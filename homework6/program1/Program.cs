using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace program2
{
    public class OrderException : Exception
    {
        public OrderException(string message) : base(message)
        { }

        public OrderException() : base()
        { }
    }

    public class Order : OrderDetails
    {
        public String ID { get; set; }              //订单号
        public Order() { }
        public Order(String ID, String productName,String clientName,long money)
        {
            this.ID = ID; ProductName = productName; ClientName = clientName; Money = money;
        }
    }

    [Serializable]
    public class OrderDetails
    {
        public String ProductName { get; set; }     //商品名
        public String ClientName { get; set; }      //客户名
        public long Money { get; set; }           //订单金额
    }

    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        public void DisplayOrder(Order order)       //打印一个订单
        {
            Console.WriteLine($"订单号：{order.ID}");
            Console.WriteLine($"商品名：{order.ProductName}");
            Console.WriteLine($"客户名：{order.ClientName}");
            Console.WriteLine($"订单金额：{order.Money}\n");
        }

        public void DisplayOrderList()             //打印整个订单列表
        {
            foreach (Order order in orders)
                DisplayOrder(order);
            Console.WriteLine("========================\n");
        }

        public static void CheckIDInput(String newID)        //检查输入的订单号是否为数字，若不是则抛出异常
        {
            try
            {
                int temp = Int32.Parse(newID);
            }
            catch (System.FormatException)
            {
                throw new OrderException("错误！请输入数字串作为订单号");
            }
        }

        public void IsUnique(String newID)            //检查订单号是否重复
        {
            foreach (Order order in orders)
            {
                if (order.ID == newID)
                {
                    throw new OrderException("错误！订单号已存在");
                }
            }
        }

        public void AddOrder(Order newOrder)                  //添加新订单
        {
            CheckIDInput(newOrder.ID);            //确保订单号为数字串
            IsUnique(newOrder.ID);                //确保订单号唯一，如果没有重复则继续输入，如果重复则结束输入且不添加新订单
            orders.Add(newOrder);
        }

        public void DeleteOrder(String ID)          //通过订单号删除订单，删除前可以用查询功能查询订单号
        {
            bool deleted = false;          //是否已经删除
            CheckIDInput(ID);
            foreach (Order order in orders)
            {
                if (order.ID == ID)
                {
                    orders.Remove(order);
                    deleted = true;
                    break;
                }
            }
            if (!deleted)
                throw new OrderException("错误！找不到该订单");
        }

        public void Search(int flag)                 //查询订单，在此调用SearchByID()、SearchByProductName()或者SearchByClientName()
        {
            switch (flag)
            {
                case 1:
                    Console.WriteLine("请输入订单号：");
                    String ID = Console.ReadLine();
                    SearchByID(ID);
                    break;
                case 2:
                    Console.WriteLine("请输入商品名：");
                    String productName = Console.ReadLine();
                    SearchByProductName(productName);
                    break;
                case 3:
                    Console.WriteLine("请输入客户名：");
                    String clientName = Console.ReadLine();
                    SearchByClientName(clientName);
                    break;
                case 4:
                    Console.WriteLine("请输入金额：");
                    long money = long.Parse(Console.ReadLine());
                    SearchByMoney(money);
                    break;
            }
        }

        public void SearchByID(String ID)             //通过订单号查询订单
        {
            bool found = false;             //是否查询到订单
            CheckIDInput(ID);                 //检查是否输入合法的订单号
            var results = from order in orders where order.ID == ID select order;
            if (results.Any())
                found = true;
            if (!found)
                throw new OrderException("错误！未找到该订单");
            else
            {
                Console.WriteLine("查询结果：");
                foreach (Order order in results)
                    DisplayOrder(order);
            }
        }

        public void SearchByProductName(String productName)       //通过商品名查询订单
        {
            bool found = false;                 //是否查询到订单
            var results = from order in orders where order.ProductName == productName select order;
            if (results.Any())
                found = true;
            if (!found)
                throw new OrderException("错误！未找到该订单");
            else
            {
                Console.WriteLine("查询结果：");
                foreach (Order order in results)
                    DisplayOrder(order);
            }
        }

        public void SearchByClientName(String clientName)            //通过客户名查询订单
        {
            bool found = false;                     //是否查询到订单
            try
            {
                var results = from order in orders where order.ClientName == clientName select order;
                if (results.Any())
                    found = true;
                if (!found)
                    throw new OrderException("错误！未找到该订单");
                else
                {
                    Console.WriteLine("查询结果：");
                    foreach (Order order in results)
                        DisplayOrder(order);
                }
            }
            catch (OrderException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SearchByMoney(long money)            //通过订单金额查询订单
        {
            bool found = false;                     //是否查询到订单
                var results = from order in orders where order.Money > money select order;
                if (results.Any())
                    found = true;
            if (!found)
                throw new OrderException("错误！未找到该订单");
            else
            {
                Console.WriteLine("查询结果：");
                foreach (Order order in results)
                    DisplayOrder(order);
            }
        }

        public void ReviseOrder()                   //通过订单号修改订单
        {
            bool found = false;                     //是否找到订单
            Console.WriteLine("请输入订单号：");
            String ID = Console.ReadLine();
            try
            {
                CheckIDInput(ID);                   //检查是否输入数字串
                Order temp = null;
                foreach (Order order in orders)
                {
                    if (order.ID == ID)
                    {
                        temp = order;
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    Console.WriteLine("请输入新的订单号：");
                    String newID = Console.ReadLine();
                    CheckIDInput(newID);                    //确保新订单号是数字串
                    IsUnique(newID);                        //确保新订单号没有重复
                    temp.ID = newID;
                    Console.WriteLine("请输入新的商品名：");
                    temp.ProductName = Console.ReadLine();
                    Console.WriteLine("请输入新的客户名：");
                    Console.WriteLine("新的订单：");
                    DisplayOrder(temp);
                    temp.ClientName = Console.ReadLine();
                }
                else
                    throw new OrderException("错误！找不到订单");
            }
            catch (OrderException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ReviseOrderForForm(String oldID, String newID, String newProductName, String newClientName, long newMoney)            //窗体应用程序使用的修改订单方法
        {
            CheckIDInput(oldID);
            CheckIDInput(newID);
            foreach (Order order in orders)
            {
                if (order.ID == oldID)
                {
                    Order temp = order;
                    orders.Remove(order);
                    IsUnique(newID);
                    temp.ID = newID;
                    temp.ProductName = newProductName;
                    temp.ClientName = newClientName;
                    temp.Money = newMoney;
                    orders.Add(temp);
                    return;
                }
            }
            throw new OrderException("错误！找不到该订单");
        }

        public void Export(String fileName)               //将订单列表序列化为XML文件
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            XmlSerialize(xmlser, fileName, orders);
        }

        void XmlSerialize(XmlSerializer ser, string fileName, object obj)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }       //序列化

        public void Import(string fileName)           //从XML文件反序列化为订单列表
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
                orders = (List<Order>)xmlser.Deserialize(fs);
            }
            DisplayOrderList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            int flag = 0;
            String fileName = @"D:\学习资料\大二上\C#\orders.xml";
            while (true)
            {
                Console.WriteLine("请选择需要执行的操作（输入选项前的数字）：");
                Console.WriteLine("1.从xml文件导入订单列表");
                Console.WriteLine("2.添加新订单");
                Console.WriteLine("3.删除订单");
                Console.WriteLine("4.查询订单");
                Console.WriteLine("5.修改订单");
                Console.WriteLine("6.查看订单列表");
                Console.WriteLine("7.将订单导出为xml文件并退出");
                try
                {
                    flag = Int32.Parse(Console.ReadLine());
                    if (flag < 1 || flag > 7)
                        throw new OrderException();
                    else
                    {
                        switch (flag)
                        {
                            case 1:
                                orderService.Import(fileName);
                                break;
                            case 2:
                                try
                                {
                                    Console.WriteLine("请输入订单号：");
                                    String ID = Console.ReadLine();
                                    Console.WriteLine("请输入商品名：");
                                    String productName = Console.ReadLine();
                                    Console.WriteLine("请输入客户名：");
                                    String clientName = Console.ReadLine();
                                    Console.WriteLine("请输入订单金额：");
                                    long money = long.Parse(Console.ReadLine());
                                    Order newOrder = new Order(ID, productName, clientName, money);
                                    orderService.AddOrder(newOrder);
                                    Console.WriteLine("操作后订单列表：");
                                    orderService.DisplayOrderList();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                            case 3:
                                try
                                {
                                    Console.WriteLine("请输入要删除的订单的订单号：");
                                    String ID = Console.ReadLine();
                                    orderService.DeleteOrder(ID);
                                    Console.WriteLine("操作后订单列表：");
                                    orderService.DisplayOrderList();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                            case 4:
                                int flag1 = 0;
                                Console.WriteLine("请选择查询订单的依据（输入选项前的数字）：");
                                Console.WriteLine("1.订单号");
                                Console.WriteLine("2.商品名");
                                Console.WriteLine("3.客户名");
                                Console.WriteLine("4.查询订单金额大于某个值的订单");
                                try
                                {
                                    flag1 = Int32.Parse(Console.ReadLine());         //若输入不是数字则抛出异常
                                    if (flag1 < 1 || flag1 > 4)
                                        throw new OrderException();                 //若输入不在1到3之内则抛出异常
                                    orderService.Search(flag1);
                                    break;
                                }
                                catch(Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                            case 5:
                                orderService.ReviseOrder(); break;
                            case 6:
                                orderService.DisplayOrderList(); break;
                            case 7:
                                orderService.Export(fileName);
                                return;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("错误！输入有误");
                }
            }
        }
    }
}