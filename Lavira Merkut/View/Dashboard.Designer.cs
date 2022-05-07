
namespace Lavira_Merkut.View
{
    partial class Dashboard
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
            this.panel_container = new System.Windows.Forms.TableLayoutPanel();
            this.chart_dashboard_altitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_dashboard_stateContainer = new System.Windows.Forms.TableLayoutPanel();
            this.label_stateText = new System.Windows.Forms.Label();
            this.label_dashboard_checkText = new System.Windows.Forms.Label();
            this.textBox_dashboard_stateText = new System.Windows.Forms.TextBox();
            this.textBox_dashboard_checkText = new System.Windows.Forms.TextBox();
            this.panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_dashboard_altitude)).BeginInit();
            this.panel_dashboard_stateContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.ColumnCount = 2;
            this.panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_container.Controls.Add(this.chart_dashboard_altitude, 0, 0);
            this.panel_container.Controls.Add(this.panel_dashboard_stateContainer, 0, 1);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.RowCount = 2;
            this.panel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_container.Size = new System.Drawing.Size(1181, 655);
            this.panel_container.TabIndex = 0;
            // 
            // chart_dashboard_altitude
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_dashboard_altitude.ChartAreas.Add(chartArea1);
            this.chart_dashboard_altitude.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart_dashboard_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_dashboard_altitude.Legends.Add(legend1);
            this.chart_dashboard_altitude.Location = new System.Drawing.Point(3, 3);
            this.chart_dashboard_altitude.Name = "chart_dashboard_altitude";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_dashboard_altitude.Series.Add(series1);
            this.chart_dashboard_altitude.Size = new System.Drawing.Size(584, 321);
            this.chart_dashboard_altitude.TabIndex = 0;
            this.chart_dashboard_altitude.Text = "chart1";
            this.chart_dashboard_altitude.Click += new System.EventHandler(this.chart_dashboard_altitude_Click);
            // 
            // panel_dashboard_stateContainer
            // 
            this.panel_dashboard_stateContainer.BackColor = System.Drawing.Color.Navy;
            this.panel_dashboard_stateContainer.ColumnCount = 2;
            this.panel_dashboard_stateContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_dashboard_stateContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_dashboard_stateContainer.Controls.Add(this.label_dashboard_checkText, 1, 0);
            this.panel_dashboard_stateContainer.Controls.Add(this.label_stateText, 0, 0);
            this.panel_dashboard_stateContainer.Controls.Add(this.textBox_dashboard_stateText, 0, 1);
            this.panel_dashboard_stateContainer.Controls.Add(this.textBox_dashboard_checkText, 1, 1);
            this.panel_dashboard_stateContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dashboard_stateContainer.Location = new System.Drawing.Point(3, 330);
            this.panel_dashboard_stateContainer.Name = "panel_dashboard_stateContainer";
            this.panel_dashboard_stateContainer.RowCount = 2;
            this.panel_dashboard_stateContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_dashboard_stateContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.panel_dashboard_stateContainer.Size = new System.Drawing.Size(584, 322);
            this.panel_dashboard_stateContainer.TabIndex = 1;
            // 
            // label_stateText
            // 
            this.label_stateText.AutoSize = true;
            this.label_stateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_stateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_stateText.ForeColor = System.Drawing.Color.White;
            this.label_stateText.Location = new System.Drawing.Point(3, 0);
            this.label_stateText.Name = "label_stateText";
            this.label_stateText.Size = new System.Drawing.Size(286, 32);
            this.label_stateText.TabIndex = 0;
            this.label_stateText.Text = "Durum";
            this.label_stateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_dashboard_checkText
            // 
            this.label_dashboard_checkText.AutoSize = true;
            this.label_dashboard_checkText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_dashboard_checkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_dashboard_checkText.ForeColor = System.Drawing.Color.White;
            this.label_dashboard_checkText.Location = new System.Drawing.Point(295, 0);
            this.label_dashboard_checkText.Name = "label_dashboard_checkText";
            this.label_dashboard_checkText.Size = new System.Drawing.Size(286, 32);
            this.label_dashboard_checkText.TabIndex = 1;
            this.label_dashboard_checkText.Text = "Kontrol";
            this.label_dashboard_checkText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_dashboard_stateText
            // 
            this.textBox_dashboard_stateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_dashboard_stateText.Location = new System.Drawing.Point(3, 35);
            this.textBox_dashboard_stateText.Multiline = true;
            this.textBox_dashboard_stateText.Name = "textBox_dashboard_stateText";
            this.textBox_dashboard_stateText.Size = new System.Drawing.Size(286, 284);
            this.textBox_dashboard_stateText.TabIndex = 2;
            // 
            // textBox_dashboard_checkText
            // 
            this.textBox_dashboard_checkText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_dashboard_checkText.Location = new System.Drawing.Point(295, 35);
            this.textBox_dashboard_checkText.Multiline = true;
            this.textBox_dashboard_checkText.Name = "textBox_dashboard_checkText";
            this.textBox_dashboard_checkText.Size = new System.Drawing.Size(286, 284);
            this.textBox_dashboard_checkText.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 655);
            this.Controls.Add(this.panel_container);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_dashboard_altitude)).EndInit();
            this.panel_dashboard_stateContainer.ResumeLayout(false);
            this.panel_dashboard_stateContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_container;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_dashboard_altitude;
        private System.Windows.Forms.TableLayoutPanel panel_dashboard_stateContainer;
        private System.Windows.Forms.Label label_dashboard_checkText;
        private System.Windows.Forms.Label label_stateText;
        private System.Windows.Forms.TextBox textBox_dashboard_stateText;
        private System.Windows.Forms.TextBox textBox_dashboard_checkText;
    }
}