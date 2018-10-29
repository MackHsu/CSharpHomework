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

        private void buttonDiserialize_Click(object sender, EventArgs e)
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
    
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.ShowDialog();
            try
            {
                orderService.AddOrder(new Order(addOrderForm.ID, addOrderForm.ProductName1, addOrderForm.ClientName, long.Parse(addOrderForm.Money)));
            }
            catch { }
            finally
            {
                orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrderForm deleteOrderForm = new DeleteOrderForm();
            deleteOrderForm.ShowDialog();
            try
            {
                orderService.DeleteOrder(deleteOrderForm.ID);
            }
            catch { }
            finally
            {
                orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
            }
        }

        private void buttonReviseOrder_Click(object sender, EventArgs e)
        {
            ReviseOrderForm reviseOrderForm = new ReviseOrderForm();
            reviseOrderForm.ShowDialog();
            try
            {
                orderService.ReviseOrderForForm(reviseOrderForm.OldID, reviseOrderForm.NewID, reviseOrderForm.newProductName, reviseOrderForm.newClientName, reviseOrderForm.newMoney);
            }
            catch { }
            finally
            {
                orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
            try
            {
                orderService.Export(importForm.FileName);
            }
            catch { }
            finally
            {
                orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
            }
        }

        private void buttonSearchByID_Click(object sender, EventArgs e)
        {
            orderServiceBindingSource.DataSource = orderService.orders.Where(s => s.ID == textBox1.Text);
        }

        private void buttomSearchByProductName_Click(object sender, EventArgs e)
        {
            orderServiceBindingSource.DataSource = orderService.orders.Where(s => s.ProductName == textBox2.Text);
        }

        private void buttonSearchByClientName_Click(object sender, EventArgs e)
        {
            orderServiceBindingSource.DataSource = orderService.orders.Where(s => s.ClientName == textBox3.Text);
        }

        private void buttonSearchByMoney_Click(object sender, EventArgs e)
        {
            orderServiceBindingSource.DataSource = orderService.orders.Where(s => s.Money > long.Parse((textBox4.Text)));
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
        }
    }
}
