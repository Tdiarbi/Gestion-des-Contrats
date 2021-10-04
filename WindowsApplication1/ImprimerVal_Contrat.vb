Public Class ImprimerVal_Contrat

    Private Sub ImprimerVal_Contrat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'loginformDataSet11.ODS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ODSTableAdapter.Fill(Me.loginformDataSet11.ODS)
        'TODO : cette ligne de code charge les données dans la table 'loginformDataSet11.Validation_contrat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Validation_contratTableAdapter.Fill(Me.loginformDataSet11.Validation_contrat)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class