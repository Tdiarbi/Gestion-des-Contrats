<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Cahier_Des_Charges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Cahier_Des_Charges))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.txtch = New System.Windows.Forms.ToolStripTextBox
        Me.ContratDataSet3 = New GestionContrats.ContratDataSet3
        Me.CahierdeschargesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cahier_des_chargesTableAdapter = New GestionContrats.ContratDataSet3TableAdapters.Cahier_des_chargesTableAdapter
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObjetdelademandeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RéfferrenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StructureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModePassationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheminFichierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodeAffaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UtilisateurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateSaisieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CahierdeschargesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ObjetdelademandeDataGridViewTextBoxColumn, Me.RéfferrenceDataGridViewTextBoxColumn, Me.StructureDataGridViewTextBoxColumn, Me.ModePassationDataGridViewTextBoxColumn, Me.CheminFichierDataGridViewTextBoxColumn, Me.CodeAffaireDataGridViewTextBoxColumn, Me.UtilisateurDataGridViewTextBoxColumn, Me.DateSaisieDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CahierdeschargesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 537)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.txtch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(739, 25)
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
        'ContratDataSet3
        '
        Me.ContratDataSet3.DataSetName = "ContratDataSet3"
        Me.ContratDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CahierdeschargesBindingSource
        '
        Me.CahierdeschargesBindingSource.DataMember = "Cahier_des_charges"
        Me.CahierdeschargesBindingSource.DataSource = Me.ContratDataSet3
        '
        'Cahier_des_chargesTableAdapter
        '
        Me.Cahier_des_chargesTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObjetdelademandeDataGridViewTextBoxColumn
        '
        Me.ObjetdelademandeDataGridViewTextBoxColumn.DataPropertyName = "Objet_de_la_demande"
        Me.ObjetdelademandeDataGridViewTextBoxColumn.HeaderText = "Objet_de_la_demande"
        Me.ObjetdelademandeDataGridViewTextBoxColumn.Name = "ObjetdelademandeDataGridViewTextBoxColumn"
        '
        'RéfferrenceDataGridViewTextBoxColumn
        '
        Me.RéfferrenceDataGridViewTextBoxColumn.DataPropertyName = "Réfferrence"
        Me.RéfferrenceDataGridViewTextBoxColumn.HeaderText = "Réfferrence"
        Me.RéfferrenceDataGridViewTextBoxColumn.Name = "RéfferrenceDataGridViewTextBoxColumn"
        '
        'StructureDataGridViewTextBoxColumn
        '
        Me.StructureDataGridViewTextBoxColumn.DataPropertyName = "Structure"
        Me.StructureDataGridViewTextBoxColumn.HeaderText = "Structure"
        Me.StructureDataGridViewTextBoxColumn.Name = "StructureDataGridViewTextBoxColumn"
        '
        'ModePassationDataGridViewTextBoxColumn
        '
        Me.ModePassationDataGridViewTextBoxColumn.DataPropertyName = "Mode_Passation"
        Me.ModePassationDataGridViewTextBoxColumn.HeaderText = "Mode_Passation"
        Me.ModePassationDataGridViewTextBoxColumn.Name = "ModePassationDataGridViewTextBoxColumn"
        '
        'CheminFichierDataGridViewTextBoxColumn
        '
        Me.CheminFichierDataGridViewTextBoxColumn.DataPropertyName = "Chemin_Fichier"
        Me.CheminFichierDataGridViewTextBoxColumn.HeaderText = "Chemin_Fichier"
        Me.CheminFichierDataGridViewTextBoxColumn.Name = "CheminFichierDataGridViewTextBoxColumn"
        '
        'CodeAffaireDataGridViewTextBoxColumn
        '
        Me.CodeAffaireDataGridViewTextBoxColumn.DataPropertyName = "Code_Affaire"
        Me.CodeAffaireDataGridViewTextBoxColumn.HeaderText = "Code_Affaire"
        Me.CodeAffaireDataGridViewTextBoxColumn.Name = "CodeAffaireDataGridViewTextBoxColumn"
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
        'Liste_Cahier_Des_Charges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 561)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Liste_Cahier_Des_Charges"
        Me.Text = "Liste Cahier Des Charges"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CahierdeschargesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ContratDataSet3 As GestionContrats.ContratDataSet3
    Friend WithEvents CahierdeschargesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cahier_des_chargesTableAdapter As GestionContrats.ContratDataSet3TableAdapters.Cahier_des_chargesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObjetdelademandeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RéfferrenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StructureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModePassationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheminFichierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeAffaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilisateurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSaisieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
