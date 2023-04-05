<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        withdrawbtn = New Button()
        depositbtn = New Button()
        transferbtn = New Button()
        loanbtn = New Button()
        customerbtn = New Button()
        logoutbtn = New Button()
        SuspendLayout()
        ' 
        ' withdrawbtn
        ' 
        withdrawbtn.BackColor = Color.Black
        withdrawbtn.Font = New Font("Product Sans Medium", 18F, FontStyle.Bold, GraphicsUnit.Point)
        withdrawbtn.ForeColor = Color.White
        withdrawbtn.Location = New Point(505, 911)
        withdrawbtn.Name = "withdrawbtn"
        withdrawbtn.Size = New Size(281, 96)
        withdrawbtn.TabIndex = 0
        withdrawbtn.Text = "Withdraw"
        withdrawbtn.UseVisualStyleBackColor = False
        ' 
        ' depositbtn
        ' 
        depositbtn.BackColor = Color.Black
        depositbtn.Font = New Font("Product Sans Medium", 18F, FontStyle.Bold, GraphicsUnit.Point)
        depositbtn.ForeColor = Color.White
        depositbtn.Location = New Point(1155, 911)
        depositbtn.Name = "depositbtn"
        depositbtn.Size = New Size(281, 96)
        depositbtn.TabIndex = 1
        depositbtn.Text = "Deposit"
        depositbtn.UseVisualStyleBackColor = False
        ' 
        ' transferbtn
        ' 
        transferbtn.BackColor = Color.Black
        transferbtn.Font = New Font("Product Sans Medium", 18F, FontStyle.Bold, GraphicsUnit.Point)
        transferbtn.ForeColor = Color.White
        transferbtn.Location = New Point(836, 911)
        transferbtn.Name = "transferbtn"
        transferbtn.Size = New Size(281, 96)
        transferbtn.TabIndex = 2
        transferbtn.Text = "Transfer"
        transferbtn.UseVisualStyleBackColor = False
        ' 
        ' loanbtn
        ' 
        loanbtn.BackColor = Color.Black
        loanbtn.Font = New Font("Product Sans Medium", 18F, FontStyle.Bold, GraphicsUnit.Point)
        loanbtn.ForeColor = Color.White
        loanbtn.Location = New Point(1471, 911)
        loanbtn.Name = "loanbtn"
        loanbtn.Size = New Size(281, 96)
        loanbtn.TabIndex = 3
        loanbtn.Text = "Loans"
        loanbtn.UseVisualStyleBackColor = False
        ' 
        ' customerbtn
        ' 
        customerbtn.BackColor = Color.Black
        customerbtn.Font = New Font("Product Sans Medium", 18F, FontStyle.Bold, GraphicsUnit.Point)
        customerbtn.ForeColor = Color.White
        customerbtn.Location = New Point(53, 911)
        customerbtn.Name = "customerbtn"
        customerbtn.Size = New Size(409, 96)
        customerbtn.TabIndex = 5
        customerbtn.Text = "View Customers"
        customerbtn.UseVisualStyleBackColor = False
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Brown
        logoutbtn.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        logoutbtn.ForeColor = SystemColors.ButtonFace
        logoutbtn.Location = New Point(1534, 32)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(218, 68)
        logoutbtn.TabIndex = 6
        logoutbtn.Text = "Sign Out"
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Teal
        BackgroundImage = My.Resources.Resources.HomePage
        ClientSize = New Size(1812, 1070)
        ControlBox = False
        Controls.Add(logoutbtn)
        Controls.Add(customerbtn)
        Controls.Add(loanbtn)
        Controls.Add(transferbtn)
        Controls.Add(depositbtn)
        Controls.Add(withdrawbtn)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        ResumeLayout(False)
    End Sub

    Friend WithEvents logoutbtn As Button
    Friend WithEvents depositbtn As Button
    Friend WithEvents transferbtn As Button
    Friend WithEvents loanbtn As Button
    Friend WithEvents withdrawbtn As Button
    Friend WithEvents customerbtn As Button
End Class
