namespace Example1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFlipVer = new System.Windows.Forms.Button();
            this.buttonFlipHor = new System.Windows.Forms.Button();
            this.buttonStsrt = new System.Windows.Forms.Button();
            this.tbCarmera = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.statusLabalDate = new System.Windows.Forms.Label();
            this.statusLabelClock = new System.Windows.Forms.Label();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(565, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // imageBox1
            // 
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.Location = new System.Drawing.Point(18, 26);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(540, 289);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConnect.Location = new System.Drawing.Point(54, 26);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(147, 109);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonFlipVer);
            this.groupBox2.Controls.Add(this.buttonFlipHor);
            this.groupBox2.Controls.Add(this.buttonStsrt);
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Location = new System.Drawing.Point(7, 360);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(880, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tool";
            // 
            // buttonFlipVer
            // 
            this.buttonFlipVer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFlipVer.Location = new System.Drawing.Point(560, 36);
            this.buttonFlipVer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFlipVer.Name = "buttonFlipVer";
            this.buttonFlipVer.Size = new System.Drawing.Size(137, 90);
            this.buttonFlipVer.TabIndex = 5;
            this.buttonFlipVer.Text = "FlipVer";
            this.buttonFlipVer.UseVisualStyleBackColor = true;
            this.buttonFlipVer.Click += new System.EventHandler(this.buttonFlipVer_Click);
            // 
            // buttonFlipHor
            // 
            this.buttonFlipHor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFlipHor.Location = new System.Drawing.Point(400, 35);
            this.buttonFlipHor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFlipHor.Name = "buttonFlipHor";
            this.buttonFlipHor.Size = new System.Drawing.Size(137, 90);
            this.buttonFlipHor.TabIndex = 4;
            this.buttonFlipHor.Text = "FlipHor";
            this.buttonFlipHor.UseVisualStyleBackColor = true;
            this.buttonFlipHor.Click += new System.EventHandler(this.buttonFlipHor_Click);
            // 
            // buttonStsrt
            // 
            this.buttonStsrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonStsrt.Location = new System.Drawing.Point(208, 28);
            this.buttonStsrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStsrt.Name = "buttonStsrt";
            this.buttonStsrt.Size = new System.Drawing.Size(165, 109);
            this.buttonStsrt.TabIndex = 6;
            this.buttonStsrt.Text = "Stsrt";
            this.buttonStsrt.UseVisualStyleBackColor = true;
            this.buttonStsrt.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbCarmera
            // 
            this.tbCarmera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCarmera.Location = new System.Drawing.Point(14, 520);
            this.tbCarmera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCarmera.Name = "tbCarmera";
            this.tbCarmera.Size = new System.Drawing.Size(151, 26);
            this.tbCarmera.TabIndex = 4;
            this.tbCarmera.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 36);
            this.contextMenuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(192, 520);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // statusLabalDate
            // 
            this.statusLabalDate.AutoSize = true;
            this.statusLabalDate.Location = new System.Drawing.Point(784, 524);
            this.statusLabalDate.Name = "statusLabalDate";
            this.statusLabalDate.Size = new System.Drawing.Size(37, 20);
            this.statusLabalDate.TabIndex = 8;
            this.statusLabalDate.Text = "Day";
            // 
            // statusLabelClock
            // 
            this.statusLabelClock.AutoSize = true;
            this.statusLabelClock.Location = new System.Drawing.Point(700, 524);
            this.statusLabelClock.Name = "statusLabelClock";
            this.statusLabelClock.Size = new System.Drawing.Size(43, 20);
            this.statusLabelClock.TabIndex = 9;
            this.statusLabelClock.Text = "Time";
            // 
            // imageBox2
            // 
            this.imageBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox2.Location = new System.Drawing.Point(614, 72);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(253, 222);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.statusLabelClock);
            this.Controls.Add(this.statusLabalDate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbCarmera);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFlipHor;
        private System.Windows.Forms.Button buttonFlipVer;
        private System.Windows.Forms.TextBox tbCarmera;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonStsrt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label statusLabalDate;
        private System.Windows.Forms.Label statusLabelClock;
        private Emgu.CV.UI.ImageBox imageBox2;
    }
}

