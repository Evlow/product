using NUnit.Framework;
using productMicroservice.Data;
using productMicroservice.Data.Repository;
using productMicroservice.Model;
using productMicroservice.Tests.Common.ScenarioDatas;

namespace productMicroservice.Tests.unitTest
{
    public class ProductUnitTest : Common.TestBase
    {
        private ProductRepository _productRepository;

        [SetUp]
        public void Setup()
        {
            SetupTest();

            _productRepository = _serviceProvider?.GetService<ProductRepository>();

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
                ProductPrice = 20,
                ProductStock = 13
            };

            // Act
            var productToAdd = await _productRepository.CreateProductAsync(product).ConfigureAwait(false);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(productToAdd, Is.Not.Null);
                Assert.That(product.ProductName, Is.EqualTo("Maudit Mot Dit"));
            });
        }

        [Test]
        public async Task GetProducts()
        {
            // Arrange
            var products = await _productRepository.GetProductsAsync().ConfigureAwait(false);

            Assert.That(products, Is.Not.Null);

        }
    }
}
