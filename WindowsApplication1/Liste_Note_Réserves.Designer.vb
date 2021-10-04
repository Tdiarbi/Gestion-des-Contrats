<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Note_Réserves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Liste_Note_Réserves))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.txtch = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ContratDataSet3 = New GestionContrats.ContratDataSet3
        Me.NotedesReservesClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Note_des_Reserves_ClientTableAdapter = New GestionContrats.ContratDataSet3TableAdapters.Note_des_Reserves_ClientTableAdapter
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModepassationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProjetcontratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodeAffaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UtilisateurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateSaisieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotedesReservesClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtch, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(645, 25)
        Me.ToolStrip1.TabIndex = 3
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ClientDataGridViewTextBoxColumn, Me.ModepassationDataGridViewTextBoxColumn, Me.ProjetcontratDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.CodeAffaireDataGridViewTextBoxColumn, Me.UtilisateurDataGridViewTextBoxColumn, Me.DateSaisieDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NotedesReservesClientBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 362)
        Me.DataGridView1.TabIndex = 4
        '
        'ContratDataSet3
        '
        Me.ContratDataSet3.DataSetName = "ContratDataSet3"
        Me.ContratDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotedesReservesClientBindingSource
        '
        Me.NotedesReservesClientBindingSource.DataMember = "Note_des_Reserves_Client"
        Me.NotedesReservesClientBindingSource.DataSource = Me.ContratDataSet3
        '
        'Note_des_Reserves_ClientTableAdapter
        '
        Me.Note_des_Reserves_ClientTableAdapter.ClearBeforeFill = True
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
        Me.ClientDataGridViewTextBoxColumn.DataPropertyName = "client"
        Me.ClientDataGridViewTextBoxColumn.HeaderText = "client"
        Me.ClientDataGridViewTextBoxColumn.Name = "ClientDataGridViewTextBoxColumn"
        '
        'ModepassationDataGridViewTextBoxColumn
        '
        Me.ModepassationDataGridViewTextBoxColumn.DataPropertyName = "Mode_passation"
        Me.ModepassationDataGridViewTextBoxColumn.HeaderText = "Mode_passation"
        Me.ModepassationDataGridViewTextBoxColumn.Name = "ModepassationDataGridViewTextBoxColumn"
        '
        'ProjetcontratDataGridViewTextBoxColumn
        '
        Me.ProjetcontratDataGridViewTextBoxColumn.DataPropertyName = "projet_contrat"
        Me.ProjetcontratDataGridViewTextBoxColumn.HeaderText = "projet_contrat"
        Me.ProjetcontratDataGridViewTextBoxColumn.Name = "ProjetcontratDataGridViewTextBoxColumn"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
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
        'Liste_Note_Réserves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 387)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Liste_Note_Réserves"
        Me.Text = "Liste Note Des Réserves"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotedesReservesClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ContratDataSet3 As GestionContrats.ContratDataSet3
    Friend WithEvents NotedesReservesClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Note_des_Reserves_ClientTableAdapter As GestionContrats.ContratDataSet3TableAdapters.Note_des_Reserves_ClientTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModepassationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjetcontratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeAffaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilisateurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSaisieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
