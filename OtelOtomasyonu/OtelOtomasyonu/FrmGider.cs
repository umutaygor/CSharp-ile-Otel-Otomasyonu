﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler(Elektrik,Su,Dogalgaz,Internet,Gida,Personel,Diger) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGida.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giderler Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
                throw;
            }
           
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {

        }
    }
}
