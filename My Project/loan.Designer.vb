<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loan
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
        dueamtlabel = New Label()
        dueamt = New TextBox()
        Label7 = New Label()
        duration = New TextBox()
        Label5 = New Label()
        interest = New TextBox()
        Label4 = New Label()
        lamount = New TextBox()
        lname = New TextBox()
        Label2 = New Label()
        searchbtn = New Button()
        loanno = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        loanbtn = New Button()
        paidbtn = New Button()
        SuspendLayout()
        ' 
        ' dueamtlabel
        ' 
        dueamtlabel.AutoSize = True
        dueamtlabel.BackColor = Color.Transparent
        dueamtlabel.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        dueamtlabel.ForeColor = Color.White
        dueamtlabel.Location = New Point(634, 606)
        dueamtlabel.Name = "dueamtlabel"
        dueamtlabel.Size = New Size(220, 42)
        dueamtlabel.TabIndex = 31
        dueamtlabel.Text = "Due Amount:"' 
        ' dueamt
        ' 
        dueamt.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        dueamt.Location = New Point(866, 601)
        dueamt.Name = "dueamt"
        dueamt.Size = New Size(354, 50)
        dueamt.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(594, 479)
        Label7.Name = "Label7"
        Label7.Size = New Size(313, 42)
        Label7.TabIndex = 29
        Label7.Text = "Duration (In Years):"' 
        ' duration
        ' 
        duration.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        duration.Location = New Point(913, 474)
        duration.Name = "duration"
        duration.Size = New Size(354, 50)
        duration.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(1246, 341)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 42)
        Label5.TabIndex = 26
        Label5.Text = "Interest(%):"' 
        ' interest
        ' 
        interest.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        interest.Location = New Point(1451, 336)
        interest.Name = "interest"
        interest.Size = New Size(221, 50)
        interest.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(663, 346)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 42)
        Label4.TabIndex = 24
        Label4.Text = "Amount:"' 
        ' lamount
        ' 
        lamount.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        lamount.Location = New Point(816, 339)
        lamount.Name = "lamount"
        lamount.Size = New Size(404, 50)
        lamount.TabIndex = 23
        ' 
        ' lname
        ' 
        lname.Font = New Font("Product Sans", 14.999999F, FontStyle.Regular, GraphicsUnit.Point)
        lname.Location = New Point(198, 337)
        lname.Name = "lname"
        lname.Size = New Size(426, 50)
        lname.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(423, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(236, 42)
        Label2.TabIndex = 21
        Label2.Text = "Loan Number:"' 
        ' searchbtn
        ' 
        searchbtn.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        searchbtn.Location = New Point(1054, 202)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(228, 56)
        searchbtn.TabIndex = 20
        searchbtn.Text = "🔍 Search"
        searchbtn.UseVisualStyleBackColor = True
        ' 
        ' loanno
        ' 
        loanno.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        loanno.Location = New Point(665, 205)
        loanno.Name = "loanno"
        loanno.Size = New Size(354, 50)
        loanno.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(8), CByte(107), CByte(107))
        Label1.Font = New Font("Product Sans Medium", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(706, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(428, 78)
        Label1.TabIndex = 18
        Label1.Text = "Manage Loans"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(76, 342)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 42)
        Label3.TabIndex = 32
        Label3.Text = "Name:"' 
        ' loanbtn
        ' 
        loanbtn.BackColor = Color.Black
        loanbtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        loanbtn.ForeColor = Color.White
        loanbtn.Location = New Point(775, 707)
        loanbtn.Name = "loanbtn"
        loanbtn.Size = New Size(330, 80)
        loanbtn.TabIndex = 33
        loanbtn.Text = "Process Loan"
        loanbtn.UseVisualStyleBackColor = False
        ' 
        ' paidbtn
        ' 
        paidbtn.BackColor = Color.Black
        paidbtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        paidbtn.ForeColor = Color.White
        paidbtn.Location = New Point(750, 722)
        paidbtn.Name = "paidbtn"
        paidbtn.Size = New Size(375, 80)
        paidbtn.TabIndex = 34
        paidbtn.Text = "Make Loan Payment"
        paidbtn.UseVisualStyleBackColor = False
        ' 
        ' loan
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.URANUS_BANK
        ClientSize = New Size(1788, 1006)
        Controls.Add(paidbtn)
        Controls.Add(loanbtn)
        Controls.Add(Label3)
        Controls.Add(dueamtlabel)
        Controls.Add(dueamt)
        Controls.Add(Label7)
        Controls.Add(duration)
        Controls.Add(Label5)
        Controls.Add(interest)
        Controls.Add(Label4)
        Controls.Add(lamount)
        Controls.Add(lname)
        Controls.Add(Label2)
        Controls.Add(searchbtn)
        Controls.Add(loanno)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "loan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Loans"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dueamtlabel As Label
    Friend WithEvents dueamt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents duration As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents interest As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lamount As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchbtn As Button
    Friend WithEvents loanno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents loanbtn As Button
    Friend WithEvents paidbtn As Button
End Class
