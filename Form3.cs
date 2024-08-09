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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private async void OnLoad(object sender, EventArgs e)
        {
            var result = await custom.API("andyxie.cn");
            
                if(result.players.list != null)
            {
                foreach (var players in result.players.list)
                {
                    listBox1.Items.Add(players.name);
                }
            }
                

            
            


            string icon = result.icon;
            icon = icon.Substring(icon.IndexOf(",") + 1);


            var icon_img = Convert.FromBase64String(icon);

            using (MemoryStream ms = new MemoryStream(icon_img))
            {

                Image icon_img_real = Image.FromStream(ms);
                var img = icon_img_real;
                var newImage = new Bitmap(145, 145);

                using (var gr = Graphics.FromImage(newImage))
                {
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    gr.DrawImage(img, 0, 0, newImage.Width, newImage.Height);
                }

                pictureBox1.Image = newImage;

            }
        }

        private void copy(object sender, EventArgs e)
        {
            Clipboard.SetText(listBox1.SelectedItem.ToString());
        }
    }
}
