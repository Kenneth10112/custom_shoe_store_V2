<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectCustomer
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Accounts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_sortBy = New System.Windows.Forms.ComboBox()
        Me.txtb_input = New System.Windows.Forms.TextBox()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Accounts)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 379)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.back)
        Me.Panel2.Controls.Add(Me.btn_select)
        Me.Panel2.Controls.Add(Me.txtb_input)
        Me.Panel2.Controls.Add(Me.cbo_sortBy)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 40)
        Me.Panel2.TabIndex = 1
        '
        'Accounts
        '
        Me.Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Accounts.Location = New System.Drawing.Point(4, 4)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Size = New System.Drawing.Size(769, 372)
        Me.Accounts.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sort By:"
        '
        'cbo_sortBy
        '
        Me.cbo_sortBy.FormattingEnabled = True
        Me.cbo_sortBy.Items.AddRange(New Object() {"account_id", "username", "address", "contact_number", "email"})
        Me.cbo_sortBy.Location = New System.Drawing.Point(78, 11)
        Me.cbo_sortBy.Name = "cbo_sortBy"
        Me.cbo_sortBy.Size = New System.Drawing.Size(141, 21)
        Me.cbo_sortBy.TabIndex = 1
        '
        'txtb_input
        '
        Me.txtb_input.Location = New System.Drawing.Point(225, 11)
        Me.txtb_input.Name = "txtb_input"
        Me.txtb_input.Size = New System.Drawing.Size(135, 20)
        Me.txtb_input.TabIndex = 2
        '
        'btn_select
        '
        Me.btn_select.Location = New System.Drawing.Point(565, 9)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(98, 23)
        Me.btn_select.TabIndex = 1
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(669, 10)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(98, 23)
        Me.back.TabIndex = 3
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'selectCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "selectCustomer"
        Me.Text = "selectCustomer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Accounts As DataGridView
    Friend WithEvents btn_select As Button
    Friend WithEvents txtb_input As TextBox
    Friend WithEvents cbo_sortBy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents back As Button
End Class
