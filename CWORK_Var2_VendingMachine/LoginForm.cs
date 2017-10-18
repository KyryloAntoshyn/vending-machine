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
    public partial class SecretForm : Form
    {
        public SecretForm()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (GeneralForm.Machine.CheckPassword(textBoxPassword.Text))
                buttonGetMachMoney.Enabled = true;
            else
                textBoxPassword.Clear();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.MaxLength = 10;
            textBoxPassword.UseSystemPasswordChar = true;
        }
        private void buttonGetMachMoney_Click(object sender, EventArgs e)
        {
            GeneralForm.Station.StationMoney += GeneralForm.Machine.MachineMoney;
            GeneralForm.Machine.MachineMoney = new Money(0,0);
            Program.GF.ShowMoney(GeneralForm.Machine.MachineMoney.ToString(), GeneralForm.Machine.CashInto.ToString());
            this.Close();
            MessageBox.Show("Деньги на сервисной станции: " + GeneralForm.Station.StationMoney.ToString());
        }
        private void SecretForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Вход только для администратора!");
        }
    }
}
