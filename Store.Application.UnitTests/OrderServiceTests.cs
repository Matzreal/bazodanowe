using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Store.Domain.Repositories;
using Store.ObjectMothers;
using Store.Domain.Model.Order;

namespace Store.Application.UnitTests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void CheckGetAllMethodCalled()
        {
            // Arrange
            Mock<IOrderRepository> repositoryMock = new Mock<IOrderRepository>();
            IOrderService service = new OrderService(repositoryMock.Object);

            // Act
            service.GetAll();

            // Assert
            repositoryMock.Verify(k => k.GetAll(), Times.Once());
        }

        [TestMethod]
        public void CheckGetByIdMethodCalled()
        {
            // Arrange
            Mock<IOrderRepository> repositoryMock = new Mock<IOrderRepository>();
            IOrderService service = new OrderService(repositoryMock.Object);
            var id = new Guid();

            // Act
            service.GetById(id);

            // Assert
            repositoryMock.Verify(k => k.GetById(id), Times.Once());
        }

        [TestMethod]
        public void CheckInsertMethodCalled()
        {
            // Arrange
            Mock<IOrderRepository> repositoryMock = new Mock<IOrderRepository>();
            IOrderService service = new OrderService(repositoryMock.Object);
            var order = OrderObjectMother.CreateOrder();

            // Act
            service.Insert(order);

            // Assert
            repositoryMock.Verify(k => k.Insert(order), Times.Once());
        }

        [TestMethod]
        public void CheckDeleteMethodCalled()
        {
            // Arrange
            Mock<IOrderRepository> repositoryMock = new Mock<IOrderRepository>();
            IOrderService service = new OrderService(repositoryMock.Object);
            var id = new Guid();

            // Act
            service.Delete(id);

            // Assert
            repositoryMock.Verify(k => k.Delete(id), Times.Once());
        }

        [TestMethod]
        public void CheckGetByStatusMethodCalled()
        {
            // Arrange
            Mock<IOrderRepository> repositoryMock = new Mock<IOrderRepository>();
            IOrderService service = new OrderService(repositoryMock.Object);
            var status = new StatusType();

            // Act
            service.GetByStatus(status);

            // Assert
            repositoryMock.Verify(k => k.GetByStatus(status), Times.Once());
        }
    }
}
