using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Store.Domain.Repositories;
using Store.ObjectMothers;

namespace Store.Application.UnitTests
{
    [TestClass]
    public class ReportServiceTests
    {
        [TestMethod]
        public void CheckGetAllMethodCalled()
        {
            // Arrange
            Mock<IReportRepository> repositoryMock = new Mock<IReportRepository>();
            IReportService service = new ReportService(repositoryMock.Object);

            // Act
            service.GetAll();

            // Assert
            repositoryMock.Verify(k => k.GetAll(), Times.Once());
        }

        [TestMethod]
        public void CheckGetByIdMethodCalled()
        {
            // Arrange
            Mock<IReportRepository> repositoryMock = new Mock<IReportRepository>();
            IReportService service = new ReportService(repositoryMock.Object);
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
            Mock<IReportRepository> repositoryMock = new Mock<IReportRepository>();
            IReportService service = new ReportService(repositoryMock.Object);
            var report = ReportObjectMother.CreateReport();

            // Act
            service.Insert(report);

            // Assert
            repositoryMock.Verify(k => k.Insert(report), Times.Once());
        }

        [TestMethod]
        public void CheckDeleteMethodCalled()
        {
            // Arrange
            Mock<IReportRepository> repositoryMock = new Mock<IReportRepository>();
            IReportService service = new ReportService(repositoryMock.Object);
            var id = new Guid();

            // Act
            service.Delete(id);

            // Assert
            repositoryMock.Verify(k => k.Delete(id), Times.Once());
        }
    }
}
