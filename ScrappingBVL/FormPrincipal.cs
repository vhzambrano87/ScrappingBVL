﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrappingBVL
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearControls();
            _categoryUC.Visible = true;
            _categoryUC.InitControl();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearControls();
            _companyUC.Visible = true;
            _companyUC.InitControl();
        }

        private void ClearControls()
        {
            _categoryUC.Visible = false;
            _companyUC.Visible = false;
        }
    }
}
