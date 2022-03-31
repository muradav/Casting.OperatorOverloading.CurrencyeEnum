using CurrencyEnum.Helper;
using System;

namespace CurrencyEnum
{
    class Program
    {
        

        static void Main(string[] args)
        {
            CurrencyHelper nc = new CurrencyHelper();
            nc.Exchange(Currency.EUR, 170);
           
        }


            
    }
}
