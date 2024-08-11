using RconSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public bool icon_initialized { get; set; }

        string request_url;
        public Form3(string requested_url)
        {
            this.request_url = requested_url;
            InitializeComponent();
        }
        private async void Backgroundworker_work(object sender, DoWorkEventArgs e)
        {
            var result = await custom.API(request_url);
            e.Result = result;
        }
        byte[] icon_img; 
        private void Backgroundworker_done(object sender, RunWorkerCompletedEventArgs e)
        {
            listBox1.Items.Clear();

            var result = e.Result as Rootobject;
            if (result.players.list != null)
            {
                foreach (var players in result.players.list)
                {
                    listBox1.Items.Add(players.name);
                }
            }


            ip.Text += result.ip;
            port.Text += result.port;
            foreach (var motds in result.motd.clean)
            {
                motd.Text += motds;


            }
            version.Text += result.version;


            if(result.icon != null)
            {
                icon_initialized = true;

            }
            string icon = result.icon;
            icon = icon.Substring(icon.IndexOf(",") + 1);


           icon_img = Convert.FromBase64String(icon);

            using (MemoryStream ms = new MemoryStream(icon_img))
            {

                Image icon_img_real = Image.FromStream(ms);
                var img = icon_img_real;
                var newImage = new Bitmap(151, 151);

                using (var gr = Graphics.FromImage(newImage))
                {
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    gr.DrawImage(img, 0, 0, newImage.Width, newImage.Height);
                }

                pictureBox1.Image = newImage;


            }
            
            if(icon_initialized == true)
            {

                System.Windows.Forms.ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Items.Add("Save image...", null, save_image);
                pictureBox1.ContextMenuStrip = contextMenuStrip;
                

            }
            textBox1.AppendText( "Completed." + "\r\n");
        }
        private void save_image(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "PNG Images (*.png) | *.png";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                try
                {
                    File.WriteAllBytes(path, icon_img);

                }catch (Exception ex)
                {
                    MessageBox.Show("Failed: " + ex.Message, null, MessageBoxButtons.OK);
                }
                

            }



        }
        private async void OnLoad(object sender, EventArgs e)
        {

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += Backgroundworker_work;
            backgroundWorker.RunWorkerCompleted += Backgroundworker_done;
            backgroundWorker.RunWorkerAsync();


        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                send_command();
                e.Handled = true;
                textBox2.Clear();
            }
        }

        private void copy(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());

            }
            catch (NullReferenceException ex)
            {

            }
            finally
            {

            }
        }

        private async void refresh_click_action(object sender, EventArgs e)
        {
            textBox1.AppendText("Refreshing\r\n");

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                Backgroundworker_work(sender,e);
            };
            backgroundWorker.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
            {
                listBox1.Items.Clear();
                var result = e.Result as Rootobject;

                if (result.players.list != null)
                {
                    foreach (var players in result.players.list)
                    {
                        listBox1.Items.Add(players.name);
                    }

                }
                textBox1.AppendText("Done refreshing. \r\n");
            };
            backgroundWorker.RunWorkerAsync();
            GC.Collect();



        }
        Rcons rcons;
        private async void connect(object sender, EventArgs e)
        {
            
            try
            {
                foreach (TextBox textbox in tableLayoutPanel6.Controls.OfType<TextBox>())
                {
                    textbox.Enabled = false;
                }
                foreach (MaskedTextBox masked in tableLayoutPanel6.Controls.OfType<MaskedTextBox>())
                {
                    masked.Enabled = false;
                }
                foreach (Button button in tableLayoutPanel6.Controls.OfType<Button>())
                {
                    button.Enabled = false;
                }
                rcons = await Rcons.InitRcon(textBox3.Text, textBox4.Text, maskedTextBox1.Text);
                textBox1.AppendText( "Connection successful. \r\n");
                
                button2.Text = "Disconnect";
                button2.Enabled = true;
                button2.Click -= connect;
                button2.Click += while_disconnected;
            }
            catch (Exception ex)
            {

                textBox1.AppendText( ex.Message + "\r\n");

            }



        }
        private void while_disconnected(object sender, EventArgs e)
        {
            foreach (TextBox textbox in tableLayoutPanel6.Controls.OfType<TextBox>())
            {
                textbox.Enabled = true;
            }
            foreach (MaskedTextBox masked in tableLayoutPanel6.Controls.OfType<MaskedTextBox>())
            {
                masked.Enabled = true;
            }
            foreach (Button button in tableLayoutPanel6.Controls.OfType<Button>())
            {
                button.Enabled = true;
            }

            tableLayoutPanel6.Enabled = true;
            button2.Text = "Connect";
            button2.Click -= while_disconnected;
            button2.Click += connect;
            GC.Collect();
        }

        private async void send_command(object sender, EventArgs e)
        {
            try
            {
                string output = await Rcons.io(textBox2.Text) + "\r\n";
            textBox1.AppendText(output);
        }catch(NullReferenceException ex)
            {
                textBox1.AppendText(ex.Message + "\r\n");
            }
}
        private async void send_command()
        {
            try {
                string output = await Rcons.io(textBox2.Text) + "\r\n";
                textBox1.AppendText(output);
            }catch(NullReferenceException ex)
            {
                textBox1.AppendText("Please connect to the host first. \r\n");
            }

            
        }
    }
}
