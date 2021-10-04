<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimerVal_Contrat
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
        Me.ODSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.loginformDataSet11 = New WindowsApplication1.loginformDataSet11
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Validation_contratBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Validation_contratTableAdapter = New WindowsApplication1.loginformDataSet11TableAdapters.Validation_contratTableAdapter
        Me.ODSTableAdapter = New WindowsApplication1.loginformDataSet11TableAdapters.ODSTableAdapter
        CType(Me.ODSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginformDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Validation_contratBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ODSBindingSource
        '
        Me.ODSBindingSource.DataMember = "ODS"
        Me.ODSBindingSource.DataSource = Me.loginformDataSet11
        '
        'loginformDataSet11
        '
        Me.loginformDataSet11.DataSetName = "loginformDataSet11"
        Me.loginformDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "loginformDataSet11_Validation_contrat"
        ReportDataSource1.Value = Me.Validation_contratBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(573, 341)
        Me.ReportViewer1.TabIndex = 0
        '
        'Validation_contratBindingSource
        '
        Me.Validation_contratBindingSource.DataMember = "Validation_contrat"
        Me.Validation_contratBindingSource.DataSource = Me.loginformDataSet11
        '
        'Validation_contratTableAdapter
        '
        Me.Validation_contratTableAdapter.ClearBeforeFill = True
        '
        'ODSTableAdapter
        '
        Me.ODSTableAdapter.ClearBeforeFill = True
        '
        'ImprimerVal_Contrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 341)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ImprimerVal_Contrat"
        Me.Text = "ImprimerVal_Contrat"
        CType(Me.ODSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginformDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Validation_contratBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Validation_contratBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents loginformDataSet11 As WindowsApplication1.loginformDataSet11
    Friend WithEvents Validation_contratTableAdapter As WindowsApplication1.loginformDataSet11TableAdapters.Validation_contratTableAdapter
    Friend WithEvents ODSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ODSTableAdapter As WindowsApplication1.loginformDataSet11TableAdapters.ODSTableAdapter
End Class
