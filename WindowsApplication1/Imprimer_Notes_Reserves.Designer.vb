<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimer_Notes_Reserves
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprimer_Notes_Reserves))
        Me.Note_des_Reserves_ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContratDataSet1 = New GestionContrats.ContratDataSet1
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Note_des_Reserves_ClientTableAdapter = New GestionContrats.ContratDataSet1TableAdapters.Note_des_Reserves_ClientTableAdapter
        CType(Me.Note_des_Reserves_ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Note_des_Reserves_ClientBindingSource
        '
        Me.Note_des_Reserves_ClientBindingSource.DataMember = "Note_des_Reserves_Client"
        Me.Note_des_Reserves_ClientBindingSource.DataSource = Me.ContratDataSet1
        '
        'ContratDataSet1
        '
        Me.ContratDataSet1.DataSetName = "ContratDataSet1"
        Me.ContratDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ContratDataSet1_Note_des_Reserves_Client"
        ReportDataSource1.Value = Me.Note_des_Reserves_ClientBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionContrats.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(609, 409)
        Me.ReportViewer1.TabIndex = 0
        '
        'Note_des_Reserves_ClientTableAdapter
        '
        Me.Note_des_Reserves_ClientTableAdapter.ClearBeforeFill = True
        '
        'Imprimer_Notes_Reserves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 409)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Imprimer_Notes_Reserves"
        Me.Text = "Impression Notes des Reserves"
        CType(Me.Note_des_Reserves_ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Note_des_Reserves_ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContratDataSet1 As GestionContrats.ContratDataSet1
    Friend WithEvents Note_des_Reserves_ClientTableAdapter As GestionContrats.ContratDataSet1TableAdapters.Note_des_Reserves_ClientTableAdapter
End Class
