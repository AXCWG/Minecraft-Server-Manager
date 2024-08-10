using Newtonsoft.Json;

namespace WinFormsApp1;



public partial class Form1 : Form
{

    public Form1()
    {

        InitializeComponent();
    }

    private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void aboutThisSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2();
        form2.ShowDialog();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        System.Environment.Exit(0);
    }

    private void form1_onload(object sender, EventArgs e)
    {
        foreach(Instance instance in Program.config.Instance)
        {
            string host = instance.Host;
            TabPage tab = new TabPage();
            Panel panel = new Panel();
            
            tab.Controls.Add(panel);
            
            panel.Dock = DockStyle.Fill;
          
            panel.AutoSize = false;
            Form3 form3_ = new Form3(instance.Host);
            form3_.FormBorderStyle = FormBorderStyle.None;
            form3_.TopLevel = false;
            panel.Controls.Add(form3_); 
           form3_.Dock = DockStyle.Fill;
            form3_.Show();
            tab.Text = host;
            tabControl1.TabPages.Add(tab);
        }
        
        
    }
    private void copy_name(object sender, EventArgs e)
    {
        
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }
}
