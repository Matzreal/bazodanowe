using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Store.Domain.Repositories;
using Store.ObjectMothers;

namespace Store.Application.UnitTests
{
    [TestClass]
    public class ProductServiceTests
    {
        [TestMethod]
        public void CheckGetAllMethodCalled()
        {
            // Arrange
            Mock<IProductRepository> repositoryMock = new Mock<IProductRepository>();
            IProductService service = new ProductService(repositoryMock.Object);

            // Act
            service.GetAll();

            // Assert
            repositoryMock.Verify(k => k.GetAll(), Times.Once());
        }

        [TestMethod]
        public void CheckGetByIdMethodCalled()
        {
            // Arrange
            Mock<IProductRepository> repositoryMock = new Mock<IProductRepository>();
            IProductService service = new ProductService(repositoryMock.Object);
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
            Mock<IProductRepository> repositoryMock = new Mock<IProductRepository>();
            IProductService service = new ProductService(repositoryMock.Object);
            var product = ProductObjectMother.CreateProduct();

            // Act
            service.Insert(product);

            // Assert
            repositoryMock.Verify(k => k.Insert(product), Times.Once());
        }

        [TestMethod]
        public void CheckDeleteMethodCalled()
        {
            // Arrange
            Mock<IProductRepository> repositoryMock = new Mock<IProductRepository>();
            IProductService service = new ProductService(repositoryMock.Object);
            var id = new Guid();

            // Act
            service.Delete(id);

            // Assert
            repositoryMock.Verify(k => k.Delete(id), Times.Once());
        }

        [TestMethod]
        public void CheckGetByCategoryMethodCalled()
        {
            // Arrange
            Mock<IProductRepository> repositoryMock = new Mock<IProductRepository>();
            IProductService service = new ProductService(repositoryMock.Object);
            var category = "";

            // Act
            service.GetByCategory(category);

            // Assert
            repositoryMock.Verify(k => k.GetByCategory(category), Times.Once());
        }
    }
}
