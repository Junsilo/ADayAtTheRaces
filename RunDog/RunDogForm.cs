using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* By Jusyou
 * Chinese shanghai
 * 2022 0204
 */

namespace RunDog
{
    public partial class RunDogForm : Form
    {
        #region [字段]
        Random MyRandomizer = new Random();
        int[] Cash = new int[3];
        bool[] AmountValue = new bool[3];

        GreyhoundClass[] DogsArray = new GreyhoundClass[4];
        GuyClass[] Guys = new GuyClass[3];
        BetClass[] Bets = new BetClass[3];

        #endregion

        #region [构造函数]
        public RunDogForm()
        {
            InitializeComponent();

            InitializeBetLabel();
            InitializeDogs();
            InitializeBets();

            //每个人的初识钱数
            Cash[0] = 50;
            Cash[1] = 75;
            Cash[2] = 45;

            InitializeGuys(Cash);
        }
        #endregion

        #region [更新押注栏赌徒的名字]
        public void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }
        #endregion

        #region [更新下注按钮按下去后绑定 钱 狗 人]
        private void BetButton_Click(object sender, EventArgs e)
        {

            if (joeRadioButton.Checked)
            {
                Bets[0].Amount = (int)numericUpDown1.Value;
                Bets[0].Dog = (int)numericUpDown2.Value;
                Guys[0].UpdateLabels();

            }
            if (Bets[0].Amount != 0)
                AmountValue[0] = true;

            if (bobRadioButton.Checked)
            {
                Bets[1].Amount = (int)numericUpDown1.Value;
                Bets[1].Dog = (int)numericUpDown2.Value;
                Guys[1].UpdateLabels();

            }
            if (Bets[1].Amount != 0)
                AmountValue[1] = true;

            if (alRadioButton.Checked)
            {
                Bets[2].Amount = (int)numericUpDown1.Value;
                Bets[2].Dog = (int)numericUpDown2.Value;
                Guys[2].UpdateLabels();

            }
            if (Bets[2].Amount != 0)
                AmountValue[2] = true;




        }
        #endregion

        #region [时间滴答器，类似update，每隔一段时间ms执行]
        private void timer1_Tick(object sender, EventArgs e)
        {
            //遍历四只狗
            for (int i = 0; i < 4; i++)
            {
                //一个临时变量暂存一下胜利与否，并让狗子跑起来
                bool Finsh = DogsArray[i].Run();
                //当有任一条狗冲过终点
                if (Finsh)
                {
                    //让时间停止，这样timer1_Tick将停止执行
                    timer1.Stop();
                    //公布哪只狗胜利了，因为索引比序列小1所以+1
                    MessageBox.Show($"Dog # {i + 1} won the race! ", "We have a winner");

                    //让下面的赌场GUI再次激活
                    groupBox1.Enabled = true;

                    //结算每个人的赌注并更新钱数，把当前钱数存下来
                    for (int m = 0; m < 3; m++)
                    {
                        Guys[m].Collect(i + 1);
                        Guys[m].UpdateLabels();
                        Cash[m] = Guys[m].Cash;
                    }

                    //初始化赌注
                    InitializeBets();

                    //初始化赌徒并把新的现金值更新进去，为下局做准备
                    InitializeGuys(Cash);

                    //让每只狗都回到原地
                    for (int n = 0; n < 4; n++)
                    {
                        DogsArray[n].TakeStartingPosition();
                    }

                    
                    return; //为了不让此序列之后狗继续更新往前
                }
            }

        }
        #endregion

        #region [开始比赛按钮]
        private void RaceButton_Click(object sender, EventArgs e)
        {
            //当所有人都没有下注的时候不开始赛跑
            if (AmountValue[0] == AmountValue[1] == AmountValue[2] == false)
            {
                //且返回一个警告
                MessageBox.Show("No One Bet!","Warnning!");
            }
            else
            {
                timer1.Start();
                groupBox1.Enabled = false;
            }

        }
        #endregion

        #region [初始化]

        //初始化最小押注 字符串
        public void InitializeBetLabel()
        {
            minBetLabel.Text = $"Minimum bet : {numericUpDown1.Minimum} bucks";
        }


        //初始化所有的赌注信息
        public void InitializeBets()
        {
            //Bets[0] = new BetClass();
            //Bets[1] = new BetClass();
            //Bets[2] = new BetClass();

            //AmountValue[0] = false;
            //AmountValue[1] = false;
            //AmountValue[2] = false;

            //使用循环初始化
            for (int h = 0; h<3; h++)
            { 
                Bets[h] = new BetClass();
                AmountValue[h] = false;
            }

        }

        //初始化所有的赌徒
        public void InitializeGuys(int[] Cash)
        {

            Guys[0] = new GuyClass();
            Guys[0].Name = "Joe";
            Guys[0].MyBet = Bets[0];
            Guys[0].Cash = Cash[0];
            Guys[0].MyRadioButton = joeRadioButton;
            Guys[0].MyLabel = joeBetLabel;


            Guys[1] = new GuyClass();
            Guys[1].Name = "Bob";
            Guys[1].MyBet = Bets[1];
            Guys[1].Cash = Cash[1];
            Guys[1].MyRadioButton = bobRadioButton;
            Guys[1].MyLabel = bobBetLabel;


            Guys[2] = new GuyClass();
            Guys[2].Name = "Al";
            Guys[2].MyBet = Bets[2];
            Guys[2].Cash = Cash[2];
            Guys[2].MyRadioButton = alRadioButton;
            Guys[2].MyLabel = alBetLabel;

            for (int j = 0; j < 3; j++)
            {
                Guys[j].UpdateLabels();
            }

        }

        //初始化所有的赛狗并赋值
        public void InitializeDogs()
        {
            //因为这里跑道长度是固定的所以就用临时变量存一下
            int raceLength = pictureBoxBG.Width - DogPictureBox1.Width;

            DogsArray[0] = new GreyhoundClass();
            DogsArray[0].StartingPosition = DogPictureBox1.Left;
            DogsArray[0].RacetrackLength = raceLength;
            DogsArray[0].MyPictureBox = DogPictureBox1;
            DogsArray[0].Randomizer = MyRandomizer;

            DogsArray[1] = new GreyhoundClass();
            DogsArray[1].StartingPosition = DogPictureBox2.Left;
            DogsArray[1].RacetrackLength = raceLength;
            DogsArray[1].MyPictureBox = DogPictureBox2;
            DogsArray[1].Randomizer = MyRandomizer;

            DogsArray[2] = new GreyhoundClass();
            DogsArray[2].StartingPosition = DogPictureBox3.Left;
            DogsArray[2].RacetrackLength = raceLength;
            DogsArray[2].MyPictureBox = DogPictureBox3;
            DogsArray[2].Randomizer = MyRandomizer;

            DogsArray[3] = new GreyhoundClass();
            DogsArray[3].StartingPosition = DogPictureBox4.Left;
            DogsArray[3].RacetrackLength = raceLength;
            DogsArray[3].MyPictureBox = DogPictureBox4;
            DogsArray[3].Randomizer = MyRandomizer;
        }
        #endregion

    }
}
