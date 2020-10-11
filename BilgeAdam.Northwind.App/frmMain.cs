using BilgeAdam.OOP.Common.GenericInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Faker;
using BilgeAdam.OOP.Common.GenericInterface.Managers;
using BilgeAdam.OOP.Common.GenericInterface.Mappers;
using BilgeAdam.Northwind.App.Dtos;
using BilgeAdam.OOP.Common.GenericInterface;

namespace BilgeAdam.Northwind.App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public List<Supplier> Suppliers { get; set; }
        public List<Category> Categories { get; set; }
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
            var mc = MapperFactory.GetMapper<Category>();
            Categories = mc.ReadAll();
            lstCategories.DataSource = Categories;

            var ms = MapperFactory.GetMapper<Supplier>();
            Suppliers = ms.ReadAll();
            lstSuppliers.DataSource = Suppliers;

            var mp = MapperFactory.GetMapper<Product>();
            var products = mp.ReadAll();
            var mappedProducts = MapProducts(products);
            dgvProducts.DataSource = mappedProducts.ToList();

            lstCategories.DisplayMember = nameof(Category.Name);
            lstCategories.ValueMember = nameof(Category.Id);
            lstSuppliers.DisplayMember = nameof(Supplier.Info);
            lstSuppliers.ValueMember = nameof(Supplier.Id);
        }

        private IEnumerable<ProductDto> MapProducts(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                yield return new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Stock = product.Stock,
                    Category = GetCategoryName(product.CategoryId),
                    Company = GetCompanyName(product.SupplierId)
                };
            }
        }

        private string GetCategoryName(int id)
        {
            //return Categories.First(i => i.Id == id).Name;
            foreach (var cat in Categories)
            {
                if (cat.Id == id)
                {
                    return cat.Name;
                }
            }
            return string.Empty;
        }

        private string GetCompanyName(int id)
        {
            foreach (var sup in Suppliers)
            {
                if (sup.Id == id)
                {
                    return sup.Name;
                }
            }
            return string.Empty;
        }
    }
}
