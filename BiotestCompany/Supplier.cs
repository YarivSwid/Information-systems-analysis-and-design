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
        private List<ProductType> producttypes;
        
        public Supplier(int supplierID, string companyName, string country, string officialMail, double punctualityRank, double qualityRank, double totalRank, string notes, List<Contact> contacts, List<ProductType> producttypes, Boolean isNew)
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
            this.producttypes = producttypes;
            if(isNew)
            {
                createSupplier();
                Program.suppliers.Add(this);
            }

        }
        public void createSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddSupplier @supplierID, @companyName, @country, @officialEmail ,@punctualityRank, @qualityRank, @totalRank, @notes";
            c.Parameters.AddWithValue("@supplierID", int.Parse(this.supplierID.ToString()));
            c.Parameters.AddWithValue("@companyName", this.companyName);
            c.Parameters.AddWithValue("@country", this.country);
            c.Parameters.AddWithValue("@officialEmail", this.officialMail);
            c.Parameters.AddWithValue("@punctualityRank", 0);
            c.Parameters.AddWithValue("@qualityRank", 0);
            c.Parameters.AddWithValue("@totalRank", 0);
            c.Parameters.AddWithValue("@notes", this.notes);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateSupplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateSupplier2 @supplierID, @companyName, @country, @officialEmail ,@notes"; 
            c.Parameters.AddWithValue("@supplierID", this.supplierID);
            c.Parameters.AddWithValue("@companyName", this.companyName);
            c.Parameters.AddWithValue("@country", this.country);
            c.Parameters.AddWithValue("@officialEmail", this.officialMail);
            c.Parameters.AddWithValue("@notes", this.notes);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateSupplierAlon()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateSupplier @supplierID, @companyName, @country, @officialEmail, @punctualityRank, @qualityRank, @totalRank, @notes";
            c.Parameters.AddWithValue("@supplierID", this.supplierID);
            c.Parameters.AddWithValue("@companyName", this.companyName);
            c.Parameters.AddWithValue("@country", this.country);
            c.Parameters.AddWithValue("@officialEmail", this.officialMail);
            c.Parameters.AddWithValue("@punctualityRank", this.punctualityRank);
            c.Parameters.AddWithValue("@qualityRank", this.qualityRank);
            c.Parameters.AddWithValue("@totalRank", this.totalRank);
            c.Parameters.AddWithValue("@notes", this.notes);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        // getters & setters:

        public int getSupplierID()
        {
            return this.supplierID;
        }
        public string getCompanyName()
        {
            return this.companyName;
        }
        public string getCountry()
        {
            return this.country;
        }
        public string getMail()
        {
            return this.officialMail;
        }
        public double getPunRank()
        {
            return this.punctualityRank;
        }
        public double getQualRank()
        {
            return this.qualityRank;
        }
        public double getTotRank()
        {
            return this.totalRank;
        }
        public string getNotes()
        {
            return this.notes;
        }
        public int getID()
        {
            return this.supplierID;
        }
        public void setCompanyName(string name)
        {
            this.companyName = name;
        }
        public void setCountry(string name)
        {
            this.country = name;
        }
        public void setMail(string name)
        {
            this.officialMail = name;
        }
        public void setPunRank(double rank)
        {
            this.punctualityRank = rank;
        }
        public void setQualRank(double rank)
        {
            this.qualityRank = rank;
        }
        public void setNotes(string name)
        {
            this.notes = name;
        }
        public void updateSupplierRanks()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.ReturnSupplierRank @supplierID";
            c.Parameters.AddWithValue("@supplierID", this.supplierID);
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                this.punctualityRank = double.Parse(rdr.GetValue(0).ToString());
                this.qualityRank = double.Parse(rdr.GetValue(1).ToString());
                this.totalRank = double.Parse(rdr.GetValue(2).ToString());
            }
            this.updateSupplierAlon();
        }
    }
}
