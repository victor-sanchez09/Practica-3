<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.materia1 = New System.Windows.Forms.TextBox()
        Me.materia2 = New System.Windows.Forms.TextBox()
        Me.materia3 = New System.Windows.Forms.TextBox()
        Me.materia4 = New System.Windows.Forms.TextBox()
        Me.materia5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.Label()
        Me.calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Socie. y Cultura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matematicas IV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Med. y Tecno."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Or. Vocacional"
        '
        'materia1
        '
        Me.materia1.Location = New System.Drawing.Point(271, 71)
        Me.materia1.Name = "materia1"
        Me.materia1.Size = New System.Drawing.Size(82, 20)
        Me.materia1.TabIndex = 5
        '
        'materia2
        '
        Me.materia2.Location = New System.Drawing.Point(271, 97)
        Me.materia2.Name = "materia2"
        Me.materia2.Size = New System.Drawing.Size(82, 20)
        Me.materia2.TabIndex = 6
        '
        'materia3
        '
        Me.materia3.Location = New System.Drawing.Point(271, 122)
        Me.materia3.Name = "materia3"
        Me.materia3.Size = New System.Drawing.Size(82, 20)
        Me.materia3.TabIndex = 7
        '
        'materia4
        '
        Me.materia4.Location = New System.Drawing.Point(271, 153)
        Me.materia4.Name = "materia4"
        Me.materia4.Size = New System.Drawing.Size(82, 20)
        Me.materia4.TabIndex = 8
        '
        'materia5
        '
        Me.materia5.Location = New System.Drawing.Point(271, 182)
        Me.materia5.Name = "materia5"
        Me.materia5.Size = New System.Drawing.Size(82, 20)
        Me.materia5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(461, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Resultado"
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(565, 80)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(25, 25)
        Me.resultado.TabIndex = 11
        Me.resultado.Text = "0"
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(464, 159)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(85, 35)
        Me.calcular.TabIndex = 12
        Me.calcular.Text = "Calcular promedio"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.materia5)
        Me.Controls.Add(Me.materia4)
        Me.Controls.Add(Me.materia3)
        Me.Controls.Add(Me.materia2)
        Me.Controls.Add(Me.materia1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents materia1 As TextBox
    Friend WithEvents materia2 As TextBox
    Friend WithEvents materia3 As TextBox
    Friend WithEvents materia4 As TextBox
    Friend WithEvents materia5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents resultado As Label
    Friend WithEvents calcular As Button
End Class
