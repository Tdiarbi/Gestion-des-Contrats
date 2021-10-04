Public Class Imprimer_ODS

    Private Sub Imprimer_ODS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'ContratDataSet3.ODS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ODSTableAdapter.Fill(Me.ContratDataSet3.ODS)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class