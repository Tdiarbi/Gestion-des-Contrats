Imports System.IO
Imports System.Data.SqlClient
Imports System.DateTime
Imports System.Data.SqlTypes

Public Class ODS
    Dim sqldatenull As SqlDateTime
    Dim nom As String
    Dim filetomove As String
    Dim movelocation As String

    '----- Fonction pour Supprimer  les champs  ------'
    Private Sub supp()
        cmbTO.Text = Nothing
        cmbDO.Text = Nothing
        cmbREFF.Text = Nothing
        cmbConREF.Text = Nothing
        txtStructure.Text = Nothing
        txtClient.Text = Nothing
        txtMontant.Text = Nothing
        txtCommande.Text = Nothing
        txtReference.Text = Nothing
        dateDS.Text = Nothing
        DateDN.Text = Nothing
        txtSc.Text = Nothing
        txtObj.Text = Nothing
        txtDcontractuelle.Text = Nothing
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
        Dim cmd1 As New SqlCommand("select * from ODS", con)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub


    Private Sub ODS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        d_styleRow()
        afficher()

        If role = "user4" Then

            txtid = True
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True
            btnEnregistrer.Enabled = True
            btnSupprimer.Enabled = True
            btnModifier.Enabled = True
        ElseIf role = "user" Then
            DataGridView1.Visible = True

        ElseIf role = "admin" Then

            btnEnregistrer.Enabled = True
            Panel3.Visible = True

        ElseIf role = "user2" Then
            btnEnregistrer.Enabled = True
            btnSupprimer.Enabled = True
            btnModifier.Enabled = True
            txtid = True
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True
        ElseIf role = "user3" Then
            btnModifier.Enabled = True
            btnSupprimer.Enabled = True
            txtid = True
            DataGridView1.Visible = True
            btnch.Visible = True
            txtch.Visible = True
        End If

        'sum()


    End Sub

    Private Sub btnScanner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanner.Click
        Try
            Dim choisir As New OpenFileDialog

            If choisir.ShowDialog() = 1 Then
                txtSc.Text = choisir.FileName

            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try

    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Imprimer_ODS.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'd_styleRow()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        d_styleRow()
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtid = selectedRow.Cells(0).Value.ToString()
            txtClient.Text = selectedRow.Cells(1).Value.ToString()
            cmbConREF.Text = selectedRow.Cells(2).Value.ToString()
            txtObj.Text = selectedRow.Cells(3).Value.ToString()
            txtMontant.Text = selectedRow.Cells(4).Value.ToString()
            txtStructure.Text = selectedRow.Cells(5).Value.ToString()
            dateDS.Text = selectedRow.Cells(6).Value.ToString()
            txtReference.Text = selectedRow.Cells(7).Value.ToString()
            txtSc.Text = selectedRow.Cells(8).Value.ToString()
            txtCommande.Text = selectedRow.Cells(9).Value.ToString()
            txtDcontractuelle.Text = selectedRow.Cells(10).Value.ToString()
            cmbTO.Text = selectedRow.Cells(11).Value.ToString()
            cmbDO.Text = selectedRow.Cells(12).Value.ToString()
            txtCA.Text = selectedRow.Cells(13).Value.ToString()
            DateDN.Text = selectedRow.Cells(14).Value.ToString()
            cmbREFF.Text = selectedRow.Cells(15).Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtMontant_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontant.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregistrer.Click
        Try
            If txtClient.Text = Nothing Or txtReference.Text = Nothing Then

                MessageBox.Show("Veuillez remplir les champs", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf MsgBox("voulez vous vraiment Enregistrer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                con.Open()
                Dim cmd3 As New SqlCommand("select Contrat_de_Réfferrence from ODS where Contrat_de_Réfferrence ='" & cmbConREF.Text.Trim & "'", con)
                Dim myreader As SqlDataReader = cmd3.ExecuteReader
                If (myreader.Read()) Then
                    MessageBox.Show("ODS existe Déja")


                Else
                    con.Close()
                    txtCommande.Text = Replace(txtCommande.Text, "'", "''")
                    txtObj.Text = Replace(txtObj.Text, "'", "''")
                    txtStructure.Text = Replace(txtStructure.Text, "'", "''")

                    con.Open()
                    If CheckBox1.Checked = True Then
                        DateDN.CustomFormat = "          "
                      CheckBox1.Checked = True

                        cmd.CommandText = "insert into ODS values('" & txtClient.Text & "','" & cmbConREF.Text & "','" & txtObj.Text & "','" & txtMontant.Text & "','" & txtStructure.Text & "','" & dateDS.Value & "','" & txtReference.Text & "','" & txtSc.Text & "','" & txtCommande.Text & "','" & txtDcontractuelle.Text & "','" & cmbTO.Text & "','" & cmbDO.Text & "','" & txtCA.Text & "',NULL,'" & cmbREFF.Text & "','" & LoginForm1.txtuser.Text & "','" & Now.Date & "')"
                        cmd.Connection = con
                        cmd.ExecuteNonQuery()
                        MsgBox("Enregistrer avec succès :)")
                        con.Close()
                        supp()
                        afficher()
                    Else
                        cmd.CommandText = "insert into ODS values('" & txtClient.Text & "','" & cmbConREF.Text & "','" & txtObj.Text & "','" & txtMontant.Text & "','" & txtStructure.Text & "','" & dateDS.Value & "','" & txtReference.Text & "','" & txtSc.Text & "','" & txtCommande.Text & "','" & txtDcontractuelle.Text & "','" & cmbTO.Text & "','" & cmbDO.Text & "','" & txtCA.Text & "','" & DateDN.Value & "','" & cmbREFF.Text & "','" & LoginForm1.txtuser.Text & "','" & Now.Date & "')"

                        cmd.Connection = con
                        cmd.ExecuteNonQuery()
                        MsgBox("Enregistrer avec succès :)")
                        con.Close()
                        supp()
                        afficher()
                    End If
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
                cmd.CommandText = " delete from ODS where ID = " & txtid
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
            OpenFileDialog1.Filter = "word Files |*.docx"

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

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Imprimer_ODS.ShowDialog()
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

    Private Sub cmbTO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub


    Private Sub cmbDO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtDcontractuelle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDcontractuelle.KeyPress
        Try
            '97 - 122 = Ascii codes for simple letters
            '65 - 90  = Ascii codes for capital letters
            '48 - 57  = Ascii codes for numbers

            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                    e.Handled = True
                End If
            End If

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
            '   MessageBox.Show(ErrorToString)
        End Try
    End Sub


    Private Sub loading(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try

            Dim command As New SqlCommand("select * from ODS ", con)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            cmbREFF.DataSource = table
            cmbREFF.DisplayMember = "Réfferrence"
            cmbREFF.ValueMember = "id"

        Catch ex As Exception
            '   MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Sub sum()
        Try
            Dim cmds As New SqlCommand
            cmds.Connection = con
            cmds.CommandText = "select sum (Montant) as sumMontant from ODS where Contrat_de_Réfferrence = '" & cmbConREF.Text & "' "
            Dim adapter As New SqlDataAdapter(cmds)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() > 0 Then



                sumODS = table.Rows(0)("sumMontant").ToString()

            End If
            con.Close()

        Catch ex As Exception
            ' MessageBox.Show(ErrorToString)
        End Try
    End Sub


    Private Sub txtMontant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontant.TextChanged
        Try
            sum()

            Dim number1 As Double
            Dim number2 As Double
            Dim number3 As Double

            number1 = Convert.ToDouble(txtMontant.Text)
            number2 = Convert.ToDouble(sumODS)
            number3 = Convert.ToDouble(sumcontrat)

            If number3 < number2 + number1 Then
               


                MsgBox("le montant des ods est supérieur au montant du contrat")
            End If
        Catch ex As Exception
            'MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub loading1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try

            Dim command As New SqlCommand("select * from Contrat ", con1)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            cmbConREF.DataSource = table
            cmbConREF.DisplayMember = "Réfferrence"
            cmbConREF.ValueMember = "id"

        Catch ex As Exception
            '    MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        Try

            If MsgBox("voulez vous vraiment modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                txtCommande.Text = Replace(txtCommande.Text, "'", "''")
                txtObj.Text = Replace(txtObj.Text, "'", "''")
                txtClient.Text = Replace(txtClient.Text, "'", "''")

                con.Open()

                If CheckBox1.Checked = True Then
                    DateDN.CustomFormat = "          "
                    CheckBox1.Checked = True
                    cmd.CommandText = "update ODS set client= '" & txtClient.Text & "',Contrat_de_Réfferrence='" & cmbConREF.Text & "',Objet_de_la_Demande='" & txtObj.Text & "',Montant = '" & txtMontant.Text & "',Structure='" & txtStructure.Text & "',Date_Signature = '" & dateDS.Value & "', Réfferrence = '" & txtReference.Text & "',Chemin_Fichier ='" & txtSc.Text & "',Commande='" & txtCommande.Text & "',Delai_Contractuelle='" & txtDcontractuelle.Text & "',Type_ODS='" & cmbTO.Text & "',Detenteur_ODS='" & cmbDO.Text & "',Code_Affaire='" & txtCA.Text & "',Date_Notification= NULL , ODS_Initiale='" & cmbREFF.Text & "',Utilisateur='" & LoginForm1.txtuser.Text & "',Date_Saisie='" & Now.Date & "' where ID = '" & txtid & "'"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    MsgBox("Modifier avec succès :)")
                    con.Close()
                    supp()
                    afficher()
                Else
                    cmd.CommandText = "update ODS set client= '" & txtClient.Text & "',Contrat_de_Réfferrence='" & cmbConREF.Text & "',Objet_de_la_Demande='" & txtObj.Text & "',Montant = '" & txtMontant.Text & "',Structure='" & txtStructure.Text & "',Date_Signature = '" & dateDS.Value & "', Réfferrence = '" & txtReference.Text & "',Chemin_Fichier ='" & txtSc.Text & "',Commande='" & txtCommande.Text & "',Delai_Contractuelle='" & txtDcontractuelle.Text & "',Type_ODS='" & cmbTO.Text & "',Detenteur_ODS='" & cmbDO.Text & "',Code_Affaire='" & txtCA.Text & "',Date_Notification= '" & DateDN.Value & "', ODS_Initiale='" & cmbREFF.Text & "',Utilisateur='" & LoginForm1.txtuser.Text & "',Date_Saisie='" & Now.Date & "' where ID = '" & txtid & "'"
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

    Private Sub cmbConREF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConREF.SelectedIndexChanged
        Try

            Dim cmds As New SqlCommand
            cmds.Connection = con
            cmds.CommandText = "select Montant from Contrat where Réfferrence like '%" & cmbConREF.Text & "%' "
            Dim adapter As New SqlDataAdapter(cmds)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() > 0 Then

                sumcontrat = table.Rows(0).Item("Montant").ToString()

            End If

            '
            sum()
            '
        Catch ex As Exception
            'MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub cmbREFF_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbREFF.SelectedIndexChanged
        Try
            Dim sqla As String
            Dim cmda As New SqlCommand
            Dim dta As New DataTable
            Dim daa As New SqlDataAdapter

            sqla = "select * from ODS where  Réfferrence like '%" & cmbREFF.Text & "%' "
            cmda.Connection = con
            cmda.CommandText = sqla
            daa.SelectCommand = cmda

            daa.Fill(dta)

            If dta.Rows.Count > 0 Then
                cmbTO.Text = dta.Rows(0).Item("Type_ODS").ToString
                cmbREFF.Text = dta.Rows(0).Item("Réfferrence").ToString
                cmbDO.Text = dta.Rows(0).Item("Detenteur_ODS").ToString
                cmbConREF.Text = dta.Rows(0).Item("Contrat_de_Réfferrence").ToString
                txtStructure.Text = dta.Rows(0).Item("Structure").ToString
                txtClient.Text = dta.Rows(0).Item("Client").ToString
                txtMontant.Text = dta.Rows(0).Item("Montant").ToString
                txtCommande.Text = dta.Rows(0).Item("Commande").ToString
                txtReference.Text = dta.Rows(0).Item("Réfferrence").ToString
                dateDS.Text = dta.Rows(0).Item("Date_Signature").ToString
                txtSc.Text = dta.Rows(0).Item("Chemin_Fichier").ToString
                txtObj.Text = dta.Rows(0).Item("Objet_de_la_Demande").ToString
                txtDcontractuelle.Text = dta.Rows(0).Item("Delai_Contractuelle").ToString
                txtid = dta.Rows(0).Item("id").ToString
                txtCA.Text = dta.Rows(0).Item("Code_Affaire").ToString
                DateDN.Text = dta.Rows(0).Item("Date_Notification").ToString
                CheckBox1.Checked = dta.Rows(0).Item("ODS_Initiale").ToString

            End If

        Catch ex As Exception
            '   MessageBox.Show(ErrorToString)
        End Try
    End Sub

End Class