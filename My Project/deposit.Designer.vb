<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deposit
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
        Label6 = New Label()
        transid = New TextBox()
        Label4 = New Label()
        balance = New TextBox()
        Label5 = New Label()
        cname = New TextBox()
        Label2 = New Label()
        searchbtn = New Button()
        acno = New TextBox()
        depositbtn = New Button()
        Label3 = New Label()
        depamount = New TextBox()
        Label1 = New Label()
        tablebtn = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(22, 757)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 42)
        Label6.TabIndex = 30
        Label6.Visible = False
        ' 
        ' transid
        ' 
        transid.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        transid.Location = New Point(44, 933)
        transid.Name = "transid"
        transid.ReadOnly = True
        transid.Size = New Size(10, 50)
        transid.TabIndex = 29
        transid.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(919, 326)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 42)
        Label4.TabIndex = 28
        Label4.Text = "Balance:"' 
        ' balance
        ' 
        balance.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        balance.Location = New Point(1072, 322)
        balance.Name = "balance"
        balance.ReadOnly = True
        balance.Size = New Size(404, 50)
        balance.TabIndex = 27
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(311, 326)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 42)
        Label5.TabIndex = 26
        Label5.Text = "Name:"' 
        ' cname
        ' 
        cname.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        cname.Location = New Point(435, 320)
        cname.Name = "cname"
        cname.ReadOnly = True
        cname.Size = New Size(426, 50)
        cname.TabIndex = 25
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(398, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(293, 42)
        Label2.TabIndex = 24
        Label2.Text = "Account Number:"' 
        ' searchbtn
        ' 
        searchbtn.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        searchbtn.Location = New Point(1109, 189)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(228, 56)
        searchbtn.TabIndex = 23
        searchbtn.Text = "🔍 Search"
        searchbtn.UseVisualStyleBackColor = True
        ' 
        ' acno
        ' 
        acno.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        acno.Location = New Point(708, 191)
        acno.Name = "acno"
        acno.Size = New Size(354, 50)
        acno.TabIndex = 22
        ' 
        ' depositbtn
        ' 
        depositbtn.BackColor = Color.Black
        depositbtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        depositbtn.ForeColor = Color.White
        depositbtn.Location = New Point(738, 668)
        depositbtn.Name = "depositbtn"
        depositbtn.Size = New Size(330, 80)
        depositbtn.TabIndex = 21
        depositbtn.Text = "Deposit"
        depositbtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(502, 477)
        Label3.Name = "Label3"
        Label3.Size = New Size(279, 42)
        Label3.TabIndex = 20
        Label3.Text = "Deposit Amount:"' 
        ' depamount
        ' 
        depamount.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        depamount.Location = New Point(816, 474)
        depamount.Name = "depamount"
        depamount.Size = New Size(429, 50)
        depamount.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Product Sans Medium", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(774, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 78)
        Label1.TabIndex = 18
        Label1.Text = "Deposit"' 
        ' tablebtn
        ' 
        tablebtn.BackColor = Color.LightBlue
        tablebtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        tablebtn.ForeColor = Color.Black
        tablebtn.Location = New Point(693, 789)
        tablebtn.Name = "tablebtn"
        tablebtn.Size = New Size(420, 80)
        tablebtn.TabIndex = 31
        tablebtn.Text = "View Deposit History"
        tablebtn.UseVisualStyleBackColor = False
        ' 
        ' deposit
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        BackgroundImage = My.Resources.Resources.URANUS_BANK
        ClientSize = New Size(1788, 1006)
        Controls.Add(tablebtn)
        Controls.Add(Label6)
        Controls.Add(transid)
        Controls.Add(Label4)
        Controls.Add(balance)
        Controls.Add(Label5)
        Controls.Add(cname)
        Controls.Add(Label2)
        Controls.Add(searchbtn)
        Controls.Add(acno)
        Controls.Add(depositbtn)
        Controls.Add(Label3)
        Controls.Add(depamount)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "deposit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "deposit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents transid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents balance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchbtn As Button
    Friend WithEvents acno As TextBox
    Friend WithEvents depositbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents depamount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tablebtn As Button
End Class
