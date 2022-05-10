
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel_topBar = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_settings = new System.Windows.Forms.PictureBox();
            this.panel_container = new System.Windows.Forms.TableLayoutPanel();
            this.panel_infoText = new System.Windows.Forms.TableLayoutPanel();
            this.panel_timer = new System.Windows.Forms.TableLayoutPanel();
            this.label_timeText = new System.Windows.Forms.Label();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_timeLaunch = new System.Windows.Forms.Label();
            this.panel_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.button_start = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.panel_info = new System.Windows.Forms.TableLayoutPanel();
            this.label_accelerationZ = new System.Windows.Forms.Label();
            this.textBox_accelerationZ = new System.Windows.Forms.TextBox();
            this.label_accelerationY = new System.Windows.Forms.Label();
            this.textBox_accelerationY = new System.Windows.Forms.TextBox();
            this.label_accelerationX = new System.Windows.Forms.Label();
            this.textBox_accelerationX = new System.Windows.Forms.TextBox();
            this.label_moisture = new System.Windows.Forms.Label();
            this.textBox_moisture = new System.Windows.Forms.TextBox();
            this.label_pressure = new System.Windows.Forms.Label();
            this.textBox_pressure = new System.Windows.Forms.TextBox();
            this.label_temperature = new System.Windows.Forms.Label();
            this.textBox_temperature = new System.Windows.Forms.TextBox();
            this.label_locationY = new System.Windows.Forms.Label();
            this.textBox_locationY = new System.Windows.Forms.TextBox();
            this.label_locationX = new System.Windows.Forms.Label();
            this.textBox_locationX = new System.Windows.Forms.TextBox();
            this.label_altitude = new System.Windows.Forms.Label();
            this.textBox_altitude = new System.Windows.Forms.TextBox();
            this.label_Vz = new System.Windows.Forms.Label();
            this.textBox_Vz = new System.Windows.Forms.TextBox();
            this.label_Vx = new System.Windows.Forms.Label();
            this.textBox_Vx = new System.Windows.Forms.TextBox();
            this.label_velocity = new System.Windows.Forms.Label();
            this.textBox_velocity = new System.Windows.Forms.TextBox();
            this.panel_charts = new System.Windows.Forms.TableLayoutPanel();
            this.chart_altitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_velocity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_stateControls = new System.Windows.Forms.TableLayoutPanel();
            this.label_controlsText = new System.Windows.Forms.Label();
            this.label_stateText = new System.Windows.Forms.Label();
            this.textBox_state = new System.Windows.Forms.TextBox();
            this.textBox_controls = new System.Windows.Forms.TextBox();
            this.panel_3dMap = new System.Windows.Forms.TableLayoutPanel();
            this.panel_unity = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.panel_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_settings)).BeginInit();
            this.panel_container.SuspendLayout();
            this.panel_infoText.SuspendLayout();
            this.panel_timer.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.panel_charts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_altitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_velocity)).BeginInit();
            this.panel_stateControls.SuspendLayout();
            this.panel_3dMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panel_topBar, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel_container, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1251, 772);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panel_topBar
            // 
            this.panel_topBar.ColumnCount = 2;
            this.panel_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.panel_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.panel_topBar.Controls.Add(this.pictureBox1, 0, 0);
            this.panel_topBar.Controls.Add(this.panel_top, 1, 0);
            this.panel_topBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_topBar.Location = new System.Drawing.Point(0, 0);
            this.panel_topBar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_topBar.Name = "panel_topBar";
            this.panel_topBar.RowCount = 1;
            this.panel_topBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_topBar.Size = new System.Drawing.Size(1251, 80);
            this.panel_topBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_top
            // 
            this.panel_top.ColumnCount = 2;
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.panel_top.Controls.Add(this.label1, 0, 0);
            this.panel_top.Controls.Add(this.pictureBox_settings, 1, 0);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_top.Location = new System.Drawing.Point(178, 3);
            this.panel_top.Name = "panel_top";
            this.panel_top.RowCount = 1;
            this.panel_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_top.Size = new System.Drawing.Size(1070, 74);
            this.panel_top.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lavira Merkut";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_settings
            // 
            this.pictureBox_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_settings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_settings.Image")));
            this.pictureBox_settings.Location = new System.Drawing.Point(1040, 3);
            this.pictureBox_settings.Name = "pictureBox_settings";
            this.pictureBox_settings.Size = new System.Drawing.Size(27, 68);
            this.pictureBox_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_settings.TabIndex = 1;
            this.pictureBox_settings.TabStop = false;
            this.pictureBox_settings.Click += new System.EventHandler(this.pictureBox_settings_Click);
            // 
            // panel_container
            // 
            this.panel_container.ColumnCount = 3;
            this.panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_container.Controls.Add(this.panel_infoText, 0, 0);
            this.panel_container.Controls.Add(this.panel_charts, 1, 0);
            this.panel_container.Controls.Add(this.panel_3dMap, 2, 0);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(3, 83);
            this.panel_container.Name = "panel_container";
            this.panel_container.RowCount = 1;
            this.panel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_container.Size = new System.Drawing.Size(1245, 686);
            this.panel_container.TabIndex = 1;
            // 
            // panel_infoText
            // 
            this.panel_infoText.ColumnCount = 1;
            this.panel_infoText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_infoText.Controls.Add(this.panel_timer, 0, 0);
            this.panel_infoText.Controls.Add(this.panel_buttons, 0, 1);
            this.panel_infoText.Controls.Add(this.panel_info, 0, 2);
            this.panel_infoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_infoText.Location = new System.Drawing.Point(0, 0);
            this.panel_infoText.Margin = new System.Windows.Forms.Padding(0);
            this.panel_infoText.Name = "panel_infoText";
            this.panel_infoText.RowCount = 3;
            this.panel_infoText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panel_infoText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.panel_infoText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.panel_infoText.Size = new System.Drawing.Size(174, 686);
            this.panel_infoText.TabIndex = 0;
            // 
            // panel_timer
            // 
            this.panel_timer.ColumnCount = 1;
            this.panel_timer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_timer.Controls.Add(this.label_timeText, 0, 0);
            this.panel_timer.Controls.Add(this.label_timer, 0, 1);
            this.panel_timer.Controls.Add(this.label_timeLaunch, 0, 2);
            this.panel_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_timer.Location = new System.Drawing.Point(3, 3);
            this.panel_timer.Name = "panel_timer";
            this.panel_timer.RowCount = 3;
            this.panel_timer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_timer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panel_timer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_timer.Size = new System.Drawing.Size(168, 131);
            this.panel_timer.TabIndex = 0;
            // 
            // label_timeText
            // 
            this.label_timeText.AutoSize = true;
            this.label_timeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_timeText.ForeColor = System.Drawing.Color.White;
            this.label_timeText.Location = new System.Drawing.Point(3, 0);
            this.label_timeText.Name = "label_timeText";
            this.label_timeText.Size = new System.Drawing.Size(162, 39);
            this.label_timeText.TabIndex = 0;
            this.label_timeText.Text = "Click \'Start\' to start";
            this.label_timeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_timer.ForeColor = System.Drawing.Color.White;
            this.label_timer.Location = new System.Drawing.Point(3, 39);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(162, 52);
            this.label_timer.TabIndex = 1;
            this.label_timer.Text = "00:00.00";
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_timeLaunch
            // 
            this.label_timeLaunch.AutoSize = true;
            this.label_timeLaunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_timeLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_timeLaunch.ForeColor = System.Drawing.Color.White;
            this.label_timeLaunch.Location = new System.Drawing.Point(3, 91);
            this.label_timeLaunch.Name = "label_timeLaunch";
            this.label_timeLaunch.Size = new System.Drawing.Size(162, 40);
            this.label_timeLaunch.TabIndex = 2;
            this.label_timeLaunch.Text = "00:00.00";
            this.label_timeLaunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_buttons
            // 
            this.panel_buttons.ColumnCount = 2;
            this.panel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_buttons.Controls.Add(this.button_start, 0, 0);
            this.panel_buttons.Controls.Add(this.button_finish, 1, 0);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_buttons.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_buttons.Location = new System.Drawing.Point(3, 140);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.RowCount = 1;
            this.panel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.panel_buttons.Size = new System.Drawing.Size(168, 42);
            this.panel_buttons.TabIndex = 1;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_start.Location = new System.Drawing.Point(3, 3);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(78, 36);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click_1);
            // 
            // button_finish
            // 
            this.button_finish.BackColor = System.Drawing.Color.Red;
            this.button_finish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_finish.Location = new System.Drawing.Point(87, 3);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(78, 36);
            this.button_finish.TabIndex = 1;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = false;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click_1);
            // 
            // panel_info
            // 
            this.panel_info.ColumnCount = 2;
            this.panel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_info.Controls.Add(this.label_accelerationZ, 0, 11);
            this.panel_info.Controls.Add(this.textBox_accelerationZ, 1, 11);
            this.panel_info.Controls.Add(this.label_accelerationY, 0, 10);
            this.panel_info.Controls.Add(this.textBox_accelerationY, 1, 10);
            this.panel_info.Controls.Add(this.label_accelerationX, 0, 9);
            this.panel_info.Controls.Add(this.textBox_accelerationX, 1, 9);
            this.panel_info.Controls.Add(this.label_moisture, 0, 8);
            this.panel_info.Controls.Add(this.textBox_moisture, 1, 8);
            this.panel_info.Controls.Add(this.label_pressure, 0, 7);
            this.panel_info.Controls.Add(this.textBox_pressure, 1, 7);
            this.panel_info.Controls.Add(this.label_temperature, 0, 6);
            this.panel_info.Controls.Add(this.textBox_temperature, 1, 6);
            this.panel_info.Controls.Add(this.label_locationY, 0, 5);
            this.panel_info.Controls.Add(this.textBox_locationY, 1, 5);
            this.panel_info.Controls.Add(this.label_locationX, 0, 4);
            this.panel_info.Controls.Add(this.textBox_locationX, 1, 4);
            this.panel_info.Controls.Add(this.label_altitude, 0, 3);
            this.panel_info.Controls.Add(this.textBox_altitude, 1, 3);
            this.panel_info.Controls.Add(this.label_Vz, 0, 2);
            this.panel_info.Controls.Add(this.textBox_Vz, 1, 2);
            this.panel_info.Controls.Add(this.label_Vx, 0, 1);
            this.panel_info.Controls.Add(this.textBox_Vx, 1, 1);
            this.panel_info.Controls.Add(this.label_velocity, 0, 0);
            this.panel_info.Controls.Add(this.textBox_velocity, 1, 0);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_info.Location = new System.Drawing.Point(3, 188);
            this.panel_info.Name = "panel_info";
            this.panel_info.RowCount = 12;
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_info.Size = new System.Drawing.Size(168, 495);
            this.panel_info.TabIndex = 2;
            // 
            // label_accelerationZ
            // 
            this.label_accelerationZ.AutoSize = true;
            this.label_accelerationZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_accelerationZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_accelerationZ.ForeColor = System.Drawing.Color.White;
            this.label_accelerationZ.Location = new System.Drawing.Point(3, 451);
            this.label_accelerationZ.Name = "label_accelerationZ";
            this.label_accelerationZ.Size = new System.Drawing.Size(78, 44);
            this.label_accelerationZ.TabIndex = 22;
            this.label_accelerationZ.Text = "AccelerationZ";
            // 
            // textBox_accelerationZ
            // 
            this.textBox_accelerationZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_accelerationZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_accelerationZ.Location = new System.Drawing.Point(87, 454);
            this.textBox_accelerationZ.Name = "textBox_accelerationZ";
            this.textBox_accelerationZ.ReadOnly = true;
            this.textBox_accelerationZ.Size = new System.Drawing.Size(78, 23);
            this.textBox_accelerationZ.TabIndex = 23;
            // 
            // label_accelerationY
            // 
            this.label_accelerationY.AutoSize = true;
            this.label_accelerationY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_accelerationY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_accelerationY.ForeColor = System.Drawing.Color.White;
            this.label_accelerationY.Location = new System.Drawing.Point(3, 410);
            this.label_accelerationY.Name = "label_accelerationY";
            this.label_accelerationY.Size = new System.Drawing.Size(78, 41);
            this.label_accelerationY.TabIndex = 20;
            this.label_accelerationY.Text = "AccelerationY";
            // 
            // textBox_accelerationY
            // 
            this.textBox_accelerationY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_accelerationY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_accelerationY.Location = new System.Drawing.Point(87, 413);
            this.textBox_accelerationY.Name = "textBox_accelerationY";
            this.textBox_accelerationY.ReadOnly = true;
            this.textBox_accelerationY.Size = new System.Drawing.Size(78, 23);
            this.textBox_accelerationY.TabIndex = 21;
            // 
            // label_accelerationX
            // 
            this.label_accelerationX.AutoSize = true;
            this.label_accelerationX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_accelerationX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_accelerationX.ForeColor = System.Drawing.Color.White;
            this.label_accelerationX.Location = new System.Drawing.Point(3, 369);
            this.label_accelerationX.Name = "label_accelerationX";
            this.label_accelerationX.Size = new System.Drawing.Size(78, 41);
            this.label_accelerationX.TabIndex = 18;
            this.label_accelerationX.Text = "AccelerationX";
            // 
            // textBox_accelerationX
            // 
            this.textBox_accelerationX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_accelerationX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_accelerationX.Location = new System.Drawing.Point(87, 372);
            this.textBox_accelerationX.Name = "textBox_accelerationX";
            this.textBox_accelerationX.ReadOnly = true;
            this.textBox_accelerationX.Size = new System.Drawing.Size(78, 23);
            this.textBox_accelerationX.TabIndex = 19;
            // 
            // label_moisture
            // 
            this.label_moisture.AutoSize = true;
            this.label_moisture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_moisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_moisture.ForeColor = System.Drawing.Color.White;
            this.label_moisture.Location = new System.Drawing.Point(3, 328);
            this.label_moisture.Name = "label_moisture";
            this.label_moisture.Size = new System.Drawing.Size(78, 41);
            this.label_moisture.TabIndex = 16;
            this.label_moisture.Text = "Moisture";
            // 
            // textBox_moisture
            // 
            this.textBox_moisture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_moisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_moisture.Location = new System.Drawing.Point(87, 331);
            this.textBox_moisture.Name = "textBox_moisture";
            this.textBox_moisture.ReadOnly = true;
            this.textBox_moisture.Size = new System.Drawing.Size(78, 23);
            this.textBox_moisture.TabIndex = 17;
            // 
            // label_pressure
            // 
            this.label_pressure.AutoSize = true;
            this.label_pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_pressure.ForeColor = System.Drawing.Color.White;
            this.label_pressure.Location = new System.Drawing.Point(3, 287);
            this.label_pressure.Name = "label_pressure";
            this.label_pressure.Size = new System.Drawing.Size(78, 41);
            this.label_pressure.TabIndex = 14;
            this.label_pressure.Text = "Pressure";
            // 
            // textBox_pressure
            // 
            this.textBox_pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_pressure.Location = new System.Drawing.Point(87, 290);
            this.textBox_pressure.Name = "textBox_pressure";
            this.textBox_pressure.ReadOnly = true;
            this.textBox_pressure.Size = new System.Drawing.Size(78, 23);
            this.textBox_pressure.TabIndex = 15;
            // 
            // label_temperature
            // 
            this.label_temperature.AutoSize = true;
            this.label_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_temperature.ForeColor = System.Drawing.Color.White;
            this.label_temperature.Location = new System.Drawing.Point(3, 246);
            this.label_temperature.Name = "label_temperature";
            this.label_temperature.Size = new System.Drawing.Size(78, 41);
            this.label_temperature.TabIndex = 12;
            this.label_temperature.Text = "Temperature";
            // 
            // textBox_temperature
            // 
            this.textBox_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_temperature.Location = new System.Drawing.Point(87, 249);
            this.textBox_temperature.Name = "textBox_temperature";
            this.textBox_temperature.ReadOnly = true;
            this.textBox_temperature.Size = new System.Drawing.Size(78, 23);
            this.textBox_temperature.TabIndex = 13;
            // 
            // label_locationY
            // 
            this.label_locationY.AutoSize = true;
            this.label_locationY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_locationY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_locationY.ForeColor = System.Drawing.Color.White;
            this.label_locationY.Location = new System.Drawing.Point(3, 205);
            this.label_locationY.Name = "label_locationY";
            this.label_locationY.Size = new System.Drawing.Size(78, 41);
            this.label_locationY.TabIndex = 10;
            this.label_locationY.Text = "LocationY";
            // 
            // textBox_locationY
            // 
            this.textBox_locationY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_locationY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_locationY.Location = new System.Drawing.Point(87, 208);
            this.textBox_locationY.Name = "textBox_locationY";
            this.textBox_locationY.ReadOnly = true;
            this.textBox_locationY.Size = new System.Drawing.Size(78, 23);
            this.textBox_locationY.TabIndex = 11;
            // 
            // label_locationX
            // 
            this.label_locationX.AutoSize = true;
            this.label_locationX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_locationX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_locationX.ForeColor = System.Drawing.Color.White;
            this.label_locationX.Location = new System.Drawing.Point(3, 164);
            this.label_locationX.Name = "label_locationX";
            this.label_locationX.Size = new System.Drawing.Size(78, 41);
            this.label_locationX.TabIndex = 8;
            this.label_locationX.Text = "LocationX";
            // 
            // textBox_locationX
            // 
            this.textBox_locationX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_locationX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_locationX.Location = new System.Drawing.Point(87, 167);
            this.textBox_locationX.Name = "textBox_locationX";
            this.textBox_locationX.ReadOnly = true;
            this.textBox_locationX.Size = new System.Drawing.Size(78, 23);
            this.textBox_locationX.TabIndex = 9;
            // 
            // label_altitude
            // 
            this.label_altitude.AutoSize = true;
            this.label_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_altitude.ForeColor = System.Drawing.Color.White;
            this.label_altitude.Location = new System.Drawing.Point(3, 123);
            this.label_altitude.Name = "label_altitude";
            this.label_altitude.Size = new System.Drawing.Size(78, 41);
            this.label_altitude.TabIndex = 6;
            this.label_altitude.Text = "Altitude";
            // 
            // textBox_altitude
            // 
            this.textBox_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_altitude.Location = new System.Drawing.Point(87, 126);
            this.textBox_altitude.Name = "textBox_altitude";
            this.textBox_altitude.ReadOnly = true;
            this.textBox_altitude.Size = new System.Drawing.Size(78, 23);
            this.textBox_altitude.TabIndex = 7;
            // 
            // label_Vz
            // 
            this.label_Vz.AutoSize = true;
            this.label_Vz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Vz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Vz.ForeColor = System.Drawing.Color.White;
            this.label_Vz.Location = new System.Drawing.Point(3, 82);
            this.label_Vz.Name = "label_Vz";
            this.label_Vz.Size = new System.Drawing.Size(78, 41);
            this.label_Vz.TabIndex = 4;
            this.label_Vz.Text = "Velocity_Z";
            // 
            // textBox_Vz
            // 
            this.textBox_Vz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Vz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Vz.Location = new System.Drawing.Point(87, 85);
            this.textBox_Vz.Name = "textBox_Vz";
            this.textBox_Vz.ReadOnly = true;
            this.textBox_Vz.Size = new System.Drawing.Size(78, 23);
            this.textBox_Vz.TabIndex = 5;
            // 
            // label_Vx
            // 
            this.label_Vx.AutoSize = true;
            this.label_Vx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Vx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Vx.ForeColor = System.Drawing.Color.White;
            this.label_Vx.Location = new System.Drawing.Point(3, 41);
            this.label_Vx.Name = "label_Vx";
            this.label_Vx.Size = new System.Drawing.Size(78, 41);
            this.label_Vx.TabIndex = 2;
            this.label_Vx.Text = "Velocity_X";
            // 
            // textBox_Vx
            // 
            this.textBox_Vx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Vx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Vx.Location = new System.Drawing.Point(87, 44);
            this.textBox_Vx.Name = "textBox_Vx";
            this.textBox_Vx.ReadOnly = true;
            this.textBox_Vx.Size = new System.Drawing.Size(78, 23);
            this.textBox_Vx.TabIndex = 3;
            // 
            // label_velocity
            // 
            this.label_velocity.AutoSize = true;
            this.label_velocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_velocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_velocity.ForeColor = System.Drawing.Color.White;
            this.label_velocity.Location = new System.Drawing.Point(3, 0);
            this.label_velocity.Name = "label_velocity";
            this.label_velocity.Size = new System.Drawing.Size(78, 41);
            this.label_velocity.TabIndex = 0;
            this.label_velocity.Text = "Velocity";
            // 
            // textBox_velocity
            // 
            this.textBox_velocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_velocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_velocity.Location = new System.Drawing.Point(87, 3);
            this.textBox_velocity.Name = "textBox_velocity";
            this.textBox_velocity.ReadOnly = true;
            this.textBox_velocity.Size = new System.Drawing.Size(78, 23);
            this.textBox_velocity.TabIndex = 1;
            // 
            // panel_charts
            // 
            this.panel_charts.ColumnCount = 1;
            this.panel_charts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_charts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_charts.Controls.Add(this.chart_altitude, 0, 0);
            this.panel_charts.Controls.Add(this.chart_velocity, 0, 1);
            this.panel_charts.Controls.Add(this.panel_stateControls, 0, 2);
            this.panel_charts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_charts.Location = new System.Drawing.Point(174, 0);
            this.panel_charts.Margin = new System.Windows.Forms.Padding(0);
            this.panel_charts.Name = "panel_charts";
            this.panel_charts.RowCount = 3;
            this.panel_charts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_charts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_charts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panel_charts.Size = new System.Drawing.Size(448, 686);
            this.panel_charts.TabIndex = 1;
            // 
            // chart_altitude
            // 
            chartArea15.Name = "ChartArea1";
            this.chart_altitude.ChartAreas.Add(chartArea15);
            this.chart_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Name = "Legend1";
            this.chart_altitude.Legends.Add(legend15);
            this.chart_altitude.Location = new System.Drawing.Point(3, 3);
            this.chart_altitude.Name = "chart_altitude";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Altitude";
            this.chart_altitude.Series.Add(series15);
            this.chart_altitude.Size = new System.Drawing.Size(442, 199);
            this.chart_altitude.TabIndex = 0;
            this.chart_altitude.Text = "chart1";
            this.chart_altitude.Click += new System.EventHandler(this.chart_altitude_Click);
            // 
            // chart_velocity
            // 
            chartArea16.Name = "ChartArea1";
            this.chart_velocity.ChartAreas.Add(chartArea16);
            this.chart_velocity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend16.Name = "Legend1";
            this.chart_velocity.Legends.Add(legend16);
            this.chart_velocity.Location = new System.Drawing.Point(3, 208);
            this.chart_velocity.Name = "chart_velocity";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Velocity";
            this.chart_velocity.Series.Add(series16);
            this.chart_velocity.Size = new System.Drawing.Size(442, 199);
            this.chart_velocity.TabIndex = 1;
            this.chart_velocity.Text = "chart1";
            // 
            // panel_stateControls
            // 
            this.panel_stateControls.ColumnCount = 2;
            this.panel_stateControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_stateControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_stateControls.Controls.Add(this.label_controlsText, 1, 0);
            this.panel_stateControls.Controls.Add(this.label_stateText, 0, 0);
            this.panel_stateControls.Controls.Add(this.textBox_state, 0, 1);
            this.panel_stateControls.Controls.Add(this.textBox_controls, 1, 1);
            this.panel_stateControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_stateControls.Location = new System.Drawing.Point(3, 413);
            this.panel_stateControls.Name = "panel_stateControls";
            this.panel_stateControls.RowCount = 2;
            this.panel_stateControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_stateControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.panel_stateControls.Size = new System.Drawing.Size(442, 270);
            this.panel_stateControls.TabIndex = 2;
            // 
            // label_controlsText
            // 
            this.label_controlsText.AutoSize = true;
            this.label_controlsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_controlsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_controlsText.ForeColor = System.Drawing.Color.White;
            this.label_controlsText.Location = new System.Drawing.Point(224, 0);
            this.label_controlsText.Name = "label_controlsText";
            this.label_controlsText.Size = new System.Drawing.Size(215, 27);
            this.label_controlsText.TabIndex = 1;
            this.label_controlsText.Text = "Controls";
            this.label_controlsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_stateText
            // 
            this.label_stateText.AutoSize = true;
            this.label_stateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_stateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_stateText.ForeColor = System.Drawing.Color.White;
            this.label_stateText.Location = new System.Drawing.Point(3, 0);
            this.label_stateText.Name = "label_stateText";
            this.label_stateText.Size = new System.Drawing.Size(215, 27);
            this.label_stateText.TabIndex = 0;
            this.label_stateText.Text = "State";
            this.label_stateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_state
            // 
            this.textBox_state.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_state.Location = new System.Drawing.Point(3, 30);
            this.textBox_state.Multiline = true;
            this.textBox_state.Name = "textBox_state";
            this.textBox_state.ReadOnly = true;
            this.textBox_state.Size = new System.Drawing.Size(215, 237);
            this.textBox_state.TabIndex = 2;
            // 
            // textBox_controls
            // 
            this.textBox_controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_controls.Location = new System.Drawing.Point(224, 30);
            this.textBox_controls.Multiline = true;
            this.textBox_controls.Name = "textBox_controls";
            this.textBox_controls.ReadOnly = true;
            this.textBox_controls.Size = new System.Drawing.Size(215, 237);
            this.textBox_controls.TabIndex = 3;
            // 
            // panel_3dMap
            // 
            this.panel_3dMap.ColumnCount = 1;
            this.panel_3dMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_3dMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_3dMap.Controls.Add(this.panel_unity, 0, 0);
            this.panel_3dMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_3dMap.Location = new System.Drawing.Point(625, 3);
            this.panel_3dMap.Name = "panel_3dMap";
            this.panel_3dMap.RowCount = 2;
            this.panel_3dMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_3dMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_3dMap.Size = new System.Drawing.Size(617, 680);
            this.panel_3dMap.TabIndex = 2;
            // 
            // panel_unity
            // 
            this.panel_unity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_unity.Location = new System.Drawing.Point(3, 3);
            this.panel_unity.Name = "panel_unity";
            this.panel_unity.Size = new System.Drawing.Size(611, 334);
            this.panel_unity.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1251, 772);
            this.Controls.Add(this.tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(425, 720);
            this.Name = "Form1";
            this.Text = "Lavira Merkut";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel_topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_settings)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.panel_infoText.ResumeLayout(false);
            this.panel_timer.ResumeLayout(false);
            this.panel_timer.PerformLayout();
            this.panel_buttons.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.panel_charts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_altitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_velocity)).EndInit();
            this.panel_stateControls.ResumeLayout(false);
            this.panel_stateControls.PerformLayout();
            this.panel_3dMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel panel_topBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel panel_container;
        private System.Windows.Forms.TableLayoutPanel panel_infoText;
        private System.Windows.Forms.TableLayoutPanel panel_timer;
        private System.Windows.Forms.Label label_timeText;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label_timeLaunch;
        private System.Windows.Forms.TableLayoutPanel panel_buttons;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.TableLayoutPanel panel_charts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_altitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_velocity;
        private System.Windows.Forms.TableLayoutPanel panel_stateControls;
        private System.Windows.Forms.Label label_controlsText;
        private System.Windows.Forms.Label label_stateText;
        private System.Windows.Forms.TextBox textBox_state;
        private System.Windows.Forms.TextBox textBox_controls;
        private System.Windows.Forms.TableLayoutPanel panel_info;
        private System.Windows.Forms.Label label_accelerationZ;
        private System.Windows.Forms.TextBox textBox_accelerationZ;
        private System.Windows.Forms.Label label_accelerationY;
        private System.Windows.Forms.TextBox textBox_accelerationY;
        private System.Windows.Forms.Label label_accelerationX;
        private System.Windows.Forms.TextBox textBox_accelerationX;
        private System.Windows.Forms.Label label_moisture;
        private System.Windows.Forms.TextBox textBox_moisture;
        private System.Windows.Forms.Label label_pressure;
        private System.Windows.Forms.TextBox textBox_pressure;
        private System.Windows.Forms.Label label_temperature;
        private System.Windows.Forms.TextBox textBox_temperature;
        private System.Windows.Forms.Label label_locationY;
        private System.Windows.Forms.TextBox textBox_locationY;
        private System.Windows.Forms.Label label_locationX;
        private System.Windows.Forms.TextBox textBox_locationX;
        private System.Windows.Forms.Label label_altitude;
        private System.Windows.Forms.TextBox textBox_altitude;
        private System.Windows.Forms.Label label_Vz;
        private System.Windows.Forms.TextBox textBox_Vz;
        private System.Windows.Forms.Label label_Vx;
        private System.Windows.Forms.TextBox textBox_Vx;
        private System.Windows.Forms.Label label_velocity;
        private System.Windows.Forms.TextBox textBox_velocity;
        private System.Windows.Forms.TableLayoutPanel panel_3dMap;
        private System.Windows.Forms.Panel panel_unity;
        private System.Windows.Forms.TableLayoutPanel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_settings;
    }
}

