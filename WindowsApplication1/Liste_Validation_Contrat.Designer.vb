<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Validation_Contrat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Validation_Contrat))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.txtch = New System.Windows.Forms.ToolStripTextBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContratDataSet3 = New GestionContrats.ContratDataSet3
        Me.ContratBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContratTableAdapter = New GestionContrats.ContratDataSet3TableAdapters.ContratTableAdapter
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateSignatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RéfferrenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObjetdelademandeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModedepassationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DuréecontratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypecontratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheminFichierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommandeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DelaiContractuelleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NatureContratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetenteurContratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateValidationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateRetourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodeAffaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateNotificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateFinContratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FinReceptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UtilisateurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateSaisieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ClientDataGridViewTextBoxColumn, Me.MontantDataGridViewTextBoxColumn, Me.DateSignatureDataGridViewTextBoxColumn, Me.RéfferrenceDataGridViewTextBoxColumn, Me.ObjetdelademandeDataGridViewTextBoxColumn, Me.ModedepassationDataGridViewTextBoxColumn, Me.DuréecontratDataGridViewTextBoxColumn, Me.TypecontratDataGridViewTextBoxColumn, Me.CheminFichierDataGridViewTextBoxColumn, Me.CommandeDataGridViewTextBoxColumn, Me.DelaiContractuelleDataGridViewTextBoxColumn, Me.NatureContratDataGridViewTextBoxColumn, Me.DetenteurContratDataGridViewTextBoxColumn, Me.DateValidationDataGridViewTextBoxColumn, Me.DateRetourDataGridViewTextBoxColumn, Me.CodeAffaireDataGridViewTextBoxColumn, Me.DateNotificationDataGridViewTextBoxColumn, Me.DateFinContratDataGridViewTextBoxColumn, Me.FinReceptionDataGridViewTextBoxColumn, Me.UtilisateurDataGridViewTextBoxColumn, Me.DateSaisieDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContratBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1004, 497)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.txtch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1003, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'txtch
        '
        Me.txtch.Name = "txtch"
        Me.txtch.Size = New System.Drawing.Size(100, 25)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Fichier_PDF"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fichier_PDF"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fichier_PDF"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fichier_PDF"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fichier_PDF"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fichier_PDF"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fichier_PDF"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fichier_PDF"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ContratDataSet3
        '
        Me.ContratDataSet3.DataSetName = "ContratDataSet3"
        Me.ContratDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContratBindingSource
        '
        Me.ContratBindingSource.DataMember = "Contrat"
        Me.ContratBindingSource.DataSource = Me.ContratDataSet3
        '
        'ContratTableAdapter
        '
        Me.ContratTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClientDataGridViewTextBoxColumn
        '
        Me.ClientDataGridViewTextBoxColumn.DataPropertyName = "Client"
        Me.ClientDataGridViewTextBoxColumn.HeaderText = "Client"
        Me.ClientDataGridViewTextBoxColumn.Name = "ClientDataGridViewTextBoxColumn"
        '
        'MontantDataGridViewTextBoxColumn
        '
        Me.MontantDataGridViewTextBoxColumn.DataPropertyName = "Montant"
        Me.MontantDataGridViewTextBoxColumn.HeaderText = "Montant"
        Me.MontantDataGridViewTextBoxColumn.Name = "MontantDataGridViewTextBoxColumn"
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
        'ObjetdelademandeDataGridViewTextBoxColumn
        '
        Me.ObjetdelademandeDataGridViewTextBoxColumn.DataPropertyName = "Objet_de_la_demande"
        Me.ObjetdelademandeDataGridViewTextBoxColumn.HeaderText = "Objet_de_la_demande"
        Me.ObjetdelademandeDataGridViewTextBoxColumn.Name = "ObjetdelademandeDataGridViewTextBoxColumn"
        '
        'ModedepassationDataGridViewTextBoxColumn
        '
        Me.ModedepassationDataGridViewTextBoxColumn.DataPropertyName = "Mode_de_passation"
        Me.ModedepassationDataGridViewTextBoxColumn.HeaderText = "Mode_de_passation"
        Me.ModedepassationDataGridViewTextBoxColumn.Name = "ModedepassationDataGridViewTextBoxColumn"
        '
        'DuréecontratDataGridViewTextBoxColumn
        '
        Me.DuréecontratDataGridViewTextBoxColumn.DataPropertyName = "Durée_contrat"
        Me.DuréecontratDataGridViewTextBoxColumn.HeaderText = "Durée_contrat"
        Me.DuréecontratDataGridViewTextBoxColumn.Name = "DuréecontratDataGridViewTextBoxColumn"
        '
        'TypecontratDataGridViewTextBoxColumn
        '
        Me.TypecontratDataGridViewTextBoxColumn.DataPropertyName = "Type_contrat"
        Me.TypecontratDataGridViewTextBoxColumn.HeaderText = "Type_contrat"
        Me.TypecontratDataGridViewTextBoxColumn.Name = "TypecontratDataGridViewTextBoxColumn"
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
        'NatureContratDataGridViewTextBoxColumn
        '
        Me.NatureContratDataGridViewTextBoxColumn.DataPropertyName = "Nature_Contrat"
        Me.NatureContratDataGridViewTextBoxColumn.HeaderText = "Nature_Contrat"
        Me.NatureContratDataGridViewTextBoxColumn.Name = "NatureContratDataGridViewTextBoxColumn"
        '
        'DetenteurContratDataGridViewTextBoxColumn
        '
        Me.DetenteurContratDataGridViewTextBoxColumn.DataPropertyName = "Detenteur_Contrat"
        Me.DetenteurContratDataGridViewTextBoxColumn.HeaderText = "Detenteur_Contrat"
        Me.DetenteurContratDataGridViewTextBoxColumn.Name = "DetenteurContratDataGridViewTextBoxColumn"
        '
        'DateValidationDataGridViewTextBoxColumn
        '
        Me.DateValidationDataGridViewTextBoxColumn.DataPropertyName = "Date_Validation"
        Me.DateValidationDataGridViewTextBoxColumn.HeaderText = "Date_Validation"
        Me.DateValidationDataGridViewTextBoxColumn.Name = "DateValidationDataGridViewTextBoxColumn"
        '
        'DateRetourDataGridViewTextBoxColumn
        '
        Me.DateRetourDataGridViewTextBoxColumn.DataPropertyName = "Date_Retour"
        Me.DateRetourDataGridViewTextBoxColumn.HeaderText = "Date_Retour"
        Me.DateRetourDataGridViewTextBoxColumn.Name = "DateRetourDataGridViewTextBoxColumn"
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
        'DateFinContratDataGridViewTextBoxColumn
        '
        Me.DateFinContratDataGridViewTextBoxColumn.DataPropertyName = "Date_Fin_Contrat"
        Me.DateFinContratDataGridViewTextBoxColumn.HeaderText = "Date_Fin_Contrat"
        Me.DateFinContratDataGridViewTextBoxColumn.Name = "DateFinContratDataGridViewTextBoxColumn"
        '
        'FinReceptionDataGridViewTextBoxColumn
        '
        Me.FinReceptionDataGridViewTextBoxColumn.DataPropertyName = "Fin_Reception"
        Me.FinReceptionDataGridViewTextBoxColumn.HeaderText = "Fin_Reception"
        Me.FinReceptionDataGridViewTextBoxColumn.Name = "FinReceptionDataGridViewTextBoxColumn"
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
        'Liste_Validation_Contrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 523)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Liste_Validation_Contrat"
        Me.Text = "Liste Validation Contrat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContratDataSet3 As GestionContrats.ContratDataSet3
    Friend WithEvents ContratBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContratTableAdapter As GestionContrats.ContratDataSet3TableAdapters.ContratTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSignatureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RéfferrenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObjetdelademandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModedepassationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DuréecontratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypecontratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheminFichierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DelaiContractuelleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NatureContratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetenteurContratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateValidationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateRetourDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeAffaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateNotificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFinContratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinReceptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilisateurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSaisieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
