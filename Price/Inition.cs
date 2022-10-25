using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Price
{
    public partial class Inition : Form
    {
        public int Init_Number = 0;
        public string Name;
        public string Store;
        public int Cost;


        public Inition()
        {
            InitializeComponent();
            Main main = new Main();
        }


        private void Next_Click(object sender, EventArgs e)
        {
            Init_Number++;
            Name = tbName.Text;
            Store = tbStore.Text;
            Cost = Convert.ToInt32(tbCost.Text);
            main.Add_Price(Name, Store, Cost, Init_Number);
            this.Text = $"Инициализация {Init_Number} из 8";
            tbName.Text = "";
            tbStore.Text = "";
            tbCost.Text = "";
            if (Init_Number == 2)
            {
                MessageBox.Show("Все элементы заполнены!");
                this.Close();
            }
        }
    }
}
