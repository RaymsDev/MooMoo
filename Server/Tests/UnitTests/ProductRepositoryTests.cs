using System;
using MooMoo.ApplicationCore.Entities;
using MooMoo.Infrastructure.Data;
using Xunit;

namespace UnitTests
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void AddProduct()
        {
            var repository = new ProductRepository();
            var product = new ProductEntity(){
                Name="Jambon",
                Quantity = 5,
                DeliverDate= new DateTime(),
                RegisterDate = new DateTime()                
            };
            repository.Add(product);
            Assert.True(product.Id != null);
        }
    }
}
