Public Class ShortcutDoctor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Add Columns to DataTable
        Dt.Columns.Add("Label")
        Dt.Columns.Add("Drive")
        ''Load external Device Info into Combobox
        LoadStorage()
        If Not DriveShowList.Text = Nothing Then
            SelectedDrive = DriveShowList.Text.ToString()
            Label2.Text = DriveShowList.SelectedValue.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show(DriveShowList.SelectedText & vbCrLf & DriveShowList.Text & vbCrLf & DriveShowList.SelectedValue & vbCrLf & DriveShowList.ValueMember)
        If DriveShowList.Text = Nothing Then
            DriveShowList.Focus()
            Exit Sub

        ElseIf MessageBox.Show("Are you sure ?", "confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            CallDoctor()
        End If
        'LoadStorage()
    End Sub

    Private Sub DriveShowList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DriveShowList.SelectedIndexChanged
        If Not DriveShowList.Text = Nothing Then
            SelectedDrive = DriveShowList.SelectedText.ToString()
            Label2.Text = DriveShowList.SelectedValue.ToString()
        Else
            Label2.Text = Nothing
        End If ''Show Drive Letter
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadStorage() ''Refresh Storage info
    End Sub
End Class
