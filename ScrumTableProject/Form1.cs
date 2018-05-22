using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ScrumTableProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int storyid = 0, storyy = 56, storysayisi = 0;
        int taskid = 0;// taskx = 207, tasky = 53; //taskx+76 tasky+120    +220
        Panel[] pnlTask = new Panel[9];
        Button btnGeri = new Button();
        Button btnIleri = new Button();
        int[] tasksayisi = new int[3] { 0, 0, 0 };
        int[] taskx = new int[3] { 209, 285, 361 };
        int[] tasky = new int[3] { 53, 173, 293 };
        int taskkordinat0 = 0, taskkordinat1 = 0, taskkordinat2 = 0;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4QVTMNV\DBKURS8;Initial Catalog=dbScrumTable;Integrated Security=True");

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //story ekleme sayi tutma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SId , SBaslik , SIcerik , SYazan from tblStory", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                storyid = Convert.ToInt32(dr[0]);
                Story(dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            baglanti.Close();
            //task ekleme
            baglanti.Open();
            SqlCommand command = new SqlCommand("select TId,TBaslik,TIcerik,TX,TY,SId from tblTask", baglanti);
            SqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                taskid = Convert.ToInt32(data[0]);
                Task(data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), Convert.ToInt32(data[4]), Convert.ToInt32(data[5]));
            }
            baglanti.Close();
            //task sayisi için sadece
            int taskDiziDegisken = 0;
            baglanti.Open();
            SqlCommand komutTaskSayisi = new SqlCommand("select COUNT(*) from tblTask t group by t.SId", baglanti);
            SqlDataReader reader = komutTaskSayisi.ExecuteReader();
            while (reader.Read())
            {
                tasksayisi[taskDiziDegisken] = Convert.ToInt32(reader[0]);
                taskDiziDegisken++;
            }
            baglanti.Close();
            taskkordinat0 = tasksayisi[0];
            taskkordinat1 = tasksayisi[1];
            taskkordinat2 = tasksayisi[2];
        }

        protected void btnGeri_Click(object sender, EventArgs e)
        {
            //panel içindeki butonların komutunu ayarlamak için
            foreach (Control cont in Controls)
            {
                if (cont is Button && cont != btnEnd && cont != btnStoryAl && cont != btnStoryEkle && cont != btnTaskEkle)
                {
                    cont.Click += new EventHandler(btnGeri_Click);
                    cont.Click += new EventHandler(btnIleri_Click);
                }
            }
            Button dinamikButton = (sender as Button);
            string temp = dinamikButton.Name;
            int stryid_temp = Convert.ToInt16(temp[1].ToString());
            int pnlid_temp = Convert.ToInt16(temp[2].ToString());
            int x_temp = 0, y_temp = 0;
            //seçili taskın x y kordinatlarını alma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TId , SId , TX , TY from tblTask where TId='" + pnlid_temp + "'and SId='" + stryid_temp + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                x_temp = Convert.ToInt32(dr[2]);
                y_temp = Convert.ToInt32(dr[3]);
            }
            baglanti.Close();
            if (x_temp > 209)
            {
                x_temp -= 240;
                pnlTask[pnlid_temp].Location = new Point(x_temp, y_temp);
                // taskı güncelle
                baglanti.Open();
                SqlCommand command = new SqlCommand("select *  from tblTask Update tblTask set TX = '" + x_temp + "' where TId = '" + pnlid_temp + "' and SId = '" + stryid_temp + "'", baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        protected void btnIleri_Click(object sender, EventArgs e)
        {
            //panel içindeki butonların komutunu ayarlamak için
            foreach (Control cont in Controls)
            {
                if (cont is Button && cont != btnEnd && cont != btnStoryAl && cont != btnStoryEkle && cont != btnTaskEkle)
                {
                    cont.Click += new EventHandler(btnGeri_Click);
                    cont.Click += new EventHandler(btnIleri_Click);
                }
            }
            Button dinamikButon = (sender as Button);
            string temp = dinamikButon.Name;
            int stryid_temp = Convert.ToInt16(temp[1].ToString());
            int pnlid_temp = Convert.ToInt16(temp[2].ToString());
            int x_temp = 0, y_temp = 0;
            //seçili taskın x y kordinatlarını alma
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TId , SId , TX , TY from tblTask where TId='"+pnlid_temp+"'and SId='"+stryid_temp+"'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                x_temp = Convert.ToInt32(dr[2]);
                y_temp = Convert.ToInt32(dr[3]);
            }
            baglanti.Close();
            if (x_temp < 689)
            {
                x_temp += 240;
                pnlTask[pnlid_temp].Location = new Point(x_temp,y_temp);
                baglanti.Open();
                // taskı güncelle
                SqlCommand command = new SqlCommand("select *  from tblTask Update tblTask set TX = '"+x_temp+"' where TId = '"+pnlid_temp+"' and SId = '"+stryid_temp+"'",baglanti);
                command.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void btnStoryAl_Click(object sender, EventArgs e)
        {
            if (cmbStoryId.SelectedItem == null)
            {
                MessageBox.Show("Story id seçiniz..");
            }
            else
            {
                Story_Cagir(Convert.ToInt32(cmbStoryId.Text));
            }
        }

        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            if (txtSBaslik.Text == "" || txtSIcerik.Text == "" || txtSYazan.Text == "")
            {
                MessageBox.Show("Boş veri bırakmayınız..");
            }
            else
            {
                String Baslik, Icerik, Yazan;
                Baslik = txtSBaslik.Text;
                Icerik = txtSIcerik.Text;
                Yazan = txtSYazan.Text;
                Story_Ekle();
                Story(Baslik, Icerik, Yazan);
                MessageBox.Show("Story eklendi Başlığı : " + Baslik);
            }
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            if (cmbKayitliHikayeler.SelectedItem != null)
            {
                if (txtTBaslik.Text != "" || txtTIcerik.Text != "")
                {
                    if (Convert.ToInt16(cmbKayitliHikayeler.SelectedItem) == 0 && tasksayisi[0] < 3)
                    {
                        String Baslik, Icerik;
                        Baslik = txtTBaslik.Text;
                        Icerik = txtTIcerik.Text;
                        Task_Ekle(taskid, taskx[taskkordinat0], tasky[0]);
                        Task(Baslik, Icerik, taskx[taskkordinat0], tasky[0], cmbKayitliHikayeler.SelectedIndex);
                        MessageBox.Show("Task eklendi Başlığı : " + Baslik);
                        tasksayisi[0]++;
                        taskkordinat0++;
                    }
                    else if (Convert.ToInt16(cmbKayitliHikayeler.SelectedItem) == 1 && tasksayisi[1] < 3)
                    {
                        String Baslik, Icerik;
                        Baslik = txtTBaslik.Text;
                        Icerik = txtTIcerik.Text;
                        Task_Ekle(taskid, taskx[taskkordinat1], tasky[1]);
                        Task(Baslik, Icerik, taskx[taskkordinat1], tasky[1], cmbKayitliHikayeler.SelectedIndex);
                        MessageBox.Show("Task eklendi Başlığı : " + Baslik);
                        tasksayisi[1]++;
                        taskkordinat1++;
                    }
                    else if (Convert.ToInt16(cmbKayitliHikayeler.SelectedItem) == 2 && tasksayisi[2] < 3)
                    {
                        String Baslik, Icerik;
                        Baslik = txtTBaslik.Text;
                        Icerik = txtTIcerik.Text;
                        Task_Ekle(taskid, taskx[taskkordinat2], tasky[2]);
                        Task(Baslik, Icerik, taskx[taskkordinat2], tasky[2], cmbKayitliHikayeler.SelectedIndex);
                        MessageBox.Show("Task eklendi Başlığı : " + Baslik);
                        tasksayisi[2]++;
                        taskkordinat2++;
                    }
                    else
                    {
                        MessageBox.Show("Task eklenemedi..");
                    }
                }
                else
                {
                    MessageBox.Show("Boş veri bırakmayınız..");
                }
            }
            else
            {
                MessageBox.Show("Story id seçiniz..");
            }
        }

        public void Story_Cagir(int storyId)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SBaslik , SIcerik , SYazan from tblStory where SId='" + storyId + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtSBaslik.Text = dr[0].ToString();
                txtSIcerik.Text = dr[1].ToString();
                txtSYazan.Text = dr[2].ToString();
            }
            baglanti.Close();
        }

        public void Story_Ekle()
        {
            SqlCommand komut = new SqlCommand("INSERT INTO tblStory (SId,SBaslik,SIcerik,SYazan) VALUES ('" + storyid + "','" + txtSBaslik.Text + "','" + txtSIcerik.Text + "','" + txtSYazan.Text + "')", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Story(String Baslik, String Icerik, String Yazan)
        {
            Panel pnlStory = new Panel();
            TextBox txtBaslik = new TextBox();
            TextBox txtIcerik = new TextBox();
            TextBox txtYazan = new TextBox();
            pnlStory.SuspendLayout();
            tbScrum.Controls.Add(pnlStory);
            // 
            // pnlStory
            // 
            pnlStory.BackColor = Color.Turquoise;
            pnlStory.Controls.Add(txtIcerik);
            pnlStory.Controls.Add(txtYazan);
            pnlStory.Controls.Add(txtBaslik);
            pnlStory.Location = new Point(6, storyy);
            pnlStory.Name = "pnlStory" + storyid;
            pnlStory.Size = new Size(180, 90);
            pnlStory.TabIndex = 1;
            // 
            // txtBaslik
            // 
            txtBaslik.BackColor = Color.LightCyan;
            txtBaslik.BorderStyle = BorderStyle.None;
            txtBaslik.Cursor = Cursors.Arrow;
            txtBaslik.Location = new Point(3, 4);
            txtBaslik.Multiline = true;
            txtBaslik.Name = "txtBaslik" + storyid;
            txtBaslik.ReadOnly = true;
            txtBaslik.Size = new Size(174, 19);
            txtBaslik.TabIndex = 3;
            txtBaslik.Text = Baslik;
            // 
            // txtIcerik
            // 
            txtIcerik.BackColor = Color.LightCyan;
            txtIcerik.BorderStyle = BorderStyle.None;
            txtIcerik.Cursor = Cursors.Arrow;
            txtIcerik.Location = new Point(3, 24);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik" + storyid;
            txtIcerik.ReadOnly = true;
            txtIcerik.ScrollBars = ScrollBars.Vertical;
            txtIcerik.Size = new Size(174, 42);
            txtIcerik.TabIndex = 3;
            txtIcerik.Text = Icerik;
            // 
            // txtYazan
            // 
            txtYazan.BackColor = Color.LightCyan;
            txtYazan.BorderStyle = BorderStyle.None;
            txtYazan.Cursor = Cursors.Arrow;
            txtYazan.Location = new Point(3, 67);
            txtYazan.Multiline = true;
            txtYazan.Name = "txtYazan" + storyid;
            txtYazan.ReadOnly = true;
            txtYazan.Size = new Size(174, 19);
            txtYazan.TabIndex = 3;
            txtYazan.Text = Yazan;
            //comboboxlara ekle
            cmbStoryId.Items.Add(storyid);
            cmbKayitliHikayeler.Items.Add(storyid);
            storyid++;
            storysayisi++;
            storyy += 120;
            if (storysayisi >= 3)
            {
                btnStoryEkle.Enabled = false;
                btnStoryEkle.Text = "Story Dolu";
            }
        }

        public void Task_Ekle(int taskid, int taskx, int tasky)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO tblTask (TId,TBaslik,TIcerik,TX,TY,SId) VALUES ('" + taskid + "','" + txtTBaslik.Text + "','" + txtTIcerik.Text + "','" + taskx + "','" + tasky + "','" + cmbKayitliHikayeler.SelectedIndex + "')", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Task(string baslik, string icerik, int taskx, int tasky, int storyid)
        {
            pnlTask[taskid] = new Panel();
            btnGeri = new Button();
            btnIleri = new Button();
            TextBox txtIcerik = new TextBox();
            TextBox txtBaslik = new TextBox();
            pnlTask[taskid].SuspendLayout();
            tbScrum.Controls.Add(pnlTask[taskid]);
            // 
            // pnl00
            // 
            pnlTask[taskid].BackColor = Color.Turquoise;
            pnlTask[taskid].Controls.Add(txtBaslik);
            pnlTask[taskid].Controls.Add(txtIcerik);
            pnlTask[taskid].Controls.Add(btnGeri);
            pnlTask[taskid].Controls.Add(btnIleri);
            pnlTask[taskid].Location = new Point(taskx, tasky);
            pnlTask[taskid].Name = "pnlTask" + storyid + taskid;
            pnlTask[taskid].Size = new Size(70, 101);
            pnlTask[taskid].TabIndex = 0;
            // 
            // btnGeri1
            // 
            btnGeri.FlatStyle = FlatStyle.Flat;
            btnGeri.Image = Image.FromFile("geri.png"); ;
            btnGeri.Location = new Point(0, 0);
            btnGeri.Name = "b" + storyid + taskid;
            btnGeri.Size = new Size(25, 15);
            btnGeri.TabIndex = 1;
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += new EventHandler(btnGeri_Click);
            // 
            // btnIleri1
            // 
            btnIleri.FlatStyle = FlatStyle.Flat;
            btnIleri.Image = Image.FromFile("ileri.png"); ;
            btnIleri.Location = new System.Drawing.Point(45, 0);
            btnIleri.Name = "b" + storyid + taskid;
            btnIleri.Size = new System.Drawing.Size(25, 15);
            btnIleri.TabIndex = 1;
            btnIleri.UseVisualStyleBackColor = true;
            btnIleri.Click += new EventHandler(btnIleri_Click);
            // 
            // txtBaslik
            // 
            txtBaslik.BackColor = Color.LightCyan;
            txtBaslik.Location = new Point(0, 15);
            txtBaslik.Name = "txtBaslik" + storyid + taskid;
            txtBaslik.ReadOnly = true;
            txtBaslik.Size = new Size(70, 20);
            txtBaslik.TabIndex = 0;
            txtBaslik.Text = baslik;
            // 
            // txtIcerik
            // 
            txtIcerik.BackColor = Color.LightCyan;
            txtIcerik.Location = new Point(0, 35);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik" + storyid + taskid;
            txtIcerik.ReadOnly = true;
            txtIcerik.ScrollBars = ScrollBars.Vertical;
            txtIcerik.Size = new Size(70, 66);
            txtIcerik.TabIndex = 0;
            txtIcerik.Text = icerik;

            taskid++;
        }


    }
}
