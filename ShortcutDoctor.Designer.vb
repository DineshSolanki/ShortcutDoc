<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShortcutDoctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShortcutDoctor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DriveShowList = New System.Windows.Forms.ComboBox()
        Me.DelShortcut = New System.Windows.Forms.CheckBox()
        Me.DelEXE = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Drive:"
        '
        'DriveShowList
        '
        Me.DriveShowList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DriveShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DriveShowList.FormattingEnabled = True
        Me.DriveShowList.Location = New System.Drawing.Point(125, 15)
        Me.DriveShowList.Name = "DriveShowList"
        Me.DriveShowList.Size = New System.Drawing.Size(67, 21)
        Me.DriveShowList.TabIndex = 1
        '
        'DelShortcut
        '
        Me.DelShortcut.AutoSize = True
        Me.DelShortcut.Checked = True
        Me.DelShortcut.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DelShortcut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelShortcut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelShortcut.Location = New System.Drawing.Point(53, 81)
        Me.DelShortcut.Name = "DelShortcut"
        Me.DelShortcut.Size = New System.Drawing.Size(101, 17)
        Me.DelShortcut.TabIndex = 2
        Me.DelShortcut.Text = "Delete Shortcut"
        Me.DelShortcut.UseVisualStyleBackColor = True
        '
        'DelEXE
        '
        Me.DelEXE.AutoSize = True
        Me.DelEXE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelEXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelEXE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelEXE.Location = New System.Drawing.Point(53, 114)
        Me.DelEXE.Name = "DelEXE"
        Me.DelEXE.Size = New System.Drawing.Size(88, 17)
        Me.DelEXE.TabIndex = 3
        Me.DelEXE.Text = "Delete EXE(s)"
        Me.DelEXE.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!)
        Me.Button1.Location = New System.Drawing.Point(50, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Fix it !"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(145, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 40)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 11.25!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(50, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 207)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DelEXE)
        Me.Controls.Add(Me.DelShortcut)
        Me.Controls.Add(Me.DriveShowList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Shortcut Doctor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DriveShowList As System.Windows.Forms.ComboBox
    Friend WithEvents DelShortcut As System.Windows.Forms.CheckBox
    Friend WithEvents DelEXE As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
