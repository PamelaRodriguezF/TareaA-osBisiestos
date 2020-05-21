Public Class Formulario2
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        bisiesto() 'LLamado a la función bisiesto
        Textosalfinal() 'LLamado a la función que hace aparecer los textos al final


    End Sub

    Sub bisiesto()
        Dim a As Integer 'Funcion  para saber si el año es bisiesto o no 
        a = TextIngA.Text
        If (a Mod 4 = 0 And a Mod 100 <> 0 Or a Mod 400 = 0) Then
            Lresultado.Text = "El año " + "" + Trim(a) + "" + " Si es Bisiesto"
        Else
            Lresultado.Text = "El año " + "" + Trim(a) + "" + " No es Bisiesto "

        End If

    End Sub



    Sub Textosalfinal() ' cuando el usuario hace click en el boton aceptar muestra los siguientes labels
        LGracias.Text = "Gracias por usar mi programa!!!!"
        LMiNombre.Text = "Mi nombre es Pamela Rodríguez"
        LUTU.Text = "Soy alumna de 3ero EMT de la Escuela Tecnica Maria Espinola Espinola"
    End Sub

    Private Sub Formulario2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nombreusuario() 'LLamado de la funcion para mostrar el nombre del usuario
    End Sub


    Sub Nombreusuario() 'Funcion para pasar el nombre del usuario del textbox al label
        LNombreus.Text = Formulario1.TextoNombre.Text
    End Sub
End Class