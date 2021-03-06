﻿namespace NinjaTranslate
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtbox_search_shortkey = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.btn_history = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quickChangeInMemory = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_window_width = new System.Windows.Forms.NumericUpDown();
            this.numeric_window_height = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_clipboardAccess = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.quickChangeKey = new System.Windows.Forms.CheckBox();
            this.currentKey = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_dict = new System.Windows.Forms.Button();
            this.comboBox_dict = new System.Windows.Forms.ComboBox();
            this.btn_browse_dict = new System.Windows.Forms.Button();
            this.textBox_path_to_dict = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_restore_shortkeys = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox_openinput_shortkey = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_window_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_window_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clipboardAccess)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_search_shortkey
            // 
            this.txtbox_search_shortkey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtbox_search_shortkey.Enabled = false;
            this.txtbox_search_shortkey.Location = new System.Drawing.Point(277, 30);
            this.txtbox_search_shortkey.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_search_shortkey.Name = "txtbox_search_shortkey";
            this.txtbox_search_shortkey.ReadOnly = true;
            this.txtbox_search_shortkey.Size = new System.Drawing.Size(171, 22);
            this.txtbox_search_shortkey.TabIndex = 5;
            this.txtbox_search_shortkey.Click += new System.EventHandler(this.txtbox_search_shortkey_focused);
            this.txtbox_search_shortkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_search_shortkey_KeyDown);
            this.txtbox_search_shortkey.Leave += new System.EventHandler(this.txtbox_search_shortkey_Leave);
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.Control;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(21, 642);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(457, 38);
            this.description.TabIndex = 7;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NinjaTranslate";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Settings";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Exit NinjaTranslate";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(12, 526);
            this.btn_history.Margin = new System.Windows.Forms.Padding(4);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(107, 28);
            this.btn_history.TabIndex = 8;
            this.btn_history.Text = "Show History";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Visible = false;
            this.btn_history.Click += new System.EventHandler(this.Btn_history_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quickChangeInMemory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numeric_window_width);
            this.groupBox1.Controls.Add(this.numeric_window_height);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numeric_clipboardAccess);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // quickChangeInMemory
            // 
            this.quickChangeInMemory.AutoSize = true;
            this.quickChangeInMemory.Location = new System.Drawing.Point(280, 53);
            this.quickChangeInMemory.Margin = new System.Windows.Forms.Padding(4);
            this.quickChangeInMemory.Name = "quickChangeInMemory";
            this.quickChangeInMemory.Size = new System.Drawing.Size(18, 17);
            this.quickChangeInMemory.TabIndex = 26;
            this.quickChangeInMemory.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Keep quick change dictionary in memory:";
            this.toolTip1.SetToolTip(this.label11, "Defines the time of how long NinjaTranslate waits until\r\nit takes the data from t" +
        "he clipboard. Increase the timer if\r\nNinjaTranslate ist having troubles translat" +
        "ing the selected\r\nword.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "px";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "px";
            // 
            // numeric_window_width
            // 
            this.numeric_window_width.Location = new System.Drawing.Point(280, 110);
            this.numeric_window_width.Margin = new System.Windows.Forms.Padding(4);
            this.numeric_window_width.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numeric_window_width.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_window_width.Name = "numeric_window_width";
            this.numeric_window_width.Size = new System.Drawing.Size(137, 22);
            this.numeric_window_width.TabIndex = 23;
            this.numeric_window_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeric_window_width.Value = new decimal(new int[] {
            420,
            0,
            0,
            0});
            // 
            // numeric_window_height
            // 
            this.numeric_window_height.Location = new System.Drawing.Point(280, 80);
            this.numeric_window_height.Margin = new System.Windows.Forms.Padding(4);
            this.numeric_window_height.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numeric_window_height.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_window_height.Name = "numeric_window_height";
            this.numeric_window_height.Size = new System.Drawing.Size(137, 22);
            this.numeric_window_height.TabIndex = 18;
            this.numeric_window_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeric_window_height.Value = new decimal(new int[] {
            340,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Window Width";
            this.toolTip1.SetToolTip(this.label8, "Defines the time of how long NinjaTranslate waits until\r\nit takes the data from t" +
        "he clipboard. Increase the timer if\r\nNinjaTranslate ist having troubles translat" +
        "ing the selected\r\nword.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Window Height";
            this.toolTip1.SetToolTip(this.label3, "Defines the time of how long NinjaTranslate waits until\r\nit takes the data from t" +
        "he clipboard. Increase the timer if\r\nNinjaTranslate ist having troubles translat" +
        "ing the selected\r\nword.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "ms";
            // 
            // numeric_clipboardAccess
            // 
            this.numeric_clipboardAccess.Location = new System.Drawing.Point(280, 23);
            this.numeric_clipboardAccess.Margin = new System.Windows.Forms.Padding(4);
            this.numeric_clipboardAccess.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numeric_clipboardAccess.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numeric_clipboardAccess.Name = "numeric_clipboardAccess";
            this.numeric_clipboardAccess.Size = new System.Drawing.Size(137, 22);
            this.numeric_clipboardAccess.TabIndex = 14;
            this.numeric_clipboardAccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeric_clipboardAccess.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Clipboard Access Timer:";
            this.toolTip1.SetToolTip(this.label4, "Defines the time of how long NinjaTranslate waits until\r\nit takes the data from t" +
        "he clipboard. Increase the timer if\r\nNinjaTranslate ist having troubles translat" +
        "ing the selected\r\nword.");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.infoButton);
            this.groupBox2.Controls.Add(this.keyTextBox);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.quickChangeKey);
            this.groupBox2.Controls.Add(this.currentKey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_add_dict);
            this.groupBox2.Controls.Add(this.comboBox_dict);
            this.groupBox2.Controls.Add(this.btn_browse_dict);
            this.groupBox2.Controls.Add(this.textBox_path_to_dict);
            this.groupBox2.Location = new System.Drawing.Point(13, 165);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(465, 181);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dictionaries";
            // 
            // infoButton
            // 
            this.infoButton.AutoSize = true;
            this.infoButton.Location = new System.Drawing.Point(167, 137);
            this.infoButton.Margin = new System.Windows.Forms.Padding(4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(147, 33);
            this.infoButton.TabIndex = 29;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Enabled = false;
            this.keyTextBox.Location = new System.Drawing.Point(11, 62);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(65, 22);
            this.keyTextBox.TabIndex = 28;
            this.keyTextBox.Text = "Key";
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(263, 90);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(184, 27);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // quickChangeKey
            // 
            this.quickChangeKey.AutoSize = true;
            this.quickChangeKey.Enabled = false;
            this.quickChangeKey.Location = new System.Drawing.Point(141, 94);
            this.quickChangeKey.Margin = new System.Windows.Forms.Padding(4);
            this.quickChangeKey.Name = "quickChangeKey";
            this.quickChangeKey.Size = new System.Drawing.Size(114, 21);
            this.quickChangeKey.TabIndex = 26;
            this.quickChangeKey.Text = "quick change";
            this.quickChangeKey.UseVisualStyleBackColor = true;
            this.quickChangeKey.CheckedChanged += new System.EventHandler(this.quickChangeKey_CheckedChanged);
            // 
            // currentKey
            // 
            this.currentKey.AutoSize = true;
            this.currentKey.Enabled = false;
            this.currentKey.Location = new System.Drawing.Point(12, 94);
            this.currentKey.Margin = new System.Windows.Forms.Padding(4);
            this.currentKey.Name = "currentKey";
            this.currentKey.Size = new System.Drawing.Size(105, 21);
            this.currentKey.TabIndex = 25;
            this.currentKey.Text = "load at start";
            this.currentKey.UseVisualStyleBackColor = true;
            this.currentKey.CheckedChanged += new System.EventHandler(this.currentKey_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dictionary:";
            // 
            // btn_add_dict
            // 
            this.btn_add_dict.AutoSize = true;
            this.btn_add_dict.Location = new System.Drawing.Point(12, 137);
            this.btn_add_dict.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_dict.Name = "btn_add_dict";
            this.btn_add_dict.Size = new System.Drawing.Size(147, 33);
            this.btn_add_dict.TabIndex = 23;
            this.btn_add_dict.Text = "Add Dictionary";
            this.btn_add_dict.UseVisualStyleBackColor = true;
            this.btn_add_dict.Click += new System.EventHandler(this.Btn_add_dict_Click);
            // 
            // comboBox_dict
            // 
            this.comboBox_dict.FormattingEnabled = true;
            this.comboBox_dict.Location = new System.Drawing.Point(276, 27);
            this.comboBox_dict.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_dict.Name = "comboBox_dict";
            this.comboBox_dict.Size = new System.Drawing.Size(171, 24);
            this.comboBox_dict.TabIndex = 1;
            this.comboBox_dict.Text = "select Dictionary";
            this.comboBox_dict.SelectedIndexChanged += new System.EventHandler(this.ComboBox_dict_SelectedIndexChanged);
            // 
            // btn_browse_dict
            // 
            this.btn_browse_dict.Enabled = false;
            this.btn_browse_dict.Location = new System.Drawing.Point(352, 60);
            this.btn_browse_dict.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browse_dict.Name = "btn_browse_dict";
            this.btn_browse_dict.Size = new System.Drawing.Size(96, 27);
            this.btn_browse_dict.TabIndex = 19;
            this.btn_browse_dict.Text = "Browse";
            this.btn_browse_dict.UseVisualStyleBackColor = true;
            this.btn_browse_dict.Click += new System.EventHandler(this.Btn_browse_dict_Click);
            // 
            // textBox_path_to_dict
            // 
            this.textBox_path_to_dict.Enabled = false;
            this.textBox_path_to_dict.Location = new System.Drawing.Point(85, 62);
            this.textBox_path_to_dict.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_path_to_dict.Name = "textBox_path_to_dict";
            this.textBox_path_to_dict.ReadOnly = true;
            this.textBox_path_to_dict.Size = new System.Drawing.Size(256, 22);
            this.textBox_path_to_dict.TabIndex = 18;
            this.textBox_path_to_dict.Text = "Path to Dictionary";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbox_search_shortkey);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btn_restore_shortkeys);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtbox_openinput_shortkey);
            this.groupBox3.Location = new System.Drawing.Point(13, 359);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(465, 155);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shortkeys";
            this.groupBox3.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Translate Selected Text:";
            // 
            // btn_restore_shortkeys
            // 
            this.btn_restore_shortkeys.Location = new System.Drawing.Point(9, 107);
            this.btn_restore_shortkeys.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restore_shortkeys.Name = "btn_restore_shortkeys";
            this.btn_restore_shortkeys.Size = new System.Drawing.Size(137, 27);
            this.btn_restore_shortkeys.TabIndex = 24;
            this.btn_restore_shortkeys.Text = "Restore Default";
            this.btn_restore_shortkeys.UseVisualStyleBackColor = true;
            this.btn_restore_shortkeys.Click += new System.EventHandler(this.Btn_restore_shortkeys_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Open Input Form:";
            // 
            // txtbox_openinput_shortkey
            // 
            this.txtbox_openinput_shortkey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtbox_openinput_shortkey.Enabled = false;
            this.txtbox_openinput_shortkey.Location = new System.Drawing.Point(277, 62);
            this.txtbox_openinput_shortkey.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_openinput_shortkey.Name = "txtbox_openinput_shortkey";
            this.txtbox_openinput_shortkey.ReadOnly = true;
            this.txtbox_openinput_shortkey.Size = new System.Drawing.Size(171, 22);
            this.txtbox_openinput_shortkey.TabIndex = 21;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(372, 526);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 28);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(257, 526);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 28);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 561);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "NinjaTranslate - Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_window_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_window_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_clipboardAccess)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.TextBox txtbox_search_shortkey;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_clipboardAccess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add_dict;
        private System.Windows.Forms.Button btn_browse_dict;
        private System.Windows.Forms.TextBox textBox_path_to_dict;
        private System.Windows.Forms.ComboBox comboBox_dict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_restore_shortkeys;
        private System.Windows.Forms.TextBox txtbox_openinput_shortkey;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_window_width;
        private System.Windows.Forms.NumericUpDown numeric_window_height;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox currentKey;
        private System.Windows.Forms.CheckBox quickChangeInMemory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckBox quickChangeKey;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label label4;
    }
}

