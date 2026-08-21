<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblname = New Label()
        lblage = New Label()
        lblcourse = New Label()
        txtname = New TextBox()
        txtage = New TextBox()
        txtcourse = New TextBox()
        btnregister = New Button()
        SuspendLayout()
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Location = New Point(29, 21)
        lblname.Name = "lblname"
        lblname.Size = New Size(39, 15)
        lblname.TabIndex = 0
        lblname.Text = "Name"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Location = New Point(29, 88)
        lblage.Name = "lblage"
        lblage.Size = New Size(28, 15)
        lblage.TabIndex = 1
        lblage.Text = "Age"
        ' 
        ' lblcourse
        ' 
        lblcourse.AutoSize = True
        lblcourse.Location = New Point(29, 151)
        lblcourse.Name = "lblcourse"
        lblcourse.Size = New Size(44, 15)
        lblcourse.TabIndex = 2
        lblcourse.Text = "Course"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(29, 39)
        txtname.Name = "txtname"
        txtname.Size = New Size(275, 23)
        txtname.TabIndex = 3
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(29, 106)
        txtage.Name = "txtage"
        txtage.Size = New Size(275, 23)
        txtage.TabIndex = 4
        ' 
        ' txtcourse
        ' 
        txtcourse.Location = New Point(29, 169)
        txtcourse.Name = "txtcourse"
        txtcourse.Size = New Size(275, 23)
        txtcourse.TabIndex = 5
        ' 
        ' btnregister
        ' 
        btnregister.Location = New Point(103, 231)
        btnregister.Name = "btnregister"
        btnregister.Size = New Size(75, 23)
        btnregister.TabIndex = 6
        btnregister.Text = "Register"
        btnregister.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(407, 339)
        Controls.Add(btnregister)
        Controls.Add(txtcourse)
        Controls.Add(txtage)
        Controls.Add(txtname)
        Controls.Add(lblcourse)
        Controls.Add(lblage)
        Controls.Add(lblname)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lblcourse As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents btnregister As Button

End Class
