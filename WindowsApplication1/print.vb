Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class print


    Private Sub print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'loginformDataSet11.Table_Contrat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Table_ContratTableAdapter.Fill(Me.loginformDataSet11.Table_Contrat)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class