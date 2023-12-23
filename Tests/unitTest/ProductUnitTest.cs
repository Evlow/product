using NUnit.Framework;
using productMicroservice.Data;
using productMicroservice.Model;
using productMicroservice.Tests.Common.ScenarioDatas;

namespace productMicroservice.Tests.unitTest
{
    public class ProductUnitTest : Common.TestBase
    {
        private DbContextClass _dbContextClass;

        [SetUp]
        public void Setup()
        {
            SetupTest();

            DbContextClass? dbContextClass = _serviceProvider.GetService<DbContextClass>();
            _dbContextClass = dbContextClass!;

            _dbContextClass.CreateProduct();
        }

        [TearDown]
        public void Teardown()
        {
            CleanTest();
        }

        [Test]
        public async Task CreateProduct()
        {
            // Arrange
            var product = new Product()
            {
                ProductId = 2,
                ProductName = "Maudit Mot Dit",
                ProductDescription = "A vous de tourner autour du mot dans ce jeu d’association d’idées malicieux !",
                ProductPrice = 500,
                ProductStock = 200
            };

            // Act
            var productToAdd = await _dbContextClass.Products.AddAsync(product).ConfigureAwait(false);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(productToAdd, Is.Not.Null);
                Assert.That(product.ProductName, Is.EqualTo("Maudit Mot Dit"));
            });
        }

        [Test]
        public async Task GetProduct()
        {
            // Arrange
            var product = new Product()
            {
                ProductId = 2,
                ProductName = "Maudit Mot Dit",
                ProductDescription = "A vous de tourner autour du mot dans ce jeu d’association d’idées malicieux !",
                ProductPrice = 500,
                ProductStock = 200
            };

            // Act
            var productToAdd = await _dbContextClass.Products.AddAsync(product).ConfigureAwait(false);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(productToAdd, Is.Not.Null);
                Assert.That(product.ProductName, Is.EqualTo("Maudit Mot Dit"));
            });
        }
    }
}
