<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.GroupBoxRange = New System.Windows.Forms.GroupBox()
        Me.Range1000 = New System.Windows.Forms.RadioButton()
        Me.Range100 = New System.Windows.Forms.RadioButton()
        Me.Range10 = New System.Windows.Forms.RadioButton()
        Me.LDitebak = New System.Windows.Forms.Label()
        Me.LTingRend = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TMasukan = New System.Windows.Forms.TextBox()
        Me.bMulai = New System.Windows.Forms.Button()
        Me.bYa = New System.Windows.Forms.Button()
        Me.GroupBoxRange.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxRange
        '
        Me.GroupBoxRange.Controls.Add(Me.Range1000)
        Me.GroupBoxRange.Controls.Add(Me.Range100)
        Me.GroupBoxRange.Controls.Add(Me.Range10)
        Me.GroupBoxRange.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRange.Location = New System.Drawing.Point(33, 33)
        Me.GroupBoxRange.Name = "GroupBoxRange"
        Me.GroupBoxRange.Size = New System.Drawing.Size(132, 178)
        Me.GroupBoxRange.TabIndex = 1
        Me.GroupBoxRange.TabStop = False
        Me.GroupBoxRange.Text = "Range"
        '
        'Range1000
        '
        Me.Range1000.AutoSize = True
        Me.Range1000.Location = New System.Drawing.Point(16, 130)
        Me.Range1000.Name = "Range1000"
        Me.Range1000.Size = New System.Drawing.Size(97, 27)
        Me.Range1000.TabIndex = 2
        Me.Range1000.TabStop = True
        Me.Range1000.Text = "1 - 1000"
        Me.Range1000.UseVisualStyleBackColor = True
        '
        'Range100
        '
        Me.Range100.AutoSize = True
        Me.Range100.Location = New System.Drawing.Point(16, 84)
        Me.Range100.Name = "Range100"
        Me.Range100.Size = New System.Drawing.Size(84, 27)
        Me.Range100.TabIndex = 1
        Me.Range100.TabStop = True
        Me.Range100.Text = "1 - 100"
        Me.Range100.UseVisualStyleBackColor = True
        '
        'Range10
        '
        Me.Range10.AutoSize = True
        Me.Range10.Location = New System.Drawing.Point(16, 39)
        Me.Range10.Name = "Range10"
        Me.Range10.Size = New System.Drawing.Size(71, 27)
        Me.Range10.TabIndex = 0
        Me.Range10.TabStop = True
        Me.Range10.Text = "1 - 10"
        Me.Range10.UseVisualStyleBackColor = True
        '
        'LDitebak
        '
        Me.LDitebak.AutoSize = True
        Me.LDitebak.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDitebak.Location = New System.Drawing.Point(216, 42)
        Me.LDitebak.Name = "LDitebak"
        Me.LDitebak.Size = New System.Drawing.Size(191, 21)
        Me.LDitebak.TabIndex = 2
        Me.LDitebak.Text = "Angka Yang Ditebak :"
        '
        'LTingRend
        '
        Me.LTingRend.AutoSize = True
        Me.LTingRend.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTingRend.Location = New System.Drawing.Point(216, 96)
        Me.LTingRend.Name = "LTingRend"
        Me.LTingRend.Size = New System.Drawing.Size(169, 21)
        Me.LTingRend.TabIndex = 4
        Me.LTingRend.Text = "Tinggi atau Rendah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(217, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Masukkan Angka :"
        '
        'TMasukan
        '
        Me.TMasukan.Enabled = False
        Me.TMasukan.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMasukan.Location = New System.Drawing.Point(220, 186)
        Me.TMasukan.Name = "TMasukan"
        Me.TMasukan.Size = New System.Drawing.Size(261, 25)
        Me.TMasukan.TabIndex = 6
        '
        'bMulai
        '
        Me.bMulai.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMulai.Location = New System.Drawing.Point(58, 239)
        Me.bMulai.Name = "bMulai"
        Me.bMulai.Size = New System.Drawing.Size(75, 36)
        Me.bMulai.TabIndex = 7
        Me.bMulai.Text = "Mulai"
        Me.bMulai.UseVisualStyleBackColor = True
        '
        'bYa
        '
        Me.bYa.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bYa.Location = New System.Drawing.Point(293, 239)
        Me.bYa.Name = "bYa"
        Me.bYa.Size = New System.Drawing.Size(76, 36)
        Me.bYa.TabIndex = 8
        Me.bYa.Text = "YA"
        Me.bYa.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 293)
        Me.Controls.Add(Me.bYa)
        Me.Controls.Add(Me.bMulai)
        Me.Controls.Add(Me.TMasukan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LTingRend)
        Me.Controls.Add(Me.LDitebak)
        Me.Controls.Add(Me.GroupBoxRange)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBoxRange.ResumeLayout(False)
        Me.GroupBoxRange.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Range1000 As System.Windows.Forms.RadioButton
    Friend WithEvents Range100 As System.Windows.Forms.RadioButton
    Friend WithEvents Range10 As System.Windows.Forms.RadioButton
    Friend WithEvents LDitebak As System.Windows.Forms.Label
    Friend WithEvents LTingRend As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TMasukan As System.Windows.Forms.TextBox
    Friend WithEvents bMulai As System.Windows.Forms.Button
    Friend WithEvents bYa As System.Windows.Forms.Button
    Friend WithEvents GroupBoxRange As System.Windows.Forms.GroupBox

End Class
