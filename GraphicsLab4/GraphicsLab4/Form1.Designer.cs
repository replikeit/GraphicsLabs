
namespace GraphicsLab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LinePicture = new System.Windows.Forms.PictureBox();
            this.X0TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Y0TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.X1TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Y1TextBox = new System.Windows.Forms.TextBox();
            this.BresenhamMethodButton = new System.Windows.Forms.Button();
            this.BresenhamCircleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.DDAMethodButton = new System.Windows.Forms.Button();
            this.StepMethodButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LinePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LinePicture
            // 
            this.LinePicture.BackColor = System.Drawing.Color.White;
            this.LinePicture.Location = new System.Drawing.Point(12, 12);
            this.LinePicture.Name = "LinePicture";
            this.LinePicture.Size = new System.Drawing.Size(556, 426);
            this.LinePicture.TabIndex = 1;
            this.LinePicture.TabStop = false;
            // 
            // X0TextBox
            // 
            this.X0TextBox.Location = new System.Drawing.Point(574, 30);
            this.X0TextBox.Name = "X0TextBox";
            this.X0TextBox.Size = new System.Drawing.Size(100, 22);
            this.X0TextBox.TabIndex = 2;
            this.X0TextBox.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "x0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "y0";
            // 
            // Y0TextBox
            // 
            this.Y0TextBox.Location = new System.Drawing.Point(682, 30);
            this.Y0TextBox.Name = "Y0TextBox";
            this.Y0TextBox.Size = new System.Drawing.Size(100, 22);
            this.Y0TextBox.TabIndex = 4;
            this.Y0TextBox.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "x1";
            // 
            // X1TextBox
            // 
            this.X1TextBox.Location = new System.Drawing.Point(574, 77);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.Size = new System.Drawing.Size(100, 22);
            this.X1TextBox.TabIndex = 6;
            this.X1TextBox.Text = "540";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "y1";
            // 
            // Y1TextBox
            // 
            this.Y1TextBox.Location = new System.Drawing.Point(682, 77);
            this.Y1TextBox.Name = "Y1TextBox";
            this.Y1TextBox.Size = new System.Drawing.Size(100, 22);
            this.Y1TextBox.TabIndex = 8;
            this.Y1TextBox.Text = "400";
            // 
            // BresenhamMethodButton
            // 
            this.BresenhamMethodButton.Location = new System.Drawing.Point(574, 333);
            this.BresenhamMethodButton.Name = "BresenhamMethodButton";
            this.BresenhamMethodButton.Size = new System.Drawing.Size(208, 29);
            this.BresenhamMethodButton.TabIndex = 10;
            this.BresenhamMethodButton.Text = "Bresenham";
            this.BresenhamMethodButton.UseVisualStyleBackColor = true;
            this.BresenhamMethodButton.Click += new System.EventHandler(this.BresenhamMethodButton_Click);
            // 
            // BresenhamCircleButton
            // 
            this.BresenhamCircleButton.Location = new System.Drawing.Point(574, 409);
            this.BresenhamCircleButton.Name = "BresenhamCircleButton";
            this.BresenhamCircleButton.Size = new System.Drawing.Size(208, 29);
            this.BresenhamCircleButton.TabIndex = 11;
            this.BresenhamCircleButton.Text = "Bresenham Circle";
            this.BresenhamCircleButton.UseVisualStyleBackColor = true;
            this.BresenhamCircleButton.Click += new System.EventHandler(this.BresenhamCircleButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Radius";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(632, 386);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 22);
            this.RadiusTextBox.TabIndex = 12;
            this.RadiusTextBox.Text = "50";
            // 
            // DDAMethodButton
            // 
            this.DDAMethodButton.Location = new System.Drawing.Point(574, 298);
            this.DDAMethodButton.Name = "DDAMethodButton";
            this.DDAMethodButton.Size = new System.Drawing.Size(208, 29);
            this.DDAMethodButton.TabIndex = 14;
            this.DDAMethodButton.Text = "DDA Method";
            this.DDAMethodButton.UseVisualStyleBackColor = true;
            this.DDAMethodButton.Click += new System.EventHandler(this.DDAMethodButton_Click);
            // 
            // StepMethodButton
            // 
            this.StepMethodButton.Location = new System.Drawing.Point(574, 263);
            this.StepMethodButton.Name = "StepMethodButton";
            this.StepMethodButton.Size = new System.Drawing.Size(208, 29);
            this.StepMethodButton.TabIndex = 15;
            this.StepMethodButton.Text = "Step Method";
            this.StepMethodButton.UseVisualStyleBackColor = true;
            this.StepMethodButton.Click += new System.EventHandler(this.StepMethodButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.StepMethodButton);
            this.Controls.Add(this.DDAMethodButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.BresenhamCircleButton);
            this.Controls.Add(this.BresenhamMethodButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.X1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Y0TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X0TextBox);
            this.Controls.Add(this.LinePicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LinePicture;
        private System.Windows.Forms.TextBox X0TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Y0TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X1TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y1TextBox;
        private System.Windows.Forms.Button BresenhamMethodButton;
        private System.Windows.Forms.Button BresenhamCircleButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Button DDAMethodButton;
        private System.Windows.Forms.Button StepMethodButton;
    }
}

