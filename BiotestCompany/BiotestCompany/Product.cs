using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiotestCompany
{
    public class Product
    {
        private int serialNumber;
        private int units;
        private ProductStatus status;
        private ProductType productType;
        private int supplierOrderID;
        private int customerOrderID;

        public Product(int serialNumber, int units, ProductStatus status, ProductType productType, int sOrderID, int cOrderID, Boolean isNew)
        {
            this.serialNumber = serialNumber;
            this.units = units;
            this.status = status;
            this.productType = productType;
            this.supplierOrderID = sOrderID;
            this.customerOrderID = cOrderID;
            if (isNew)
            {
                this.createProduct();
                Program.Products.Add(this);
            }
        }

        public void createProduct() // CREATE THIS
        {

        }
    }
}
