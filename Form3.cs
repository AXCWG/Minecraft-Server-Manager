using RconSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
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




            string icon = result.icon;
            icon = icon.Substring(icon.IndexOf(",") + 1);


            var icon_img = Convert.FromBase64String(icon);

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
            textBox1.Text += "Completed.";
        }
        private async void OnLoad(object sender, EventArgs e)
        {
           
            BackgroundWorker backgroundWorker    = new BackgroundWorker();
            backgroundWorker.DoWork += Backgroundworker_work;
            backgroundWorker.RunWorkerCompleted += Backgroundworker_done;
            backgroundWorker.RunWorkerAsync();
            
           
        }

        private void copy(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());

            }
            catch(NullReferenceException ex)
            {
                
            }
            finally
            {

            }
        }

        private async void refresh_click_action(object sender, EventArgs e)
        {
            GC.Collect();
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += Backgroundworker_work;
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
            };
            

            
        }
        private async void connect(object sender, EventArgs e)
        {
            


        }
    }
}
