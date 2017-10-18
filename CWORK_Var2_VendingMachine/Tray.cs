using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWORK_Var2_VendingMachine
{
    [Serializable]
    public class Tray
    {
        public List<Product> ProductsOnTray { get; set; } // Продукти на лотку
        public int TrayNumber { get; set; } // Номер лотка
        public bool Reach { get; set; } // Перевірка: з цього лотка виймаємо продукт
        public Tray(List<Product> ProductsOnTray, int TrayNumber, bool Reach) // Конструктор з параметрами
        {
            this.ProductsOnTray = ProductsOnTray;
            this.TrayNumber = TrayNumber;
            this.Reach = Reach;
        }
    }
}