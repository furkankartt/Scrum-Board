using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrum
{
    public partial class FormScrum : Form
    {
        public FormHikayeEkle HikayeFormu = new FormHikayeEkle();
        public FormGorevEkle GorevFormu = new FormGorevEkle();
        public List<Hikaye> Hikayeler = new List<Hikaye>();
        public List<Gorev> Gorevler = new List<Gorev>();

        public FormScrum()
        {
            InitializeComponent();

            HikayeFormu.Scrum = this;
            GorevFormu.Scrum = this;
        }
        

        private void buttonHikayeEkle_Click(object sender, EventArgs e)
        {
            HikayeFormu.ShowDialog();
        }

        private void buttonGorevEkle_Click(object sender, EventArgs e)
        {
            GorevFormu.ShowDialog();
        }

        public void HikayeGoruntule(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                foreach (Hikaye hky in Hikayeler)
                {
                    MessageBox.Show("Hikaye Başlığı: " + hky.HikayeBasligi + Environment.NewLine + "Hikaye Bitiş Süresi: " + hky.HikayeBitisSuresi 
                        + Environment.NewLine + "Hikaye İçeriği: " + hky.HikayeIcerik);
                }
            }
        }

        public void GorevGoruntule(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Gorev grv in Gorevler)
                {
                    MessageBox.Show("Hikaye Başlığı: " + grv.HikayeBasligi + Environment.NewLine + "Görev Kategori:  " + grv.GorevKategori
                        + Environment.NewLine + "Görev İsmi: " + grv.GorevIsmi + Environment.NewLine + "Görev Sahibi: "+ grv.GorevSahibi + Environment.NewLine 
                        + "Görev Tarihi : " + grv.GorevTarihi + Environment.NewLine + "Görev İçeriği: " + grv.GorevIcerik);
                }
            }
        }

        bool Durum = false;
        Point IlkKonum;

        public void GorevSurukleBirakMove (object sender, MouseEventArgs e)
        {
            Button ButonSec = (sender as Button);
            if(Durum)
            {
                this.Controls.Add(ButonSec);
                ButonSec.BringToFront();
                ButonSec.Left = e.X + ButonSec.Left - (IlkKonum.X);
                ButonSec.Top = e.Y + ButonSec.Top - (IlkKonum.Y);
            }
        }

        public void GorevSurukleBirakDown(object sender, MouseEventArgs e)
        {
            Button ButonSec = (sender as Button);
            Durum = true;
            ButonSec.Cursor = Cursors.SizeAll;
            IlkKonum = e.Location;
        }

        public void GorevSurukleBirakUp(object sender, MouseEventArgs e)
        {
            Button ButonSec = (sender as Button);
            foreach (Gorev item in Gorevler)
            {
                Durum = false;
                ButonSec.Cursor = Cursors.Default;
                if((ButonSec.Location.X > panelBaslanacak.Location.X) && (ButonSec.Location.X < (panelBaslanacak.Location.X + panelBaslanacak.Width)) &&
                    (ButonSec.Location.Y > panelBaslanacak.Location.Y) && (panelBaslanacak.Location.Y < (panelBaslanacak.Location.Y + panelBaslanacak.Height)) )
                {
                    item.GorevKategori = "Başlanacak";
                    this.Controls.Remove(ButonSec);
                }

                else if ((ButonSec.Location.X > panelDevamEden.Location.X) && (ButonSec.Location.X < (panelDevamEden.Location.X + panelDevamEden.Width)) &&
                    (ButonSec.Location.Y > panelDevamEden.Location.Y) && (panelDevamEden.Location.Y < (panelDevamEden.Location.Y + panelDevamEden.Height)))
                {
                    item.GorevKategori = "Devam Eden";
                    this.Controls.Remove(ButonSec);
                }

                else if ((ButonSec.Location.X > panelBiten.Location.X) && (ButonSec.Location.X < (panelBiten.Location.X + panelBiten.Width)) &&
                    (ButonSec.Location.Y > panelBiten.Location.Y) && (panelBiten.Location.Y < (panelBiten.Location.Y + panelBiten.Height)))
                {
                    item.GorevKategori = "Biten";
                    this.Controls.Remove(ButonSec);
                }

                else
                {
                    this.Controls.Remove(ButonSec);
                }
            }
            GorevFormu.GorevEkle();
        }
        
    }
}
