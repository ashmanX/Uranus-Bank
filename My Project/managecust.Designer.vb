<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managecust
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
        Label1 = New Label()
        acno = New TextBox()
        searchbtn = New Button()
        Label2 = New Label()
        cname = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        balance = New TextBox()
        Label5 = New Label()
        age = New TextBox()
        gender = New ComboBox()
        Label6 = New Label()
        address = New TextBox()
        Label7 = New Label()
        phone = New TextBox()
        Label8 = New Label()
        addbtn = New Button()
        editbtn = New Button()
        deletebtn = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(8), CByte(107), CByte(107))
        Label1.Font = New Font("Product Sans Medium", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(648, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(569, 78)
        Label1.TabIndex = 2
        Label1.Text = "Manage Customers"' 
        ' acno
        ' 
        acno.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        acno.Location = New Point(734, 211)
        acno.Name = "acno"
        acno.Size = New Size(354, 50)
        acno.TabIndex = 3
        ' 
        ' searchbtn
        ' 
        searchbtn.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        searchbtn.Location = New Point(1135, 207)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(228, 56)
        searchbtn.TabIndex = 4
        searchbtn.Text = "🔍 Search"
        searchbtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(424, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(293, 42)
        Label2.TabIndex = 5
        Label2.Text = "Account Number:"' 
        ' cname
        ' 
        cname.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        cname.Location = New Point(235, 383)
        cname.Name = "cname"
        cname.Size = New Size(426, 50)
        cname.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(111, 383)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 42)
        Label3.TabIndex = 7
        Label3.Text = "Name:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(719, 392)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 42)
        Label4.TabIndex = 9
        Label4.Text = "Balance:"' 
        ' balance
        ' 
        balance.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        balance.Location = New Point(872, 385)
        balance.Name = "balance"
        balance.Size = New Size(404, 50)
        balance.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(1345, 387)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 42)
        Label5.TabIndex = 11
        Label5.Text = "Age:"' 
        ' age
        ' 
        age.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        age.Location = New Point(1441, 382)
        age.Name = "age"
        age.Size = New Size(221, 50)
        age.TabIndex = 10
        ' 
        ' gender
        ' 
        gender.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        gender.FormattingEnabled = True
        gender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        gender.Location = New Point(253, 521)
        gender.Name = "gender"
        gender.Size = New Size(268, 53)
        gender.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(102, 528)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 42)
        Label6.TabIndex = 13
        Label6.Text = "Gender:"' 
        ' address
        ' 
        address.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        address.Location = New Point(762, 523)
        address.Name = "address"
        address.Size = New Size(354, 50)
        address.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(598, 528)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 42)
        Label7.TabIndex = 15
        Label7.Text = "Address:"' 
        ' phone
        ' 
        phone.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        phone.Location = New Point(1308, 526)
        phone.Name = "phone"
        phone.Size = New Size(354, 50)
        phone.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(1173, 531)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 42)
        Label8.TabIndex = 17
        Label8.Text = "Phone:"' 
        ' addbtn
        ' 
        addbtn.BackColor = Color.FromArgb(CByte(190), CByte(240), CByte(203))
        addbtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        addbtn.ForeColor = Color.Black
        addbtn.Location = New Point(728, 774)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(347, 87)
        addbtn.TabIndex = 18
        addbtn.Text = "Create Account"
        addbtn.UseVisualStyleBackColor = False
        ' 
        ' editbtn
        ' 
        editbtn.BackColor = Color.FromArgb(CByte(255), CByte(244), CByte(210))
        editbtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        editbtn.ForeColor = Color.Black
        editbtn.Location = New Point(196, 774)
        editbtn.Name = "editbtn"
        editbtn.Size = New Size(320, 87)
        editbtn.TabIndex = 19
        editbtn.Text = "Update Changes"
        editbtn.UseVisualStyleBackColor = False
        ' 
        ' deletebtn
        ' 
        deletebtn.BackColor = Color.FromArgb(CByte(233), CByte(100), CByte(121))
        deletebtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        deletebtn.ForeColor = Color.White
        deletebtn.Location = New Point(1282, 774)
        deletebtn.Name = "deletebtn"
        deletebtn.Size = New Size(332, 87)
        deletebtn.TabIndex = 20
        deletebtn.Text = "Delete Account"
        deletebtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1517, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(217, 83)
        Button1.TabIndex = 21
        Button1.Text = "🏠 Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' managecust
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        BackgroundImage = My.Resources.Resources.URANUS_BANK
        ClientSize = New Size(1812, 1070)
        Controls.Add(Button1)
        Controls.Add(deletebtn)
        Controls.Add(editbtn)
        Controls.Add(addbtn)
        Controls.Add(Label8)
        Controls.Add(phone)
        Controls.Add(Label7)
        Controls.Add(address)
        Controls.Add(Label6)
        Controls.Add(gender)
        Controls.Add(Label5)
        Controls.Add(age)
        Controls.Add(Label4)
        Controls.Add(balance)
        Controls.Add(Label3)
        Controls.Add(cname)
        Controls.Add(Label2)
        Controls.Add(searchbtn)
        Controls.Add(acno)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "managecust"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Customers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents acno As TextBox
    Friend WithEvents searchbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents balance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents age As TextBox
    Friend WithEvents gender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents addbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents Button1 As Button
End Class
