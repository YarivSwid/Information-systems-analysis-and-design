using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class ProductType
    {
        private int catNumber;
        private string name;
        private int shelfLife;
        private double tempCels;
        private double weight;
        private double price;

        public ProductType(int catNumber, string name, int shelfLife, double tempCels, double weight, double price, Boolean isNew)
        {
            this.catNumber = catNumber;
            this.name = name;
            this.shelfLife = shelfLife;
            this.tempCels = tempCels;
            this.weight = weight;
            this.price = price;
            if (isNew)
            {
                this.createProductType();
                Program.productTypes.Add(this);
            }
        }

        // getters & setters:

        public int getCatNumber()
        {
            return this.catNumber;
        }
        public string getName()
        {
            return this.name;
        }
        public int getShelfLife()
        {
            return this.shelfLife;
        }
        public double getTemp()
        {
            return this.tempCels;
        }
        public double getWeight()
        {
            return this.weight;
        }
        public void setCatNumber(int num)
        {
            this.catNumber = num;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setShelfLife(int shelfLife)
        {
            this.shelfLife = shelfLife;
        }
        public void setTempCels(double temp)
        {
            this.tempCels = temp;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public double getPrice()
        {
            return this.price;
        }

        public void createProductType()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddProductType @categorialNumber, @name, @shelfLifeDays ,@tempCels, @weightKG, @price";
            c.Parameters.AddWithValue("@categorialNumber", this.catNumber);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@shelfLifeDays", this.shelfLife);
            c.Parameters.AddWithValue("@tempCels", this.tempCels);
            c.Parameters.AddWithValue("@weightKG", this.weight);
            c.Parameters.AddWithValue("@price", this.price);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateProductType()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateProductType @categorialNumber, @name, @shelfLifeDays ,@tempCels, @weightKG, @price";
            c.Parameters.AddWithValue("@categorialNumber", this.catNumber);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@shelfLifeDays", this.shelfLife);
            c.Parameters.AddWithValue("@tempCels", this.tempCels);
            c.Parameters.AddWithValue("@weightKG", this.weight);
            c.Parameters.AddWithValue("@price", this.price);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updatePrice()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateProductTypePrice @categorialNumber, @price";
            c.Parameters.AddWithValue("@categorialNumber", this.catNumber);
            c.Parameters.AddWithValue("@price", this.price);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}