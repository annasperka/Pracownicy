using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            LoadData();

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

        
        private void btnFilter_Click(object sender, EventArgs e)
        {
            employessBindingSource.Filter = string.Format("Name like '%{0}%' or Surname like '%{0}%' or Adress like '%{0}%'", txtFilter.Text);
        }

     

        private void LoadData()
        {
            this.employessTableAdapter.Fill(this.kotrakMedDataSet.Employess);

            Tools tool = new Tools();
            tool.Transform(this.kotrakMedDataSet.Employess);
            //tool.SetDisplayMember(this.dataGridViewTextBoxColumnStatus);
            //tool.SetDisplayMember(this.statusComboBox);        


        }


        private void btnAccept_Click(object sender, EventArgs e)
        {

            DataRow dr = ((DataRowView)employessBindingSource.Current).Row;

            if ((byte)dr["Status"] == (byte)EntityProperties.Status.New)
            {
                dr["Status"] = (byte)EntityProperties.Status.Accepted;
                dr["StatusValue"] = EntityProperties.Status.Accepted.ToString();

                //this.Validate();
                //this.employessBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.kotrakMedDataSet);
            }
            else
            {
                MessageBox.Show(Messages.CannotAccept);
            }
        }

        private void bntBlock_Click(object sender, EventArgs e)
        {
            DataRow dr = ((DataRowView)employessBindingSource.Current).Row;

            if ((byte)dr["Status"] == (byte)EntityProperties.Status.Accepted)
            {
                dr["Status"] = (byte)EntityProperties.Status.Blocked;
                dr["StatusValue"] = EntityProperties.Status.Blocked.ToString();
             
            }
            else
            {
                MessageBox.Show(Messages.CannotBlock);
            }

        }

        private void btnUnblock_Click(object sender, EventArgs e)
        {
            DataRow dr = ((DataRowView)employessBindingSource.Current).Row;

            if ((byte)dr["Status"] == (byte)EntityProperties.Status.Blocked)
            {
                dr["Status"] = (byte)EntityProperties.Status.Accepted;
                dr["StatusValue"] = EntityProperties.Status.Accepted.ToString();

            }
            else
            {
                MessageBox.Show(Messages.CannotBlock);
            }

        }

       

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Tools.CheckEmailFormat(((TextBox)sender).Text);

        }
      

            
        
    }
}
