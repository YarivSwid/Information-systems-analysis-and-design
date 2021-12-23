using System;
using System.Collections.Generic;
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

        public ProductType(int catNumber, string name, int shelfLife, double tempCels, double weight, Boolean isNew)
        {
            this.catNumber = catNumber;
            this.name = name;
            this.shelfLife = shelfLife;
            this.tempCels = tempCels;
            this.weight = weight;
            if (isNew)
            {
                this.createProductType();
                Program.ProductTypes.Add(this);
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


        public void createProductType() // CREATE THIS
        {

        }
    }
}
