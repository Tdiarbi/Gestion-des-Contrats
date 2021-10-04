Imports word = Microsoft.Office.Interop.Word

Public Class OpenWordDocument

    Private Sub Word_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Try
            If result = Windows.Forms.DialogResult.OK Then
                'Dim path As String = OpenFileDialog1.FileName
                'Dim wdApp As word.Application = New word.Application()
                ' Dim wdDoc As word.Document = wdApp.Documents.Open(path.ToString)
                'Dim lines As String() = wdDoc.Paragraphs.Cast(Of word.Paragraph).Select(Function(x) x.Range.Text.Trim()).ToArray()
                'RichTextBox1.Lines = lines
                'wdDoc.Close(SaveChanges:=False)
                'wdApp.Quit()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Dim word As Word.Application
    'Dim doc As Word.Document
    'word = CreateObject("word.Application")
    'Dim path As String = Application.StartupPath & "\test.docx"
    'doc = word.Documents.Open(path)
    'word.Visible = True


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Using sfd As New SaveFileDialog
            With sfd
               
                .AddExtension = True
                .FileName = "fichier"
                .DefaultExt = ".docx"
                .Filter = "Portable Document Files (*.doc)|*.docx"
                .FilterIndex = 1
                .InitialDirectory = Application.StartupPath & "\scan"
                .Title = "select the location to save word file"
                .ValidateNames = True
            End With

            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then


                 Dim word As Byte() = My.Resources.induction_finale

                My.Computer.FileSystem.WriteAllBytes(sfd.FileName, word, False)
                MsgBox("le fichier est sauvegarder |", MsgBoxStyle.Information, "information")
            End If

        End Using
    End Sub
End Class