using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class SupplierBid
    {
        private Supplier supplier;
        private int catNumber;
        private double pricePerUnit;
        private DateTime date;

        public SupplierBid(Supplier supplier, int catNumber, double pricePerUnit, DateTime date, Boolean isNew)
        {
            this.supplier = supplier;
            this.catNumber = catNumber;
            this.pricePerUnit = pricePerUnit;
            this.date = date;
            if (isNew)
            {
                this.createSupplierBid();
                Program.supplierBids.Add(this);
            }
        }
        public void createSupplierBid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddSupplierBid @supplierID, @categorialNumber, @pricePerUnit, @bidDateTime";
            c.Parameters.AddWithValue("@supplierID", this.supplier.getSupplierID());
            c.Parameters.AddWithValue("@categorialNumber", this.catNumber);
            c.Parameters.AddWithValue("@pricePerUnit", this.pricePerUnit);
            c.Parameters.AddWithValue("@bidDateTime", this.date);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void updateSupplierBid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.UpdateSupplierBid @supplierID, @categorialNumber, @pricePerUnit, @bidDateTime";
            c.Parameters.AddWithValue("@supplierID", this.supplier.getSupplierID());
            c.Parameters.AddWithValue("@categorialNumber", this.catNumber);
            c.Parameters.AddWithValue("@pricePerUnit", this.pricePerUnit);
            c.Parameters.AddWithValue("@bidDateTime", this.date);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
