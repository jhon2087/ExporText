

Public Class RegistroEmisor

  

    Private Sub RegistroEmisor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

      
        TextBox3.Enabled = False
        TextBox1.Enabled = False
    End Sub

    Private Sub TextBox2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
      
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim txt As String = TextBox2.TextLength


        Dim obRuc As New ConvertirLetras()
        Dim resul As ArrayList = obRuc.obtenerRucEmisor(TextBox2.Text)
        Dim r1() As String = resul(0)
        Dim t1 = r1(3)
        Dim text1 = t1.Substring(0, 2)
        Dim text2 = t1.Substring(0, 4)
        TextBox3.Text = r1(0)
        TextBox1.Text = r1(4) & " " & r1(5) & " " & r1(8)



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click


        Dim txt As String = TextBox2.TextLength
        Dim sel As String = ComboBox1.SelectedItem.ToString()

        Dim obRuc As New ConvertirLetras()
        Dim resul As ArrayList = obRuc.obtenerRucEmisor(TextBox2.Text)
        Dim r1() As String = resul(0)

        If txt = 0 Then
            MsgBox("Debes ingresar RUC")

        ElseIf sel = "" Then
            MsgBox("Debes seleccionar tipo de Emisor")

        Else

            If (sel = "Agencia") Then

                Dim t1 = r1(3)
                Dim us = r1(0)
                Dim us1 = us.Substring(0, 3)
                Dim text1 = t1.Substring(0, 2)
                Dim text2 = t1.Substring(0, 4)
                'TextBox3.Text = r1(0)
                'TextBox1.Text = r1(4) & " " & r1(5) & " " & r1(8)

                'obRuc.RegistrarAgencia("1", 515, 121, r1(0), r1(0), TextBox2.Text, "1", TextBox1.Text, "1", "PE", text1, text2, t1, "5213", "www.ejemplo.com",
                '"12345678", "232323", "correo@ejemplo.com", "correo@ejemplo.com", "1254631", "1", "201215461", "prueba", "1", "1.1.1.1")

                Dim resul2 As ArrayList = obRuc.RecordSucursal()
                Dim r3 As Integer = resul2(0)
                Dim r4 As String = resul2(1)
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "1", "FF11", "1", "1000", "USER" & us1 & 1, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "1", "FF12", "1", "1000", "USER" & us1 & 2, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "1", "FF13", "1", "1000", "USER" & us1 & 3, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "1", "FF14", "1", "1000", "USER" & us1 & 4, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "1", "FF30", "1", "1000", "USER" & us1 & 5, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "1", "FF40", "1", "1000", "USER" & us1 & 6, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "1", "FF50", "1", "1000", "USER" & us1 & 7, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "2", "BB11", "1", "1000", "USER" & us1 & 1, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "2", "BB12", "1", "1000", "USER" & us1 & 2, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "2", "BB13", "1", "1000", "USER" & us1 & 3, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "2", "BB14", "1", "1000", "USER" & us1 & 4, "1", "1")
                'obRuc.InsertarRango(r4, TextBox2.Text, TextBox3.Text, r3, "2", "BB50", "1", "1000", "USER" & us1 & 5, "1", "1")

                obRuc.RegistrarUsuario("USER" & us1 & 1, TextBox3.Text, TextBox3.Text, "21212121", TextBox1.Text, "correo@ejemplo.com", "1", "234212", "123", "1", "Usuario", 2, r4, r3, "SuperEmisor", "1.1.1.1")
                obRuc.RegistrarUsuario("USER" & us1 & 2, TextBox3.Text, TextBox3.Text, "21212121", TextBox1.Text, "correo@ejemplo.com", "1", "234212", "123", "1", "Usuario", 2, r4, r3, "SuperEmisor", "1.1.1.1")
                obRuc.RegistrarUsuario("USER" & us1 & 3, TextBox3.Text, TextBox3.Text, "21212121", TextBox1.Text, "correo@ejemplo.com", "1", "234212", "123", "1", "Usuario", 2, r4, r3, "SuperEmisor", "1.1.1.1")
                obRuc.RegistrarUsuario("USER" & us1 & 4, TextBox3.Text, TextBox3.Text, "21212121", TextBox1.Text, "correo@ejemplo.com", "1", "234212", "123", "1", "Usuario", 2, r4, r3, "SuperEmisor", "1.1.1.1")
                obRuc.RegistrarUsuario("USER" & us1 & 5, TextBox3.Text, TextBox3.Text, "21212121", TextBox1.Text, "correo@ejemplo.com", "1", "234212", "123", "1", "Usuario", 2, r4, r3, "SuperEmisor", "1.1.1.1")
                obRuc.RegistrarUsuario("USER" & us1 & 6, TextBox3.Text, TextBox3.Text, "21212121", TextBox1.Text, "correo@ejemplo.com", "1", "234212", "123", "1", "Usuario", 2, r4, r3, "SuperEmisor", "1.1.1.1")
                obRuc.RegistrarUsuario("USER" & us1 & 7, TextBox3.Text, TextBox3.Text, "21212121", TextBox1.Text, "correo@ejemplo.com", "1", "234212", "123", "1", "Usuario", 2, r4, r3, "SuperEmisor", "1.1.1.1")




                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.SelectedIndex = 0

                MsgBox("Registro guardado con éxito")
                Form1.ShowDialog()



            ElseIf (sel = "Aerolinea") Then

                Dim t1 = r1(3)
                Dim text1 = t1.Substring(0, 2)
                Dim text2 = t1.Substring(2, 2)
                Dim text3 = t1.Substring(4, 2)
                TextBox3.Text = r1(0)
                TextBox1.Text = r1(4) & " " & r1(5) & " " & r1(8)


                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.SelectedIndex = "0"
                Form1.ShowDialog()

            ElseIf (sel = "Tercero") Then

                Dim t1 = r1(3)
                Dim text1 = t1.Substring(0, 2)
                Dim text2 = t1.Substring(2, 2)
                Dim text3 = t1.Substring(4, 2)
                TextBox3.Text = r1(0)
                TextBox1.Text = r1(4) & " " & r1(5) & " " & r1(8)


                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.SelectedIndex = "0"
                Form1.ShowDialog()

            End If



        End If

    End Sub
End Class