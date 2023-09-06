<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnGreetings = New Button()
        lblCountry = New Label()
        txtCountry = New TextBox()
        SuspendLayout()
        ' 
        ' btnGreetings
        ' 
        btnGreetings.Location = New Point(359, 174)
        btnGreetings.Name = "btnGreetings"
        btnGreetings.Size = New Size(166, 74)
        btnGreetings.TabIndex = 0
        btnGreetings.Text = "Greetings"
        btnGreetings.UseVisualStyleBackColor = True
        ' 
        ' lblCountry
        ' 
        lblCountry.AutoSize = True
        lblCountry.Location = New Point(143, 84)
        lblCountry.Name = "lblCountry"
        lblCountry.Size = New Size(194, 20)
        lblCountry.TabIndex = 1
        lblCountry.Text = "Which Country are you from"
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(359, 77)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(226, 27)
        txtCountry.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtCountry)
        Controls.Add(lblCountry)
        Controls.Add(btnGreetings)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGreetings As Button
    Friend WithEvents lblCountry As Label
    Friend WithEvents txtCountry As TextBox
End Class
