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
    public partial class ReviseOrderForm : Form
    {
        public String OldID { get; set; }
        public String NewID { get; set; }
        public String newProductName { get; set; }
        public String newClientName { get; set; }
        public long newMoney;

        public ReviseOrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OldID = textBox1.Text;
                AddOrderForm addOrderForm = new AddOrderForm();
                addOrderForm.ShowDialog();
                NewID = addOrderForm.ID;
                newProductName = addOrderForm.ProductName1;
                newClientName = addOrderForm.ClientName;
                newMoney = long.Parse(addOrderForm.Money);
            }
            catch { }
            finally
            {
                Close();
            }
        }
    }
}
