
namespace GraphicsLab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SrcPictureBox = new System.Windows.Forms.PictureBox();
            this.DestPictureBox = new System.Windows.Forms.PictureBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.GaussianMethodButton = new System.Windows.Forms.Button();
            this.NegativeButton = new System.Windows.Forms.Button();
            this.ContrastButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.OtsuMethodButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MethodNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SrcPictureBox
            // 
            this.SrcPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SrcPictureBox.Location = new System.Drawing.Point(12, 174);
            this.SrcPictureBox.Name = "SrcPictureBox";
            this.SrcPictureBox.Size = new System.Drawing.Size(640, 400);
            this.SrcPictureBox.TabIndex = 0;
            this.SrcPictureBox.TabStop = false;
            // 
            // DestPictureBox
            // 
            this.DestPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DestPictureBox.Location = new System.Drawing.Point(703, 174);
            this.DestPictureBox.Name = "DestPictureBox";
            this.DestPictureBox.Size = new System.Drawing.Size(640, 400);
            this.DestPictureBox.TabIndex = 1;
            this.DestPictureBox.TabStop = false;
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(12, 63);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(374, 27);
            this.PathTextBox.TabIndex = 2;
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(410, 61);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(94, 29);
            this.UploadPictureButton.TabIndex = 3;
            this.UploadPictureButton.Text = "Upload";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // GaussianMethodButton
            // 
            this.GaussianMethodButton.Enabled = false;
            this.GaussianMethodButton.Location = new System.Drawing.Point(521, 12);
            this.GaussianMethodButton.Name = "GaussianMethodButton";
            this.GaussianMethodButton.Size = new System.Drawing.Size(131, 29);
            this.GaussianMethodButton.TabIndex = 4;
            this.GaussianMethodButton.Text = "Adaptive TH";
            this.GaussianMethodButton.UseVisualStyleBackColor = true;
            this.GaussianMethodButton.Click += new System.EventHandler(this.GaussianMethodButton_Click);
            // 
            // NegativeButton
            // 
            this.NegativeButton.Enabled = false;
            this.NegativeButton.Location = new System.Drawing.Point(521, 47);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(131, 29);
            this.NegativeButton.TabIndex = 5;
            this.NegativeButton.Text = "Negative";
            this.NegativeButton.UseVisualStyleBackColor = true;
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // ContrastButton
            // 
            this.ContrastButton.Enabled = false;
            this.ContrastButton.Location = new System.Drawing.Point(521, 82);
            this.ContrastButton.Name = "ContrastButton";
            this.ContrastButton.Size = new System.Drawing.Size(131, 29);
            this.ContrastButton.TabIndex = 6;
            this.ContrastButton.Text = "Contrast";
            this.ContrastButton.UseVisualStyleBackColor = true;
            this.ContrastButton.Click += new System.EventHandler(this.ContrastButton_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.Enabled = false;
            this.TriangleButton.Location = new System.Drawing.Point(658, 12);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(130, 29);
            this.TriangleButton.TabIndex = 7;
            this.TriangleButton.Text = "Triangle";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // OtsuMethodButton
            // 
            this.OtsuMethodButton.Enabled = false;
            this.OtsuMethodButton.Location = new System.Drawing.Point(658, 47);
            this.OtsuMethodButton.Name = "OtsuMethodButton";
            this.OtsuMethodButton.Size = new System.Drawing.Size(130, 29);
            this.OtsuMethodButton.TabIndex = 8;
            this.OtsuMethodButton.Text = "Otsu";
            this.OtsuMethodButton.UseVisualStyleBackColor = true;
            this.OtsuMethodButton.Click += new System.EventHandler(this.OtsuMethodButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(258, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "Source";
            // 
            // MethodNameLabel
            // 
            this.MethodNameLabel.AutoSize = true;
            this.MethodNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MethodNameLabel.Location = new System.Drawing.Point(991, 130);
            this.MethodNameLabel.Name = "MethodNameLabel";
            this.MethodNameLabel.Size = new System.Drawing.Size(0, 41);
            this.MethodNameLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 586);
            this.Controls.Add(this.MethodNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OtsuMethodButton);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.ContrastButton);
            this.Controls.Add(this.NegativeButton);
            this.Controls.Add(this.GaussianMethodButton);
            this.Controls.Add(this.UploadPictureButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.DestPictureBox);
            this.Controls.Add(this.SrcPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SrcPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SrcPictureBox;
        private System.Windows.Forms.PictureBox DestPictureBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button UploadPictureButton;
        private System.Windows.Forms.Button GaussianMethodButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ContrastButton;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button OtsuMethodButton;
        private System.Windows.Forms.Button NegativeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MethodNameLabel;
    }
}

