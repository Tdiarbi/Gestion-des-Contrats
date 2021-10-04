Imports System
Imports System.IO

Imports System.Data.SqlClient

Public Class Contrat1
    Dim datevalid As String
    Dim dateretour As String
    Dim nom As String
    Dim filetomove As String
    Dim movelocation As String
    '----- Fonction pour Supprimer  les champs  ------'
    Private Sub supp()

        txtClient.Text = Nothing
        txtDC.Text = Nothing
        txtMontant.Text = Nothing
        txtCommande.Text = Nothing
        txtReference.Text = Nothing
        dateDS.Text = Nothing
        cmbTp.Text = Nothing
        cmpNC.Text = Nothing
        txtSc.Text = Nothing
        cmbDC.Text = Nothing
        txtObj.Text = Nothing
        txtDcontractuelle.Text = Nothing
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

    Dim con As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=Contrat;Integrated Security=True")
    Public cmd As New SqlCommand
    Public Sub afficher()
        Dim cmd1 As New SqlCommand("select * from contrat", con)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'd_styleRow()
    End Sub

    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'd_styleRow()
        afficher()


        If role = "admin" Then

            btnEnregistrer.Enabled = True
            Panel3.Visible = True
        ElseIf role = "user" Then
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True

        ElseIf role = "user2" Then
            btnEnregistrer.Enabled = True
            btnch.Visible = True
            txtch.Visible = True
            btnSupprimer.Enabled = True
            btnModifier.Enabled = True
            DataGridView1.Visible = True

        ElseIf role = "user3" Then
            btnSupprimer.Enabled = True
            btnModifier.Enabled = True
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True

        ElseIf role = "user4" Then

            btnch.Visible = True
            txtch.Visible = True

            DataGridView1.Visible = True

        End If

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
            txtMontant.Text = selectedRow.Cells(2).Value.ToString()
            dateDS.Text = selectedRow.Cells(3).Value.ToString()
            txtReference.Text = selectedRow.Cells(4).Value.ToString()
            txtObj.Text = selectedRow.Cells(5).Value.ToString()
            cmbMP.Text = selectedRow.Cells(6).Value.ToString()
            txtDC.Text = selectedRow.Cells(7).Value.ToString()
            cmbTp.Text = selectedRow.Cells(8).Value.ToString()
            txtSc.Text = selectedRow.Cells(9).Value.ToString()
            txtCommande.Text = selectedRow.Cells(10).Value.ToString()
            txtDcontractuelle.Text = selectedRow.Cells(11).Value.ToString()
            cmpNC.Text = selectedRow.Cells(12).Value.ToString()
            cmbDC.Text = selectedRow.Cells(13).Value.ToString()
            txtCA.Text = selectedRow.Cells(16).Value.ToString()
            DateDN.Text = selectedRow.Cells(17).Value.ToString()
            DateFin.Text = selectedRow.Cells(18).Value.ToString()
            CheckBox1.Checked = selectedRow.Cells(19).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            PDF.OpenFileDialog1.Filter = " PDF Files |*.pdf"

            If PDF.OpenFileDialog1.ShowDialog = DialogResult.OK Then
                PDF.AxAcroPDF1.src = PDF.OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            OpenFileDialog1.Filter = "PDF Files |*.pdf"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim FileToMove As String = OpenFileDialog1.FileName
                Dim MoveLocation As String = SaveFileDialog1.FileName
                Dim nom As String

                nom = Path.GetFileName(OpenFileDialog1.FileName)
                FileToMove = OpenFileDialog1.FileName
                MoveLocation = Application.StartupPath & "\" + nom + ""

                If System.IO.File.Exists(FileToMove) = True Then

                    System.IO.File.Move(FileToMove, MoveLocation)
                    MessageBox.Show("Fichier Enregistrer")

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            OpenFileDialog1.Filter = "word Files |*.docx"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim FileToMove As String = OpenFileDialog1.FileName
                Dim MoveLocation As String = SaveFileDialog1.FileName
                Dim nom As String

                nom = Path.GetFileName(OpenFileDialog1.FileName)
                FileToMove = OpenFileDialog1.FileName
                MoveLocation = Application.StartupPath & "\" + nom + ""

                If System.IO.File.Exists(FileToMove) = True Then

                    System.IO.File.Move(FileToMove, MoveLocation)
                    MessageBox.Show("Fichier Enregistrer")

                End If
            End If




        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cmbMP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True

    End Sub


    Private Sub cmbTp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True

    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
        Try
            If txtClient.Text = Nothing Or txtMontant.Text = Nothing Or txtDcontractuelle.Text = Nothing Then

                MessageBox.Show("Veuillez remplir les champs", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf MsgBox("voulez vous vraiment Enregistrer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                txtCommande.Text = Replace(txtCommande.Text, "'", "''")
                txtObj.Text = Replace(txtObj.Text, "'", "''")
                txtClient.Text = Replace(txtClient.Text, "'", "''")
                cmbMP.Text = Replace(cmbMP.Text, "'", "''")
                cmpNC.Text = Replace(cmpNC.Text, "'", "''")
                con.Open()
                If CheckBox1.Checked = True Then

                    DateFin.CustomFormat = "          "

                    CheckBox1.Checked = True
                    cmd.CommandText = "insert into Contrat values('" & txtClient.Text & "','" & txtMontant.Text & "','" & dateDS.Value & "','" & txtReference.Text & "','" & txtObj.Text & "','" & cmbMP.Text & "','" & txtDC.Text & "','" & cmbTp.SelectedItem & "','" & txtSc.Text & "','" & txtCommande.Text & "','" & txtDcontractuelle.Text & "','" & cmpNC.Text & "','" & cmbDC.Text & "','" & datevalid & "','" & dateretour & "' ,'" & txtCA.Text & "','" & DateDN.Value & "',NULL,'" & CheckBox1.Checked & "','" & LoginForm1.txtuser.Text & "','" & Now.Date & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Enregistrer avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                Else
                    cmd.CommandText = "insert into Contrat values('" & txtClient.Text & "','" & txtMontant.Text & "','" & dateDS.Value & "','" & txtReference.Text & "','" & txtObj.Text & "','" & cmbMP.Text & "','" & txtDC.Text & "','" & cmbTp.SelectedItem & "','" & txtSc.Text & "','" & txtCommande.Text & "','" & txtDcontractuelle.Text & "','" & cmpNC.Text & "','" & cmbDC.Text & "','" & datevalid & "','" & dateretour & "' ,'" & txtCA.Text & "','" & DateDN.Value & "','" & DateFin.Value & "','" & CheckBox1.Checked & "','" & LoginForm1.txtuser.Text & "','" & Now.Date & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Enregistrer avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                End If
                If CheckBox2.Checked = True Then
                    DateDN.CustomFormat = "          "

                    CheckBox2.Checked = True
                    cmd.CommandText = "insert into Contrat values('" & txtClient.Text & "','" & txtMontant.Text & "','" & dateDS.Value & "','" & txtReference.Text & "','" & txtObj.Text & "','" & cmbMP.Text & "','" & txtDC.Text & "','" & cmbTp.SelectedItem & "','" & txtSc.Text & "','" & txtCommande.Text & "','" & txtDcontractuelle.Text & "','" & cmpNC.Text & "','" & cmbDC.Text & "','" & datevalid & "','" & dateretour & "' ,'" & txtCA.Text & "',NULL,'" & DateFin.Value & "','" & CheckBox1.Checked & "','" & LoginForm1.txtuser.Text & "','" & Now.Date & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Enregistrer avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                Else
                    cmd.CommandText = "insert into Contrat values('" & txtClient.Text & "','" & txtMontant.Text & "','" & dateDS.Value & "','" & txtReference.Text & "','" & txtObj.Text & "','" & cmbMP.Text & "','" & txtDC.Text & "','" & cmbTp.SelectedItem & "','" & txtSc.Text & "','" & txtCommande.Text & "','" & txtDcontractuelle.Text & "','" & cmpNC.Text & "','" & cmbDC.Text & "','" & datevalid & "','" & dateretour & "' ,'" & txtCA.Text & "','" & DateDN.Value & "','" & DateFin.Value & "','" & CheckBox1.Checked & "','" & LoginForm1.txtuser.Text & "','" & Now.Date & "')"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Enregistrer avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click

        Try

            If MsgBox("voulez vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                txtCommande.Text = Replace(txtCommande.Text, "'", "''")
                txtObj.Text = Replace(txtObj.Text, "'", "''")
                txtClient.Text = Replace(txtClient.Text, "'", "''")
                cmbMP.Text = Replace(cmbMP.Text, "'", "''")
                cmpNC.Text = Replace(cmpNC.Text, "'", "''")
                con.Open()

                If CheckBox1.Checked = True Then

                    DateFin.CustomFormat = "          "

                    CheckBox1.Checked = True
                    cmd.CommandText = "update Contrat set client= '" & txtClient.Text & "', Montant = '" & txtMontant.Text & "', Date_Signature = '" & dateDS.Value & "', Réfferrence = '" & txtReference.Text & "', Objet_de_la_demande = '" & txtObj.Text & "',Mode_de_passation = '" & cmbMP.Text & "',Durée_contrat = '" & txtDC.Text & "',Type_contrat ='" & cmbTp.SelectedItem & "',Chemin_Fichier ='" & txtSc.Text & "',Commande='" & txtCommande.Text & "',Delai_Contractuelle='" & txtDcontractuelle.Text & "',Nature_Contrat='" & cmpNC.Text & "',Detenteur_Contrat='" & cmbDC.Text & "',Code_Affaire='" & txtCA.Text & "',Date_Notification= '" & DateDN.Value & "' ,Date_Fin_Contrat= NULL ,Fin_Reception='" & CheckBox1.Checked & "',Utilisateur='" & LoginForm1.txtuser.Text & "',Date_Saisie='" & Now.Date & "' where ID = '" & txtid & "'"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Modifier avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                Else
                    cmd.CommandText = "update Contrat set client= '" & txtClient.Text & "', Montant = '" & txtMontant.Text & "', Date_Signature = '" & dateDS.Value & "', Réfferrence = '" & txtReference.Text & "', Objet_de_la_demande = '" & txtObj.Text & "',Mode_de_passation = '" & cmbMP.Text & "',Durée_contrat = '" & txtDC.Text & "',Type_contrat ='" & cmbTp.SelectedItem & "',Chemin_Fichier ='" & txtSc.Text & "',Commande='" & txtCommande.Text & "',Delai_Contractuelle='" & txtDcontractuelle.Text & "',Nature_Contrat='" & cmpNC.Text & "',Detenteur_Contrat='" & cmbDC.Text & "',Code_Affaire='" & txtCA.Text & "',Date_Notification= '" & DateDN.Value & "' ,Date_Fin_Contrat='" & DateFin.Value & "',Fin_Reception='" & CheckBox1.Checked & "',Utilisateur='" & LoginForm1.txtuser.Text & "',Date_Saisie='" & Now.Date & "' where ID = '" & txtid & "'"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Modifier avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                End If


                If CheckBox2.Checked = True Then
                    DateDN.CustomFormat = "          "

                    CheckBox2.Checked = True
                    cmd.CommandText = "update Contrat set client= '" & txtClient.Text & "', Montant = '" & txtMontant.Text & "', Date_Signature = '" & dateDS.Value & "', Réfferrence = '" & txtReference.Text & "', Objet_de_la_demande = '" & txtObj.Text & "',Mode_de_passation = '" & cmbMP.Text & "',Durée_contrat = '" & txtDC.Text & "',Type_contrat ='" & cmbTp.SelectedItem & "',Chemin_Fichier ='" & txtSc.Text & "',Commande='" & txtCommande.Text & "',Delai_Contractuelle='" & txtDcontractuelle.Text & "',Nature_Contrat='" & cmpNC.Text & "',Detenteur_Contrat='" & cmbDC.Text & "',Code_Affaire='" & txtCA.Text & "',Date_Notification= NULL ,Date_Fin_Contrat='" & DateFin.Value & "',Fin_Reception='" & CheckBox1.Checked & "',Utilisateur='" & LoginForm1.txtuser.Text & "',Date_Saisie='" & Now.Date & "' where ID = '" & txtid & "'"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Modifier avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                Else
                    cmd.CommandText = "update Contrat set client= '" & txtClient.Text & "', Montant = '" & txtMontant.Text & "', Date_Signature = '" & dateDS.Value & "', Réfferrence = '" & txtReference.Text & "', Objet_de_la_demande = '" & txtObj.Text & "',Mode_de_passation = '" & cmbMP.Text & "',Durée_contrat = '" & txtDC.Text & "',Type_contrat ='" & cmbTp.SelectedItem & "',Chemin_Fichier ='" & txtSc.Text & "',Commande='" & txtCommande.Text & "',Delai_Contractuelle='" & txtDcontractuelle.Text & "',Nature_Contrat='" & cmpNC.Text & "',Detenteur_Contrat='" & cmbDC.Text & "',Code_Affaire='" & txtCA.Text & "',Date_Notification= '" & DateDN.Value & "' ,Date_Fin_Contrat='" & DateFin.Value & "',Fin_Reception='" & CheckBox1.Checked & "',Utilisateur='" & LoginForm1.txtuser.Text & "',Date_Saisie='" & Now.Date & "' where ID = '" & txtid & "'"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Modifier avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        Try
            If MsgBox("voulez vous vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then

                con.Open()
                cmd.CommandText = " delete from Contrat where ID = " & txtid
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
            OpenFileDialog1.Filter = "PDF Files |*.pdf"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim FileToMove As String = OpenFileDialog1.FileName
                Dim MoveLocation As String = SaveFileDialog1.FileName
                Dim nom As String

                nom = Path.GetFileName(OpenFileDialog1.FileName)


            End If
            nom = Path.GetFileName(OpenFileDialog1.FileName)
            filetomove = OpenFileDialog1.FileName

            Dim userpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\SCAN " & "\" + nom + ""
            nom = Path.GetFileName(OpenFileDialog1.FileName)

            movelocation = userpath

            If System.IO.File.Exists(filetomove) = True Then

                System.IO.File.Move(filetomove, movelocation)
                MessageBox.Show("Fichier Enregistrer")

            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Try
            OpenFileDialog1.Filter = "word file |*.docx"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim FileToMove As String = OpenFileDialog1.FileName
                Dim MoveLocation As String = SaveFileDialog1.FileName
                Dim nom As String

                nom = Path.GetFileName(OpenFileDialog1.FileName)


            End If

            nom = Path.GetFileName(OpenFileDialog1.FileName)
            filetomove = OpenFileDialog1.FileName

            Dim userpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\SCAN " & "\" + nom + ""
            nom = Path.GetFileName(OpenFileDialog1.FileName)

            movelocation = userpath

            If System.IO.File.Exists(filetomove) = True Then

                System.IO.File.Move(filetomove, movelocation)
                MessageBox.Show("Fichier Enregistrer")

            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Try
            OpenFileDialog1.Filter = "PDF Files |*.pdf"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                PDF.AxAcroPDF1.src = OpenFileDialog1.FileName
                PDF.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try
            Imprimer_Contrat.ShowDialog()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Private Sub DataGridView1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DataSourceChanged
        d_styleRow()
    End Sub



    Private Sub cmbDC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cmpNC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub


    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub DataGridView1_DefaultCellStyleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DefaultCellStyleChanged
        d_styleRow()
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


    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            supp()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    

    Private Sub txtMontant_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontant.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDC_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDC.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDcontractuelle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDcontractuelle.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtScanne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScanne.Click
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