using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CWORK_Var2_VendingMachine
{
    public partial class GeneralForm : Form
    {
        public static Machine Machine = new Machine();
        public static ServiceStation Station = new ServiceStation();
        int index = -1; // Вибраний чи не вибраний продукт
        public GeneralForm()
        {
            InitializeComponent();
        }
        private void GeneralForm_Load(object sender, EventArgs e)
        {           
            this.Controls["buttonOFF"].BackColor = Color.FromName("IndianRed");
            this.Controls["buttonSecret"].BackColor = Color.FromName("RoyalBlue");
            this.Controls["buttonGetProduct"].BackColor = Color.FromName("SeaGreen");
            this.Controls["buttonLoadCash"].BackColor = Color.FromName("AliceBlue");
            this.Controls["buttonLoadCoins"].BackColor = Color.FromName("AliceBlue");
            this.Controls["buttonRefund"].BackColor = Color.FromName("AliceBlue");

            UpdateProductCount();
            UpdateTrayLight(-1);

            pictureBoxSnickers.Load(Directory.GetCurrentDirectory() + "\\Snickers-logo.jpg");
            pictureBoxMars.Load(Directory.GetCurrentDirectory() + "\\Mars-logo.jpg");
            pictureBoxLays.Load(Directory.GetCurrentDirectory() + "\\Lay's-logo.jpg");
            pictureBoxPepsi.Load(Directory.GetCurrentDirectory() + "\\Pepsi-logo.jpg");
            pictureBoxSprite.Load(Directory.GetCurrentDirectory() + "\\Sprite-logo.jpg");

            Machine.AbsenceProductHandler += Station.ProductToMachine;

            ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
        }
        private void buttonSecret_Click(object sender, EventArgs e)
        {
            SecretForm SF = new SecretForm();
            SF.Show();
        }
        public void ShowMoney(string MachineMoney, string UserMoney)
        {
            richTextBoxMachineCash.Text = "Автомат: " + Machine.MachineMoney.ToString() + '\n';
            richTextBoxMachineCash.Text += "Пользователь: " + Machine.CashInto.ToString();
        }
        private void buttonLoadCash_Click(object sender, EventArgs e)
        {
            if (textBoxCash.Text == "")
                return;
            try
            {
                if (Money.CheckFakeCash(int.Parse(textBoxCash.Text)))
                {
                    Machine.CashInto += new Money(int.Parse(textBoxCash.Text), 0);

                    ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());

                    if (!Machine.CheckUserMoneyAllProducts())
                    {
                        ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
                        richTextBoxMachineCash.Text += "\nНедостаточно денег для любого из товаров!";
                    }
                }
                else
                {
                    MessageBox.Show("Поддельные деньги!");
                    textBoxRefund.Text = textBoxCash.Text;
                    ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Поддельные деньги!");
                textBoxRefund.Text = textBoxCash.Text;
                ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
            }
            textBoxCash.Clear();
        }
        private void buttonLoadCoins_Click(object sender, EventArgs e)
        {
            if (textBoxCoins.Text == "")
                return;
            try
            {
                if (Money.CheckFakeCoins(int.Parse(textBoxCoins.Text)))
                {
                    Machine.CashInto += new Money(0, int.Parse(textBoxCoins.Text));

                    ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());

                    if (!Machine.CheckUserMoneyAllProducts())
                    {
                        ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
                        richTextBoxMachineCash.Text += "\nНедостаточно денег для любого из товаров!";
                    }
                }
                else
                {
                    MessageBox.Show("Поддельные деньги!");
                    textBoxRefund.Text = textBoxCoins.Text;
                    ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Поддельные деньги!");
                textBoxRefund.Text = textBoxCoins.Text;
                ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
            }
            textBoxCoins.Clear();
        }
        private void buttonRefund_Click(object sender, EventArgs e)
        {
            RefundCashForm RCF = new RefundCashForm();
            RCF.Show();
        }
        private void buttonOFF_Click(object sender, EventArgs e)
        {
            Machine.Save();
            Station.Save();
            this.Close();
        }
        public void UpdateProductCount()
        {
            for (int i = 0; i < Machine.Trays.Length; i++)
                switch (i)
                {
                    case 0:
                        textBoxSnickersCount.Text = Machine.Trays[i].ProductsOnTray.Count.ToString();
                        break;
                    case 1:
                        textBoxMarsCount.Text = Machine.Trays[i].ProductsOnTray.Count.ToString();
                        break;
                    case 2:
                        textBoxLaysCount.Text = Machine.Trays[i].ProductsOnTray.Count.ToString();
                        break;
                    case 3:
                        textBoxPepsiCount.Text = Machine.Trays[i].ProductsOnTray.Count.ToString();
                        break;
                    case 4:
                        textBoxSpriteCount.Text = Machine.Trays[i].ProductsOnTray.Count.ToString();
                        break;
                }
        }
        public void UpdateTrayLight(int TrayNumber)
        {
            for (int i = 0; i < Machine.Trays.Length; i++)
                switch (i)
                {
                    case 0:
                        pictureBoxPr1.Load(Directory.GetCurrentDirectory() + "\\Green_light.png");
                        break;
                    case 1:
                        pictureBoxPr2.Load(Directory.GetCurrentDirectory() + "\\Green_light.png");
                        break;
                    case 2:
                        pictureBoxPr3.Load(Directory.GetCurrentDirectory() + "\\Green_light.png");
                        break;
                    case 3:
                        pictureBoxPr4.Load(Directory.GetCurrentDirectory() + "\\Green_light.png");
                        break;
                    case 4:
                        pictureBoxPr5.Load(Directory.GetCurrentDirectory() + "\\Green_light.png");
                        break;
                }

            if (TrayNumber != -1)
                for (int i = 0; i < Machine.Trays.Length; i++)
                    if (TrayNumber == i)
                        switch (i)
                        {
                            case 0:
                                pictureBoxPr1.Load(Directory.GetCurrentDirectory() + "\\Red_light.jpg");
                                break;
                            case 1:
                                pictureBoxPr2.Load(Directory.GetCurrentDirectory() + "\\Red_light.jpg");
                                break;
                            case 2:
                                pictureBoxPr3.Load(Directory.GetCurrentDirectory() + "\\Red_light.jpg");
                                break;
                            case 3:
                                pictureBoxPr4.Load(Directory.GetCurrentDirectory() + "\\Red_light.jpg");
                                break;
                            case 4:
                                pictureBoxPr5.Load(Directory.GetCurrentDirectory() + "\\Red_light.jpg");
                                break;
                        }
        }
        private void GetProduct()
        {
            Machine.CashInto -= Machine.Trays[index].ProductsOnTray.First().ProductPrice;
            Machine.MachineMoney += Machine.Trays[index].ProductsOnTray.First().ProductPrice;
            UpdateProductCount();
        }
        private void buttonGetProduct_Click(object sender, EventArgs e)
        {
            Money[] ProductPrices = new Money[5];

            for (int i = 0; i < Machine.Trays.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (radioButtonPr1.Checked)
                        {
                            Machine.Trays[i].Reach = true;
                            ProductPrices[i] = Machine.Trays[i].ProductsOnTray.First().ProductPrice;
                            index = i;
                        }
                        break;
                    case 1:
                        if (radioButtonPr2.Checked)
                        {
                            Machine.Trays[i].Reach = true;
                            ProductPrices[i] = Machine.Trays[i].ProductsOnTray.First().ProductPrice;
                            index = i;
                        }
                        break;
                    case 2:
                        if (radioButtonPr3.Checked)
                        {
                            Machine.Trays[i].Reach = true;
                            ProductPrices[i] = Machine.Trays[i].ProductsOnTray.First().ProductPrice;
                            index = i;
                        }
                        break;
                    case 3:
                        if (radioButtonPr4.Checked)
                        {
                            Machine.Trays[i].Reach = true;
                            ProductPrices[i] = Machine.Trays[i].ProductsOnTray.First().ProductPrice;
                            index = i;
                        }
                        break;
                    case 4:
                        if (radioButtonPr5.Checked)
                        {
                            Machine.Trays[i].Reach = true;
                            ProductPrices[i] = Machine.Trays[i].ProductsOnTray.First().ProductPrice;
                            index = i;
                        }
                        break;
                }
            }

            if (index == -1)
            {
                MessageBox.Show("Вы не выбрали продукт!");
                return;
            }

            if (Machine.CheckUserCash(Machine.Trays[index].ProductsOnTray.First().ProductPrice))
                 Machine.GetProduct();
            else
            {
                ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
                richTextBoxMachineCash.Text += "\nНедостаточно денег для выбраного товара!";
                Machine.Trays[index].Reach = false;
                return;
            }

            if (Machine.Trays[index].ProductsOnTray.Count > 0) // Якщо продукт наявний
            {
                GetProduct();
                ShowMoney(Machine.MachineMoney.ToString(), Machine.CashInto.ToString());
                UpdateProductCount();
                Machine.Trays[index].Reach = false;      
            }
            else
            {
                ShowMoney((Machine.MachineMoney += ProductPrices[index]).ToString(), (Machine.CashInto -= ProductPrices[index]).ToString());
                UpdateTrayLight(index);
                UpdateProductCount();

                buttonGetProduct.Enabled = false;
                buttonOFF.Enabled = false;
                buttonRefund.Enabled = false;
                buttonSecret.Enabled = false;
                buttonLoadCash.Enabled = false;
                buttonLoadCoins.Enabled = false;

                timerDelay.Enabled = true;
                Machine.Trays[index].Reach = false;
            }
        }
        private void timerDelay_Tick(object sender, EventArgs e)
        {
            UpdateTrayLight(index);
            Station.ProductToMachine(Machine, Machine.Trays[index]);
            UpdateTrayLight(-1);
            UpdateProductCount();

            buttonGetProduct.Enabled = true;
            buttonOFF.Enabled = true;
            buttonRefund.Enabled = true;
            buttonSecret.Enabled = true;
            buttonLoadCash.Enabled = true;
            buttonLoadCoins.Enabled = true;

            timerDelay.Enabled = false;
        }
        public void ShowRefund(Money money)
        {
            textBoxRefund.Text = money.ToString();
        }
        private void textBoxRefund_TextChanged(object sender, EventArgs e)
        {
            textBoxRefund.Click += textboxRefund_TextChangedHandler;
        }
        private void textboxRefund_TextChangedHandler(object sender, EventArgs e)
        {
            if (textBoxRefund.Text!= "")
                MessageBox.Show("Пользователь забрал деньги");
                textBoxRefund.Clear();
        }
    }
}