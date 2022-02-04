using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunDog
{
    public class GuyClass //对象 赌徒
    {
        public string Name ; //赌徒人名
        public BetClass MyBet ; //赌注
        public int Cash = 0; //赌徒拥有的现金

        public RadioButton MyRadioButton = new RadioButton(); //单选按钮
        public Label MyLabel = new Label(); //My Label


        //更新所有的label 包括单选按钮上的字符串
        public void UpdateLabels()
        {
            MyRadioButton.Text = $"{Name} has {Cash} bucks"; //单选按钮上的字符串
            MyBet.Bettor = this; //关联赌注和赌徒
            if (this.PlaceBet(MyBet.Amount, MyBet.Dog)) //如果下注成功
            {
                MyLabel.Text = MyBet.GetDescription(); //那就更新标签栏
            }
            else
            {
                MyBet.Amount = 0; //否则把赌注的金额设置为0，为之后的判断做准备
            }
        }

        //清除赌注，给下一局做准备
        public void ClearBet()
        {
            this.MyBet = new BetClass();
        }

        //是否能下注成功
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            //如果持有的现金大于押注 返回true 并且更新描述文字
            if (Cash > BetAmount)
            {
                MyBet.Dog = DogToWin;
                return true;
            }
            //如果没钱就返回没足够钱 并返回false
            else
            {
                MessageBox.Show("I don't have enough money to bet!", $"{this.Name} says ...");
                return false;
            }
        }


        public void Collect(int Winner)
        {
            MyBet.Bettor = this;
            if(Cash>MyBet.Amount)
                MyBet.Payout(Winner);
            this.ClearBet();
            this.UpdateLabels();
        }


    }
}
