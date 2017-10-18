using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWORK_Var2_VendingMachine
{
    [Serializable]
    public class Money
    {
        private int Cash { get; set; } // Купюри
        private int Coins { get; set; } // Монети
        public Money() // Конструктор без параметрів
        {
            Cash = 0;
            Coins = 0;
        }
        public Money(int Cash, int Coins) // Конструктор з параметрами
        {
            this.Cash = Cash;
            this.Coins = Coins;
        }
        public static bool CheckFakeCash(int Cash) // Перевірка купюри на підробку (статичний)
        {
            List<int> AvailableCash = new List<int>() { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            if (AvailableCash.Contains(Cash))
                return true;
            else
                return false;
        }
        public static bool CheckFakeCoins(int Coin) // Перевірка монети на підробку (статичний)
        {
            List<int> AvailableCoins = new List<int>() { 1, 2, 5, 10, 25, 50 };
            if (AvailableCoins.Contains(Coin))
                return true;
            else
                return false;
        }
        public override string ToString() // Перевизначений метод (вивід на екран)
        {
            return Cash + "-" + Coins + " грн";
        }
        public static Money operator +(Money obj1, Money obj2) // Перевантажена операція для коректного додавання об'єктів типу Money
        {
            Money money = new Money();
            money.Cash = obj1.Cash + obj2.Cash;
            int coins = obj1.Coins + obj2.Coins;

            if (coins > 99)
                do
                {
                    money.Cash += 1;
                    coins -= 100;
                }
                while (coins > 100);   
            money.Coins = coins;
            return money;
        }
        public static Money operator -(Money obj1, Money obj2) // Перевантажена операція для коректного віднімання об'єктів типу Money
        {
            Money money = new Money();
            money.Cash = obj1.Cash - obj2.Cash;
            int coins = obj1.Coins - obj2.Coins;

            if (coins < 0)
            {
                coins = Math.Abs(coins);
                do
                {
                    money.Cash -= 1;
                    coins -= 100;
                    money.Coins = Math.Abs(coins);
                }
                while (coins >= 100);
            }
            else
                money.Coins = coins;
            return money;
        }
        public static bool operator >(Money obj1, Money obj2) // Перевантажена операція для порівняння об'єктів типу Money
        {
            if (obj1.Cash > obj2.Cash)
                return true;
            else if (obj1.Cash == obj2.Cash)
                if (obj1.Coins > obj2.Coins)
                    return true;
                else
                    return false;
            else
                return false;       
        }
        public static bool operator <(Money obj1, Money obj2) // Перевантажена операція для порівняння об'єктів типу Money
        {
            if (obj1.Cash < obj2.Cash)
                return true;
            else if (obj1.Cash == obj2.Cash)
                if (obj1.Coins < obj2.Coins)
                    return true;
                else
                    return false;
            else
                return false;
        }
        public static bool operator >=(Money obj1, Money obj2) // Перевантажена операція для порівняння об'єктів типу Money
        {
            if (obj1.Cash == obj2.Cash)
            {
                if (obj1.Coins >= obj2.Coins)
                    return true; // По монетам
                else
                    return false;
            }
            else if (obj1.Cash > obj2.Cash)
                return true;
            else
                return false;
        }   
        public static bool operator <=(Money obj1, Money obj2) // Перевантажена операція для порівняння об'єктів типу Money
        {
            if (obj1.Cash == obj2.Cash)
            {
                if (obj1.Coins <= obj2.Coins)
                    return true; // По монетам
                else
                    return false;
            }
            else if (obj1.Cash < obj2.Cash)
                return true;
            else
                return false;
        }
    }
}