using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gomrokP1
{
    public class Good
    {
        private string kName;
        private string pName;
        private string weight;
        private double fee;
        public Good(string kname, string pName, string weight, double fee)
        {
            this.kName = kname;
            this.pName = pName;
            this.weight = weight;
            this.fee = fee;
        }
        public string getName()
        {
            return this.kName;
        }
    }
}
