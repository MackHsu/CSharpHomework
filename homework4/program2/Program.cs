using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Order: OrderDetails
    {
        public String ID { get; set; }              //订单号
    }

    class OrderDetails
    {
        public String ProductName { get; set; }     //商品名
        public String ClientName { get; set; }      //客户名
    }

    class OrderService
    {
        List<Order> orders = new List<Order>();
        
        public void DisplayOrder(Order order)       //打印一个订单
        {
            Console.WriteLine($"订单号：{order.ID}");
            Console.WriteLine($"商品名：{order.ProductName}");
            Console.WriteLine($"客户名：{order.ClientName}\n");
        }

        public void DisplayOrderList()             //打印整个订单列表
        {
            foreach (Order order in orders)
                DisplayOrder(order);
        }

        public bool IsUnique(String newID)            //检查订单号是否重复
        {
            foreach(Order order in orders)
            {
                if(order.ID==newID)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddOrder()                  //添加新订单
        {
            Order newOrder = new Order();
            Console.WriteLine("请输入订单号：");
            String newID = Console.ReadLine();
            if (IsUnique(newID))                   //确保订单号唯一，如果没有重复则继续输入，如果重复则结束输入且不添加新订单
            {
                newOrder.ID = newID;
                Console.WriteLine("请输入商品名：");
                newOrder.ProductName = Console.ReadLine();
                Console.WriteLine("请输入客户名：");
                newOrder.ClientName = Console.ReadLine();
                orders.Add(newOrder);
                Console.WriteLine("操作后订单列表：");
                DisplayOrderList();
            }
            else
            {
                Console.WriteLine("错误！该订单号已存在！");
            }
        }

        public void DeleteOrder()          //通过订单号删除订单，删除前可以用查询功能查询订单号
        {
            bool deleted = false;          //是否已经删除
            Console.WriteLine("请输入要删除的订单的订单号：");
            String ID = Console.ReadLine();
            foreach(Order order in orders)
            {
                if(order.ID==ID)
                {
                    orders.Remove(order);
                    deleted = true;
                    break;
                }
            }
            if (!deleted)
                Console.WriteLine("错误！找不到订单！");
            else
            {
                Console.WriteLine("操作后订单列表：");
                DisplayOrderList();
            }
        }

        public void Search()                 //查询订单，在此调用SearchByID()、SearchByProductName()或者SearchByClientName()
        {
            int flag = 0;
            Console.WriteLine("请选择查询订单的依据（输入选项前的数字）：");
            Console.WriteLine("1.订单号");
            Console.WriteLine("2.商品名");
            Console.WriteLine("3.客户名");
            try
            {
                flag = Int32.Parse(Console.ReadLine());
                if (flag < 0 || flag > 3)
                    Console.WriteLine("错误！输入有误！");
                else
                {
                    switch(flag)
                    {
                        case 1:
                            SearchByID();           break;
                        case 2:
                            SearchByProductName();  break;
                        case 3:
                            SearchByClientName();   break;
                    }
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("错误！输入有误！");
            }
        }

        public void SearchByID()             //通过订单号查询订单
        {
            bool found = false;             //是否查询到订单
            Console.WriteLine("请输入订单号：");
            String ID = Console.ReadLine();
            Console.WriteLine("查询结果：");
            foreach(Order order in orders)
            {
                if(order.ID==ID)
                {
                    DisplayOrder(order);
                    found = true;
                    break;                  //由于订单号唯一，查询到即可退出循环
                }
            }
            if (!found)
                Console.WriteLine("错误！找不到订单！");
        }

        public void SearchByProductName()       //通过商品名查询订单
        {
            bool found = false;                 //是否查询到订单
            Console.WriteLine("请输入商品名：");
            String productName = Console.ReadLine();
            Console.WriteLine("查询结果：");
            foreach(Order order in orders)
            {
                if(order.ProductName==productName)
                {
                    DisplayOrder(order);
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("错误！找不到订单！");
        }

        public void SearchByClientName()            //通过客户名查询订单
        {
            bool found = false;                     //是否查询到订单
            Console.WriteLine("请输入客户名：");
            String clientName = Console.ReadLine();
            Console.WriteLine("查询结果：");
            foreach(Order order in orders)
            {
                if(order.ClientName==clientName)
                {
                    DisplayOrder(order);
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("错误！找不到订单！");
        }

        public void ReviseOrder()                   //通过订单号修改订单
        {
            bool found = false;                     //是否找到订单
            Console.WriteLine("请输入订单号：");
            String ID = Console.ReadLine();
            Order temp = null;
            foreach(Order order in orders)
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
                temp.ID = Console.ReadLine();
                Console.WriteLine("请输入新的商品名：");
                temp.ProductName = Console.ReadLine();
                Console.WriteLine("请输入新的客户名：");
                temp.ClientName = Console.ReadLine();
                Console.WriteLine("新的订单：");
                DisplayOrder(temp);
            }
            else
                Console.WriteLine("错误！订单列表中没有此订单号！");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            int flag = 0;
            while(true)
            {
                Console.WriteLine("请选择需要执行的操作（输入选项前的数字）：");
                Console.WriteLine("1.添加新订单");
                Console.WriteLine("2.删除订单");
                Console.WriteLine("3.查询订单");
                Console.WriteLine("4.修改订单");
                Console.WriteLine("5.查看订单列表");
                Console.WriteLine("6.退出");
                try
                {
                    flag = Int32.Parse(Console.ReadLine());
                    if (flag < 1 || flag > 6)
                        Console.WriteLine("错误！请输入正确的数字");
                    else
                    {
                        switch (flag)
                        {
                            case 1:
                                orderService.AddOrder();            break;
                            case 2:
                                orderService.DeleteOrder();         break;
                            case 3:
                                orderService.Search();              break;
                            case 4:
                                orderService.ReviseOrder();         break;
                            case 5:
                                orderService.DisplayOrderList();    break;
                            case 6:
                                return;
                        }
                    }
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("错误！请输入正确的数字");
                }
            }
        }
    }
}
