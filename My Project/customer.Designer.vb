<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        managebtn = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Product Sans Medium", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(736, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 78)
        Label1.TabIndex = 1
        Label1.Text = "Customers"' 
        ' managebtn
        ' 
        managebtn.BackColor = Color.Black
        managebtn.Font = New Font("Product Sans Medium", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        managebtn.ForeColor = Color.White
        managebtn.Location = New Point(711, 799)
        managebtn.Name = "managebtn"
        managebtn.Size = New Size(413, 105)
        managebtn.TabIndex = 9
        managebtn.Text = "Manage Customers"
        managebtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New Font("Product Sans", 11.999999F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ButtonFace
        DataGridView1.Location = New Point(90, 212)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 72
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Product Sans", 11.999999F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.White
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.RowTemplate.Height = 37
        DataGridView1.Size = New Size(1624, 451)
        DataGridView1.TabIndex = 10
        ' 
        ' customer
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        BackgroundImage = My.Resources.Resources.URANUS_BANK
        ClientSize = New Size(1788, 1006)
        Controls.Add(DataGridView1)
        Controls.Add(managebtn)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "customer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customers"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents managebtn As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
