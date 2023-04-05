<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WIthdraw
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
        withamount = New TextBox()
        Label3 = New Label()
        withdrawbtn = New Button()
        Label2 = New Label()
        searchbtn = New Button()
        acno = New TextBox()
        Label4 = New Label()
        balance = New TextBox()
        Label5 = New Label()
        cname = New TextBox()
        transid = New TextBox()
        tablebtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Product Sans Medium", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(786, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(300, 78)
        Label1.TabIndex = 0
        Label1.Text = "Withdraw"' 
        ' withamount
        ' 
        withamount.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        withamount.Location = New Point(821, 495)
        withamount.Name = "withamount"
        withamount.Size = New Size(429, 50)
        withamount.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(507, 498)
        Label3.Name = "Label3"
        Label3.Size = New Size(308, 42)
        Label3.TabIndex = 6
        Label3.Text = "Withdraw Amount:"' 
        ' withdrawbtn
        ' 
        withdrawbtn.BackColor = Color.Black
        withdrawbtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        withdrawbtn.ForeColor = Color.White
        withdrawbtn.Location = New Point(743, 650)
        withdrawbtn.Name = "withdrawbtn"
        withdrawbtn.Size = New Size(330, 80)
        withdrawbtn.TabIndex = 8
        withdrawbtn.Text = "Withdraw"
        withdrawbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(422, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(293, 42)
        Label2.TabIndex = 11
        Label2.Text = "Account Number:"' 
        ' searchbtn
        ' 
        searchbtn.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        searchbtn.Location = New Point(1133, 211)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(228, 56)
        searchbtn.TabIndex = 10
        searchbtn.Text = "🔍 Search"
        searchbtn.UseVisualStyleBackColor = True
        ' 
        ' acno
        ' 
        acno.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        acno.Location = New Point(732, 213)
        acno.Name = "acno"
        acno.Size = New Size(354, 50)
        acno.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(924, 347)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 42)
        Label4.TabIndex = 15
        Label4.Text = "Balance:"' 
        ' balance
        ' 
        balance.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        balance.Location = New Point(1077, 343)
        balance.Name = "balance"
        balance.ReadOnly = True
        balance.Size = New Size(404, 50)
        balance.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(316, 347)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 42)
        Label5.TabIndex = 13
        Label5.Text = "Name:"' 
        ' cname
        ' 
        cname.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        cname.Location = New Point(440, 341)
        cname.Name = "cname"
        cname.ReadOnly = True
        cname.Size = New Size(426, 50)
        cname.TabIndex = 12
        ' 
        ' transid
        ' 
        transid.BackColor = Color.Teal
        transid.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        transid.Location = New Point(53, 928)
        transid.Name = "transid"
        transid.ReadOnly = True
        transid.Size = New Size(10, 50)
        transid.TabIndex = 30
        transid.Visible = False
        ' 
        ' tablebtn
        ' 
        tablebtn.BackColor = Color.PowderBlue
        tablebtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        tablebtn.ForeColor = Color.Black
        tablebtn.Location = New Point(700, 782)
        tablebtn.Name = "tablebtn"
        tablebtn.Size = New Size(418, 80)
        tablebtn.TabIndex = 31
        tablebtn.Text = "View Withdraw History"
        tablebtn.UseVisualStyleBackColor = False
        ' 
        ' WIthdraw
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        BackgroundImage = My.Resources.Resources.URANUS_BANK
        ClientSize = New Size(1788, 1006)
        Controls.Add(tablebtn)
        Controls.Add(transid)
        Controls.Add(Label4)
        Controls.Add(balance)
        Controls.Add(Label5)
        Controls.Add(cname)
        Controls.Add(Label2)
        Controls.Add(searchbtn)
        Controls.Add(acno)
        Controls.Add(withdrawbtn)
        Controls.Add(Label3)
        Controls.Add(withamount)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "WIthdraw"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Withdraw"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents withamount As TextBox
    Friend WithEvents withdrawbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents searchbtn As Button
    Friend WithEvents acno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents balance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cname As TextBox
    Friend WithEvents transid As TextBox
    Friend WithEvents tablebtn As Button
End Class
