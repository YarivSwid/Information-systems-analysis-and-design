using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class Supplier
    {
        private int supplierID;
        private string companyName;
        private string country;
        private string officialMail;
        private double punctualityRank;
        private double qualityRank;
        private double totalRank;
        private string notes;
        private List<Contact> contacts;
        
        public Supplier(int supplierID, string companyName, string country, string officialMail, double punctualityRank, double qualityRank, double totalRank, string notes, List<Contact> contacts, Boolean isNew)
        {
            this.supplierID = supplierID;
            this.companyName = companyName;
            this.country = country;
            this.officialMail = officialMail;
            this.punctualityRank = punctualityRank;
            this.qualityRank = qualityRank;
            this.totalRank = totalRank;
            this.notes = notes;
            this.contacts = contacts;
            if(isNew)
            {
                createSupplier();
                Program.Suppliers.Add(this);
            }

        }
        public void createSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddSupplier @supplierID, @companyName, @country ,@punctualityRank, @qualityRank, @totalRank, @notes";
            c.Parameters.AddWithValue("@supplierID", this.supplierID);
            c.Parameters.AddWithValue("@companyName", this.companyName);
            c.Parameters.AddWithValue("@country", this.country);
            c.Parameters.AddWithValue("@punctualityRank", this.punctualityRank);
            c.Parameters.AddWithValue("@qualityRank", this.qualityRank);
            c.Parameters.AddWithValue("@pScore", this.totalRank);
            c.Parameters.AddWithValue("@qScore", this.notes);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // getters & setters:

        public int getSupplierID()
        {
            return this.supplierID;
        }

    }
}