using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class AddOrderForm : Form
    {
        public String ID { set; get; }
        public String ProductName1 { get; set; }
        public String ClientName { set; get; }
        public String ClientPhone { get; set; }
        public String Money { set; get; }


        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ID=textBoxID.Text;
            ProductName1=textBoxProductName.Text;
            ClientName=textBoxClientName.Text;
            ClientPhone = textBoxClientPhone.Text;
            Money=textBoxMoney.Text;
            Close();
        }
    }
}
