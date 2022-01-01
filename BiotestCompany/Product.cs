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
        private DateTime expirationDate;
        private int supplierOrderID; // supplierOrderID from DB
        private int customerOrderID; // customerOrderID from DB

        public Product(int serialNumber, int units, ProductStatus status, ProductType productType, int supplierOrderID, int customerOrderID, DateTime expirationDate, Boolean isNew)
        {
            this.serialNumber = serialNumber;
            this.units = units;
            this.status = status;
            this.productType = productType;
            this.supplierOrderID = supplierOrderID;
            this.customerOrderID = customerOrderID;
            this.expirationDate = expirationDate;


            if (isNew)
            {
                this.createProduct();
                Program.Products.Add(this);
            }
        }

        public void createProduct()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddProduct @serialNumber, @unitsNumber, @status ,@productType, @supplierOrderID, @customerOrderID, @expiration_date";
            c.Parameters.AddWithValue("@serialNumber", this.serialNumber);
            c.Parameters.AddWithValue("@units", this.units);
            c.Parameters.AddWithValue("@status", this.status);
            c.Parameters.AddWithValue("@productType", this.productType.getCatNumber());
            c.Parameters.AddWithValue("@supplierOrderID", this.supplierOrderID);
            c.Parameters.AddWithValue("@customerOrderID", this.customerOrderID);
            c.Parameters.AddWithValue("@expiration_date", this.expirationDate);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateProduct()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateProduct @serialNumber, @unitsNumber, @status ,@productType, @supplierOrderID, @customerOrderID, @expiration_date";
            c.Parameters.AddWithValue("@serialNumber", this.serialNumber);
            c.Parameters.AddWithValue("@units", this.units);
            c.Parameters.AddWithValue("@status", this.status);
            c.Parameters.AddWithValue("@productType", this.productType.getCatNumber());
            c.Parameters.AddWithValue("@supplierOrderID", this.supplierOrderID);
            c.Parameters.AddWithValue("@customerOrderID", this.customerOrderID);
            c.Parameters.AddWithValue("@expiration_date", this.expirationDate);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // getters & setters:

        public int getSerialNumer()
        {
            return this.serialNumber;
        }
    }
}