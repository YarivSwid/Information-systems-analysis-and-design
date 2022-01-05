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
        private Dictionary<ProductType, int> products;

        public SupplierOrder(int orderID, DateTime orderDate, DateTime arrivalDate, double shippingCost, double orderValue, double pScore, double qScore, Supplier supplier, Dictionary<ProductType, int> products, Boolean isNew)
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
                this.createSupplierDetails();
                Program.supplierOrders.Add(this);
            }
        }
        public void setProducts(Dictionary<ProductType, int> products)
        {
            this.products = products;
            updateSupplierOrder();
        }
        public void createSupplierOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddSupplierOrder @supplierOrderID, @orderDate, @arrivalDate ,@shippingCost, @orderValue, @punctualityScore, @qualityScore, @supplierID";
            c.Parameters.AddWithValue("@supplierOrderID", this.orderID);
            c.Parameters.AddWithValue("@orderDate", this.orderDate);
            c.Parameters.AddWithValue("@arrivalDate", this.arrivalDate);
            c.Parameters.AddWithValue("@shippingCost", this.shippingCost);
            c.Parameters.AddWithValue("@orderValue", this.orderValue);
            c.Parameters.AddWithValue("@punctualityScore", this.punctualityScore);
            c.Parameters.AddWithValue("@qualityScore", this.qualityScore);
            c.Parameters.AddWithValue("@supplierID", int.Parse(this.supplier.getSupplierID().ToString()));

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void createSupplierDetails()
        {
            int i = 0;
            int count = this.products.Count();
            while (count > i)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "dbo.AddProductListSupplierOrder  @supplierOrderID, @categorialNumber, @amount"; // CREATE SP
                c.Parameters.AddWithValue("@bidID", this.orderID);
                c.Parameters.AddWithValue("@categorialNumber", this.products.ElementAt(i).Key.getCatNumber());
                c.Parameters.AddWithValue("@amount", this.products.ElementAt(i).Value);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
                i = i + 1;
            }
        }
        public void updateSupplierOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateSupplierOrder @supplierOrderID, @orderDate, @arrivalDate ,@shippingCost, @orderValue, @punctualityScore, @qualityScore, @supplierID";
            c.Parameters.AddWithValue("@supplierOrderID", this.orderID);
            c.Parameters.AddWithValue("@orderDate", this.orderDate);
            c.Parameters.AddWithValue("@arrivalDate", this.arrivalDate);
            c.Parameters.AddWithValue("@shippingCost", this.shippingCost);
            c.Parameters.AddWithValue("@orderValue", this.orderValue);
            c.Parameters.AddWithValue("@punctualityScore", this.punctualityScore);
            c.Parameters.AddWithValue("@qualityScore", this.qualityScore);
            c.Parameters.AddWithValue("@supplierID", int.Parse(this.supplier.getSupplierID().ToString()));

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

            this.supplier.updateSupplierRanks();
        }
        public Dictionary<ProductType, int> getProducts()
        {
            return this.products;
        }
        public int getOrderID()
        {
            return this.orderID;
        }
        public double getPunctualityScore()
        {
            return this.punctualityScore;
        }
        public double getQualityScore()
        {
            return this.qualityScore;
        }

        public void setPunctualityScore(double score)
        {
            this.punctualityScore = score;
        }

        public void setQualityScore(double score)
        {
            this.qualityScore = score;
        }
        public void setArrivalDate(DateTime DT)
        {
            this.arrivalDate = DT;
        }
        public void setShippingCost(double shippingCost)
        {
            this.shippingCost = shippingCost;
        }
        public void setOrderValue(double orderValue)
        {
            this.orderValue = orderValue;
        }
        public void setSupplier(int supplierID)
        {
            this.supplier = Program.findMySupplier(supplierID);
        }
    }
}