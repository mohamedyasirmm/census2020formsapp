<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabResidents = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbResRace = New System.Windows.Forms.TextBox()
        Me.tbResSex = New System.Windows.Forms.TextBox()
        Me.tbResDoB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagridRes = New System.Windows.Forms.DataGridView()
        Me.tbResLN = New System.Windows.Forms.TextBox()
        Me.tbResMN = New System.Windows.Forms.TextBox()
        Me.tbResFN = New System.Windows.Forms.TextBox()
        Me.tbResResID = New System.Windows.Forms.TextBox()
        Me.btnResDelete = New System.Windows.Forms.Button()
        Me.btnResUpdate = New System.Windows.Forms.Button()
        Me.btnResInsert = New System.Windows.Forms.Button()
        Me.btnResRefresh = New System.Windows.Forms.Button()
        Me.TabEmployees = New System.Windows.Forms.TabPage()
        Me.cbEmpManagerID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbEmpSalary = New System.Windows.Forms.TextBox()
        Me.tbEmpPosition = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.datagridEmp = New System.Windows.Forms.DataGridView()
        Me.tbEmpLN = New System.Windows.Forms.TextBox()
        Me.tbEmpFN = New System.Windows.Forms.TextBox()
        Me.tbEmpEmpID = New System.Windows.Forms.TextBox()
        Me.btnEmpDelete = New System.Windows.Forms.Button()
        Me.btnEmpUpdate = New System.Windows.Forms.Button()
        Me.btnEmpInsert = New System.Windows.Forms.Button()
        Me.btnEmpRefresh = New System.Windows.Forms.Button()
        Me.TabRegions = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.datagridReg = New System.Windows.Forms.DataGridView()
        Me.tbRegRegDesc = New System.Windows.Forms.TextBox()
        Me.tbRegRegID = New System.Windows.Forms.TextBox()
        Me.btnRegDelete = New System.Windows.Forms.Button()
        Me.btnRegUpdate = New System.Windows.Forms.Button()
        Me.btnRegInsert = New System.Windows.Forms.Button()
        Me.btnRegRefresh = New System.Windows.Forms.Button()
        Me.TabAddresses = New System.Windows.Forms.TabPage()
        Me.cbAddrRegID = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbAddrZipCode = New System.Windows.Forms.TextBox()
        Me.tbAddrState = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.datagridAddr = New System.Windows.Forms.DataGridView()
        Me.tbAddrCity = New System.Windows.Forms.TextBox()
        Me.tbAddrStreet = New System.Windows.Forms.TextBox()
        Me.tbAddrNum = New System.Windows.Forms.TextBox()
        Me.tbAddrAddrID = New System.Windows.Forms.TextBox()
        Me.btnAddrDelete = New System.Windows.Forms.Button()
        Me.btnAddrUpdate = New System.Windows.Forms.Button()
        Me.btnAddrInsert = New System.Windows.Forms.Button()
        Me.btnAddrRefresh = New System.Windows.Forms.Button()
        Me.TabAssignments = New System.Windows.Forms.TabPage()
        Me.cbAssignRegID = New System.Windows.Forms.ComboBox()
        Me.cbAssignEmpID = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.datagridAssign = New System.Windows.Forms.DataGridView()
        Me.btnAssignDelete = New System.Windows.Forms.Button()
        Me.btnAssignInsert = New System.Windows.Forms.Button()
        Me.btnAssignRefresh = New System.Windows.Forms.Button()
        Me.TabResidentAddress = New System.Windows.Forms.TabPage()
        Me.tbResAddrResStatus = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbResAddrAddrID = New System.Windows.Forms.ComboBox()
        Me.cbResAddrResID = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.datagridResAddr = New System.Windows.Forms.DataGridView()
        Me.btnResAddrDelete = New System.Windows.Forms.Button()
        Me.btnResAddrUpdate = New System.Windows.Forms.Button()
        Me.btnResAddrInsert = New System.Windows.Forms.Button()
        Me.btnResAddrRefresh = New System.Windows.Forms.Button()
        Me.lblResRowCount = New System.Windows.Forms.Label()
        Me.lblEmpRowCount = New System.Windows.Forms.Label()
        Me.lblRegRowCount = New System.Windows.Forms.Label()
        Me.lblAddrRowCount = New System.Windows.Forms.Label()
        Me.lblAssignRowCount = New System.Windows.Forms.Label()
        Me.lblResAddrRowCount = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabResidents.SuspendLayout()
        CType(Me.datagridRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEmployees.SuspendLayout()
        CType(Me.datagridEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRegions.SuspendLayout()
        CType(Me.datagridReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAddresses.SuspendLayout()
        CType(Me.datagridAddr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAssignments.SuspendLayout()
        CType(Me.datagridAssign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabResidentAddress.SuspendLayout()
        CType(Me.datagridResAddr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabResidents)
        Me.TabControl1.Controls.Add(Me.TabEmployees)
        Me.TabControl1.Controls.Add(Me.TabRegions)
        Me.TabControl1.Controls.Add(Me.TabAddresses)
        Me.TabControl1.Controls.Add(Me.TabAssignments)
        Me.TabControl1.Controls.Add(Me.TabResidentAddress)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1423, 919)
        Me.TabControl1.TabIndex = 0
        '
        'TabResidents
        '
        Me.TabResidents.Controls.Add(Me.lblResRowCount)
        Me.TabResidents.Controls.Add(Me.Label7)
        Me.TabResidents.Controls.Add(Me.Label8)
        Me.TabResidents.Controls.Add(Me.Label9)
        Me.TabResidents.Controls.Add(Me.tbResRace)
        Me.TabResidents.Controls.Add(Me.tbResSex)
        Me.TabResidents.Controls.Add(Me.tbResDoB)
        Me.TabResidents.Controls.Add(Me.Label5)
        Me.TabResidents.Controls.Add(Me.LabelLabel)
        Me.TabResidents.Controls.Add(Me.Label3)
        Me.TabResidents.Controls.Add(Me.Label2)
        Me.TabResidents.Controls.Add(Me.Label1)
        Me.TabResidents.Controls.Add(Me.datagridRes)
        Me.TabResidents.Controls.Add(Me.tbResLN)
        Me.TabResidents.Controls.Add(Me.tbResMN)
        Me.TabResidents.Controls.Add(Me.tbResFN)
        Me.TabResidents.Controls.Add(Me.tbResResID)
        Me.TabResidents.Controls.Add(Me.btnResDelete)
        Me.TabResidents.Controls.Add(Me.btnResUpdate)
        Me.TabResidents.Controls.Add(Me.btnResInsert)
        Me.TabResidents.Controls.Add(Me.btnResRefresh)
        Me.TabResidents.Location = New System.Drawing.Point(4, 38)
        Me.TabResidents.Name = "TabResidents"
        Me.TabResidents.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResidents.Size = New System.Drawing.Size(1415, 877)
        Me.TabResidents.TabIndex = 0
        Me.TabResidents.Text = "Residents"
        Me.TabResidents.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(895, 492)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 29)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Race"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(895, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 29)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Sex"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(895, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 29)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "DoB"
        '
        'tbResRace
        '
        Me.tbResRace.Location = New System.Drawing.Point(1053, 486)
        Me.tbResRace.Name = "tbResRace"
        Me.tbResRace.Size = New System.Drawing.Size(322, 35)
        Me.tbResRace.TabIndex = 51
        '
        'tbResSex
        '
        Me.tbResSex.Location = New System.Drawing.Point(1053, 439)
        Me.tbResSex.Name = "tbResSex"
        Me.tbResSex.Size = New System.Drawing.Size(322, 35)
        Me.tbResSex.TabIndex = 50
        '
        'tbResDoB
        '
        Me.tbResDoB.Location = New System.Drawing.Point(1053, 388)
        Me.tbResDoB.Name = "tbResDoB"
        Me.tbResDoB.Size = New System.Drawing.Size(322, 35)
        Me.tbResDoB.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 37)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Residents"
        '
        'LabelLabel
        '
        Me.LabelLabel.AutoSize = True
        Me.LabelLabel.Location = New System.Drawing.Point(895, 300)
        Me.LabelLabel.Name = "LabelLabel"
        Me.LabelLabel.Size = New System.Drawing.Size(152, 29)
        Me.LabelLabel.TabIndex = 47
        Me.LabelLabel.Text = "MiddleName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(895, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 29)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "LastName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(895, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 29)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "FirstName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(895, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 29)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "ResidentID"
        '
        'datagridRes
        '
        Me.datagridRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridRes.Location = New System.Drawing.Point(46, 187)
        Me.datagridRes.Name = "datagridRes"
        Me.datagridRes.RowHeadersWidth = 62
        Me.datagridRes.Size = New System.Drawing.Size(816, 474)
        Me.datagridRes.TabIndex = 43
        '
        'tbResLN
        '
        Me.tbResLN.Location = New System.Drawing.Point(1053, 338)
        Me.tbResLN.Name = "tbResLN"
        Me.tbResLN.Size = New System.Drawing.Size(322, 35)
        Me.tbResLN.TabIndex = 42
        '
        'tbResMN
        '
        Me.tbResMN.Location = New System.Drawing.Point(1053, 294)
        Me.tbResMN.Name = "tbResMN"
        Me.tbResMN.Size = New System.Drawing.Size(322, 35)
        Me.tbResMN.TabIndex = 41
        '
        'tbResFN
        '
        Me.tbResFN.Location = New System.Drawing.Point(1053, 247)
        Me.tbResFN.Name = "tbResFN"
        Me.tbResFN.Size = New System.Drawing.Size(322, 35)
        Me.tbResFN.TabIndex = 40
        '
        'tbResResID
        '
        Me.tbResResID.Location = New System.Drawing.Point(1053, 196)
        Me.tbResResID.Name = "tbResResID"
        Me.tbResResID.Size = New System.Drawing.Size(322, 35)
        Me.tbResResID.TabIndex = 39
        '
        'btnResDelete
        '
        Me.btnResDelete.Location = New System.Drawing.Point(1162, 666)
        Me.btnResDelete.Name = "btnResDelete"
        Me.btnResDelete.Size = New System.Drawing.Size(112, 38)
        Me.btnResDelete.TabIndex = 38
        Me.btnResDelete.Text = "Delete"
        Me.btnResDelete.UseVisualStyleBackColor = True
        '
        'btnResUpdate
        '
        Me.btnResUpdate.Location = New System.Drawing.Point(965, 666)
        Me.btnResUpdate.Name = "btnResUpdate"
        Me.btnResUpdate.Size = New System.Drawing.Size(112, 38)
        Me.btnResUpdate.TabIndex = 37
        Me.btnResUpdate.Text = "Update"
        Me.btnResUpdate.UseVisualStyleBackColor = True
        '
        'btnResInsert
        '
        Me.btnResInsert.Location = New System.Drawing.Point(1162, 581)
        Me.btnResInsert.Name = "btnResInsert"
        Me.btnResInsert.Size = New System.Drawing.Size(112, 38)
        Me.btnResInsert.TabIndex = 36
        Me.btnResInsert.Text = "Insert"
        Me.btnResInsert.UseVisualStyleBackColor = True
        '
        'btnResRefresh
        '
        Me.btnResRefresh.Location = New System.Drawing.Point(965, 581)
        Me.btnResRefresh.Name = "btnResRefresh"
        Me.btnResRefresh.Size = New System.Drawing.Size(112, 38)
        Me.btnResRefresh.TabIndex = 35
        Me.btnResRefresh.Text = "Refresh"
        Me.btnResRefresh.UseVisualStyleBackColor = True
        '
        'TabEmployees
        '
        Me.TabEmployees.Controls.Add(Me.lblEmpRowCount)
        Me.TabEmployees.Controls.Add(Me.cbEmpManagerID)
        Me.TabEmployees.Controls.Add(Me.Label6)
        Me.TabEmployees.Controls.Add(Me.Label10)
        Me.TabEmployees.Controls.Add(Me.Label11)
        Me.TabEmployees.Controls.Add(Me.tbEmpSalary)
        Me.TabEmployees.Controls.Add(Me.tbEmpPosition)
        Me.TabEmployees.Controls.Add(Me.Label12)
        Me.TabEmployees.Controls.Add(Me.Label14)
        Me.TabEmployees.Controls.Add(Me.Label15)
        Me.TabEmployees.Controls.Add(Me.Label16)
        Me.TabEmployees.Controls.Add(Me.datagridEmp)
        Me.TabEmployees.Controls.Add(Me.tbEmpLN)
        Me.TabEmployees.Controls.Add(Me.tbEmpFN)
        Me.TabEmployees.Controls.Add(Me.tbEmpEmpID)
        Me.TabEmployees.Controls.Add(Me.btnEmpDelete)
        Me.TabEmployees.Controls.Add(Me.btnEmpUpdate)
        Me.TabEmployees.Controls.Add(Me.btnEmpInsert)
        Me.TabEmployees.Controls.Add(Me.btnEmpRefresh)
        Me.TabEmployees.Location = New System.Drawing.Point(4, 38)
        Me.TabEmployees.Name = "TabEmployees"
        Me.TabEmployees.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEmployees.Size = New System.Drawing.Size(1415, 877)
        Me.TabEmployees.TabIndex = 1
        Me.TabEmployees.Text = "Employees"
        Me.TabEmployees.UseVisualStyleBackColor = True
        '
        'cbEmpManagerID
        '
        Me.cbEmpManagerID.FormattingEnabled = True
        Me.cbEmpManagerID.Location = New System.Drawing.Point(1048, 467)
        Me.cbEmpManagerID.Name = "cbEmpManagerID"
        Me.cbEmpManagerID.Size = New System.Drawing.Size(322, 37)
        Me.cbEmpManagerID.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(890, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 29)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "ManagerID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(890, 420)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 29)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Salary"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(890, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 29)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Position"
        '
        'tbEmpSalary
        '
        Me.tbEmpSalary.Location = New System.Drawing.Point(1048, 414)
        Me.tbEmpSalary.Name = "tbEmpSalary"
        Me.tbEmpSalary.Size = New System.Drawing.Size(322, 35)
        Me.tbEmpSalary.TabIndex = 71
        '
        'tbEmpPosition
        '
        Me.tbEmpPosition.Location = New System.Drawing.Point(1048, 363)
        Me.tbEmpPosition.Name = "tbEmpPosition"
        Me.tbEmpPosition.Size = New System.Drawing.Size(322, 35)
        Me.tbEmpPosition.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(34, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(173, 37)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Employees"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(890, 319)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 29)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "LastName"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(890, 261)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 29)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "FirstName"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(890, 209)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 29)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "EmployeeID"
        '
        'datagridEmp
        '
        Me.datagridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridEmp.Location = New System.Drawing.Point(41, 195)
        Me.datagridEmp.Name = "datagridEmp"
        Me.datagridEmp.RowHeadersWidth = 62
        Me.datagridEmp.Size = New System.Drawing.Size(816, 474)
        Me.datagridEmp.TabIndex = 64
        '
        'tbEmpLN
        '
        Me.tbEmpLN.Location = New System.Drawing.Point(1048, 313)
        Me.tbEmpLN.Name = "tbEmpLN"
        Me.tbEmpLN.Size = New System.Drawing.Size(322, 35)
        Me.tbEmpLN.TabIndex = 63
        '
        'tbEmpFN
        '
        Me.tbEmpFN.Location = New System.Drawing.Point(1048, 255)
        Me.tbEmpFN.Name = "tbEmpFN"
        Me.tbEmpFN.Size = New System.Drawing.Size(322, 35)
        Me.tbEmpFN.TabIndex = 61
        '
        'tbEmpEmpID
        '
        Me.tbEmpEmpID.Location = New System.Drawing.Point(1048, 204)
        Me.tbEmpEmpID.Name = "tbEmpEmpID"
        Me.tbEmpEmpID.Size = New System.Drawing.Size(322, 35)
        Me.tbEmpEmpID.TabIndex = 60
        '
        'btnEmpDelete
        '
        Me.btnEmpDelete.Location = New System.Drawing.Point(1157, 674)
        Me.btnEmpDelete.Name = "btnEmpDelete"
        Me.btnEmpDelete.Size = New System.Drawing.Size(112, 38)
        Me.btnEmpDelete.TabIndex = 59
        Me.btnEmpDelete.Text = "Delete"
        Me.btnEmpDelete.UseVisualStyleBackColor = True
        '
        'btnEmpUpdate
        '
        Me.btnEmpUpdate.Location = New System.Drawing.Point(960, 674)
        Me.btnEmpUpdate.Name = "btnEmpUpdate"
        Me.btnEmpUpdate.Size = New System.Drawing.Size(112, 38)
        Me.btnEmpUpdate.TabIndex = 58
        Me.btnEmpUpdate.Text = "Update"
        Me.btnEmpUpdate.UseVisualStyleBackColor = True
        '
        'btnEmpInsert
        '
        Me.btnEmpInsert.Location = New System.Drawing.Point(1157, 589)
        Me.btnEmpInsert.Name = "btnEmpInsert"
        Me.btnEmpInsert.Size = New System.Drawing.Size(112, 38)
        Me.btnEmpInsert.TabIndex = 57
        Me.btnEmpInsert.Text = "Insert"
        Me.btnEmpInsert.UseVisualStyleBackColor = True
        '
        'btnEmpRefresh
        '
        Me.btnEmpRefresh.Location = New System.Drawing.Point(960, 589)
        Me.btnEmpRefresh.Name = "btnEmpRefresh"
        Me.btnEmpRefresh.Size = New System.Drawing.Size(112, 38)
        Me.btnEmpRefresh.TabIndex = 56
        Me.btnEmpRefresh.Text = "Refresh"
        Me.btnEmpRefresh.UseVisualStyleBackColor = True
        '
        'TabRegions
        '
        Me.TabRegions.Controls.Add(Me.lblRegRowCount)
        Me.TabRegions.Controls.Add(Me.Label19)
        Me.TabRegions.Controls.Add(Me.Label22)
        Me.TabRegions.Controls.Add(Me.Label23)
        Me.TabRegions.Controls.Add(Me.datagridReg)
        Me.TabRegions.Controls.Add(Me.tbRegRegDesc)
        Me.TabRegions.Controls.Add(Me.tbRegRegID)
        Me.TabRegions.Controls.Add(Me.btnRegDelete)
        Me.TabRegions.Controls.Add(Me.btnRegUpdate)
        Me.TabRegions.Controls.Add(Me.btnRegInsert)
        Me.TabRegions.Controls.Add(Me.btnRegRefresh)
        Me.TabRegions.Location = New System.Drawing.Point(4, 38)
        Me.TabRegions.Name = "TabRegions"
        Me.TabRegions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRegions.Size = New System.Drawing.Size(1415, 877)
        Me.TabRegions.TabIndex = 2
        Me.TabRegions.Text = "Regions"
        Me.TabRegions.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(38, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 37)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Regions"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(894, 242)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(146, 29)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "RegionDesc"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(894, 190)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(114, 29)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "RegionID"
        '
        'datagridReg
        '
        Me.datagridReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridReg.Location = New System.Drawing.Point(45, 176)
        Me.datagridReg.Name = "datagridReg"
        Me.datagridReg.RowHeadersWidth = 62
        Me.datagridReg.Size = New System.Drawing.Size(816, 474)
        Me.datagridReg.TabIndex = 64
        '
        'tbRegRegDesc
        '
        Me.tbRegRegDesc.Location = New System.Drawing.Point(1052, 236)
        Me.tbRegRegDesc.Name = "tbRegRegDesc"
        Me.tbRegRegDesc.Size = New System.Drawing.Size(322, 35)
        Me.tbRegRegDesc.TabIndex = 61
        '
        'tbRegRegID
        '
        Me.tbRegRegID.Location = New System.Drawing.Point(1052, 185)
        Me.tbRegRegID.Name = "tbRegRegID"
        Me.tbRegRegID.Size = New System.Drawing.Size(322, 35)
        Me.tbRegRegID.TabIndex = 60
        '
        'btnRegDelete
        '
        Me.btnRegDelete.Location = New System.Drawing.Point(1156, 476)
        Me.btnRegDelete.Name = "btnRegDelete"
        Me.btnRegDelete.Size = New System.Drawing.Size(112, 38)
        Me.btnRegDelete.TabIndex = 59
        Me.btnRegDelete.Text = "Delete"
        Me.btnRegDelete.UseVisualStyleBackColor = True
        '
        'btnRegUpdate
        '
        Me.btnRegUpdate.Location = New System.Drawing.Point(959, 476)
        Me.btnRegUpdate.Name = "btnRegUpdate"
        Me.btnRegUpdate.Size = New System.Drawing.Size(112, 38)
        Me.btnRegUpdate.TabIndex = 58
        Me.btnRegUpdate.Text = "Update"
        Me.btnRegUpdate.UseVisualStyleBackColor = True
        '
        'btnRegInsert
        '
        Me.btnRegInsert.Location = New System.Drawing.Point(1156, 391)
        Me.btnRegInsert.Name = "btnRegInsert"
        Me.btnRegInsert.Size = New System.Drawing.Size(112, 38)
        Me.btnRegInsert.TabIndex = 57
        Me.btnRegInsert.Text = "Insert"
        Me.btnRegInsert.UseVisualStyleBackColor = True
        '
        'btnRegRefresh
        '
        Me.btnRegRefresh.Location = New System.Drawing.Point(959, 391)
        Me.btnRegRefresh.Name = "btnRegRefresh"
        Me.btnRegRefresh.Size = New System.Drawing.Size(112, 38)
        Me.btnRegRefresh.TabIndex = 56
        Me.btnRegRefresh.Text = "Refresh"
        Me.btnRegRefresh.UseVisualStyleBackColor = True
        '
        'TabAddresses
        '
        Me.TabAddresses.Controls.Add(Me.lblAddrRowCount)
        Me.TabAddresses.Controls.Add(Me.cbAddrRegID)
        Me.TabAddresses.Controls.Add(Me.Label13)
        Me.TabAddresses.Controls.Add(Me.Label17)
        Me.TabAddresses.Controls.Add(Me.Label18)
        Me.TabAddresses.Controls.Add(Me.tbAddrZipCode)
        Me.TabAddresses.Controls.Add(Me.tbAddrState)
        Me.TabAddresses.Controls.Add(Me.Label20)
        Me.TabAddresses.Controls.Add(Me.Label21)
        Me.TabAddresses.Controls.Add(Me.Label24)
        Me.TabAddresses.Controls.Add(Me.Label25)
        Me.TabAddresses.Controls.Add(Me.Label26)
        Me.TabAddresses.Controls.Add(Me.datagridAddr)
        Me.TabAddresses.Controls.Add(Me.tbAddrCity)
        Me.TabAddresses.Controls.Add(Me.tbAddrStreet)
        Me.TabAddresses.Controls.Add(Me.tbAddrNum)
        Me.TabAddresses.Controls.Add(Me.tbAddrAddrID)
        Me.TabAddresses.Controls.Add(Me.btnAddrDelete)
        Me.TabAddresses.Controls.Add(Me.btnAddrUpdate)
        Me.TabAddresses.Controls.Add(Me.btnAddrInsert)
        Me.TabAddresses.Controls.Add(Me.btnAddrRefresh)
        Me.TabAddresses.Location = New System.Drawing.Point(4, 38)
        Me.TabAddresses.Name = "TabAddresses"
        Me.TabAddresses.Size = New System.Drawing.Size(1415, 877)
        Me.TabAddresses.TabIndex = 3
        Me.TabAddresses.Text = "Addresses"
        Me.TabAddresses.UseVisualStyleBackColor = True
        '
        'cbAddrRegID
        '
        Me.cbAddrRegID.FormattingEnabled = True
        Me.cbAddrRegID.Location = New System.Drawing.Point(1054, 482)
        Me.cbAddrRegID.Name = "cbAddrRegID"
        Me.cbAddrRegID.Size = New System.Drawing.Size(322, 37)
        Me.cbAddrRegID.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(896, 482)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 29)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "RegionID"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(896, 435)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 29)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "ZipCode"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(896, 383)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 29)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "State"
        '
        'tbAddrZipCode
        '
        Me.tbAddrZipCode.Location = New System.Drawing.Point(1054, 429)
        Me.tbAddrZipCode.Name = "tbAddrZipCode"
        Me.tbAddrZipCode.Size = New System.Drawing.Size(322, 35)
        Me.tbAddrZipCode.TabIndex = 71
        '
        'tbAddrState
        '
        Me.tbAddrState.Location = New System.Drawing.Point(1054, 378)
        Me.tbAddrState.Name = "tbAddrState"
        Me.tbAddrState.Size = New System.Drawing.Size(322, 35)
        Me.tbAddrState.TabIndex = 70
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(40, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(168, 37)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Addresses"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(896, 290)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 29)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "Street"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(896, 334)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 29)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "City"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(896, 243)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 29)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "Number"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(896, 191)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(125, 29)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "AddressID"
        '
        'datagridAddr
        '
        Me.datagridAddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridAddr.Location = New System.Drawing.Point(47, 177)
        Me.datagridAddr.Name = "datagridAddr"
        Me.datagridAddr.RowHeadersWidth = 62
        Me.datagridAddr.Size = New System.Drawing.Size(816, 474)
        Me.datagridAddr.TabIndex = 64
        '
        'tbAddrCity
        '
        Me.tbAddrCity.Location = New System.Drawing.Point(1054, 328)
        Me.tbAddrCity.Name = "tbAddrCity"
        Me.tbAddrCity.Size = New System.Drawing.Size(322, 35)
        Me.tbAddrCity.TabIndex = 63
        '
        'tbAddrStreet
        '
        Me.tbAddrStreet.Location = New System.Drawing.Point(1054, 284)
        Me.tbAddrStreet.Name = "tbAddrStreet"
        Me.tbAddrStreet.Size = New System.Drawing.Size(322, 35)
        Me.tbAddrStreet.TabIndex = 62
        '
        'tbAddrNum
        '
        Me.tbAddrNum.Location = New System.Drawing.Point(1054, 237)
        Me.tbAddrNum.Name = "tbAddrNum"
        Me.tbAddrNum.Size = New System.Drawing.Size(322, 35)
        Me.tbAddrNum.TabIndex = 61
        '
        'tbAddrAddrID
        '
        Me.tbAddrAddrID.Location = New System.Drawing.Point(1054, 186)
        Me.tbAddrAddrID.Name = "tbAddrAddrID"
        Me.tbAddrAddrID.Size = New System.Drawing.Size(322, 35)
        Me.tbAddrAddrID.TabIndex = 60
        '
        'btnAddrDelete
        '
        Me.btnAddrDelete.Location = New System.Drawing.Point(1163, 656)
        Me.btnAddrDelete.Name = "btnAddrDelete"
        Me.btnAddrDelete.Size = New System.Drawing.Size(112, 38)
        Me.btnAddrDelete.TabIndex = 59
        Me.btnAddrDelete.Text = "Delete"
        Me.btnAddrDelete.UseVisualStyleBackColor = True
        '
        'btnAddrUpdate
        '
        Me.btnAddrUpdate.Location = New System.Drawing.Point(966, 656)
        Me.btnAddrUpdate.Name = "btnAddrUpdate"
        Me.btnAddrUpdate.Size = New System.Drawing.Size(112, 38)
        Me.btnAddrUpdate.TabIndex = 58
        Me.btnAddrUpdate.Text = "Update"
        Me.btnAddrUpdate.UseVisualStyleBackColor = True
        '
        'btnAddrInsert
        '
        Me.btnAddrInsert.Location = New System.Drawing.Point(1163, 571)
        Me.btnAddrInsert.Name = "btnAddrInsert"
        Me.btnAddrInsert.Size = New System.Drawing.Size(112, 38)
        Me.btnAddrInsert.TabIndex = 57
        Me.btnAddrInsert.Text = "Insert"
        Me.btnAddrInsert.UseVisualStyleBackColor = True
        '
        'btnAddrRefresh
        '
        Me.btnAddrRefresh.Location = New System.Drawing.Point(966, 571)
        Me.btnAddrRefresh.Name = "btnAddrRefresh"
        Me.btnAddrRefresh.Size = New System.Drawing.Size(112, 38)
        Me.btnAddrRefresh.TabIndex = 56
        Me.btnAddrRefresh.Text = "Refresh"
        Me.btnAddrRefresh.UseVisualStyleBackColor = True
        '
        'TabAssignments
        '
        Me.TabAssignments.Controls.Add(Me.lblAssignRowCount)
        Me.TabAssignments.Controls.Add(Me.cbAssignRegID)
        Me.TabAssignments.Controls.Add(Me.cbAssignEmpID)
        Me.TabAssignments.Controls.Add(Me.Label30)
        Me.TabAssignments.Controls.Add(Me.Label33)
        Me.TabAssignments.Controls.Add(Me.Label34)
        Me.TabAssignments.Controls.Add(Me.datagridAssign)
        Me.TabAssignments.Controls.Add(Me.btnAssignDelete)
        Me.TabAssignments.Controls.Add(Me.btnAssignInsert)
        Me.TabAssignments.Controls.Add(Me.btnAssignRefresh)
        Me.TabAssignments.Location = New System.Drawing.Point(4, 38)
        Me.TabAssignments.Name = "TabAssignments"
        Me.TabAssignments.Size = New System.Drawing.Size(1415, 877)
        Me.TabAssignments.TabIndex = 4
        Me.TabAssignments.Text = "Assignments"
        Me.TabAssignments.UseVisualStyleBackColor = True
        '
        'cbAssignRegID
        '
        Me.cbAssignRegID.FormattingEnabled = True
        Me.cbAssignRegID.Location = New System.Drawing.Point(1057, 248)
        Me.cbAssignRegID.Name = "cbAssignRegID"
        Me.cbAssignRegID.Size = New System.Drawing.Size(278, 37)
        Me.cbAssignRegID.TabIndex = 71
        '
        'cbAssignEmpID
        '
        Me.cbAssignEmpID.FormattingEnabled = True
        Me.cbAssignEmpID.Location = New System.Drawing.Point(1057, 199)
        Me.cbAssignEmpID.Name = "cbAssignEmpID"
        Me.cbAssignEmpID.Size = New System.Drawing.Size(278, 37)
        Me.cbAssignEmpID.TabIndex = 70
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(33, 67)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(201, 37)
        Me.Label30.TabIndex = 69
        Me.Label30.Text = "Assignments"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(889, 251)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(114, 29)
        Me.Label33.TabIndex = 66
        Me.Label33.Text = "RegionID"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(889, 199)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(145, 29)
        Me.Label34.TabIndex = 65
        Me.Label34.Text = "EmployeeID"
        '
        'datagridAssign
        '
        Me.datagridAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridAssign.Location = New System.Drawing.Point(40, 185)
        Me.datagridAssign.Name = "datagridAssign"
        Me.datagridAssign.RowHeadersWidth = 62
        Me.datagridAssign.Size = New System.Drawing.Size(816, 474)
        Me.datagridAssign.TabIndex = 64
        '
        'btnAssignDelete
        '
        Me.btnAssignDelete.Location = New System.Drawing.Point(1155, 543)
        Me.btnAssignDelete.Name = "btnAssignDelete"
        Me.btnAssignDelete.Size = New System.Drawing.Size(112, 38)
        Me.btnAssignDelete.TabIndex = 59
        Me.btnAssignDelete.Text = "Delete"
        Me.btnAssignDelete.UseVisualStyleBackColor = True
        '
        'btnAssignInsert
        '
        Me.btnAssignInsert.Location = New System.Drawing.Point(1155, 458)
        Me.btnAssignInsert.Name = "btnAssignInsert"
        Me.btnAssignInsert.Size = New System.Drawing.Size(112, 38)
        Me.btnAssignInsert.TabIndex = 57
        Me.btnAssignInsert.Text = "Insert"
        Me.btnAssignInsert.UseVisualStyleBackColor = True
        '
        'btnAssignRefresh
        '
        Me.btnAssignRefresh.Location = New System.Drawing.Point(958, 458)
        Me.btnAssignRefresh.Name = "btnAssignRefresh"
        Me.btnAssignRefresh.Size = New System.Drawing.Size(112, 38)
        Me.btnAssignRefresh.TabIndex = 56
        Me.btnAssignRefresh.Text = "Refresh"
        Me.btnAssignRefresh.UseVisualStyleBackColor = True
        '
        'TabResidentAddress
        '
        Me.TabResidentAddress.Controls.Add(Me.lblResAddrRowCount)
        Me.TabResidentAddress.Controls.Add(Me.tbResAddrResStatus)
        Me.TabResidentAddress.Controls.Add(Me.Label31)
        Me.TabResidentAddress.Controls.Add(Me.cbResAddrAddrID)
        Me.TabResidentAddress.Controls.Add(Me.cbResAddrResID)
        Me.TabResidentAddress.Controls.Add(Me.Label27)
        Me.TabResidentAddress.Controls.Add(Me.Label28)
        Me.TabResidentAddress.Controls.Add(Me.Label29)
        Me.TabResidentAddress.Controls.Add(Me.datagridResAddr)
        Me.TabResidentAddress.Controls.Add(Me.btnResAddrDelete)
        Me.TabResidentAddress.Controls.Add(Me.btnResAddrUpdate)
        Me.TabResidentAddress.Controls.Add(Me.btnResAddrInsert)
        Me.TabResidentAddress.Controls.Add(Me.btnResAddrRefresh)
        Me.TabResidentAddress.Location = New System.Drawing.Point(4, 38)
        Me.TabResidentAddress.Name = "TabResidentAddress"
        Me.TabResidentAddress.Size = New System.Drawing.Size(1415, 877)
        Me.TabResidentAddress.TabIndex = 5
        Me.TabResidentAddress.Text = "ResidentAddress"
        Me.TabResidentAddress.UseVisualStyleBackColor = True
        '
        'tbResAddrResStatus
        '
        Me.tbResAddrResStatus.Location = New System.Drawing.Point(1072, 293)
        Me.tbResAddrResStatus.Name = "tbResAddrResStatus"
        Me.tbResAddrResStatus.Size = New System.Drawing.Size(278, 35)
        Me.tbResAddrResStatus.TabIndex = 83
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(891, 299)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(175, 29)
        Me.Label31.TabIndex = 82
        Me.Label31.Text = "ResidentStatus"
        '
        'cbResAddrAddrID
        '
        Me.cbResAddrAddrID.FormattingEnabled = True
        Me.cbResAddrAddrID.Location = New System.Drawing.Point(1072, 240)
        Me.cbResAddrAddrID.Name = "cbResAddrAddrID"
        Me.cbResAddrAddrID.Size = New System.Drawing.Size(278, 37)
        Me.cbResAddrAddrID.TabIndex = 81
        '
        'cbResAddrResID
        '
        Me.cbResAddrResID.FormattingEnabled = True
        Me.cbResAddrResID.Location = New System.Drawing.Point(1072, 191)
        Me.cbResAddrResID.Name = "cbResAddrResID"
        Me.cbResAddrResID.Size = New System.Drawing.Size(278, 37)
        Me.cbResAddrResID.TabIndex = 80
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(35, 59)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(259, 37)
        Me.Label27.TabIndex = 79
        Me.Label27.Text = "ResidentAddress"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(891, 243)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(125, 29)
        Me.Label28.TabIndex = 78
        Me.Label28.Text = "AddressID"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(891, 191)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(132, 29)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "ResidentID"
        '
        'datagridResAddr
        '
        Me.datagridResAddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridResAddr.Location = New System.Drawing.Point(42, 177)
        Me.datagridResAddr.Name = "datagridResAddr"
        Me.datagridResAddr.RowHeadersWidth = 62
        Me.datagridResAddr.Size = New System.Drawing.Size(816, 474)
        Me.datagridResAddr.TabIndex = 76
        '
        'btnResAddrDelete
        '
        Me.btnResAddrDelete.Location = New System.Drawing.Point(1157, 535)
        Me.btnResAddrDelete.Name = "btnResAddrDelete"
        Me.btnResAddrDelete.Size = New System.Drawing.Size(112, 38)
        Me.btnResAddrDelete.TabIndex = 75
        Me.btnResAddrDelete.Text = "Delete"
        Me.btnResAddrDelete.UseVisualStyleBackColor = True
        '
        'btnResAddrUpdate
        '
        Me.btnResAddrUpdate.Location = New System.Drawing.Point(960, 535)
        Me.btnResAddrUpdate.Name = "btnResAddrUpdate"
        Me.btnResAddrUpdate.Size = New System.Drawing.Size(112, 38)
        Me.btnResAddrUpdate.TabIndex = 74
        Me.btnResAddrUpdate.Text = "Update"
        Me.btnResAddrUpdate.UseVisualStyleBackColor = True
        '
        'btnResAddrInsert
        '
        Me.btnResAddrInsert.Location = New System.Drawing.Point(1157, 450)
        Me.btnResAddrInsert.Name = "btnResAddrInsert"
        Me.btnResAddrInsert.Size = New System.Drawing.Size(112, 38)
        Me.btnResAddrInsert.TabIndex = 73
        Me.btnResAddrInsert.Text = "Insert"
        Me.btnResAddrInsert.UseVisualStyleBackColor = True
        '
        'btnResAddrRefresh
        '
        Me.btnResAddrRefresh.Location = New System.Drawing.Point(960, 450)
        Me.btnResAddrRefresh.Name = "btnResAddrRefresh"
        Me.btnResAddrRefresh.Size = New System.Drawing.Size(112, 38)
        Me.btnResAddrRefresh.TabIndex = 72
        Me.btnResAddrRefresh.Text = "Refresh"
        Me.btnResAddrRefresh.UseVisualStyleBackColor = True
        '
        'lblResRowCount
        '
        Me.lblResRowCount.AutoSize = True
        Me.lblResRowCount.Location = New System.Drawing.Point(41, 119)
        Me.lblResRowCount.Name = "lblResRowCount"
        Me.lblResRowCount.Size = New System.Drawing.Size(0, 29)
        Me.lblResRowCount.TabIndex = 56
        '
        'lblEmpRowCount
        '
        Me.lblEmpRowCount.AutoSize = True
        Me.lblEmpRowCount.Location = New System.Drawing.Point(36, 133)
        Me.lblEmpRowCount.Name = "lblEmpRowCount"
        Me.lblEmpRowCount.Size = New System.Drawing.Size(0, 29)
        Me.lblEmpRowCount.TabIndex = 77
        '
        'lblRegRowCount
        '
        Me.lblRegRowCount.AutoSize = True
        Me.lblRegRowCount.Location = New System.Drawing.Point(40, 113)
        Me.lblRegRowCount.Name = "lblRegRowCount"
        Me.lblRegRowCount.Size = New System.Drawing.Size(0, 29)
        Me.lblRegRowCount.TabIndex = 70
        '
        'lblAddrRowCount
        '
        Me.lblAddrRowCount.AutoSize = True
        Me.lblAddrRowCount.Location = New System.Drawing.Point(42, 114)
        Me.lblAddrRowCount.Name = "lblAddrRowCount"
        Me.lblAddrRowCount.Size = New System.Drawing.Size(0, 29)
        Me.lblAddrRowCount.TabIndex = 77
        '
        'lblAssignRowCount
        '
        Me.lblAssignRowCount.AutoSize = True
        Me.lblAssignRowCount.Location = New System.Drawing.Point(35, 116)
        Me.lblAssignRowCount.Name = "lblAssignRowCount"
        Me.lblAssignRowCount.Size = New System.Drawing.Size(0, 29)
        Me.lblAssignRowCount.TabIndex = 72
        '
        'lblResAddrRowCount
        '
        Me.lblResAddrRowCount.AutoSize = True
        Me.lblResAddrRowCount.Location = New System.Drawing.Point(37, 114)
        Me.lblResAddrRowCount.Name = "lblResAddrRowCount"
        Me.lblResAddrRowCount.Size = New System.Drawing.Size(0, 29)
        Me.lblResAddrRowCount.TabIndex = 84
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 953)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "US Census DB"
        Me.TabControl1.ResumeLayout(False)
        Me.TabResidents.ResumeLayout(False)
        Me.TabResidents.PerformLayout()
        CType(Me.datagridRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEmployees.ResumeLayout(False)
        Me.TabEmployees.PerformLayout()
        CType(Me.datagridEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRegions.ResumeLayout(False)
        Me.TabRegions.PerformLayout()
        CType(Me.datagridReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAddresses.ResumeLayout(False)
        Me.TabAddresses.PerformLayout()
        CType(Me.datagridAddr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAssignments.ResumeLayout(False)
        Me.TabAssignments.PerformLayout()
        CType(Me.datagridAssign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabResidentAddress.ResumeLayout(False)
        Me.TabResidentAddress.PerformLayout()
        CType(Me.datagridResAddr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabResidents As TabPage
    Friend WithEvents TabEmployees As TabPage
    Friend WithEvents TabRegions As TabPage
    Friend WithEvents TabAddresses As TabPage
    Friend WithEvents TabAssignments As TabPage
    Friend WithEvents TabResidentAddress As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbResRace As TextBox
    Friend WithEvents tbResSex As TextBox
    Friend WithEvents tbResDoB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents datagridRes As DataGridView
    Friend WithEvents tbResLN As TextBox
    Friend WithEvents tbResMN As TextBox
    Friend WithEvents tbResFN As TextBox
    Friend WithEvents tbResResID As TextBox
    Friend WithEvents btnResDelete As Button
    Friend WithEvents btnResUpdate As Button
    Friend WithEvents btnResInsert As Button
    Friend WithEvents btnResRefresh As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbEmpSalary As TextBox
    Friend WithEvents tbEmpPosition As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents datagridEmp As DataGridView
    Friend WithEvents tbEmpLN As TextBox
    Friend WithEvents tbEmpFN As TextBox
    Friend WithEvents tbEmpEmpID As TextBox
    Friend WithEvents btnEmpDelete As Button
    Friend WithEvents btnEmpUpdate As Button
    Friend WithEvents btnEmpInsert As Button
    Friend WithEvents btnEmpRefresh As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents datagridReg As DataGridView
    Friend WithEvents tbRegRegDesc As TextBox
    Friend WithEvents tbRegRegID As TextBox
    Friend WithEvents btnRegDelete As Button
    Friend WithEvents btnRegUpdate As Button
    Friend WithEvents btnRegInsert As Button
    Friend WithEvents btnRegRefresh As Button
    Friend WithEvents cbAddrRegID As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tbAddrZipCode As TextBox
    Friend WithEvents tbAddrState As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents datagridAddr As DataGridView
    Friend WithEvents tbAddrCity As TextBox
    Friend WithEvents tbAddrStreet As TextBox
    Friend WithEvents tbAddrNum As TextBox
    Friend WithEvents tbAddrAddrID As TextBox
    Friend WithEvents btnAddrDelete As Button
    Friend WithEvents btnAddrUpdate As Button
    Friend WithEvents btnAddrInsert As Button
    Friend WithEvents btnAddrRefresh As Button
    Friend WithEvents cbAssignRegID As ComboBox
    Friend WithEvents cbAssignEmpID As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents datagridAssign As DataGridView
    Friend WithEvents btnAssignDelete As Button
    Friend WithEvents btnAssignInsert As Button
    Friend WithEvents btnAssignRefresh As Button
    Friend WithEvents tbResAddrResStatus As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents cbResAddrAddrID As ComboBox
    Friend WithEvents cbResAddrResID As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents datagridResAddr As DataGridView
    Friend WithEvents btnResAddrDelete As Button
    Friend WithEvents btnResAddrUpdate As Button
    Friend WithEvents btnResAddrInsert As Button
    Friend WithEvents btnResAddrRefresh As Button
    Friend WithEvents cbEmpManagerID As ComboBox
    Friend WithEvents lblResRowCount As Label
    Friend WithEvents lblEmpRowCount As Label
    Friend WithEvents lblRegRowCount As Label
    Friend WithEvents lblAddrRowCount As Label
    Friend WithEvents lblAssignRowCount As Label
    Friend WithEvents lblResAddrRowCount As Label
End Class
