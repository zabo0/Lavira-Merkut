
namespace Lavira_Merkut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_TopBar = new System.Windows.Forms.Panel();
            this.Label_LaviraMerkut = new System.Windows.Forms.Label();
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Container = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_navigation = new System.Windows.Forms.TableLayoutPanel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox_topLogo = new System.Windows.Forms.PictureBox();
            this.panel_navigationTime = new System.Windows.Forms.Panel();
            this.label_textTime = new System.Windows.Forms.Label();
            this.label_currentTime = new System.Windows.Forms.Label();
            this.label_launchTime = new System.Windows.Forms.Label();
            this.panel_navigationButtons = new System.Windows.Forms.Panel();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.button_velocity = new System.Windows.Forms.Button();
            this.button_Temperature = new System.Windows.Forms.Button();
            this.button_Pressure = new System.Windows.Forms.Button();
            this.button_Moisture = new System.Windows.Forms.Button();
            this.button_acceleration = new System.Windows.Forms.Button();
            this.button_location = new System.Windows.Forms.Button();
            this.button_altitude = new System.Windows.Forms.Button();
            this.tableLayoutPanel_buttonStartFinish = new System.Windows.Forms.TableLayoutPanel();
            this.button_start = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.panel_formContainer = new System.Windows.Forms.Panel();
            this.Panel_TopBar.SuspendLayout();
            this.Panel_Container.SuspendLayout();
            this.tableLayoutPanel_Container.SuspendLayout();
            this.tableLayoutPanel_navigation.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_topLogo)).BeginInit();
            this.panel_navigationTime.SuspendLayout();
            this.panel_navigationButtons.SuspendLayout();
            this.tableLayoutPanel_buttonStartFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_TopBar
            // 
            this.Panel_TopBar.BackColor = System.Drawing.Color.Navy;
            this.Panel_TopBar.Controls.Add(this.panel_logo);
            this.Panel_TopBar.Controls.Add(this.Label_LaviraMerkut);
            this.Panel_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopBar.Name = "Panel_TopBar";
            this.Panel_TopBar.Size = new System.Drawing.Size(1180, 70);
            this.Panel_TopBar.TabIndex = 0;
            // 
            // Label_LaviraMerkut
            // 
            this.Label_LaviraMerkut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_LaviraMerkut.AutoSize = true;
            this.Label_LaviraMerkut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_LaviraMerkut.ForeColor = System.Drawing.Color.White;
            this.Label_LaviraMerkut.Location = new System.Drawing.Point(644, 25);
            this.Label_LaviraMerkut.Name = "Label_LaviraMerkut";
            this.Label_LaviraMerkut.Size = new System.Drawing.Size(139, 20);
            this.Label_LaviraMerkut.TabIndex = 0;
            this.Label_LaviraMerkut.Text = "LAVIRA MERKUT";
            this.Label_LaviraMerkut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_LaviraMerkut.Click += new System.EventHandler(this.label1_Click);
            // 
            // Panel_Container
            // 
            this.Panel_Container.BackColor = System.Drawing.Color.White;
            this.Panel_Container.Controls.Add(this.tableLayoutPanel_Container);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(0, 70);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(1180, 611);
            this.Panel_Container.TabIndex = 1;
            // 
            // tableLayoutPanel_Container
            // 
            this.tableLayoutPanel_Container.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel_Container.ColumnCount = 2;
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Container.Controls.Add(this.tableLayoutPanel_navigation, 0, 0);
            this.tableLayoutPanel_Container.Controls.Add(this.panel_formContainer, 1, 0);
            this.tableLayoutPanel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Container.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Container.Name = "tableLayoutPanel_Container";
            this.tableLayoutPanel_Container.RowCount = 1;
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Container.Size = new System.Drawing.Size(1180, 611);
            this.tableLayoutPanel_Container.TabIndex = 0;
            // 
            // tableLayoutPanel_navigation
            // 
            this.tableLayoutPanel_navigation.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel_navigation.ColumnCount = 1;
            this.tableLayoutPanel_navigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_navigation.Controls.Add(this.panel_navigationTime, 0, 0);
            this.tableLayoutPanel_navigation.Controls.Add(this.panel_navigationButtons, 0, 1);
            this.tableLayoutPanel_navigation.Controls.Add(this.tableLayoutPanel_buttonStartFinish, 0, 2);
            this.tableLayoutPanel_navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_navigation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_navigation.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_navigation.Name = "tableLayoutPanel_navigation";
            this.tableLayoutPanel_navigation.RowCount = 3;
            this.tableLayoutPanel_navigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel_navigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_navigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_navigation.Size = new System.Drawing.Size(250, 611);
            this.tableLayoutPanel_navigation.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox_topLogo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(250, 70);
            this.panel_logo.TabIndex = 1;
            // 
            // pictureBox_topLogo
            // 
            this.pictureBox_topLogo.BackColor = System.Drawing.Color.White;
            this.pictureBox_topLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_topLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_topLogo.Image")));
            this.pictureBox_topLogo.InitialImage = null;
            this.pictureBox_topLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_topLogo.Name = "pictureBox_topLogo";
            this.pictureBox_topLogo.Size = new System.Drawing.Size(250, 70);
            this.pictureBox_topLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_topLogo.TabIndex = 0;
            this.pictureBox_topLogo.TabStop = false;
            // 
            // panel_navigationTime
            // 
            this.panel_navigationTime.Controls.Add(this.label_launchTime);
            this.panel_navigationTime.Controls.Add(this.label_currentTime);
            this.panel_navigationTime.Controls.Add(this.label_textTime);
            this.panel_navigationTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_navigationTime.Location = new System.Drawing.Point(3, 3);
            this.panel_navigationTime.Name = "panel_navigationTime";
            this.panel_navigationTime.Size = new System.Drawing.Size(244, 124);
            this.panel_navigationTime.TabIndex = 0;
            // 
            // label_textTime
            // 
            this.label_textTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_textTime.ForeColor = System.Drawing.Color.White;
            this.label_textTime.Location = new System.Drawing.Point(0, 9);
            this.label_textTime.Name = "label_textTime";
            this.label_textTime.Size = new System.Drawing.Size(244, 23);
            this.label_textTime.TabIndex = 0;
            this.label_textTime.Text = "Click \'Start\' to start";
            this.label_textTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_currentTime
            // 
            this.label_currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_currentTime.ForeColor = System.Drawing.Color.White;
            this.label_currentTime.Location = new System.Drawing.Point(0, 32);
            this.label_currentTime.Name = "label_currentTime";
            this.label_currentTime.Size = new System.Drawing.Size(244, 55);
            this.label_currentTime.TabIndex = 1;
            this.label_currentTime.Text = "00:00.00";
            this.label_currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_launchTime
            // 
            this.label_launchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_launchTime.ForeColor = System.Drawing.Color.White;
            this.label_launchTime.Location = new System.Drawing.Point(0, 87);
            this.label_launchTime.Name = "label_launchTime";
            this.label_launchTime.Size = new System.Drawing.Size(244, 37);
            this.label_launchTime.TabIndex = 2;
            this.label_launchTime.Text = "00:00.00";
            this.label_launchTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_navigationButtons
            // 
            this.panel_navigationButtons.Controls.Add(this.button_altitude);
            this.panel_navigationButtons.Controls.Add(this.button_location);
            this.panel_navigationButtons.Controls.Add(this.button_acceleration);
            this.panel_navigationButtons.Controls.Add(this.button_Moisture);
            this.panel_navigationButtons.Controls.Add(this.button_Pressure);
            this.panel_navigationButtons.Controls.Add(this.button_Temperature);
            this.panel_navigationButtons.Controls.Add(this.button_velocity);
            this.panel_navigationButtons.Controls.Add(this.button_dashboard);
            this.panel_navigationButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_navigationButtons.Location = new System.Drawing.Point(3, 133);
            this.panel_navigationButtons.Name = "panel_navigationButtons";
            this.panel_navigationButtons.Size = new System.Drawing.Size(244, 415);
            this.panel_navigationButtons.TabIndex = 1;
            // 
            // button_dashboard
            // 
            this.button_dashboard.BackColor = System.Drawing.Color.Navy;
            this.button_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dashboard.FlatAppearance.BorderSize = 0;
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_dashboard.ForeColor = System.Drawing.Color.White;
            this.button_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("button_dashboard.Image")));
            this.button_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dashboard.Location = new System.Drawing.Point(0, 0);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(244, 52);
            this.button_dashboard.TabIndex = 0;
            this.button_dashboard.Text = "    DashBoard";
            this.button_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_dashboard.UseVisualStyleBackColor = false;
            // 
            // button_velocity
            // 
            this.button_velocity.BackColor = System.Drawing.Color.Navy;
            this.button_velocity.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_velocity.FlatAppearance.BorderSize = 0;
            this.button_velocity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_velocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_velocity.ForeColor = System.Drawing.Color.White;
            this.button_velocity.Image = ((System.Drawing.Image)(resources.GetObject("button_velocity.Image")));
            this.button_velocity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_velocity.Location = new System.Drawing.Point(0, 52);
            this.button_velocity.Name = "button_velocity";
            this.button_velocity.Size = new System.Drawing.Size(244, 52);
            this.button_velocity.TabIndex = 1;
            this.button_velocity.Text = "    Velocity";
            this.button_velocity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_velocity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_velocity.UseVisualStyleBackColor = false;
            // 
            // button_Temperature
            // 
            this.button_Temperature.BackColor = System.Drawing.Color.Navy;
            this.button_Temperature.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Temperature.FlatAppearance.BorderSize = 0;
            this.button_Temperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Temperature.ForeColor = System.Drawing.Color.White;
            this.button_Temperature.Image = ((System.Drawing.Image)(resources.GetObject("button_Temperature.Image")));
            this.button_Temperature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Temperature.Location = new System.Drawing.Point(0, 104);
            this.button_Temperature.Name = "button_Temperature";
            this.button_Temperature.Size = new System.Drawing.Size(244, 52);
            this.button_Temperature.TabIndex = 2;
            this.button_Temperature.Text = "    Temperature";
            this.button_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Temperature.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Temperature.UseVisualStyleBackColor = false;
            // 
            // button_Pressure
            // 
            this.button_Pressure.BackColor = System.Drawing.Color.Navy;
            this.button_Pressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Pressure.FlatAppearance.BorderSize = 0;
            this.button_Pressure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Pressure.ForeColor = System.Drawing.Color.White;
            this.button_Pressure.Image = ((System.Drawing.Image)(resources.GetObject("button_Pressure.Image")));
            this.button_Pressure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pressure.Location = new System.Drawing.Point(0, 156);
            this.button_Pressure.Name = "button_Pressure";
            this.button_Pressure.Size = new System.Drawing.Size(244, 52);
            this.button_Pressure.TabIndex = 3;
            this.button_Pressure.Text = "    Pressure";
            this.button_Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pressure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Pressure.UseVisualStyleBackColor = false;
            // 
            // button_Moisture
            // 
            this.button_Moisture.BackColor = System.Drawing.Color.Navy;
            this.button_Moisture.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Moisture.FlatAppearance.BorderSize = 0;
            this.button_Moisture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Moisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Moisture.ForeColor = System.Drawing.Color.White;
            this.button_Moisture.Image = ((System.Drawing.Image)(resources.GetObject("button_Moisture.Image")));
            this.button_Moisture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Moisture.Location = new System.Drawing.Point(0, 208);
            this.button_Moisture.Name = "button_Moisture";
            this.button_Moisture.Size = new System.Drawing.Size(244, 52);
            this.button_Moisture.TabIndex = 4;
            this.button_Moisture.Text = "    Moisture";
            this.button_Moisture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Moisture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Moisture.UseVisualStyleBackColor = false;
            // 
            // button_acceleration
            // 
            this.button_acceleration.BackColor = System.Drawing.Color.Navy;
            this.button_acceleration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_acceleration.FlatAppearance.BorderSize = 0;
            this.button_acceleration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_acceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_acceleration.ForeColor = System.Drawing.Color.White;
            this.button_acceleration.Image = ((System.Drawing.Image)(resources.GetObject("button_acceleration.Image")));
            this.button_acceleration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_acceleration.Location = new System.Drawing.Point(0, 260);
            this.button_acceleration.Name = "button_acceleration";
            this.button_acceleration.Size = new System.Drawing.Size(244, 52);
            this.button_acceleration.TabIndex = 5;
            this.button_acceleration.Text = "    Acceleration";
            this.button_acceleration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_acceleration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_acceleration.UseVisualStyleBackColor = false;
            // 
            // button_location
            // 
            this.button_location.BackColor = System.Drawing.Color.Navy;
            this.button_location.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_location.FlatAppearance.BorderSize = 0;
            this.button_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_location.ForeColor = System.Drawing.Color.White;
            this.button_location.Image = ((System.Drawing.Image)(resources.GetObject("button_location.Image")));
            this.button_location.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_location.Location = new System.Drawing.Point(0, 312);
            this.button_location.Name = "button_location";
            this.button_location.Size = new System.Drawing.Size(244, 52);
            this.button_location.TabIndex = 6;
            this.button_location.Text = "    Location";
            this.button_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_location.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_location.UseVisualStyleBackColor = false;
            // 
            // button_altitude
            // 
            this.button_altitude.BackColor = System.Drawing.Color.Navy;
            this.button_altitude.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_altitude.FlatAppearance.BorderSize = 0;
            this.button_altitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_altitude.ForeColor = System.Drawing.Color.White;
            this.button_altitude.Image = ((System.Drawing.Image)(resources.GetObject("button_altitude.Image")));
            this.button_altitude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_altitude.Location = new System.Drawing.Point(0, 364);
            this.button_altitude.Name = "button_altitude";
            this.button_altitude.Size = new System.Drawing.Size(244, 52);
            this.button_altitude.TabIndex = 7;
            this.button_altitude.Text = "    Altitude";
            this.button_altitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_altitude.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_altitude.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel_buttonStartFinish
            // 
            this.tableLayoutPanel_buttonStartFinish.ColumnCount = 2;
            this.tableLayoutPanel_buttonStartFinish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_buttonStartFinish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_buttonStartFinish.Controls.Add(this.button_finish, 1, 0);
            this.tableLayoutPanel_buttonStartFinish.Controls.Add(this.button_start, 0, 0);
            this.tableLayoutPanel_buttonStartFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_buttonStartFinish.Location = new System.Drawing.Point(3, 554);
            this.tableLayoutPanel_buttonStartFinish.Name = "tableLayoutPanel_buttonStartFinish";
            this.tableLayoutPanel_buttonStartFinish.RowCount = 1;
            this.tableLayoutPanel_buttonStartFinish.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_buttonStartFinish.Size = new System.Drawing.Size(244, 54);
            this.tableLayoutPanel_buttonStartFinish.TabIndex = 2;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start.Location = new System.Drawing.Point(3, 3);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(116, 48);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            // 
            // button_finish
            // 
            this.button_finish.BackColor = System.Drawing.Color.Red;
            this.button_finish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_finish.Location = new System.Drawing.Point(125, 3);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(116, 48);
            this.button_finish.TabIndex = 1;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = false;
            // 
            // panel_formContainer
            // 
            this.panel_formContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_formContainer.Location = new System.Drawing.Point(253, 3);
            this.panel_formContainer.Name = "panel_formContainer";
            this.panel_formContainer.Size = new System.Drawing.Size(924, 605);
            this.panel_formContainer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 681);
            this.Controls.Add(this.Panel_Container);
            this.Controls.Add(this.Panel_TopBar);
            this.MinimumSize = new System.Drawing.Size(425, 720);
            this.Name = "Form1";
            this.Text = "Lavira Merkut";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_TopBar.ResumeLayout(false);
            this.Panel_TopBar.PerformLayout();
            this.Panel_Container.ResumeLayout(false);
            this.tableLayoutPanel_Container.ResumeLayout(false);
            this.tableLayoutPanel_navigation.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_topLogo)).EndInit();
            this.panel_navigationTime.ResumeLayout(false);
            this.panel_navigationButtons.ResumeLayout(false);
            this.tableLayoutPanel_buttonStartFinish.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_TopBar;
        private System.Windows.Forms.Label Label_LaviraMerkut;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel Panel_Container;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Container;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_navigation;
        private System.Windows.Forms.PictureBox pictureBox_topLogo;
        private System.Windows.Forms.Panel panel_navigationTime;
        private System.Windows.Forms.Label label_launchTime;
        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Label label_textTime;
        private System.Windows.Forms.Panel panel_navigationButtons;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button_altitude;
        private System.Windows.Forms.Button button_location;
        private System.Windows.Forms.Button button_acceleration;
        private System.Windows.Forms.Button button_Moisture;
        private System.Windows.Forms.Button button_Pressure;
        private System.Windows.Forms.Button button_Temperature;
        private System.Windows.Forms.Button button_velocity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_buttonStartFinish;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Panel panel_formContainer;
    }
}

