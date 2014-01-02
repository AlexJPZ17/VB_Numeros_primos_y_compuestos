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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox_Compuestos = New System.Windows.Forms.ListBox()
        Me.ListBox_Primos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Run = New System.Windows.Forms.Button()
        Me.Button_Clean = New System.Windows.Forms.Button()
        Me.TextBox_Inicial = New System.Windows.Forms.TextBox()
        Me.TextBox_Final = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.ListBox_Compuestos)
        Me.GroupBox1.Controls.Add(Me.ListBox_Primos)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(166, 285)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ListBox_Compuestos
        '
        Me.ListBox_Compuestos.FormattingEnabled = True
        Me.ListBox_Compuestos.Location = New System.Drawing.Point(84, 19)
        Me.ListBox_Compuestos.Name = "ListBox_Compuestos"
        Me.ListBox_Compuestos.Size = New System.Drawing.Size(64, 251)
        Me.ListBox_Compuestos.TabIndex = 3
        '
        'ListBox_Primos
        '
        Me.ListBox_Primos.FormattingEnabled = True
        Me.ListBox_Primos.Location = New System.Drawing.Point(15, 19)
        Me.ListBox_Primos.Name = "ListBox_Primos"
        Me.ListBox_Primos.Size = New System.Drawing.Size(58, 251)
        Me.ListBox_Primos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(112, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inicio"
        '
        'Button_Run
        '
        Me.Button_Run.Location = New System.Drawing.Point(12, 433)
        Me.Button_Run.Name = "Button_Run"
        Me.Button_Run.Size = New System.Drawing.Size(75, 23)
        Me.Button_Run.TabIndex = 2
        Me.Button_Run.Text = "Run"
        Me.Button_Run.UseVisualStyleBackColor = True
        '
        'Button_Clean
        '
        Me.Button_Clean.Location = New System.Drawing.Point(105, 433)
        Me.Button_Clean.Name = "Button_Clean"
        Me.Button_Clean.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clean.TabIndex = 3
        Me.Button_Clean.Text = "Clean"
        Me.Button_Clean.UseVisualStyleBackColor = True
        '
        'TextBox_Inicial
        '
        Me.TextBox_Inicial.Location = New System.Drawing.Point(29, 68)
        Me.TextBox_Inicial.Name = "TextBox_Inicial"
        Me.TextBox_Inicial.Size = New System.Drawing.Size(58, 20)
        Me.TextBox_Inicial.TabIndex = 4
        '
        'TextBox_Final
        '
        Me.TextBox_Final.Location = New System.Drawing.Point(105, 68)
        Me.TextBox_Final.Name = "TextBox_Final"
        Me.TextBox_Final.Size = New System.Drawing.Size(57, 20)
        Me.TextBox_Final.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(95, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Compuestos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Primos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(199, 480)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Final)
        Me.Controls.Add(Me.TextBox_Inicial)
        Me.Controls.Add(Me.Button_Clean)
        Me.Controls.Add(Me.Button_Run)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox_Primos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox_Compuestos As System.Windows.Forms.ListBox
    Friend WithEvents Button_Run As System.Windows.Forms.Button
    Friend WithEvents Button_Clean As System.Windows.Forms.Button
    Friend WithEvents TextBox_Inicial As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Final As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
