namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartWeather = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCurrentStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGetForecast = new System.Windows.Forms.Button();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSunsetTime = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSunrsieTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTempToday = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeather)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.clouds;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.chartWeather);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(408, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 614);
            this.panel3.TabIndex = 8;
            // 
            // chartWeather
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeather.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeather.Legends.Add(legend1);
            this.chartWeather.Location = new System.Drawing.Point(3, 83);
            this.chartWeather.Name = "chartWeather";
            this.chartWeather.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartWeather.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Navy,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWeather.Series.Add(series1);
            this.chartWeather.Size = new System.Drawing.Size(920, 500);
            this.chartWeather.TabIndex = 0;
            this.chartWeather.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "7 Hour Forecast";
            this.chartWeather.Titles.Add(title1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Next 7 Days";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.clouds;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelCurrentStatus);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonGetForecast);
            this.panel2.Controls.Add(this.comboBoxCities);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1323, 77);
            this.panel2.TabIndex = 7;
            // 
            // labelCurrentStatus
            // 
            this.labelCurrentStatus.AutoSize = true;
            this.labelCurrentStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentStatus.Location = new System.Drawing.Point(758, 24);
            this.labelCurrentStatus.Name = "labelCurrentStatus";
            this.labelCurrentStatus.Size = new System.Drawing.Size(0, 31);
            this.labelCurrentStatus.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Status:";
            // 
            // buttonGetForecast
            // 
            this.buttonGetForecast.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetForecast.ForeColor = System.Drawing.Color.Black;
            this.buttonGetForecast.Location = new System.Drawing.Point(285, 16);
            this.buttonGetForecast.Name = "buttonGetForecast";
            this.buttonGetForecast.Size = new System.Drawing.Size(189, 39);
            this.buttonGetForecast.TabIndex = 3;
            this.buttonGetForecast.Text = "Get Forecast";
            this.buttonGetForecast.UseVisualStyleBackColor = false;
            this.buttonGetForecast.Click += new System.EventHandler(this.buttonGetForecast_Click);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(new object[] {
            "Brasov",
            "Bucharest",
            "Cluj",
            "Iasi",
            "TImisoara"});
            this.comboBoxCities.Location = new System.Drawing.Point(23, 16);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(239, 39);
            this.comboBoxCities.Sorted = true;
            this.comboBoxCities.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.clouds;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(15, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 614);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "More data about today";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel8.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.rain;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.labelHumidity);
            this.panel8.Location = new System.Drawing.Point(3, 530);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(377, 77);
            this.panel8.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "Humidity:";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidity.Location = new System.Drawing.Point(286, 36);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(52, 31);
            this.labelHumidity.TabIndex = 8;
            this.labelHumidity.Text = "0.0";
            this.labelHumidity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel7.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.clouds;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.labelWindSpeed);
            this.panel7.Location = new System.Drawing.Point(3, 419);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(377, 105);
            this.panel7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Wind Speed:";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindSpeed.Location = new System.Drawing.Point(245, 64);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(142, 31);
            this.labelWindSpeed.TabIndex = 8;
            this.labelWindSpeed.Text = "0.00 KM/H";
            this.labelWindSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sunset;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.labelSunsetTime);
            this.panel6.Location = new System.Drawing.Point(3, 308);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(377, 105);
            this.panel6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Bisque;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunset Time:";
            // 
            // labelSunsetTime
            // 
            this.labelSunsetTime.AutoSize = true;
            this.labelSunsetTime.BackColor = System.Drawing.Color.Bisque;
            this.labelSunsetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunsetTime.Location = new System.Drawing.Point(238, 65);
            this.labelSunsetTime.Name = "labelSunsetTime";
            this.labelSunsetTime.Size = new System.Drawing.Size(120, 31);
            this.labelSunsetTime.TabIndex = 8;
            this.labelSunsetTime.Text = "00:00:00";
            this.labelSunsetTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sunrise;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.labelSunrsieTime);
            this.panel5.Location = new System.Drawing.Point(3, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(377, 105);
            this.panel5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sunrise Time:";
            // 
            // labelSunrsieTime
            // 
            this.labelSunrsieTime.AutoSize = true;
            this.labelSunrsieTime.BackColor = System.Drawing.Color.Bisque;
            this.labelSunrsieTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunrsieTime.Location = new System.Drawing.Point(238, 62);
            this.labelSunrsieTime.Name = "labelSunrsieTime";
            this.labelSunrsieTime.Size = new System.Drawing.Size(120, 31);
            this.labelSunrsieTime.TabIndex = 6;
            this.labelSunrsieTime.Text = "00:00:00";
            this.labelSunrsieTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.clouds;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.labelTempToday);
            this.panel4.Location = new System.Drawing.Point(3, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 105);
            this.panel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Temperature:";
            // 
            // labelTempToday
            // 
            this.labelTempToday.AutoSize = true;
            this.labelTempToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempToday.Location = new System.Drawing.Point(279, 64);
            this.labelTempToday.Name = "labelTempToday";
            this.labelTempToday.Size = new System.Drawing.Size(79, 31);
            this.labelTempToday.TabIndex = 4;
            this.labelTempToday.Text = "0.0 C";
            this.labelTempToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 721);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1366, 760);
            this.MinimumSize = new System.Drawing.Size(1366, 760);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeather)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTempToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Button buttonGetForecast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSunrsieTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelSunsetTime;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label label7;
    }
}

