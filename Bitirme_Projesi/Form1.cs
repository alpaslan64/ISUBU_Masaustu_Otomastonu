using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Globalization;
using Bunifu.Framework.UI;

namespace Bitirme_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bunifuCircleProgress1.Hide();
        }
        

        Form2 frm2 = new Form2();
        static string belgelerKlasoru = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        static string logKlasoru = Path.Combine(belgelerKlasoru, "log_files");
        static string logDosyaAdi = $"{DateTime.Now:dd.MM.yyyy-HH.mm}.log";
        static string logDosyaYolu = Path.Combine(logKlasoru, logDosyaAdi);
        public string hataMesaji = "Hatalı numara veya şifre!!";
        public int logSiraNumarasi = 1;


        public void basariliLog(string adi, string soyadi)
        {
            if (!Directory.Exists(logKlasoru))
            {
                Directory.CreateDirectory(logKlasoru);
            }
            string sansurluSifre = sifre.Text.Substring(0, Math.Min(3, sifre.Text.Length)) + new string('•', Math.Max(0, sifre.Text.Length - 3));
            File.AppendAllText(logDosyaYolu, $"Başarılı Giriş! - {DateTime.Now} \nNumara: {numara.Text} \nŞifre: {sansurluSifre}\nGiriş Yapan: {adi} {soyadi}");
        }

        public void basarisizLog()
        {
            if (!Directory.Exists(logKlasoru))
            {
                Directory.CreateDirectory(logKlasoru);
            }
            string sansurluSifre = sifre.Text.Substring(0, Math.Min(3, sifre.Text.Length)) + new string('•', Math.Max(0, sifre.Text.Length - 3));
            File.AppendAllText(logDosyaYolu, $"Başarısız Giriş! - {DateTime.Now} \nNumara: {numara.Text} \nŞifre: {sansurluSifre}\nHata: {hataMesaji}");
        }
        private async Task girisDeneme()
        {
            await Task.Run(() =>
            {
                var edgeDriverService = EdgeDriverService.CreateDefaultService();
                edgeDriverService.HideCommandPromptWindow = true;
                var options = new EdgeOptions();
                options.AddArgument("--headless");
                WebDriver driver = new EdgeDriver(edgeDriverService, options);

                driver.Navigate().GoToUrl("https://obs.isparta.edu.tr/");

                IWebElement numara = driver.FindElement(By.Id("textKulID"));
                numara.SendKeys(this.numara.Text);

                IWebElement sifre = driver.FindElement(By.Id("textSifre"));
                sifre.SendKeys(this.sifre.Text);

                IWebElement tamamButton = driver.FindElement(By.Id("buttonTamam"));
                tamamButton.Click();

                if (driver.Url == "https://obs.isparta.edu.tr/Birimler/Ogrenci/Bilgilerim.aspx")
                {
                    IWebElement adiElement = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_OgrenciTemelBilgiler1_textAdi"));
                    string adi = adiElement.Text;
                    IWebElement soyadiElement = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_OgrenciTemelBilgiler1_textSoyadi"));
                    string soyadi = soyadiElement.Text;

                    MessageBox.Show($"Giriş başarılı! \n\nHoşgeldin {adi} {soyadi}!", "Başarılı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    basariliLog(adi, soyadi);
                    bilgiKayit();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Hide();
                        frm2.Show();
                        frm2.BringToFront();
                    });
                    driver.Quit();
                }

                else
                {
                    MessageBox.Show($"Giriş başarısız, tekrar deneyin!\n{logDosyaYolu}", "Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    basarisizLog();
                    bilgiKayit();
                    driver.Close();
                    Application.Exit();
                    Application.Restart();
                }

                if (Application.OpenForms.Count == 0)
                {
                    if (driver != null)
                    {
                        driver.Quit();
                    }
                }
            });
        }

        public void bilgiKayit()
        {
            Properties.Settings.Default.numara = numara.Text;
            Properties.Settings.Default.sifre = sifre.Text;
            Properties.Settings.Default.Save();
        }
        public void bilgiYaz()
        {
            numara.Text = Properties.Settings.Default.numara;
            sifre.Text = Properties.Settings.Default.sifre;
        }
        private async void girisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numara.Text) || string.IsNullOrEmpty(sifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuCircleProgress1.Hide();
                bunifuCircleProgress1.Animated = false;
                return; 
            }

            bunifuCircleProgress1.Show();
            bunifuCircleProgress1.Animated = true;

            await Task.Run(async () =>
            {
                await Task.Delay(1);

                await girisDeneme();

                this.Invoke((MethodInvoker)delegate
                {
                    bunifuCircleProgress1.Hide();
                    bunifuCircleProgress1.Animated = false;
                });
            });            
        }
        private void geriGetir_Click(object sender, EventArgs e)
        {
            bilgiYaz();
        }

//****************************************************************************************************************************//
        private void numara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)System.Windows.Forms.Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar != (char)System.Windows.Forms.Keys.Back && numara.Text.Length >= 10)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://isparta.edu.tr");
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.UseSystemPasswordChar = false;
            }
            else sifre.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2.Show();
        }
    }
    
}
