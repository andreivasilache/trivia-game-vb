<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.points_label = New System.Windows.Forms.Label()
        Me.lifes_label = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.option_1 = New System.Windows.Forms.Button()
        Me.question = New System.Windows.Forms.Button()
        Me.option_2 = New System.Windows.Forms.Button()
        Me.option_3 = New System.Windows.Forms.Button()
        Me.option_4 = New System.Windows.Forms.Button()
        Me.visitMeAnchor = New System.Windows.Forms.LinkLabel()
        Me.category = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'points_label
        '
        Me.points_label.AutoSize = True
        Me.points_label.Font = New System.Drawing.Font("Roboto Thin", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.points_label.Location = New System.Drawing.Point(21, 46)
        Me.points_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.points_label.Name = "points_label"
        Me.points_label.Size = New System.Drawing.Size(51, 17)
        Me.points_label.TabIndex = 2
        Me.points_label.Text = "Points: "
        '
        'lifes_label
        '
        Me.lifes_label.AutoSize = True
        Me.lifes_label.Font = New System.Drawing.Font("Roboto Thin", 10.0!)
        Me.lifes_label.Location = New System.Drawing.Point(21, 76)
        Me.lifes_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lifes_label.Name = "lifes_label"
        Me.lifes_label.Size = New System.Drawing.Size(38, 17)
        Me.lifes_label.TabIndex = 3
        Me.lifes_label.Text = "Lifes:"
        '
        'option_1
        '
        Me.option_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.option_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.option_1.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.option_1.Location = New System.Drawing.Point(24, 290)
        Me.option_1.Margin = New System.Windows.Forms.Padding(0)
        Me.option_1.Name = "option_1"
        Me.option_1.Size = New System.Drawing.Size(370, 70)
        Me.option_1.TabIndex = 8
        Me.option_1.Text = "a"
        Me.option_1.UseVisualStyleBackColor = True
        '
        'question
        '
        Me.question.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.question.FlatAppearance.BorderSize = 0
        Me.question.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.question.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question.Location = New System.Drawing.Point(24, 148)
        Me.question.Margin = New System.Windows.Forms.Padding(0)
        Me.question.Name = "question"
        Me.question.Size = New System.Drawing.Size(370, 90)
        Me.question.TabIndex = 10
        Me.question.Text = "Lorem ipsum? "
        Me.question.UseVisualStyleBackColor = True
        '
        'option_2
        '
        Me.option_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.option_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.option_2.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.option_2.Location = New System.Drawing.Point(24, 379)
        Me.option_2.Margin = New System.Windows.Forms.Padding(0)
        Me.option_2.Name = "option_2"
        Me.option_2.Size = New System.Drawing.Size(370, 70)
        Me.option_2.TabIndex = 11
        Me.option_2.Text = "b"
        Me.option_2.UseVisualStyleBackColor = True
        '
        'option_3
        '
        Me.option_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.option_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.option_3.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.option_3.Location = New System.Drawing.Point(24, 463)
        Me.option_3.Margin = New System.Windows.Forms.Padding(0)
        Me.option_3.Name = "option_3"
        Me.option_3.Size = New System.Drawing.Size(370, 70)
        Me.option_3.TabIndex = 12
        Me.option_3.Text = "c"
        Me.option_3.UseVisualStyleBackColor = True
        '
        'option_4
        '
        Me.option_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.option_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.option_4.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.option_4.Location = New System.Drawing.Point(24, 548)
        Me.option_4.Margin = New System.Windows.Forms.Padding(0)
        Me.option_4.Name = "option_4"
        Me.option_4.Size = New System.Drawing.Size(370, 70)
        Me.option_4.TabIndex = 13
        Me.option_4.Text = "d"
        Me.option_4.UseVisualStyleBackColor = True
        '
        'visitMeAnchor
        '
        Me.visitMeAnchor.AutoSize = True
        Me.visitMeAnchor.LinkColor = System.Drawing.Color.Black
        Me.visitMeAnchor.Location = New System.Drawing.Point(345, 9)
        Me.visitMeAnchor.Name = "visitMeAnchor"
        Me.visitMeAnchor.Size = New System.Drawing.Size(49, 13)
        Me.visitMeAnchor.TabIndex = 14
        Me.visitMeAnchor.TabStop = True
        Me.visitMeAnchor.Text = "Visit ME"
        Me.visitMeAnchor.VisitedLinkColor = System.Drawing.Color.Black
        '
        'category
        '
        Me.category.AutoSize = True
        Me.category.Font = New System.Drawing.Font("Roboto Medium", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category.Location = New System.Drawing.Point(12, 251)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(73, 18)
        Me.category.TabIndex = 15
        Me.category.Text = "Category:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(403, 627)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.visitMeAnchor)
        Me.Controls.Add(Me.option_4)
        Me.Controls.Add(Me.option_3)
        Me.Controls.Add(Me.option_2)
        Me.Controls.Add(Me.question)
        Me.Controls.Add(Me.option_1)
        Me.Controls.Add(Me.lifes_label)
        Me.Controls.Add(Me.points_label)
        Me.Font = New System.Drawing.Font("Roboto Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "Main"
        Me.Text = "Trivia Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents points_label As Label
    Friend WithEvents lifes_label As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents option_1 As Button
    Friend WithEvents question As Button
    Friend WithEvents option_2 As Button
    Friend WithEvents option_3 As Button
    Friend WithEvents option_4 As Button
    Friend WithEvents visitMeAnchor As LinkLabel
    Friend WithEvents category As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
