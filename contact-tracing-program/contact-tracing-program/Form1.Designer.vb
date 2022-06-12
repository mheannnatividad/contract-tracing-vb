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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.boxGivenName = New System.Windows.Forms.TextBox()
        Me.labelGivenName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.boxMiddleName = New System.Windows.Forms.TextBox()
        Me.labelMiddleName = New System.Windows.Forms.Label()
        Me.boxLastName = New System.Windows.Forms.TextBox()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.boxCourse = New System.Windows.Forms.TextBox()
        Me.labelCourse = New System.Windows.Forms.Label()
        Me.boxStudentNo = New System.Windows.Forms.TextBox()
        Me.labelStudentNo = New System.Windows.Forms.Label()
        Me.boxBirthdate = New System.Windows.Forms.TextBox()
        Me.labelBirthdate = New System.Windows.Forms.Label()
        Me.boxEmail = New System.Windows.Forms.TextBox()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.boxContactNo = New System.Windows.Forms.TextBox()
        Me.labelContactNo = New System.Windows.Forms.Label()
        Me.boxGender = New System.Windows.Forms.TextBox()
        Me.labelGender = New System.Windows.Forms.Label()
        Me.boxHomeAdd = New System.Windows.Forms.TextBox()
        Me.labelHomeAdd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(3, 3)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(262, 37)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Student Contact"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(353, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 42)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(266, 265)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 42)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'boxGivenName
        '
        Me.boxGivenName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxGivenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxGivenName.Location = New System.Drawing.Point(10, 76)
        Me.boxGivenName.Name = "boxGivenName"
        Me.boxGivenName.Size = New System.Drawing.Size(119, 23)
        Me.boxGivenName.TabIndex = 2
        '
        'labelGivenName
        '
        Me.labelGivenName.AutoSize = True
        Me.labelGivenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGivenName.Location = New System.Drawing.Point(7, 56)
        Me.labelGivenName.Name = "labelGivenName"
        Me.labelGivenName.Size = New System.Drawing.Size(101, 17)
        Me.labelGivenName.TabIndex = 3
        Me.labelGivenName.Text = "Given Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 10)
        Me.Panel1.TabIndex = 4
        '
        'boxMiddleName
        '
        Me.boxMiddleName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxMiddleName.Location = New System.Drawing.Point(138, 76)
        Me.boxMiddleName.Name = "boxMiddleName"
        Me.boxMiddleName.Size = New System.Drawing.Size(119, 23)
        Me.boxMiddleName.TabIndex = 2
        '
        'labelMiddleName
        '
        Me.labelMiddleName.AutoSize = True
        Me.labelMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMiddleName.Location = New System.Drawing.Point(135, 56)
        Me.labelMiddleName.Name = "labelMiddleName"
        Me.labelMiddleName.Size = New System.Drawing.Size(106, 17)
        Me.labelMiddleName.TabIndex = 3
        Me.labelMiddleName.Text = "Middle Name:"
        '
        'boxLastName
        '
        Me.boxLastName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxLastName.Location = New System.Drawing.Point(266, 76)
        Me.boxLastName.Name = "boxLastName"
        Me.boxLastName.Size = New System.Drawing.Size(119, 23)
        Me.boxLastName.TabIndex = 2
        '
        'labelLastName
        '
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLastName.Location = New System.Drawing.Point(263, 56)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(90, 17)
        Me.labelLastName.TabIndex = 3
        Me.labelLastName.Text = "Last Name:"
        '
        'boxCourse
        '
        Me.boxCourse.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxCourse.Location = New System.Drawing.Point(10, 125)
        Me.boxCourse.Name = "boxCourse"
        Me.boxCourse.Size = New System.Drawing.Size(119, 23)
        Me.boxCourse.TabIndex = 2
        '
        'labelCourse
        '
        Me.labelCourse.AutoSize = True
        Me.labelCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCourse.Location = New System.Drawing.Point(7, 105)
        Me.labelCourse.Name = "labelCourse"
        Me.labelCourse.Size = New System.Drawing.Size(103, 17)
        Me.labelCourse.TabIndex = 3
        Me.labelCourse.Text = "Course/Year:"
        '
        'boxStudentNo
        '
        Me.boxStudentNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxStudentNo.Location = New System.Drawing.Point(138, 125)
        Me.boxStudentNo.Name = "boxStudentNo"
        Me.boxStudentNo.Size = New System.Drawing.Size(147, 23)
        Me.boxStudentNo.TabIndex = 2
        '
        'labelStudentNo
        '
        Me.labelStudentNo.AutoSize = True
        Me.labelStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStudentNo.Location = New System.Drawing.Point(135, 105)
        Me.labelStudentNo.Name = "labelStudentNo"
        Me.labelStudentNo.Size = New System.Drawing.Size(130, 17)
        Me.labelStudentNo.TabIndex = 3
        Me.labelStudentNo.Text = "Student Number:"
        '
        'boxBirthdate
        '
        Me.boxBirthdate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxBirthdate.Location = New System.Drawing.Point(296, 125)
        Me.boxBirthdate.Name = "boxBirthdate"
        Me.boxBirthdate.Size = New System.Drawing.Size(132, 23)
        Me.boxBirthdate.TabIndex = 2
        '
        'labelBirthdate
        '
        Me.labelBirthdate.AutoSize = True
        Me.labelBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBirthdate.Location = New System.Drawing.Point(293, 105)
        Me.labelBirthdate.Name = "labelBirthdate"
        Me.labelBirthdate.Size = New System.Drawing.Size(135, 17)
        Me.labelBirthdate.TabIndex = 3
        Me.labelBirthdate.Text = "Birthdate (m/d/y):"
        '
        'boxEmail
        '
        Me.boxEmail.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxEmail.Location = New System.Drawing.Point(10, 174)
        Me.boxEmail.Name = "boxEmail"
        Me.boxEmail.Size = New System.Drawing.Size(141, 23)
        Me.boxEmail.TabIndex = 2
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEmail.Location = New System.Drawing.Point(7, 154)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(52, 17)
        Me.labelEmail.TabIndex = 3
        Me.labelEmail.Text = "Email:"
        '
        'boxContactNo
        '
        Me.boxContactNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxContactNo.Location = New System.Drawing.Point(160, 173)
        Me.boxContactNo.Name = "boxContactNo"
        Me.boxContactNo.Size = New System.Drawing.Size(141, 23)
        Me.boxContactNo.TabIndex = 2
        '
        'labelContactNo
        '
        Me.labelContactNo.AutoSize = True
        Me.labelContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelContactNo.Location = New System.Drawing.Point(157, 153)
        Me.labelContactNo.Name = "labelContactNo"
        Me.labelContactNo.Size = New System.Drawing.Size(129, 17)
        Me.labelContactNo.TabIndex = 3
        Me.labelContactNo.Text = "Contact Number:"
        '
        'boxGender
        '
        Me.boxGender.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxGender.Location = New System.Drawing.Point(310, 173)
        Me.boxGender.Name = "boxGender"
        Me.boxGender.Size = New System.Drawing.Size(75, 23)
        Me.boxGender.TabIndex = 2
        '
        'labelGender
        '
        Me.labelGender.AutoSize = True
        Me.labelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGender.Location = New System.Drawing.Point(307, 153)
        Me.labelGender.Name = "labelGender"
        Me.labelGender.Size = New System.Drawing.Size(67, 17)
        Me.labelGender.TabIndex = 3
        Me.labelGender.Text = "Gender:"
        '
        'boxHomeAdd
        '
        Me.boxHomeAdd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.boxHomeAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxHomeAdd.Location = New System.Drawing.Point(10, 220)
        Me.boxHomeAdd.Name = "boxHomeAdd"
        Me.boxHomeAdd.Size = New System.Drawing.Size(418, 23)
        Me.boxHomeAdd.TabIndex = 2
        '
        'labelHomeAdd
        '
        Me.labelHomeAdd.AutoSize = True
        Me.labelHomeAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHomeAdd.Location = New System.Drawing.Point(7, 200)
        Me.labelHomeAdd.Name = "labelHomeAdd"
        Me.labelHomeAdd.Size = New System.Drawing.Size(118, 17)
        Me.labelHomeAdd.TabIndex = 3
        Me.labelHomeAdd.Text = "Home Address:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(442, 319)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labelGender)
        Me.Controls.Add(Me.boxGender)
        Me.Controls.Add(Me.labelBirthdate)
        Me.Controls.Add(Me.boxBirthdate)
        Me.Controls.Add(Me.labelLastName)
        Me.Controls.Add(Me.boxLastName)
        Me.Controls.Add(Me.labelMiddleName)
        Me.Controls.Add(Me.boxMiddleName)
        Me.Controls.Add(Me.labelStudentNo)
        Me.Controls.Add(Me.boxStudentNo)
        Me.Controls.Add(Me.labelContactNo)
        Me.Controls.Add(Me.boxContactNo)
        Me.Controls.Add(Me.labelHomeAdd)
        Me.Controls.Add(Me.boxHomeAdd)
        Me.Controls.Add(Me.labelEmail)
        Me.Controls.Add(Me.boxEmail)
        Me.Controls.Add(Me.labelCourse)
        Me.Controls.Add(Me.boxCourse)
        Me.Controls.Add(Me.labelGivenName)
        Me.Controls.Add(Me.boxGivenName)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.titleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Student Contact Tracing App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents boxGivenName As TextBox
    Friend WithEvents labelGivenName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents boxMiddleName As TextBox
    Friend WithEvents labelMiddleName As Label
    Friend WithEvents boxLastName As TextBox
    Friend WithEvents labelLastName As Label
    Friend WithEvents boxCourse As TextBox
    Friend WithEvents labelCourse As Label
    Friend WithEvents boxStudentNo As TextBox
    Friend WithEvents labelStudentNo As Label
    Friend WithEvents boxBirthdate As TextBox
    Friend WithEvents labelBirthdate As Label
    Friend WithEvents boxEmail As TextBox
    Friend WithEvents labelEmail As Label
    Friend WithEvents boxContactNo As TextBox
    Friend WithEvents labelContactNo As Label
    Friend WithEvents boxGender As TextBox
    Friend WithEvents labelGender As Label
    Friend WithEvents boxHomeAdd As TextBox
    Friend WithEvents labelHomeAdd As Label
End Class
