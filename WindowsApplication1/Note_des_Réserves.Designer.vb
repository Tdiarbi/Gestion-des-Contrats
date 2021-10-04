<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Note_des_Réserves
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Note_des_Réserves))
        Me.txtClient = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.txtMP = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtPC = New System.Windows.Forms.TextBox
        Me.btnEnregistrer = New System.Windows.Forms.Button
        Me.btnModifier = New System.Windows.Forms.Button
        Me.btnSupprimer = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModepassationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProjetcontratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotedesRéservesClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginformDataSet11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginformDataSet11 = New WindowsApplication1.loginformDataSet11
        Me.Note_des_Réserves_ClientTableAdapter = New WindowsApplication1.loginformDataSet11TableAdapters.Note_des_Réserves_ClientTableAdapter
        Me.NotedesRéservesClientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotedesRéservesClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginformDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotedesRéservesClientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(117, 57)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(100, 20)
        Me.txtClient.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mode de Passation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Projet de Contrat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(385, 153)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(100, 20)
        Me.txtNote.TabIndex = 5
        '
        'txtMP
        '
        Me.txtMP.Location = New System.Drawing.Point(116, 149)
        Me.txtMP.Name = "txtMP"
        Me.txtMP.Size = New System.Drawing.Size(100, 20)
        Me.txtMP.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(507, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Scanner"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPC
        '
        Me.txtPC.Location = New System.Drawing.Point(385, 57)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(100, 20)
        Me.txtPC.TabIndex = 9
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Location = New System.Drawing.Point(411, 208)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(86, 28)
        Me.btnEnregistrer.TabIndex = 18
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(238, 212)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(93, 28)
        Me.btnModifier.TabIndex = 23
        Me.btnModifier.Text = "modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(81, 208)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(87, 28)
        Me.btnSupprimer.TabIndex = 55
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(238, 186)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "id"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ClientDataGridViewTextBoxColumn, Me.ModepassationDataGridViewTextBoxColumn, Me.ProjetcontratDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NotedesRéservesClientBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 275)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 109)
        Me.DataGridView1.TabIndex = 58
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
        'NotedesRéservesClientBindingSource
        '
        Me.NotedesRéservesClientBindingSource.DataMember = "Note_des_Réserves_Client"
        Me.NotedesRéservesClientBindingSource.DataSource = Me.LoginformDataSet11BindingSource
        '
        'LoginformDataSet11BindingSource
        '
        Me.LoginformDataSet11BindingSource.DataSource = Me.LoginformDataSet11
        Me.LoginformDataSet11BindingSource.Position = 0
        '
        'LoginformDataSet11
        '
        Me.LoginformDataSet11.DataSetName = "loginformDataSet11"
        Me.LoginformDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Note_des_Réserves_ClientTableAdapter
        '
        Me.Note_des_Réserves_ClientTableAdapter.ClearBeforeFill = True
        '
        'NotedesRéservesClientBindingSource1
        '
        Me.NotedesRéservesClientBindingSource1.DataMember = "Note_des_Réserves_Client"
        Me.NotedesRéservesClientBindingSource1.DataSource = Me.LoginformDataSet11BindingSource
        '
        'Note_des_Réserves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 383)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.txtPC)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMP)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtClient)
        Me.Name = "Note_des_Réserves"
        Me.Text = "Note_des_Réserves_Client"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotedesRéservesClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginformDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotedesRéservesClientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtClient As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents txtMP As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPC As System.Windows.Forms.TextBox
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LoginformDataSet11BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginformDataSet11 As WindowsApplication1.loginformDataSet11
    Friend WithEvents NotedesRéservesClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Note_des_Réserves_ClientTableAdapter As WindowsApplication1.loginformDataSet11TableAdapters.Note_des_Réserves_ClientTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModepassationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjetcontratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotedesRéservesClientBindingSource1 As System.Windows.Forms.BindingSource
End Class
