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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }


        struct Price
        {
            public string Name;
            public string Store;
            public int Cost;
            public Price(string name, string store, int cost)
            {
                Name = name;
                Store = store;
                Cost = cost;
            }

        }

        Inition inition = new Inition();
        List<Price> price_limit = new List<Price>();

        public void Add_Price(string name, string store, int cost, int i)
        {
            Price price = new Price(name, store, cost);
            price_limit.Add(price);
            MessageBox.Show($"{price_limit[0].Store}, {price_limit[0].Name})");
        }

        private void Init()
        {
            inition.Show();
            this.SendToBack();   
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string store = tbSearch.Text;
            bool searched = false;
            foreach (Price price in price_limit)
            {
                MessageBox.Show(price.Store);
                //lbItems.Items.Add(price.Store);
                if (price.Store.ToLower() == store.ToLower())
                {
                    if (!searched) searched = true;
                    lbItems.Items.Add($"{price.Name}    {price.Cost}р");
                }
            }
            if (!searched) { MessageBox.Show("Такого магазина нет"); }
        }

        private void tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            tbSearch.Text = "";
        }
    }
}
