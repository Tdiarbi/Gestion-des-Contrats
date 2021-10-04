Imports System.Data.SqlClient
Public Class Permission
    Dim constr As String = "server=DELL-SERV7;Database=Contrat;Uid=root;pwd=;Integrated Security=True"
    Dim conn As New SqlConnection(constr)
    Dim DataSetUsers As New DataSet
    Dim sqlusers As String = "select * from login"

    Public Sub AddUser()
        Try

            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO login (username,password,usertype)values (@username,@password,@usertype)"
            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim)
            cmd.Parameters.AddWithValue("@usertype", chbRole.Text.Trim)


            cmd.ExecuteScalar()
            conn.Close()


            MsgBox("Ajouter avec succés")



        Catch ex As Exception
            MsgBox("Erreur !: " + ex.Message)
        End Try
    End Sub
    Public Sub EditUser()
        Try

            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If

            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE login SET username=@username,password=@password,usertype=@usertype where id=" & txtid.Text & ""
            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim)
            cmd.Parameters.AddWithValue("@usertype", chbRole.Text.Trim)

            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("modifier avec succés")

        Catch ex As Exception
            MsgBox("Erreur!: " + ex.Message)
        End Try
    End Sub
    Public Sub deleteuser()
       
        If MsgBox("voulez vous supprimer!", MsgBoxStyle.OkCancel, "") = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        Try
           
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd1 As New SqlCommand
            cmd1.Connection = conn
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "delete from login where id = " & txtid.Text & ""
            cmd1.ExecuteScalar()
            conn.Close()
            MsgBox("le compte a été supprimer avec succés!!!")

        Catch ex As Exception
            MsgBox("erreur!: " + ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbRole.SelectedIndexChanged
        If chbRole.Text = "Admin" Then


        ElseIf chbRole.Text = "User" Then


        ElseIf chbRole.Text = "user2" Then

        ElseIf chbRole.Text = "user3" Then


        End If

    End Sub

    Private Sub Permi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'ContratDataSet.login'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.LoginTableAdapter.Fill(Me.ContratDataSet.login)
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddUser()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        EditUser()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        deleteuser()
    End Sub
End Class