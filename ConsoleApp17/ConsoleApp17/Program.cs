using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    interface ibill
    {
        void Print();
    }
    class Card
    {
        public string number { get; set; }
        public int money { get; set; }
        public int cvv { get; set; }

        public Card() { }
        public Card(string n, int c, int m)
        {
            number = n;
            cvv = c;
            money = m;
        }
        public void Printmoney()
        {
            Console.WriteLine(money);
        }
    }


    class ATM : Card, ibill
    {
        int amount { get; set; }

        public ATM() { }
        public ATM(int a)
        {
            amount = a;
        }
        public void Add(Card Obj, int a)
        {
            money += a;
        }
        public void Take(Card Obj, int a)
        {
            money -= a;
        }
        public void Print()
        {
            Console.WriteLine("Сумма: {0}", money);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card("123456", 235000, 123);
            c.number = "123456";
            c.money = 23500;
            c.cvv = 123;

            ATM a = new ATM();
            a.Print();

        }
    }
}
