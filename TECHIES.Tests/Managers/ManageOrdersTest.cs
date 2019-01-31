using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TECHIES.Core.Domain;

namespace TECHIES.UnitTests.Managers
{

    public class ManageOrdersTest
    {
        [Fact]
        public void GetOrderDetailsByCustomerId_and_given_OrderId_should_return_orderlist()
        {

            var OrderDetails = new List<Orders>
            {
                new Orders
                {
                    OrderId = 1,
                    CustomerId=1,
                    Description="Test Desc",
                    OrderItems=new List<OrderItems>
                    {
                        new OrderItems
                        {
                            OrderItemId=1,
                            OrderId=1,
                            ProductId=1,
                            Quantity=1,
                            Products=new Products
                            {
                               ProductName="Test Product"
                            }
                        }
                    }
                }
            };
        }
    }
}
