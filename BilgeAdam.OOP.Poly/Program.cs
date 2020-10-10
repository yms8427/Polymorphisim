using BilgeAdam.OOP.Common;
using BilgeAdam.OOP.Common.GenericInterface.Models;
using System;
using BA = BilgeAdam.OOP.Common.BilgeAdam;

namespace BilgeAdam.OOP.Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShapeCalculation();

            //VirtualMethods();


            Console.ReadLine();
        }

        private static void VirtualMethods()
        {
            var m = new Meteksan() { CompanyName = "Meteksan Holding", ExpiresAt = DateTime.Now.AddYears(1) };
            var t = new Tepe() { CompanyName = "Tepe Holding", ExpiresAt = DateTime.Now.AddMonths(6) };
            var b = new BA() { CompanyName = "Bilge Adam Yazılım", ExpiresAt = DateTime.Now.AddYears(2) };

            PrintTotalWithCommission(m, 10000);
            PrintTotalWithCommission(t, 10000);
            PrintTotalWithCommission(b, 10000);
        }

        private static void PrintTotalWithCommission(BusinessPartner partner, decimal amount)
        {
            Console.WriteLine($"{partner.CompanyName} için toplam alacak: {partner.GetTotalAmount(amount)} TL. Uygulanan Komisyon Oranı: %{partner.Commision}");
        }

        private static void ShapeCalculation()
        {
            var k = new Square(5);
            Console.WriteLine("Kare Alan........: " + k.GetArea());
            Console.WriteLine("Kare Çevre.......: " + k.GetPerimeter());
            Console.WriteLine();
            var c = new Circle(5);
            Console.WriteLine("Çember Alan......: " + c.GetArea());
            Console.WriteLine("Çember Çevre.....: " + c.GetPerimeter());
            Console.WriteLine();
            var t = new Triangle(4, 3, 5, 3);
            Console.WriteLine("Üçgen Alan......: " + t.GetArea());
            Console.WriteLine("Üçgen Çevre.....: " + t.GetPerimeter());
        }
    }
}
