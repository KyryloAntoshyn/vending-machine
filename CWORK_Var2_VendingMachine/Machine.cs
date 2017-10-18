using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CWORK_Var2_VendingMachine
{
    public delegate void ProductCountHandler(object obj, Tray Tray); // Делегат для події
    [Serializable]
    public class Machine
    {
        public Tray[] Trays { get; set; } // Лотки в автоматі
        public Money MachineMoney { get; set; } // Наявні гроші у автоматі
        public Money CashInto { get; set; } // Гроші, які вніс користувач до автомата
        private string SecretPassword { get; set; } // Секретний пароль для адміністратора сервісної станції
        public Machine() // Включає у себе метод Add_Defaults та Load (десеріалізацію)
        {
            MachineMoney = new Money(1000, 0);
            CashInto = new Money(0, 0);
            SecretPassword = "adminadmin";

            string[] tmp = File.ReadAllLines(Directory.GetCurrentDirectory() + "//LastCondition.dat");
            if (tmp.Length == 0)
                Add_Defaults();
            else
                this.Load();
        }
        public void Add_Defaults() // Початкове загруження автомата
        {
            Trays = new Tray[5];
            Product p1 = new Product("Snickers", new Money(6, 50));
            Product p2 = new Product("Mars", new Money(10, 0));
            Product p3 = new Product("Lays", new Money(20, 0));
            Product p4 = new Product("Pepsi", new Money(7, 50));
            Product p5 = new Product("Sprite", new Money(10, 0));

            Product[] Products = Product.AddProductsToArray(p1, p2, p3, p4, p5);

            List<Product> tmpProducts;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                tmpProducts = new List<Product>();
                for (int j = 0; j < rnd.Next(5, 10); j++)
                    tmpProducts.Add(Products[i]);

                switch (i)
                {
                    case 0:
                        Trays[i] = new Tray(tmpProducts, i, false);
                        break;
                    case 1:
                        Trays[i] = new Tray(tmpProducts, i, false);                      
                        break;
                    case 2:
                        Trays[i] = new Tray(tmpProducts, i, false);
                        break;
                    case 3:
                        Trays[i] = new Tray(tmpProducts, i, false);
                        break;
                    case 4:
                        Trays[i] = new Tray(tmpProducts, i, false);
                        break;
                }
            }
        }
        public bool Load() // Десеріалізація для завантаження останнього стану автомата (моделювання пам'яті автомата)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\LastCondition.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Machine DeserializableObj = null;
            try
            {
                DeserializableObj = formatter.Deserialize(fs) as Machine;
            }
            catch (SerializationException)
            {
                return false;
            }
            finally
            {
                fs.Close();
            }
            Trays = DeserializableObj.Trays;
            MachineMoney = DeserializableObj.MachineMoney;
            CashInto = DeserializableObj.CashInto;
            return true;
        }
        public bool Save() // Серіалізація для збереження стану автомата, коли він виключається (моделювання пам'яті автомата)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "//LastCondition.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);
            }
            catch (SerializationException)
            {
                return false;
            }
            finally
            {
                fs.Close();
            }
            return true;
        }
        public bool CheckPassword(string password) // Перевірка на схожість секретного пароля, який зазначений у автоматі
        {
            if (password == SecretPassword)
                return true;
            else
                return false;
        }
        public bool CheckUserMoneyAllProducts() // Перевірка: чи достатня кількість введених користувачем грошей хоча б для одного продукту
        {
            for (int i = 0; i < Trays.Length; i++)
                if (Trays[i].ProductsOnTray.First().ProductPrice > this.CashInto)
                    continue;
                else
                    return true;
            return false;
        }
        public bool CheckProductAvailable() // Перевірка: чи вибраний хоча б один з лотків з товаром для покупки
        {
            for (int i = 0; i < Trays.Length; i++)
                if (Trays[i].Reach == false)
                    return false;
            return true;
        }
        public void GetProduct() // Видалення продукта з вибраного лотка (якщо продукт закінчився, то кидається подія LessProductHandler(this, Trays[i]))
        {
            for (int i = 0; i < Trays.Length; i++)
                if (Trays[i].Reach == true)
                {
                    if (Trays[i].ProductsOnTray.Count == 0)
                        AbsenceProductHandler(this, Trays[i]); // Подія кидається, коли продукту нуль
                    Trays[i].ProductsOnTray.RemoveAt(Trays[i].ProductsOnTray.Count - 1);
                }      
        }
        public bool CheckUserCash(Money productPrice) // Перевірка: чи може користувач придбати вибраний продукт з автомату 
        {
            Money tmp = CashInto - productPrice;
            if (tmp >= new Money())
                return true;
            else
                return false;
        }
        public event ProductCountHandler AbsenceProductHandler; // Подія кидається, коли вибраний лоток з продуктами пустий
    }
}