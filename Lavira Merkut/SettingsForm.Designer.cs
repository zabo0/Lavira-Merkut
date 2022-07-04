
namespace Lavira_Merkut
{
    partial class SettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_sendDataAutomatic = new System.Windows.Forms.CheckBox();
            this.checkBox_isSend = new System.Windows.Forms.CheckBox();
            this.comboBox_sendingDataComPort = new System.Windows.Forms.ComboBox();
            this.label_sendingDataComPort = new System.Windows.Forms.Label();
            this.label_3dRocketSimulationComPort = new System.Windows.Forms.Label();
            this.comboBox_3dRocketSimulationComPort = new System.Windows.Forms.ComboBox();
            this.comboBox_incomingDataComPort = new System.Windows.Forms.ComboBox();
            this.label_incomingDataComPort = new System.Windows.Forms.Label();
            this.checkBox_sendDataToRocket = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1153, 756);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_sendDataToRocket);
            this.groupBox1.Controls.Add(this.checkBox_sendDataAutomatic);
            this.groupBox1.Controls.Add(this.checkBox_isSend);
            this.groupBox1.Controls.Add(this.comboBox_sendingDataComPort);
            this.groupBox1.Controls.Add(this.label_sendingDataComPort);
            this.groupBox1.Controls.Add(this.label_3dRocketSimulationComPort);
            this.groupBox1.Controls.Add(this.comboBox_3dRocketSimulationComPort);
            this.groupBox1.Controls.Add(this.comboBox_incomingDataComPort);
            this.groupBox1.Controls.Add(this.label_incomingDataComPort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ports";
            // 
            // checkBox_sendDataAutomatic
            // 
            this.checkBox_sendDataAutomatic.AutoSize = true;
            this.checkBox_sendDataAutomatic.Location = new System.Drawing.Point(215, 250);
            this.checkBox_sendDataAutomatic.Name = "checkBox_sendDataAutomatic";
            this.checkBox_sendDataAutomatic.Size = new System.Drawing.Size(124, 17);
            this.checkBox_sendDataAutomatic.TabIndex = 7;
            this.checkBox_sendDataAutomatic.Text = "Send data automatic";
            this.checkBox_sendDataAutomatic.UseVisualStyleBackColor = true;
            this.checkBox_sendDataAutomatic.CheckedChanged += new System.EventHandler(this.checkBox_sendDataAutomatic_CheckedChanged);
            // 
            // checkBox_isSend
            // 
            this.checkBox_isSend.AutoSize = true;
            this.checkBox_isSend.Location = new System.Drawing.Point(215, 193);
            this.checkBox_isSend.Name = "checkBox_isSend";
            this.checkBox_isSend.Size = new System.Drawing.Size(75, 17);
            this.checkBox_isSend.TabIndex = 6;
            this.checkBox_isSend.Text = "Send data";
            this.checkBox_isSend.UseVisualStyleBackColor = true;
            this.checkBox_isSend.CheckedChanged += new System.EventHandler(this.checkBox_isSend_CheckedChanged);
            // 
            // comboBox_sendingDataComPort
            // 
            this.comboBox_sendingDataComPort.FormattingEnabled = true;
            this.comboBox_sendingDataComPort.Location = new System.Drawing.Point(215, 165);
            this.comboBox_sendingDataComPort.Name = "comboBox_sendingDataComPort";
            this.comboBox_sendingDataComPort.Size = new System.Drawing.Size(349, 21);
            this.comboBox_sendingDataComPort.TabIndex = 5;
            this.comboBox_sendingDataComPort.SelectedIndexChanged += new System.EventHandler(this.comboBox_sendingDataComPort_SelectedIndexChanged);
            // 
            // label_sendingDataComPort
            // 
            this.label_sendingDataComPort.AutoSize = true;
            this.label_sendingDataComPort.Location = new System.Drawing.Point(49, 168);
            this.label_sendingDataComPort.Name = "label_sendingDataComPort";
            this.label_sendingDataComPort.Size = new System.Drawing.Size(121, 13);
            this.label_sendingDataComPort.TabIndex = 4;
            this.label_sendingDataComPort.Text = "Sending Data COM Port";
            // 
            // label_3dRocketSimulationComPort
            // 
            this.label_3dRocketSimulationComPort.AutoSize = true;
            this.label_3dRocketSimulationComPort.Location = new System.Drawing.Point(46, 84);
            this.label_3dRocketSimulationComPort.Name = "label_3dRocketSimulationComPort";
            this.label_3dRocketSimulationComPort.Size = new System.Drawing.Size(159, 13);
            this.label_3dRocketSimulationComPort.TabIndex = 3;
            this.label_3dRocketSimulationComPort.Text = "3D Rocket Simulation COM Port";
            // 
            // comboBox_3dRocketSimulationComPort
            // 
            this.comboBox_3dRocketSimulationComPort.FormattingEnabled = true;
            this.comboBox_3dRocketSimulationComPort.Location = new System.Drawing.Point(215, 81);
            this.comboBox_3dRocketSimulationComPort.Name = "comboBox_3dRocketSimulationComPort";
            this.comboBox_3dRocketSimulationComPort.Size = new System.Drawing.Size(349, 21);
            this.comboBox_3dRocketSimulationComPort.TabIndex = 2;
            this.comboBox_3dRocketSimulationComPort.SelectedIndexChanged += new System.EventHandler(this.comboBox_3dRocketSimulationComPort_SelectedIndexChanged);
            // 
            // comboBox_incomingDataComPort
            // 
            this.comboBox_incomingDataComPort.FormattingEnabled = true;
            this.comboBox_incomingDataComPort.Location = new System.Drawing.Point(215, 34);
            this.comboBox_incomingDataComPort.Name = "comboBox_incomingDataComPort";
            this.comboBox_incomingDataComPort.Size = new System.Drawing.Size(349, 21);
            this.comboBox_incomingDataComPort.TabIndex = 1;
            this.comboBox_incomingDataComPort.SelectedIndexChanged += new System.EventHandler(this.comboBox_incomingDataComPort_SelectedIndexChanged);
            // 
            // label_incomingDataComPort
            // 
            this.label_incomingDataComPort.AutoSize = true;
            this.label_incomingDataComPort.Location = new System.Drawing.Point(46, 37);
            this.label_incomingDataComPort.Name = "label_incomingDataComPort";
            this.label_incomingDataComPort.Size = new System.Drawing.Size(125, 13);
            this.label_incomingDataComPort.TabIndex = 0;
            this.label_incomingDataComPort.Text = "Incoming Data COM Port";
            // 
            // checkBox_sendDataToRocket
            // 
            this.checkBox_sendDataToRocket.AutoSize = true;
            this.checkBox_sendDataToRocket.Location = new System.Drawing.Point(215, 109);
            this.checkBox_sendDataToRocket.Name = "checkBox_sendDataToRocket";
            this.checkBox_sendDataToRocket.Size = new System.Drawing.Size(77, 17);
            this.checkBox_sendDataToRocket.TabIndex = 8;
            this.checkBox_sendDataToRocket.Text = "Send Data";
            this.checkBox_sendDataToRocket.UseVisualStyleBackColor = true;
            this.checkBox_sendDataToRocket.CheckedChanged += new System.EventHandler(this.checkBox_sendDataToRocket_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(579, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 372);
            this.panel1.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(487, 340);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 756);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_3dRocketSimulationComPort;
        private System.Windows.Forms.ComboBox comboBox_3dRocketSimulationComPort;
        private System.Windows.Forms.ComboBox comboBox_incomingDataComPort;
        private System.Windows.Forms.Label label_incomingDataComPort;
        private System.Windows.Forms.ComboBox comboBox_sendingDataComPort;
        private System.Windows.Forms.Label label_sendingDataComPort;
        private System.Windows.Forms.CheckBox checkBox_isSend;
        private System.Windows.Forms.CheckBox checkBox_sendDataAutomatic;
        private System.Windows.Forms.CheckBox checkBox_sendDataToRocket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_save;
    }
}