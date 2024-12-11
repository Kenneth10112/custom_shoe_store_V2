<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
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
        Me.Amount_To_be_paid = New System.Windows.Forms.Label()
        Me.paymentAmount = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.back)
        Me.Panel1.Controls.Add(Me.btn_pay)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.paymentAmount)
        Me.Panel1.Controls.Add(Me.Amount_To_be_paid)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 166)
        Me.Panel1.TabIndex = 0
        '
        'Amount_To_be_paid
        '
        Me.Amount_To_be_paid.AutoSize = True
        Me.Amount_To_be_paid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_To_be_paid.Location = New System.Drawing.Point(11, 8)
        Me.Amount_To_be_paid.Name = "Amount_To_be_paid"
        Me.Amount_To_be_paid.Size = New System.Drawing.Size(208, 24)
        Me.Amount_To_be_paid.TabIndex = 1
        Me.Amount_To_be_paid.Text = "Amount To be Paid:  "
        '
        'paymentAmount
        '
        Me.paymentAmount.AutoSize = True
        Me.paymentAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentAmount.Location = New System.Drawing.Point(11, 53)
        Me.paymentAmount.Name = "paymentAmount"
        Me.paymentAmount.Size = New System.Drawing.Size(174, 24)
        Me.paymentAmount.TabIndex = 2
        Me.paymentAmount.Text = "Payment Amount:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 20)
        Me.TextBox1.TabIndex = 3
        '
        'btn_pay
        '
        Me.btn_pay.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_pay.Location = New System.Drawing.Point(15, 114)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(233, 41)
        Me.btn_pay.TabIndex = 4
        Me.btn_pay.Text = "Pay"
        Me.btn_pay.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.back.Location = New System.Drawing.Point(254, 114)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(91, 41)
        Me.back.TabIndex = 5
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = False
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "payment"
        Me.Text = "payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_pay As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents paymentAmount As Label
    Friend WithEvents Amount_To_be_paid As Label
    Friend WithEvents back As Button
End Class
