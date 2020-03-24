using Libraries.DataHelpers.DataAccess;
using Libraries.DataHelpers.Factory;
using Libraries.DataHelpers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarCalculatorClientWinForm
{
    public partial class Main : Form
    {
        private BindingList<CarsModel> datagridMasterData;
        private BindingList<TransactionModel> datagridTransactionData;
        private IEnumerable<CarsModel> hasilx = null;
        private IEnumerable<TransactionModel> TransactionHasil = null;

        private CRUDProcessors crud = new CRUDProcessors();
        private TransactionProcessor processor = new TransactionProcessor();
        private TransactionModel obj = new TransactionModel();

        public Main()
        {
            InitializeComponent();
        }

       
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var obj = new CarsModel();
           
            if (CheckInputMasterDataForms())
            {
                obj.ModelName = TbModelName.Text;
                obj.ModelYear = Convert.ToInt32(TbModelYear.Text);
                obj.NumberCar = TbCarNumber.Text;
                obj.RentCost = Convert.ToDecimal(TbRentCost.Text);
                obj.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                obj.SeriesName = TbSeriesName.Text;

                try
                {
                    if (crud.InsertCar(obj) > 0)
                    {
                        LoadData();
                        SetEmptyForm();
                    }
                    else
                    {
                        MessageBox.Show("Error Insert data");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error Insert data " + err.Message);
                    throw err;
                }
            }
            else
            {
                MessageBox.Show("Text Box cannot be empty! ");
            }
            

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var obj = new CarsModel();
            if (CheckInputMasterDataForms())
            {
                obj.Id = Convert.ToInt32(TbId.Text);
                obj.ModelName = TbModelName.Text;
                obj.ModelYear = Convert.ToInt32(TbModelYear.Text);
                obj.NumberCar = TbCarNumber.Text;
                obj.RentCost = Convert.ToDecimal(TbRentCost.Text);
                obj.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                obj.SeriesName = TbSeriesName.Text;

                try
                {
                    if (crud.UpdateCar(obj) > 0)
                    {
                        LoadData();
                        SetEmptyForm();
                    }
                    else
                    {
                        MessageBox.Show("Error Update data");
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show("Error Update data " + err.Message);
                    throw err;
                }
            }
            else
            {
                MessageBox.Show("Text Box cannot be empty! ");
            }




        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var obj = new CarsModel();

            if (CheckInputMasterDataForms())
            {
                obj.Id = Convert.ToInt32(TbId.Text);
                obj.ModelName = TbModelName.Text;
                obj.ModelYear = Convert.ToInt32(TbModelYear.Text);
                obj.NumberCar = TbCarNumber.Text;
                obj.RentCost = Convert.ToDecimal(TbRentCost.Text);

                try
                {
                    if (crud.DeleteCar(obj) > 0)
                    {
                        LoadData();
                        SetEmptyForm();
                    }
                    else
                    {
                        MessageBox.Show("Error Delete data");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error Delete data " + err.Message);
                    throw err;
                }
            }
            else
            {
                MessageBox.Show("Text Box cannot be empty! ");
            }

          
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
            int id = 0;
            int days = 0;
            int carQty = 0;
            bool res = false;

            string myStr = string.Empty;
            if (CbModel.SelectedValue != null) myStr = CbModel.SelectedValue.ToString();
            res = int.TryParse(myStr, out id);

            if (!string.IsNullOrEmpty(TbDaysQty.Text)) myStr = TbDaysQty.Text;
            res = int.TryParse(myStr, out days);

            if (!string.IsNullOrEmpty(TbCarQty.Text)) myStr = TbCarQty.Text;
            res = int.TryParse(myStr, out carQty);

            try
            {
                IEnumerable<CarsModel> query = hasilx.Where(s => s.Id == id).ToList();
                if (query != null && query.Count() > 0)
                {
                    obj.ModelYear = Convert.ToInt32(query.Select(x => x.ModelYear).First().ToString());
                    obj.TotalDay = days;
                    obj.Car = query.Select(x => x.ModelName).First().ToString() + " | ";
                    obj.Car += query.Select(x => x.SeriesName).First().ToString();
                    obj.QtyCar = carQty;
                    obj.TotalPrice = Convert.ToDecimal(query.Select(x => x.RentCost).First().ToString());
                    obj.Discount = processor.GetDiscountValue(obj.TotalDay, obj.QtyCar, obj.ModelYear);
                    obj.TotalPrice = obj.TotalPrice * obj.QtyCar * obj.TotalDay;
                    // Price after discount

                    obj.TotalPrice -= ((obj.TotalPrice * obj.Discount) / 100);
                    obj.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    List<TransactionModel> _items = new List<TransactionModel>();
                    _items.Add(obj);
                    datagridTransactionData = new BindingList<TransactionModel>(_items.ToList());
                    DGResult.DataSource = datagridTransactionData;
                    


                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void LoadData()
        {
            hasilx = crud.GetAllCars();
            datagridMasterData = new BindingList<CarsModel>(hasilx.ToList());
            DGviewMasterData.DataSource = datagridMasterData;

            // Set Combo box
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("DisplayText", typeof(string));
            
            CbModel.ValueMember = "ID";
            CbModel.DisplayMember = "DisplayText";

            foreach (var value in hasilx)
            {
                dt.Rows.Add(new object[] { value.Id, value.ModelName +" | Series: "+ value.SeriesName +" | Year: " +value.ModelYear });

            }
            CbModel.DataSource = new BindingSource(dt, null);

        }

        /// <summary>
        /// Check Input Form Input Master Data CRUD
        /// </summary>
        /// <returns></returns>
        private bool CheckInputMasterDataForms()
        {
            bool result = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.TabIndex > 3)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        result = false;
                        return result;
                    }
                    else result = true;
                }
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Set Empty Form inputs
        /// </summary>

        private void SetEmptyForm()
        {
            TbSeriesName.Text = string.Empty;
            TbRentCost.Text = string.Empty;
            TbModelYear.Text = string.Empty;
            TbModelName.Text = string.Empty;
            TbDaysQty.Text = string.Empty;
            TbCarNumber.Text = string.Empty;
            TbCarQty.Text = string.Empty;

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            crud.Dispose();
            processor.Dispose();
        }

        /// <summary>
        /// Click Cell on GridView data and assign to form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGviewMasterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGviewMasterData.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DGviewMasterData.CurrentRow.Selected = true;
                TbId.Text = DGviewMasterData.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            }
            if (DGviewMasterData.Rows[e.RowIndex].Cells[1].Value != null)
            {
                TbModelName.Text = DGviewMasterData.Rows[e.RowIndex].Cells["ModelName"].Value.ToString();
            }
            if (DGviewMasterData.Rows[e.RowIndex].Cells[2].Value != null)
            {
                TbSeriesName.Text = DGviewMasterData.Rows[e.RowIndex].Cells["SeriesName"].Value.ToString();
            }
            if (DGviewMasterData.Rows[e.RowIndex].Cells[3].Value != null)
            {
                TbModelYear.Text = DGviewMasterData.Rows[e.RowIndex].Cells["ModelYear"].FormattedValue.ToString();
            }
            if (DGviewMasterData.Rows[e.RowIndex].Cells[4].Value != null)
            {
                TbCarNumber.Text = DGviewMasterData.Rows[e.RowIndex].Cells["NumberCar"].FormattedValue.ToString();
            }
            if (DGviewMasterData.Rows[e.RowIndex].Cells[5].Value != null)
            {
                TbRentCost.Text = DGviewMasterData.Rows[e.RowIndex].Cells["RentCost"].FormattedValue.ToString();
            }
            
        }
    }
}
