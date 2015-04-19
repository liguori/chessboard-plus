<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNuova = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNuova
        '
        Me.btnNuova.Location = New System.Drawing.Point(99, 79)
        Me.btnNuova.Name = "btnNuova"
        Me.btnNuova.Size = New System.Drawing.Size(179, 77)
        Me.btnNuova.TabIndex = 0
        Me.btnNuova.Text = "Start Game"
        Me.btnNuova.UseVisualStyleBackColor = True
        '
        'frmInizio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 266)
        Me.Controls.Add(Me.btnNuova)
        Me.MaximizeBox = False
        Me.Name = "frmInizio"
        Me.Text = "Chessboard Plus - Schermata Iniziale"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNuova As System.Windows.Forms.Button

End Class
