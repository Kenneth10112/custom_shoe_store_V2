<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAndUpdateMaterials
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panel_modifying_account_elements = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtb_timesUsed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtb_critical = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtb_warning = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtb_stock = New System.Windows.Forms.TextBox()
        Me.cbo_partGroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtb_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Material_addModify_lbl_matID = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.txtb_name = New System.Windows.Forms.TextBox()
        Me.panel_modifying_account_elements.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_modifying_account_elements
        '
        Me.panel_modifying_account_elements.Controls.Add(Me.Label7)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_timesUsed)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label4)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_critical)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label5)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_warning)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label3)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_stock)
        Me.panel_modifying_account_elements.Controls.Add(Me.cbo_partGroup)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label2)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_price)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label1)
        Me.panel_modifying_account_elements.Controls.Add(Me.Button1)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label103)
        Me.panel_modifying_account_elements.Controls.Add(Me.Material_addModify_lbl_matID)
        Me.panel_modifying_account_elements.Controls.Add(Me.Button5)
        Me.panel_modifying_account_elements.Controls.Add(Me.Label101)
        Me.panel_modifying_account_elements.Controls.Add(Me.txtb_name)
        Me.panel_modifying_account_elements.Location = New System.Drawing.Point(16, 15)
        Me.panel_modifying_account_elements.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_modifying_account_elements.Name = "panel_modifying_account_elements"
        Me.panel_modifying_account_elements.Size = New System.Drawing.Size(475, 375)
        Me.panel_modifying_account_elements.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 20)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Times Used: "
        '
        'txtb_timesUsed
        '
        Me.txtb_timesUsed.Location = New System.Drawing.Point(200, 287)
        Me.txtb_timesUsed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_timesUsed.Name = "txtb_timesUsed"
        Me.txtb_timesUsed.Size = New System.Drawing.Size(265, 22)
        Me.txtb_timesUsed.TabIndex = 68
        Me.txtb_timesUsed.Text = "(Times used)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Critical point"
        '
        'txtb_critical
        '
        Me.txtb_critical.Location = New System.Drawing.Point(200, 246)
        Me.txtb_critical.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_critical.Name = "txtb_critical"
        Me.txtb_critical.Size = New System.Drawing.Size(265, 22)
        Me.txtb_critical.TabIndex = 66
        Me.txtb_critical.Text = "(Critical point)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Warning point"
        '
        'txtb_warning
        '
        Me.txtb_warning.Location = New System.Drawing.Point(200, 207)
        Me.txtb_warning.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_warning.Name = "txtb_warning"
        Me.txtb_warning.Size = New System.Drawing.Size(265, 22)
        Me.txtb_warning.TabIndex = 64
        Me.txtb_warning.Text = "(Warning point)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Stock:"
        '
        'txtb_stock
        '
        Me.txtb_stock.Location = New System.Drawing.Point(200, 166)
        Me.txtb_stock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_stock.Name = "txtb_stock"
        Me.txtb_stock.Size = New System.Drawing.Size(265, 22)
        Me.txtb_stock.TabIndex = 62
        Me.txtb_stock.Text = "(Stock)"
        '
        'cbo_partGroup
        '
        Me.cbo_partGroup.FormattingEnabled = True
        Me.cbo_partGroup.Items.AddRange(New Object() {"Body", "insole", "midsole", "outsole", "lace"})
        Me.cbo_partGroup.Location = New System.Drawing.Point(200, 90)
        Me.cbo_partGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_partGroup.Name = "cbo_partGroup"
        Me.cbo_partGroup.Size = New System.Drawing.Size(265, 24)
        Me.cbo_partGroup.TabIndex = 60
        Me.cbo_partGroup.Text = "Part"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Price:"
        '
        'txtb_price
        '
        Me.txtb_price.Location = New System.Drawing.Point(200, 127)
        Me.txtb_price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_price.Name = "txtb_price"
        Me.txtb_price.Size = New System.Drawing.Size(265, 22)
        Me.txtb_price.TabIndex = 57
        Me.txtb_price.Text = "(Price)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Part Group:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 324)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 39)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(10, 11)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(108, 20)
        Me.Label103.TabIndex = 38
        Me.Label103.Text = "Material ID:"
        '
        'Material_addModify_lbl_matID
        '
        Me.Material_addModify_lbl_matID.AutoSize = True
        Me.Material_addModify_lbl_matID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_addModify_lbl_matID.Location = New System.Drawing.Point(124, 11)
        Me.Material_addModify_lbl_matID.Name = "Material_addModify_lbl_matID"
        Me.Material_addModify_lbl_matID.Size = New System.Drawing.Size(98, 20)
        Me.Material_addModify_lbl_matID.TabIndex = 39
        Me.Material_addModify_lbl_matID.Text = "(materialID)"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(8, 324)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(365, 39)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Confirm Changes"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(10, 53)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(137, 20)
        Me.Label101.TabIndex = 40
        Me.Label101.Text = "Material Name:"
        '
        'txtb_name
        '
        Me.txtb_name.Location = New System.Drawing.Point(200, 52)
        Me.txtb_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtb_name.Name = "txtb_name"
        Me.txtb_name.Size = New System.Drawing.Size(265, 22)
        Me.txtb_name.TabIndex = 45
        Me.txtb_name.Text = "(name)"
        '
        'addAndUpdateMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_modifying_account_elements)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "addAndUpdateMaterials"
        Me.Text = "addAndUpdateMaterials"
        Me.panel_modifying_account_elements.ResumeLayout(False)
        Me.panel_modifying_account_elements.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_modifying_account_elements As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label103 As Label
    Friend WithEvents Material_addModify_lbl_matID As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label101 As Label
    Friend WithEvents txtb_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_partGroup As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtb_timesUsed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb_critical As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtb_warning As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtb_stock As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtb_price As TextBox
End Class
