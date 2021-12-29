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
                Program.SupplierBids.Add(this);
            }
        }
        public void createSupplierBid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.AddSupplierBid @supplier, @catNumber, @pricePerUnit ,@date";
            c.Parameters.AddWithValue("@supplier", this.supplier);
            c.Parameters.AddWithValue("@catNumber", this.catNumber);
            c.Parameters.AddWithValue("@pricePerUnit", this.pricePerUnit);
            c.Parameters.AddWithValue("@date", this.date);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
