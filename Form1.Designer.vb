<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.plusLeftLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.plusRightLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.minusRight = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.minusLeft = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.multRight = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.multLeft = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.divRight = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.divLeft = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.NumericUpDown()
        Me.diff = New System.Windows.Forms.NumericUpDown()
        Me.prod = New System.Windows.Forms.NumericUpDown()
        Me.division = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        CType(Me.sum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.division, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTimeLeft.Location = New System.Drawing.Point(252, 9)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(165, 30)
        Me.lblTimeLeft.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time Left:"
        '
        'plusLeftLabel
        '
        Me.plusLeftLabel.Location = New System.Drawing.Point(50, 75)
        Me.plusLeftLabel.Name = "plusLeftLabel"
        Me.plusLeftLabel.Size = New System.Drawing.Size(60, 50)
        Me.plusLeftLabel.TabIndex = 2
        Me.plusLeftLabel.Text = "?"
        Me.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(116, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 50)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "+"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'plusRightLabel
        '
        Me.plusRightLabel.Location = New System.Drawing.Point(182, 75)
        Me.plusRightLabel.Name = "plusRightLabel"
        Me.plusRightLabel.Size = New System.Drawing.Size(60, 50)
        Me.plusRightLabel.TabIndex = 4
        Me.plusRightLabel.Text = "?"
        Me.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(248, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 50)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(248, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 50)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "="
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusRight
        '
        Me.minusRight.Location = New System.Drawing.Point(182, 125)
        Me.minusRight.Name = "minusRight"
        Me.minusRight.Size = New System.Drawing.Size(60, 50)
        Me.minusRight.TabIndex = 8
        Me.minusRight.Text = "?"
        Me.minusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(116, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 50)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "-"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusLeft
        '
        Me.minusLeft.Location = New System.Drawing.Point(50, 125)
        Me.minusLeft.Name = "minusLeft"
        Me.minusLeft.Size = New System.Drawing.Size(60, 50)
        Me.minusLeft.TabIndex = 6
        Me.minusLeft.Text = "?"
        Me.minusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(248, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 50)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "="
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'multRight
        '
        Me.multRight.Location = New System.Drawing.Point(182, 175)
        Me.multRight.Name = "multRight"
        Me.multRight.Size = New System.Drawing.Size(60, 50)
        Me.multRight.TabIndex = 12
        Me.multRight.Text = "?"
        Me.multRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(116, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 50)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'multLeft
        '
        Me.multLeft.Location = New System.Drawing.Point(50, 175)
        Me.multLeft.Name = "multLeft"
        Me.multLeft.Size = New System.Drawing.Size(60, 50)
        Me.multLeft.TabIndex = 10
        Me.multLeft.Text = "?"
        Me.multLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(248, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 50)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "="
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'divRight
        '
        Me.divRight.Location = New System.Drawing.Point(182, 225)
        Me.divRight.Name = "divRight"
        Me.divRight.Size = New System.Drawing.Size(60, 50)
        Me.divRight.TabIndex = 16
        Me.divRight.Text = "?"
        Me.divRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(116, 225)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 50)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "/"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'divLeft
        '
        Me.divLeft.Location = New System.Drawing.Point(50, 225)
        Me.divLeft.Name = "divLeft"
        Me.divLeft.Size = New System.Drawing.Size(60, 50)
        Me.divLeft.TabIndex = 14
        Me.divLeft.Text = "?"
        Me.divLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sum
        '
        Me.sum.Location = New System.Drawing.Point(314, 92)
        Me.sum.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(70, 20)
        Me.sum.TabIndex = 18
        '
        'diff
        '
        Me.diff.Location = New System.Drawing.Point(314, 142)
        Me.diff.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.diff.Name = "diff"
        Me.diff.Size = New System.Drawing.Size(70, 20)
        Me.diff.TabIndex = 19
        '
        'prod
        '
        Me.prod.Location = New System.Drawing.Point(314, 192)
        Me.prod.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.prod.Name = "prod"
        Me.prod.Size = New System.Drawing.Size(70, 20)
        Me.prod.TabIndex = 20
        '
        'division
        '
        Me.division.Location = New System.Drawing.Point(314, 242)
        Me.division.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(70, 20)
        Me.division.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 44)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(25, 288)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(103, 44)
        Me.btnQuit.TabIndex = 23
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 355)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.prod)
        Me.Controls.Add(Me.diff)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.divRight)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.divLeft)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.multRight)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.multLeft)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.minusRight)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.minusLeft)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.plusRightLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.plusLeftLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.sum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.division, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents plusLeftLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents plusRightLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents minusRight As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents minusLeft As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents multRight As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents multLeft As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents divRight As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents divLeft As Label
    Friend WithEvents sum As NumericUpDown
    Friend WithEvents diff As NumericUpDown
    Friend WithEvents prod As NumericUpDown
    Friend WithEvents division As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents btnQuit As Button
End Class
