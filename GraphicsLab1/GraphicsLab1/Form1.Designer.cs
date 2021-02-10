namespace GraphicsLab1
{
    partial class Form1
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
            this.XTrack = new System.Windows.Forms.TrackBar();
            this.XCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YCountLabel = new System.Windows.Forms.Label();
            this.YTrack = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.ZCountLabel = new System.Windows.Forms.Label();
            this.ZTrack = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.BCountLabel = new System.Windows.Forms.Label();
            this.BTrack = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.ACountLabel = new System.Windows.Forms.Label();
            this.ATrack = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.LCountLabel = new System.Windows.Forms.Label();
            this.LTrack = new System.Windows.Forms.TrackBar();
            this.label = new System.Windows.Forms.Label();
            this.StaturationCountLabel = new System.Windows.Forms.Label();
            this.SaturationTrack = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.LightCountLabel = new System.Windows.Forms.Label();
            this.LightTrack = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.HueCountLabel = new System.Windows.Forms.Label();
            this.HueTrack = new System.Windows.Forms.TrackBar();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.ColorInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrack)).BeginInit();
            this.ColorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // XTrack
            // 
            this.XTrack.Location = new System.Drawing.Point(26, 44);
            this.XTrack.Maximum = 255;
            this.XTrack.Name = "XTrack";
            this.XTrack.Size = new System.Drawing.Size(148, 56);
            this.XTrack.TabIndex = 0;
            this.XTrack.Tag = "x";
            this.XTrack.TickFrequency = 20;
            this.XTrack.Scroll += new System.EventHandler(this.XYZ_Scroll);
            // 
            // XCountLabel
            // 
            this.XCountLabel.AutoSize = true;
            this.XCountLabel.Location = new System.Drawing.Point(171, 48);
            this.XCountLabel.Name = "XCountLabel";
            this.XCountLabel.Size = new System.Drawing.Size(16, 17);
            this.XCountLabel.TabIndex = 1;
            this.XCountLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(99, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(99, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Y";
            // 
            // YCountLabel
            // 
            this.YCountLabel.AutoSize = true;
            this.YCountLabel.Location = new System.Drawing.Point(171, 110);
            this.YCountLabel.Name = "YCountLabel";
            this.YCountLabel.Size = new System.Drawing.Size(16, 17);
            this.YCountLabel.TabIndex = 4;
            this.YCountLabel.Text = "0";
            // 
            // YTrack
            // 
            this.YTrack.Location = new System.Drawing.Point(26, 106);
            this.YTrack.Maximum = 255;
            this.YTrack.Name = "YTrack";
            this.YTrack.Size = new System.Drawing.Size(148, 56);
            this.YTrack.TabIndex = 3;
            this.YTrack.Tag = "y";
            this.YTrack.TickFrequency = 20;
            this.YTrack.Scroll += new System.EventHandler(this.XYZ_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(99, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 8;
            this.label4.Tag = "";
            this.label4.Text = "Z";
            // 
            // ZCountLabel
            // 
            this.ZCountLabel.AutoSize = true;
            this.ZCountLabel.Location = new System.Drawing.Point(171, 172);
            this.ZCountLabel.Name = "ZCountLabel";
            this.ZCountLabel.Size = new System.Drawing.Size(16, 17);
            this.ZCountLabel.TabIndex = 7;
            this.ZCountLabel.Text = "0";
            // 
            // ZTrack
            // 
            this.ZTrack.Location = new System.Drawing.Point(26, 168);
            this.ZTrack.Maximum = 255;
            this.ZTrack.Name = "ZTrack";
            this.ZTrack.Size = new System.Drawing.Size(148, 56);
            this.ZTrack.TabIndex = 6;
            this.ZTrack.Tag = "z";
            this.ZTrack.TickFrequency = 20;
            this.ZTrack.Scroll += new System.EventHandler(this.XYZ_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(373, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "B";
            // 
            // BCountLabel
            // 
            this.BCountLabel.AutoSize = true;
            this.BCountLabel.Location = new System.Drawing.Point(445, 172);
            this.BCountLabel.Name = "BCountLabel";
            this.BCountLabel.Size = new System.Drawing.Size(16, 17);
            this.BCountLabel.TabIndex = 16;
            this.BCountLabel.Text = "0";
            // 
            // BTrack
            // 
            this.BTrack.Location = new System.Drawing.Point(300, 168);
            this.BTrack.Maximum = 256;
            this.BTrack.Name = "BTrack";
            this.BTrack.Size = new System.Drawing.Size(148, 56);
            this.BTrack.TabIndex = 15;
            this.BTrack.Tag = "b";
            this.BTrack.TickFrequency = 20;
            this.BTrack.Value = 130;
            this.BTrack.Scroll += new System.EventHandler(this.LAB_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(373, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "A";
            // 
            // ACountLabel
            // 
            this.ACountLabel.AutoSize = true;
            this.ACountLabel.Location = new System.Drawing.Point(445, 110);
            this.ACountLabel.Name = "ACountLabel";
            this.ACountLabel.Size = new System.Drawing.Size(16, 17);
            this.ACountLabel.TabIndex = 13;
            this.ACountLabel.Text = "0";
            // 
            // ATrack
            // 
            this.ATrack.Location = new System.Drawing.Point(300, 106);
            this.ATrack.Maximum = 256;
            this.ATrack.Name = "ATrack";
            this.ATrack.Size = new System.Drawing.Size(148, 56);
            this.ATrack.TabIndex = 12;
            this.ATrack.Tag = "a";
            this.ATrack.TickFrequency = 20;
            this.ATrack.Value = 130;
            this.ATrack.Scroll += new System.EventHandler(this.LAB_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(373, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "L";
            // 
            // LCountLabel
            // 
            this.LCountLabel.AutoSize = true;
            this.LCountLabel.Location = new System.Drawing.Point(445, 48);
            this.LCountLabel.Name = "LCountLabel";
            this.LCountLabel.Size = new System.Drawing.Size(16, 17);
            this.LCountLabel.TabIndex = 10;
            this.LCountLabel.Text = "0";
            // 
            // LTrack
            // 
            this.LTrack.Location = new System.Drawing.Point(300, 44);
            this.LTrack.Maximum = 255;
            this.LTrack.Name = "LTrack";
            this.LTrack.Size = new System.Drawing.Size(148, 56);
            this.LTrack.TabIndex = 9;
            this.LTrack.Tag = "l";
            this.LTrack.TickFrequency = 20;
            this.LTrack.Scroll += new System.EventHandler(this.LAB_Scroll);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(624, 148);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 17);
            this.label.TabIndex = 26;
            this.label.Text = "Saturation";
            // 
            // StaturationCountLabel
            // 
            this.StaturationCountLabel.AutoSize = true;
            this.StaturationCountLabel.Location = new System.Drawing.Point(723, 172);
            this.StaturationCountLabel.Name = "StaturationCountLabel";
            this.StaturationCountLabel.Size = new System.Drawing.Size(16, 17);
            this.StaturationCountLabel.TabIndex = 25;
            this.StaturationCountLabel.Text = "0";
            // 
            // SaturationTrack
            // 
            this.SaturationTrack.Location = new System.Drawing.Point(578, 168);
            this.SaturationTrack.Maximum = 255;
            this.SaturationTrack.Name = "SaturationTrack";
            this.SaturationTrack.Size = new System.Drawing.Size(148, 56);
            this.SaturationTrack.TabIndex = 24;
            this.SaturationTrack.Tag = "s";
            this.SaturationTrack.TickFrequency = 20;
            this.SaturationTrack.Scroll += new System.EventHandler(this.HLS_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(624, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Lightness";
            // 
            // LightCountLabel
            // 
            this.LightCountLabel.AutoSize = true;
            this.LightCountLabel.Location = new System.Drawing.Point(723, 110);
            this.LightCountLabel.Name = "LightCountLabel";
            this.LightCountLabel.Size = new System.Drawing.Size(16, 17);
            this.LightCountLabel.TabIndex = 22;
            this.LightCountLabel.Text = "0";
            // 
            // LightTrack
            // 
            this.LightTrack.Location = new System.Drawing.Point(578, 106);
            this.LightTrack.Maximum = 255;
            this.LightTrack.Name = "LightTrack";
            this.LightTrack.Size = new System.Drawing.Size(148, 56);
            this.LightTrack.TabIndex = 21;
            this.LightTrack.Tag = "l";
            this.LightTrack.TickFrequency = 20;
            this.LightTrack.Scroll += new System.EventHandler(this.HLS_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(642, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Hue";
            // 
            // HueCountLabel
            // 
            this.HueCountLabel.AutoSize = true;
            this.HueCountLabel.Location = new System.Drawing.Point(723, 48);
            this.HueCountLabel.Name = "HueCountLabel";
            this.HueCountLabel.Size = new System.Drawing.Size(16, 17);
            this.HueCountLabel.TabIndex = 19;
            this.HueCountLabel.Text = "0";
            // 
            // HueTrack
            // 
            this.HueTrack.Location = new System.Drawing.Point(578, 44);
            this.HueTrack.Maximum = 360;
            this.HueTrack.Name = "HueTrack";
            this.HueTrack.Size = new System.Drawing.Size(148, 56);
            this.HueTrack.TabIndex = 18;
            this.HueTrack.Tag = "h";
            this.HueTrack.TickFrequency = 20;
            this.HueTrack.Scroll += new System.EventHandler(this.HLS_Scroll);
            // 
            // ColorPanel
            // 
            this.ColorPanel.Controls.Add(this.ColorInfoLabel);
            this.ColorPanel.Location = new System.Drawing.Point(12, 229);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(807, 100);
            this.ColorPanel.TabIndex = 27;
            // 
            // ColorInfoLabel
            // 
            this.ColorInfoLabel.AutoSize = true;
            this.ColorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorInfoLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.ColorInfoLabel.Location = new System.Drawing.Point(130, 30);
            this.ColorInfoLabel.Name = "ColorInfoLabel";
            this.ColorInfoLabel.Size = new System.Drawing.Size(381, 32);
            this.ColorInfoLabel.TabIndex = 0;
            this.ColorInfoLabel.Text = "Нормальный цвет (0, 0, 0)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 341);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.StaturationCountLabel);
            this.Controls.Add(this.SaturationTrack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LightCountLabel);
            this.Controls.Add(this.LightTrack);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HueCountLabel);
            this.Controls.Add(this.HueTrack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BCountLabel);
            this.Controls.Add(this.BTrack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ACountLabel);
            this.Controls.Add(this.ATrack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LCountLabel);
            this.Controls.Add(this.LTrack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZCountLabel);
            this.Controls.Add(this.ZTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YCountLabel);
            this.Controls.Add(this.YTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XCountLabel);
            this.Controls.Add(this.XTrack);
            this.Name = "Form1";
            this.Text = "ColorConverter";
            ((System.ComponentModel.ISupportInitialize)(this.XTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrack)).EndInit();
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar XTrack;
        private System.Windows.Forms.Label XCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YCountLabel;
        private System.Windows.Forms.TrackBar YTrack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ZCountLabel;
        private System.Windows.Forms.TrackBar ZTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BCountLabel;
        private System.Windows.Forms.TrackBar BTrack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ACountLabel;
        private System.Windows.Forms.TrackBar ATrack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LCountLabel;
        private System.Windows.Forms.TrackBar LTrack;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label StaturationCountLabel;
        private System.Windows.Forms.TrackBar SaturationTrack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LightCountLabel;
        private System.Windows.Forms.TrackBar LightTrack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label HueCountLabel;
        private System.Windows.Forms.TrackBar HueTrack;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Label ColorInfoLabel;
    }
}

