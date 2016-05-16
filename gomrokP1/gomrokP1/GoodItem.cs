using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gomrokP1
{
    public class GoodItem
    {
        private Good good;
        private double quntity;
        public GoodItem(Good good, double quntity)
        {
            this.good = good;
            this.quntity = quntity;
        }
        public Good getGood()
        {
            return good;
        }
        public double getQuntity()
        {
            return this.quntity;
        }
    }

}
