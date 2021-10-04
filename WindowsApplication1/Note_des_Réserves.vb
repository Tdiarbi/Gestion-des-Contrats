Imports System.Data.SqlClient
Public Class Note_des_Réserves
    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=loginform;Integrated Security=True")
    Public cmd As New SqlCommand
    Public Sub afficher()
        Dim cmd1 As New SqlCommand("select * from Note_des_Réserves_Client", con)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub

    Private Sub Note_des_Réserves_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'LoginformDataSet11.Note_des_Réserves_Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Note_des_Réserves_ClientTableAdapter.Fill(Me.LoginformDataSet11.Note_des_Réserves_Client)

    End Sub

    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
        Try
            If MsgBox("voulez vous vraiment Enregistrer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                con.Open()
                cmd.CommandText = "insert into Note_des_Réserves_Client values('" & txtClient.Text & "','" & txtMP.Text & "','" & txtPC.Text & "','" & txtNote.Text & "')"
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MsgBox("Enregistrer avec succès :)")
                con.Close()
                afficher()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        Try
            If MsgBox("voulez vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                con.Open()
                cmd.CommandText = "update Note_des_Réserves_Client set client= '" & txtClient.Text & "',mode_passation = '" & txtMP.Text & "',projet_contrat='" & txtPC.Text & "',note='" & txtNote.Text & "' where ID = '" & txtID.Text & "'"
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MsgBox("Modifier avec succès :)")
                con.Close()
                afficher()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        Try
            If MsgBox("voulez vous vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then

                con.Open()
                cmd.CommandText = " delete from Note_des_Réserves_Client where ID = " & txtID.Text
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MsgBox("supprimer avec succès :)")
                con.Close()
                afficher()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim choisir As New OpenFileDialog

        If choisir.ShowDialog() = 1 Then
            txtPC.Text = choisir.FileName

        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtID.Text = selectedRow.Cells(0).Value.ToString()
            txtClient.Text = selectedRow.Cells(1).Value.ToString()
            txtMP.Text = selectedRow.Cells(2).Value.ToString()
            txtPC.Text = selectedRow.Cells(3).Value.ToString()
            txtNote.Text = selectedRow.Cells(4).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class