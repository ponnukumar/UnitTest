using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TECHIES.Core.Domain;
using TECHIES.Repositories;
using Moq;
using TECHIES.Core.Interfaces;
using TECHIES.Core.Interfaces.Infrastructure;
using TECHIES.Managers;
using TECHIES.Core.Interfaces.Repositories;
using TECHIES.Core.ViewModels;

namespace TECHIES.UnitTests.Managers
{

    public class ManageOrdersTest
    {
        private readonly IManageOrders _manageOrders;
        private readonly Mock<IOrderRepository> _mockOrderRepository;

        #region Ctor
        public ManageOrdersTest()
        {
            var _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockOrderRepository = new Mock<IOrderRepository>(MockBehavior.Loose);
            _mockUnitOfWork.Setup(x => x.OrderRepository).Returns(_mockOrderRepository.Object);
            _manageOrders = new ManageOrders(_mockUnitOfWork.Object);
        }
        #endregion

        /// <summary>
        /// Gets the order details by customer identifier and given order identifier should return orderlist.
        /// </summary>
        [Fact]
        public async void GetOrderDetailsByCustomerId_and_given_OrderId_should_return_orderlist()
        {
            Guid customerId = new Guid("e37e2fd6-f5cd-45ce-8243-062731680c2b");
            int orderId = 1;
            //Arrange
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
                            Products=new Core.Domain.Products
                            {
                               ProductName="Test Product"
                            }
                        }
                    }
                },
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
                            Products=new Core.Domain.Products
                            {
                               ProductName="Test Product"
                            }
                        }
                    }
                }
            };
            _mockOrderRepository
                .Setup(m => m.GetOrderDetailsByCustomerIdAsync(customerId, orderId))
                .ReturnsAsync(OrderDetails);

            //Act
            var actualOrders = await _manageOrders.GetOrdersByCustomerIdAsync(customerId, orderId);

            //Assert
            Assert.NotNull(actualOrders);
            Assert.IsAssignableFrom<IList<CustomerOrders>>(actualOrders);
            //Assert.IsAssignableFrom<IEnumerable<Core.ViewModels.CustomerOrderItems>>(actualOrders.First().);
        }
    }
}
