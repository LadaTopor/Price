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
            string Name;
            string Store;
            int Cost;
            public Price(string name, string store, int cost)
            {
                Name = name;
                Store = store;
                Cost = cost;
            }

        }
        private void Init()
        {
            Price[] prive_limit = new Price[8];
            Inition inition = new Inition();
            while (inition.Init_Number != 9) // Баг
            {
                Price price = new Price(inition.Name, inition.Store, inition.Cost);
                inition.Text = $"Инициализация {inition.Init_Number} из 8";
                inition.Show();
                prive_limit[inition.Init_Number] = price;
            }
        }
    }
}
