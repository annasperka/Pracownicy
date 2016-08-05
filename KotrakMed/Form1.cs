﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KotrakMed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kotrakMedDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kotrakMedDataSet.Employess' table. You can move, or remove it, as needed.
            this.employessTableAdapter.Fill(this.kotrakMedDataSet.Employess);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            employessBindingSource.Filter = string.Format("Name like '%{0}%' or Surname like '%{0}%' or Adress like '%{0}%'", txtSearch.Text);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.employessBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kotrakMedDataSet);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.employessBindingSource.RemoveCurrent();
        }

        private void employessDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void employessBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void employessBindingSource_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void employessBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
