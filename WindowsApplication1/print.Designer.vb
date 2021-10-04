<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print
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
        Me.loginformDataSet11 = New WindowsApplication1.loginformDataSet11
        Me.Table_ContratBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_ContratTableAdapter = New WindowsApplication1.loginformDataSet11TableAdapters.Table_ContratTableAdapter
        CType(Me.loginformDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_ContratBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "loginformDataSet11_Table_Contrat"
        ReportDataSource1.Value = Me.Table_ContratBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(610, 334)
        Me.ReportViewer1.TabIndex = 0
        '
        'loginformDataSet11
        '
        Me.loginformDataSet11.DataSetName = "loginformDataSet11"
        Me.loginformDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table_ContratBindingSource
        '
        Me.Table_ContratBindingSource.DataMember = "Table_Contrat"
        Me.Table_ContratBindingSource.DataSource = Me.loginformDataSet11
        '
        'Table_ContratTableAdapter
        '
        Me.Table_ContratTableAdapter.ClearBeforeFill = True
        '
        'print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 334)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "print"
        Me.Text = "print"
        CType(Me.loginformDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_ContratBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Table_ContratBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents loginformDataSet11 As WindowsApplication1.loginformDataSet11
    Friend WithEvents Table_ContratTableAdapter As WindowsApplication1.loginformDataSet11TableAdapters.Table_ContratTableAdapter
End Class
