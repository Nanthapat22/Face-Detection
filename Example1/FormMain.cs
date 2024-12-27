using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace Example1
{
    public partial class FormMain : Form
    {
        private VideoCapture _capture = null;
        private Mat _frame = new Mat(); // Mat สำหรับเก็บเฟรมจากกล้อง
        private bool IsConnect = true;
        private bool isCapturing = true; // Track connection state

        CascadeClassifier _cascadeClassifier = new CascadeClassifier(@"D:\New folder 3\Face Detection 6510301020\haarcascade_frontalface_default.xml");

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture == null || _capture.Ptr == IntPtr.Zero) return;

            try
            {
                _capture.Retrieve(_frame);
                if (!_frame.IsEmpty)
                {
                    using (var imageFrame = _frame.ToImage<Bgr, Byte>())
                    {
                        using (var grayFrame = imageFrame.Convert<Gray, byte>())
                        {
                            var faces = _cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 10);
                            foreach (var face in faces)
                            {
                                imageFrame.Draw(face, new Bgr(Color.MistyRose), 3);
                            }

                            Invoke(new Action(() =>
                            {
                                imageBox1.Image = imageFrame;

                                if (faces.Length > 0)
                                {
                                    var croppedFace = new Mat(_frame, faces[0]);
                                    imageBox2.Image = croppedFace.ToImage<Gray, Byte>();
                                }
                                else
                                {
                                    imageBox2.Image = null;
                                }
                            }));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing frame: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeCapture()
        {
            try
            {
                if (_capture == null)
                {
                    _capture = new VideoCapture();
                    _capture.ImageGrabbed += ProcessFrame;
                    _frame = new Mat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing camera: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReleaseCapture()
        {
            try
            {
                if (_capture != null)
                {
                    _capture.Pause();
                    _capture.Dispose();
                    _capture = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error releasing camera: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            IsConnect = !IsConnect;
            if (IsConnect)
            {
                InitializeCapture();
                tbCarmera.Text = "Connected";
                tbCarmera.BackColor = Color.Green;
                buttonConnect.Text = "Disconnect";
                buttonStsrt.Enabled = true;
            }
            else
            {
                ReleaseCapture();
                tbCarmera.Text = "Disconnected";
                tbCarmera.BackColor = Color.Red;
                buttonConnect.Text = "Connect";
                buttonStsrt.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isCapturing = !isCapturing;
            if (isCapturing)
            {
                buttonStsrt.Text = "Pause";
                textBox2.Text = "Record";
                textBox2.BackColor = Color.Green;
                buttonConnect.Enabled = false;
                _capture?.Start();
            }
            else
            {
                buttonStsrt.Text = "Start";
                textBox2.Text = "No record";
                textBox2.BackColor = Color.Red;
                buttonConnect.Enabled = true;
                _capture?.Pause();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่?", "ยืนยันการปิด", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            ReleaseCapture();
        }
    }
}