Imports System.Data.SqlClient
Public Class Note_Reserves
    '----- Fonction pour Supprimer  les champs  ------'
    Private Sub supp()
        txtPC.Text = Nothing
        txtNote.Text = Nothing
        txtClient.Text = Nothing
         cmbMP.Text = Nothing
        txtid = Nothing
        txtCA.Text = Nothing
    End Sub
    Sub d_styleRow()

        For i As Integer = 0 To DataGridView1.RowCount - 1

            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue

            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If


        Next
    End Sub
    Public Sub afficher()
        Dim cmd1 As New SqlCommand("select * from Note_des_Reserves_Client", con)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
        
        Try
            If txtClient.Text = Nothing Or txtNote.Text = Nothing Then

                MessageBox.Show("Veuillez remplir les champs", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf MsgBox("voulez vous vraiment Enregistrer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                txtNote.Text = Replace(txtNote.Text, "'", "''")
                cmbMP.Text = Replace(cmbMP.Text, "'", "''")

                con.Open()
                cmd.CommandText = "insert into Note_des_Reserves_Client values('" & txtClient.Text & "','" & cmbMP.Text & "','" & txtPC.Text & "','" & txtNote.Text & "','" & txtCA.Text & "','" & LoginForm1.txtuser.Text & "','" & Now.Date & "')"
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MsgBox("Enregistrer avec succès :)")
                con.Close()
                supp()
                afficher()
            End If

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        Try
            
            If MsgBox("voulez vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                txtNote.Text = Replace(txtNote.Text, "'", "''")
                cmbMP.Text = Replace(cmbMP.Text, "'", "''")
                con.Open()
                cmd.CommandText = "update Note_des_Reserves_Client set client= '" & txtClient.Text & "',mode_passation = '" & cmbMP.Text & "',projet_contrat='" & txtPC.Text & "',note='" & txtNote.Text & "',Code_Affaire='" & txtCA.Text & "',Utilisateur='" & LoginForm1.txtuser.Text & "',Date_Saisie='" & Now.Date & "' where ID = '" & txtid & "'"
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MsgBox("Modifier avec succès :)")

                con.Close()
                supp()
                afficher()
            End If

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        Try
            If MsgBox("voulez vous vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then

                con.Open()
                cmd.CommandText = " delete from Note_des_Reserves_Client where ID = " & txtid
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MsgBox("supprimer avec succès :)")
                con.Close()
                supp()
                afficher()

            End If

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub Note_Reserves_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        afficher()

        If role = "admin" Then

            btnEnregistrer.Enabled = True
            DataGridView1.Visible = False
            Panel2.Visible = True
        ElseIf role = "user" Then
            DataGridView1.Visible = True
        ElseIf role = "user2" Then
            btnEnregistrer.Enabled = True
            btnSupprimer.Enabled = True
            btnModifier.Enabled = True
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True
        ElseIf role = "user3" Then
            btnModifier.Enabled = True
            btnSupprimer.Enabled = True
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True
        ElseIf role = "user4" Then
           
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Imprimer_Notes_Reserves.ShowDialog()
    End Sub

    Private Sub cmbMP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMP.KeyPress
        e.Handled = True
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'd_styleRow()
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtid = selectedRow.Cells(0).Value.ToString()
            txtClient.Text = selectedRow.Cells(1).Value.ToString()
            cmbMP.Text = selectedRow.Cells(2).Value.ToString()
            txtPC.Text = selectedRow.Cells(3).Value.ToString()
            txtNote.Text = selectedRow.Cells(4).Value.ToString()
            txtCA.Text = selectedRow.Cells(5).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        supp()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnch.Click
        Try
            Dim cmd1 As New SqlCommand("select * from contrat where client like '%'+@parm1+ '%' ", con)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim choisir As New OpenFileDialog

            If choisir.ShowDialog() = 1 Then
                txtPC.Text = choisir.FileName

            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim choisir As New OpenFileDialog

            If choisir.ShowDialog() = 1 Then
                txtNote.Text = choisir.FileName

            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class