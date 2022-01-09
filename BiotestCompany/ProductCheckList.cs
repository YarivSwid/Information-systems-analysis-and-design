using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiotestCompany
{
    public partial class ProductCheckList : Form
    {
        private int chosenID;
        Dictionary<int, int> temp = new Dictionary<int, int>();
        public ProductCheckList()
        {
            InitializeComponent();
           
            int i = 0;
            int count = Program.tempProductTypesDict.Count();
            while (count >i) {
                int a = Program.tempProductTypesDict.ElementAt(i).Key.getCatNumber();
                int b = Program.tempProductTypesDict.ElementAt(i).Value;
                temp.Add(a, b);
                i = i + 1;
            }
            if (temp.Count() != 0)
            {
                BindingSource _bindingSource = new BindingSource();
                dataGridView1.DataSource = _bindingSource;
                _bindingSource.DataSource = temp;
                this.dataGridView1.Columns[0].HeaderText = "Product CategorialNumber";
                this.dataGridView1.Columns[1].HeaderText = "Amount";

            }
            else
            {
                temp.Add(0, 0);
                BindingSource _bindingSource = new BindingSource();
                dataGridView1.DataSource = _bindingSource;
                _bindingSource.DataSource = temp;
                this.dataGridView1.Columns[0].HeaderText = "Product CategorialNumber";
                this.dataGridView1.Columns[1].HeaderText = "Amount";
            }
            dataGridView1.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.tempProductTypesDict.Clear();
            this.temp.Clear();
            Dictionary<int, int> temp = new Dictionary<int, int>();
            temp.Add(0, 0);
            BindingSource _bindingSource = new BindingSource();
            dataGridView1.DataSource = _bindingSource;
            _bindingSource.DataSource = temp;
            this.dataGridView1.Columns[0].HeaderText = "Product CategorialNumber";
            this.dataGridView1.Columns[1].HeaderText = "Amount";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            int count = Program.tempProductTypesDict.Count();
            while (count > i)
            {                
                if (Program.tempProductTypesDict.ElementAt(i).Key.getCatNumber() == this.chosenID) {
                    ProductType PT = Program.tempProductTypesDict.ElementAt(i).Key;
                    this.temp.Remove(PT.getCatNumber());
                    Program.tempProductTypesDict.Remove(PT);
                    if (temp.Count()!=0)
                    {
                        BindingSource _bindingSource = new BindingSource();
                        dataGridView1.DataSource = _bindingSource;
                        _bindingSource.DataSource = temp;
                        this.dataGridView1.Columns[0].HeaderText = "Product CategorialNumber";
                        this.dataGridView1.Columns[1].HeaderText = "Amount";
                    }
                    else {
                        temp.Add(0, 0);
                        BindingSource _bindingSource = new BindingSource();
                        dataGridView1.DataSource = _bindingSource;
                        _bindingSource.DataSource = temp;
                        this.dataGridView1.Columns[0].HeaderText = "Product CategorialNumber";
                        this.dataGridView1.Columns[1].HeaderText = "Amount";
                    }

                    break;
                }
                else {
                    i = i + 1;
                }

            }


        }
        public void removeElement(int CategorialNumber) {
            int i = 0;
            int count = temp.Count();
            while (count>i) {
                if (temp.ElementAt(i).Key == CategorialNumber) {
                    this.temp.Remove(i);
                    break;
                }
                i = i + 1;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            try { 
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                this.chosenID = int.Parse(row.Cells[0].Value.ToString());
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductCheckList_Load(object sender, EventArgs e)
        {

        }
    }
}
