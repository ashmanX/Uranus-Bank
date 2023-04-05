<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Panel1 = New Panel()
        userid = New TextBox()
        pass = New TextBox()
        loginb = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Product Sans Medium", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1168, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 78)
        Label1.TabIndex = 0
        Label1.Text = "Sign In Here"' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.BackgroundImage = My.Resources.Resources.LoginPage
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(906, 918)
        Panel1.TabIndex = 1
        ' 
        ' userid
        ' 
        userid.BorderStyle = BorderStyle.FixedSingle
        userid.Font = New Font("Product Sans", 15.8571415F, FontStyle.Regular, GraphicsUnit.Point)
        userid.ForeColor = SystemColors.WindowFrame
        userid.Location = New Point(1050, 335)
        userid.Name = "userid"
        userid.Size = New Size(612, 52)
        userid.TabIndex = 2
        ' 
        ' pass
        ' 
        pass.Font = New Font("Product Sans", 15.8571415F, FontStyle.Regular, GraphicsUnit.Point)
        pass.ForeColor = SystemColors.WindowFrame
        pass.Location = New Point(1050, 515)
        pass.Name = "pass"
        pass.Size = New Size(612, 52)
        pass.TabIndex = 3
        pass.UseSystemPasswordChar = True
        ' 
        ' loginb
        ' 
        loginb.Font = New Font("Product Sans Medium", 15.8571415F, FontStyle.Bold, GraphicsUnit.Point)
        loginb.Location = New Point(1199, 665)
        loginb.Name = "loginb"
        loginb.Size = New Size(333, 83)
        loginb.TabIndex = 4
        loginb.Text = "Sign In"
        loginb.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(1050, 273)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 42)
        Label2.TabIndex = 5
        Label2.Text = "User ID:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Product Sans Medium", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(1050, 459)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 42)
        Label3.TabIndex = 6
        Label3.Text = "Password:"' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ClientSize = New Size(1788, 918)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(loginb)
        Controls.Add(pass)
        Controls.Add(userid)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents userid As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents loginb As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
