<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Btn_ajouter = New Button()
        Label1 = New Label()
        txt_isbn = New TextBox()
        txt_auteur = New TextBox()
        txt_titre = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' Btn_ajouter
        ' 
        Btn_ajouter.Location = New Point(222, 332)
        Btn_ajouter.Name = "Btn_ajouter"
        Btn_ajouter.Size = New Size(86, 77)
        Btn_ajouter.TabIndex = 0
        Btn_ajouter.Text = "Ajouter"
        Btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(106, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 32)
        Label1.TabIndex = 1
        Label1.Text = "ISBN"
        ' 
        ' txt_isbn
        ' 
        txt_isbn.Font = New Font("Segoe UI", 14F)
        txt_isbn.Location = New Point(356, 55)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(100, 32)
        txt_isbn.TabIndex = 2
        ' 
        ' txt_auteur
        ' 
        txt_auteur.Font = New Font("Segoe UI", 14F)
        txt_auteur.Location = New Point(356, 252)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(100, 32)
        txt_auteur.TabIndex = 3
        ' 
        ' txt_titre
        ' 
        txt_titre.Font = New Font("Segoe UI", 14F)
        txt_titre.Location = New Point(356, 148)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(100, 32)
        txt_titre.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.Location = New Point(109, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 32)
        Label2.TabIndex = 5
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(106, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 32)
        Label3.TabIndex = 6
        Label3.Text = "Auteur"
        ' 
        ' Btn_afficher
        ' 
        Btn_afficher.Location = New Point(424, 332)
        Btn_afficher.Name = "Btn_afficher"
        Btn_afficher.Size = New Size(91, 77)
        Btn_afficher.TabIndex = 7
        Btn_afficher.Text = "Afficher"
        Btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_afficher)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_titre)
        Controls.Add(txt_auteur)
        Controls.Add(txt_isbn)
        Controls.Add(Label1)
        Controls.Add(Btn_ajouter)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_ajouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_afficher As Button

End Class
