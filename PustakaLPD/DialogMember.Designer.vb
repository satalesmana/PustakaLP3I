<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogMember
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
        Me.tKeyword = New System.Windows.Forms.TextBox()
        Me.lvDialogMember = New System.Windows.Forms.ListView()
        Me.tFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tKeyword
        '
        Me.tKeyword.Location = New System.Drawing.Point(99, 16)
        Me.tKeyword.Name = "tKeyword"
        Me.tKeyword.Size = New System.Drawing.Size(230, 20)
        Me.tKeyword.TabIndex = 0
        '
        'lvDialogMember
        '
        Me.lvDialogMember.Location = New System.Drawing.Point(18, 43)
        Me.lvDialogMember.Name = "lvDialogMember"
        Me.lvDialogMember.Size = New System.Drawing.Size(388, 372)
        Me.lvDialogMember.TabIndex = 1
        Me.lvDialogMember.UseCompatibleStateImageBehavior = False
        '
        'tFind
        '
        Me.tFind.Location = New System.Drawing.Point(335, 13)
        Me.tFind.Name = "tFind"
        Me.tFind.Size = New System.Drawing.Size(71, 25)
        Me.tFind.TabIndex = 2
        Me.tFind.Text = "Find Data"
        Me.tFind.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Find Data"
        '
        'DialogMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 427)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tFind)
        Me.Controls.Add(Me.lvDialogMember)
        Me.Controls.Add(Me.tKeyword)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogMember"
        Me.Text = "Dialog Member"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tKeyword As System.Windows.Forms.TextBox
    Friend WithEvents lvDialogMember As System.Windows.Forms.ListView
    Friend WithEvents tFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
