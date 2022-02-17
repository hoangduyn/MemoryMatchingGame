using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Media;
using Microsoft.VisualBasic;
using System.IO;


namespace WindowsFormsApplication2
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        Button[] b;
        string pathImage = Application.StartupPath + @"\latHinhImage\";
        int clickTime = 0;
        int playTime = 0;
        int playerScoreTemp = 0;
        int playerScore = 0;
        int checkWin = 0;
        bool checkName = false;
        int nextLv = 0;
        bool easterEgg = false;

        int fireTime;
        int freezeTime;
        int stopTime;
       

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        public void level1()
        {
            lbMinute.Text = 1.ToString();
            lbSecond.Text = 0.ToString();
            int n = 12;
            b = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {
                b[i] = new Button();
                b[i].Size = new Size(100, 70);
                b[i].Text = "";
                b[i].Image = Image.FromFile(pathImage + "Default.jpg");
                b[i].Location = new Point(115 + k * 105, 100 + j * 75);
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == 4)
                {
                    k = 0; j++;
                }
            }
        }

        public void level2()
        {
            lbMinute.Text = 1.ToString();
            lbSecond.Text = 15.ToString();
            int n = 20;
            b = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {
                b[i] = new Button();
                b[i].Size = new Size(100, 70);
                b[i].Text = "";
                b[i].Image = Image.FromFile(pathImage + "Default.jpg");
                b[i].Location = new Point(80 + k * 105, 10 + j * 75);
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == 4)
                {
                    k = 0; j++;
                }
            }
        }

        public void level3()
        {
            lbMinute.Text = 1.ToString();
            lbSecond.Text = 30.ToString();
            int n = 30;
            b = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {
                b[i] = new Button();
                b[i].Size = new Size(100, 70);
                b[i].Text = "";
                b[i].Image = Image.FromFile(pathImage + "Default.jpg");
                b[i].Location = new Point(40 + k * 105, -60 + j * 75);
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == 5)
                {
                    k = 0; j++;
                }
            }

        }

        Random r = new Random();

        public void random()
        {
            //Nửa mảng button cho random các giá trị từ 0 đến 9
            ArrayList list = new ArrayList();
            bool checkFire = false;
            bool checkFreeze = false;
            bool checkTimeStop = false;
            for (int i = 0; i < b.Length / 2; i++)
            {
                int j = r.Next(0, 12);
                b[i].Tag = j;
                list.Add(j);//Lưu các giá trị đã random vào trong list.
            }
            ArrayList listTemp = new ArrayList();

            for (int i = 0; i < list.Count; i++)
                listTemp.Add(list[i]);

            for (int i = b.Length / 2; i < b.Length; i++)
            {
                int x = r.Next(0, list.Count - 1); // Lấy ngẫu nhiên 1 index trong list.
                b[i].Tag = list[x];//gán phần tử có index x trong list vào b[i].tag.
                list.RemoveAt(x);//Xóa phần tử đã được random trong list.
            }

            if (b.Length >= 26)
            {
                int fireEvent = r.Next(0, 12);
                int freezeEvent = r.Next(0, 12);
                int timeStopEvent = r.Next(0, 12);
                //kiểm soát mấy thằng random chắc chắn khác nhau và giống 1 trong mấy đám listTemp
                for (int q = 0; q < 999; q++)
                {
                    for (int i = 0; i < listTemp.Count; i++)
                    {
                        if (fireEvent == int.Parse(listTemp[i].ToString()) && fireEvent != freezeEvent && fireEvent != timeStopEvent && checkFire == false)
                            checkFire = true;
                        if (freezeEvent == int.Parse(listTemp[i].ToString()) && freezeEvent != fireEvent && freezeEvent != timeStopEvent && checkFreeze == false)
                            checkFreeze = true;
                        if (timeStopEvent == int.Parse(listTemp[i].ToString()) && timeStopEvent != fireEvent && timeStopEvent != freezeEvent && checkTimeStop == false)
                            checkTimeStop = true;
                    }
                    if (checkFire == checkFreeze == checkTimeStop == true)
                        q = 999;
                    else
                    {
                        fireEvent = r.Next(0, 12);
                        freezeEvent = r.Next(0, 12);
                        timeStopEvent = r.Next(0, 12);
                    }
                }

                if (easterEgg)
                {
                    gbThongTin.Text = fireEvent.ToString();
                    btPause.Text = freezeEvent.ToString();
                    btContinue.Text = timeStopEvent.ToString();
                }

                //gán cho tụi được random cái BottomCenter để kích hoạt fire
                for (int i = 0; i < b.Length; i++)
                {
                    if (int.Parse(b[i].Tag.ToString()) == fireEvent)
                    {
                        b[i].TextAlign = ContentAlignment.BottomCenter;
                    }
                }
                //gán cho tụi được random cái BottomLeft để kích hoạt freeze
                for (int i = 0; i < b.Length; i++)
                {
                    if (int.Parse(b[i].Tag.ToString()) == freezeEvent)
                    {
                        b[i].TextAlign = ContentAlignment.BottomLeft;
                    }
                }
                //gán cho tụi được random cái BottomRight để kích hoạt timeStop
                for (int i = 0; i < b.Length; i++)
                {
                    if (int.Parse(b[i].Tag.ToString()) == timeStopEvent)
                    {
                        b[i].TextAlign = ContentAlignment.BottomRight;
                    }
                }
            }
        }

        public void b_Click(object sender, EventArgs e)
        {
            clickTime++;
            Button bt = (Button)sender;
            bt.Image = Image.FromFile(pathImage + bt.Tag + ".jpg");
            bt.Enabled = false;
            checkPair();
            lbClickTime.Text = (clickTime).ToString();
            win();
        }

        public void checkPair()
        {
            int s = b.Length;
            for (int i = 0; i < b.Length - 1; i++)
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i].Enabled == false && b[j].Enabled == false)
                    {
                        if (b[i].Tag.ToString() == b[j].Tag.ToString())
                        {
                            correctSound();
                            System.Threading.Thread.Sleep(500);
                            b[i].Visible = false;
                            b[j].Visible = false;
                            b[i].Enabled = true;
                            b[j].Enabled = true;
                            if (s >= 12 && s <= 16)
                            {
                                playerScoreTemp += 10;
                            }
                            if (s >= 18 && s <= 24)
                            {
                                playerScoreTemp += 15;
                            }
                            if (s <= 30 && s >= 26)
                            {
                                playerScoreTemp += 20;
                            }
                            lbPlayerScore.Text = playerScoreTemp.ToString();
                            checkWin++;
                            if (b[i].TextAlign == ContentAlignment.BottomCenter &&
                                b[j].TextAlign == ContentAlignment.BottomCenter)
                            {
                                timer1.Interval = 500;
                                burningSound();
                                fireTime = 10;
                                gbThongTin.BackColor = Color.DarkOrange;
                                lbTime.ForeColor = lbMinute.ForeColor = lbMAS.ForeColor = lbSecond.ForeColor = Color.DarkRed;
                            }
                            else if (b[i].TextAlign == ContentAlignment.BottomLeft &&
                                b[j].TextAlign == ContentAlignment.BottomLeft)
                            {
                                timer1.Interval = 1500;
                                windSound();
                                freezeTime = 5;
                                gbThongTin.BackColor = Color.Blue;
                                lbTime.ForeColor = lbMinute.ForeColor = lbMAS.ForeColor = lbSecond.ForeColor = Color.Aqua;
                            }
                            else if (b[i].TextAlign == ContentAlignment.BottomRight &&
                                b[j].TextAlign == ContentAlignment.BottomRight)
                            {
                                timer1.Stop();
                                timer2.Start();
                                mpBackgroundMusic.Ctlcontrols.pause();
                                timeStopSound();
                                stopTime = 5;
                                lbTime.ForeColor = lbMinute.ForeColor = lbMAS.ForeColor = lbSecond.ForeColor = Color.White;
                                gbThongTin.BackColor = Color.Black;
                                btPause.Visible = btContinue.Visible = false;
                            }
                        }
                        else
                        {
                            wrongSound();
                            System.Threading.Thread.Sleep(500);
                            b[i].Image = Image.FromFile(pathImage + "Default.jpg");
                            b[j].Image = Image.FromFile(pathImage + "Default.jpg");
                            b[i].Enabled = true;
                            b[j].Enabled = true;
                        }
                    }
                }
        }

        void wrongSound()
        {
            SoundPlayer sp = new SoundPlayer("chimes.wav");
            sp.Play();
        }

        void correctSound()
        {
            SoundPlayer sp = new SoundPlayer("tada.wav");
            sp.Play();
        }

        void burningSound()
        {
            mpFire.URL = ("burning.wav");
            mpFire.Ctlcontrols.play();
            mpFire.settings.volume = 50;
        }

        void windSound()
        {
            mpWind.URL = ("wind1.wav");
            mpWind.Ctlcontrols.play();
            mpWind.settings.volume = 50;
        }


        void timeStopSound()
        {
            mpZawarudo.URL = ("time.wav");
            mpZawarudo.Ctlcontrols.play();
            mpZawarudo.settings.volume = 50;
        }


        void music()
        {
            mpBackgroundMusic.URL=("bitrush.wav");
            mpBackgroundMusic.Ctlcontrols.play();
            mpBackgroundMusic.settings.volume = 50;
        }

        void resetArray()
        {
            for (int i = 0; i < b.Length - 1; i++)
                for (int j = i + 1; j < b.Length; j++)
                {
                    b[i].Visible = false;
                    b[j].Visible = false;
                }
            btPause.Enabled = true;
            music();
            checkWin = 0;
            playTime = 0;
            clickTime = 0;
            playerScoreTemp = 0;
            playerScore = 0;
            lbClickTime.Text = (clickTime).ToString();
            if (nextLv == 1 && !btCustom.Enabled)
            {
                btLevel2.Enabled = true;
                btHighScore.Visible = true;
            }
            if ( nextLv == 2)
            {
                btLevel3.Enabled = true;
            }
            if (nextLv == 3)
            {
                btCustom.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fireTime > 0)
                fireTime--;
            else if (fireTime == 0 && lbMinute.ForeColor == Color.DarkRed)
            {
                timer1.Interval = 1000;
                lbTime.ForeColor = lbMinute.ForeColor = lbMAS.ForeColor = lbSecond.ForeColor = Color.Black;
                gbThongTin.BackColor = Color.Pink;
            }
            if (freezeTime > 0)
                freezeTime--;
            else if (freezeTime == 0 && lbMinute.ForeColor == Color.Aqua)
            {
                timer1.Interval = 1000;
                lbTime.ForeColor = lbMinute.ForeColor = lbMAS.ForeColor = lbSecond.ForeColor = Color.Black;
                gbThongTin.BackColor = Color.Pink;
            }
            playTime++;
            int x = int.Parse(lbSecond.Text);
            int y = int.Parse(lbMinute.Text);
            x--;
            if (x < 0)
            {
                x = 59;
                y--;
            }
            lbSecond.Text = x < 10 ? ("0" + x) : x.ToString();
            lbMinute.Text = y < 10 ? ("0" + y) : y.ToString();
            if (y < 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết thời gian rồi, hãy cố gắng lần sau nhé!", "TIME UP!!!", MessageBoxButtons.OK);
                resetArray();
                pnMenu.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (stopTime > 0)
            {
                stopTime--;
            }
            else if (stopTime == 0)
            {
                mpBackgroundMusic.Ctlcontrols.play();
                btPause.Visible = btContinue.Visible = true;
                timer1.Start();
                timer2.Stop();
                lbTime.ForeColor = lbMinute.ForeColor = lbMAS.ForeColor = lbSecond.ForeColor = Color.Black;
                gbThongTin.BackColor = Color.Pink;
            }
        }

        private void btLevel1_Click(object sender, EventArgs e)
        {
            mpBackgroundMusic.settings.volume = 20;
            lbPlayerName.Text = tbPlayerName.Text;
            pnMenu.Hide();
            level1();
            random();
            timer1.Start();
            this.BackgroundImage = btLevel1.BackgroundImage;
        }

        private void btLevel2_Click(object sender, EventArgs e)
        {
            mpBackgroundMusic.settings.volume = 20;
            lbPlayerName.Text = tbPlayerName.Text;
            pnMenu.Hide();
            level2();
            random();
            timer1.Start();
            this.BackgroundImage = btLevel2.BackgroundImage;
        }

        int dem = 0;
        private void btLevel3_Click(object sender, EventArgs e)
        {
            if (dem == 0)
            {
                MessageBox.Show("Ở LEVEL NÀY, BẠN CÓ KHẢ NĂNG SẼ GẶP CÁC HIỆU ỨNG LÀM TÁC ĐỘNG ĐẾN THỜI GIAN CHƠI. ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dem++;
            }
            mpBackgroundMusic.settings.volume = 20;
            lbPlayerName.Text = tbPlayerName.Text;
            pnMenu.Hide();
            level3();
            random();
            timer1.Start();
            this.BackgroundImage = btLevel3.BackgroundImage;
        }

        private void btCustom_Click(object sender, EventArgs e)
        {
            btHighScore.Visible = false;
            btBack.Visible = true;
            lbPlayerName.Text = tbPlayerName.Text;
            SwitchControls(false);
            btOKCustom.Visible = true;
            label2.Visible = true;
            tbSoLuong.Visible = true;
            this.BackgroundImage = btCustom.BackgroundImage;
        }

        private void SwitchControls(bool a)
        {
            if(btLevel2.Enabled)
            {
                btHighScore.Visible = a;
            }
            label3.Visible = a;
            btOkName.Visible = a;
            btLevel1.Visible = a;
            btLevel2.Visible = a;
            btLevel3.Visible = a;
            tbPlayerName.Visible = a;
            label1.Visible = a;
            btCustom.Visible = a;               
        }

        void btOkName_Enter()
        {

            if (tbPlayerName.Text.Length > 20)
                MessageBox.Show("Nhập tên có độ dài dưới 20 ký tự", "");
            else if (tbPlayerName.Text.Length < 1)
                MessageBox.Show("Bạn chưa nhập tên!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tbPlayerName.Text.Length > 0 && tbPlayerName.Text.Length <= 20)
            {
                checkName = true;
                tbPlayerName.Enabled = false;
                music();
            }
            if (checkName)
                btLevel1.Enabled = true;
            tbPlayerName.Focus();
        }

        private void btOkName_Click(object sender, EventArgs e)
        {
            btOkName_Enter();
        }

        public void win()
        {
            if (checkWin == b.Length / 2)
            {
                timer1.Stop();
                if (b.Length == 12 && !btLevel2.Enabled)
                {
                    nextLv = 1;
                    MessageBox.Show("BẠN ĐÃ MỞ KHÓA LEVEL 2  VÀ TÍNH NĂNG HIGHSCORE", "chú ý", MessageBoxButtons.OK);
                }
                if (b.Length == 20 && !btLevel3.Enabled)
                {
                    nextLv = 2;
                    MessageBox.Show("BẠN ĐÃ MỞ KHÓA LEVEL 3", "chú ý", MessageBoxButtons.OK);
                }
                if (b.Length == 30 && !btCustom.Enabled)
                {
                    nextLv = 3;
                    MessageBox.Show("BẠN ĐÃ MỞ KHÓA TÍNH NĂNG CUSTOM", "chú ý", MessageBoxButtons.OK);
                }
                playerScore = playerScoreTemp - clickTime - playTime;
                readFileScore();
                if (MessageBox.Show("Điểm của bạn: " + playerScore + "\nSố lần click: " + lbClickTime.Text +
                    "\nThời gian chơi: " + playTime, "Thống kê", MessageBoxButtons.OK) == DialogResult.OK)
                    resetArray();
                pnMenu.Show();
            }
        }

        public void custom()
        {
           
            int s = int.Parse(tbSoLuong.Text);
                
                b = new Button[s];
                int k = 0, j = 1;
                for (int i = 0; i < b.Length; i++)
                {
                    if (s >= 12 && s <= 16)
                    {
                        lbMinute.Text = 1.ToString();
                        lbSecond.Text = 0.ToString();
                        b[i] = new Button();
                        b[i].Size = new Size(100, 70);
                        b[i].Image = Image.FromFile(pathImage + "Default.jpg");
                        b[i].Location = new Point(115 + k * 105, 75 + j * 75);
                        b[i].Click += new EventHandler(b_Click);
                        b[i].Text = "";
                        this.Controls.Add(b[i]);
                        k++;
                        if (k == 4)
                        {
                            k = 0; j++;
                        }

                    }
                    if (s >= 18 && s <= 24)
                    {
                        lbMinute.Text = 1.ToString();
                        lbSecond.Text = 0.ToString();
                        b[i] = new Button();
                        b[i].Size = new Size(100, 70);
                        b[i].Image = Image.FromFile(pathImage + "Default.jpg");
                        b[i].Location = new Point(80 + k * 105, 10 + j * 75);
                        b[i].Click += new EventHandler(b_Click);
                        b[i].Text = "";
                        this.Controls.Add(b[i]);
                        k++;
                        if (k == 4)
                        {
                            k = 0; j++;
                        }
                    }
                    if (s <= 30 && s >= 26)
                    {
                        lbMinute.Text = 1.ToString();
                        lbSecond.Text = 30.ToString();
                        b[i] = new Button();
                        b[i].Size = new Size(100, 70);
                        b[i].Image = Image.FromFile(pathImage + "Default.jpg");
                        b[i].Location = new Point(40 + k * 105, -60 + j * 75);
                        b[i].Click += new EventHandler(b_Click);
                        b[i].Text = "";
                        this.Controls.Add(b[i]);
                        k++;
                        if (k == 5)
                        {
                            k = 0; j++;
                        }
                    }
                }
        }

        void btOkCustom_Enter()
        {
            if (tbSoLuong.Text.Length == 0)
                MessageBox.Show("Bạn chưa nhập số lượng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (int.Parse(tbSoLuong.Text) < 12 || int.Parse(tbSoLuong.Text) > 30 || int.Parse(tbSoLuong.Text) % 2 == 1)
            {
                MessageBox.Show("Nhập số lượng hình là số lẻ lớn hơn 11 và bé hơn 31", "");
                tbSoLuong.Text = "";
            }
            else
            {
                mpBackgroundMusic.settings.volume = 20;
                tbSoLuong.Focus();
                pnMenu.Hide();
                custom();
                random();
                timer1.Start();
            }
            music();    
        }

        private void btOKCustom_Click(object sender, EventArgs e)
        {
            btOkCustom_Enter();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            SwitchControls(true);
            btOKCustom.Visible = false;
            label2.Visible = false;
            tbSoLuong.Visible = false;
            btBack.Visible = false;
            lbTop3.Visible = lbTop2.Visible = lbTop1.Visible = false;            
            lbHall.Visible = false;
            lbAuthor.Visible = true;
            pnMenu.BackgroundImage = Image.FromFile("bgr.jpg");
        }

        void readFileScore()
        {
            string scoreFile = @"HighScore\ScoreFile.txt";
            string playerName = @"HighScore\PlayerName.txt";
            string highScore = @"HighScore\HighScore.txt";
            string[] sFile = new string[3];
            string[] pName = new string[3];
            string[] hScore = new string[3];
            pName = System.IO.File.ReadAllLines(playerName);
            sFile = System.IO.File.ReadAllLines(scoreFile);
            if(int.Parse(sFile[0]) < playerScore)
            {
                sFile[2] = sFile[1];
                sFile[1] = sFile[0];
                sFile[0] = playerScore.ToString();
                pName[2] = pName[1];
                pName[1] = pName[0];
                pName[0] = tbPlayerName.Text;
            }
            else if (int.Parse(sFile[1]) < playerScore)
            {
                sFile[2] = sFile[1];
                sFile[1] = playerScore.ToString();
                pName[2] = pName[1];
                pName[1] = tbPlayerName.Text;
            }
            else if (int.Parse(sFile[2]) < playerScore)
            {
                sFile[2] = playerScore.ToString();
                pName[2] = tbPlayerName.Text;
            }
            for (int i = 0; i < sFile.Length; i++)
                hScore[i] = pName[i] + "\t" + sFile[i];
            System.IO.File.WriteAllLines(scoreFile, sFile);
            System.IO.File.WriteAllLines(playerName, pName);
            System.IO.File.WriteAllLines(highScore, hScore);
        }

        private void btHighScore_Click(object sender, EventArgs e)
        {
            string scoreFile = @"HighScore\ScoreFile.txt";
            string playerName = @"HighScore\PlayerName.txt";
            string[] sFile = new string[3];
            string[] pName = new string[3];
            pName = System.IO.File.ReadAllLines(playerName);
            sFile = System.IO.File.ReadAllLines(scoreFile);
            lbAuthor.Visible = true;
            btBack.Visible = true;
            SwitchControls(false);            
            lbHall.Visible = true;
            lbHall.Text = "Hall Of Fame";
            lbTop1.Visible = lbTop2.Visible = lbTop3.Visible = lbHall.Visible= true;            
            lbTop1.Text = "1/" + pName[0] + "         " + sFile[0];
            lbTop2.Text = "2/" + pName[1] + "         " + sFile[1];
            lbTop3.Text = "3/" + pName[2] + "         " + sFile[2];
            pnMenu.BackgroundImage = Image.FromFile("hof.jpg");
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)13)
                btOkCustom_Enter();
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b.Length - 1; i++)
                for (int j = i + 1; j < b.Length; j++)
                {
                    b[i].Enabled = false;
                    b[j].Enabled = false;
                    b[i].Image = Image.FromFile(pathImage + "Default.jpg");
                }
            timer1.Stop();           
            btPause.Enabled = false;
            btContinue.Enabled = true;
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b.Length - 1; i++)
                for (int j = i + 1; j < b.Length; j++)
                {
                    b[i].Enabled = true;
                    b[j].Enabled = true;
                }
            timer1.Start();
            btPause.Enabled = true;
            btContinue.Enabled = false;
        }

        private void tbPlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btOkName_Enter();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ?", "Cảnh báo ", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            easterEgg = true;
            int i = 0;
            if (i == 0)
            {
                MessageBox.Show("Chúc mừng bạn đã tìm ra lối tắt!!!", "Congratulation", MessageBoxButtons.OK);
                i++;
            }
            btLevel1.Enabled = btLevel2.Enabled = btLevel3.Enabled = btCustom.Enabled = btHighScore.Visible = true;
        }
        
        private void btGuide_Click(object sender, EventArgs e)
        {
            SwitchControls(false);
            btBack.Visible = true;
            pnMenu.BackgroundImage = Image.FromFile("guide.jpg");
            // Đảm bảo không bị mẫu thuẫn giữa Hall và Highscore
            lbTop1.Visible = lbTop2.Visible = lbTop3.Visible = lbHall.Visible = false;
            lbAuthor.Visible = false;               

        }
    }
}
