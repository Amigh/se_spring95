using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gomrokP1
{
    class Ezhar
    {
        private string fName;
        private string lName;
        private string ssn;
        private DateTime date;
        private double totalVal;
        private string sCountry;
        private string transport;
        private List<GoodItem> goods;
        public Ezhar(string fName, string lName, string ssn, DateTime date, double totalVal, string sCountry, string transport, List<GoodItem> goods)
        { 
            this.fName = fName;
            this.lName = lName;
            this.ssn = ssn;
            this.date = date;
            this.totalVal = totalVal;
            this.sCountry = sCountry;
            this.transport = transport;
            this.goods = goods;
        }
    }
}
