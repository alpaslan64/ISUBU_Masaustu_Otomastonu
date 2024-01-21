using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Bitirme_Projesi
{
    public partial class Form2 : Form
    {

        string obs = "https://obs.isparta.edu.tr";
        string giris = "https://obs.isparta.edu.tr/Birimler/Ogrenci/Bilgilerim.aspx";
        string donem_dersleri_link = "https://obs.isparta.edu.tr/Birimler/Ogrenci/DonemDersleri.aspx";
        string devamsizlik_link = "https://obs.isparta.edu.tr/Birimler/Ogrenci/OgrenciDevamTakibi.aspx";
        string dokuman_link = "https://obs.isparta.edu.tr/Birimler/Ogrenci/DersDokumanlari.aspx";
        string ders_bilgi_link = "https://obs.isparta.edu.tr/Birimler/Ogrenci/Derslerim.aspx";
        string not_ort_link = "https://obs.isparta.edu.tr/Birimler/Ogrenci/NotOrtalamasiHesapla.aspx";
        string ders_prog_link = "https://obs.isparta.edu.tr/Birimler/Ogrenci/DersProgrami.aspx";
        string yemekhane_link = "https://yemek.isparta.edu.tr/";
        string zstaj_link = "https://obs.isparta.edu.tr/Birimler/Ogrenci/ZorunluStajBasvuru.aspx";
        string is_yeri_link = "https://obs.isparta.edu.tr/Birimler/Ogrenci/IsyeriEgitimiBasvuruMyo.aspx";
        string meyok_link = "https://meyok.isparta.edu.tr/";

        public Form2()
        {
            InitializeComponent();
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Hide();
        }

        private void NavigateAndAutomate()
        {
            webBrowser1.Navigate(obs);
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument document = webBrowser1.Document;
            HtmlElement numaraTextBox = document.GetElementById("textKulID");
            HtmlElement sifreTextBox = document.GetElementById("textSifre");
            HtmlElement submitButton = document.GetElementById("buttonTamam");

            if (numaraTextBox != null && sifreTextBox != null && submitButton != null)
            {
                numaraTextBox.SetAttribute("value", Properties.Settings.Default.numara);
                sifreTextBox.SetAttribute("value", Properties.Settings.Default.sifre);
                submitButton.InvokeMember("click");
            }

            if (webBrowser1.Url.AbsoluteUri == giris) webBrowser1.Show(); 
        }

        private void donemdersleri_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(donem_dersleri_link);
        }
        private void devamsizlik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(devamsizlik_link);
        }
        private void dokumanlar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(dokuman_link);
        }
        private void ders_bilgi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(ders_bilgi_link);
        }
        private void not_ort_hesap_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(not_ort_link);
        }
        private void ders_prog_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(ders_prog_link);
        }

        private void yemekhane_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(yemekhane_link);
        }
        private void zstaj_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(zstaj_link);
        }
        private void is_yeri_basvuru_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(is_yeri_link);
        }
        private void meyok_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(meyok_link);
        }












        /********************************************************************************************/
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://uluborlumyo.isparta.edu.tr/");
        }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NavigateAndAutomate();
            this.Show();
            this.BringToFront();
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            //bunifuGradientPanel2.Top = bunifuVScrollBar1.Value;
            this.DoubleBuffered = true;
        }
    }
}
