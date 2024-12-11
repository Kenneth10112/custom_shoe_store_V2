<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SampleCustomer1 created a new order (SampleOrder1)")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SampleCustomer1 edited their chosen shoe/s")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("SampleCustomer1 completed their account details")
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_Dashboard = New System.Windows.Forms.Button()
        Me.btn_Accounts = New System.Windows.Forms.Button()
        Me.btn_CustomizeShoe = New System.Windows.Forms.Button()
        Me.btn_Materials = New System.Windows.Forms.Button()
        Me.btn_Orders = New System.Windows.Forms.Button()
        Me.btn_logs = New System.Windows.Forms.Button()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Orders_allOrders = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Orders_lbl_processStatus = New System.Windows.Forms.Label()
        Me.Orders_lbl_paymentStatus = New System.Windows.Forms.Label()
        Me.Orders_lbl_totalAmount = New System.Windows.Forms.Label()
        Me.Orders_lbl_dueDate = New System.Windows.Forms.Label()
        Me.Orders_lbl_claimMethod = New System.Windows.Forms.Label()
        Me.Orders_lbl_orderDetail = New System.Windows.Forms.Label()
        Me.Orders_lbl_customer = New System.Windows.Forms.Label()
        Me.Orders_lbl_orderID = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Orders_finish_to_settled = New System.Windows.Forms.Button()
        Me.Orders_outgoing_to_settled = New System.Windows.Forms.Button()
        Me.Orders_finish_to_outgoing = New System.Windows.Forms.Button()
        Me.Orders_to_finished = New System.Windows.Forms.Button()
        Me.Orders_to_inProgress = New System.Windows.Forms.Button()
        Me.Orders_outgoing = New System.Windows.Forms.DataGridView()
        Me.Orders_finished = New System.Windows.Forms.DataGridView()
        Me.Orders_inProgress = New System.Windows.Forms.DataGridView()
        Me.Orders_notStarted = New System.Windows.Forms.DataGridView()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Material_btn_deleteMaterial = New System.Windows.Forms.Button()
        Me.Material_btn_updateMaterial = New System.Windows.Forms.Button()
        Me.Material_btn_addMaterial = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Materials_normal = New System.Windows.Forms.DataGridView()
        Me.Materials_warning = New System.Windows.Forms.DataGridView()
        Me.Material_lbl_aveMatPrice = New System.Windows.Forms.Label()
        Me.Material_lbl_lowestPrice = New System.Windows.Forms.Label()
        Me.Materials_critical = New System.Windows.Forms.DataGridView()
        Me.Material_lbl_highestPrice = New System.Windows.Forms.Label()
        Me.Material_lbl_leastUsed = New System.Windows.Forms.Label()
        Me.Material_lbl_normalAmount = New System.Windows.Forms.Label()
        Me.Material_lbl_mostUsed = New System.Windows.Forms.Label()
        Me.Material_lbl_warningAmount = New System.Windows.Forms.Label()
        Me.Material_lbl_criticalAmount = New System.Windows.Forms.Label()
        Me.Materials_allMaterials = New System.Windows.Forms.DataGridView()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.RTB_summary = New System.Windows.Forms.RichTextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.CustomizeShoe_btn_selectCustomer = New System.Windows.Forms.Button()
        Me.CustomizeShoe_viewSummary = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.CustomizeShoe_cbo_lace = New System.Windows.Forms.ComboBox()
        Me.CustomizeShoe_cbo_midsole = New System.Windows.Forms.ComboBox()
        Me.CustomizeShoe_cbo_outsole = New System.Windows.Forms.ComboBox()
        Me.CustomizeShoe_cbo_insole = New System.Windows.Forms.ComboBox()
        Me.CustomizeShoe_cbo_body = New System.Windows.Forms.ComboBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.CustomizeShoe_lbl_customer = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Accounts_allAccounts = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Accounts_btn_editDetails = New System.Windows.Forms.Button()
        Me.Account_lbl_pass = New System.Windows.Forms.Label()
        Me.Account_lbl_role = New System.Windows.Forms.Label()
        Me.Account_lbl_email = New System.Windows.Forms.Label()
        Me.Account_lbl_contactNum = New System.Windows.Forms.Label()
        Me.Account_lbl_address = New System.Windows.Forms.Label()
        Me.Account_lbl_name = New System.Windows.Forms.Label()
        Me.Accounts_allOrders = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Account_lbl_ordersCount = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Account_lbl_creationDate = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Account_lbl_accID = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Dashboard_Sales_soldProductCount = New System.Windows.Forms.Label()
        Me.Dashboard_Sales_totalSales = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Dashboard_Stocks_normal = New System.Windows.Forms.DataGridView()
        Me.Dashboard_Stocks_warning = New System.Windows.Forms.DataGridView()
        Me.Dashboard_Stocks_critical = New System.Windows.Forms.DataGridView()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dashboard_Orders_outgoing = New System.Windows.Forms.DataGridView()
        Me.Dashboard_Orders_finished = New System.Windows.Forms.DataGridView()
        Me.Dashboard_Orders_inProgress = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Dashboard_Orders_notStarted = New System.Windows.Forms.DataGridView()
        Me.Dashboard_Orders_lbl_outgoing = New System.Windows.Forms.Label()
        Me.Dashboard_Orders_lbl_finished = New System.Windows.Forms.Label()
        Me.Dashboard_Orders_lbl_inProgress = New System.Windows.Forms.Label()
        Me.Dashboard_Orders_lbl_notStarted = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.CustomizeShoe_cbo_claimMethod = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.Orders_allOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.Orders_outgoing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Orders_finished, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Orders_inProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Orders_notStarted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.Materials_normal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Materials_warning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Materials_critical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Materials_allMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Accounts_allAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.Accounts_allOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Dashboard_Stocks_normal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dashboard_Stocks_warning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dashboard_Stocks_critical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Dashboard_Orders_outgoing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dashboard_Orders_finished, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dashboard_Orders_inProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dashboard_Orders_notStarted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Dashboard)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Accounts)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_CustomizeShoe)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Materials)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Orders)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_logs)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Login)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Exit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_refresh)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 126)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(152, 534)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btn_Dashboard
        '
        Me.btn_Dashboard.Location = New System.Drawing.Point(8, 8)
        Me.btn_Dashboard.Name = "btn_Dashboard"
        Me.btn_Dashboard.Size = New System.Drawing.Size(135, 23)
        Me.btn_Dashboard.TabIndex = 0
        Me.btn_Dashboard.Text = "Dashboard"
        Me.btn_Dashboard.UseVisualStyleBackColor = True
        '
        'btn_Accounts
        '
        Me.btn_Accounts.Location = New System.Drawing.Point(8, 37)
        Me.btn_Accounts.Name = "btn_Accounts"
        Me.btn_Accounts.Size = New System.Drawing.Size(135, 23)
        Me.btn_Accounts.TabIndex = 1
        Me.btn_Accounts.Text = "Accounts"
        Me.btn_Accounts.UseVisualStyleBackColor = True
        '
        'btn_CustomizeShoe
        '
        Me.btn_CustomizeShoe.Location = New System.Drawing.Point(8, 66)
        Me.btn_CustomizeShoe.Name = "btn_CustomizeShoe"
        Me.btn_CustomizeShoe.Size = New System.Drawing.Size(135, 23)
        Me.btn_CustomizeShoe.TabIndex = 2
        Me.btn_CustomizeShoe.Text = "Customize Shoe"
        Me.btn_CustomizeShoe.UseVisualStyleBackColor = True
        '
        'btn_Materials
        '
        Me.btn_Materials.Location = New System.Drawing.Point(8, 95)
        Me.btn_Materials.Name = "btn_Materials"
        Me.btn_Materials.Size = New System.Drawing.Size(135, 23)
        Me.btn_Materials.TabIndex = 3
        Me.btn_Materials.Text = "Materials"
        Me.btn_Materials.UseVisualStyleBackColor = True
        '
        'btn_Orders
        '
        Me.btn_Orders.Location = New System.Drawing.Point(8, 124)
        Me.btn_Orders.Name = "btn_Orders"
        Me.btn_Orders.Size = New System.Drawing.Size(135, 23)
        Me.btn_Orders.TabIndex = 4
        Me.btn_Orders.Text = "Orders"
        Me.btn_Orders.UseVisualStyleBackColor = True
        '
        'btn_logs
        '
        Me.btn_logs.Location = New System.Drawing.Point(8, 153)
        Me.btn_logs.Name = "btn_logs"
        Me.btn_logs.Size = New System.Drawing.Size(135, 23)
        Me.btn_logs.TabIndex = 5
        Me.btn_logs.Text = "logs"
        Me.btn_logs.UseVisualStyleBackColor = True
        '
        'btn_Login
        '
        Me.btn_Login.Location = New System.Drawing.Point(8, 182)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(135, 23)
        Me.btn_Login.TabIndex = 6
        Me.btn_Login.Text = "SignUp / Login"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(8, 211)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(135, 26)
        Me.btn_Exit.TabIndex = 7
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(8, 243)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(135, 26)
        Me.btn_refresh.TabIndex = 8
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label64)
        Me.Panel1.Controls.Add(Me.Label65)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 126)
        Me.Panel1.TabIndex = 1
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(41, 72)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(78, 16)
        Me.Label64.TabIndex = 27
        Me.Label64.Text = "Admin User"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(10, 25)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(142, 31)
        Me.Label65.TabIndex = 26
        Me.Label65.Text = "Welcome!"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ListView3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1165, 634)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.HideSelection = False
        Me.ListView3.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView3.Location = New System.Drawing.Point(0, 0)
        Me.ListView3.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(1165, 634)
        Me.ListView3.TabIndex = 0
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Logs"
        Me.ColumnHeader8.Width = 1550
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Panel7)
        Me.TabPage5.Controls.Add(Me.Orders_allOrders)
        Me.TabPage5.Controls.Add(Me.Panel9)
        Me.TabPage5.Controls.Add(Me.Panel8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1165, 634)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Silver
        Me.Panel7.Location = New System.Drawing.Point(872, 357)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(293, 277)
        Me.Panel7.TabIndex = 3
        '
        'Orders_allOrders
        '
        Me.Orders_allOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Orders_allOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Orders_allOrders.Location = New System.Drawing.Point(0, 3)
        Me.Orders_allOrders.MultiSelect = False
        Me.Orders_allOrders.Name = "Orders_allOrders"
        Me.Orders_allOrders.ReadOnly = True
        Me.Orders_allOrders.RowHeadersWidth = 51
        Me.Orders_allOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Orders_allOrders.Size = New System.Drawing.Size(809, 350)
        Me.Orders_allOrders.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel9.Controls.Add(Me.Orders_lbl_processStatus)
        Me.Panel9.Controls.Add(Me.Orders_lbl_paymentStatus)
        Me.Panel9.Controls.Add(Me.Orders_lbl_totalAmount)
        Me.Panel9.Controls.Add(Me.Orders_lbl_dueDate)
        Me.Panel9.Controls.Add(Me.Orders_lbl_claimMethod)
        Me.Panel9.Controls.Add(Me.Orders_lbl_orderDetail)
        Me.Panel9.Controls.Add(Me.Orders_lbl_customer)
        Me.Panel9.Controls.Add(Me.Orders_lbl_orderID)
        Me.Panel9.Location = New System.Drawing.Point(814, 3)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(353, 350)
        Me.Panel9.TabIndex = 2
        '
        'Orders_lbl_processStatus
        '
        Me.Orders_lbl_processStatus.AutoSize = True
        Me.Orders_lbl_processStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orders_lbl_processStatus.Location = New System.Drawing.Point(15, 174)
        Me.Orders_lbl_processStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Orders_lbl_processStatus.Name = "Orders_lbl_processStatus"
        Me.Orders_lbl_processStatus.Size = New System.Drawing.Size(122, 17)
        Me.Orders_lbl_processStatus.TabIndex = 19
        Me.Orders_lbl_processStatus.Text = "Process Status:"
        '
        'Orders_lbl_paymentStatus
        '
        Me.Orders_lbl_paymentStatus.AutoSize = True
        Me.Orders_lbl_paymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orders_lbl_paymentStatus.Location = New System.Drawing.Point(15, 152)
        Me.Orders_lbl_paymentStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Orders_lbl_paymentStatus.Name = "Orders_lbl_paymentStatus"
        Me.Orders_lbl_paymentStatus.Size = New System.Drawing.Size(126, 17)
        Me.Orders_lbl_paymentStatus.TabIndex = 12
        Me.Orders_lbl_paymentStatus.Text = "Payment Status:"
        '
        'Orders_lbl_totalAmount
        '
        Me.Orders_lbl_totalAmount.AutoSize = True
        Me.Orders_lbl_totalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orders_lbl_totalAmount.Location = New System.Drawing.Point(15, 129)
        Me.Orders_lbl_totalAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Orders_lbl_totalAmount.Name = "Orders_lbl_totalAmount"
        Me.Orders_lbl_totalAmount.Size = New System.Drawing.Size(156, 17)
        Me.Orders_lbl_totalAmount.TabIndex = 10
        Me.Orders_lbl_totalAmount.Text = "Order Total Amount:"
        '
        'Orders_lbl_dueDate
        '
        Me.Orders_lbl_dueDate.AutoSize = True
        Me.Orders_lbl_dueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orders_lbl_dueDate.Location = New System.Drawing.Point(15, 106)
        Me.Orders_lbl_dueDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Orders_lbl_dueDate.Name = "Orders_lbl_dueDate"
        Me.Orders_lbl_dueDate.Size = New System.Drawing.Size(81, 17)
        Me.Orders_lbl_dueDate.TabIndex = 8
        Me.Orders_lbl_dueDate.Text = "Due Date:"
        '
        'Orders_lbl_claimMethod
        '
        Me.Orders_lbl_claimMethod.AutoSize = True
        Me.Orders_lbl_claimMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orders_lbl_claimMethod.Location = New System.Drawing.Point(15, 85)
        Me.Orders_lbl_claimMethod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Orders_lbl_claimMethod.Name = "Orders_lbl_claimMethod"
        Me.Orders_lbl_claimMethod.Size = New System.Drawing.Size(110, 17)
        Me.Orders_lbl_claimMethod.TabIndex = 6
        Me.Orders_lbl_claimMethod.Text = "Claim Method:"
        '
        'Orders_lbl_orderDetail
        '
        Me.Orders_lbl_orderDetail.AutoSize = True
        Me.Orders_lbl_orderDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orders_lbl_orderDetail.Location = New System.Drawing.Point(15, 63)
        Me.Orders_lbl_orderDetail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Orders_lbl_orderDetail.Name = "Orders_lbl_orderDetail"
        Me.Orders_lbl_orderDetail.Size = New System.Drawing.Size(110, 17)
        Me.Orders_lbl_orderDetail.TabIndex = 4
        Me.Orders_lbl_orderDetail.Text = "Order Details:"
        '
        'Orders_lbl_customer
        '
        Me.Orders_lbl_customer.AutoSize = True
        Me.Orders_lbl_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orders_lbl_customer.Location = New System.Drawing.Point(15, 41)
        Me.Orders_lbl_customer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Orders_lbl_customer.Name = "Orders_lbl_customer"
        Me.Orders_lbl_customer.Size = New System.Drawing.Size(101, 17)
        Me.Orders_lbl_customer.TabIndex = 2
        Me.Orders_lbl_customer.Text = "Customer ID:"
        '
        'Orders_lbl_orderID
        '
        Me.Orders_lbl_orderID.AutoSize = True
        Me.Orders_lbl_orderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orders_lbl_orderID.Location = New System.Drawing.Point(15, 19)
        Me.Orders_lbl_orderID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Orders_lbl_orderID.Name = "Orders_lbl_orderID"
        Me.Orders_lbl_orderID.Size = New System.Drawing.Size(75, 17)
        Me.Orders_lbl_orderID.TabIndex = 0
        Me.Orders_lbl_orderID.Text = "Order ID:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel8.Controls.Add(Me.Orders_finish_to_settled)
        Me.Panel8.Controls.Add(Me.Orders_outgoing_to_settled)
        Me.Panel8.Controls.Add(Me.Orders_finish_to_outgoing)
        Me.Panel8.Controls.Add(Me.Orders_to_finished)
        Me.Panel8.Controls.Add(Me.Orders_to_inProgress)
        Me.Panel8.Controls.Add(Me.Orders_outgoing)
        Me.Panel8.Controls.Add(Me.Orders_finished)
        Me.Panel8.Controls.Add(Me.Orders_inProgress)
        Me.Panel8.Controls.Add(Me.Orders_notStarted)
        Me.Panel8.Controls.Add(Me.Label80)
        Me.Panel8.Controls.Add(Me.Label84)
        Me.Panel8.Controls.Add(Me.Label86)
        Me.Panel8.Controls.Add(Me.Label88)
        Me.Panel8.Location = New System.Drawing.Point(0, 357)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(872, 282)
        Me.Panel8.TabIndex = 1
        '
        'Orders_finish_to_settled
        '
        Me.Orders_finish_to_settled.Location = New System.Drawing.Point(438, 34)
        Me.Orders_finish_to_settled.Name = "Orders_finish_to_settled"
        Me.Orders_finish_to_settled.Size = New System.Drawing.Size(102, 23)
        Me.Orders_finish_to_settled.TabIndex = 42
        Me.Orders_finish_to_settled.Text = "Send to Settled"
        Me.Orders_finish_to_settled.UseVisualStyleBackColor = True
        '
        'Orders_outgoing_to_settled
        '
        Me.Orders_outgoing_to_settled.Location = New System.Drawing.Point(652, 34)
        Me.Orders_outgoing_to_settled.Name = "Orders_outgoing_to_settled"
        Me.Orders_outgoing_to_settled.Size = New System.Drawing.Size(102, 23)
        Me.Orders_outgoing_to_settled.TabIndex = 41
        Me.Orders_outgoing_to_settled.Text = "Send to Settled"
        Me.Orders_outgoing_to_settled.UseVisualStyleBackColor = True
        '
        'Orders_finish_to_outgoing
        '
        Me.Orders_finish_to_outgoing.Location = New System.Drawing.Point(544, 34)
        Me.Orders_finish_to_outgoing.Name = "Orders_finish_to_outgoing"
        Me.Orders_finish_to_outgoing.Size = New System.Drawing.Size(102, 23)
        Me.Orders_finish_to_outgoing.TabIndex = 40
        Me.Orders_finish_to_outgoing.Text = "Send to Outgoing"
        Me.Orders_finish_to_outgoing.UseVisualStyleBackColor = True
        '
        'Orders_to_finished
        '
        Me.Orders_to_finished.Location = New System.Drawing.Point(224, 34)
        Me.Orders_to_finished.Name = "Orders_to_finished"
        Me.Orders_to_finished.Size = New System.Drawing.Size(125, 23)
        Me.Orders_to_finished.TabIndex = 39
        Me.Orders_to_finished.Text = "Send to Finished"
        Me.Orders_to_finished.UseVisualStyleBackColor = True
        '
        'Orders_to_inProgress
        '
        Me.Orders_to_inProgress.Location = New System.Drawing.Point(10, 34)
        Me.Orders_to_inProgress.Name = "Orders_to_inProgress"
        Me.Orders_to_inProgress.Size = New System.Drawing.Size(125, 23)
        Me.Orders_to_inProgress.TabIndex = 4
        Me.Orders_to_inProgress.Text = "Send to In_progress"
        Me.Orders_to_inProgress.UseVisualStyleBackColor = True
        '
        'Orders_outgoing
        '
        Me.Orders_outgoing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Orders_outgoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Orders_outgoing.Location = New System.Drawing.Point(652, 63)
        Me.Orders_outgoing.MultiSelect = False
        Me.Orders_outgoing.Name = "Orders_outgoing"
        Me.Orders_outgoing.ReadOnly = True
        Me.Orders_outgoing.RowHeadersWidth = 51
        Me.Orders_outgoing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Orders_outgoing.Size = New System.Drawing.Size(208, 208)
        Me.Orders_outgoing.TabIndex = 38
        '
        'Orders_finished
        '
        Me.Orders_finished.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Orders_finished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Orders_finished.Location = New System.Drawing.Point(438, 63)
        Me.Orders_finished.MultiSelect = False
        Me.Orders_finished.Name = "Orders_finished"
        Me.Orders_finished.ReadOnly = True
        Me.Orders_finished.RowHeadersWidth = 51
        Me.Orders_finished.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Orders_finished.Size = New System.Drawing.Size(208, 208)
        Me.Orders_finished.TabIndex = 37
        '
        'Orders_inProgress
        '
        Me.Orders_inProgress.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Orders_inProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Orders_inProgress.Location = New System.Drawing.Point(224, 63)
        Me.Orders_inProgress.MultiSelect = False
        Me.Orders_inProgress.Name = "Orders_inProgress"
        Me.Orders_inProgress.ReadOnly = True
        Me.Orders_inProgress.RowHeadersWidth = 51
        Me.Orders_inProgress.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Orders_inProgress.Size = New System.Drawing.Size(208, 208)
        Me.Orders_inProgress.TabIndex = 36
        '
        'Orders_notStarted
        '
        Me.Orders_notStarted.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Orders_notStarted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Orders_notStarted.Location = New System.Drawing.Point(10, 63)
        Me.Orders_notStarted.MultiSelect = False
        Me.Orders_notStarted.Name = "Orders_notStarted"
        Me.Orders_notStarted.ReadOnly = True
        Me.Orders_notStarted.RowHeadersWidth = 51
        Me.Orders_notStarted.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Orders_notStarted.Size = New System.Drawing.Size(208, 208)
        Me.Orders_notStarted.TabIndex = 35
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(649, 13)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(70, 16)
        Me.Label80.TabIndex = 32
        Me.Label80.Text = "Outgoing"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(435, 13)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(67, 16)
        Me.Label84.TabIndex = 30
        Me.Label84.Text = "Finished"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(221, 15)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(86, 16)
        Me.Label86.TabIndex = 28
        Me.Label86.Text = "In progress"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(7, 15)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(84, 16)
        Me.Label88.TabIndex = 26
        Me.Label88.Text = "Not started"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel15)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1165, 634)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Material_btn_deleteMaterial)
        Me.Panel15.Controls.Add(Me.Material_btn_updateMaterial)
        Me.Panel15.Controls.Add(Me.Material_btn_addMaterial)
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.Materials_allMaterials)
        Me.Panel15.Controls.Add(Me.Label115)
        Me.Panel15.Location = New System.Drawing.Point(5, 4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1152, 621)
        Me.Panel15.TabIndex = 0
        '
        'Material_btn_deleteMaterial
        '
        Me.Material_btn_deleteMaterial.Location = New System.Drawing.Point(721, 282)
        Me.Material_btn_deleteMaterial.Name = "Material_btn_deleteMaterial"
        Me.Material_btn_deleteMaterial.Size = New System.Drawing.Size(420, 108)
        Me.Material_btn_deleteMaterial.TabIndex = 57
        Me.Material_btn_deleteMaterial.Text = "Delete Material"
        Me.Material_btn_deleteMaterial.UseVisualStyleBackColor = True
        '
        'Material_btn_updateMaterial
        '
        Me.Material_btn_updateMaterial.Location = New System.Drawing.Point(721, 179)
        Me.Material_btn_updateMaterial.Name = "Material_btn_updateMaterial"
        Me.Material_btn_updateMaterial.Size = New System.Drawing.Size(420, 97)
        Me.Material_btn_updateMaterial.TabIndex = 56
        Me.Material_btn_updateMaterial.Text = "Update Material"
        Me.Material_btn_updateMaterial.UseVisualStyleBackColor = True
        '
        'Material_btn_addMaterial
        '
        Me.Material_btn_addMaterial.Location = New System.Drawing.Point(721, 63)
        Me.Material_btn_addMaterial.Name = "Material_btn_addMaterial"
        Me.Material_btn_addMaterial.Size = New System.Drawing.Size(420, 110)
        Me.Material_btn_addMaterial.TabIndex = 55
        Me.Material_btn_addMaterial.Text = "Add Material"
        Me.Material_btn_addMaterial.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Label2)
        Me.Panel16.Controls.Add(Me.Label3)
        Me.Panel16.Controls.Add(Me.Label4)
        Me.Panel16.Controls.Add(Me.Materials_normal)
        Me.Panel16.Controls.Add(Me.Materials_warning)
        Me.Panel16.Controls.Add(Me.Material_lbl_aveMatPrice)
        Me.Panel16.Controls.Add(Me.Material_lbl_lowestPrice)
        Me.Panel16.Controls.Add(Me.Materials_critical)
        Me.Panel16.Controls.Add(Me.Material_lbl_highestPrice)
        Me.Panel16.Controls.Add(Me.Material_lbl_leastUsed)
        Me.Panel16.Controls.Add(Me.Material_lbl_normalAmount)
        Me.Panel16.Controls.Add(Me.Material_lbl_mostUsed)
        Me.Panel16.Controls.Add(Me.Material_lbl_warningAmount)
        Me.Panel16.Controls.Add(Me.Material_lbl_criticalAmount)
        Me.Panel16.Location = New System.Drawing.Point(14, 397)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1122, 221)
        Me.Panel16.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "warning stock amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "critical stock amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(591, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "normal stock amount"
        '
        'Materials_normal
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Materials_normal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Materials_normal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Materials_normal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Materials_normal.Location = New System.Drawing.Point(589, 27)
        Me.Materials_normal.MultiSelect = False
        Me.Materials_normal.Name = "Materials_normal"
        Me.Materials_normal.ReadOnly = True
        Me.Materials_normal.RowHeadersWidth = 51
        Me.Materials_normal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Materials_normal.Size = New System.Drawing.Size(287, 191)
        Me.Materials_normal.TabIndex = 49
        '
        'Materials_warning
        '
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Materials_warning.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Materials_warning.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Materials_warning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Materials_warning.Location = New System.Drawing.Point(296, 27)
        Me.Materials_warning.MultiSelect = False
        Me.Materials_warning.Name = "Materials_warning"
        Me.Materials_warning.ReadOnly = True
        Me.Materials_warning.RowHeadersWidth = 51
        Me.Materials_warning.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Materials_warning.Size = New System.Drawing.Size(287, 191)
        Me.Materials_warning.TabIndex = 48
        '
        'Material_lbl_aveMatPrice
        '
        Me.Material_lbl_aveMatPrice.AutoSize = True
        Me.Material_lbl_aveMatPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_lbl_aveMatPrice.Location = New System.Drawing.Point(892, 177)
        Me.Material_lbl_aveMatPrice.Name = "Material_lbl_aveMatPrice"
        Me.Material_lbl_aveMatPrice.Size = New System.Drawing.Size(167, 16)
        Me.Material_lbl_aveMatPrice.TabIndex = 8
        Me.Material_lbl_aveMatPrice.Text = "Average Price Material"
        '
        'Material_lbl_lowestPrice
        '
        Me.Material_lbl_lowestPrice.AutoSize = True
        Me.Material_lbl_lowestPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_lbl_lowestPrice.Location = New System.Drawing.Point(892, 139)
        Me.Material_lbl_lowestPrice.Name = "Material_lbl_lowestPrice"
        Me.Material_lbl_lowestPrice.Size = New System.Drawing.Size(156, 16)
        Me.Material_lbl_lowestPrice.TabIndex = 9
        Me.Material_lbl_lowestPrice.Text = "Lowest Price Material"
        '
        'Materials_critical
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Materials_critical.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Materials_critical.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Materials_critical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Materials_critical.Location = New System.Drawing.Point(3, 27)
        Me.Materials_critical.MultiSelect = False
        Me.Materials_critical.Name = "Materials_critical"
        Me.Materials_critical.ReadOnly = True
        Me.Materials_critical.RowHeadersWidth = 51
        Me.Materials_critical.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Materials_critical.Size = New System.Drawing.Size(287, 191)
        Me.Materials_critical.TabIndex = 47
        '
        'Material_lbl_highestPrice
        '
        Me.Material_lbl_highestPrice.AutoSize = True
        Me.Material_lbl_highestPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_lbl_highestPrice.Location = New System.Drawing.Point(892, 102)
        Me.Material_lbl_highestPrice.Name = "Material_lbl_highestPrice"
        Me.Material_lbl_highestPrice.Size = New System.Drawing.Size(177, 16)
        Me.Material_lbl_highestPrice.TabIndex = 7
        Me.Material_lbl_highestPrice.Text = "Most Expensive Material"
        '
        'Material_lbl_leastUsed
        '
        Me.Material_lbl_leastUsed.AutoSize = True
        Me.Material_lbl_leastUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_lbl_leastUsed.Location = New System.Drawing.Point(892, 64)
        Me.Material_lbl_leastUsed.Name = "Material_lbl_leastUsed"
        Me.Material_lbl_leastUsed.Size = New System.Drawing.Size(147, 16)
        Me.Material_lbl_leastUsed.TabIndex = 6
        Me.Material_lbl_leastUsed.Text = "Least Used Material"
        '
        'Material_lbl_normalAmount
        '
        Me.Material_lbl_normalAmount.AutoSize = True
        Me.Material_lbl_normalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_lbl_normalAmount.Location = New System.Drawing.Point(740, 9)
        Me.Material_lbl_normalAmount.Name = "Material_lbl_normalAmount"
        Me.Material_lbl_normalAmount.Size = New System.Drawing.Size(22, 16)
        Me.Material_lbl_normalAmount.TabIndex = 44
        Me.Material_lbl_normalAmount.Text = "10"
        '
        'Material_lbl_mostUsed
        '
        Me.Material_lbl_mostUsed.AutoSize = True
        Me.Material_lbl_mostUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_lbl_mostUsed.Location = New System.Drawing.Point(892, 27)
        Me.Material_lbl_mostUsed.Name = "Material_lbl_mostUsed"
        Me.Material_lbl_mostUsed.Size = New System.Drawing.Size(142, 16)
        Me.Material_lbl_mostUsed.TabIndex = 5
        Me.Material_lbl_mostUsed.Text = "Most Used Material"
        '
        'Material_lbl_warningAmount
        '
        Me.Material_lbl_warningAmount.AutoSize = True
        Me.Material_lbl_warningAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_lbl_warningAmount.Location = New System.Drawing.Point(454, 8)
        Me.Material_lbl_warningAmount.Name = "Material_lbl_warningAmount"
        Me.Material_lbl_warningAmount.Size = New System.Drawing.Size(15, 16)
        Me.Material_lbl_warningAmount.TabIndex = 42
        Me.Material_lbl_warningAmount.Text = "3"
        '
        'Material_lbl_criticalAmount
        '
        Me.Material_lbl_criticalAmount.AutoSize = True
        Me.Material_lbl_criticalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_lbl_criticalAmount.Location = New System.Drawing.Point(156, 9)
        Me.Material_lbl_criticalAmount.Name = "Material_lbl_criticalAmount"
        Me.Material_lbl_criticalAmount.Size = New System.Drawing.Size(15, 16)
        Me.Material_lbl_criticalAmount.TabIndex = 40
        Me.Material_lbl_criticalAmount.Text = "6"
        '
        'Materials_allMaterials
        '
        Me.Materials_allMaterials.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Materials_allMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Materials_allMaterials.Location = New System.Drawing.Point(14, 63)
        Me.Materials_allMaterials.MultiSelect = False
        Me.Materials_allMaterials.Name = "Materials_allMaterials"
        Me.Materials_allMaterials.ReadOnly = True
        Me.Materials_allMaterials.RowHeadersWidth = 51
        Me.Materials_allMaterials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Materials_allMaterials.Size = New System.Drawing.Size(696, 327)
        Me.Materials_allMaterials.TabIndex = 53
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(16, 9)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(191, 46)
        Me.Label115.TabIndex = 0
        Me.Label115.Text = "Inventory"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel13)
        Me.TabPage3.Controls.Add(Me.Panel12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1165, 634)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.RTB_summary)
        Me.Panel13.Controls.Add(Me.Button8)
        Me.Panel13.Location = New System.Drawing.Point(780, 23)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(371, 589)
        Me.Panel13.TabIndex = 3
        '
        'RTB_summary
        '
        Me.RTB_summary.Location = New System.Drawing.Point(17, 18)
        Me.RTB_summary.Name = "RTB_summary"
        Me.RTB_summary.Size = New System.Drawing.Size(337, 489)
        Me.RTB_summary.TabIndex = 8
        Me.RTB_summary.Text = "Summary: (Customization details and costing details will appear here " & Global.Microsoft.VisualBasic.ChrW(10) & "after click" &
    "ing the button on the bottom left)"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(3, 513)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(365, 73)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Finalize"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.DarkGray
        Me.Panel12.Controls.Add(Me.CustomizeShoe_btn_selectCustomer)
        Me.Panel12.Controls.Add(Me.CustomizeShoe_viewSummary)
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Controls.Add(Me.CustomizeShoe_lbl_customer)
        Me.Panel12.Location = New System.Drawing.Point(14, 23)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(760, 589)
        Me.Panel12.TabIndex = 2
        '
        'CustomizeShoe_btn_selectCustomer
        '
        Me.CustomizeShoe_btn_selectCustomer.Location = New System.Drawing.Point(672, 12)
        Me.CustomizeShoe_btn_selectCustomer.Name = "CustomizeShoe_btn_selectCustomer"
        Me.CustomizeShoe_btn_selectCustomer.Size = New System.Drawing.Size(76, 23)
        Me.CustomizeShoe_btn_selectCustomer.TabIndex = 5
        Me.CustomizeShoe_btn_selectCustomer.Text = "Select"
        Me.CustomizeShoe_btn_selectCustomer.UseVisualStyleBackColor = True
        '
        'CustomizeShoe_viewSummary
        '
        Me.CustomizeShoe_viewSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomizeShoe_viewSummary.Location = New System.Drawing.Point(3, 477)
        Me.CustomizeShoe_viewSummary.Name = "CustomizeShoe_viewSummary"
        Me.CustomizeShoe_viewSummary.Size = New System.Drawing.Size(754, 107)
        Me.CustomizeShoe_viewSummary.TabIndex = 4
        Me.CustomizeShoe_viewSummary.Text = "View Summary"
        Me.CustomizeShoe_viewSummary.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Controls.Add(Me.CustomizeShoe_cbo_claimMethod)
        Me.Panel14.Controls.Add(Me.Label5)
        Me.Panel14.Controls.Add(Me.CustomizeShoe_cbo_lace)
        Me.Panel14.Controls.Add(Me.CustomizeShoe_cbo_midsole)
        Me.Panel14.Controls.Add(Me.CustomizeShoe_cbo_outsole)
        Me.Panel14.Controls.Add(Me.CustomizeShoe_cbo_insole)
        Me.Panel14.Controls.Add(Me.CustomizeShoe_cbo_body)
        Me.Panel14.Controls.Add(Me.Label114)
        Me.Panel14.Controls.Add(Me.Label113)
        Me.Panel14.Controls.Add(Me.Label112)
        Me.Panel14.Controls.Add(Me.Label111)
        Me.Panel14.Controls.Add(Me.Label110)
        Me.Panel14.Controls.Add(Me.Label109)
        Me.Panel14.Location = New System.Drawing.Point(3, 46)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(754, 427)
        Me.Panel14.TabIndex = 3
        '
        'CustomizeShoe_cbo_lace
        '
        Me.CustomizeShoe_cbo_lace.FormattingEnabled = True
        Me.CustomizeShoe_cbo_lace.Location = New System.Drawing.Point(111, 247)
        Me.CustomizeShoe_cbo_lace.Name = "CustomizeShoe_cbo_lace"
        Me.CustomizeShoe_cbo_lace.Size = New System.Drawing.Size(121, 21)
        Me.CustomizeShoe_cbo_lace.TabIndex = 18
        '
        'CustomizeShoe_cbo_midsole
        '
        Me.CustomizeShoe_cbo_midsole.FormattingEnabled = True
        Me.CustomizeShoe_cbo_midsole.Location = New System.Drawing.Point(111, 178)
        Me.CustomizeShoe_cbo_midsole.Name = "CustomizeShoe_cbo_midsole"
        Me.CustomizeShoe_cbo_midsole.Size = New System.Drawing.Size(121, 21)
        Me.CustomizeShoe_cbo_midsole.TabIndex = 17
        '
        'CustomizeShoe_cbo_outsole
        '
        Me.CustomizeShoe_cbo_outsole.FormattingEnabled = True
        Me.CustomizeShoe_cbo_outsole.Location = New System.Drawing.Point(111, 214)
        Me.CustomizeShoe_cbo_outsole.Name = "CustomizeShoe_cbo_outsole"
        Me.CustomizeShoe_cbo_outsole.Size = New System.Drawing.Size(121, 21)
        Me.CustomizeShoe_cbo_outsole.TabIndex = 16
        '
        'CustomizeShoe_cbo_insole
        '
        Me.CustomizeShoe_cbo_insole.FormattingEnabled = True
        Me.CustomizeShoe_cbo_insole.Location = New System.Drawing.Point(111, 142)
        Me.CustomizeShoe_cbo_insole.Name = "CustomizeShoe_cbo_insole"
        Me.CustomizeShoe_cbo_insole.Size = New System.Drawing.Size(121, 21)
        Me.CustomizeShoe_cbo_insole.TabIndex = 15
        '
        'CustomizeShoe_cbo_body
        '
        Me.CustomizeShoe_cbo_body.FormattingEnabled = True
        Me.CustomizeShoe_cbo_body.Location = New System.Drawing.Point(111, 109)
        Me.CustomizeShoe_cbo_body.Name = "CustomizeShoe_cbo_body"
        Me.CustomizeShoe_cbo_body.Size = New System.Drawing.Size(121, 21)
        Me.CustomizeShoe_cbo_body.TabIndex = 14
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(47, 250)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(34, 13)
        Me.Label114.TabIndex = 13
        Me.Label114.Text = "Lace:"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(47, 181)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(46, 13)
        Me.Label113.TabIndex = 11
        Me.Label113.Text = "Midsole:"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(47, 217)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(46, 13)
        Me.Label112.TabIndex = 9
        Me.Label112.Text = "Outsole:"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(47, 145)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(38, 13)
        Me.Label111.TabIndex = 7
        Me.Label111.Text = "Insole:"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(47, 112)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(34, 13)
        Me.Label110.TabIndex = 5
        Me.Label110.Text = "Body:"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(29, 28)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(594, 50)
        Me.Label109.TabIndex = 0
        Me.Label109.Text = "Select a part's option to customize that part with the selected option " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Each par" &
    "t should have an option selected"
        '
        'CustomizeShoe_lbl_customer
        '
        Me.CustomizeShoe_lbl_customer.AutoSize = True
        Me.CustomizeShoe_lbl_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomizeShoe_lbl_customer.Location = New System.Drawing.Point(12, 14)
        Me.CustomizeShoe_lbl_customer.Name = "CustomizeShoe_lbl_customer"
        Me.CustomizeShoe_lbl_customer.Size = New System.Drawing.Size(167, 20)
        Me.CustomizeShoe_lbl_customer.TabIndex = 0
        Me.CustomizeShoe_lbl_customer.Text = "Selected Customer:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Accounts_allAccounts)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Panel11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1165, 634)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Accounts_allAccounts
        '
        Me.Accounts_allAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Accounts_allAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Accounts_allAccounts.Location = New System.Drawing.Point(7, 7)
        Me.Accounts_allAccounts.MultiSelect = False
        Me.Accounts_allAccounts.Name = "Accounts_allAccounts"
        Me.Accounts_allAccounts.ReadOnly = True
        Me.Accounts_allAccounts.RowHeadersWidth = 51
        Me.Accounts_allAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Accounts_allAccounts.Size = New System.Drawing.Size(343, 618)
        Me.Accounts_allAccounts.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(356, 591)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(801, 34)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Don't have an account yet? Create one now"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Accounts_btn_editDetails)
        Me.Panel11.Controls.Add(Me.Account_lbl_pass)
        Me.Panel11.Controls.Add(Me.Account_lbl_role)
        Me.Panel11.Controls.Add(Me.Account_lbl_email)
        Me.Panel11.Controls.Add(Me.Account_lbl_contactNum)
        Me.Panel11.Controls.Add(Me.Account_lbl_address)
        Me.Panel11.Controls.Add(Me.Account_lbl_name)
        Me.Panel11.Controls.Add(Me.Accounts_allOrders)
        Me.Panel11.Controls.Add(Me.Label11)
        Me.Panel11.Controls.Add(Me.Account_lbl_ordersCount)
        Me.Panel11.Controls.Add(Me.Label107)
        Me.Panel11.Controls.Add(Me.Account_lbl_creationDate)
        Me.Panel11.Controls.Add(Me.Label105)
        Me.Panel11.Controls.Add(Me.Label90)
        Me.Panel11.Controls.Add(Me.Label91)
        Me.Panel11.Controls.Add(Me.Label92)
        Me.Panel11.Controls.Add(Me.Label93)
        Me.Panel11.Controls.Add(Me.Label94)
        Me.Panel11.Controls.Add(Me.Label95)
        Me.Panel11.Controls.Add(Me.Account_lbl_accID)
        Me.Panel11.Controls.Add(Me.Label97)
        Me.Panel11.Location = New System.Drawing.Point(356, 7)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(801, 577)
        Me.Panel11.TabIndex = 1
        '
        'Accounts_btn_editDetails
        '
        Me.Accounts_btn_editDetails.Location = New System.Drawing.Point(48, 165)
        Me.Accounts_btn_editDetails.Name = "Accounts_btn_editDetails"
        Me.Accounts_btn_editDetails.Size = New System.Drawing.Size(114, 34)
        Me.Accounts_btn_editDetails.TabIndex = 64
        Me.Accounts_btn_editDetails.Text = "Edit Details"
        Me.Accounts_btn_editDetails.UseVisualStyleBackColor = True
        Me.Accounts_btn_editDetails.Visible = False
        '
        'Account_lbl_pass
        '
        Me.Account_lbl_pass.AutoSize = True
        Me.Account_lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_pass.Location = New System.Drawing.Point(184, 136)
        Me.Account_lbl_pass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_pass.Name = "Account_lbl_pass"
        Me.Account_lbl_pass.Size = New System.Drawing.Size(78, 17)
        Me.Account_lbl_pass.TabIndex = 63
        Me.Account_lbl_pass.Text = "(password)"
        '
        'Account_lbl_role
        '
        Me.Account_lbl_role.AutoSize = True
        Me.Account_lbl_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_role.Location = New System.Drawing.Point(149, 113)
        Me.Account_lbl_role.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_role.Name = "Account_lbl_role"
        Me.Account_lbl_role.Size = New System.Drawing.Size(42, 17)
        Me.Account_lbl_role.TabIndex = 62
        Me.Account_lbl_role.Text = "(role)"
        '
        'Account_lbl_email
        '
        Me.Account_lbl_email.AutoSize = True
        Me.Account_lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_email.Location = New System.Drawing.Point(491, 112)
        Me.Account_lbl_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_email.Name = "Account_lbl_email"
        Me.Account_lbl_email.Size = New System.Drawing.Size(51, 17)
        Me.Account_lbl_email.TabIndex = 61
        Me.Account_lbl_email.Text = "(email)"
        '
        'Account_lbl_contactNum
        '
        Me.Account_lbl_contactNum.AutoSize = True
        Me.Account_lbl_contactNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_contactNum.Location = New System.Drawing.Point(565, 88)
        Me.Account_lbl_contactNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_contactNum.Name = "Account_lbl_contactNum"
        Me.Account_lbl_contactNum.Size = New System.Drawing.Size(116, 17)
        Me.Account_lbl_contactNum.TabIndex = 60
        Me.Account_lbl_contactNum.Text = "(contact number)"
        '
        'Account_lbl_address
        '
        Me.Account_lbl_address.AutoSize = True
        Me.Account_lbl_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_address.Location = New System.Drawing.Point(521, 62)
        Me.Account_lbl_address.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_address.Name = "Account_lbl_address"
        Me.Account_lbl_address.Size = New System.Drawing.Size(69, 17)
        Me.Account_lbl_address.TabIndex = 59
        Me.Account_lbl_address.Text = "(address)"
        '
        'Account_lbl_name
        '
        Me.Account_lbl_name.AutoSize = True
        Me.Account_lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_name.Location = New System.Drawing.Point(158, 87)
        Me.Account_lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_name.Name = "Account_lbl_name"
        Me.Account_lbl_name.Size = New System.Drawing.Size(55, 17)
        Me.Account_lbl_name.TabIndex = 58
        Me.Account_lbl_name.Text = "(Name)"
        '
        'Accounts_allOrders
        '
        Me.Accounts_allOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Accounts_allOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Accounts_allOrders.Location = New System.Drawing.Point(48, 325)
        Me.Accounts_allOrders.MultiSelect = False
        Me.Accounts_allOrders.Name = "Accounts_allOrders"
        Me.Accounts_allOrders.ReadOnly = True
        Me.Accounts_allOrders.RowHeadersWidth = 51
        Me.Accounts_allOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Accounts_allOrders.Size = New System.Drawing.Size(719, 238)
        Me.Accounts_allOrders.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 136)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 17)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Account password:"
        '
        'Account_lbl_ordersCount
        '
        Me.Account_lbl_ordersCount.AutoSize = True
        Me.Account_lbl_ordersCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_ordersCount.Location = New System.Drawing.Point(195, 305)
        Me.Account_lbl_ordersCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_ordersCount.Name = "Account_lbl_ordersCount"
        Me.Account_lbl_ordersCount.Size = New System.Drawing.Size(53, 17)
        Me.Account_lbl_ordersCount.TabIndex = 55
        Me.Account_lbl_ordersCount.Text = "(count)"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(45, 305)
        Me.Label107.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(152, 17)
        Me.Label107.TabIndex = 54
        Me.Label107.Text = "Total Orders Count:"
        '
        'Account_lbl_creationDate
        '
        Me.Account_lbl_creationDate.AutoSize = True
        Me.Account_lbl_creationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_creationDate.Location = New System.Drawing.Point(223, 285)
        Me.Account_lbl_creationDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_creationDate.Name = "Account_lbl_creationDate"
        Me.Account_lbl_creationDate.Size = New System.Drawing.Size(46, 17)
        Me.Account_lbl_creationDate.TabIndex = 53
        Me.Account_lbl_creationDate.Text = "(date)"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(45, 285)
        Me.Label105.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(174, 17)
        Me.Label105.TabIndex = 52
        Me.Label105.Text = "Account creation Date:"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(31, 15)
        Me.Label90.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(179, 26)
        Me.Label90.TabIndex = 35
        Me.Label90.Text = "Account Details"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(45, 112)
        Me.Label91.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(109, 17)
        Me.Label91.TabIndex = 28
        Me.Label91.Text = "Account Role:"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(381, 112)
        Me.Label92.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(115, 17)
        Me.Label92.TabIndex = 27
        Me.Label92.Text = "Account Email:"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(381, 88)
        Me.Label93.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(190, 17)
        Me.Label93.TabIndex = 26
        Me.Label93.Text = "Account Contact number:"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(381, 62)
        Me.Label94.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(135, 17)
        Me.Label94.TabIndex = 25
        Me.Label94.Text = "Account Address:"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(45, 86)
        Me.Label95.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(117, 17)
        Me.Label95.TabIndex = 24
        Me.Label95.Text = "Account Name:"
        '
        'Account_lbl_accID
        '
        Me.Account_lbl_accID.AutoSize = True
        Me.Account_lbl_accID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_lbl_accID.Location = New System.Drawing.Point(131, 62)
        Me.Account_lbl_accID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Account_lbl_accID.Name = "Account_lbl_accID"
        Me.Account_lbl_accID.Size = New System.Drawing.Size(91, 17)
        Me.Account_lbl_accID.TabIndex = 23
        Me.Account_lbl_accID.Text = "(CustomerID)"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(45, 62)
        Me.Label97.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(91, 17)
        Me.Label97.TabIndex = 22
        Me.Label97.Text = "Account ID:"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1165, 634)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.Dashboard_Sales_soldProductCount)
        Me.Panel5.Controls.Add(Me.Dashboard_Sales_totalSales)
        Me.Panel5.Controls.Add(Me.Label61)
        Me.Panel5.Controls.Add(Me.Label67)
        Me.Panel5.Controls.Add(Me.Label69)
        Me.Panel5.Controls.Add(Me.Label70)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(792, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(365, 245)
        Me.Panel5.TabIndex = 26
        '
        'Dashboard_Sales_soldProductCount
        '
        Me.Dashboard_Sales_soldProductCount.AutoSize = True
        Me.Dashboard_Sales_soldProductCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Sales_soldProductCount.Location = New System.Drawing.Point(207, 145)
        Me.Dashboard_Sales_soldProductCount.Name = "Dashboard_Sales_soldProductCount"
        Me.Dashboard_Sales_soldProductCount.Size = New System.Drawing.Size(84, 31)
        Me.Dashboard_Sales_soldProductCount.TabIndex = 23
        Me.Dashboard_Sales_soldProductCount.Text = "7 pcs"
        '
        'Dashboard_Sales_totalSales
        '
        Me.Dashboard_Sales_totalSales.AutoSize = True
        Me.Dashboard_Sales_totalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Sales_totalSales.Location = New System.Drawing.Point(33, 145)
        Me.Dashboard_Sales_totalSales.Name = "Dashboard_Sales_totalSales"
        Me.Dashboard_Sales_totalSales.Size = New System.Drawing.Size(94, 31)
        Me.Dashboard_Sales_totalSales.TabIndex = 22
        Me.Dashboard_Sales_totalSales.Text = "12345"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(17, 45)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(65, 16)
        Me.Label61.TabIndex = 21
        Me.Label61.Text = "For today"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(187, 119)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(138, 16)
        Me.Label67.TabIndex = 12
        Me.Label67.Text = "Sold Product count"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(36, 119)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(88, 16)
        Me.Label69.TabIndex = 3
        Me.Label69.Text = "Total Sales"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(14, 14)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(333, 31)
        Me.Label70.TabIndex = 2
        Me.Label70.Text = "Sales and Sold Products"
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(20, 320)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(701, 308)
        Me.Panel6.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.Dashboard_Stocks_normal)
        Me.Panel4.Controls.Add(Me.Dashboard_Stocks_warning)
        Me.Panel4.Controls.Add(Me.Dashboard_Stocks_critical)
        Me.Panel4.Controls.Add(Me.Label63)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(6, 258)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1151, 368)
        Me.Panel4.TabIndex = 2
        '
        'Dashboard_Stocks_normal
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dashboard_Stocks_normal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dashboard_Stocks_normal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dashboard_Stocks_normal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dashboard_Stocks_normal.Location = New System.Drawing.Point(770, 90)
        Me.Dashboard_Stocks_normal.MultiSelect = False
        Me.Dashboard_Stocks_normal.Name = "Dashboard_Stocks_normal"
        Me.Dashboard_Stocks_normal.ReadOnly = True
        Me.Dashboard_Stocks_normal.RowHeadersWidth = 51
        Me.Dashboard_Stocks_normal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dashboard_Stocks_normal.Size = New System.Drawing.Size(378, 275)
        Me.Dashboard_Stocks_normal.TabIndex = 40
        '
        'Dashboard_Stocks_warning
        '
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dashboard_Stocks_warning.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dashboard_Stocks_warning.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dashboard_Stocks_warning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dashboard_Stocks_warning.Location = New System.Drawing.Point(387, 90)
        Me.Dashboard_Stocks_warning.MultiSelect = False
        Me.Dashboard_Stocks_warning.Name = "Dashboard_Stocks_warning"
        Me.Dashboard_Stocks_warning.ReadOnly = True
        Me.Dashboard_Stocks_warning.RowHeadersWidth = 51
        Me.Dashboard_Stocks_warning.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dashboard_Stocks_warning.Size = New System.Drawing.Size(378, 275)
        Me.Dashboard_Stocks_warning.TabIndex = 39
        '
        'Dashboard_Stocks_critical
        '
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dashboard_Stocks_critical.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Dashboard_Stocks_critical.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dashboard_Stocks_critical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dashboard_Stocks_critical.Location = New System.Drawing.Point(3, 90)
        Me.Dashboard_Stocks_critical.MultiSelect = False
        Me.Dashboard_Stocks_critical.Name = "Dashboard_Stocks_critical"
        Me.Dashboard_Stocks_critical.ReadOnly = True
        Me.Dashboard_Stocks_critical.RowHeadersWidth = 51
        Me.Dashboard_Stocks_critical.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dashboard_Stocks_critical.Size = New System.Drawing.Size(378, 275)
        Me.Dashboard_Stocks_critical.TabIndex = 38
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(14, 19)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(103, 31)
        Me.Label63.TabIndex = 26
        Me.Label63.Text = "Stocks"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(396, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 16)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "warning stock amount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(149, 16)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "critical stock amount"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(102, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "6"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(779, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "normal stock amount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(486, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "3"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Dashboard_Orders_outgoing)
        Me.Panel2.Controls.Add(Me.Dashboard_Orders_finished)
        Me.Panel2.Controls.Add(Me.Dashboard_Orders_inProgress)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Dashboard_Orders_notStarted)
        Me.Panel2.Controls.Add(Me.Dashboard_Orders_lbl_outgoing)
        Me.Panel2.Controls.Add(Me.Dashboard_Orders_lbl_finished)
        Me.Panel2.Controls.Add(Me.Dashboard_Orders_lbl_inProgress)
        Me.Panel2.Controls.Add(Me.Dashboard_Orders_lbl_notStarted)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 245)
        Me.Panel2.TabIndex = 0
        '
        'Dashboard_Orders_outgoing
        '
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dashboard_Orders_outgoing.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dashboard_Orders_outgoing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dashboard_Orders_outgoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dashboard_Orders_outgoing.Location = New System.Drawing.Point(586, 88)
        Me.Dashboard_Orders_outgoing.MultiSelect = False
        Me.Dashboard_Orders_outgoing.Name = "Dashboard_Orders_outgoing"
        Me.Dashboard_Orders_outgoing.ReadOnly = True
        Me.Dashboard_Orders_outgoing.RowHeadersWidth = 51
        Me.Dashboard_Orders_outgoing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dashboard_Orders_outgoing.Size = New System.Drawing.Size(187, 149)
        Me.Dashboard_Orders_outgoing.TabIndex = 38
        '
        'Dashboard_Orders_finished
        '
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dashboard_Orders_finished.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Dashboard_Orders_finished.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dashboard_Orders_finished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dashboard_Orders_finished.Location = New System.Drawing.Point(393, 88)
        Me.Dashboard_Orders_finished.MultiSelect = False
        Me.Dashboard_Orders_finished.Name = "Dashboard_Orders_finished"
        Me.Dashboard_Orders_finished.ReadOnly = True
        Me.Dashboard_Orders_finished.RowHeadersWidth = 51
        Me.Dashboard_Orders_finished.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dashboard_Orders_finished.Size = New System.Drawing.Size(187, 149)
        Me.Dashboard_Orders_finished.TabIndex = 37
        '
        'Dashboard_Orders_inProgress
        '
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dashboard_Orders_inProgress.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Dashboard_Orders_inProgress.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dashboard_Orders_inProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dashboard_Orders_inProgress.Location = New System.Drawing.Point(200, 88)
        Me.Dashboard_Orders_inProgress.MultiSelect = False
        Me.Dashboard_Orders_inProgress.Name = "Dashboard_Orders_inProgress"
        Me.Dashboard_Orders_inProgress.ReadOnly = True
        Me.Dashboard_Orders_inProgress.RowHeadersWidth = 51
        Me.Dashboard_Orders_inProgress.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dashboard_Orders_inProgress.Size = New System.Drawing.Size(187, 149)
        Me.Dashboard_Orders_inProgress.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "For today"
        '
        'Dashboard_Orders_notStarted
        '
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dashboard_Orders_notStarted.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Dashboard_Orders_notStarted.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dashboard_Orders_notStarted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dashboard_Orders_notStarted.Location = New System.Drawing.Point(7, 88)
        Me.Dashboard_Orders_notStarted.MultiSelect = False
        Me.Dashboard_Orders_notStarted.Name = "Dashboard_Orders_notStarted"
        Me.Dashboard_Orders_notStarted.ReadOnly = True
        Me.Dashboard_Orders_notStarted.RowHeadersWidth = 51
        Me.Dashboard_Orders_notStarted.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dashboard_Orders_notStarted.Size = New System.Drawing.Size(187, 149)
        Me.Dashboard_Orders_notStarted.TabIndex = 35
        '
        'Dashboard_Orders_lbl_outgoing
        '
        Me.Dashboard_Orders_lbl_outgoing.AutoSize = True
        Me.Dashboard_Orders_lbl_outgoing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Orders_lbl_outgoing.Location = New System.Drawing.Point(583, 68)
        Me.Dashboard_Orders_lbl_outgoing.Name = "Dashboard_Orders_lbl_outgoing"
        Me.Dashboard_Orders_lbl_outgoing.Size = New System.Drawing.Size(74, 16)
        Me.Dashboard_Orders_lbl_outgoing.TabIndex = 18
        Me.Dashboard_Orders_lbl_outgoing.Text = "Outgoing:"
        '
        'Dashboard_Orders_lbl_finished
        '
        Me.Dashboard_Orders_lbl_finished.AutoSize = True
        Me.Dashboard_Orders_lbl_finished.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Orders_lbl_finished.Location = New System.Drawing.Point(390, 68)
        Me.Dashboard_Orders_lbl_finished.Name = "Dashboard_Orders_lbl_finished"
        Me.Dashboard_Orders_lbl_finished.Size = New System.Drawing.Size(71, 16)
        Me.Dashboard_Orders_lbl_finished.TabIndex = 15
        Me.Dashboard_Orders_lbl_finished.Text = "Finished:"
        '
        'Dashboard_Orders_lbl_inProgress
        '
        Me.Dashboard_Orders_lbl_inProgress.AutoSize = True
        Me.Dashboard_Orders_lbl_inProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Orders_lbl_inProgress.Location = New System.Drawing.Point(197, 68)
        Me.Dashboard_Orders_lbl_inProgress.Name = "Dashboard_Orders_lbl_inProgress"
        Me.Dashboard_Orders_lbl_inProgress.Size = New System.Drawing.Size(90, 16)
        Me.Dashboard_Orders_lbl_inProgress.TabIndex = 12
        Me.Dashboard_Orders_lbl_inProgress.Text = "In progress:"
        '
        'Dashboard_Orders_lbl_notStarted
        '
        Me.Dashboard_Orders_lbl_notStarted.AutoSize = True
        Me.Dashboard_Orders_lbl_notStarted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_Orders_lbl_notStarted.Location = New System.Drawing.Point(6, 68)
        Me.Dashboard_Orders_lbl_notStarted.Name = "Dashboard_Orders_lbl_notStarted"
        Me.Dashboard_Orders_lbl_notStarted.Size = New System.Drawing.Size(88, 16)
        Me.Dashboard_Orders_lbl_notStarted.TabIndex = 3
        Me.Dashboard_Orders_lbl_notStarted.Text = "Not started:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Orders"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(20, 320)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(701, 308)
        Me.Panel3.TabIndex = 1
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.TabPage1)
        Me.mainTabControl.Controls.Add(Me.TabPage2)
        Me.mainTabControl.Controls.Add(Me.TabPage3)
        Me.mainTabControl.Controls.Add(Me.TabPage4)
        Me.mainTabControl.Controls.Add(Me.TabPage5)
        Me.mainTabControl.Controls.Add(Me.TabPage6)
        Me.mainTabControl.Location = New System.Drawing.Point(149, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(1173, 660)
        Me.mainTabControl.TabIndex = 2
        '
        'CustomizeShoe_cbo_claimMethod
        '
        Me.CustomizeShoe_cbo_claimMethod.FormattingEnabled = True
        Me.CustomizeShoe_cbo_claimMethod.Items.AddRange(New Object() {"pick_up", "delivery"})
        Me.CustomizeShoe_cbo_claimMethod.Location = New System.Drawing.Point(422, 109)
        Me.CustomizeShoe_cbo_claimMethod.Name = "CustomizeShoe_cbo_claimMethod"
        Me.CustomizeShoe_cbo_claimMethod.Size = New System.Drawing.Size(121, 21)
        Me.CustomizeShoe_cbo_claimMethod.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(346, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Claim method:"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 659)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainTabControl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Shoe Store Management"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        CType(Me.Orders_allOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.Orders_outgoing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Orders_finished, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Orders_inProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Orders_notStarted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.Materials_normal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Materials_warning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Materials_critical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Materials_allMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Accounts_allAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.Accounts_allOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Dashboard_Stocks_normal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dashboard_Stocks_warning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dashboard_Stocks_critical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Dashboard_Orders_outgoing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dashboard_Orders_finished, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dashboard_Orders_inProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dashboard_Orders_notStarted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_Dashboard As Button
    Friend WithEvents btn_Accounts As Button
    Friend WithEvents btn_CustomizeShoe As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Materials As Button
    Friend WithEvents btn_Orders As Button
    Friend WithEvents btn_logs As Button
    Friend WithEvents btn_Login As Button
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Orders_lbl_paymentStatus As Label
    Friend WithEvents Orders_lbl_totalAmount As Label
    Friend WithEvents Orders_lbl_dueDate As Label
    Friend WithEvents Orders_lbl_claimMethod As Label
    Friend WithEvents Orders_lbl_orderDetail As Label
    Friend WithEvents Orders_lbl_customer As Label
    Friend WithEvents Orders_lbl_orderID As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label80 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Dashboard_Sales_soldProductCount As Label
    Friend WithEvents Dashboard_Sales_totalSales As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label63 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Dashboard_Orders_lbl_outgoing As Label
    Friend WithEvents Dashboard_Orders_lbl_finished As Label
    Friend WithEvents Dashboard_Orders_lbl_inProgress As Label
    Friend WithEvents Dashboard_Orders_lbl_notStarted As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents Account_lbl_accID As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents Account_lbl_ordersCount As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents Account_lbl_creationDate As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Material_lbl_lowestPrice As Label
    Friend WithEvents Material_lbl_aveMatPrice As Label
    Friend WithEvents Material_lbl_highestPrice As Label
    Friend WithEvents Material_lbl_leastUsed As Label
    Friend WithEvents Material_lbl_mostUsed As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Dashboard_Orders_notStarted As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Dashboard_Stocks_critical As DataGridView
    Friend WithEvents Dashboard_Orders_outgoing As DataGridView
    Friend WithEvents Dashboard_Orders_finished As DataGridView
    Friend WithEvents Dashboard_Orders_inProgress As DataGridView
    Friend WithEvents Dashboard_Stocks_normal As DataGridView
    Friend WithEvents Dashboard_Stocks_warning As DataGridView
    Friend WithEvents Accounts_allAccounts As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Orders_allOrders As DataGridView
    Friend WithEvents Accounts_allOrders As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Orders_outgoing As DataGridView
    Friend WithEvents Orders_finished As DataGridView
    Friend WithEvents Orders_inProgress As DataGridView
    Friend WithEvents Orders_notStarted As DataGridView
    Friend WithEvents Account_lbl_pass As Label
    Friend WithEvents Account_lbl_role As Label
    Friend WithEvents Account_lbl_email As Label
    Friend WithEvents Account_lbl_contactNum As Label
    Friend WithEvents Account_lbl_address As Label
    Friend WithEvents Account_lbl_name As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Materials_critical As DataGridView
    Friend WithEvents Material_lbl_normalAmount As Label
    Friend WithEvents Material_lbl_warningAmount As Label
    Friend WithEvents Material_lbl_criticalAmount As Label
    Friend WithEvents Materials_allMaterials As DataGridView
    Friend WithEvents Materials_normal As DataGridView
    Friend WithEvents Materials_warning As DataGridView
    Friend WithEvents Accounts_btn_editDetails As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Orders_lbl_processStatus As Label
    Friend WithEvents Material_btn_deleteMaterial As Button
    Friend WithEvents Material_btn_updateMaterial As Button
    Friend WithEvents Material_btn_addMaterial As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents RTB_summary As RichTextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents CustomizeShoe_btn_selectCustomer As Button
    Friend WithEvents CustomizeShoe_viewSummary As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents CustomizeShoe_cbo_lace As ComboBox
    Friend WithEvents CustomizeShoe_cbo_midsole As ComboBox
    Friend WithEvents CustomizeShoe_cbo_outsole As ComboBox
    Friend WithEvents CustomizeShoe_cbo_insole As ComboBox
    Friend WithEvents CustomizeShoe_cbo_body As ComboBox
    Friend WithEvents Label114 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents CustomizeShoe_lbl_customer As Label
    Friend WithEvents Orders_finish_to_outgoing As Button
    Friend WithEvents Orders_to_finished As Button
    Friend WithEvents Orders_to_inProgress As Button
    Friend WithEvents Orders_finish_to_settled As Button
    Friend WithEvents Orders_outgoing_to_settled As Button
    Friend WithEvents CustomizeShoe_cbo_claimMethod As ComboBox
    Friend WithEvents Label5 As Label
End Class
