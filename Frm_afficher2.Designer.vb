<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_afficher2
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
        Dgv_livre = New DataGridView()
        Isbn = New DataGridViewTextBoxColumn()
        Titre = New DataGridViewTextBoxColumn()
        Auteur = New DataGridViewTextBoxColumn()
        CType(Dgv_livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Dgv_livre
        ' 
        Dgv_livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_livre.Columns.AddRange(New DataGridViewColumn() {Isbn, Titre, Auteur})
        Dgv_livre.Dock = DockStyle.Fill
        Dgv_livre.Location = New Point(0, 0)
        Dgv_livre.Name = "Dgv_livre"
        Dgv_livre.Size = New Size(800, 450)
        Dgv_livre.TabIndex = 0
        ' 
        ' Isbn
        ' 
        Isbn.HeaderText = "Isbn"
        Isbn.Name = "Isbn"
        ' 
        ' Titre
        ' 
        Titre.HeaderText = "Titre"
        Titre.Name = "Titre"
        ' 
        ' Auteur
        ' 
        Auteur.HeaderText = "Auteur"
        Auteur.Name = "Auteur"
        ' 
        ' Frm_afficher2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Dgv_livre)
        Name = "Frm_afficher2"
        Text = "Frm_afficher2"
        CType(Dgv_livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Dgv_livre As DataGridView
    Friend WithEvents Isbn As DataGridViewTextBoxColumn
    Friend WithEvents Titre As DataGridViewTextBoxColumn
    Friend WithEvents Auteur As DataGridViewTextBoxColumn
End Class
