using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Store.Domain.Repositories;
using Store.ObjectMothers;

namespace Store.Application.UnitTests
{
    [TestClass]
    public class ClientServiceTests
    {
        [TestMethod]
        public void CheckGetAllMethodCalled()
        {
            // Arrange
            Mock<IClientRepository> repositoryMock = new Mock<IClientRepository>();
            IClientService service = new ClientService(repositoryMock.Object);

            // Act
            service.GetAll();

            // Assert
            repositoryMock.Verify(k => k.GetAll(), Times.Once());
        }

        [TestMethod]
        public void CheckGetByIdMethodCalled()
        {
            // Arrange
            Mock<IClientRepository> repositoryMock = new Mock<IClientRepository>();
            IClientService service = new ClientService(repositoryMock.Object);
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
            Mock<IClientRepository> repositoryMock = new Mock<IClientRepository>();
            IClientService service = new ClientService(repositoryMock.Object);
            var client = ClientObjectMother.CreateClient();

            // Act
            service.Insert(client);

            // Assert
            repositoryMock.Verify(k => k.Insert(client), Times.Once());
        }

        [TestMethod]
        public void CheckDeleteMethodCalled()
        {
            // Arrange
            Mock<IClientRepository> repositoryMock = new Mock<IClientRepository>();
            IClientService service = new ClientService(repositoryMock.Object);
            var id = new Guid();

            // Act
            service.Delete(id);

            // Assert
            repositoryMock.Verify(k => k.Delete(id), Times.Once());
        }
    }
}
