Imports System.Data.SqlClient
Public Class Liste_ODS
    Sub dgv_styleRow()

        For i As Integer = 0 To DataGridView1.RowCount - 1

            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue

            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If


        Next
    End Sub
    Dim con As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=Contrat;Integrated Security=True")
    Public cmd As New SqlCommand
    Public Sub afficher()
        Try
            Dim cmd1 As New SqlCommand("select * from ODS", con)
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


    Private Sub Liste_ODS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'ContratDataSet3.ODS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ODSTableAdapter.Fill(Me.ContratDataSet3.ODS)

        dgv_styleRow()
        afficher()
    End Sub

    Private Sub DataGridView1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DataSourceChanged
        dgv_styleRow()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim cmd1 As New SqlCommand("select * from ODS where client like '%'+@parm1+ '%' ", con)
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

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtid = selectedRow.Cells(0).Value.ToString()
            Informations_ODS.txtClient.Text = selectedRow.Cells(1).Value.ToString()
            Informations_ODS.txtContratReferrence.Text = selectedRow.Cells(2).Value.ToString()
            Informations_ODS.txtObj.Text = selectedRow.Cells(3).Value.ToString()
            Informations_ODS.txtMontant.Text = selectedRow.Cells(4).Value.ToString()
            Informations_ODS.txtStructure.Text = selectedRow.Cells(5).Value.ToString()
            Informations_ODS.txtDS.Text = selectedRow.Cells(6).Value.ToString()
            Informations_ODS.txtReference.Text = selectedRow.Cells(7).Value.ToString()
            Informations_ODS.txtSC1.Text = selectedRow.Cells(8).Value.ToString()
            Informations_ODS.txtCommande.Text = selectedRow.Cells(9).Value.ToString()
            Informations_ODS.txtDcontractuelle.Text = selectedRow.Cells(10).Value.ToString()
            Informations_ODS.txtTP.Text = selectedRow.Cells(11).Value.ToString()
            Informations_ODS.txtDO.Text = selectedRow.Cells(12).Value.ToString()
            Informations_ODS.txtCA.Text = selectedRow.Cells(13).Value.ToString()
            Informations_ODS.txtDN.Text = selectedRow.Cells(14).Value.ToString()
            Informations_ODS.txtODSinitiale.Text = selectedRow.Cells(15).Value.ToString()
            Informations_ODS.txtUtilisateur.Text = selectedRow.Cells(16).Value.ToString()
            Informations_ODS.txtDateSaisie.Text = selectedRow.Cells(17).Value.ToString()

            Informations_ODS.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class
