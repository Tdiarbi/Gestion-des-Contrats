Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO : insérez le code pour effectuer une authentification personnalisée à l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Voir http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=Contrat;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select usertype from login where username='" & txtuser.Text & "' and password='" & txtpass.Text & "'", con)

            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then

                role = dt.Rows(0).Item(0).ToString
                'MsgBox(role)

                Projet_De_Contrat.Show()
                Me.Hide()

                If role = "user4" Then
                    Projet_De_Contrat.LoginToolStripMenuItem1.Visible = True

                    Projet_De_Contrat.NouveauToolStripMenuItem5.Enabled = True
                    Projet_De_Contrat.FournisseurToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ToolStripMenuItem2.Enabled = True
                    Projet_De_Contrat.APRPROCToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.FournisseursToolStripMenuItem1.Enabled = True
                    Projet_De_Contrat.FournisseursToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem6.Enabled = True
                    Projet_De_Contrat.modfToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ClientToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ToolStripMenuItem3.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem11.Enabled = True
                    Projet_De_Contrat.LOGCPAToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem2.Enabled = True
                    Projet_De_Contrat.ClientsToolStripMenuItem1.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem3.Enabled = True
                    Projet_De_Contrat.ClientsToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem4.Enabled = True
                    
                ElseIf role = "admin" Then

                    Projet_De_Contrat.NouveauToolStripMenuItem5.Enabled = True
                    Projet_De_Contrat.FournisseurToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ToolStripMenuItem2.Enabled = True
                    Projet_De_Contrat.APRPROCToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.FournisseursToolStripMenuItem1.Enabled = True
                    Projet_De_Contrat.FournisseursToolStripMenuItem.Enabled = True
                ElseIf role = "user" Then

                    Projet_De_Contrat.SupprimerToolStripMenuItem6.Enabled = True
                    Projet_De_Contrat.modfToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ClientToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ToolStripMenuItem3.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem11.Enabled = True
                    Projet_De_Contrat.LOGCPAToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem2.Enabled = True
                    Projet_De_Contrat.ClientsToolStripMenuItem1.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem3.Enabled = True
                    Projet_De_Contrat.ClientsToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem4.Enabled = True
                ElseIf role = "user2" Then

                    Projet_De_Contrat.NouveauToolStripMenuItem5.Enabled = True
                    Projet_De_Contrat.FournisseurToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ToolStripMenuItem2.Enabled = True
                    Projet_De_Contrat.APRPROCToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.FournisseursToolStripMenuItem1.Enabled = True
                    Projet_De_Contrat.FournisseursToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem6.Enabled = True
                    Projet_De_Contrat.modfToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ClientToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ToolStripMenuItem3.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem11.Enabled = True
                    Projet_De_Contrat.LOGCPAToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem2.Enabled = True
                    Projet_De_Contrat.ClientsToolStripMenuItem1.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem3.Enabled = True
                    Projet_De_Contrat.ClientsToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem4.Enabled = True

                ElseIf role = "user3" Then

                    Projet_De_Contrat.SupprimerToolStripMenuItem6.Enabled = True
                    Projet_De_Contrat.modfToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ClientToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.ToolStripMenuItem3.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem11.Enabled = True
                    Projet_De_Contrat.LOGCPAToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem2.Enabled = True
                    Projet_De_Contrat.ClientsToolStripMenuItem1.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem3.Enabled = True
                    Projet_De_Contrat.ClientsToolStripMenuItem.Enabled = True
                    Projet_De_Contrat.SupprimerToolStripMenuItem4.Enabled = True
                End If
            Else
                MessageBox.Show("erreur")
            End If
            'Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        With CheckBox1
            If .Checked Then
                txtpass.UseSystemPasswordChar = False
            Else
                txtpass.UseSystemPasswordChar = True
            End If
        End With
    End Sub

    
End Class