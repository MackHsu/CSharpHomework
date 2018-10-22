using Microsoft.VisualStudio.TestTools.UnitTesting;
using program2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void CheckIDInputTest()
        {
            OrderService orderService = new OrderService();
            try
            {
                orderService.CheckIDInput("a");
            }
            catch(Exception e)
            {
                StringAssert.Equals(e.Message, "错误！请输入数字串作为订单号");
            }
            orderService.CheckIDInput("1");
        }

        [TestMethod()]
        public void IsUniqueTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("1", "1", "1", 1);
            orderService.orders.Add(order1);
            orderService.IsUnique("2");
            try
            {
                orderService.IsUnique("1");
            }
            catch(Exception e)
            {
                StringAssert.Equals(e.Message, "错误！订单号已存在");
            }
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Order newOrder = new Order();
            newOrder.ID = "1"; newOrder.ProductName = "1"; newOrder.ClientName = "1"; newOrder.Money = 1;
            OrderService orderService = new OrderService();
            orderService.AddOrder(newOrder);
            Assert.IsTrue(orderService.orders.Contains(newOrder));
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("1", "1", "1", 1);
            Order order2 = new Order("2", "2", "2", 2);
            orderService.orders.Add(order1);
            orderService.orders.Add(order2);
            orderService.DeleteOrder("1");
            Assert.IsFalse(orderService.orders.Contains(order1));
            Assert.IsTrue(orderService.orders.Contains(order2));
        }

        [TestMethod()]
        public void SearchByIDTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("1", "1", "1", 1);
            orderService.orders.Add(order1);
            orderService.SearchByID("1");
            try
            {
                orderService.SearchByID("2");
            }
            catch(Exception e)
            {
                StringAssert.Equals(e.Message, "错误！未找到该订单");
            }
        }

        [TestMethod()]
        public void SearchByProductNameTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("1", "1", "1", 1);
            orderService.orders.Add(order1);
            orderService.SearchByProductName("1");
            try
            {
                orderService.SearchByProductName("2");
            }
            catch (Exception e)
            {
                StringAssert.Equals(e.Message, "错误！未找到该订单");
            }
        }

        [TestMethod()]
        public void SearchByClientNameTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("1", "1", "1", 1);
            orderService.orders.Add(order1);
            orderService.SearchByClientName("1");
            try
            {
                orderService.SearchByClientName("2");
            }
            catch (Exception e)
            {
                StringAssert.Equals(e.Message, "错误！未找到该订单");
            }
        }

        [TestMethod()]
        public void SearchByMoneyTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("1", "1", "1", 1);
            orderService.orders.Add(order1);
            orderService.SearchByMoney(0);
            try
            {
                orderService.SearchByMoney(2);
            }
            catch (Exception e)
            {
                StringAssert.Equals(e.Message, "错误！未找到该订单");
            }
        }
    }
}