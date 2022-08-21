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
        Me.length = New System.Windows.Forms.ComboBox()
        Me.s_roll = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.height = New System.Windows.Forms.ComboBox()
        Me.width = New System.Windows.Forms.ComboBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rollcov = New System.Windows.Forms.ComboBox()
        Me.Calculatebtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'length
        '
        Me.length.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.length.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.SystemColors.WindowText
        Me.length.FormattingEnabled = True
        Me.length.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.length.Location = New System.Drawing.Point(287, 116)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(213, 28)
        Me.length.TabIndex = 0
        '
        's_roll
        '
        Me.s_roll.Location = New System.Drawing.Point(539, 162)
        Me.s_roll.Multiline = True
        Me.s_roll.Name = "s_roll"
        Me.s_roll.Size = New System.Drawing.Size(250, 28)
        Me.s_roll.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Length (feet) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Height (feet) :"
        '
        'height
        '
        Me.height.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.height.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.height.FormattingEnabled = True
        Me.height.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.height.Location = New System.Drawing.Point(287, 209)
        Me.height.Name = "height"
        Me.height.Size = New System.Drawing.Size(213, 28)
        Me.height.TabIndex = 3
        '
        'width
        '
        Me.width.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.width.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.width.FormattingEnabled = True
        Me.width.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.width.Location = New System.Drawing.Point(287, 162)
        Me.width.Name = "width"
        Me.width.Size = New System.Drawing.Size(213, 28)
        Me.width.TabIndex = 3
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(50, 170)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(121, 20)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Width (feet) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Roll coverage (sqrt) :"
        '
        'rollcov
        '
        Me.rollcov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rollcov.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollcov.FormattingEnabled = True
        Me.rollcov.Items.AddRange(New Object() {"40", "40.5", "41", "41.5", "42", "42.5", "43", "43.5", "44", "44.5", "45", "45.5", "46", "46.5", "47", "47.5", "48", "48.5", "49", "49.5", "50"})
        Me.rollcov.Location = New System.Drawing.Point(287, 256)
        Me.rollcov.Name = "rollcov"
        Me.rollcov.Size = New System.Drawing.Size(213, 28)
        Me.rollcov.TabIndex = 5
        '
        'Calculatebtn
        '
        Me.Calculatebtn.Location = New System.Drawing.Point(539, 212)
        Me.Calculatebtn.Name = "Calculatebtn"
        Me.Calculatebtn.Size = New System.Drawing.Size(122, 36)
        Me.Calculatebtn.TabIndex = 7
        Me.Calculatebtn.Text = "Calculate"
        Me.Calculatebtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(535, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Single roll :"
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(667, 212)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(122, 36)
        Me.Exitbtn.TabIndex = 9
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 413)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Calculatebtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rollcov)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.width)
        Me.Controls.Add(Me.height)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.s_roll)
        Me.Controls.Add(Me.length)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wallpaper App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents length As ComboBox
    Friend WithEvents s_roll As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents height As ComboBox
    Friend WithEvents width As ComboBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rollcov As ComboBox
    Friend WithEvents Calculatebtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Exitbtn As Button
End Class
