using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Laba3Part3
{
    class Currency
    {
        public double Value;

        public Currency(double value1)
        {
            Value = value1;
        }
    }

    class CurrenceUSD : Currency
    {
        public double USDtoEUR;
        public double USDtoRUB;

        public CurrenceUSD(double _value, double _rub, double _eur) : base(_value)
        {
            USDtoEUR = _eur;
            USDtoRUB = _rub;
        }
        public static implicit operator CurrenceUSD(CurrenceRUB _rub)
        {
            return new CurrenceUSD(_rub.Value * _rub.RUBtoUSD, 1 / _rub.RUBtoUSD, _rub.RUBtoEUR / _rub.RUBtoUSD);
        }

        public static explicit operator CurrenceRUB(CurrenceUSD _usd)
        {
            return new CurrenceRUB(_usd.Value * _usd.USDtoRUB, 1 / _usd.USDtoRUB, _usd.USDtoEUR / _usd.USDtoRUB);
        }

        public static implicit operator CurrenceUSD(CurrenceEUR _eur)
        {
            return new CurrenceUSD(_eur.Value * _eur.EURtoUSD, 1 / _eur.EURtoUSD, _eur.EURtoRUB / _eur.EURtoUSD);
        }

        public static explicit operator CurrenceEUR(CurrenceUSD _usd)
        {
            return new CurrenceEUR(_usd.Value * _usd.USDtoEUR, 1 / _usd.USDtoEUR, _usd.USDtoEUR / _usd.USDtoRUB);
        }
    }

    class CurrenceEUR : Currency
    {
        public double EURtoRUB;
        public double EURtoUSD;

        public CurrenceEUR(double _value, double _rub, double _usd) : base(_value)
        {
            EURtoRUB = _rub;
            EURtoUSD = _usd;
        }

        public static implicit operator CurrenceEUR(CurrenceRUB _rub)
        {
            return new CurrenceEUR(_rub.Value * _rub.RUBtoEUR, 1 / _rub.RUBtoEUR, _rub.RUBtoUSD / _rub.RUBtoEUR);
        }

        public static explicit operator CurrenceRUB(CurrenceEUR _eur)
        {
            return new CurrenceRUB(_eur.Value * _eur.EURtoRUB, 1 / _eur.EURtoRUB, _eur.EURtoUSD / _eur.EURtoRUB);
        }

        public static implicit operator CurrenceEUR(CurrenceUSD _usd)
        {
            return new CurrenceEUR(_usd.Value * _usd.USDtoEUR, _usd.USDtoRUB / _usd.USDtoEUR, 1 / _usd.USDtoEUR);
        }
    }

    class CurrenceRUB : Currency
    {
        public double RUBtoUSD;
        public double RUBtoEUR;

        public CurrenceRUB(double _value, double _usd, double _eur) : base(_value)
        {
            RUBtoUSD = _usd;
            RUBtoEUR = _eur;
        }

        public static implicit operator CurrenceRUB(CurrenceEUR _eur)
        {
            return new CurrenceRUB(_eur.Value * _eur.EURtoRUB, _eur.EURtoUSD / _eur.EURtoRUB, 1 / _eur.EURtoRUB);
        }
        
        public static implicit operator CurrenceRUB(CurrenceUSD _usd)
        {
            return new CurrenceRUB(_usd.Value * _usd.USDtoRUB, 1 / _usd.USDtoRUB, _usd.USDtoEUR / _usd.USDtoRUB);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string check = "";
            Console.WriteLine("Введите курс валют:");
            Console.WriteLine("USD->RUB");
            double USDtoRUB = Double.Parse(Console.ReadLine());
            Console.WriteLine("EUR->RUB");
            double EURtoRUB = Double.Parse(Console.ReadLine());
            Console.WriteLine("EUR->USD");
            double EURtoUSD = Double.Parse(Console.ReadLine());

            Console.WriteLine("В какой валюте вы храните деньги?");
            string currency = Console.ReadLine();
            Console.WriteLine("Сколько у вас денег?");
            double value = Double.Parse(Console.ReadLine());
            CurrenceRUB myAccountR;
            CurrenceUSD myAccountU;
            CurrenceEUR myAccountE;

            if (currency == "RUB")
            {
                myAccountR = new CurrenceRUB(value, 1 / USDtoRUB, 1 / EURtoRUB);
                Console.WriteLine("\n" + "RUB");
                Console.WriteLine(myAccountR.Value);
                Console.WriteLine(myAccountR.RUBtoUSD);
                Console.WriteLine(myAccountR.RUBtoEUR);

                myAccountU = (CurrenceUSD)myAccountR;
                Console.WriteLine("\n" + "RUB->USD");
                Console.WriteLine(myAccountU.Value);

                myAccountE = myAccountR;
                Console.WriteLine("\n" + "RUB->EUR");
                Console.WriteLine(myAccountE.Value);
            }

            if (currency == "USD")
            {
                myAccountU = new CurrenceUSD(value, USDtoRUB, 1 / EURtoUSD);
                Console.WriteLine("\n" + "USD");
                Console.WriteLine(myAccountU.Value);
                Console.WriteLine(myAccountU.USDtoRUB);
                Console.WriteLine(myAccountU.USDtoEUR);

                myAccountR = myAccountU;
                Console.WriteLine("\n" + "USD->RUB");
                Console.WriteLine(myAccountR.Value);

                myAccountE = myAccountU;
                Console.WriteLine("\n" + "USD->EUR");
                Console.WriteLine(myAccountE.Value);
            }

            if (currency == "EUR")
            {
                myAccountE = new CurrenceEUR(value, EURtoRUB, EURtoUSD);
                Console.WriteLine("\n" + "EUR");
                Console.WriteLine(myAccountE.Value);
                Console.WriteLine(myAccountE.EURtoUSD);
                Console.WriteLine(myAccountE.EURtoRUB);

                myAccountR = myAccountE;
                Console.WriteLine("\n" + "EUR->RUB");
                Console.WriteLine(myAccountR.Value);

                myAccountU = (CurrenceUSD)myAccountE;
                Console.WriteLine("\n" + "EUR->USD");
                Console.WriteLine(myAccountU.Value);
            }
        }
    }
}
