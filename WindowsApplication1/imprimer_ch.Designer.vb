<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimer_ch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imprimer_ch))
        Me.Cahier_des_chargesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContratDataSet3 = New GestionContrats.ContratDataSet3
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Cahier_des_chargesTableAdapter = New GestionContrats.ContratDataSet3TableAdapters.Cahier_des_chargesTableAdapter
        CType(Me.Cahier_des_chargesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cahier_des_chargesBindingSource
        '
        Me.Cahier_des_chargesBindingSource.DataMember = "Cahier_des_charges"
        Me.Cahier_des_chargesBindingSource.DataSource = Me.ContratDataSet3
        '
        'ContratDataSet3
        '
        Me.ContratDataSet3.DataSetName = "ContratDataSet3"
        Me.ContratDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ContratDataSet3_Cahier_des_charges"
        ReportDataSource1.Value = Me.Cahier_des_chargesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionContrats.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(607, 410)
        Me.ReportViewer1.TabIndex = 0
        '
        'Cahier_des_chargesTableAdapter
        '
        Me.Cahier_des_chargesTableAdapter.ClearBeforeFill = True
        '
        'Imprimer_ch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 410)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Imprimer_ch"
        Me.Text = "Impression cahier Des Charges"
        CType(Me.Cahier_des_chargesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Cahier_des_chargesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContratDataSet3 As GestionContrats.ContratDataSet3
    Friend WithEvents Cahier_des_chargesTableAdapter As GestionContrats.ContratDataSet3TableAdapters.Cahier_des_chargesTableAdapter
End Class
