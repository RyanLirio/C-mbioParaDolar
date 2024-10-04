using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace conversorDeDolar
{
    public class ConversorDeMoeda
    {
        public double Cotação;
        public double Quantidade;
        public double ConversaoComIOF()
        {
            return (Quantidade/Cotação)-((Quantidade/Cotação)/100)* 6;
        }
        public override string ToString()
        {
            return ConversaoComIOF().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}