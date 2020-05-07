using CrmApp.Options;
using CrmApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Services
{
    public class ProductManagement
    {
        public CrmDbContext db;

        public ProductManagement(CrmDbContext _db)
        {
            db = _db;
        }

        //Create
        public Product CreateProduct(ProductOption productOption)
        {


            Product product = new Product
            {
                Name = productOption.Name,
                Price = productOption.Price,
                Quantity = productOption.Quantity
               
            };

            using CrmDbContext db = new CrmDbContext();
            db.Products.Add(product);
            db.SaveChanges();

            return product;
        }

        //Read
        public Product FindProductById(int productId)
        {
            Product product = db.Products.Find(productId);
            return product;
        }

        //Update
        public Product Update(ProductOption productOption, int productId)
        {
            Product product = db.Products.Find(productId);
            if (productOption.Name != null)
                product.Name = productOption.Name;
            if (productOption.Price != 0)
                product.Price = productOption.Price;
           
            product.Quantity = productOption.Quantity;

            db.SaveChanges();
            return product;
        }

        //Delete
        public void DeleteProductById(int productId)
        {
            Product product = db.Products.Find(productId);
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
