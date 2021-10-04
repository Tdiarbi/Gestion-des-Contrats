Public Class imprimer_Validation_Contrat

    Private Sub imprimer_Validation_Contrat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'loDataSet.Validation_contrat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Validation_contratTableAdapter.Fill(Me.loDataSet.Validation_contrat)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class