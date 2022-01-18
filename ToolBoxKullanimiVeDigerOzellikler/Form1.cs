using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ToolBoxKullanimiVeDigerOzellikler
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboCins.Items.Add("Bay");
            ComboCins.Items.Add("Bayan");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Deger = txtAd.Text + " " + txtSoyad.Text + " " + DateTimeDogum.Text + " " + ComboCins.Text; // İlkel Yol

            string Deger2 = $@"{txtAd.Text} {txtSoyad.Text} {DateTimeDogum.Text} {ComboCins.Text}"; // Modern Yol

            string Ad, Soyad, DogumYili, Cinsiyet; // Parçalı İşleme Yolu
            DateTime DY = Convert.ToDateTime(DateTimeDogum.Value);
            Ad = txtAd.Text;
            Soyad = txtSoyad.Text;
            DogumYili = DY.ToShortDateString();
            Cinsiyet = ComboCins.Text;
            ListPersonel.Items.Add($@"{Ad} {Soyad} {DogumYili} {Cinsiyet}");
        }
    }
}
