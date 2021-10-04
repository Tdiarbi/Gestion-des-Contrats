Imports System.Data.SqlClient
Public Class Liste_Cahier_Des_Charges
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
        'Dim cmd1 As New SqlCommand("select * from Cahier_des_charges", con)
        'Dim da As New SqlDataAdapter
        'da.SelectCommand = cmd1
        'Dim table1 As New DataTable
        'table1.Clear()
        'da.Fill(table1)
        'DataGridView1.DataSource = table1
    End Sub


    


    Private Sub Liste_ODS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'ContratDataSet3.Cahier_des_charges'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Cahier_des_chargesTableAdapter.Fill(Me.ContratDataSet3.Cahier_des_charges)
        dgv_styleRow()
        'afficher()
    End Sub

    Private Sub DataGridView1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        dgv_styleRow()
    End Sub

   

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtid = selectedRow.Cells(0).Value.ToString()
            Informations_Cahier_Des_Chargesvb.txtObj.Text = selectedRow.Cells(1).Value.ToString()
            Informations_Cahier_Des_Chargesvb.txtRéfference.Text = selectedRow.Cells(2).Value.ToString()
            Informations_Cahier_Des_Chargesvb.txtStructure.Text = selectedRow.Cells(3).Value.ToString()
            Informations_Cahier_Des_Chargesvb.txtMP.Text = selectedRow.Cells(4).Value.ToString()
            Informations_Cahier_Des_Chargesvb.txtSC1.Text = selectedRow.Cells(5).Value.ToString()
            Informations_Cahier_Des_Chargesvb.txtCA.Text = selectedRow.Cells(6).Value.ToString()
            Informations_Cahier_Des_Chargesvb.txtUtilisateur.Text = selectedRow.Cells(7).Value.ToString()
            Informations_Cahier_Des_Chargesvb.txtDateSaisie.Text = selectedRow.Cells(8).Value.ToString()
            Informations_Cahier_Des_Chargesvb.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim cmd1 As New SqlCommand("select * from cahier_des_charges where Objet_de_la_demande like '%'+@parm1+ '%' ", con)
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
End Class