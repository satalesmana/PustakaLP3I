<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBuku
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tFind = New System.Windows.Forms.Button()
        Me.lvDialogBuku = New System.Windows.Forms.ListView()
        Me.tKeyword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Find Data"
        '
        'tFind
        '
        Me.tFind.Location = New System.Drawing.Point(329, 2)
        Me.tFind.Name = "tFind"
        Me.tFind.Size = New System.Drawing.Size(71, 25)
        Me.tFind.TabIndex = 6
        Me.tFind.Text = "Find Data"
        Me.tFind.UseVisualStyleBackColor = True
        '
        'lvDialogBuku
        '
        Me.lvDialogBuku.Location = New System.Drawing.Point(12, 32)
        Me.lvDialogBuku.Name = "lvDialogBuku"
        Me.lvDialogBuku.Size = New System.Drawing.Size(388, 372)
        Me.lvDialogBuku.TabIndex = 5
        Me.lvDialogBuku.UseCompatibleStateImageBehavior = False
        '
        'tKeyword
        '
        Me.tKeyword.Location = New System.Drawing.Point(93, 5)
        Me.tKeyword.Name = "tKeyword"
        Me.tKeyword.Size = New System.Drawing.Size(230, 20)
        Me.tKeyword.TabIndex = 4
        '
        'DialogBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 418)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tFind)
        Me.Controls.Add(Me.lvDialogBuku)
        Me.Controls.Add(Me.tKeyword)
        Me.Name = "DialogBuku"
        Me.Text = "DialogBuku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tFind As System.Windows.Forms.Button
    Friend WithEvents lvDialogBuku As System.Windows.Forms.ListView
    Friend WithEvents tKeyword As System.Windows.Forms.TextBox
End Class
