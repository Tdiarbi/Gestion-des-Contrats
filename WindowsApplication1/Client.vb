Imports System.Data.SqlClient
Public Class Client


    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=loginform;Integrated Security=True")
    Public cmd As New SqlCommand
    Public Sub afficher()
        Dim cmd1 As New SqlCommand("select * from Table_contrat", con)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub
    Private Sub btnEnregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
        Try
            If MsgBox("voulez vous vraiment Enregistrer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                con.Open()
                cmd.CommandText = "insert into Table_Contrat values('" & txtClient.Text & "','" & txtMontant.Text & "','" & txtDS.Text & "','" & txtReference.Text & "','" & txtObj.Text & "','" & txtMP.Text & "','" & txtDC.Text & "','" & cmbTp.SelectedItem & "','" & txtSc.Text & "','" & txtCommande.Text & "','" & txtDcontractuelle.Text & "')"
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        afficher()
        If role = "admin" Then

            btnEnregistrer.Enabled = True
            Panel3.Visible = True
        ElseIf role = "user" Then
            DataGridView1.Visible = True
        ElseIf role = "user2" Then
            btnModifier.Enabled = True
            DataGridView1.Visible = True

        ElseIf role = "user3" Then
            btnSupprimer.Enabled = True
            DataGridView1.Visible = True


        End If

    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        Try
            If MsgBox("voulez vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                con.Open()
                cmd.CommandText = "update Table_Contrat set client= '" & txtClient.Text & "', Montant = '" & txtMontant.Text & "', Date_Signature = '" & txtDS.Text & "', Réfferrence = '" & txtReference.Text & "', Objet_de_la_demande = '" & txtObj.Text & "',Mode_de_passation = '" & txtMP.Text & "',Durée_contrat = '" & txtDC.Text & "',Type_contrat ='" & cmbTp.SelectedItem & "',Fichier_PDF ='" & txtSc.Text & "',Commande='" & txtCommande.Text & "',Delai_Contractuelle='" & txtDcontractuelle.Text & "'where ID = '" & txtID.Text & "'"
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
                cmd.CommandText = " delete from Table_Contrat where ID = " & txtID.Text
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim cmd1 As New SqlCommand("select * from Table_contrat where client like '%'+@parm1+ '%' ", con)
            cmd1.Parameters.AddWithValue("@parm1", txtch.Text)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd1
            Dim table1 As New DataTable
            table1.Clear()
            da.Fill(table1)
            DataGridView1.DataSource = table1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            print.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtScanne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScanne.Click
        Dim choisir As New OpenFileDialog

        If choisir.ShowDialog() = 1 Then
            txtSc.Text = choisir.FileName

        End If

    End Sub


    Private Sub cmbTp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTp.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtID.Text = selectedRow.Cells(0).Value.ToString()
            txtClient.Text = selectedRow.Cells(1).Value.ToString()
            txtMontant.Text = selectedRow.Cells(2).Value.ToString()
            txtReference.Text = selectedRow.Cells(3).Value.ToString()
            txtObj.Text = selectedRow.Cells(4).Value.ToString()
            txtMP.Text = selectedRow.Cells(5).Value.ToString()
            txtDC.Text = selectedRow.Cells(6).Value.ToString()
            cmbTp.Text = selectedRow.Cells(7).Value.ToString()
            txtSc.Text = selectedRow.Cells(8).Value.ToString()
            txtCommande.Text = selectedRow.Cells(9).Value.ToString()
            txtDcontractuelle.Text = selectedRow.Cells(10).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("!")
        End Try
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            PDF.OpenFileDialog1.Filter = " PDF Files |*.pdf"

            If PDF.OpenFileDialog1.ShowDialog = DialogResult.OK Then
                PDF.AxAcroPDF1.src = PDF.OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            OpenFileDialog1.Filter = "PDF Files |*.pdf"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                PDF.AxAcroPDF1.src = OpenFileDialog1.FileName
                PDF.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Using sfd As New SaveFileDialog
                With sfd
                    .AddExtension = True
                    .FileName = "fichier"
                    .DefaultExt = ".pdf"
                    .Filter = "Portable Document Files (*.pdf)|*.pdf"
                    .FilterIndex = 1
                    .InitialDirectory = Application.StartupPath & "\scan"
                    .Title = "select the location to save pdf file"
                    .ValidateNames = True

                End With

                If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then

                    Dim pdf As Byte() = My.Resources._1

                    My.Computer.FileSystem.WriteAllBytes(sfd.FileName, pdf, False)
                    MsgBox("le fichier est sauvegarder |", MsgBoxStyle.Information, "information")
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class