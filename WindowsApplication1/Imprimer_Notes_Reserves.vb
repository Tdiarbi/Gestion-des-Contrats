Public Class Imprimer_Notes_Reserves

    Private Sub Imprimer_Notes_Reserves_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO : cette ligne de code charge les données dans la table 'ContratDataSet1.Note_des_Reserves_Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Note_des_Reserves_ClientTableAdapter.Fill(Me.ContratDataSet1.Note_des_Reserves_Client)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class