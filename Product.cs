using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class Product
    {
        private int serialNumber;
        private int units;
        private ProductStatus status;
        private ProductType productType;
        private int supplierOrderID;
        private int customerOrderID;
        private DateTime expirationDate;
        private SupplierOrder suppliedBy; 
        private CustomerOrder suppliedTo; // take care of it

        public Product(int serialNumber, int units, ProductStatus status, ProductType productType, int sOrderID, int cOrderID, DateTime expirationDate, SupplierOrder suppliedby, CustomerOrder suppliedTo, Boolean isNew)
        {
            this.serialNumber = serialNumber;
            this.units = units;
            this.status = status;
            this.productType = productType;
            this.supplierOrderID = sOrderID;
            this.customerOrderID = cOrderID;
            this.expirationDate = expirationDate;
            if (isNew)
            {
             //   this.createProduct();
                Program.Products.Add(this);
            }
        }

        //public void createProduct() // CREATE THIS
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.AddProductType @catNumber, @name, @shelfLife ,@tempCels, @weight, @price";
        //    c.Parameters.AddWithValue("@catNumber", this.catNumber);
        //    c.Parameters.AddWithValue("@name", this.name);
        //    c.Parameters.AddWithValue("@shelfLife", this.shelfLife);
        //    c.Parameters.AddWithValue("@tempCels", this.tempCels);
        //    c.Parameters.AddWithValue("@weight", this.weight);
        //    c.Parameters.AddWithValue("@price", this.price);

        //    SQL_CON SC = new SQL_CON();
        //    SC.execute_non_query(c);
        //}
    }
}