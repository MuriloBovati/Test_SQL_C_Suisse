using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Suisse
{
    internal class Trading
    {
        private int id_trade;
        private double cash;
        private string clientSector;
        private string risk;

        public Trading(int id_trade, int cash, string clientSector)
        {
            this.id_trade = id_trade;
            this.cash = (double)cash;
            this.clientSector = clientSector;
            checkRisk();
        }

        private void checkRisk()
        {
            if(cash < 1000000)
            {
                if(clientSector == "public")
                {
                    risk = "LOWRISK";
                }
                else
                {
                    risk = "MEDIUMRISK";
                }
            }
            else
            {
                if (clientSector == "public")
                {
                    risk = "MEDIUMRISK/HIGHRISK";
                } else
                {
                    risk = "HIGHRISK";
                }
            }

        }
        public void showData()
        {
            Console.WriteLine($"ID Trade:{id_trade}, {cash.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))} ClientSetor: {clientSector},Risk: {risk}");
        }
        public string getRisk()
        {
            if(risk == null)
            {
                Console.WriteLine("bug");
            }
            return risk;
        }
    }
}
