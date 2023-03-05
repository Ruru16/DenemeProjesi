using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=HARUN\\SQLEXPRESS;Initial Catalog=loginDB;Integrated Security=True");
        private bool button1Clicked = false;
        private bool button2Clicked = false;
        private bool button3Clicked = false;
        private bool button4Clicked = false;
        private bool button5Clicked = false;
        private bool button6Clicked = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            
            listView1.Columns.Clear();
            listView1.Columns.Add("Kart ID");
            listView1.Columns.Add("Unvan");
            listView1.Columns.Add("Vergi Dairesi");
            listView1.Columns.Add("Vergi No");
            listView1.Columns.Add("Tc Kimlik No");
            listView1.Columns.Add("Adres");
            listView1.Columns.Add("Tip Adı");

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand com = new SqlCommand("SELECT H.KartID, H.Unvan, H.VergiDairesi, H.VergiNo, H.TCNo, H.Adres, T.tipAdı FROM HesapKarti H JOIN HesapKartTip T ON H.tipID = T.tipID WHERE H.Silindi = '0' ", baglan);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["KartID"].ToString();
                ekle.SubItems.Add(dr["Unvan"].ToString());
                ekle.SubItems.Add(dr["VergiDairesi"].ToString());
                ekle.SubItems.Add(dr["VergiNo"].ToString());
                ekle.SubItems.Add(dr["TCNo"].ToString());
                ekle.SubItems.Add(dr["Adres"].ToString());
                ekle.SubItems.Add(dr["tipAdı"].ToString());

                listView1.Items.Add(ekle);
            }

            dr.Close();
            baglan.Close();
        }
        private void KullaniciListele()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.Columns.Add("User ID");
            listView1.Columns.Add("AD");
            listView1.Columns.Add("SOYAD");
            listView1.Columns.Add("KULLANICI ADI");
            listView1.Columns.Add("ŞİFRE");
            listView1.Columns.Add("EMAİL");
            listView1.Columns.Add("TELEFON");


            baglan.Open();
            SqlCommand com = new SqlCommand("Select *From Kullanici WHERE Silindi = '0'", baglan);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["userID"].ToString();
                ekle.SubItems.Add(dr["ad"].ToString());
                ekle.SubItems.Add(dr["soyad"].ToString());
                ekle.SubItems.Add(dr["kullaniciadi"].ToString());
                ekle.SubItems.Add(dr["sifre"].ToString());
                ekle.SubItems.Add(dr["email"].ToString());
                ekle.SubItems.Add(dr["telefon"].ToString());


                listView1.Items.Add(ekle);
            }

            baglan.Close();
        }

        private void ListeleTip()
        {
            // Sütunları sadece bir kez tanımla
            listView1.Columns.Clear();
            listView1.Columns.Add("Tip ID");
            listView1.Columns.Add("Tip Adı");

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand com = new SqlCommand("Select * From HesapKartTip", baglan);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["TipID"].ToString();
                ekle.SubItems.Add(dr["TipAdı"].ToString());

                listView1.Items.Add(ekle);
            }

            dr.Close();
            baglan.Close();
        }
        private void ListeleTur()
        {
            // Sütunları sadece bir kez tanımla
            listView1.Columns.Clear();
            listView1.Columns.Add("Tur id");
            listView1.Columns.Add("Tip Adı");

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand com = new SqlCommand("Select * From HesapKartTur", baglan);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["TurID"].ToString();
                ekle.SubItems.Add(dr["TurAdı"].ToString());
                listView1.Items.Add(ekle);
            }

            dr.Close();
            baglan.Close();
        }
        private void ListeleGrup()
        {
            // Sütunları sadece bir kez tanımla
            listView1.Columns.Clear();
            listView1.Columns.Add("Grup id");
            listView1.Columns.Add("Grup Adı");

            listView1.Items.Clear();

            baglan.Open();
            SqlCommand com = new SqlCommand("Select * From HesapKartGrup", baglan);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["GrupID"].ToString();
                ekle.SubItems.Add(dr["GrupAdı"].ToString());
                listView1.Items.Add(ekle);
            }

            dr.Close();
            baglan.Close();
        }

        private void ListeleAltGrup()
        {
            // Sütunları sadece bir kez tanımla
            listView1.Columns.Clear();
            listView1.Columns.Add("Alt Grup id");
            listView1.Columns.Add("Alt Grup Adı");
            listView1.Columns.Add("Grup id");


            listView1.Items.Clear();

            baglan.Open();
            SqlCommand com = new SqlCommand("Select * From HesapKartAltGrup", baglan);
            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["AltGrupID"].ToString();
                ekle.SubItems.Add(dr["AltGrupAdı"].ToString());
                ekle.SubItems.Add(dr["GrupID"].ToString());
                listView1.Items.Add(ekle);
            }

            dr.Close();
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Listele();
            button1Clicked = true;



        }
        private void button2_Click(object sender, EventArgs e)
        {
               
            KullaniciListele(); 
            button2Clicked = true;

        }


        private void button3_Click(object sender, EventArgs e)
        {
           
            ListeleTip();
               button3Clicked=true;  
           
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            ListeleTur();
        button4Clicked=true;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            ListeleGrup();
            button5Clicked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListeleAltGrup();
            button6Clicked = true;


        }

        
        //SİLME BUTONU
        private void button9_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {

                if (listView1.SelectedItems.Count > 0)
                {
                    try
                    {
                        baglan.Open();
                        // HesapKarti.dbo'da veriyi güncelleme
                        SqlCommand cmd = new SqlCommand("UPDATE HesapKarti SET Silindi=1 WHERE KartID=@KartID", baglan);
                        cmd.Parameters.AddWithValue("@KartID", listView1.SelectedItems[0].Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        baglan.Close();

                        if (rowsAffected > 0)
                        {
                            // Listview'den seçili öğeyi silme
                            listView1.SelectedItems[0].Remove();
                            MessageBox.Show("Veri silme başarılı", "Veri silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Listele();
                        }
                        else
                        {
                            MessageBox.Show("Veri silme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veri silme başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz veriyi seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

            else if (button2Clicked == true)
            {

                if (listView1.SelectedItems.Count > 0)
                {
                    try
                    {
                        baglan.Open();
                        // HesapKarti.dbo'da veriyi güncelleme
                        SqlCommand cmd = new SqlCommand("UPDATE Kullanici SET Silindi=1 WHERE userID=@userID", baglan);
                        cmd.Parameters.AddWithValue("@userID", listView1.SelectedItems[0].Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        baglan.Close();

                        if (rowsAffected > 0)
                        {
                            // Listview'den seçili öğeyi silme
                            listView1.SelectedItems[0].Remove();
                            MessageBox.Show("Veri silme başarılı", "Veri silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KullaniciListele();
                        }
                        else
                        {
                            MessageBox.Show("Veri silme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veri silme başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz veriyi seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true)
            {
                try
                {

                    if (listView1.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Lütfen güncellenecek bir satır seçin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string unvan = Interaction.InputBox("Unvan ismi giriniz", "veri güncelleme", "", 100, 100);
                    string vergidairesi = Interaction.InputBox("Vergi dairesi ismi giriniz", "veri güncelleme", "", 100, 100);
                    string vergino = Interaction.InputBox("Vergi numarası giriniz", "veri güncelleme", "", 100, 100);
                    string tcno = Interaction.InputBox("Tc kimlik no giriniz", "veri güncelleme", "", 100, 100);
                    string adres = Interaction.InputBox("Adres giriniz", "veri güncelleme", "", 100, 100);
                    string tipid = Interaction.InputBox("Tip ID giriniz", "veri güncelleme", "", 100, 100);

                    baglan.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE HesapKarti SET Unvan=@unvan, VergiDairesi=@vergidairesi, " +
                                   "VergiNo=@vergino, TCNo=@tcno, Adres=@adres, TipID=@tipid WHERE KartID=@KartID", baglan);

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("@unvan", unvan);
                    cmd.Parameters.AddWithValue("@vergidairesi", vergidairesi);
                    cmd.Parameters.AddWithValue("@vergino", vergino);
                    cmd.Parameters.AddWithValue("@tcno", tcno);
                    cmd.Parameters.AddWithValue("@adres", adres);
                    cmd.Parameters.AddWithValue("@tipid", tipid);
                    cmd.Parameters.AddWithValue("@KartID", listView1.SelectedItems[0].Text);

                    // Sorguyu çalıştırma
                    int rowsAffected = cmd.ExecuteNonQuery();
                    baglan.Close();

                    if (rowsAffected > 0)
                    {
                        // Başarılı güncelleme mesajı
                        MessageBox.Show("Veri güncelleme başarılı", "Veri güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                    }
                    else
                    {
                        // Güncelleme yapılmadıysa hata mesajı
                        MessageBox.Show("Veri güncelleme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show("Veri güncelleme başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else if (button2Clicked == true)
            {
                try
                {

                    if (listView1.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Lütfen güncellenecek bir satır seçin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string ad = Interaction.InputBox("Adınızı giriniz", "veri güncelleme", "", 100, 100);
                    string soyad = Interaction.InputBox("Soyadınızı ismi giriniz", "veri güncelleme", "", 100, 100);
                    string kullaniciad = Interaction.InputBox("Kullanıcı adı giriniz", "veri güncelleme", "", 100, 100);
                    string sifre = Interaction.InputBox("Şifre giriniz", "veri güncelleme", "", 100, 100);
                    string email = Interaction.InputBox("email giriniz ", "veri güncelleme", "", 100, 100);
                    string telefon = Interaction.InputBox("Telefon giriniz", "veri güncelleme", "", 100, 100);

                    baglan.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Kullanici SET ad=@ad, soyad=@soyad, " +
                                   "kullaniciadi=@kullaniciadi, sifre=@sifre, email=@email, telefon=@telefon WHERE userID=@userID", baglan);

                    // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciad);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@telefon", telefon);
                    cmd.Parameters.AddWithValue("@userID", listView1.SelectedItems[0].Text);

                    // Sorguyu çalıştırma
                    int rowsAffected = cmd.ExecuteNonQuery();
                    baglan.Close();

                    if (rowsAffected > 0)
                    {
                        // Başarılı güncelleme mesajı
                        MessageBox.Show("Veri güncelleme başarılı", "Veri güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KullaniciListele();
                    }
                    else
                    {
                        // Güncelleme yapılmadıysa hata mesajı
                        MessageBox.Show("Veri güncelleme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show("Veri güncelleme başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        //ekleme
        private void button7_Click(object sender, EventArgs e)
        {

            if (button1Clicked == true)
            {
               
                    string unvan = Interaction.InputBox("Unvan ismi giriniz", "veri ekleme", "", 100, 100);
                    string vergidairesi = Interaction.InputBox("Vergi dairesi ismi giriniz", "veri ekleme", "", 100, 100);
                    string vergino = Interaction.InputBox("Vergi numarası giriniz", "veri ekleme", "", 100, 100);
                    string tcno = Interaction.InputBox("Tc kimlik no giriniz", "veri güncelleme", "", 100, 100);
                    string adres = Interaction.InputBox("Adres giriniz", "veri güncelleme", "", 100, 100);
                    string tipid = Interaction.InputBox("Tip ID giriniz", "veri güncelleme", "", 100, 100);

                    baglan.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO HesapKarti (Unvan, VergiDairesi, VergiNo, TCNo, Adres, TipID) VALUES (@unvan, @vergidairesi, @vergino, @tcno, @adres, @tipid)", baglan);

                // Parametreleri ekleme
                    cmd.Parameters.AddWithValue("@unvan", unvan);
                    cmd.Parameters.AddWithValue("@vergidairesi", vergidairesi);
                    cmd.Parameters.AddWithValue("@vergino", vergino);
                    cmd.Parameters.AddWithValue("@tcno", tcno);
                    cmd.Parameters.AddWithValue("@adres", adres);
                    cmd.Parameters.AddWithValue("@tipid", tipid);


                int rowsAffected = cmd.ExecuteNonQuery();
                baglan.Close();

                if (rowsAffected > 0)
                {

                    MessageBox.Show("Veri ekleme başarılı", "Veri güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
                else
                {

                    MessageBox.Show("Veri ekleme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };



            }

            else if (button2Clicked == true)
            {
                baglan.Open();
                string ad = Interaction.InputBox("adınızı giriniz", "veri ekleme", "", 100, 100);
                string soyad = Interaction.InputBox("soyadınızı giriniz", "veri ekleme", "", 100, 100);
                string kullaniciad = Interaction.InputBox("Kullanıcı adı giriniz", "veri ekleme", "", 100, 100);
                string sifre = Interaction.InputBox("Şifre giriniz", "veri ekleme", "", 100, 100);
                string email = Interaction.InputBox("email giriniz ", "veri ekleme", "", 100, 100);
                string telefon = Interaction.InputBox("Telefon giriniz", "veri ekleme", "", 100, 100);

                SqlCommand cmd = new SqlCommand("INSERT INTO Kullanici (ad, soyad, kullaniciadi, sifre, email, telefon) VALUES (@ad,@soyad,@kullaniciadi,@sifre,@email,@telefon)", baglan);
               
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciad);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefon", telefon);


                int rowsAffected = cmd.ExecuteNonQuery();
                baglan.Close();

                if (rowsAffected > 0)
                {
                    // Başarılı güncelleme mesajı
                    MessageBox.Show("Veri ekleme başarılı", "Veri ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KullaniciListele();
                }
                else
                {
                    // Güncelleme yapılmadıysa hata mesajı
                    MessageBox.Show("Veri ekleme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            else if (button3Clicked == true)
            {
                baglan.Open();
                string tip = Interaction.InputBox("Tip ismi giriniz", "veri ekleme", "", 100, 100);
                SqlCommand cmd = new SqlCommand("INSERT INTO HesapKartTip (tipAdı) VALUES (@tipAdı)", baglan);
                cmd.Parameters.AddWithValue("@tipAdı", tip);
                int rowsAffected = cmd.ExecuteNonQuery();
                baglan.Close();

                if (rowsAffected > 0)
                {
                    // Başarılı güncelleme mesajı
                    MessageBox.Show("Veri güncelleme başarılı", "Veri güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeleTip();
                }
                else
                {
                    // Güncelleme yapılmadıysa hata mesajı
                    MessageBox.Show("Veri güncelleme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (button4Clicked == true)
            {
                baglan.Open();
                string tur = Interaction.InputBox("Tür ismi giriniz", "veri ekleme", "", 100, 100);
                SqlCommand cmd = new SqlCommand("INSERT INTO HesapKartTur (turAdı) VALUES (@turAdı)", baglan);
                cmd.Parameters.AddWithValue("@turAdı", tur);
                int rowsAffected = cmd.ExecuteNonQuery();
                baglan.Close();

                if (rowsAffected > 0)
                {
                    // Başarılı güncelleme mesajı
                    MessageBox.Show("Veri ekleme başarılı", "Veri güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeleTur();
                }
                else
                {
                    // Güncelleme yapılmadıysa hata mesajı
                    MessageBox.Show("Veri ekleme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (button5Clicked == true)
            {
                baglan.Open();
                string grup = Interaction.InputBox("Grup ismi giriniz", "veri ekleme", "", 100, 100);
                SqlCommand cmd = new SqlCommand("INSERT INTO HesapKartGrup (GrupAdı) VALUES (@GrupAdı)", baglan);
                cmd.Parameters.AddWithValue("@GrupAdı", grup);
                int rowsAffected = cmd.ExecuteNonQuery();
                baglan.Close();

                if (rowsAffected > 0)
                {
                    // Başarılı güncelleme mesajı
                    MessageBox.Show("Veri ekleme başarılı", "Veri güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeleGrup();
                }
                else
                {
                    // Güncelleme yapılmadıysa hata mesajı
                    MessageBox.Show("Veri ekleme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (button6Clicked == true)
            {
                baglan.Open();
                string altGrup = Interaction.InputBox("Alt Grup ismi giriniz", "veri ekleme", "", 100, 100);
                SqlCommand cmd = new SqlCommand("INSERT INTO HesapKartAltGrup (AltGrupAdı) VALUES (@AltGrupAdı)", baglan);
                cmd.Parameters.AddWithValue("@AltGrupAdı", altGrup);
                int rowsAffected = cmd.ExecuteNonQuery();
                baglan.Close();

                if (rowsAffected > 0)
                {
                    // Başarılı güncelleme mesajı
                    MessageBox.Show("Veri ekleme başarılı", "Veri güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeleAltGrup();
                }
                else
                {
                    // Güncelleme yapılmadıysa hata mesajı
                    MessageBox.Show("Veri ekleme başarısız", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

    }
}

