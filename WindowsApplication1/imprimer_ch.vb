Public Class Imprimer_ch

    Private Sub Imprimer_ch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'ContratDataSet3.Cahier_des_charges'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Cahier_des_chargesTableAdapter.Fill(Me.ContratDataSet3.Cahier_des_charges)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class