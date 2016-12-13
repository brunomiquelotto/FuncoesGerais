<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DateTextBox1 = New FuncoesGerais.Componentes.DateTextBox(Me.components)
        Me.DateTextBox2 = New FuncoesGerais.Componentes.DateTextBox(Me.components)
        Me.SuspendLayout()
        '
        'DateTextBox1
        '
        Me.DateTextBox1.CustomMask = "99/99/9999"
        Me.DateTextBox1.Location = New System.Drawing.Point(39, 75)
        Me.DateTextBox1.Mask = "99/99/9999"
        Me.DateTextBox1.Name = "DateTextBox1"
        Me.DateTextBox1.Size = New System.Drawing.Size(138, 20)
        Me.DateTextBox1.TabIndex = 0
        Me.DateTextBox1.TipoData = FuncoesGerais.Componentes.DateType.ShortWithTime
        '
        'DateTextBox2
        '
        Me.DateTextBox2.CustomMask = "99/99/9999"
        Me.DateTextBox2.Location = New System.Drawing.Point(39, 101)
        Me.DateTextBox2.Mask = "99/99/9999"
        Me.DateTextBox2.Name = "DateTextBox2"
        Me.DateTextBox2.Size = New System.Drawing.Size(138, 20)
        Me.DateTextBox2.TabIndex = 0
        Me.DateTextBox2.TipoData = FuncoesGerais.Componentes.DateType.ShortWithTime
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.DateTextBox2)
        Me.Controls.Add(Me.DateTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTextBox1 As FuncoesGerais.Componentes.DateTextBox
    Friend WithEvents DateTextBox2 As FuncoesGerais.Componentes.DateTextBox

End Class
