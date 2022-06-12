using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }

        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Car CarInfor { get; set; }

        //---------------------------
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)// update mode
            {
                //show car to perform updating
                txtCarID.Text = CarInfor.CarID.ToString();
                txtCarName.Text = CarInfor.CarName;
                txtPrice.Text = CarInfor.Price.ToString();
                txtReleaseYear.Text = CarInfor.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfor.Manufacturer.Trim();
            }//end

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
            if (InsertOrUpdate==false)
            {
                    CarRepository.InsertCar(car);
            }
            else
            {
                    CarRepository.UpdateCar(car);
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,InsertOrUpdate==false?"Add a new car":"Update a car");
            }
        }//end button save

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }//end
}
