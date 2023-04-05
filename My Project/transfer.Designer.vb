<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transfer
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
        Label4 = New Label()
        balance = New TextBox()
        cname = New TextBox()
        Label2 = New Label()
        searchbtn = New Button()
        acno = New TextBox()
        transferbtn = New Button()
        Label1 = New Label()
        tacno = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        transamt = New Label()
        transamount = New TextBox()
        tsearchbtn = New Button()
        Label7 = New Label()
        tcname = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        transid = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(895, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 42)
        Label4.TabIndex = 38
        Label4.Text = "Balance:"' 
        ' balance
        ' 
        balance.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        balance.Location = New Point(1048, 285)
        balance.Name = "balance"
        balance.ReadOnly = True
        balance.Size = New Size(404, 50)
        balance.TabIndex = 37
        ' 
        ' cname
        ' 
        cname.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        cname.Location = New Point(411, 283)
        cname.Name = "cname"
        cname.ReadOnly = True
        cname.Size = New Size(426, 50)
        cname.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(384, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(293, 42)
        Label2.TabIndex = 35
        Label2.Text = "Account Number:"' 
        ' searchbtn
        ' 
        searchbtn.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        searchbtn.Location = New Point(1095, 171)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(228, 56)
        searchbtn.TabIndex = 34
        searchbtn.Text = "🔍 Search"
        searchbtn.UseVisualStyleBackColor = True
        ' 
        ' acno
        ' 
        acno.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        acno.Location = New Point(694, 173)
        acno.Name = "acno"
        acno.Size = New Size(354, 50)
        acno.TabIndex = 33
        ' 
        ' transferbtn
        ' 
        transferbtn.BackColor = Color.Black
        transferbtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        transferbtn.ForeColor = Color.White
        transferbtn.Location = New Point(754, 767)
        transferbtn.Name = "transferbtn"
        transferbtn.Size = New Size(330, 80)
        transferbtn.TabIndex = 32
        transferbtn.Text = "Transfer"
        transferbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Product Sans Medium", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(811, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 78)
        Label1.TabIndex = 29
        Label1.Text = "Transfer"' 
        ' tacno
        ' 
        tacno.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        tacno.Location = New Point(619, 420)
        tacno.Name = "tacno"
        tacno.Size = New Size(429, 50)
        tacno.TabIndex = 39
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(305, 428)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(289, 42)
        Label5.TabIndex = 40
        Label5.Text = "To (Account No.):"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(274, 285)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 42)
        Label6.TabIndex = 41
        Label6.Text = "Name:"' 
        ' transamt
        ' 
        transamt.AutoSize = True
        transamt.BackColor = Color.Transparent
        transamt.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        transamt.ForeColor = Color.White
        transamt.Location = New Point(481, 644)
        transamt.Name = "transamt"
        transamt.Size = New Size(288, 42)
        transamt.TabIndex = 43
        transamt.Text = "Transfer Amount:"' 
        ' transamount
        ' 
        transamount.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        transamount.Location = New Point(784, 640)
        transamount.Name = "transamount"
        transamount.Size = New Size(429, 50)
        transamount.TabIndex = 42
        ' 
        ' tsearchbtn
        ' 
        tsearchbtn.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        tsearchbtn.Location = New Point(1095, 417)
        tsearchbtn.Name = "tsearchbtn"
        tsearchbtn.Size = New Size(228, 56)
        tsearchbtn.TabIndex = 44
        tsearchbtn.Text = "🔍 Search"
        tsearchbtn.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(573, 523)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 42)
        Label7.TabIndex = 48
        Label7.Text = "Name:"' 
        ' tcname
        ' 
        tcname.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        tcname.Location = New Point(710, 521)
        tcname.Name = "tcname"
        tcname.ReadOnly = True
        tcname.Size = New Size(426, 50)
        tcname.TabIndex = 45
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.White
        Label9.Location = New Point(155, 355)
        Label9.Name = "Label9"
        Label9.Size = New Size(1453, 30)
        Label9.TabIndex = 49
        Label9.Text = "________________________________________________________________________________________________________________________________________________________________"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.White
        Label8.Location = New Point(155, 574)
        Label8.Name = "Label8"
        Label8.Size = New Size(1453, 30)
        Label8.TabIndex = 50
        Label8.Text = "________________________________________________________________________________________________________________________________________________________________"' 
        ' transid
        ' 
        transid.BackColor = Color.Teal
        transid.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        transid.Location = New Point(44, 934)
        transid.Name = "transid"
        transid.ReadOnly = True
        transid.Size = New Size(10, 50)
        transid.TabIndex = 51
        transid.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightBlue
        Button1.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(713, 866)
        Button1.Name = "Button1"
        Button1.Size = New Size(412, 80)
        Button1.TabIndex = 52
        Button1.Text = "View Transfer History"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' transfer
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        BackgroundImage = My.Resources.Resources.URANUS_BANK
        ClientSize = New Size(1788, 1006)
        Controls.Add(Button1)
        Controls.Add(transid)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(tcname)
        Controls.Add(tsearchbtn)
        Controls.Add(transamt)
        Controls.Add(transamount)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(tacno)
        Controls.Add(Label4)
        Controls.Add(balance)
        Controls.Add(cname)
        Controls.Add(Label2)
        Controls.Add(searchbtn)
        Controls.Add(acno)
        Controls.Add(transferbtn)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "transfer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transfer"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tcname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents balance As TextBox
    Friend WithEvents cname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchbtn As Button
    Friend WithEvents acno As TextBox
    Friend WithEvents transferbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tacno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents transamt As Label
    Friend WithEvents transamount As TextBox
    Friend WithEvents tsearchbtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents transid As TextBox
    Friend WithEvents Button1 As Button
End Class
