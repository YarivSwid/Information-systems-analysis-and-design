﻿using System;
using System.Collections.Generic;
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
        private User user;
        private ProductType productType;
        private Customer customer;

        public CustomerBid(int bidID, double discount, PaymentTerm term, User user, ProductType productType, Customer customer, Boolean isNew)
        {
            this.bidID = bidID;
            this.discount = discount;
            this.term = term;
            this.user = user;
            this.productType = productType;
            this.customer = customer;
            if (isNew)
            {
                this.createCustomerBid();
                Program.CustomerBids.Add(this);
            }
        }

        // getters & setters:

        public int getBidID()
        {
            return this.bidID;
        }
        public double getDiscount()
        {
            return this.discount;
        }
        public PaymentTerm GetPaymentTerm()
        {
            return this.term;
        }
        public User getUser()
        {
            return this.user;
        }
        public ProductType GetProductType()
        {
            return this.productType;
        }
        public Customer getCustomer()
        {
            return this.customer;
        }


        public void createCustomerBid()
        {

        }

    }
}
