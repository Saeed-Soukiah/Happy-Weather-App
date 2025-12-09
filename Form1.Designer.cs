namespace Weather_App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Discription_Label = new System.Windows.Forms.Label();
            this.City_Name_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Tempereture_Degree_Label = new System.Windows.Forms.Label();
            this.Tempereture_Label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Wind_Degree_Label = new System.Windows.Forms.Label();
            this.Wind_Label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Humidity_Degree_Label = new System.Windows.Forms.Label();
            this.Humidity_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 43);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(615, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Choose City";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(7, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Happy Weather App";
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit_Button.Location = new System.Drawing.Point(742, 2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 40);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Discription_Label);
            this.panel2.Controls.Add(this.City_Name_Label);
            this.panel2.Location = new System.Drawing.Point(146, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 263);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Weather_App.Properties.Resources.Edit_the_previously_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Discription_Label
            // 
            this.Discription_Label.AutoSize = true;
            this.Discription_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discription_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Discription_Label.Location = new System.Drawing.Point(162, 223);
            this.Discription_Label.Name = "Discription_Label";
            this.Discription_Label.Size = new System.Drawing.Size(155, 32);
            this.Discription_Label.TabIndex = 1;
            this.Discription_Label.Text = " Discription";
            // 
            // City_Name_Label
            // 
            this.City_Name_Label.AutoSize = true;
            this.City_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Name_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.City_Name_Label.Location = new System.Drawing.Point(162, 10);
            this.City_Name_Label.Name = "City_Name_Label";
            this.City_Name_Label.Size = new System.Drawing.Size(145, 32);
            this.City_Name_Label.TabIndex = 0;
            this.City_Name_Label.Text = "City Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.Tempereture_Degree_Label);
            this.panel3.Controls.Add(this.Tempereture_Label);
            this.panel3.Location = new System.Drawing.Point(12, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 182);
            this.panel3.TabIndex = 3;
            // 
            // Tempereture_Degree_Label
            // 
            this.Tempereture_Degree_Label.AutoSize = true;
            this.Tempereture_Degree_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tempereture_Degree_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tempereture_Degree_Label.Location = new System.Drawing.Point(105, 112);
            this.Tempereture_Degree_Label.Name = "Tempereture_Degree_Label";
            this.Tempereture_Degree_Label.Size = new System.Drawing.Size(49, 36);
            this.Tempereture_Degree_Label.TabIndex = 1;
            this.Tempereture_Degree_Label.Text = "35";
            // 
            // Tempereture_Label
            // 
            this.Tempereture_Label.AutoSize = true;
            this.Tempereture_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tempereture_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tempereture_Label.Location = new System.Drawing.Point(49, 19);
            this.Tempereture_Label.Name = "Tempereture_Label";
            this.Tempereture_Label.Size = new System.Drawing.Size(176, 32);
            this.Tempereture_Label.TabIndex = 0;
            this.Tempereture_Label.Text = "Tempereture";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.Wind_Degree_Label);
            this.panel4.Controls.Add(this.Wind_Label);
            this.panel4.Location = new System.Drawing.Point(283, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 182);
            this.panel4.TabIndex = 4;
            // 
            // Wind_Degree_Label
            // 
            this.Wind_Degree_Label.AutoSize = true;
            this.Wind_Degree_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wind_Degree_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Wind_Degree_Label.Location = new System.Drawing.Point(105, 112);
            this.Wind_Degree_Label.Name = "Wind_Degree_Label";
            this.Wind_Degree_Label.Size = new System.Drawing.Size(49, 36);
            this.Wind_Degree_Label.TabIndex = 1;
            this.Wind_Degree_Label.Text = "35";
            // 
            // Wind_Label
            // 
            this.Wind_Label.AutoSize = true;
            this.Wind_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wind_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Wind_Label.Location = new System.Drawing.Point(93, 19);
            this.Wind_Label.Name = "Wind_Label";
            this.Wind_Label.Size = new System.Drawing.Size(79, 32);
            this.Wind_Label.TabIndex = 0;
            this.Wind_Label.Text = "Wind";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.Humidity_Degree_Label);
            this.panel5.Controls.Add(this.Humidity_Label);
            this.panel5.Location = new System.Drawing.Point(553, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 182);
            this.panel5.TabIndex = 4;
            // 
            // Humidity_Degree_Label
            // 
            this.Humidity_Degree_Label.AutoSize = true;
            this.Humidity_Degree_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity_Degree_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Humidity_Degree_Label.Location = new System.Drawing.Point(115, 112);
            this.Humidity_Degree_Label.Name = "Humidity_Degree_Label";
            this.Humidity_Degree_Label.Size = new System.Drawing.Size(49, 36);
            this.Humidity_Degree_Label.TabIndex = 1;
            this.Humidity_Degree_Label.Text = "35";
            // 
            // Humidity_Label
            // 
            this.Humidity_Label.AutoSize = true;
            this.Humidity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Humidity_Label.Location = new System.Drawing.Point(79, 19);
            this.Humidity_Label.Name = "Humidity_Label";
            this.Humidity_Label.Size = new System.Drawing.Size(125, 32);
            this.Humidity_Label.TabIndex = 0;
            this.Humidity_Label.Text = "Humidity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_App.Properties.Resources.Edit_the_existing_sp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(829, 547);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label City_Name_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Discription_Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Tempereture_Degree_Label;
        private System.Windows.Forms.Label Tempereture_Label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Wind_Degree_Label;
        private System.Windows.Forms.Label Wind_Label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Humidity_Degree_Label;
        private System.Windows.Forms.Label Humidity_Label;
        private System.Windows.Forms.Button button1;
    }
}

