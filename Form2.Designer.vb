<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Lst_isbn = New ListBox()
        Lst_titre = New ListBox()
        Lst_auteur = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(143, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 32)
        Label1.TabIndex = 2
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.Location = New Point(338, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 32)
        Label2.TabIndex = 6
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(529, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 32)
        Label3.TabIndex = 7
        Label3.Text = "Auteur"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(225, 374)
        Button1.Name = "Button1"
        Button1.Size = New Size(312, 55)
        Button1.TabIndex = 11
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Lst_isbn
        ' 
        Lst_isbn.FormattingEnabled = True
        Lst_isbn.ItemHeight = 15
        Lst_isbn.Location = New Point(124, 114)
        Lst_isbn.Name = "Lst_isbn"
        Lst_isbn.Size = New Size(120, 229)
        Lst_isbn.TabIndex = 12
        ' 
        ' Lst_titre
        ' 
        Lst_titre.FormattingEnabled = True
        Lst_titre.ItemHeight = 15
        Lst_titre.Location = New Point(321, 114)
        Lst_titre.Name = "Lst_titre"
        Lst_titre.Size = New Size(120, 229)
        Lst_titre.TabIndex = 13
        ' 
        ' Lst_auteur
        ' 
        Lst_auteur.FormattingEnabled = True
        Lst_auteur.ItemHeight = 15
        Lst_auteur.Location = New Point(518, 114)
        Lst_auteur.Name = "Lst_auteur"
        Lst_auteur.Size = New Size(120, 229)
        Lst_auteur.TabIndex = 14
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Lst_auteur)
        Controls.Add(Lst_titre)
        Controls.Add(Lst_isbn)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Lst_isbn As ListBox
    Friend WithEvents Lst_titre As ListBox
    Friend WithEvents Lst_auteur As ListBox
End Class
