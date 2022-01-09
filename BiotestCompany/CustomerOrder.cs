using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class CustomerOrder
    {
        private int customerOrderID;
        private CustomerBid bid;
        private List<Product> products;

        public CustomerOrder(int orderID, CustomerBid bid, List<Product> products, Boolean isNew)
        {
            this.customerOrderID = orderID;
            this.bid = bid;
            this.products = products;
            if (isNew)
            {
                this.createCustomerOrder();
                Program.customerOrders.Add(this);
            }
        }

        public void createCustomerOrder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddCustomerOrder @customerOrderID, @basedOnCustBid";
            c.Parameters.AddWithValue("@customerOrderID", this.customerOrderID);
            c.Parameters.AddWithValue("@basedOnCustBid", this.bid.getBidID());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public int getOrderID()
        {
            return this.customerOrderID;
        }
        public List<Product> getProducts()
        {
            return this.products;
        }
        public CustomerBid getCustomerBid()
        {
            return this.bid;
        }
        public void setProducts(List<Product> products)
        {
            this.products = products;
        }
    }
}