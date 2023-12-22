namespace PBOApp
{
    partial class weather
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
            this.TbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_condition = new System.Windows.Forms.Label();
            this.lab_detail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCity
            // 
            this.TbCity.Location = new System.Drawing.Point(87, 50);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(206, 20);
            this.TbCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "City";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(299, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_condition
            // 
            this.lab_condition.AutoSize = true;
            this.lab_condition.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lab_condition.Location = new System.Drawing.Point(57, 160);
            this.lab_condition.Name = "lab_condition";
            this.lab_condition.Size = new System.Drawing.Size(84, 18);
            this.lab_condition.TabIndex = 3;
            this.lab_condition.Text = "Conditions";
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lab_detail.Location = new System.Drawing.Point(57, 198);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(56, 18);
            this.lab_detail.TabIndex = 4;
            this.lab_detail.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(57, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(57, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sunset";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lab_sunrise.Location = new System.Drawing.Point(152, 243);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(33, 18);
            this.lab_sunrise.TabIndex = 7;
            this.lab_sunrise.Text = "N/A";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lab_sunset.Location = new System.Drawing.Point(152, 278);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(33, 18);
            this.lab_sunset.TabIndex = 8;
            this.lab_sunset.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(244, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "WindSpeed";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lab_windspeed.Location = new System.Drawing.Point(358, 160);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(33, 18);
            this.lab_windspeed.TabIndex = 10;
            this.lab_windspeed.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(244, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pressure";
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lab_pressure.Location = new System.Drawing.Point(358, 198);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(33, 18);
            this.lab_pressure.TabIndex = 12;
            this.lab_pressure.Text = "N/A";
            // 
            // pic_icon
            // 
            this.pic_icon.Location = new System.Drawing.Point(54, 89);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(100, 50);
            this.pic_icon.TabIndex = 13;
            this.pic_icon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please type your own city!";
            // 
            // weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lab_windspeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_detail);
            this.Controls.Add(this.lab_condition);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCity);
            this.Name = "weather";
            this.Text = "weather";
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lab_condition;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label label2;
    }
}