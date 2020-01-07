<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class male
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Cust1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet13 = New BankingSoftware.bankDataSet13
        Me.CustidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrelationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RelativenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReligionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaritalstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OcupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccounttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cust1TableAdapter = New BankingSoftware.bankDataSet13TableAdapters.cust1TableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cust1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustidDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.CrelationDataGridViewTextBoxColumn, Me.RelativenameDataGridViewTextBoxColumn, Me.DdateDataGridViewTextBoxColumn, Me.MonthDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.MaritalstatusDataGridViewTextBoxColumn, Me.OcupationDataGridViewTextBoxColumn, Me.AccountnoDataGridViewTextBoxColumn, Me.AccounttypeDataGridViewTextBoxColumn, Me.AccountamountDataGridViewTextBoxColumn, Me.NnameDataGridViewTextBoxColumn, Me.NaddressDataGridViewTextBoxColumn, Me.WnameDataGridViewTextBoxColumn, Me.WaddressDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Cust1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(54, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(716, 317)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cust1BindingSource, "gender", True))
        Me.TextBox1.Location = New System.Drawing.Point(146, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cust1BindingSource
        '
        Me.Cust1BindingSource.DataMember = "cust1"
        Me.Cust1BindingSource.DataSource = Me.BankDataSet13
        '
        'BankDataSet13
        '
        Me.BankDataSet13.DataSetName = "bankDataSet13"
        Me.BankDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustidDataGridViewTextBoxColumn
        '
        Me.CustidDataGridViewTextBoxColumn.DataPropertyName = "custid"
        Me.CustidDataGridViewTextBoxColumn.HeaderText = "custid"
        Me.CustidDataGridViewTextBoxColumn.Name = "CustidDataGridViewTextBoxColumn"
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "cname"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "cname"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        '
        'CrelationDataGridViewTextBoxColumn
        '
        Me.CrelationDataGridViewTextBoxColumn.DataPropertyName = "crelation"
        Me.CrelationDataGridViewTextBoxColumn.HeaderText = "crelation"
        Me.CrelationDataGridViewTextBoxColumn.Name = "CrelationDataGridViewTextBoxColumn"
        '
        'RelativenameDataGridViewTextBoxColumn
        '
        Me.RelativenameDataGridViewTextBoxColumn.DataPropertyName = "relativename"
        Me.RelativenameDataGridViewTextBoxColumn.HeaderText = "relativename"
        Me.RelativenameDataGridViewTextBoxColumn.Name = "RelativenameDataGridViewTextBoxColumn"
        '
        'DdateDataGridViewTextBoxColumn
        '
        Me.DdateDataGridViewTextBoxColumn.DataPropertyName = "ddate"
        Me.DdateDataGridViewTextBoxColumn.HeaderText = "ddate"
        Me.DdateDataGridViewTextBoxColumn.Name = "DdateDataGridViewTextBoxColumn"
        '
        'MonthDataGridViewTextBoxColumn
        '
        Me.MonthDataGridViewTextBoxColumn.DataPropertyName = "month"
        Me.MonthDataGridViewTextBoxColumn.HeaderText = "month"
        Me.MonthDataGridViewTextBoxColumn.Name = "MonthDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'ReligionDataGridViewTextBoxColumn
        '
        Me.ReligionDataGridViewTextBoxColumn.DataPropertyName = "religion"
        Me.ReligionDataGridViewTextBoxColumn.HeaderText = "religion"
        Me.ReligionDataGridViewTextBoxColumn.Name = "ReligionDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        '
        'MaritalstatusDataGridViewTextBoxColumn
        '
        Me.MaritalstatusDataGridViewTextBoxColumn.DataPropertyName = "maritalstatus"
        Me.MaritalstatusDataGridViewTextBoxColumn.HeaderText = "maritalstatus"
        Me.MaritalstatusDataGridViewTextBoxColumn.Name = "MaritalstatusDataGridViewTextBoxColumn"
        '
        'OcupationDataGridViewTextBoxColumn
        '
        Me.OcupationDataGridViewTextBoxColumn.DataPropertyName = "ocupation"
        Me.OcupationDataGridViewTextBoxColumn.HeaderText = "ocupation"
        Me.OcupationDataGridViewTextBoxColumn.Name = "OcupationDataGridViewTextBoxColumn"
        '
        'AccountnoDataGridViewTextBoxColumn
        '
        Me.AccountnoDataGridViewTextBoxColumn.DataPropertyName = "accountno"
        Me.AccountnoDataGridViewTextBoxColumn.HeaderText = "accountno"
        Me.AccountnoDataGridViewTextBoxColumn.Name = "AccountnoDataGridViewTextBoxColumn"
        '
        'AccounttypeDataGridViewTextBoxColumn
        '
        Me.AccounttypeDataGridViewTextBoxColumn.DataPropertyName = "accounttype"
        Me.AccounttypeDataGridViewTextBoxColumn.HeaderText = "accounttype"
        Me.AccounttypeDataGridViewTextBoxColumn.Name = "AccounttypeDataGridViewTextBoxColumn"
        '
        'AccountamountDataGridViewTextBoxColumn
        '
        Me.AccountamountDataGridViewTextBoxColumn.DataPropertyName = "accountamount"
        Me.AccountamountDataGridViewTextBoxColumn.HeaderText = "accountamount"
        Me.AccountamountDataGridViewTextBoxColumn.Name = "AccountamountDataGridViewTextBoxColumn"
        '
        'NnameDataGridViewTextBoxColumn
        '
        Me.NnameDataGridViewTextBoxColumn.DataPropertyName = "nname"
        Me.NnameDataGridViewTextBoxColumn.HeaderText = "nname"
        Me.NnameDataGridViewTextBoxColumn.Name = "NnameDataGridViewTextBoxColumn"
        '
        'NaddressDataGridViewTextBoxColumn
        '
        Me.NaddressDataGridViewTextBoxColumn.DataPropertyName = "naddress"
        Me.NaddressDataGridViewTextBoxColumn.HeaderText = "naddress"
        Me.NaddressDataGridViewTextBoxColumn.Name = "NaddressDataGridViewTextBoxColumn"
        '
        'WnameDataGridViewTextBoxColumn
        '
        Me.WnameDataGridViewTextBoxColumn.DataPropertyName = "wname"
        Me.WnameDataGridViewTextBoxColumn.HeaderText = "wname"
        Me.WnameDataGridViewTextBoxColumn.Name = "WnameDataGridViewTextBoxColumn"
        '
        'WaddressDataGridViewTextBoxColumn
        '
        Me.WaddressDataGridViewTextBoxColumn.DataPropertyName = "waddress"
        Me.WaddressDataGridViewTextBoxColumn.HeaderText = "waddress"
        Me.WaddressDataGridViewTextBoxColumn.Name = "WaddressDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'Cust1TableAdapter
        '
        Me.Cust1TableAdapter.ClearBeforeFill = True
        '
        'male
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 484)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "male"
        Me.Text = "male"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cust1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BankDataSet13 As BankingSoftware.bankDataSet13
    Friend WithEvents Cust1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cust1TableAdapter As BankingSoftware.bankDataSet13TableAdapters.cust1TableAdapter
    Friend WithEvents CustidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrelationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RelativenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaritalstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OcupationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccounttypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountamountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NaddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
