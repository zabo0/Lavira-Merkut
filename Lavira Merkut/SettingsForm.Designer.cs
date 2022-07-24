
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
            this.checkBox_sendDataToRocket = new System.Windows.Forms.CheckBox();
            this.checkBox_isSend = new System.Windows.Forms.CheckBox();
            this.comboBox_sendingDataComPort = new System.Windows.Forms.ComboBox();
            this.label_sendingDataComPort = new System.Windows.Forms.Label();
            this.label_3dRocketSimulationComPort = new System.Windows.Forms.Label();
            this.comboBox_3dRocketSimulationComPort = new System.Windows.Forms.ComboBox();
            this.comboBox_incomingDataComPort = new System.Windows.Forms.ComboBox();
            this.label_incomingDataComPort = new System.Windows.Forms.Label();
            this.textBox_teamID = new System.Windows.Forms.TextBox();
            this.label_teamID = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.checkBox_simulation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_sendDataToRocket
            // 
            this.checkBox_sendDataToRocket.AutoSize = true;
            this.checkBox_sendDataToRocket.Location = new System.Drawing.Point(215, 166);
            this.checkBox_sendDataToRocket.Name = "checkBox_sendDataToRocket";
            this.checkBox_sendDataToRocket.Size = new System.Drawing.Size(77, 17);
            this.checkBox_sendDataToRocket.TabIndex = 18;
            this.checkBox_sendDataToRocket.Text = "Send Data";
            this.checkBox_sendDataToRocket.UseVisualStyleBackColor = true;
            // 
            // checkBox_isSend
            // 
            this.checkBox_isSend.AutoSize = true;
            this.checkBox_isSend.Location = new System.Drawing.Point(215, 233);
            this.checkBox_isSend.Name = "checkBox_isSend";
            this.checkBox_isSend.Size = new System.Drawing.Size(75, 17);
            this.checkBox_isSend.TabIndex = 17;
            this.checkBox_isSend.Text = "Send data";
            this.checkBox_isSend.UseVisualStyleBackColor = true;
            // 
            // comboBox_sendingDataComPort
            // 
            this.comboBox_sendingDataComPort.FormattingEnabled = true;
            this.comboBox_sendingDataComPort.Location = new System.Drawing.Point(215, 205);
            this.comboBox_sendingDataComPort.Name = "comboBox_sendingDataComPort";
            this.comboBox_sendingDataComPort.Size = new System.Drawing.Size(349, 21);
            this.comboBox_sendingDataComPort.TabIndex = 16;
            // 
            // label_sendingDataComPort
            // 
            this.label_sendingDataComPort.AutoSize = true;
            this.label_sendingDataComPort.Location = new System.Drawing.Point(12, 208);
            this.label_sendingDataComPort.Name = "label_sendingDataComPort";
            this.label_sendingDataComPort.Size = new System.Drawing.Size(121, 13);
            this.label_sendingDataComPort.TabIndex = 15;
            this.label_sendingDataComPort.Text = "Sending Data COM Port";
            // 
            // label_3dRocketSimulationComPort
            // 
            this.label_3dRocketSimulationComPort.AutoSize = true;
            this.label_3dRocketSimulationComPort.Location = new System.Drawing.Point(12, 141);
            this.label_3dRocketSimulationComPort.Name = "label_3dRocketSimulationComPort";
            this.label_3dRocketSimulationComPort.Size = new System.Drawing.Size(159, 13);
            this.label_3dRocketSimulationComPort.TabIndex = 14;
            this.label_3dRocketSimulationComPort.Text = "3D Rocket Simulation COM Port";
            // 
            // comboBox_3dRocketSimulationComPort
            // 
            this.comboBox_3dRocketSimulationComPort.FormattingEnabled = true;
            this.comboBox_3dRocketSimulationComPort.Location = new System.Drawing.Point(215, 138);
            this.comboBox_3dRocketSimulationComPort.Name = "comboBox_3dRocketSimulationComPort";
            this.comboBox_3dRocketSimulationComPort.Size = new System.Drawing.Size(349, 21);
            this.comboBox_3dRocketSimulationComPort.TabIndex = 13;
            // 
            // comboBox_incomingDataComPort
            // 
            this.comboBox_incomingDataComPort.FormattingEnabled = true;
            this.comboBox_incomingDataComPort.Location = new System.Drawing.Point(215, 83);
            this.comboBox_incomingDataComPort.Name = "comboBox_incomingDataComPort";
            this.comboBox_incomingDataComPort.Size = new System.Drawing.Size(349, 21);
            this.comboBox_incomingDataComPort.TabIndex = 11;
            // 
            // label_incomingDataComPort
            // 
            this.label_incomingDataComPort.AutoSize = true;
            this.label_incomingDataComPort.Location = new System.Drawing.Point(12, 86);
            this.label_incomingDataComPort.Name = "label_incomingDataComPort";
            this.label_incomingDataComPort.Size = new System.Drawing.Size(125, 13);
            this.label_incomingDataComPort.TabIndex = 9;
            this.label_incomingDataComPort.Text = "Incoming Data COM Port";
            // 
            // textBox_teamID
            // 
            this.textBox_teamID.Location = new System.Drawing.Point(215, 27);
            this.textBox_teamID.Name = "textBox_teamID";
            this.textBox_teamID.Size = new System.Drawing.Size(122, 20);
            this.textBox_teamID.TabIndex = 12;
            this.textBox_teamID.TextChanged += new System.EventHandler(this.textBox_teamID_TextChanged);
            // 
            // label_teamID
            // 
            this.label_teamID.AutoSize = true;
            this.label_teamID.Location = new System.Drawing.Point(12, 30);
            this.label_teamID.Name = "label_teamID";
            this.label_teamID.Size = new System.Drawing.Size(84, 13);
            this.label_teamID.TabIndex = 10;
            this.label_teamID.Text = "TeamID For HYI";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(504, 346);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 19;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click_1);
            // 
            // checkBox_simulation
            // 
            this.checkBox_simulation.AutoSize = true;
            this.checkBox_simulation.Location = new System.Drawing.Point(215, 278);
            this.checkBox_simulation.Name = "checkBox_simulation";
            this.checkBox_simulation.Size = new System.Drawing.Size(122, 17);
            this.checkBox_simulation.TabIndex = 21;
            this.checkBox_simulation.Text = "Simulate saved data";
            this.checkBox_simulation.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 381);
            this.Controls.Add(this.checkBox_simulation);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.checkBox_sendDataToRocket);
            this.Controls.Add(this.checkBox_isSend);
            this.Controls.Add(this.comboBox_sendingDataComPort);
            this.Controls.Add(this.label_sendingDataComPort);
            this.Controls.Add(this.label_3dRocketSimulationComPort);
            this.Controls.Add(this.comboBox_3dRocketSimulationComPort);
            this.Controls.Add(this.comboBox_incomingDataComPort);
            this.Controls.Add(this.label_incomingDataComPort);
            this.Controls.Add(this.textBox_teamID);
            this.Controls.Add(this.label_teamID);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_sendDataToRocket;
        private System.Windows.Forms.CheckBox checkBox_isSend;
        private System.Windows.Forms.ComboBox comboBox_sendingDataComPort;
        private System.Windows.Forms.Label label_sendingDataComPort;
        private System.Windows.Forms.Label label_3dRocketSimulationComPort;
        private System.Windows.Forms.ComboBox comboBox_3dRocketSimulationComPort;
        private System.Windows.Forms.ComboBox comboBox_incomingDataComPort;
        private System.Windows.Forms.Label label_incomingDataComPort;
        private System.Windows.Forms.TextBox textBox_teamID;
        private System.Windows.Forms.Label label_teamID;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.CheckBox checkBox_simulation;
    }
}