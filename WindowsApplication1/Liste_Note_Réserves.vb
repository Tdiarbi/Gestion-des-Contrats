Imports System.Data.SqlClient
Public Class Liste_Note_Réserves
    Sub dgv_styleRow()

        For i As Integer = 0 To DataGridView1.RowCount - 1

            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue

            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If


        Next
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim cmd1 As New SqlCommand("select * from Note_des_Réserves_Client where client like '%'+@parm1+ '%' ", con)
            cmd1.Parameters.AddWithValue("@parm1", txtch.Text)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd1
            Dim table1 As New DataTable
            table1.Clear()
            da.Fill(table1)
            DataGridView1.DataSource = table1
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    

    Private Sub Liste_Note_Réserves_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'ContratDataSet3.Note_des_Reserves_Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Note_des_Reserves_ClientTableAdapter.Fill(Me.ContratDataSet3.Note_des_Reserves_Client)

        dgv_styleRow()
    End Sub

   

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtid = selectedRow.Cells(0).Value.ToString()
            Informations_Notes_Des_Réserves.txtClient.Text = selectedRow.Cells(1).Value.ToString()
            Informations_Notes_Des_Réserves.txtMP.Text = selectedRow.Cells(2).Value.ToString()
            Informations_Notes_Des_Réserves.txtPC.Text = selectedRow.Cells(3).Value.ToString()
            Informations_Notes_Des_Réserves.txtNote.Text = selectedRow.Cells(4).Value.ToString()
            Informations_Notes_Des_Réserves.txtCA.Text = selectedRow.Cells(5).Value.ToString()
            Informations_Notes_Des_Réserves.txtUtilisateur.Text = selectedRow.Cells(6).Value.ToString()
            Informations_Notes_Des_Réserves.txtDateSaisie.Text = selectedRow.Cells(7).Value.ToString()

            Informations_Notes_Des_Réserves.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class