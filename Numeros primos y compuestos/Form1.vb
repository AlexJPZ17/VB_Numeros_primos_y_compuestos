Public Class Form1
    Private Sub Numeros()
        'Declaramos las variables 
        Dim inicio As Integer
        Dim final As Integer
        Dim numeros As Integer

        'Condición que valida el TextBox_Inicial si este esta vacío
        If TextBox_Inicial.Text = "" Then
            MessageBox.Show("Ingrese un valor inicial ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Condición que valida el TextBox_Final si este esta vacío
            If TextBox_Final.Text = "" Then
                MessageBox.Show("Ingrese un valor final ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Método que extrae el valor ingresado en el TextBox_Inicia,
                'y TextBox_Final y lo convierte en un tipo entero y lo almacena 
                'en las variables inicio y final 
                inicio = Convert.ToInt32(TextBox_Inicial.Text)
                final = Convert.ToInt32(TextBox_Final.Text)
                'Ciclo for que recorre un valor en pensando por el valor almacenado en la
                'Variable inicio hasta el valor almacenado en la variable final
                For i = inicio To final
                    'La variable números se inicializa con 0
                    numeros = 0
                    'Ciclo for que recorre desde el valor j hasta lo que este almacenado
                    'en la variable i
                    For j = 1 To i
                        'Condición que si i Mod j es la división para buscar el 
                        'residuo y si el residuo es igual a 0 que numeros = numeros + 1
                        If ((i Mod j) = 0) Then
                            numeros = numeros + 1
                        End If
                    Next j
                    'Condición que si número es igual a 2 esto es porque los números
                    'primos solo es divisible por 2 o por sí mismo y por 1 
                    If (numeros = 2) Then
                        ListBox_Primos.Items.Add(i)
                    Else
                        ListBox_Compuestos.Items.Add(i)
                    End If
                Next i

            End If
        End If

    End Sub

    Private Sub Button_Run_Click(sender As Object, e As EventArgs) Handles Button_Run.Click
        Numeros()
    End Sub

    Private Sub Button_Clean_Click(sender As Object, e As EventArgs) Handles Button_Clean.Click
        'limpiamos los controles 
        TextBox_Inicial.Text = ""
        TextBox_Final.Text = ""
        ListBox_Primos.Items.Clear()
        ListBox_Compuestos.Items.Clear()
        TextBox_Inicial.Focus()

    End Sub
End Class
