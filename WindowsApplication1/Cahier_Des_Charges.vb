Imports System.Data.SqlClient

Public Class Cahier_Des_Charges
    '----- Fonction pour Supprimer  les champs  ------'
    Private Sub supp()
        txtObj.Text = Nothing
        txtStructure.Text = Nothing
        txtRéfference.Text = Nothing
        cmbMP.Text = Nothing
        txtid = Nothing
        txtCA.Text = Nothing
        txtSc.Text = Nothing
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
    Dim con As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=Contrat;Integrated Security=True")
    Public cmd As New SqlCommand

    Public Sub afficher()
        Dim cmd1 As New SqlCommand("select * from Cahier_des_charges", con)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub
    


    Private Sub txtScanne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim choisir As New OpenFileDialog

            If choisir.ShowDialog() = 1 Then
                txtSc.Text = choisir.FileName

            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    

    Private Sub Cahier_Des_Charges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        afficher()
        If role = "admin" Then

            btnEnregistrer.Enabled = True
            Panel2.Visible = True
        ElseIf role = "user4" Then
            Panel2.Visible = True
            btnch.Visible = True
            txtch.Visible = True
            DataGridView1.Visible = True
        ElseIf role = "user" Then
            DataGridView1.Visible = True
        ElseIf role = "user2" Then
            btnEnregistrer.Enabled = True
            btnSupprimer.Enabled = True
            btnModifier.Enabled = True
            txtid = True
            btnch.Visible = True
            txtch.Visible = True
            DataGridView1.Visible = True
        ElseIf role = "user3" Then
            btnModifier.Enabled = True
            btnSupprimer.Enabled = True
            txtid = True
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Imprimer_ch.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'd_styleRow()
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtid = selectedRow.Cells(0).Value.ToString()
            txtObj.Text = selectedRow.Cells(1).Value.ToString()
            txtRéfference.Text = selectedRow.Cells(2).Value.ToString()
            txtStructure.Text = selectedRow.Cells(3).Value.ToString()
            cmbMP.Text = selectedRow.Cells(4).Value.ToString()
            txtSc.Text = selectedRow.Cells(5).Value.ToString()
            txtCA.Text = selectedRow.Cells(6).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
        Try
            If txtObj.Text = Nothing Or txtRéfference.Text = Nothing Then

                MessageBox.Show("Veuillez remplir les champs", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf MsgBox("voulez vous vraiment Enregistrer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                txtObj.Text = Replace(txtObj.Text, "'", "''")
                cmbMP.Text = Replace(cmbMP.Text, "'", "''")
                con.Open()
                cmd.CommandText = "insert into Cahier_des_charges values('" & txtObj.Text & "','" & txtRéfference.Text & "','" & txtStructure.Text & "','" & cmbMP.Text & "','" & txtSc.Text & "','" & txtCA.Text & "','" & LoginForm1.txtuser.Text & "','" & Now.Date.ToShortDateString & "')"
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
                txtObj.Text = Replace(txtObj.Text, "'", "''")
                cmbMP.Text = Replace(cmbMP.Text, "'", "''")

                con.Open()
                cmd.CommandText = "update Cahier_des_charges set Objet_de_la_demande = '" & txtObj.Text & "', Réfferrence= '" & txtRéfference.Text & "', Structure = '" & txtStructure.Text & "', Mode_Passation = '" & cmbMP.Text & "', Chemin_Fichier = '" & txtSc.Text & "',Code_Affaire='" & txtCA.Text & "',Utilisateur='" & LoginForm1.txtuser.Text & "',Date_Saisie='" & Now.Date & "' where ID = '" & txtid & "'"
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
                cmd.CommandText = " delete from Cahier_des_charges where ID = " & txtid
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

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            Imprimer_ch.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub cmbMP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMP.KeyPress
        e.Handled = True
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnch.Click
        Try
            Dim cmd1 As New SqlCommand("select * from Cahier_des_charges where client like '%'+@parm1+ '%' ", con)
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

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            supp()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub txtScanne_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScanne.Click
        Try
            Dim choisir As New OpenFileDialog

            If choisir.ShowDialog() = 1 Then
                txtSc.Text = choisir.FileName

            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class