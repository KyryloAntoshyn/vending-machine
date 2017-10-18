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
    [Serializable]
    public class ServiceStation
    {
        private List<List<Product>> AvailableProducts { get; set; } // Доступні продукти на станції
        public Money StationMoney { get; set; } // Гроші на станції
        public ServiceStation() // Конструктор без параметрів
        {
            AvailableProducts = new List<List<Product>>();
            StationMoney = new Money(1000, 0);

            string[] tmp = File.ReadAllLines(Directory.GetCurrentDirectory() + "//ServiceCondition.dat");
            if (tmp.Length == 0)
                AddDefaults();
            else
                this.Load();
        }
        public void AddDefaults() // Початковий стан станції обслуговування
        {
            Product p1 = new Product("Snickers", new Money(6, 50));
            Product p2 = new Product("Mars", new Money(10, 0));
            Product p3 = new Product("Lays", new Money(20, 0));
            Product p4 = new Product("Pepsi", new Money(7, 50));
            Product p5 = new Product("Sprite", new Money(10, 0));
            
            Product[] tmpProduct = Product.AddProductsToArray(p1, p2, p3, p4, p5);
            List<Product> tmp;

            for (int i = 0; i < tmpProduct.Length; i++)
            {
                tmp = new List<Product>(); 
                for (int j = 0; j < 1000; j++)
                    tmp.Add(tmpProduct[i]);
                AvailableProducts.Add(tmp);
            }
        }
        public bool Load() // Десеріалізація для завантаження останнього стану станції
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\ServiceCondition.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            ServiceStation DeserializableObj = null;
            try
            {
                DeserializableObj = formatter.Deserialize(fs) as ServiceStation;
            }
            catch (SerializationException)
            {
                return false;
            }
            finally
            {
                fs.Close();
            }
            AvailableProducts = DeserializableObj.AvailableProducts;
            StationMoney = DeserializableObj.StationMoney;
            return true;
        }
        public bool Save() // Серіалізація для збереження стану станції, коли автомат виключається
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "//ServiceCondition.dat", FileMode.Open);
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
        public void ProductToMachine(object obj, Tray Tray) // Заповненя пустого лотка. Метод підписаний на подію AbsenceProductHandler
        {
            for (int i = 0; i < AvailableProducts.Count; i++)
                if (i == Tray.TrayNumber)
                {
                    (obj as Machine).Trays[i] = new Tray(AvailableProducts[i].GetRange(0, 10), i, false);
                    break;
                }
        }
    }
}