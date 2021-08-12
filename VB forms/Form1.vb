Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String
    Dim conn As New SqlConnection
    Dim sqlComm As New SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim DataReader As SqlDataReader


    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridRes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridRes.ReadOnly = True
        datagridEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridEmp.ReadOnly = True
        datagridReg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridReg.ReadOnly = True
        datagridAssign.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridAssign.ReadOnly = True
        datagridAddr.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridAddr.ReadOnly = True
        datagridResAddr.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        datagridResAddr.ReadOnly = True
    End Sub

    'Refresh Buttons
    Private Sub BtnResRefresh_Click(sender As Object, e As EventArgs) Handles btnResRefresh.Click
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds.Clear()
        datagridRes.DataSource = ds
        datagridRes.DataSource = Nothing
        tbResResID.Text = ""
        tbResFN.Text = ""
        tbResMN.Text = ""
        tbResLN.Text = ""
        tbResRace.Text = ""
        tbResSex.Text = ""
        tbResDoB.Text = ""

        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)

        conn.Open()
        adapter = New SqlDataAdapter("select * from census.Residents", conn)
        adapter.Fill(ds)
        adapter = New SqlDataAdapter("select count(*) from census.Residents", conn)
        adapter.Fill(ds1)
        conn.Close()
        lblResRowCount.Text = "Row Count: " + ds1.Tables(0).Rows(0)(0).ToString()
        datagridRes.DataSource = ds.Tables(0)


    End Sub
    Private Sub BtnEmpRefresh_Click(sender As Object, e As EventArgs) Handles btnEmpRefresh.Click
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        ds.Clear()
        datagridEmp.DataSource = ds
        datagridEmp.DataSource = Nothing
        tbEmpEmpID.Text = ""
        tbEmpFN.Text = ""
        tbEmpLN.Text = ""
        tbEmpSalary.Text = ""
        tbEmpPosition.Text = ""

        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)

        conn.Open()
        adapter = New SqlDataAdapter("select * from census.Employees", conn)
        adapter.Fill(ds)
        adapter = New SqlDataAdapter("select EmployeeID from census.Employees WHERE Position LIKE '%supervisor%' OR Position LIKE '%director%'", conn)
        adapter.Fill(ds1)
        adapter = New SqlDataAdapter("select Count(*) from census.Employees", conn)
        adapter.Fill(ds2)
        conn.Close()
        datagridEmp.DataSource = ds.Tables(0)
        cbEmpManagerID.DataSource = ds1.Tables(0)
        cbEmpManagerID.ValueMember = "EmployeeID"
        lblEmpRowCount.Text = "Row Count: " + ds2.Tables(0).Rows(0)(0).ToString()
    End Sub
    Private Sub BtnRegRefresh_Click(sender As Object, e As EventArgs) Handles btnRegRefresh.Click
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds.Clear()
        datagridReg.DataSource = ds
        datagridReg.DataSource = Nothing
        tbRegRegID.Text = ""
        tbRegRegDesc.Text = ""


        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)

        conn.Open()
        adapter = New SqlDataAdapter("select * from census.Regions", conn)
        adapter.Fill(ds)
        adapter = New SqlDataAdapter("select count(*) from census.Regions", conn)
        adapter.Fill(ds1)
        conn.Close()
        lblRegRowCount.Text = "Row Count: " + ds1.Tables(0).Rows(0)(0).ToString()
        datagridReg.DataSource = ds.Tables(0)
    End Sub
    Private Sub BtnAddrRefresh_Click(sender As Object, e As EventArgs) Handles btnAddrRefresh.Click
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        ds.Clear()
        datagridAddr.DataSource = ds
        datagridAddr.DataSource = Nothing
        tbAddrAddrID.Text = ""
        tbAddrNum.Text = ""
        tbAddrStreet.Text = ""
        tbAddrCity.Text = ""
        tbAddrState.Text = ""
        tbAddrZipCode.Text = ""

        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)

        conn.Open()
        adapter = New SqlDataAdapter("select * from census.Addresses", conn)
        adapter.Fill(ds)
        adapter = New SqlDataAdapter("select RegionID from census.Regions", conn)
        adapter.Fill(ds1)
        adapter = New SqlDataAdapter("select Count(*) from census.Addresses", conn)
        adapter.Fill(ds2)
        conn.Close()
        lblAddrRowCount.Text = "Row Count: " + ds2.Tables(0).Rows(0)(0).ToString()
        datagridAddr.DataSource = ds.Tables(0)
        cbAddrRegID.DataSource = ds1.Tables(0)
        cbAddrRegID.ValueMember = "RegionID"

    End Sub
    Private Sub BtnAssignRefresh_Click(sender As Object, e As EventArgs) Handles btnAssignRefresh.Click
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim ds3 As New DataSet
        ds.Clear()
        datagridAssign.DataSource = ds
        datagridAssign.DataSource = Nothing

        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)

        conn.Open()
        adapter = New SqlDataAdapter("select * from census.Assignments", conn)
        adapter.Fill(ds)
        adapter = New SqlDataAdapter("select EmployeeID from census.Employees", conn)
        adapter.Fill(ds1)
        adapter = New SqlDataAdapter("select RegionID from census.Regions", conn)
        adapter.Fill(ds2)
        adapter = New SqlDataAdapter("select COUNT(*) from census.Assignments", conn)
        adapter.Fill(ds3)
        conn.Close()
        lblAssignRowCount.Text = "Row Count: " + ds3.Tables(0).Rows(0)(0).ToString()
        datagridAssign.DataSource = ds.Tables(0)
        cbAssignEmpID.DataSource = ds1.Tables(0)
        cbAssignEmpID.ValueMember = "EmployeeID"
        cbAssignRegID.DataSource = ds2.Tables(0)
        cbAssignRegID.ValueMember = "RegionID"
    End Sub
    Private Sub BtnResAddrRefresh_Click(sender As Object, e As EventArgs) Handles btnResAddrRefresh.Click
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim ds3 As New DataSet
        ds.Clear()
        ds1.Clear()
        datagridResAddr.DataSource = ds
        datagridResAddr.DataSource = Nothing

        tbResAddrResStatus.Text = ""

        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)

        conn.Open()
        adapter = New SqlDataAdapter("select * from census.ResidentAddress", conn)
        adapter.Fill(ds)
        adapter = New SqlDataAdapter("select ResidentID from census.Residents", conn)
        adapter.Fill(ds1)
        adapter = New SqlDataAdapter("select AddressID from census.Addresses", conn)
        adapter.Fill(ds2)
        adapter = New SqlDataAdapter("select Count(*) from census.ResidentAddress", conn)
        adapter.Fill(ds3)
        conn.Close()
        lblResAddrRowCount.Text = "Row Count: " + ds3.Tables(0).Rows(0)(0).ToString()
        datagridResAddr.DataSource = ds.Tables(0)
        cbResAddrResID.DataSource = ds1.Tables(0)
        cbResAddrResID.ValueMember = "ResidentID"
        cbResAddrAddrID.DataSource = ds2.Tables(0)
        cbResAddrAddrID.ValueMember = "AddressID"
    End Sub


    'DataGrid Clicks
    Private Sub DatagridRes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridRes.CellContentClick
        If (e.RowIndex > -1) And Not (datagridRes.SelectedRows(0).Cells(0).Value = Nothing) Then
            tbResResID.Text = datagridRes.SelectedRows(0).Cells(0).Value.ToString
            tbResFN.Text = datagridRes.SelectedRows(0).Cells(1).Value.ToString
            tbResMN.Text = datagridRes.SelectedRows(0).Cells(2).Value.ToString
            tbResLN.Text = datagridRes.SelectedRows(0).Cells(3).Value.ToString
            tbResDoB.Text = datagridRes.SelectedRows(0).Cells(4).Value.ToString
            tbResSex.Text = datagridRes.SelectedRows(0).Cells(5).Value.ToString
            tbResRace.Text = datagridRes.SelectedRows(0).Cells(6).Value.ToString
        Else
            tbResResID.Text = ""
            tbResFN.Text = ""
            tbResMN.Text = ""
            tbResLN.Text = ""
            tbResRace.Text = ""
            tbResSex.Text = ""
            tbResDoB.Text = ""
        End If
    End Sub
    Private Sub DatagridEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridEmp.CellContentClick

        If (e.RowIndex > -1) And Not (datagridEmp.SelectedRows(0).Cells(0).Value = Nothing) Then
            cbEmpManagerID.Text = ""
            tbEmpEmpID.Text = datagridEmp.SelectedRows(0).Cells(0).Value.ToString
            tbEmpFN.Text = datagridEmp.SelectedRows(0).Cells(1).Value.ToString
            tbEmpLN.Text = datagridEmp.SelectedRows(0).Cells(2).Value.ToString
            tbEmpSalary.Text = datagridEmp.SelectedRows(0).Cells(3).Value.ToString
            tbEmpPosition.Text = datagridEmp.SelectedRows(0).Cells(4).Value.ToString
            cbEmpManagerID.Text = datagridEmp.SelectedRows(0).Cells(5).Value.ToString
        Else
            tbEmpEmpID.Text = ""
            tbEmpFN.Text = ""
            tbEmpLN.Text = ""
            tbEmpPosition.Text = ""
            tbEmpSalary.Text = ""
        End If
    End Sub
    Private Sub DatagridReg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridReg.CellContentClick
        If (e.RowIndex > -1) And Not (datagridReg.SelectedRows(0).Cells(0).Value = Nothing) Then
            tbRegRegID.Text = datagridReg.SelectedRows(0).Cells(0).Value.ToString
            tbRegRegDesc.Text = datagridReg.SelectedRows(0).Cells(1).Value.ToString
        Else
            tbRegRegID.Text = ""
            tbRegRegDesc.Text = ""
        End If
    End Sub
    Private Sub DatagridAddr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridAddr.CellContentClick
        cbAddrRegID.Text = ""
        If (e.RowIndex > -1) And Not (datagridAddr.SelectedRows(0).Cells(0).Value = Nothing) Then
            tbAddrAddrID.Text = datagridAddr.SelectedRows(0).Cells(0).Value.ToString
            tbAddrNum.Text = datagridAddr.SelectedRows(0).Cells(1).Value.ToString
            tbAddrStreet.Text = datagridAddr.SelectedRows(0).Cells(2).Value.ToString
            tbAddrCity.Text = datagridAddr.SelectedRows(0).Cells(3).Value.ToString
            tbAddrState.Text = datagridAddr.SelectedRows(0).Cells(4).Value.ToString
            tbAddrZipCode.Text = datagridAddr.SelectedRows(0).Cells(5).Value.ToString
            cbAddrRegID.Text = datagridAddr.SelectedRows(0).Cells(6).Value.ToString
        Else
            tbAddrAddrID.Text = ""
            tbAddrNum.Text = ""
            tbAddrStreet.Text = ""
            tbAddrCity.Text = ""
            tbAddrState.Text = ""
            tbAddrZipCode.Text = ""
        End If
    End Sub
    Private Sub DatagridAssign_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridAssign.CellContentClick
        cbAssignRegID.Text = ""
        cbAssignEmpID.Text = ""
        If (e.RowIndex > -1) And Not (datagridAssign.SelectedRows(0).Cells(0).Value = Nothing) Then
            cbAssignRegID.Text = datagridAssign.SelectedRows(0).Cells(1).Value.ToString
            cbAssignEmpID.Text = datagridAssign.SelectedRows(0).Cells(0).Value.ToString
        Else
            cbAssignRegID.Text = ""
            cbAssignEmpID.Text = ""
        End If
    End Sub
    Private Sub DatagridResAddr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridResAddr.CellContentClick
        cbResAddrResID.Text = ""
        cbResAddrAddrID.Text = ""

        If (e.RowIndex > -1) And Not (datagridResAddr.SelectedRows(0).Cells(0).Value = Nothing) Then
            cbResAddrResID.Text = datagridResAddr.SelectedRows(0).Cells(0).Value.ToString
            cbResAddrAddrID.Text = datagridResAddr.SelectedRows(0).Cells(1).Value.ToString
            tbResAddrResStatus.Text = datagridResAddr.SelectedRows(0).Cells(2).Value.ToString
        Else
            cbResAddrResID.Text = ""
            cbResAddrAddrID.Text = ""
            tbResAddrResStatus.Text = ""
        End If
    End Sub


    'Insert Buttons
    Private Sub BtnResInsert_Click(sender As Object, e As EventArgs) Handles btnResInsert.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If tbResResID.Text = "" Or tbResFN.Text = "" Or tbResLN.Text = "" Or tbResRace.Text = "" Or tbResDoB.Text = "" Or tbResSex.Text = "" Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "Insert into census.Residents(residentID, firstName, middleName, lastName, race, sex, DoB) values(@residentID, @firstName, @middleName, @lastName, @race, @sex, @DoB)"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@residentID", tbResResID.Text)
        sqlComm.Parameters.AddWithValue("@firstName", tbResFN.Text)
        sqlComm.Parameters.AddWithValue("@middleName", tbResMN.Text)
        sqlComm.Parameters.AddWithValue("@lastName", tbResLN.Text)
        sqlComm.Parameters.AddWithValue("@race", tbResRace.Text)
        sqlComm.Parameters.AddWithValue("@sex", tbResSex.Text)
        sqlComm.Parameters.AddWithValue("@DoB", tbResDoB.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Insert Exception: " + ex.Message.ToString)
            Return
        End Try


        MsgBox("New Resident has been inserted")

        tbResResID.Text = ""
        tbResFN.Text = ""
        tbResMN.Text = ""
        tbResLN.Text = ""
        tbResRace.Text = ""
        tbResSex.Text = ""
        tbResDoB.Text = ""

        BtnResRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnEmpInsert_Click(sender As Object, e As EventArgs) Handles btnEmpInsert.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbEmpEmpID.Text = "" Or
            tbEmpFN.Text = "" Or
            tbEmpLN.Text = "" Or
            tbEmpSalary.Text = "" Or
            tbEmpPosition.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "Insert into census.Employees(employeeID, firstName, lastName, salary, position, managerID) 
            values(@employeeID, @firstName, @lastName, @salary, @position, @managerID)"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@employeeID", tbEmpEmpID.Text)
        sqlComm.Parameters.AddWithValue("@firstName", tbEmpFN.Text)
        sqlComm.Parameters.AddWithValue("@lastName", tbEmpLN.Text)
        sqlComm.Parameters.AddWithValue("@salary", tbEmpSalary.Text)
        sqlComm.Parameters.AddWithValue("@position", tbEmpPosition.Text)
        sqlComm.Parameters.AddWithValue("@managerID", cbEmpManagerID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Insert Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("New Employee has been inserted")

        tbEmpEmpID.Text = ""
        tbEmpFN.Text = ""
        tbEmpLN.Text = ""
        tbEmpSalary.Text = ""
        tbEmpPosition.Text = ""
        cbEmpManagerID.Text = ""

        BtnEmpRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnRegInsert_Click(sender As Object, e As EventArgs) Handles btnRegInsert.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbRegRegID.Text = "" Or
            tbRegRegDesc.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "Insert into census.Regions(RegionID, RegionDesc) 
            values(@RegionID, @RegionDesc)"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@RegionID", tbRegRegID.Text)
        sqlComm.Parameters.AddWithValue("@RegionDesc", tbRegRegDesc.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Insert Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("New Region has been inserted")

        tbRegRegID.Text = ""
        tbRegRegDesc.Text = ""

        BtnRegRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnAddrInsert_Click(sender As Object, e As EventArgs) Handles btnAddrInsert.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbAddrAddrID.Text = "" Or
            tbAddrNum.Text = "" Or
            tbAddrStreet.Text = "" Or
            tbAddrCity.Text = "" Or
            tbAddrState.Text = "" Or
            tbAddrZipCode.Text = "" Or
            cbAddrRegID.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "Insert into census.Addresses(AddressID, Number, Street, City, State, ZipCode, RegionID) 
            values(@AddressID, @Number, @Street, @City, @State, @ZipCode, @RegionID)"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@AddressID", tbRegRegID.Text)
        sqlComm.Parameters.AddWithValue("@Number", tbRegRegDesc.Text)
        sqlComm.Parameters.AddWithValue("@Street", tbRegRegID.Text)
        sqlComm.Parameters.AddWithValue("@City", tbRegRegDesc.Text)
        sqlComm.Parameters.AddWithValue("@State", tbRegRegID.Text)
        sqlComm.Parameters.AddWithValue("@ZipCode", tbRegRegDesc.Text)
        sqlComm.Parameters.AddWithValue("@RegionID", cbAddrRegID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Insert Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("New Address has been inserted")

        tbAddrAddrID.Text = ""
        tbAddrNum.Text = ""
        tbAddrStreet.Text = ""
        tbAddrCity.Text = ""
        tbAddrState.Text = ""
        tbAddrZipCode.Text = ""
        cbAddrRegID.Text = ""

        BtnAddrRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnAssignInsert_Click(sender As Object, e As EventArgs) Handles btnAssignInsert.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (cbAssignRegID.Text = "" Or
            cbAssignEmpID.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "Insert into census.Assignments(EmployeeID, RegionID) 
            values(@EmployeeID, @RegionID)"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@EmployeeID", cbAssignEmpID.Text)
        sqlComm.Parameters.AddWithValue("@RegionID", cbAssignRegID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Insert Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("New Assignment has been inserted")

        cbAssignRegID.Text = ""
        cbAssignEmpID.Text = ""

        BtnAssignRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnResAddrInsert_Click(sender As Object, e As EventArgs) Handles btnResAddrInsert.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (cbResAddrResID.Text = "" Or
            cbResAddrAddrID.Text = "" Or
            tbResAddrResStatus.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "Insert into census.ResidentAddress(ResidentID, AddressID, ResidentStatus) 
            values(@ResidentID, @AddressID, @ResidentStatus)"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@ResidentID", cbResAddrResID.Text)
        sqlComm.Parameters.AddWithValue("@AddressID", cbResAddrAddrID.Text)
        sqlComm.Parameters.AddWithValue("@ResidentStatus", tbResAddrResStatus.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Insert Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("New Resident Address mapping has been inserted")
        cbResAddrResID.Text = ""
        cbResAddrAddrID.Text = ""
        tbResAddrResStatus.Text = ""

        BtnResAddrRefresh_Click(sender, New System.EventArgs())
    End Sub


    'Delete Buttons
    Private Sub BtnResDelete_Click(sender As Object, e As EventArgs) Handles btnResDelete.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If tbResResID.Text = "" Or tbResFN.Text = "" Or tbResLN.Text = "" Or tbResRace.Text = "" Or tbResDoB.Text = "" Or tbResSex.Text = "" Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "DELETE FROM census.Residents WHERE residentID = @residentID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@residentID", tbResResID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL DELETE Exception: " + ex.Message.ToString)
            Return
        End Try


        MsgBox("The resident has been deleted")

        tbResResID.Text = ""
        tbResFN.Text = ""
        tbResMN.Text = ""
        tbResLN.Text = ""
        tbResRace.Text = ""
        tbResSex.Text = ""
        tbResDoB.Text = ""

        BtnResRefresh_Click(sender, New System.EventArgs())

    End Sub
    Private Sub BtnEmpDelete_Click(sender As Object, e As EventArgs) Handles btnEmpDelete.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbEmpEmpID.Text = "" Or
            tbEmpFN.Text = "" Or
            tbEmpLN.Text = "" Or
            tbEmpSalary.Text = "" Or
            tbEmpPosition.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "DELETE FROM census.Employees WHERE employeeID = @employeeID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@employeeID", tbEmpEmpID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Delete Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The employee has been deleted")

        tbEmpEmpID.Text = ""
        tbEmpFN.Text = ""
        tbEmpLN.Text = ""
        tbEmpSalary.Text = ""
        tbEmpPosition.Text = ""
        cbEmpManagerID.Text = ""

        BtnEmpRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnRegDelete_Click(sender As Object, e As EventArgs) Handles btnRegDelete.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbRegRegID.Text = "" Or
            tbRegRegDesc.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "DELETE FROM census.Regions WHERE RegionID = @RegionID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@RegionID", tbRegRegID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL DELETE Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The Region has been deleted")

        tbRegRegID.Text = ""
        tbRegRegDesc.Text = ""

        BtnRegRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnAddrDelete_Click(sender As Object, e As EventArgs) Handles btnAddrDelete.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbAddrAddrID.Text = "" Or
            tbAddrNum.Text = "" Or
            tbAddrStreet.Text = "" Or
            tbAddrCity.Text = "" Or
            tbAddrState.Text = "" Or
            tbAddrZipCode.Text = "" Or
            cbAddrRegID.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "DELETE FROM census.Addresses WHERE AddressID = @AddressID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@AddressID", tbRegRegID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Delete Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The address has been deleted")

        tbAddrAddrID.Text = ""
        tbAddrNum.Text = ""
        tbAddrStreet.Text = ""
        tbAddrCity.Text = ""
        tbAddrState.Text = ""
        tbAddrZipCode.Text = ""
        cbAddrRegID.Text = ""

        BtnAddrRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnAssignDelete_Click(sender As Object, e As EventArgs) Handles btnAssignDelete.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (cbAssignRegID.Text = "" Or
            cbAssignEmpID.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "DELETE FROM census.Assignments WHERE EmployeeID = @EmployeeID AND RegionID = @RegionID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@EmployeeID", cbAssignEmpID.Text)
        sqlComm.Parameters.AddWithValue("@RegionID", cbAssignRegID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL DELETE Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The Assignment has been deleted")

        cbAssignRegID.Text = ""
        cbAssignEmpID.Text = ""

        BtnAssignRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnResAddrDelete_Click(sender As Object, e As EventArgs) Handles btnResAddrDelete.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (cbResAddrResID.Text = "" Or
            cbResAddrAddrID.Text = "" Or
            tbResAddrResStatus.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "DELETE FROM census.ResidentAddress WHERE ResidentID = @ResidentID AND AddressID = @AddressID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@ResidentID", cbResAddrResID.Text)
        sqlComm.Parameters.AddWithValue("@AddressID", cbResAddrAddrID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL DELETE Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The Resident Address mapping has been deleted")
        cbResAddrResID.Text = ""
        cbResAddrAddrID.Text = ""
        tbResAddrResStatus.Text = ""

        BtnResAddrRefresh_Click(sender, New System.EventArgs())
    End Sub


    'Update Buttons
    Private Sub BtnResUpdate_Click(sender As Object, e As EventArgs) Handles btnResUpdate.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If tbResResID.Text = "" Or tbResFN.Text = "" Or tbResLN.Text = "" Or tbResRace.Text = "" Or tbResDoB.Text = "" Or tbResSex.Text = "" Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "Update census.Residents SET firstName =@firstName, middleName =@middleName, lastName=@lastName, race=@race, sex=@sex, DoB=@DoB WHERE residentID = @residentID)"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@residentID", tbResResID.Text)
        sqlComm.Parameters.AddWithValue("@firstName", tbResFN.Text)
        sqlComm.Parameters.AddWithValue("@middleName", tbResMN.Text)
        sqlComm.Parameters.AddWithValue("@lastName", tbResLN.Text)
        sqlComm.Parameters.AddWithValue("@race", tbResRace.Text)
        sqlComm.Parameters.AddWithValue("@sex", tbResSex.Text)
        sqlComm.Parameters.AddWithValue("@DoB", tbResDoB.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Update Exception: " + ex.Message.ToString)
            Return
        End Try


        MsgBox("The Resident has been updated")

        tbResResID.Text = ""
        tbResFN.Text = ""
        tbResMN.Text = ""
        tbResLN.Text = ""
        tbResRace.Text = ""
        tbResSex.Text = ""
        tbResDoB.Text = ""

        BtnResRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnEmpUpdate_Click(sender As Object, e As EventArgs) Handles btnEmpUpdate.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbEmpEmpID.Text = "" Or
            tbEmpFN.Text = "" Or
            tbEmpLN.Text = "" Or
            tbEmpSalary.Text = "" Or
            tbEmpPosition.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "UPDATE census.Employees SET firstName=@firstName, lastName=@lastName, salary=@salary, position=@position, managerID=@managerID WHERE employeeID = @employeeID"

        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@employeeID", tbEmpEmpID.Text)
        sqlComm.Parameters.AddWithValue("@firstName", tbEmpFN.Text)
        sqlComm.Parameters.AddWithValue("@lastName", tbEmpLN.Text)
        sqlComm.Parameters.AddWithValue("@salary", tbEmpSalary.Text)
        sqlComm.Parameters.AddWithValue("@position", tbEmpPosition.Text)
        sqlComm.Parameters.AddWithValue("@managerID", cbEmpManagerID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Update Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The Employee has been updated")

        tbEmpEmpID.Text = ""
        tbEmpFN.Text = ""
        tbEmpLN.Text = ""
        tbEmpSalary.Text = ""
        tbEmpPosition.Text = ""
        cbEmpManagerID.Text = ""

        BtnEmpRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnRegUpdate_Click(sender As Object, e As EventArgs) Handles btnRegUpdate.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbRegRegID.Text = "" Or
            tbRegRegDesc.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "UPDATE census.Regions SET RegionDesc = @RegionDesc WHERE RegionID = @RegionID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@RegionID", tbRegRegID.Text)
        sqlComm.Parameters.AddWithValue("@RegionDesc", tbRegRegDesc.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Update Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The Region has been updated")

        tbRegRegID.Text = ""
        tbRegRegDesc.Text = ""

        BtnRegRefresh_Click(sender, New System.EventArgs())
    End Sub
    Private Sub BtnAddrUpdate_Click(sender As Object, e As EventArgs) Handles btnAddrUpdate.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (tbAddrAddrID.Text = "" Or
            tbAddrNum.Text = "" Or
            tbAddrStreet.Text = "" Or
            tbAddrCity.Text = "" Or
            tbAddrState.Text = "" Or
            tbAddrZipCode.Text = "" Or
            cbAddrRegID.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "UPDATE census.Addresses SET Number=@Number, Street=@Street, City=@City, State=@State, ZipCode=@ZipCode, RegionID=@RegionID WHERE AddressID=@AddressID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@AddressID", tbRegRegID.Text)
        sqlComm.Parameters.AddWithValue("@Number", tbRegRegDesc.Text)
        sqlComm.Parameters.AddWithValue("@Street", tbRegRegID.Text)
        sqlComm.Parameters.AddWithValue("@City", tbRegRegDesc.Text)
        sqlComm.Parameters.AddWithValue("@State", tbRegRegID.Text)
        sqlComm.Parameters.AddWithValue("@ZipCode", tbRegRegDesc.Text)
        sqlComm.Parameters.AddWithValue("@RegionID", tbRegRegID.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL Update Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The Address has been updated")

        tbAddrAddrID.Text = ""
        tbAddrNum.Text = ""
        tbAddrStreet.Text = ""
        tbAddrCity.Text = ""
        tbAddrState.Text = ""
        tbAddrZipCode.Text = ""
        cbAddrRegID.Text = ""

        BtnAddrRefresh_Click(sender, New System.EventArgs())
    End Sub
    'Private Sub BtnAssignUpdate_Click(sender As Object, e As EventArgs)

    'End Sub
    Private Sub BtnResAddrUpdate_Click(sender As Object, e As EventArgs) Handles btnResAddrUpdate.Click
        connectionString = "Initial Catalog=Student96;Data Source=stcs3;Integrated Security=SSPI;"
        conn = New SqlConnection(connectionString)
        conn.Open()
        sqlComm = conn.CreateCommand
        If (cbResAddrResID.Text = "" Or
            cbResAddrAddrID.Text = "" Or
            tbResAddrResStatus.Text = "") Then
            MsgBox("Enter Data")
            Return
        End If
        Dim strsql

        strsql = "UPDATE census.ResidentAddress SET ResidentStatus = @ResidentStatus WHERE  ResidentID=@ResidentID AND AddressID=@AddressID"
        sqlComm.CommandText = strsql
        sqlComm.Parameters.AddWithValue("@ResidentID", cbResAddrResID.Text)
        sqlComm.Parameters.AddWithValue("@AddressID", cbResAddrAddrID.Text)
        sqlComm.Parameters.AddWithValue("@ResidentStatus", tbResAddrResStatus.Text)
        'MsgBox(sqlComm.CommandText)
        adapter.InsertCommand = sqlComm
        Try
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("SQL UPDATE Exception: " + ex.Message.ToString)
            Return
        End Try

        MsgBox("The Resident Address mapping has been Updated")
        cbResAddrResID.Text = ""
        cbResAddrAddrID.Text = ""
        tbResAddrResStatus.Text = ""

        BtnResAddrRefresh_Click(sender, New System.EventArgs())
    End Sub



End Class
