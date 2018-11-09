<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pinjam
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tTglPinjam = New System.Windows.Forms.DateTimePicker()
        Me.tIdMember = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.tLamaPinjam = New System.Windows.Forms.ComboBox()
        Me.lvItemPinjam = New System.Windows.Forms.ListView()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Member"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl Pinjam"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lama Pinjam"
        '
        'tTglPinjam
        '
        Me.tTglPinjam.CustomFormat = "yyyy/MM/dd"
        Me.tTglPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tTglPinjam.Location = New System.Drawing.Point(112, 59)
        Me.tTglPinjam.Name = "tTglPinjam"
        Me.tTglPinjam.Size = New System.Drawing.Size(170, 20)
        Me.tTglPinjam.TabIndex = 3
        '
        'tIdMember
        '
        Me.tIdMember.Location = New System.Drawing.Point(112, 29)
        Me.tIdMember.Name = "tIdMember"
        Me.tIdMember.Size = New System.Drawing.Size(170, 20)
        Me.tIdMember.TabIndex = 4
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(288, 27)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(58, 23)
        Me.btnFind.TabIndex = 5
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'tLamaPinjam
        '
        Me.tLamaPinjam.FormattingEnabled = True
        Me.tLamaPinjam.Location = New System.Drawing.Point(112, 88)
        Me.tLamaPinjam.Name = "tLamaPinjam"
        Me.tLamaPinjam.Size = New System.Drawing.Size(119, 21)
        Me.tLamaPinjam.TabIndex = 6
        '
        'lvItemPinjam
        '
        Me.lvItemPinjam.Location = New System.Drawing.Point(33, 173)
        Me.lvItemPinjam.Name = "lvItemPinjam"
        Me.lvItemPinjam.Size = New System.Drawing.Size(518, 145)
        Me.lvItemPinjam.TabIndex = 7
        Me.lvItemPinjam.UseCompatibleStateImageBehavior = False
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(112, 132)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(66, 27)
        Me.btnAddItem.TabIndex = 8
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(195, 133)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 26)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 362)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.lvItemPinjam)
        Me.Controls.Add(Me.tLamaPinjam)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.tIdMember)
        Me.Controls.Add(Me.tTglPinjam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pinjam"
        Me.Text = "Peminjaman"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tTglPinjam As System.Windows.Forms.DateTimePicker
    Friend WithEvents tIdMember As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents tLamaPinjam As System.Windows.Forms.ComboBox
    Friend WithEvents lvItemPinjam As System.Windows.Forms.ListView
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
