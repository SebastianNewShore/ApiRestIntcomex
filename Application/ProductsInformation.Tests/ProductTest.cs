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
    public class ProductTest
    {
        [Test]
        public void AddProductSuccessTest()
        {
            var produt = new Product();

            produt.productName = "Azure Kubernetes Service (AKS)";
            produt.quantityPerunit = 1;
            produt.unitPrice = 100000;
            produt.unitsinStock = 50;
            produt.unitsonOrder = 100;
            produt.recorderLevel = 0;
            produt.active = true;
            produt.idSuppliers = Guid.NewGuid();
            produt.idCategory = Guid.NewGuid();
            produt.Id = Guid.NewGuid();

            Mock<IAddBaseRepository<Product, Guid>> repoAdd = new Mock<IAddBaseRepository<Product, Guid>>();
            Mock<IListBaseRepository<Product, Guid>> repoList = new Mock<IListBaseRepository<Product, Guid>>();
            repoAdd.Setup(x => x.Add(produt)).Returns(produt);
            repoList.Setup(x => x.ListById(Guid.NewGuid())).Returns(produt);
            Products products = new Products(repoList.Object, repoAdd.Object);

            var result = products.Add(produt);
            Assert.AreEqual(produt, result);
        }

        [Test]
        public void AddNullProductTest()
        {
            var produt = new Product();

            produt.productName = "Azure Kubernetes Service (AKS)";
            produt.quantityPerunit = 1;
            produt.unitPrice = 100000;
            produt.unitsinStock = 50;
            produt.unitsonOrder = 100;
            produt.recorderLevel = 0;
            produt.active = true;
            produt.idSuppliers = Guid.NewGuid();
            produt.idCategory = Guid.NewGuid();
            produt.Id = Guid.NewGuid();

            Mock<IAddBaseRepository<Product, Guid>> repoAdd = new Mock<IAddBaseRepository<Product, Guid>>();
            Mock<IListBaseRepository<Product, Guid>> repoList = new Mock<IListBaseRepository<Product, Guid>>();
            repoAdd.Setup(x => x.Add(produt)).Returns(produt);
            repoList.Setup(x => x.ListById(Guid.NewGuid())).Returns(produt);
            Products products = new Products(repoList.Object, repoAdd.Object);

            var result = products.Add(null);
            Assert.AreEqual(new Product().Id, result.Id);
        }

        [Test]
        public void LisProductByIdTest()
        {
            var produt = new Product();
            var id = Guid.NewGuid();

            produt.productName = "Azure Kubernetes Service (AKS)";
            produt.quantityPerunit = 1;
            produt.unitPrice = 100000;
            produt.unitsinStock = 50;
            produt.unitsonOrder = 100;
            produt.recorderLevel = 0;
            produt.active = true;
            produt.idSuppliers = Guid.NewGuid();
            produt.idCategory = Guid.NewGuid();
            produt.Id = id;

            Mock<IAddBaseRepository<Product, Guid>> repoAdd = new Mock<IAddBaseRepository<Product, Guid>>();
            Mock<IListBaseRepository<Product, Guid>> repoList = new Mock<IListBaseRepository<Product, Guid>>();
            repoAdd.Setup(x => x.Add(produt)).Returns(produt);
            repoList.Setup(x => x.ListById(id)).Returns(produt);
            Products products = new Products(repoList.Object, repoAdd.Object);

            var result = products.ListById(id);
            Assert.AreEqual(produt, result);
        }

        [Test]
        public void LisProductByIdNullTest()
        {
            var produt = new Product();
            produt.productName = "Azure Kubernetes Service (AKS)";
            produt.quantityPerunit = 1;
            produt.unitPrice = 100000;
            produt.unitsinStock = 50;
            produt.unitsonOrder = 100;
            produt.recorderLevel = 0;
            produt.active = true;
            produt.idSuppliers = Guid.NewGuid();
            produt.idCategory = Guid.NewGuid();
            produt.Id = Guid.NewGuid();

            Mock<IAddBaseRepository<Product, Guid>> repoAdd = new Mock<IAddBaseRepository<Product, Guid>>();
            Mock<IListBaseRepository<Product, Guid>> repoList = new Mock<IListBaseRepository<Product, Guid>>();
            repoAdd.Setup(x => x.Add(produt)).Returns(produt);
            repoList.Setup(x => x.ListById(Guid.NewGuid())).Returns(produt);
            Products products = new Products(repoList.Object, repoAdd.Object);

            var result = products.ListById(Guid.NewGuid());
            Assert.Null(result);
        }
    }
}
