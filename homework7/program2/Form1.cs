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
    public partial class Form1 : Form
    {
        public OrderService orderService = new OrderService();

        public Form1()
        {
            InitializeComponent();

            orderService.AddOrder(new Order("1", "2", "3", 4));
            orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
            orderService.AddOrder(new Order("2", "2", "3", 4));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
            try
            {
                orderService.Import(importForm.FileName);
            }
            catch (System.ArgumentNullException) { }
            finally
            {
                orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.ShowDialog();
            try
            {
                orderService.AddOrder(new Order(addOrderForm.ID, addOrderForm.ProductName1, addOrderForm.ClientName, long.Parse(addOrderForm.Money)));
            }
            catch (System.ArgumentNullException) { }
            finally
            {
                orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteOrderForm deleteOrderForm = new DeleteOrderForm();
            deleteOrderForm.ShowDialog();
            try
            {
                orderService.DeleteOrder(deleteOrderForm.ID);
            }
            catch (System.ArgumentNullException) { }
            finally
            {
                orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
            }
        }
    }
}
