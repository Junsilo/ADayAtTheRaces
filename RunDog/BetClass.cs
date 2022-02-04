using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunDog
{
    public class BetClass //对象 赌注
    {
        public int Amount;
        public int Dog;
        public GuyClass Bettor;

        //初始化描述信息
        public string GetDescription()
        {
            if (Amount != 0)
                return $"{Bettor.Name} bets {Amount} on dog # {Dog}";
            else
                return $"{Bettor.Name} hasn't placed a bet";
        }

        //根据狗子的胜利结果给赌徒进账或者扣钱
        public int Payout(int Winner)
        {
            if (Dog == Winner)
                return Bettor.Cash += Amount; //temp
            else
                return Bettor.Cash -= Amount;
        }

    }
}
