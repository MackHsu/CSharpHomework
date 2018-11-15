using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace program2
{
    public partial class Form1 : Form
    {
        public OrderService orderService = new OrderService();

        public Form1()
        {
            InitializeComponent();

            orderServiceBindingSource.DataSource = new BindingList<Order>(orderService.orders);
        }

        private void buttonDiserialize_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
            try
            {
                orderService.Import(importForm.FileName);
            }
            catch(ArgumentNullException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (Exception error)
            {
                ErrorForm errorForm = new ErrorForm(error.Message);
                errorForm.ShowDialog();
            }
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
                orderService.AddOrder(new Order(addOrderForm.ID, addOrderForm.ProductName1, addOrderForm.ClientName, addOrderForm.ClientPhone, long.Parse(addOrderForm.Money)));
            }
            catch(FormatException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (ArgumentNullException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (Exception error)
            {
                ErrorForm errorForm = new ErrorForm(error.Message);
                errorForm.ShowDialog();
            }
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
            catch (FormatException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (ArgumentNullException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (Exception error)
            {
                ErrorForm errorForm = new ErrorForm(error.Message);
                errorForm.ShowDialog();
            }
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
                orderService.ReviseOrderForForm(reviseOrderForm.OldID, reviseOrderForm.NewID, reviseOrderForm.newProductName, reviseOrderForm.newClientName, reviseOrderForm.newClientPhone, reviseOrderForm.newMoney);
            }
            catch (FormatException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (ArgumentNullException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (Exception error)
            {
                ErrorForm errorForm = new ErrorForm(error.Message);
                errorForm.ShowDialog();
            }
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
            catch (ArgumentNullException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (Exception error)
            {
                ErrorForm errorForm = new ErrorForm(error.Message);
                errorForm.ShowDialog();
            }
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

        private void buttonToHTML_Click(object sender, EventArgs e)
        {
            ToHTMLForm toHTMLForm = new ToHTMLForm();
            toHTMLForm.ShowDialog();
            try
            {
                orderService.ToHTML(toHTMLForm.XmlFileName, toHTMLForm.XsltFileName, toHTMLForm.HtmlFileName);
            }
            catch (ArgumentNullException) { }      //点弹窗的关闭时不弹出错误窗口
            catch (Exception error)
            {
                ErrorForm errorForm = new ErrorForm(error.Message);
                errorForm.ShowDialog();
            }
        }
    }
}
