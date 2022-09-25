using Moq;
using NUnit.Framework;
using ProductsInformation.Application.Services;
using ProductsInformation.Domain;
using ProductsInformation.Domain.Interfaces.Repositories;
using ProductsInformation.Infrastructure.Repository;
using System;

namespace ProductsInformation.Tests
{
    [TestFixture]
    public class CreateCategoryTest
    {   
        [Test]
        public void AddCategorySuccessTest()
        {
            var category = new Category();

            category.categoryname = "AWS";
            category.description = "";
            category.picture = "C:/images/Aws";
            category.Id = Guid.NewGuid();
            category.active = true;

            Mock<IAddBaseRepository<Category, Guid>> repo = new Mock<IAddBaseRepository<Category, Guid>>();
            repo.Setup(x => x.Add(category)).Returns(category);
            Categories categories = new Categories(repo.Object);

            var result = categories.Add(category);
            Assert.AreEqual(category, result);
        }

        [Test]
        public void AddNullCategoryTest()
        {
            var category = new Category();

            category.categoryname = "AWS";
            category.description = "";
            category.picture = "C:/images/Aws";
            category.Id = Guid.NewGuid();
            category.active = true;

            Mock<IAddBaseRepository<Category, Guid>> repo = new Mock<IAddBaseRepository<Category, Guid>>();
            repo.Setup(x => x.Add(category)).Returns(category);
            Categories categories = new Categories(repo.Object);

            var result = categories.Add(null);
            Assert.AreEqual(new Category().Id, result.Id);
        }
    }
}