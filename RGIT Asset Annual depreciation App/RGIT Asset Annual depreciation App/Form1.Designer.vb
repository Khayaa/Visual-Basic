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
        Me.Asset = New System.Windows.Forms.TextBox()
        Me.Displaybtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.salvage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Usefulcombo = New System.Windows.Forms.ComboBox()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Asset
        '
        Me.Asset.Location = New System.Drawing.Point(201, 113)
        Me.Asset.Multiline = True
        Me.Asset.Name = "Asset"
        Me.Asset.Size = New System.Drawing.Size(197, 30)
        Me.Asset.TabIndex = 0
        '
        'Displaybtn
        '
        Me.Displaybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Displaybtn.Location = New System.Drawing.Point(32, 304)
        Me.Displaybtn.Name = "Displaybtn"
        Me.Displaybtn.Size = New System.Drawing.Size(216, 94)
        Me.Displaybtn.TabIndex = 3
        Me.Displaybtn.Text = "Display depreciation Schedules"
        Me.Displaybtn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(18, 97)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(298, 264)
        Me.ListBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Assest Cost :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Salvage Value :"
        '
        'salvage
        '
        Me.salvage.Location = New System.Drawing.Point(201, 162)
        Me.salvage.Multiline = True
        Me.salvage.Name = "salvage"
        Me.salvage.Size = New System.Drawing.Size(197, 30)
        Me.salvage.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Useful Life :"
        '
        'Usefulcombo
        '
        Me.Usefulcombo.FormattingEnabled = True
        Me.Usefulcombo.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", ""})
        Me.Usefulcombo.Location = New System.Drawing.Point(201, 218)
        Me.Usefulcombo.Name = "Usefulcombo"
        Me.Usefulcombo.Size = New System.Drawing.Size(197, 24)
        Me.Usefulcombo.TabIndex = 12
        '
        'Exitbtn
        '
        Me.Exitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitbtn.Location = New System.Drawing.Point(263, 304)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(135, 94)
        Me.Exitbtn.TabIndex = 13
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(433, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 398)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depreciation Schedules"
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(351, 97)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(298, 264)
        Me.ListBox2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Double-declining Balancies"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(347, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Sum of the Year`s Digits"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 549)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Usefulcombo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.salvage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Displaybtn)
        Me.Controls.Add(Me.Asset)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RGIT Asset Annual depreciation App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Asset As TextBox
    Friend WithEvents Displaybtn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents salvage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Usefulcombo As ComboBox
    Friend WithEvents Exitbtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox2 As ListBox
End Class
