Public Class Formulario1


    Private Sub BotonContinuar_Click(sender As Object, e As EventArgs) Handles BotonContinuar.Click
        Dim NomUsar As String    'variable que contiene el nombre del usuario  
        NomUsar = TextoNombre.Text 'La varable guarda el valor ingresado en el textbox
        If (NomUsar = "") Then 'comprueba si el campo esta vacio y si lo esta avisa al usuario, si el usuario ingresa el nombre entonces se abre el siguiente form y e cierra el primero
            MsgBox("Ingrese su nombre o no podrá continuar", MsgBoxStyle.Information, "Error")                                                                                                                     ')
        Else
            Dim form As Formulario2 = New Formulario2
            form.Show()
            Me.Hide()


        End If
    End Sub

End Class
