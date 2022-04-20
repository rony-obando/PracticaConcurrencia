
namespace WeatherConcurrencyApp
{
    partial class WeatherPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWeather = new System.Windows.Forms.Label();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(3, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(313, 59);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemperature.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(3, 59);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(313, 59);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "30";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTemperature, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWeather, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 138);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(3, 118);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(313, 20);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "lblWeather";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpContent
            // 
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpContent.Location = new System.Drawing.Point(0, 144);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(319, 407);
            this.flpContent.TabIndex = 3;
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(319, 551);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
    }
}
