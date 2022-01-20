using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using WheelBearings.Model;

namespace WheelBearings
{

    public partial class FormTable : Form
    {
        List<BrandCar> brandCars = new List<BrandCar>();

        public FormTable()
        {
            InitializeComponent();
            lbxBrandCarList.DataSource = brandCars;
            lbxBrandCarList.DisplayMember = "FullInfo";
        }
            
        private void FormTable_Load(object sender, EventArgs e)
        {
             
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            brandCars = dataAccess.GetBrandCars(tbxBrandCar.Text);
        }
    }
}
