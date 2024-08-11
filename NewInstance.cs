using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NewInstance : Form
    {
        public NewInstance()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("A host is required. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NewInstance newInstance = new NewInstance();
            Program.Save(new Instance
            {
                id = Program.config.Instance.Last<Instance>().id + 1,
                Host = this.textBox1.Text

            });
            Program.Load_Reload();
            string host = Program.config.Instance.Last<Instance>().Host;
            TabPage tab = new TabPage();
            Panel panel = new Panel();

            tab.Controls.Add(panel);

            panel.Dock = DockStyle.Fill;

            panel.AutoSize = false;
            Form3 form3_ = new Form3(Program.config.Instance.Last<Instance>().Host);
            form3_.FormBorderStyle = FormBorderStyle.None;
            form3_.TopLevel = false;
            panel.Controls.Add(form3_);
            form3_.Dock = DockStyle.Fill;
            form3_.Show();
            tab.Text = host;
            Form1.tabControl1.TabPages.Add(tab);
            this.Close();
        }
    }
}
