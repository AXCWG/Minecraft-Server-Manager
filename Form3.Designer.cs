﻿namespace WinFormsApp1
{
    partial class Form3
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ip = new Label();
            port = new Label();
            motd = new Label();
            version = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            listBox1 = new ListBox();
            refresh = new Button();
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 177);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 155);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(151, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 151);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ip, 0, 0);
            tableLayoutPanel1.Controls.Add(port, 0, 1);
            tableLayoutPanel1.Controls.Add(motd, 0, 2);
            tableLayoutPanel1.Controls.Add(version, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(388, 151);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ip
            // 
            ip.Dock = DockStyle.Fill;
            ip.Location = new Point(3, 0);
            ip.Name = "ip";
            ip.Size = new Size(382, 37);
            ip.TabIndex = 4;
            ip.Text = "IP: ";
            ip.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // port
            // 
            port.Dock = DockStyle.Fill;
            port.Location = new Point(3, 37);
            port.Name = "port";
            port.Size = new Size(382, 37);
            port.TabIndex = 5;
            port.Text = "Port: ";
            port.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // motd
            // 
            motd.Dock = DockStyle.Fill;
            motd.Location = new Point(3, 74);
            motd.Name = "motd";
            motd.Size = new Size(382, 37);
            motd.TabIndex = 6;
            motd.Text = "Motd: ";
            motd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // version
            // 
            version.Dock = DockStyle.Fill;
            version.Location = new Point(3, 111);
            version.Name = "version";
            version.Size = new Size(382, 40);
            version.TabIndex = 7;
            version.Text = "Version: ";
            version.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources._636977108000120237;
            pictureBox1.InitialImage = Properties.Resources._636977108000120237;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(listBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(refresh, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 91.69231F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.307693F));
            tableLayoutPanel2.Size = new Size(131, 364);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(125, 327);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += copy;
            // 
            // refresh
            // 
            refresh.Dock = DockStyle.Fill;
            refresh.Location = new Point(3, 336);
            refresh.Name = "refresh";
            refresh.Size = new Size(125, 25);
            refresh.TabIndex = 4;
            refresh.Text = "Refresh Player List";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_click_action;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(684, 364);
            splitContainer1.SplitterDistance = 549;
            splitContainer1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(549, 187);
            panel4.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(549, 187);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(543, 152);
            textBox1.TabIndex = 0;
            textBox1.Text = "dwadwa\r\nkuhykuykykykyuky";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 161);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(543, 23);
            textBox2.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 364);
            Controls.Add(splitContainer1);
            Name = "Form3";
            Text = "Form3";
            Load += OnLoad;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox listBox1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ip;
        private Label port;
        private Label motd;
        private Label version;
        private Button refresh;
        private SplitContainer splitContainer1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}