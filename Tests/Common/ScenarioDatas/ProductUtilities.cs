using productMicroservice.Data;
using productMicroservice.Model;

namespace productMicroservice.Tests.Common.ScenarioDatas
{
    public static class ProductUtilities
    {
        public static void CreateProduct(this DbContextClass dbContextClass)
        {
            var product = new Product
            {
                ProductId = 1,
                ProductName = "Codenames",
                ProductDescription = "Codenames est un jeu d’association d’idées dans lequel, répartis en deux équipes, vous incarnez soit un maître-espion, soit un agent en mission.",
                ProductPrice = 25,
                ProductStock = 43
            };

            dbContextClass.Products.Add(product);
            dbContextClass.SaveChanges();
        }

        public static void CreateProducts(this DbContextClass dbContextClass)
        {
            var product1 = new Product
            {
                ProductId = 1,
                ProductName = "Les loups-garous de Thiercelieux",
                ProductDescription = "Comment, vous ne connaissez pas Thiercelieux ? Un si joli petit village de l'est, bien à l'abri des vents et du froid, niché entre de charmantes forêts et de bons pâturages.",
                ProductPrice = 11,
                ProductStock = 50
            };

            var product2 = new Product
            {
                ProductId = 2,
                ProductName = " L’Archipel des Dinosaures",
                ProductDescription = "Reconstituez les îles afin de sauver les dinosaures verts!\r\n\r\nConcentrez-vous pour recréer le monde du jurassique!",
                ProductPrice = 26,
                ProductStock = 36
            };

            dbContextClass.Products.AddRange(product1, product2);
            dbContextClass.SaveChanges();
        }
    }
}
