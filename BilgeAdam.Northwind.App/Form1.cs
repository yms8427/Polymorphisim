using BilgeAdam.OOP.Common.GenericInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Faker;
using Newtonsoft.Json;
using BilgeAdam.Northwind.App.Managers;

namespace BilgeAdam.Northwind.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitillize_Click(object sender, EventArgs e)
        {
            #region Ürünler
            var products = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                var name = Lorem.Words(1).ElementAt(0);
                var p = new Product
                {
                    Id = i + 1,
                    Name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower(),
                    CategoryId = RandomNumber.Next(1, 10),
                    SupplierId = RandomNumber.Next(1, 25),
                    Stock = RandomNumber.Next(0, 800),
                    Price = RandomNumber.Next(1, 5600)
                };
                products.Add(p);
            }
            FileManager.SaveProducts(products);
            #endregion
            #region Kategoriler
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Giyim" },
                new Category { Id = 2, Name = "Yiyecek" },
                new Category { Id = 3, Name = "İçecek" },
                new Category { Id = 4, Name = "Elektronik" },
                new Category { Id = 5, Name = "Kırtasiye" },
                new Category { Id = 6, Name = "Züccaciye" },
                new Category { Id = 7, Name = "Mobilya" },
                new Category { Id = 8, Name = "Ayakkabı" },
                new Category { Id = 9, Name = "Takı" },
                new Category { Id = 10, Name = "Beyaz Eşya" }
            };
            FileManager.SaveCategories(categories);
            #endregion
            #region Sağlayıcılar
            var suppliers = new List<Supplier>();
            for (int i = 0; i < 25; i++)
            {
                var s = new Supplier
                {
                    Id = i + 1,
                    Name = Company.Name(),
                    Phone = Phone.Number()
                };
                suppliers.Add(s);
            }
            FileManager.SaveSuppliers(suppliers);
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
