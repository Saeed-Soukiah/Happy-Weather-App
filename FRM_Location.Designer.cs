namespace Weather_App
{
    partial class FRM_Location
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
            this.Locations_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Select_Your_Location_Label = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Locations_Combo_Box
            // 
            this.Locations_Combo_Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Locations_Combo_Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Locations_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locations_Combo_Box.FormattingEnabled = true;
            this.Locations_Combo_Box.Location = new System.Drawing.Point(80, 82);
            this.Locations_Combo_Box.Name = "Locations_Combo_Box";
            this.Locations_Combo_Box.Size = new System.Drawing.Size(335, 37);
            this.Locations_Combo_Box.TabIndex = 0;
            this.Locations_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Locations_Combo_Box_SelectedIndexChanged);
            // 
            // Select_Your_Location_Label
            // 
            this.Select_Your_Location_Label.AutoSize = true;
            this.Select_Your_Location_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Your_Location_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Select_Your_Location_Label.Location = new System.Drawing.Point(77, 25);
            this.Select_Your_Location_Label.Name = "Select_Your_Location_Label";
            this.Select_Your_Location_Label.Size = new System.Drawing.Size(192, 25);
            this.Select_Your_Location_Label.TabIndex = 1;
            this.Select_Your_Location_Label.Text = "Select Your Location";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(80, 139);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(335, 37);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // FRM_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(498, 203);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Select_Your_Location_Label);
            this.Controls.Add(this.Locations_Combo_Box);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Location";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Location";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_Location_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Locations_Combo_Box;
        private System.Windows.Forms.Label Select_Your_Location_Label;
        private System.Windows.Forms.Button Save_Button;
    }
}