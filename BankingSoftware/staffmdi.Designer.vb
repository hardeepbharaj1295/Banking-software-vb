<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffmdi
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ADDNEWCUSTOMRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaleCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.AddMoneyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PickMoneyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransferMoneyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InterestTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDNEWCUSTOMRToolStripMenuItem, Me.FindToolStripMenuItem, Me.CloseToolStripMenuItem3, Me.CToolStripMenuItem, Me.TimeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ADDNEWCUSTOMRToolStripMenuItem
        '
        Me.ADDNEWCUSTOMRToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.CloseToolStripMenuItem, Me.CloseToolStripMenuItem4})
        Me.ADDNEWCUSTOMRToolStripMenuItem.Name = "ADDNEWCUSTOMRToolStripMenuItem"
        Me.ADDNEWCUSTOMRToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.ADDNEWCUSTOMRToolStripMenuItem.Text = "Customer"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.AddToolStripMenuItem.Text = "Add New"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.UpdateToolStripMenuItem.Text = "Update "
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CloseToolStripMenuItem.Text = "Atm "
        '
        'CloseToolStripMenuItem4
        '
        Me.CloseToolStripMenuItem4.Name = "CloseToolStripMenuItem4"
        Me.CloseToolStripMenuItem4.Size = New System.Drawing.Size(121, 22)
        Me.CloseToolStripMenuItem4.Text = "Close"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaleCustomerToolStripMenuItem, Me.CustListToolStripMenuItem})
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(39, 23)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'MaleCustomerToolStripMenuItem
        '
        Me.MaleCustomerToolStripMenuItem.Name = "MaleCustomerToolStripMenuItem"
        Me.MaleCustomerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MaleCustomerToolStripMenuItem.Text = "Male Customer"
        '
        'CustListToolStripMenuItem
        '
        Me.CustListToolStripMenuItem.Name = "CustListToolStripMenuItem"
        Me.CustListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustListToolStripMenuItem.Text = "Customer List"
        '
        'CloseToolStripMenuItem3
        '
        Me.CloseToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMoneyToolStripMenuItem, Me.PickMoneyToolStripMenuItem, Me.TransferMoneyToolStripMenuItem, Me.CheckBalanceToolStripMenuItem, Me.InterestTimeToolStripMenuItem})
        Me.CloseToolStripMenuItem3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseToolStripMenuItem3.Name = "CloseToolStripMenuItem3"
        Me.CloseToolStripMenuItem3.Size = New System.Drawing.Size(75, 23)
        Me.CloseToolStripMenuItem3.Text = "Transaction"
        '
        'AddMoneyToolStripMenuItem
        '
        Me.AddMoneyToolStripMenuItem.Name = "AddMoneyToolStripMenuItem"
        Me.AddMoneyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AddMoneyToolStripMenuItem.Text = "Add money"
        '
        'PickMoneyToolStripMenuItem
        '
        Me.PickMoneyToolStripMenuItem.Name = "PickMoneyToolStripMenuItem"
        Me.PickMoneyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PickMoneyToolStripMenuItem.Text = "Pick money"
        '
        'TransferMoneyToolStripMenuItem
        '
        Me.TransferMoneyToolStripMenuItem.Name = "TransferMoneyToolStripMenuItem"
        Me.TransferMoneyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TransferMoneyToolStripMenuItem.Text = "Transfer money"
        '
        'CheckBalanceToolStripMenuItem
        '
        Me.CheckBalanceToolStripMenuItem.Name = "CheckBalanceToolStripMenuItem"
        Me.CheckBalanceToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CheckBalanceToolStripMenuItem.Text = "Check balance"
        '
        'InterestTimeToolStripMenuItem
        '
        Me.InterestTimeToolStripMenuItem.Name = "InterestTimeToolStripMenuItem"
        Me.InterestTimeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.InterestTimeToolStripMenuItem.Text = "Interest Time"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(73, 23)
        Me.CToolStripMenuItem.Text = "CLOSE"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TimeToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.TimeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(58, 23)
        Me.TimeToolStripMenuItem.Text = "time"
        Me.TimeToolStripMenuItem.ToolTipText = "Current Time."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem1, Me.CloseToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 48)
        '
        'CloseToolStripMenuItem1
        '
        Me.CloseToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        Me.CloseToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.CloseToolStripMenuItem1.Text = "Refresh"
        '
        'CloseToolStripMenuItem2
        '
        Me.CloseToolStripMenuItem2.BackColor = System.Drawing.Color.White
        Me.CloseToolStripMenuItem2.Name = "CloseToolStripMenuItem2"
        Me.CloseToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.CloseToolStripMenuItem2.Text = "Close"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(438, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "5111541661652165229"
        '
        'staffmdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.BankingSoftware.My.Resources.Resources.ANZ_Bank_counter1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "staffmdi"
        Me.Text = "Staff Section"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ADDNEWCUSTOMRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaleCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMoneyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PickMoneyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferMoneyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InterestTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
