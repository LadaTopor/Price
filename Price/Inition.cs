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
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Name = tbName.Text;
            Store = tbStore.Text;
            Cost = Convert.ToInt32(tbCost.Text);
            Init_Number++;
            
        }
    }
}
