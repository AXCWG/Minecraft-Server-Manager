namespace WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    /// 


    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        menuStrip1 = new MenuStrip();
        fIleToolStripMenuItem = new ToolStripMenuItem();
        newInstanceToolStripMenuItem = new ToolStripMenuItem();
        readFromFileToolStripMenuItem = new ToolStripMenuItem();
        settingsToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        aboutThisSoftwareToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        exitToolStripMenuItem = new ToolStripMenuItem();
        tabControl1 = new TabControl();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fIleToolStripMenuItem
        // 
        fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newInstanceToolStripMenuItem, readFromFileToolStripMenuItem });
        fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
        fIleToolStripMenuItem.Size = new Size(63, 20);
        fIleToolStripMenuItem.Text = "Instance";
        // 
        // newInstanceToolStripMenuItem
        // 
        newInstanceToolStripMenuItem.Name = "newInstanceToolStripMenuItem";
        newInstanceToolStripMenuItem.Size = new Size(180, 22);
        newInstanceToolStripMenuItem.Text = "New Instance";
        // 
        // readFromFileToolStripMenuItem
        // 
        readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
        readFromFileToolStripMenuItem.Size = new Size(180, 22);
        readFromFileToolStripMenuItem.Text = "&Read From File";
        // 
        // settingsToolStripMenuItem
        // 
        settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
        settingsToolStripMenuItem.Size = new Size(61, 20);
        settingsToolStripMenuItem.Text = "Settings";
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutThisSoftwareToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(44, 20);
        helpToolStripMenuItem.Text = "Help";
        // 
        // aboutThisSoftwareToolStripMenuItem
        // 
        aboutThisSoftwareToolStripMenuItem.Name = "aboutThisSoftwareToolStripMenuItem";
        aboutThisSoftwareToolStripMenuItem.Size = new Size(178, 22);
        aboutThisSoftwareToolStripMenuItem.Text = "About this program";
        aboutThisSoftwareToolStripMenuItem.Click += aboutThisSoftwareToolStripMenuItem_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(175, 6);
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(178, 22);
        exitToolStripMenuItem.Text = "Exit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // tabControl1
        // 
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.Location = new Point(0, 24);
        tabControl1.Name = "tabControl1";
        tabControl1.Padding = new Point(0, 0);
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(800, 447);
        tabControl1.TabIndex = 1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 471);
        Controls.Add(tabControl1);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        MaximizeBox = false;
        Name = "Form1";
        Text = "Minecraft Server Manager";
        Load += form1_onload;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem fIleToolStripMenuItem;
    private ToolStripMenuItem newInstanceToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem aboutThisSoftwareToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem settingsToolStripMenuItem;
    private ToolStripMenuItem readFromFileToolStripMenuItem;
    private TabControl tabControl1;
}
