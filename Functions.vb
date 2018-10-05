

Module Functions
    Public SelectedDrive As String
    Public Dt As New DataTable
    Public Sub LoadStorage()
        Dt.Rows.Clear()
        For Each d As IO.DriveInfo In My.Computer.FileSystem.Drives
            If d.DriveType = IO.DriveType.Removable Then
                Dt.Rows.Add(d.VolumeLabel, d.RootDirectory.Name)
                ShortcutDoctor.DriveShowList.DataSource = Dt
                ShortcutDoctor.DriveShowList.DisplayMember = "Drive"
                ShortcutDoctor.DriveShowList.ValueMember = "Label"
            End If
        Next
    End Sub
    Public Sub CallDoctor()
        Dim startInfo As New ProcessStartInfo("CMD.EXE")
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.CreateNoWindow = True
        startInfo.UseShellExecute = False
        If ShortcutDoctor.DelShortcut.Checked And ShortcutDoctor.DelEXE.Checked Then
            startInfo.Arguments = "/C del " & SelectedDrive & "*.lnk" & "&del " & SelectedDrive & "*.exe" & "&attrib -h -r -s /s /d " & SelectedDrive & "*.*"
        ElseIf ShortcutDoctor.DelShortcut.Checked Then
            startInfo.Arguments = "/C del " & SelectedDrive & "*.lnk" & "&attrib -h -r -s /s /d " & SelectedDrive & "*.*"
        ElseIf ShortcutDoctor.DelEXE.Checked Then
            startInfo.Arguments = "/C del " & SelectedDrive & "*.exe" & "&attrib -h -r -s /s /d " & SelectedDrive & "*.*"
        Else
            startInfo.Arguments = "/C attrib -h -r -s /s /d " & SelectedDrive & "*.*"
        End If
        Cursor.Current = Cursors.WaitCursor
        Process.Start(startInfo).WaitForExit()
        Cursor.Current = Cursors.Arrow
        MessageBox.Show("patient has been treated! Happy Life" & vbCrLf & "this Tool is Made by Dinesh Solanki (Facebook.com/iamDineshSolanki)", "Success")
    End Sub
End Module
