<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimer_Validation_Contrat
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.loDataSet = New WindowsApplication1.loDataSet
        Me.Validation_contratBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Validation_contratTableAdapter = New WindowsApplication1.loDataSetTableAdapters.Validation_contratTableAdapter
        CType(Me.loDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Validation_contratBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "loDataSet_Validation_contrat"
        ReportDataSource1.Value = Me.Validation_contratBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(698, 370)
        Me.ReportViewer1.TabIndex = 0
        '
        'loDataSet
        '
        Me.loDataSet.DataSetName = "loDataSet"
        Me.loDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Validation_contratBindingSource
        '
        Me.Validation_contratBindingSource.DataMember = "Validation_contrat"
        Me.Validation_contratBindingSource.DataSource = Me.loDataSet
        '
        'Validation_contratTableAdapter
        '
        Me.Validation_contratTableAdapter.ClearBeforeFill = True
        '
        'imprimer_Validation_Contrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 370)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "imprimer_Validation_Contrat"
        Me.Text = "imprimer_Validation_Contrat"
        CType(Me.loDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Validation_contratBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Validation_contratBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents loDataSet As WindowsApplication1.loDataSet
    Friend WithEvents Validation_contratTableAdapter As WindowsApplication1.loDataSetTableAdapters.Validation_contratTableAdapter
End Class
