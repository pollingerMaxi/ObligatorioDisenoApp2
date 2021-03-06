﻿using Moq;
using Stockapp.Data;
using Stockapp.Data.Repository;
using Stockapp.Logic.API;
using Stockapp.Logic.Implementation;
using Xunit;

namespace Stockapp.Test.LogicTest
{
    public class StockNewsLogicTest
    {
        [Fact]
        public void RegisterStockNewsTest()
        {
            //Arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork.Setup(un => un.StockNewsRepository.Insert(It.IsAny<StockNews>()));
            mockUnitOfWork.Setup(un => un.Save());

            IStockNewsLogic newsLogic = new StockNewsLogic(mockUnitOfWork.Object);

            //Act
            var result = newsLogic.RegisterStockNews(new StockNews());

            Assert.True(result);
            mockUnitOfWork.VerifyAll();
        }

        [Fact]
        public void DeleteStockNewsTest()
        {
            //Arrange
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork.Setup(un => un.StockNewsRepository.Delete(It.IsAny<StockNews>()));
            mockUnitOfWork.Setup(un => un.Save());

            IStockNewsLogic newsLogic = new StockNewsLogic(mockUnitOfWork.Object);

            //Act
            var result = newsLogic.DeleteStockNews(new StockNews());

            Assert.True(result);
            mockUnitOfWork.VerifyAll();
        }
    }
}
