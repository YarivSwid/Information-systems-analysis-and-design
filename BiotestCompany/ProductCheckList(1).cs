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
            int count = Program.TempProductTypesDict.Count();
            while (count >i) {
                int a = Program.TempProductTypesDict.ElementAt(i).Key.getCatNumber();
                int b = Program.TempProductTypesDict.ElementAt(i).Value;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.TempProductTypesDict.Clear();
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
            int count = Program.TempProductTypesDict.Count();
            while (count > i)
            {                
                if (Program.TempProductTypesDict.ElementAt(i).Key.getCatNumber() == this.chosenID) {
                    ProductType PT = Program.TempProductTypesDict.ElementAt(i).Key;
                    this.temp.Remove(PT.getCatNumber());
                    Program.TempProductTypesDict.Remove(PT);
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
        public void RemoveElement(int CategorialNumber) {
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
    }
}
