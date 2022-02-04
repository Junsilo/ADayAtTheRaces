using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunDog
{
    public class GreyhoundClass //对象 赛狗 
    {
        public int StartingPosition = 0; //where my pictureBox starts
        public int RacetrackLength = 0; //How long the racetrack is
        public PictureBox MyPictureBox = new PictureBox(); //my picturebox object
        public int Location = 0; //My Location on the racetrack
        public Random Randomizer = new Random(); //an instance of Random



        //让狗随机往前跑，任一狗到达目的地后停止
        public bool Run()
        {
            Location += Randomizer.Next(1, 4); //对偏移进行随机叠加，1到4随机一个数字
            MyPictureBox.Left += Location; //把它当前的位置给正确的值
            if (MyPictureBox.Left >= RacetrackLength - MyPictureBox.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
            //根据它的左侧是否等于跑道长度减去自身贴图宽度
            //如果等于说明跑到头了返回真，如果没有就返回假
        }

        //让狗子返回起点
        public void TakeStartingPosition()
        {
            MyPictureBox.Left = StartingPosition;
        }
    }
}
