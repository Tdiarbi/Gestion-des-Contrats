Public Class Imprimer_Val_Contrat

    Private Sub Imprimer_Val_Contrat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'ContratDataSet3.Contrat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ContratTableAdapter.Fill(Me.ContratDataSet3.Contrat)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class