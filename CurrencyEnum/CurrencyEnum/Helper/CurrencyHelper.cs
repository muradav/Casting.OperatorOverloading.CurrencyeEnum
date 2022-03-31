using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyEnum.Helper
{
    enum Currency {USD,EUR,TRY}
    class CurrencyHelper
    {
        public void Exchange(Enum obj, double azn)
        {
            bool testenum = false;
            if(obj is Currency)
            {
                testenum =true;
                switch (obj)
                {
                    case Currency.USD:

                        Console.WriteLine($"{azn} AZN = {azn * 0.59} USD");
                        break;

                    case Currency.EUR:

                        Console.WriteLine($"{azn} AZN = {azn * 0.53} EUR");
                        break;

                    case Currency.TRY:

                        Console.WriteLine($"{azn} AZN = {azn * 8.62} TYR");
                        break;

                }               

                
            }
            else
            {
                Console.WriteLine("Currency is not exist");
            }
            
            




        }
    }
}
