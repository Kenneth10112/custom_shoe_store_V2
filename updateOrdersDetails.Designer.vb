<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updateOrdersDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panel_modifying_account_elements = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtb_newPass = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.cbo_newRole = New System.Windows.Forms.ComboBox()
        Me.Account_modify_lbl_accID = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.txtb_newEmail = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.txtb_newNumber = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.txtb_newAddress = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txtb_newName = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.panel_modifying_account_elements.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_modifying_account_elements
        '
        Me.panel_modifying_account_elements.Controls.Add(Me.Button1)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label1)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_newPass)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label103)
        Me.panel_modifying_account_elements.Controls.Add(Me.cbo_newRole)
        Me.panel_modifying_account_elements.Controls.Add(Me.Account_modify_lbl_accID)
        Me.panel_modifying_account_elements.Controls.Add(Me.Button5)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label101)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_newEmail)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label100)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_newNumber)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label99)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_newAddress)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label98)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_newName)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label89)
        Me.panel_modifying_account_elements.Location = New System.Drawing.Point(12, 12)
        Me.panel_modifying_account_elements.Name = "panel_modifying_account_elements"
        Me.panel_modifying_account_elements.Size = New System.Drawing.Size(356, 268)
        Me.panel_modifying_account_elements.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 228)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 32)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 17)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "New Account Password:"
        '
        'txtb_newPass
        '
        Me.txtb_newPass.Location = New System.Drawing.Point(189, 179)
        Me.txtb_newPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtb_newPass.Name = "txtb_newPass"
        Me.txtb_newPass.Size = New System.Drawing.Size(161, 20)
        Me.txtb_newPass.TabIndex = 52
        Me.txtb_newPass.Text = "(name)"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(5, 5)
        Me.Label103.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(75, 17)
        Me.Label103.TabIndex = 38
        Me.Label103.Text = "Order ID:"
        '
        'cbo_newRole
        '
        Me.cbo_newRole.FormattingEnabled = True
        Me.cbo_newRole.Items.AddRange(New Object() {"admin", "employee", "customer"})
        Me.cbo_newRole.Location = New System.Drawing.Point(154, 146)
        Me.cbo_newRole.Name = "cbo_newRole"
        Me.cbo_newRole.Size = New System.Drawing.Size(195, 21)
        Me.cbo_newRole.TabIndex = 50
        Me.cbo_newRole.Text = "Roles"
        '
        'Account_modify_lbl_accID
        '
        Me.Account_modify_lbl_accID.AutoSize = True
        Me.Account_modify_lbl_accID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_modify_lbl_accID.Location = New System.Drawing.Point(93, 5)
        Me.Account_modify_lbl_accID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_modify_lbl_accID.Name = "Account_modify_lbl_accID"
        Me.Account_modify_lbl_accID.Size = New System.Drawing.Size(91, 17)
        Me.Account_modify_lbl_accID.TabIndex = 39
        Me.Account_modify_lbl_accID.Text = "(CustomerID)"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 228)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(274, 32)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Confirm Changes"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(5, 33)
        Me.Label101.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(152, 17)
        Me.Label101.TabIndex = 40
        Me.Label101.Text = "New Account Name:"
        '
        'txtb_newEmail
        '
        Me.txtb_newEmail.Location = New System.Drawing.Point(159, 117)
        Me.txtb_newEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtb_newEmail.Name = "txtb_newEmail"
        Me.txtb_newEmail.Size = New System.Drawing.Size(191, 20)
        Me.txtb_newEmail.TabIndex = 48
        Me.txtb_newEmail.Text = "(Email)"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(5, 59)
        Me.Label100.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(170, 17)
        Me.Label100.TabIndex = 41
        Me.Label100.Text = "New Account Address:"
        '
        'txtb_newNumber
        '
        Me.txtb_newNumber.Location = New System.Drawing.Point(234, 88)
        Me.txtb_newNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtb_newNumber.Name = "txtb_newNumber"
        Me.txtb_newNumber.Size = New System.Drawing.Size(116, 20)
        Me.txtb_newNumber.TabIndex = 47
        Me.txtb_newNumber.Text = "(Contact number)"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(5, 88)
        Me.Label99.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(225, 17)
        Me.Label99.TabIndex = 42
        Me.Label99.Text = "New Account Contact number:"
        '
        'txtb_newAddress
        '
        Me.txtb_newAddress.Location = New System.Drawing.Point(180, 59)
        Me.txtb_newAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtb_newAddress.Name = "txtb_newAddress"
        Me.txtb_newAddress.Size = New System.Drawing.Size(170, 20)
        Me.txtb_newAddress.TabIndex = 46
        Me.txtb_newAddress.Text = "(Address)"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(5, 117)
        Me.Label98.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(150, 17)
        Me.Label98.TabIndex = 43
        Me.Label98.Text = "New Account Email:"
        '
        'txtb_newName
        '
        Me.txtb_newName.Location = New System.Drawing.Point(161, 30)
        Me.txtb_newName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtb_newName.Name = "txtb_newName"
        Me.txtb_newName.Size = New System.Drawing.Size(189, 20)
        Me.txtb_newName.TabIndex = 45
        Me.txtb_newName.Text = "(name)"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(5, 146)
        Me.Label89.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(144, 17)
        Me.Label89.TabIndex = 44
        Me.Label89.Text = "New Account Role:"
        '
        'updateOrdersDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_modifying_account_elements)
        Me.Name = "updateOrdersDetails"
        Me.Text = "updateOrdersDetails"
        Me.panel_modifying_account_elements.ResumeLayout(False)
        Me.panel_modifying_account_elements.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_modifying_account_elements As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtb_newPass As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents cbo_newRole As ComboBox
    Friend WithEvents Account_modify_lbl_accID As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label101 As Label
    Friend WithEvents txtb_newEmail As TextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents txtb_newNumber As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents txtb_newAddress As TextBox
    Friend WithEvents Label98 As Label
    Friend WithEvents txtb_newName As TextBox
    Friend WithEvents Label89 As Label
End Class
