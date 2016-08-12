namespace KotrakMed
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label emailLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.employessDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnStatusValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.bntBlock = new System.Windows.Forms.Button();
            this.btnUnblock = new System.Windows.Forms.Button();
            this.employessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kotrakMedDataSet = new KotrakMed.KotrakMedDataSet();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employessTableAdapter = new KotrakMed.KotrakMedDataSetTableAdapters.EmployessTableAdapter();
            this.tableAdapterManager = new KotrakMed.KotrakMedDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employessDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotrakMedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(20, 21);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(20, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(20, 73);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(20, 99);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(42, 13);
            adressLabel.TabIndex = 7;
            adressLabel.Text = "Adress:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(20, 125);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 9;
            telephoneLabel.Text = "Telephone:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(20, 155);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employessBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(87, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(62, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employessBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(87, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employessBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(87, 70);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(203, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employessBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(87, 96);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(203, 20);
            this.adressTextBox.TabIndex = 8;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employessBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(87, 122);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(203, 20);
            this.telephoneTextBox.TabIndex = 10;
            // 
            // employessDataGridView
            // 
            this.employessDataGridView.AllowUserToAddRows = false;
            this.employessDataGridView.AllowUserToDeleteRows = false;
            this.employessDataGridView.AutoGenerateColumns = false;
            this.employessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumnName,
            this.dataGridViewTextBoxColumnSurname,
            this.dataGridViewTextBoxColumnAdress,
            this.dataGridViewTextBoxColumnTelephone,
            this.dataGridViewTextBoxColumnStatusValue,
            this.Email});
            this.employessDataGridView.DataSource = this.employessBindingSource;
            this.employessDataGridView.Location = new System.Drawing.Point(611, 12);
            this.employessDataGridView.Name = "employessDataGridView";
            this.employessDataGridView.ReadOnly = true;
            this.employessDataGridView.Size = new System.Drawing.Size(717, 475);
            this.employessDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumnStatusValue
            // 
            this.dataGridViewTextBoxColumnStatusValue.DataPropertyName = "StatusValue";
            this.dataGridViewTextBoxColumnStatusValue.HeaderText = "StatusValue";
            this.dataGridViewTextBoxColumnStatusValue.Name = "dataGridViewTextBoxColumnStatusValue";
            this.dataGridViewTextBoxColumnStatusValue.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(35, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(111, 20);
            this.txtFilter.TabIndex = 12;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(180, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(35, 413);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(35, 444);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.telephoneTextBox);
            this.groupBox1.Controls.Add(telephoneLabel);
            this.groupBox1.Controls.Add(this.adressTextBox);
            this.groupBox1.Controls.Add(adressLabel);
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(surnameLabel);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(35, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 281);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // textEmail
            // 
            this.textEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employessBindingSource, "Email", true));
            this.textEmail.Location = new System.Drawing.Point(87, 174);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(203, 20);
            this.textEmail.TabIndex = 13;
            this.textEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textEmail_Validating);
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employessBindingSource, "StatusValue", true));
            this.statusTextBox.Location = new System.Drawing.Point(87, 148);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(203, 20);
            this.statusTextBox.TabIndex = 11;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(353, 413);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // bntBlock
            // 
            this.bntBlock.Location = new System.Drawing.Point(353, 444);
            this.bntBlock.Name = "bntBlock";
            this.bntBlock.Size = new System.Drawing.Size(75, 23);
            this.bntBlock.TabIndex = 19;
            this.bntBlock.Text = "Block";
            this.bntBlock.UseVisualStyleBackColor = true;
            this.bntBlock.Click += new System.EventHandler(this.bntBlock_Click);
            // 
            // btnUnblock
            // 
            this.btnUnblock.Location = new System.Drawing.Point(353, 478);
            this.btnUnblock.Name = "btnUnblock";
            this.btnUnblock.Size = new System.Drawing.Size(75, 23);
            this.btnUnblock.TabIndex = 20;
            this.btnUnblock.Text = "Unblock";
            this.btnUnblock.UseVisualStyleBackColor = true;
            this.btnUnblock.Click += new System.EventHandler(this.btnUnblock_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(22, 181);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email:";
            // 
            // employessBindingSource
            // 
            this.employessBindingSource.DataMember = "Employess";
            this.employessBindingSource.DataSource = this.kotrakMedDataSet;
            // 
            // kotrakMedDataSet
            // 
            this.kotrakMedDataSet.DataSetName = "KotrakMedDataSet";
            this.kotrakMedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumnId
            // 
            this.dataGridViewTextBoxColumnId.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumnId.HeaderText = "Id";
            this.dataGridViewTextBoxColumnId.Name = "dataGridViewTextBoxColumnId";
            this.dataGridViewTextBoxColumnId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnName
            // 
            this.dataGridViewTextBoxColumnName.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumnName.HeaderText = "Name";
            this.dataGridViewTextBoxColumnName.Name = "dataGridViewTextBoxColumnName";
            this.dataGridViewTextBoxColumnName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnSurname
            // 
            this.dataGridViewTextBoxColumnSurname.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumnSurname.HeaderText = "Surname";
            this.dataGridViewTextBoxColumnSurname.Name = "dataGridViewTextBoxColumnSurname";
            this.dataGridViewTextBoxColumnSurname.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnAdress
            // 
            this.dataGridViewTextBoxColumnAdress.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumnAdress.HeaderText = "Adress";
            this.dataGridViewTextBoxColumnAdress.Name = "dataGridViewTextBoxColumnAdress";
            this.dataGridViewTextBoxColumnAdress.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnTelephone
            // 
            this.dataGridViewTextBoxColumnTelephone.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumnTelephone.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumnTelephone.Name = "dataGridViewTextBoxColumnTelephone";
            this.dataGridViewTextBoxColumnTelephone.ReadOnly = true;
            // 
            // employessTableAdapter
            // 
            this.employessTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployessTableAdapter = this.employessTableAdapter;
            this.tableAdapterManager.UpdateOrder = KotrakMed.KotrakMedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 544);
            this.Controls.Add(this.btnUnblock);
            this.Controls.Add(this.bntBlock);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.employessDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employessDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotrakMedDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KotrakMed.KotrakMedDataSet kotrakMedDataSet;
        private System.Windows.Forms.BindingSource employessBindingSource;
        private KotrakMed.KotrakMedDataSetTableAdapters.EmployessTableAdapter employessTableAdapter;
        private KotrakMed.KotrakMedDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.DataGridView employessDataGridView;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnStatusValue;
        private System.Windows.Forms.Button bntBlock;
        private System.Windows.Forms.Button btnUnblock;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

