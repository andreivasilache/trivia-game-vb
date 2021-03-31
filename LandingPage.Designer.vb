<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LandingPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.title = New System.Windows.Forms.Label()
        Me.subtitle = New System.Windows.Forms.Label()
        Me.subtitle1 = New System.Windows.Forms.Label()
        Me.button_easy = New System.Windows.Forms.Button()
        Me.button_medium = New System.Windows.Forms.Button()
        Me.button_hard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Roboto Medium", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.title.Location = New System.Drawing.Point(148, 84)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(117, 48)
        Me.title.TabIndex = 0
        Me.title.Text = "Hello"
        '
        'subtitle
        '
        Me.subtitle.AutoSize = True
        Me.subtitle.Font = New System.Drawing.Font("Roboto Thin", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtitle.Location = New System.Drawing.Point(110, 176)
        Me.subtitle.Name = "subtitle"
        Me.subtitle.Size = New System.Drawing.Size(204, 33)
        Me.subtitle.TabIndex = 2
        Me.subtitle.Text = "Please choose "
        '
        'subtitle1
        '
        Me.subtitle1.AutoSize = True
        Me.subtitle1.Font = New System.Drawing.Font("Roboto Thin", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtitle1.Location = New System.Drawing.Point(130, 209)
        Me.subtitle1.Name = "subtitle1"
        Me.subtitle1.Size = New System.Drawing.Size(151, 33)
        Me.subtitle1.TabIndex = 3
        Me.subtitle1.Text = "a difficulty:"
        '
        'button_easy
        '
        Me.button_easy.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.button_easy.FlatAppearance.BorderSize = 2
        Me.button_easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_easy.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_easy.Location = New System.Drawing.Point(107, 297)
        Me.button_easy.Margin = New System.Windows.Forms.Padding(0)
        Me.button_easy.Name = "button_easy"
        Me.button_easy.Size = New System.Drawing.Size(198, 44)
        Me.button_easy.TabIndex = 4
        Me.button_easy.Text = "Easy"
        Me.button_easy.UseVisualStyleBackColor = True
        '
        'button_medium
        '
        Me.button_medium.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.button_medium.FlatAppearance.BorderSize = 2
        Me.button_medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_medium.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_medium.Location = New System.Drawing.Point(107, 378)
        Me.button_medium.Margin = New System.Windows.Forms.Padding(0)
        Me.button_medium.Name = "button_medium"
        Me.button_medium.Size = New System.Drawing.Size(198, 44)
        Me.button_medium.TabIndex = 7
        Me.button_medium.Text = "Medium"
        Me.button_medium.UseVisualStyleBackColor = True
        '
        'button_hard
        '
        Me.button_hard.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.button_hard.FlatAppearance.BorderSize = 2
        Me.button_hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_hard.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_hard.Location = New System.Drawing.Point(107, 458)
        Me.button_hard.Margin = New System.Windows.Forms.Padding(0)
        Me.button_hard.Name = "button_hard"
        Me.button_hard.Size = New System.Drawing.Size(198, 44)
        Me.button_hard.TabIndex = 8
        Me.button_hard.Text = "Hard"
        Me.button_hard.UseVisualStyleBackColor = True
        '
        'LandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(401, 625)
        Me.Controls.Add(Me.button_hard)
        Me.Controls.Add(Me.button_medium)
        Me.Controls.Add(Me.button_easy)
        Me.Controls.Add(Me.subtitle1)
        Me.Controls.Add(Me.subtitle)
        Me.Controls.Add(Me.title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "LandingPage"
        Me.Text = "Landing Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents subtitle As Label
    Friend WithEvents subtitle1 As Label
    Friend WithEvents button_easy As Button
    Friend WithEvents button_medium As Button
    Friend WithEvents button_hard As Button
End Class
