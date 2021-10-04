<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_ODS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_ODS))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.txtch = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ContratDataSet3 = New GestionContrats.ContratDataSet3
        Me.ODSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ODSTableAdapter = New GestionContrats.ContratDataSet3TableAdapters.ODSTableAdapter
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContratdeRéfferrenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObjetdelaDemandeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StructureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateSignatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RéfferrenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheminFichierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommandeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DelaiContractuelleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeODSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetenteurODSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodeAffaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateNotificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ODSInitialeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UtilisateurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateSaisieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ODSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ClientDataGridViewTextBoxColumn, Me.ContratdeRéfferrenceDataGridViewTextBoxColumn, Me.ObjetdelaDemandeDataGridViewTextBoxColumn, Me.MontantDataGridViewTextBoxColumn, Me.StructureDataGridViewTextBoxColumn, Me.DateSignatureDataGridViewTextBoxColumn, Me.RéfferrenceDataGridViewTextBoxColumn, Me.CheminFichierDataGridViewTextBoxColumn, Me.CommandeDataGridViewTextBoxColumn, Me.DelaiContractuelleDataGridViewTextBoxColumn, Me.TypeODSDataGridViewTextBoxColumn, Me.DetenteurODSDataGridViewTextBoxColumn, Me.CodeAffaireDataGridViewTextBoxColumn, Me.DateNotificationDataGridViewTextBoxColumn, Me.ODSInitialeDataGridViewTextBoxColumn, Me.UtilisateurDataGridViewTextBoxColumn, Me.DateSaisieDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ODSBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 28)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1013, 449)
        Me.DataGridView1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtch, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1012, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtch
        '
        Me.txtch.Name = "txtch"
        Me.txtch.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ContratDataSet3
        '
        Me.ContratDataSet3.DataSetName = "ContratDataSet3"
        Me.ContratDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ODSBindingSource
        '
        Me.ODSBindingSource.DataMember = "ODS"
        Me.ODSBindingSource.DataSource = Me.ContratDataSet3
        '
        'ODSTableAdapter
        '
        Me.ODSTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientDataGridViewTextBoxColumn
        '
        Me.ClientDataGridViewTextBoxColumn.DataPropertyName = "Client"
        Me.ClientDataGridViewTextBoxColumn.HeaderText = "Client"
        Me.ClientDataGridViewTextBoxColumn.Name = "ClientDataGridViewTextBoxColumn"
        '
        'ContratdeRéfferrenceDataGridViewTextBoxColumn
        '
        Me.ContratdeRéfferrenceDataGridViewTextBoxColumn.DataPropertyName = "Contrat_de_Réfferrence"
        Me.ContratdeRéfferrenceDataGridViewTextBoxColumn.HeaderText = "Contrat_de_Réfferrence"
        Me.ContratdeRéfferrenceDataGridViewTextBoxColumn.Name = "ContratdeRéfferrenceDataGridViewTextBoxColumn"
        '
        'ObjetdelaDemandeDataGridViewTextBoxColumn
        '
        Me.ObjetdelaDemandeDataGridViewTextBoxColumn.DataPropertyName = "Objet_de_la_Demande"
        Me.ObjetdelaDemandeDataGridViewTextBoxColumn.HeaderText = "Objet_de_la_Demande"
        Me.ObjetdelaDemandeDataGridViewTextBoxColumn.Name = "ObjetdelaDemandeDataGridViewTextBoxColumn"
        '
        'MontantDataGridViewTextBoxColumn
        '
        Me.MontantDataGridViewTextBoxColumn.DataPropertyName = "Montant"
        Me.MontantDataGridViewTextBoxColumn.HeaderText = "Montant"
        Me.MontantDataGridViewTextBoxColumn.Name = "MontantDataGridViewTextBoxColumn"
        '
        'StructureDataGridViewTextBoxColumn
        '
        Me.StructureDataGridViewTextBoxColumn.DataPropertyName = "Structure"
        Me.StructureDataGridViewTextBoxColumn.HeaderText = "Structure"
        Me.StructureDataGridViewTextBoxColumn.Name = "StructureDataGridViewTextBoxColumn"
        '
        'DateSignatureDataGridViewTextBoxColumn
        '
        Me.DateSignatureDataGridViewTextBoxColumn.DataPropertyName = "Date_Signature"
        Me.DateSignatureDataGridViewTextBoxColumn.HeaderText = "Date_Signature"
        Me.DateSignatureDataGridViewTextBoxColumn.Name = "DateSignatureDataGridViewTextBoxColumn"
        '
        'RéfferrenceDataGridViewTextBoxColumn
        '
        Me.RéfferrenceDataGridViewTextBoxColumn.DataPropertyName = "Réfferrence"
        Me.RéfferrenceDataGridViewTextBoxColumn.HeaderText = "Réfferrence"
        Me.RéfferrenceDataGridViewTextBoxColumn.Name = "RéfferrenceDataGridViewTextBoxColumn"
        '
        'CheminFichierDataGridViewTextBoxColumn
        '
        Me.CheminFichierDataGridViewTextBoxColumn.DataPropertyName = "Chemin_Fichier"
        Me.CheminFichierDataGridViewTextBoxColumn.HeaderText = "Chemin_Fichier"
        Me.CheminFichierDataGridViewTextBoxColumn.Name = "CheminFichierDataGridViewTextBoxColumn"
        '
        'CommandeDataGridViewTextBoxColumn
        '
        Me.CommandeDataGridViewTextBoxColumn.DataPropertyName = "Commande"
        Me.CommandeDataGridViewTextBoxColumn.HeaderText = "Commande"
        Me.CommandeDataGridViewTextBoxColumn.Name = "CommandeDataGridViewTextBoxColumn"
        '
        'DelaiContractuelleDataGridViewTextBoxColumn
        '
        Me.DelaiContractuelleDataGridViewTextBoxColumn.DataPropertyName = "Delai_Contractuelle"
        Me.DelaiContractuelleDataGridViewTextBoxColumn.HeaderText = "Delai_Contractuelle"
        Me.DelaiContractuelleDataGridViewTextBoxColumn.Name = "DelaiContractuelleDataGridViewTextBoxColumn"
        '
        'TypeODSDataGridViewTextBoxColumn
        '
        Me.TypeODSDataGridViewTextBoxColumn.DataPropertyName = "Type_ODS"
        Me.TypeODSDataGridViewTextBoxColumn.HeaderText = "Type_ODS"
        Me.TypeODSDataGridViewTextBoxColumn.Name = "TypeODSDataGridViewTextBoxColumn"
        '
        'DetenteurODSDataGridViewTextBoxColumn
        '
        Me.DetenteurODSDataGridViewTextBoxColumn.DataPropertyName = "Detenteur_ODS"
        Me.DetenteurODSDataGridViewTextBoxColumn.HeaderText = "Detenteur_ODS"
        Me.DetenteurODSDataGridViewTextBoxColumn.Name = "DetenteurODSDataGridViewTextBoxColumn"
        '
        'CodeAffaireDataGridViewTextBoxColumn
        '
        Me.CodeAffaireDataGridViewTextBoxColumn.DataPropertyName = "Code_Affaire"
        Me.CodeAffaireDataGridViewTextBoxColumn.HeaderText = "Code_Affaire"
        Me.CodeAffaireDataGridViewTextBoxColumn.Name = "CodeAffaireDataGridViewTextBoxColumn"
        '
        'DateNotificationDataGridViewTextBoxColumn
        '
        Me.DateNotificationDataGridViewTextBoxColumn.DataPropertyName = "Date_Notification"
        Me.DateNotificationDataGridViewTextBoxColumn.HeaderText = "Date_Notification"
        Me.DateNotificationDataGridViewTextBoxColumn.Name = "DateNotificationDataGridViewTextBoxColumn"
        '
        'ODSInitialeDataGridViewTextBoxColumn
        '
        Me.ODSInitialeDataGridViewTextBoxColumn.DataPropertyName = "ODS_Initiale"
        Me.ODSInitialeDataGridViewTextBoxColumn.HeaderText = "ODS_Initiale"
        Me.ODSInitialeDataGridViewTextBoxColumn.Name = "ODSInitialeDataGridViewTextBoxColumn"
        '
        'UtilisateurDataGridViewTextBoxColumn
        '
        Me.UtilisateurDataGridViewTextBoxColumn.DataPropertyName = "Utilisateur"
        Me.UtilisateurDataGridViewTextBoxColumn.HeaderText = "Utilisateur"
        Me.UtilisateurDataGridViewTextBoxColumn.Name = "UtilisateurDataGridViewTextBoxColumn"
        '
        'DateSaisieDataGridViewTextBoxColumn
        '
        Me.DateSaisieDataGridViewTextBoxColumn.DataPropertyName = "Date_Saisie"
        Me.DateSaisieDataGridViewTextBoxColumn.HeaderText = "Date_Saisie"
        Me.DateSaisieDataGridViewTextBoxColumn.Name = "DateSaisieDataGridViewTextBoxColumn"
        '
        'Liste_ODS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1012, 477)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Liste_ODS"
        Me.Text = "Liste ODS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ODSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContratDataSet3 As GestionContrats.ContratDataSet3
    Friend WithEvents ODSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ODSTableAdapter As GestionContrats.ContratDataSet3TableAdapters.ODSTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContratdeRéfferrenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObjetdelaDemandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StructureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSignatureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RéfferrenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheminFichierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DelaiContractuelleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeODSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetenteurODSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeAffaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateNotificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ODSInitialeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilisateurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSaisieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
