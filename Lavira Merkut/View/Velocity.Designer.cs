
namespace Lavira_Merkut.View
{
    partial class Velocity
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_velocity_container = new System.Windows.Forms.TableLayoutPanel();
            this.chart_velocity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_velocity_Vz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_velocity_Vx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_velocity_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_velocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_velocity_Vz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_velocity_Vx)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_velocity_container
            // 
            this.panel_velocity_container.ColumnCount = 2;
            this.panel_velocity_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_velocity_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_velocity_container.Controls.Add(this.chart_velocity, 0, 0);
            this.panel_velocity_container.Controls.Add(this.chart_velocity_Vz, 0, 1);
            this.panel_velocity_container.Controls.Add(this.chart_velocity_Vx, 1, 1);
            this.panel_velocity_container.Controls.Add(this.textBox1, 1, 0);
            this.panel_velocity_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_velocity_container.Location = new System.Drawing.Point(0, 0);
            this.panel_velocity_container.Name = "panel_velocity_container";
            this.panel_velocity_container.RowCount = 2;
            this.panel_velocity_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_velocity_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_velocity_container.Size = new System.Drawing.Size(1216, 759);
            this.panel_velocity_container.TabIndex = 0;
            // 
            // chart_velocity
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_velocity.ChartAreas.Add(chartArea1);
            this.chart_velocity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_velocity.Legends.Add(legend1);
            this.chart_velocity.Location = new System.Drawing.Point(3, 3);
            this.chart_velocity.Name = "chart_velocity";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Velocity";
            this.chart_velocity.Series.Add(series1);
            this.chart_velocity.Size = new System.Drawing.Size(602, 373);
            this.chart_velocity.TabIndex = 0;
            this.chart_velocity.Text = "chart1";
            this.chart_velocity.Click += new System.EventHandler(this.chart_velocity_Click);
            // 
            // chart_velocity_Vz
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_velocity_Vz.ChartAreas.Add(chartArea2);
            this.chart_velocity_Vz.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_velocity_Vz.Legends.Add(legend2);
            this.chart_velocity_Vz.Location = new System.Drawing.Point(3, 382);
            this.chart_velocity_Vz.Name = "chart_velocity_Vz";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Velocity Z";
            this.chart_velocity_Vz.Series.Add(series2);
            this.chart_velocity_Vz.Size = new System.Drawing.Size(602, 374);
            this.chart_velocity_Vz.TabIndex = 1;
            this.chart_velocity_Vz.Text = "chart1";
            this.chart_velocity_Vz.Click += new System.EventHandler(this.chart_velocity_Vz_Click);
            // 
            // chart_velocity_Vx
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_velocity_Vx.ChartAreas.Add(chartArea3);
            this.chart_velocity_Vx.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_velocity_Vx.Legends.Add(legend3);
            this.chart_velocity_Vx.Location = new System.Drawing.Point(611, 382);
            this.chart_velocity_Vx.Name = "chart_velocity_Vx";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Velocity X";
            this.chart_velocity_Vx.Series.Add(series3);
            this.chart_velocity_Vx.Size = new System.Drawing.Size(602, 374);
            this.chart_velocity_Vx.TabIndex = 2;
            this.chart_velocity_Vx.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(611, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(602, 373);
            this.textBox1.TabIndex = 3;
            // 
            // Velocity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 759);
            this.Controls.Add(this.panel_velocity_container);
            this.Name = "Velocity";
            this.Text = "Velocity";
            this.panel_velocity_container.ResumeLayout(false);
            this.panel_velocity_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_velocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_velocity_Vz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_velocity_Vx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_velocity_container;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_velocity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_velocity_Vz;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_velocity_Vx;
        private System.Windows.Forms.TextBox textBox1;
    }
}