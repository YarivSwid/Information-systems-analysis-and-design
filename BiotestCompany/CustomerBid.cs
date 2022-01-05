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
        private Contact contact;
        private Customer customer;
        private Dictionary<ProductType, int> bidDetails;

        public CustomerBid(int bidID, double discount, PaymentTerm term, User user, Contact contact, Customer customer, Dictionary<ProductType, int> bidDetails, Boolean isNew)
        {
            this.bidID = bidID;
            this.discount = discount;
            this.term = term;
            this.user = user;
            this.contact = contact;
            this.customer = customer;
            this.bidDetails = bidDetails;
            if (isNew)
            {
                this.createCustomerBid();
                Program.customerBids.Add(this);
            }
        }

        public void createCustomerBid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "dbo.AddCustomerBid @bidID, @discount, @paymentTerm, @madeBy, @contact, @customer"; // 
            c.Parameters.AddWithValue("@bidID", this.bidID);
            c.Parameters.AddWithValue("@discount", this.discount);
            c.Parameters.AddWithValue("@paymentTerm", this.term.ToString());
            c.Parameters.AddWithValue("@madeBy", this.user.getID());
            c.Parameters.AddWithValue("@contact", this.contact.getContactEmail());
            c.Parameters.AddWithValue("@customer", this.customer.getID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
            createBidDetails();
        }
        public void createBidDetails()
        {
            int i = 0;
            int count = this.bidDetails.Count();
            while (count > i)
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "dbo.AddProductListCustomerBid	@bidID, @categorialNumber, @amount"; // CREATE SP
                c.Parameters.AddWithValue("@bidID", this.bidID);
                c.Parameters.AddWithValue("@categorialNumber", this.bidDetails.ElementAt(i).Key.getCatNumber());
                c.Parameters.AddWithValue("@amount", this.bidDetails.ElementAt(i).Value);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
                i = i + 1;
            }
        }

        public Boolean isDictEmpty()
        {
            if (this.bidDetails == null)
            {
                return true;
            }
            return false;
        }
        public Dictionary<ProductType, int> getBidDict()
        {
            return this.bidDetails;
        }

        public int doesProductExistInDict(int categorialNumber)
        { // does my product exist? and how many? 0 -> not | x>0 -> amount
            int i = 0;
            int productWasntFound = 0;
            while (this.bidDetails.ElementAt(i).Key != null)
            {
                if (this.bidDetails.ElementAt(i).Key.getCatNumber() == categorialNumber)
                {
                    return i;
                }
                i = i + 1;
            }
            return productWasntFound;
        }
        public int howManyProductTypeExistInDict(int categorialNumber)
        { // does my product exist? and how many? 0 -> not | x>0 -> amount
            int i = 0;
            int productWasntFound = 0;
            while (this.bidDetails.ElementAt(i).Key != null)
            {
                if (this.bidDetails.ElementAt(i).Key.getCatNumber() == categorialNumber)
                {
                    return this.bidDetails.ElementAt(i).Value;
                }
                i = i + 1;
            }
            return productWasntFound;
        }

        public int getBidID()
        {
            return this.bidID;
        }
        public Dictionary<ProductType, int> getBidDetails()
        {
            return this.bidDetails;
        }
    }
}