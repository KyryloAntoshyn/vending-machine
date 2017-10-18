using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWORK_Var2_VendingMachine
{
    public partial class RefundCashForm : Form
    {
        public RefundCashForm()
        {
            InitializeComponent();
        }
        private void RefundUserCash_Click(object sender, EventArgs e)
        {
            Money tmpMoney = null;
            try
            {
                if (textBoxKop.Text.Length > 2)
                {
                    MessageBox.Show("Некорректная сумма!");
                    textBoxGrn.Clear();
                    textBoxKop.Clear();
                    return;
                }

                if (textBoxGrn.Text == "")
                    tmpMoney = new Money(0, int.Parse(textBoxKop.Text));
                else if (textBoxKop.Text == "")
                    tmpMoney = new Money(int.Parse(textBoxGrn.Text), 0);
                else
                    tmpMoney = new Money(int.Parse(textBoxGrn.Text), int.Parse(textBoxKop.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректная сумма!");
                textBoxGrn.Clear();
                textBoxKop.Clear();
                return;
            }
            if (GeneralForm.Machine.CashInto >= tmpMoney && GeneralForm.Machine.CashInto > new Money(0, 0) && tmpMoney > new Money(0, 0))
            {
                GeneralForm.Machine.CashInto -= tmpMoney;
                Program.GF.ShowMoney(GeneralForm.Machine.MachineMoney.ToString(), GeneralForm.Machine.CashInto.ToString());
                this.Close();
                Program.GF.ShowRefund(tmpMoney);
            }
            else
            {
                MessageBox.Show("Некорректная сумма!");
                textBoxGrn.Clear();
                textBoxKop.Clear();
            }
        }
        private void buttonNoRefundUserCash_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefundCashForm_Load(object sender, EventArgs e)
        {
            this.Controls["buttonRefundUserCash"].BackColor = Color.FromName("AliceBlue");
            this.Controls["buttonNoRefundUserCash"].BackColor = Color.FromName("AliceBlue");
        }
    }
}