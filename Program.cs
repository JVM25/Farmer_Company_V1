using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Farm_Company_V1.Farm_Company
{
    class Program
    {
        public static void Main(String[] args)
        {
            Company company = new Company();

            Product strawberry = new Product();
            strawberry.Name = "Strawberry";
            strawberry.UnitPrice = 100;
            strawberry.UnitPerKilometer = 50;
            strawberry.CropExtensionKms = 20;
            strawberry.TaxPerUnitPercentage = 34;
            company.AddProduct(strawberry);
            
            Product potatoes = new Product();
            potatoes.Name = "Potatoes";
            potatoes.UnitPrice = 200;
            potatoes.UnitPerKilometer = 250;
            potatoes.CropExtensionKms = 45;
            potatoes.TaxPerUnitPercentage = 40;
            company.AddProduct(potatoes);

            Product tomatoes = new Product();
            tomatoes.Name = "Tomatoes";
            tomatoes.UnitPrice = 50;
            tomatoes.UnitPerKilometer = 45;
            tomatoes.CropExtensionKms = 30;
            tomatoes.TaxPerUnitPercentage = 30;
            company.AddProduct(tomatoes);

            Product apple = new Product();
            apple.Name = "Apple";
            apple.UnitPrice = 75;
            apple.UnitPerKilometer = 95;
            apple.CropExtensionKms = 40;
            apple.TaxPerUnitPercentage = 50;
            company.AddProduct(apple);

            Product banana = new Product();
            banana.Name = "Banana";
            banana.UnitPrice = 5;
            banana.UnitPerKilometer = 200;
            banana.CropExtensionKms = 60;
            banana.TaxPerUnitPercentage = 10;
            company.AddProduct(banana);

            Product pineapple = new Product();
            pineapple.Name = "Pineapple";
            pineapple.UnitPrice = 80;
            pineapple.UnitPerKilometer = 90;
            pineapple.CropExtensionKms = 20;
            pineapple.TaxPerUnitPercentage = 28;
            company.AddProduct(pineapple);

            Product onion = new Product();
            onion.Name = "Onion";
            onion.UnitPrice = 52;
            onion.UnitPerKilometer = 50;
            onion.CropExtensionKms = 29;
            onion.TaxPerUnitPercentage = 30;
            company.AddProduct(onion);


            Farmer f1 = new Farmer();
            f1.Name = "Mario";
            f1.Stratum = 2;
            f1.Gender = 0;
            company.AddFarmer(f1);

            Farmer f2 = new Farmer();
            f2.Name = "Carla";
            f2.Stratum = 1;
            f2.Gender = 1;
            company.AddFarmer(f2);

            Farmer f3 = new Farmer();
            f3.Name = "Marisol";
            f3.Stratum = 3;
            f3.Gender = 1;
            company.AddFarmer(f3);

            Farmer f4 = new Farmer();
            f4.Name = "Jeison";
            f4.Stratum = 1;
            f4.Gender = 0;
            company.AddFarmer(f4);

            Farmer f5 = new Farmer();
            f5.Name = "Leonardo";
            f5.Stratum = 4;
            f5.Gender = 0;
            company.AddFarmer(f5);

            Farmer f6 = new Farmer();
            f6.Name = "Nohelia";
            f6.Stratum = 2;
            f6.Gender = 1;
            company.AddFarmer(f6);


            Crop c1 = new Crop();
            c1.Product = strawberry;
            c1.Farmer = f1;
            company.AddCrop(c1);

            Crop c2 = new Crop();
            c2.Product = strawberry;
            c2.Farmer = f3;
            company.AddCrop(c2);

            Crop c3 = new Crop();
            c3.Product = tomatoes;
            c3.Farmer = f1;
            company.AddCrop(c3);

            Crop c4 = new Crop();
            c4.Product = tomatoes;
            c4.Farmer = f3;
            company.AddCrop(c4);

            Crop c5 = new Crop();
            c5.Product = tomatoes;
            c5.Farmer = f4;
            company.AddCrop(c5);

            Crop c6 = new Crop();
            c6.Product = potatoes;
            c6.Farmer = f2;
            company.AddCrop(c6);

            Crop c7 = new Crop();
            c7.Product = potatoes;
            c7.Farmer = f6;
            company.AddCrop(c7);

            Crop c8 = new Crop();
            c8.Product = apple;
            c8.Farmer = f4;
            company.AddCrop(c8);

            Crop c9 = new Crop();
            c9.Product = banana;
            c9.Farmer = f5;
            company.AddCrop(c9);

            Crop c10 = new Crop();
            c10.Product = banana;
            c10.Farmer = f6;
            company.AddCrop(c10);

            Crop c11 = new Crop();
            c11.Product = pineapple;
            c11.Farmer = f5;
            company.AddCrop(c11);

            Crop c12 = new Crop();
            c12.Product = pineapple;
            c12.Farmer = f6;
            company.AddCrop(c12);

            Crop c13 = new Crop();
            c13.Product = onion;
            c13.Farmer = f6;
            company.AddCrop(c13);


            Console.WriteLine("Enter the product name:");
            string product = Console.ReadLine();
            float farmersByCrop = company.countFarmersByCrop(product);
            float Farmers = company.getTotalAmountFarmers();

            Console.WriteLine("Total to pay:" + Farmers);



        }
    }
}
