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
        string temp_datasource = "andyxie.cn";
        tabPage1.Text = temp_datasource;
        Form3 form3 = new Form3(temp_datasource);
        form3.FormBorderStyle = FormBorderStyle.None;
        form3.TopLevel = false;
        this.panel1.Controls.Add(form3);
        form3.Width = panel1.Width;
        form3.Height = panel1.Height;
        form3.Show();

    }
    private void copy_name(object sender, EventArgs e)
    {
        
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }
}
