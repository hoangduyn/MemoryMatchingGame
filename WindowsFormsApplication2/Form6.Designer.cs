using Microsoft.VisualBasic;

namespace WindowsFormsApplication2
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btContinue = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.lbMAS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbHighScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbClickTime = new System.Windows.Forms.Label();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPlayerScore = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.btGuide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHall = new System.Windows.Forms.Label();
            this.lbTop1 = new System.Windows.Forms.Label();
            this.lbTop2 = new System.Windows.Forms.Label();
            this.btHighScore = new System.Windows.Forms.Button();
            this.lbTop3 = new System.Windows.Forms.Label();
            this.mpZawarudo = new AxWMPLib.AxWindowsMediaPlayer();
            this.mpWind = new AxWMPLib.AxWindowsMediaPlayer();
            this.mpFire = new AxWMPLib.AxWindowsMediaPlayer();
            this.mpBackgroundMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.btBack = new System.Windows.Forms.Button();
            this.btOKCustom = new System.Windows.Forms.Button();
            this.btOkName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.btCustom = new System.Windows.Forms.Button();
            this.btLevel3 = new System.Windows.Forms.Button();
            this.btLevel2 = new System.Windows.Forms.Button();
            this.btLevel1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gbThongTin.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpZawarudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpBackgroundMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.BackColor = System.Drawing.Color.Pink;
            this.gbThongTin.Controls.Add(this.btContinue);
            this.gbThongTin.Controls.Add(this.btPause);
            this.gbThongTin.Controls.Add(this.lbMAS);
            this.gbThongTin.Controls.Add(this.label10);
            this.gbThongTin.Controls.Add(this.lbHighScore);
            this.gbThongTin.Controls.Add(this.label6);
            this.gbThongTin.Controls.Add(this.lbClickTime);
            this.gbThongTin.Controls.Add(this.lbPlayerName);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.lbPlayerScore);
            this.gbThongTin.Controls.Add(this.lbTime);
            this.gbThongTin.Controls.Add(this.lbSecond);
            this.gbThongTin.Controls.Add(this.lbMinute);
            this.gbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.Location = new System.Drawing.Point(622, 0);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(225, 264);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // btContinue
            // 
            this.btContinue.Enabled = false;
            this.btContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinue.Location = new System.Drawing.Point(114, 224);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(104, 34);
            this.btContinue.TabIndex = 2;
            this.btContinue.Text = "Tiếp tục";
            this.btContinue.UseVisualStyleBackColor = true;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPause.Location = new System.Drawing.Point(6, 224);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(102, 34);
            this.btPause.TabIndex = 2;
            this.btPause.Text = "Tạm dừng";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // lbMAS
            // 
            this.lbMAS.ForeColor = System.Drawing.Color.Black;
            this.lbMAS.Location = new System.Drawing.Point(162, 91);
            this.lbMAS.Name = "lbMAS";
            this.lbMAS.Size = new System.Drawing.Size(14, 26);
            this.lbMAS.TabIndex = 1;
            this.lbMAS.Text = ":";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Điểm cao nhất";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHighScore
            // 
            this.lbHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighScore.Location = new System.Drawing.Point(140, 183);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(69, 31);
            this.lbHighScore.TabIndex = 0;
            this.lbHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lần click";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbClickTime
            // 
            this.lbClickTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClickTime.Location = new System.Drawing.Point(140, 121);
            this.lbClickTime.Name = "lbClickTime";
            this.lbClickTime.Size = new System.Drawing.Size(69, 31);
            this.lbClickTime.TabIndex = 0;
            this.lbClickTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.Location = new System.Drawing.Point(19, 61);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(190, 29);
            this.lbPlayerName.TabIndex = 0;
            this.lbPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điểm tạm thời";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên người chơi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayerScore
            // 
            this.lbPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerScore.Location = new System.Drawing.Point(140, 152);
            this.lbPlayerScore.Name = "lbPlayerScore";
            this.lbPlayerScore.Size = new System.Drawing.Size(69, 31);
            this.lbPlayerScore.TabIndex = 0;
            this.lbPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Black;
            this.lbTime.Location = new System.Drawing.Point(6, 90);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(128, 31);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Thời gian còn";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSecond
            // 
            this.lbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.ForeColor = System.Drawing.Color.Black;
            this.lbSecond.Location = new System.Drawing.Point(173, 91);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(36, 31);
            this.lbSecond.TabIndex = 0;
            this.lbSecond.Text = "00";
            this.lbSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMinute
            // 
            this.lbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinute.ForeColor = System.Drawing.Color.Black;
            this.lbMinute.Location = new System.Drawing.Point(129, 90);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(38, 31);
            this.lbMinute.TabIndex = 0;
            this.lbMinute.Text = "00";
            this.lbMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.bgr;
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMenu.Controls.Add(this.label4);
            this.pnMenu.Controls.Add(this.lbAuthor);
            this.pnMenu.Controls.Add(this.btGuide);
            this.pnMenu.Controls.Add(this.label3);
            this.pnMenu.Controls.Add(this.lbHall);
            this.pnMenu.Controls.Add(this.lbTop1);
            this.pnMenu.Controls.Add(this.lbTop2);
            this.pnMenu.Controls.Add(this.btHighScore);
            this.pnMenu.Controls.Add(this.lbTop3);
            this.pnMenu.Controls.Add(this.mpZawarudo);
            this.pnMenu.Controls.Add(this.mpWind);
            this.pnMenu.Controls.Add(this.mpFire);
            this.pnMenu.Controls.Add(this.mpBackgroundMusic);
            this.pnMenu.Controls.Add(this.btBack);
            this.pnMenu.Controls.Add(this.btOKCustom);
            this.pnMenu.Controls.Add(this.btOkName);
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.tbSoLuong);
            this.pnMenu.Controls.Add(this.tbPlayerName);
            this.pnMenu.Controls.Add(this.btCustom);
            this.pnMenu.Controls.Add(this.btLevel3);
            this.pnMenu.Controls.Add(this.btLevel2);
            this.pnMenu.Controls.Add(this.btLevel1);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(847, 481);
            this.pnMenu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Patch 2.1";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbAuthor.ForeColor = System.Drawing.Color.Black;
            this.lbAuthor.Location = new System.Drawing.Point(140, 3);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(534, 17);
            this.lbAuthor.TabIndex = 11;
            this.lbAuthor.Text = "@Developed by Minh Man and Hoang Duyn. Referenced from Minh Sang";
            // 
            // btGuide
            // 
            this.btGuide.BackColor = System.Drawing.Color.GreenYellow;
            this.btGuide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btGuide.ForeColor = System.Drawing.Color.Red;
            this.btGuide.Location = new System.Drawing.Point(789, 430);
            this.btGuide.Name = "btGuide";
            this.btGuide.Size = new System.Drawing.Size(55, 48);
            this.btGuide.TabIndex = 10;
            this.btGuide.Text = "?";
            this.btGuide.UseVisualStyleBackColor = false;
            this.btGuide.Click += new System.EventHandler(this.btGuide_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(615, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbHall
            // 
            this.lbHall.AutoSize = true;
            this.lbHall.BackColor = System.Drawing.Color.Transparent;
            this.lbHall.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHall.ForeColor = System.Drawing.Color.Black;
            this.lbHall.Location = new System.Drawing.Point(83, 105);
            this.lbHall.Name = "lbHall";
            this.lbHall.Size = new System.Drawing.Size(0, 46);
            this.lbHall.TabIndex = 2;
            this.lbHall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHall.Visible = false;
            // 
            // lbTop1
            // 
            this.lbTop1.AutoSize = true;
            this.lbTop1.BackColor = System.Drawing.Color.Transparent;
            this.lbTop1.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTop1.ForeColor = System.Drawing.Color.Red;
            this.lbTop1.Location = new System.Drawing.Point(83, 170);
            this.lbTop1.Name = "lbTop1";
            this.lbTop1.Size = new System.Drawing.Size(0, 46);
            this.lbTop1.TabIndex = 2;
            this.lbTop1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTop1.Visible = false;
            // 
            // lbTop2
            // 
            this.lbTop2.AutoSize = true;
            this.lbTop2.BackColor = System.Drawing.Color.Transparent;
            this.lbTop2.Font = new System.Drawing.Font("Times New Roman", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTop2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTop2.Location = new System.Drawing.Point(83, 243);
            this.lbTop2.Name = "lbTop2";
            this.lbTop2.Size = new System.Drawing.Size(0, 39);
            this.lbTop2.TabIndex = 2;
            this.lbTop2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTop2.Visible = false;
            // 
            // btHighScore
            // 
            this.btHighScore.BackColor = System.Drawing.Color.GreenYellow;
            this.btHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btHighScore.ForeColor = System.Drawing.Color.Black;
            this.btHighScore.Location = new System.Drawing.Point(689, 0);
            this.btHighScore.Name = "btHighScore";
            this.btHighScore.Size = new System.Drawing.Size(155, 47);
            this.btHighScore.TabIndex = 8;
            this.btHighScore.Text = "High Score";
            this.btHighScore.UseVisualStyleBackColor = false;
            this.btHighScore.Visible = false;
            this.btHighScore.Click += new System.EventHandler(this.btHighScore_Click);
            // 
            // lbTop3
            // 
            this.lbTop3.AutoSize = true;
            this.lbTop3.BackColor = System.Drawing.Color.Transparent;
            this.lbTop3.Font = new System.Drawing.Font("Times New Roman", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTop3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTop3.Location = new System.Drawing.Point(83, 305);
            this.lbTop3.Name = "lbTop3";
            this.lbTop3.Size = new System.Drawing.Size(0, 36);
            this.lbTop3.TabIndex = 2;
            this.lbTop3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTop3.Visible = false;
            // 
            // mpZawarudo
            // 
            this.mpZawarudo.Enabled = true;
            this.mpZawarudo.Location = new System.Drawing.Point(240, 3);
            this.mpZawarudo.Name = "mpZawarudo";
            this.mpZawarudo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpZawarudo.OcxState")));
            this.mpZawarudo.Size = new System.Drawing.Size(35, 31);
            this.mpZawarudo.TabIndex = 6;
            this.mpZawarudo.Visible = false;
            // 
            // mpWind
            // 
            this.mpWind.Enabled = true;
            this.mpWind.Location = new System.Drawing.Point(199, 3);
            this.mpWind.Name = "mpWind";
            this.mpWind.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpWind.OcxState")));
            this.mpWind.Size = new System.Drawing.Size(35, 31);
            this.mpWind.TabIndex = 6;
            this.mpWind.Visible = false;
            // 
            // mpFire
            // 
            this.mpFire.Enabled = true;
            this.mpFire.Location = new System.Drawing.Point(158, 3);
            this.mpFire.Name = "mpFire";
            this.mpFire.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpFire.OcxState")));
            this.mpFire.Size = new System.Drawing.Size(35, 31);
            this.mpFire.TabIndex = 6;
            this.mpFire.Visible = false;
            // 
            // mpBackgroundMusic
            // 
            this.mpBackgroundMusic.Enabled = true;
            this.mpBackgroundMusic.Location = new System.Drawing.Point(117, 3);
            this.mpBackgroundMusic.Name = "mpBackgroundMusic";
            this.mpBackgroundMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpBackgroundMusic.OcxState")));
            this.mpBackgroundMusic.Size = new System.Drawing.Size(35, 31);
            this.mpBackgroundMusic.TabIndex = 6;
            this.mpBackgroundMusic.Visible = false;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBack.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btBack.Location = new System.Drawing.Point(12, 25);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 34);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "BACK";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Visible = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btOKCustom
            // 
            this.btOKCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btOKCustom.Location = new System.Drawing.Point(381, 203);
            this.btOKCustom.Name = "btOKCustom";
            this.btOKCustom.Size = new System.Drawing.Size(82, 44);
            this.btOKCustom.TabIndex = 4;
            this.btOKCustom.Text = "OK";
            this.btOKCustom.UseVisualStyleBackColor = true;
            this.btOKCustom.Visible = false;
            this.btOKCustom.Click += new System.EventHandler(this.btOKCustom_Click);
            // 
            // btOkName
            // 
            this.btOkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOkName.Location = new System.Drawing.Point(365, 148);
            this.btOkName.Name = "btOkName";
            this.btOkName.Size = new System.Drawing.Size(113, 49);
            this.btOkName.TabIndex = 3;
            this.btOkName.Text = "OK";
            this.btOkName.UseVisualStyleBackColor = true;
            this.btOkName.Click += new System.EventHandler(this.btOkName_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(216, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "NHẬP SỐ LƯỢNG HÌNH :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(216, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "NHẬP TÊN NGƯỜI CHƠI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tbSoLuong.Location = new System.Drawing.Point(338, 148);
            this.tbSoLuong.Multiline = true;
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(163, 49);
            this.tbSoLuong.TabIndex = 1;
            this.tbSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSoLuong.Visible = false;
            this.tbSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoLuong_KeyPress);
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tbPlayerName.Location = new System.Drawing.Point(249, 100);
            this.tbPlayerName.Multiline = true;
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(353, 42);
            this.tbPlayerName.TabIndex = 1;
            this.tbPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPlayerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlayerName_KeyPress);
            // 
            // btCustom
            // 
            this.btCustom.BackColor = System.Drawing.Color.Transparent;
            this.btCustom.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.highground;
            this.btCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCustom.Enabled = false;
            this.btCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCustom.Location = new System.Drawing.Point(471, 345);
            this.btCustom.Name = "btCustom";
            this.btCustom.Size = new System.Drawing.Size(273, 95);
            this.btCustom.TabIndex = 0;
            this.btCustom.Text = "CUSTOM";
            this.btCustom.UseVisualStyleBackColor = false;
            this.btCustom.Click += new System.EventHandler(this.btCustom_Click);
            // 
            // btLevel3
            // 
            this.btLevel3.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.dawn;
            this.btLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLevel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLevel3.Enabled = false;
            this.btLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLevel3.Location = new System.Drawing.Point(102, 345);
            this.btLevel3.Name = "btLevel3";
            this.btLevel3.Size = new System.Drawing.Size(273, 95);
            this.btLevel3.TabIndex = 0;
            this.btLevel3.Text = "LEVEL 3";
            this.btLevel3.UseVisualStyleBackColor = true;
            this.btLevel3.Click += new System.EventHandler(this.btLevel3_Click);
            // 
            // btLevel2
            // 
            this.btLevel2.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.sakura;
            this.btLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLevel2.Enabled = false;
            this.btLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLevel2.Location = new System.Drawing.Point(471, 213);
            this.btLevel2.Name = "btLevel2";
            this.btLevel2.Size = new System.Drawing.Size(273, 95);
            this.btLevel2.TabIndex = 0;
            this.btLevel2.Text = "LEVEL 2";
            this.btLevel2.UseVisualStyleBackColor = true;
            this.btLevel2.Click += new System.EventHandler(this.btLevel2_Click);
            // 
            // btLevel1
            // 
            this.btLevel1.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.spirit5;
            this.btLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLevel1.Enabled = false;
            this.btLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLevel1.Location = new System.Drawing.Point(102, 213);
            this.btLevel1.Name = "btLevel1";
            this.btLevel1.Size = new System.Drawing.Size(273, 95);
            this.btLevel1.TabIndex = 0;
            this.btLevel1.Text = "LEVEL 1";
            this.btLevel1.UseVisualStyleBackColor = false;
            this.btLevel1.Click += new System.EventHandler(this.btLevel1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 478);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.gbThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Matching Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.gbThongTin.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpZawarudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpBackgroundMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbClickTime;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbHighScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPlayerScore;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbMAS;
        private System.Windows.Forms.Button btLevel1;
        private System.Windows.Forms.Button btLevel2;
        private System.Windows.Forms.Button btLevel3;
        private System.Windows.Forms.Button btCustom;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOkName;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOKCustom;
        private System.Windows.Forms.Button btBack;
        private AxWMPLib.AxWindowsMediaPlayer mpBackgroundMusic;
        private System.Windows.Forms.Button btHighScore;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Button btPause;
        protected internal System.Windows.Forms.Label lbHall;
        private System.Windows.Forms.Label lbTop1;
        private System.Windows.Forms.Label lbTop2;
        private System.Windows.Forms.Label lbTop3;
        private System.Windows.Forms.Timer timer2;
        private AxWMPLib.AxWindowsMediaPlayer mpZawarudo;
        private AxWMPLib.AxWindowsMediaPlayer mpWind;
        private AxWMPLib.AxWindowsMediaPlayer mpFire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGuide;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label label4;
    }
}