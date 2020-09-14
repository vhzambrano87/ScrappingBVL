using System;
using System.Windows.Forms;
using Entity;
using BusinessLayer;

namespace ScrappingBVL
{
    public partial class CategoryUC : UserControl
    {
        private int Id;
        private CategoryBusiness objCategoryBusiness;
        public CategoryUC()
        {
            InitializeComponent();
            objCategoryBusiness = new CategoryBusiness();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Category objCategory = new Category();
            objCategory.Active = chkActive.Checked;
            objCategory.Name = tbName.Text;
            objCategory.Id = Id;

            objCategoryBusiness.Save(objCategory);
            ClearControl();
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgCategory.DataSource = objCategoryBusiness.GetAll();
            dgCategory.Refresh();
        }

        public void InitControl()
        {
            LoadGrid();
            dgCategory.Columns[0].Width = 40;
            dgCategory.Columns[1].Width = 380;
            dgCategory.Columns[2].Width = 80;
        }

        private void ClearControl()
        {
            Id = 0;
            tbName.Clear();
            chkActive.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void dgCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgCategory.Rows[e.RowIndex].Cells[0].Value);
            tbName.Text = dgCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            chkActive.Checked = Convert.ToBoolean(dgCategory.Rows[e.RowIndex].Cells[2].Value);
        }
    }
}
