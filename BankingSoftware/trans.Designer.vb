<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trans
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
        Me.NumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tt1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ac1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ac2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet17 = New BankingSoftware.bankDataSet17
        Me.TransTableAdapter = New BankingSoftware.bankDataSet17TableAdapters.transTableAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumDataGridViewTextBoxColumn, Me.Tt1DataGridViewTextBoxColumn, Me.TdateDataGridViewTextBoxColumn, Me.Ac1DataGridViewTextBoxColumn, Me.Ac2DataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TransBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(60, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(808, 376)
        Me.DataGridView1.TabIndex = 0
        '
        'NumDataGridViewTextBoxColumn
        '
        Me.NumDataGridViewTextBoxColumn.DataPropertyName = "num"
        Me.NumDataGridViewTextBoxColumn.HeaderText = "num"
        Me.NumDataGridViewTextBoxColumn.Name = "NumDataGridViewTextBoxColumn"
        '
        'Tt1DataGridViewTextBoxColumn
        '
        Me.Tt1DataGridViewTextBoxColumn.DataPropertyName = "tt1"
        Me.Tt1DataGridViewTextBoxColumn.HeaderText = "tt1"
        Me.Tt1DataGridViewTextBoxColumn.Name = "Tt1DataGridViewTextBoxColumn"
        '
        'TdateDataGridViewTextBoxColumn
        '
        Me.TdateDataGridViewTextBoxColumn.DataPropertyName = "tdate"
        Me.TdateDataGridViewTextBoxColumn.HeaderText = "tdate"
        Me.TdateDataGridViewTextBoxColumn.Name = "TdateDataGridViewTextBoxColumn"
        '
        'Ac1DataGridViewTextBoxColumn
        '
        Me.Ac1DataGridViewTextBoxColumn.DataPropertyName = "ac1"
        Me.Ac1DataGridViewTextBoxColumn.HeaderText = "ac1"
        Me.Ac1DataGridViewTextBoxColumn.Name = "Ac1DataGridViewTextBoxColumn"
        '
        'Ac2DataGridViewTextBoxColumn
        '
        Me.Ac2DataGridViewTextBoxColumn.DataPropertyName = "ac2"
        Me.Ac2DataGridViewTextBoxColumn.HeaderText = "ac2"
        Me.Ac2DataGridViewTextBoxColumn.Name = "Ac2DataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'TransBindingSource
        '
        Me.TransBindingSource.DataMember = "trans"
        Me.TransBindingSource.DataSource = Me.BankDataSet17
        '
        'BankDataSet17
        '
        Me.BankDataSet17.DataSetName = "bankDataSet17"
        Me.BankDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransTableAdapter
        '
        Me.TransTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(282, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 20)
        Me.TextBox1.TabIndex = 1
        '
        'trans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 583)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "trans"
        Me.Text = "trans"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BankDataSet17 As BankingSoftware.bankDataSet17
    Friend WithEvents TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransTableAdapter As BankingSoftware.bankDataSet17TableAdapters.transTableAdapter
    Friend WithEvents NumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tt1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ac1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ac2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
