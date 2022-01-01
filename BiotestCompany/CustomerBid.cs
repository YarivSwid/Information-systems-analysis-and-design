using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class CustomerBid
    {
        private int bidID;
        private double discount;
        private PaymentTerm term;
        private User user; // made by in DB
        private ProductType productType;
        private Contact contact;
        private Customer customer;

        public CustomerBid(int bidID, double discount, PaymentTerm term, User user, ProductType productType, Contact contact, Customer customer, Boolean isNew)
        {
            this.bidID = bidID;
            this.discount = discount;
            this.term = term;
            this.user = user;
            this.productType = productType;
            this.contact = contact;
            this.customer = customer;
            if (isNew)
            {
                this.createCustomerBid();
                Program.CustomerBids.Add(this);
            }
        }

        public void createCustomerBid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.AddCustomerBid	@bidID int, @discount float, @paymentTerm varchar(50), @madeBy int, @contact varchar(50), @productType int, @customer int"; // CREATE SP
            c.Parameters.AddWithValue("@bidID", this.bidID);
            c.Parameters.AddWithValue("@discount", this.discount);
            c.Parameters.AddWithValue("@paymentTerm", this.term);
            c.Parameters.AddWithValue("@madeBy", this.user.getID());
            c.Parameters.AddWithValue("@contact", this.contact.getContactEmail());
            c.Parameters.AddWithValue("@productType", this.productType.getCatNumber());
            c.Parameters.AddWithValue("@customer", this.customer.getID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateCustomerBid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.UpdateCustomerBid	@bidID int, @discount float, @paymentTerm varchar(50), @madeBy int, @contact varchar(50), @productType int, @customer int"; // CREATE SP
            c.Parameters.AddWithValue("@bidID", this.bidID);
            c.Parameters.AddWithValue("@discount", this.discount);
            c.Parameters.AddWithValue("@paymentTerm", this.term);
            c.Parameters.AddWithValue("@madeBy", this.user.getID());
            c.Parameters.AddWithValue("@contact", this.contact.getContactEmail());
            c.Parameters.AddWithValue("@productType", this.productType.getCatNumber());
            c.Parameters.AddWithValue("@customer", this.customer.getID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // getters & setters:

        public int getBidID()
        {
            return this.bidID;
        }
    }
}