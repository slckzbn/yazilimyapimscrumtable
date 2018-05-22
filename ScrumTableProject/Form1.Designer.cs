namespace ScrumTableProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbScrumBoardMain = new System.Windows.Forms.TabControl();
            this.tbScrum = new System.Windows.Forms.TabPage();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lblNotStarted = new System.Windows.Forms.Label();
            this.lblStories = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAddStory = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblVarOlanHikayeler = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.cmbStoryId = new System.Windows.Forms.ComboBox();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.btnStoryAl = new System.Windows.Forms.Button();
            this.txtSIcerik = new System.Windows.Forms.TextBox();
            this.txtSYazan = new System.Windows.Forms.TextBox();
            this.txtSBaslik = new System.Windows.Forms.TextBox();
            this.tbAddTask = new System.Windows.Forms.TabPage();
            this.lblTIcerik = new System.Windows.Forms.Label();
            this.lblKayitliS = new System.Windows.Forms.Label();
            this.lblTBaslik = new System.Windows.Forms.Label();
            this.cmbKayitliHikayeler = new System.Windows.Forms.ComboBox();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.txtTIcerik = new System.Windows.Forms.TextBox();
            this.txtTBaslik = new System.Windows.Forms.TextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.tbScrumBoardMain.SuspendLayout();
            this.tbScrum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbAddStory.SuspendLayout();
            this.tbAddTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbScrumBoardMain
            // 
            this.tbScrumBoardMain.Controls.Add(this.tbScrum);
            this.tbScrumBoardMain.Controls.Add(this.tbAddStory);
            this.tbScrumBoardMain.Controls.Add(this.tbAddTask);
            this.tbScrumBoardMain.Location = new System.Drawing.Point(12, 12);
            this.tbScrumBoardMain.Name = "tbScrumBoardMain";
            this.tbScrumBoardMain.SelectedIndex = 0;
            this.tbScrumBoardMain.Size = new System.Drawing.Size(930, 426);
            this.tbScrumBoardMain.TabIndex = 0;
            // 
            // tbScrum
            // 
            this.tbScrum.Controls.Add(this.lblDone);
            this.tbScrum.Controls.Add(this.lblInProgress);
            this.tbScrum.Controls.Add(this.lblNotStarted);
            this.tbScrum.Controls.Add(this.lblStories);
            this.tbScrum.Controls.Add(this.pictureBox3);
            this.tbScrum.Controls.Add(this.pictureBox7);
            this.tbScrum.Controls.Add(this.pictureBox5);
            this.tbScrum.Controls.Add(this.pictureBox4);
            this.tbScrum.Controls.Add(this.pictureBox2);
            this.tbScrum.Controls.Add(this.pictureBox1);
            this.tbScrum.Location = new System.Drawing.Point(4, 22);
            this.tbScrum.Name = "tbScrum";
            this.tbScrum.Padding = new System.Windows.Forms.Padding(3);
            this.tbScrum.Size = new System.Drawing.Size(922, 400);
            this.tbScrum.TabIndex = 0;
            this.tbScrum.Text = "ScrumBoard";
            this.tbScrum.UseVisualStyleBackColor = true;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.Location = new System.Drawing.Point(762, 5);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(79, 32);
            this.lblDone.TabIndex = 2;
            this.lblDone.Text = "Done";
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgress.Location = new System.Drawing.Point(467, 5);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(170, 32);
            this.lblInProgress.TabIndex = 2;
            this.lblInProgress.Text = "In Progress";
            // 
            // lblNotStarted
            // 
            this.lblNotStarted.AutoSize = true;
            this.lblNotStarted.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotStarted.Location = new System.Drawing.Point(232, 5);
            this.lblNotStarted.Name = "lblNotStarted";
            this.lblNotStarted.Size = new System.Drawing.Size(165, 32);
            this.lblNotStarted.TabIndex = 2;
            this.lblNotStarted.Text = "Not Started";
            // 
            // lblStories
            // 
            this.lblStories.AutoSize = true;
            this.lblStories.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStories.Location = new System.Drawing.Point(43, 5);
            this.lblStories.Name = "lblStories";
            this.lblStories.Size = new System.Drawing.Size(107, 32);
            this.lblStories.TabIndex = 2;
            this.lblStories.Text = "Stories";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(677, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 400);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(0, 280);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(922, 10);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(0, 160);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(922, 10);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(0, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(922, 10);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(433, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 400);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(193, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbAddStory
            // 
            this.tbAddStory.Controls.Add(this.label1);
            this.tbAddStory.Controls.Add(this.lblIcerik);
            this.tbAddStory.Controls.Add(this.lblVarOlanHikayeler);
            this.tbAddStory.Controls.Add(this.lblBaslik);
            this.tbAddStory.Controls.Add(this.cmbStoryId);
            this.tbAddStory.Controls.Add(this.btnStoryEkle);
            this.tbAddStory.Controls.Add(this.btnStoryAl);
            this.tbAddStory.Controls.Add(this.txtSIcerik);
            this.tbAddStory.Controls.Add(this.txtSYazan);
            this.tbAddStory.Controls.Add(this.txtSBaslik);
            this.tbAddStory.Location = new System.Drawing.Point(4, 22);
            this.tbAddStory.Name = "tbAddStory";
            this.tbAddStory.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddStory.Size = new System.Drawing.Size(922, 400);
            this.tbAddStory.TabIndex = 1;
            this.tbAddStory.Text = "AddStory";
            this.tbAddStory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Yazan";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcerik.Location = new System.Drawing.Point(143, 146);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(82, 32);
            this.lblIcerik.TabIndex = 12;
            this.lblIcerik.Text = "İçerik";
            // 
            // lblVarOlanHikayeler
            // 
            this.lblVarOlanHikayeler.AutoSize = true;
            this.lblVarOlanHikayeler.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarOlanHikayeler.Location = new System.Drawing.Point(481, 81);
            this.lblVarOlanHikayeler.Name = "lblVarOlanHikayeler";
            this.lblVarOlanHikayeler.Size = new System.Drawing.Size(228, 32);
            this.lblVarOlanHikayeler.TabIndex = 14;
            this.lblVarOlanHikayeler.Text = "Kayıtlı Hikayeler";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(143, 81);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(99, 32);
            this.lblBaslik.TabIndex = 11;
            this.lblBaslik.Text = "Başlık";
            // 
            // cmbStoryId
            // 
            this.cmbStoryId.FormattingEnabled = true;
            this.cmbStoryId.ItemHeight = 13;
            this.cmbStoryId.Location = new System.Drawing.Point(715, 90);
            this.cmbStoryId.Name = "cmbStoryId";
            this.cmbStoryId.Size = new System.Drawing.Size(121, 21);
            this.cmbStoryId.TabIndex = 6;
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnStoryEkle.Location = new System.Drawing.Point(291, 273);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(189, 46);
            this.btnStoryEkle.TabIndex = 5;
            this.btnStoryEkle.Text = "Story Ekle";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // btnStoryAl
            // 
            this.btnStoryAl.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnStoryAl.Location = new System.Drawing.Point(87, 273);
            this.btnStoryAl.Name = "btnStoryAl";
            this.btnStoryAl.Size = new System.Drawing.Size(189, 46);
            this.btnStoryAl.TabIndex = 4;
            this.btnStoryAl.Text = "Story al";
            this.btnStoryAl.UseVisualStyleBackColor = true;
            this.btnStoryAl.Click += new System.EventHandler(this.btnStoryAl_Click);
            // 
            // txtSIcerik
            // 
            this.txtSIcerik.Location = new System.Drawing.Point(311, 119);
            this.txtSIcerik.Multiline = true;
            this.txtSIcerik.Name = "txtSIcerik";
            this.txtSIcerik.Size = new System.Drawing.Size(135, 87);
            this.txtSIcerik.TabIndex = 2;
            // 
            // txtSYazan
            // 
            this.txtSYazan.Location = new System.Drawing.Point(311, 212);
            this.txtSYazan.Name = "txtSYazan";
            this.txtSYazan.Size = new System.Drawing.Size(135, 20);
            this.txtSYazan.TabIndex = 3;
            // 
            // txtSBaslik
            // 
            this.txtSBaslik.Location = new System.Drawing.Point(311, 90);
            this.txtSBaslik.Multiline = true;
            this.txtSBaslik.Name = "txtSBaslik";
            this.txtSBaslik.Size = new System.Drawing.Size(135, 20);
            this.txtSBaslik.TabIndex = 1;
            // 
            // tbAddTask
            // 
            this.tbAddTask.Controls.Add(this.lblTIcerik);
            this.tbAddTask.Controls.Add(this.lblKayitliS);
            this.tbAddTask.Controls.Add(this.lblTBaslik);
            this.tbAddTask.Controls.Add(this.cmbKayitliHikayeler);
            this.tbAddTask.Controls.Add(this.btnTaskEkle);
            this.tbAddTask.Controls.Add(this.txtTIcerik);
            this.tbAddTask.Controls.Add(this.txtTBaslik);
            this.tbAddTask.Location = new System.Drawing.Point(4, 22);
            this.tbAddTask.Name = "tbAddTask";
            this.tbAddTask.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddTask.Size = new System.Drawing.Size(922, 400);
            this.tbAddTask.TabIndex = 2;
            this.tbAddTask.Text = "AddTask";
            this.tbAddTask.UseVisualStyleBackColor = true;
            // 
            // lblTIcerik
            // 
            this.lblTIcerik.AutoSize = true;
            this.lblTIcerik.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIcerik.Location = new System.Drawing.Point(115, 160);
            this.lblTIcerik.Name = "lblTIcerik";
            this.lblTIcerik.Size = new System.Drawing.Size(82, 32);
            this.lblTIcerik.TabIndex = 19;
            this.lblTIcerik.Text = "İçerik";
            // 
            // lblKayitliS
            // 
            this.lblKayitliS.AutoSize = true;
            this.lblKayitliS.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKayitliS.Location = new System.Drawing.Point(453, 95);
            this.lblKayitliS.Name = "lblKayitliS";
            this.lblKayitliS.Size = new System.Drawing.Size(228, 32);
            this.lblKayitliS.TabIndex = 20;
            this.lblKayitliS.Text = "Kayıtlı Hikayeler";
            // 
            // lblTBaslik
            // 
            this.lblTBaslik.AutoSize = true;
            this.lblTBaslik.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBaslik.Location = new System.Drawing.Point(115, 95);
            this.lblTBaslik.Name = "lblTBaslik";
            this.lblTBaslik.Size = new System.Drawing.Size(99, 32);
            this.lblTBaslik.TabIndex = 21;
            this.lblTBaslik.Text = "Başlık";
            // 
            // cmbKayitliHikayeler
            // 
            this.cmbKayitliHikayeler.FormattingEnabled = true;
            this.cmbKayitliHikayeler.Location = new System.Drawing.Point(687, 104);
            this.cmbKayitliHikayeler.Name = "cmbKayitliHikayeler";
            this.cmbKayitliHikayeler.Size = new System.Drawing.Size(121, 21);
            this.cmbKayitliHikayeler.TabIndex = 18;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnTaskEkle.Location = new System.Drawing.Point(253, 259);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(189, 46);
            this.btnTaskEkle.TabIndex = 17;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // txtTIcerik
            // 
            this.txtTIcerik.Location = new System.Drawing.Point(283, 133);
            this.txtTIcerik.Multiline = true;
            this.txtTIcerik.Name = "txtTIcerik";
            this.txtTIcerik.Size = new System.Drawing.Size(135, 87);
            this.txtTIcerik.TabIndex = 16;
            // 
            // txtTBaslik
            // 
            this.txtTBaslik.Location = new System.Drawing.Point(283, 104);
            this.txtTBaslik.Multiline = true;
            this.txtTBaslik.Name = "txtTBaslik";
            this.txtTBaslik.Size = new System.Drawing.Size(135, 20);
            this.txtTBaslik.TabIndex = 15;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Maroon;
            this.btnEnd.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnd.Location = new System.Drawing.Point(910, 0);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(30, 30);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "X";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.tbScrumBoardMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbScrumBoardMain.ResumeLayout(false);
            this.tbScrum.ResumeLayout(false);
            this.tbScrum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbAddStory.ResumeLayout(false);
            this.tbAddStory.PerformLayout();
            this.tbAddTask.ResumeLayout(false);
            this.tbAddTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbScrumBoardMain;
        private System.Windows.Forms.TabPage tbScrum;
        private System.Windows.Forms.TabPage tbAddStory;
        private System.Windows.Forms.TabPage tbAddTask;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.Label lblNotStarted;
        private System.Windows.Forms.Label lblStories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblVarOlanHikayeler;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.ComboBox cmbStoryId;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.Button btnStoryAl;
        private System.Windows.Forms.TextBox txtSIcerik;
        private System.Windows.Forms.TextBox txtSYazan;
        private System.Windows.Forms.TextBox txtSBaslik;
        private System.Windows.Forms.Label lblTIcerik;
        private System.Windows.Forms.Label lblKayitliS;
        private System.Windows.Forms.Label lblTBaslik;
        private System.Windows.Forms.ComboBox cmbKayitliHikayeler;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.TextBox txtTIcerik;
        private System.Windows.Forms.TextBox txtTBaslik;
    }
}

