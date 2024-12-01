using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface ITrade
    {
        void PurchaseWeapon(Creature otherTrade, IWeapon s);
        void ExchangeItem(Creature otherTrade, Subject s);
    }
    public class Trader : ITrade
    {


        public void PurchaseWeapon(Creature otherTrade, IWeapon s)
        {

        }






        public void ExchangeItem(Creature otherTrade, Subject s)
        {


        }
    }
}
