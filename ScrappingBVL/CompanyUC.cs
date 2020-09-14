using System;
using System.Windows.Forms;
using Entity;
using BusinessLayer;

namespace ScrappingBVL
{
    public partial class CompanyUC : UserControl
    {
        private int Id;
        private CompanyBusiness objCompanyBusiness;
        private CategoryBusiness objCategoryBusiness;
        public CompanyUC()
        {
            InitializeComponent();
            objCompanyBusiness = new CompanyBusiness();
            objCategoryBusiness = new CategoryBusiness();
        }

        private void LoadGrid()
        {
            dgCompany.DataSource = objCompanyBusiness.GetAll();
            dgCompany.Refresh();
        }

        private void LoadCategory()
        {
            cbCategory.DataSource = objCategoryBusiness.GetAll();
            cbCategory.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Company objCompany = new Company();
            objCompany.Active = chkActive.Checked;
            objCompany.Name = tbName.Text;
            objCompany.Nemonico = tbNemonico.Text;
            objCompany.Id = Id;
            objCompany.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);

            objCompanyBusiness.Save(objCompany);
            ClearControl();
            LoadGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        public void InitControl()
        {
            LoadGrid();
            LoadCategory();
            dgCompany.Columns[0].Width = 40;
            dgCompany.Columns[1].Width = 380;
            dgCompany.Columns[2].Width = 120;
            dgCompany.Columns[3].Visible = false;
            dgCompany.Columns[4].Width = 80;
        }

        private void ClearControl()
        {
            Id = 0;
            tbName.Clear();
            tbNemonico.Clear();
            chkActive.Checked = false;
        }

        private void dgCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgCompany.Rows[e.RowIndex].Cells[0].Value);
            tbName.Text = dgCompany.Rows[e.RowIndex].Cells[1].Value.ToString();
            //chkActive.Checked = Convert.ToBoolean(dgCompany.Rows[e.RowIndex].Cells[2].Value);
        }
    }
}
