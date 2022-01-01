using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class SupplierOrder
    {
        private int orderID;
        private DateTime orderDate;
        private DateTime arrivalDate;
        private double shippingCost;
        private double orderValue;
        private double punctualityScore;
        private double qualityScore;
        private Supplier supplier;
        private List<Product> products;

        public SupplierOrder(int orderID, DateTime orderDate, DateTime arrivalDate, double shippingCost, double orderValue, double pScore, double qScore, Supplier supplier, List<Product> products, Boolean isNew)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.arrivalDate = arrivalDate;
            this.shippingCost = shippingCost;
            this.orderValue = orderValue;
            this.punctualityScore = pScore;
            this.qualityScore = qScore;
            this.supplier = supplier;
            this.products = products;
            if (isNew)
            {
                this.createSupplierOrder();
                Program.SupplierOrders.Add(this);
            }
        }
        public void createSupplierOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddSupplierOrder @supplierOrderID, @orderDate, @arrivalDate ,@shippingCost, @orderValue, @punctualityScore, @qualityScore ,@supplier";
            c.Parameters.AddWithValue("@supplierOrderID", this.orderID);
            c.Parameters.AddWithValue("@orderDate", this.orderDate);
            c.Parameters.AddWithValue("@arrivalDate", this.arrivalDate);
            c.Parameters.AddWithValue("@shippingCost", this.shippingCost);
            c.Parameters.AddWithValue("@orderValue", this.orderValue);
            c.Parameters.AddWithValue("@punctualityScore", this.punctualityScore);
            c.Parameters.AddWithValue("@qualityScore", this.qualityScore);
            c.Parameters.AddWithValue("@supplier", this.supplier);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateSupplierOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateSupplierOrder @supplierOrderID, @orderDate, @arrivalDate ,@shippingCost, @orderValue, @punctualityScore, @qualityScore ,@supplier";
            c.Parameters.AddWithValue("@supplierOrderID", this.orderID);
            c.Parameters.AddWithValue("@orderDate", this.orderDate);
            c.Parameters.AddWithValue("@arrivalDate", this.arrivalDate);
            c.Parameters.AddWithValue("@shippingCost", this.shippingCost);
            c.Parameters.AddWithValue("@orderValue", this.orderValue);
            c.Parameters.AddWithValue("@punctualityScore", this.punctualityScore);
            c.Parameters.AddWithValue("@qualityScore", this.qualityScore);
            c.Parameters.AddWithValue("@supplier", this.supplier);
        }

            public int getOrderID()
        {
            return this.orderID;
        }
    }
}