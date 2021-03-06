using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Farm_Company_V1.Farm_Company
{
    class Company
    {
        Farmer[] Farmers = new Farmer[50];
        int farmerCount = 0;

        Product[] Products = new Product[50];
        int productCount = 0;

        Crop[] Crops = new Crop[50];
        int cropCount = 0;


        public void AddFarmer(Farmer farmer)
        {
            Farmers[farmerCount] = farmer;
            farmerCount++;
        }

        public void AddProduct(Product product)
        {
            Products[productCount] = product;
            productCount++;
        }

        public void AddCrop(Crop crop)
        {
            Crops[cropCount] = crop;
            cropCount++;
        }


        public float getSumUnitPrice()
        {
            float SumUnitPrice = 0;

            for (int i = 0; i < cropCount; i++)
            {

                SumUnitPrice = SumUnitPrice + Crops[i].Product.UnitPrice;


            }

            return SumUnitPrice;
        }


        public float getRealUnitPrice0()
        {
            float RealUnitPrice0 = 0;

            for (int i = 0; i < cropCount; i++)
            {
                if (Crops[i].Farmer.Gender == 0)
                {
                    RealUnitPrice0 = RealUnitPrice0 + Crops[i].Product.UnitPrice - (Crops[i].Product.UnitPrice * Crops[i].Product.TaxPerUnitPercentage) / 100;
                }
            }
            return RealUnitPrice0;
        }

        public float getRealUnitPrice1()
        {
            float RealUnitPrice1 = 0;

            for (int i = 0; i < cropCount; i++)
            {
                if (Crops[i].Farmer.Gender == 1)
                {
                    RealUnitPrice1 = RealUnitPrice1 + Crops[i].Product.UnitPrice - (Crops[i].Product.UnitPrice * (Crops[i].Product.TaxPerUnitPercentage * 50 / 100)) / 100;
                }
            }
            return RealUnitPrice1;
        }


        public float getTotalAmountFarmers()
        {
            float total = 0;

            for (int i = 0; i < cropCount; i++)
            {
                total = total + Crops[i].Product.UnitPerKilometer * Crops[i].Product.CropExtensionKms;
             
            }
            return total;
        }
        
        public float countFarmersByCrop(string productName)
        {
            float farmersByCropCount = 0;

            for (int i = 0; i < cropCount; i++)
            {
                if (Crops[i].Product.Name == productName)
                {
                    farmersByCropCount = farmersByCropCount + +Crops[i].Product.UnitPrice - (Crops[i].Product.UnitPrice * Crops[i].Product.TaxPerUnitPercentage) / 100;
                }
            }

            return farmersByCropCount;
        }
    }
}
