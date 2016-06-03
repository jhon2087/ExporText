Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ConvertirLetras

    Dim cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As DataRow
    Dim conexion As String = "server=172.14.1.4;database=dbDocument;Uid=devegdn;Password=devegogdn;"


    Public Function obtenerRuc(ByVal _Ruc As String) As ArrayList

        Dim res As String
        Dim list As ArrayList = New ArrayList

        Using cnn As New SqlConnection(conexion)

            Try
                Dim cmd As New SqlCommand("BusCliSunat", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ruc", _Ruc)
                cnn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    Do While reader.Read()
                        list.Add(reader.GetInt32(0))
                        list.Add(reader.GetString(1))
                        list.Add(reader.GetString(2))
                        list.Add(reader.GetString(3))

                    Loop
                    Console.WriteLine(list)
                Else
                    Console.WriteLine("No hay filas.")
                End If

                reader.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

        Return list

    End Function

    Public Function obtenerRucEmisor(ByVal _Ruc As String) As ArrayList

        Dim res As String, res2
        Dim list As ArrayList = New ArrayList

        Using cnn As New SqlConnection(conexion)

            Try
                Dim cmd As New SqlCommand("uspIdSunatDa", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ruc", _Ruc)
                cnn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Do While reader.Read()

                        Dim delimiter As Char = "|"
                        res = reader.GetString(0)
                        res2 = reader.GetString(1)
                        Dim num() As String
                        num = Split(res2, delimiter)
                        For intCount = LBound(num) To UBound(num)
                            Debug.Print(Trim(num(intCount)))
                        Next
                        list.Add(num)
                    Loop

                Else
                    Console.WriteLine("No hay filas.")
                End If

                reader.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

        Return list

    End Function


    Public Function RegistrarAgencia(ByVal _SIata As String, ByVal Ia0001 As Integer, ByVal CodAgencia As Integer, ByVal _Nombre As String, ByVal NombreComercial As String,
                                     ByVal _Ruc As String, ByVal NroSede As String, ByVal _Direccion As String, ByVal TipoAgencia As String, ByVal _Pais As String,
                                     ByVal _Region As String, ByVal _Estado As String, ByVal _Ciudad As String, ByVal CodigoPostal As String, ByVal WebInstitucional As String,
                                      ByVal Telefono As String, ByVal Fax As String, ByVal EmailVentas As String, ByVal EmailAdministrativo As String, ByVal Representante As String,
                                      ByVal TipoTurismo As String, ByVal CuentaCorriente As String, ByVal ComentariosLegales As String, ByVal UsuarioCreo As String,
                                      ByVal IpCreacion As String) As String


        Using cnn As New SqlConnection(conexion)

            Dim mensaje As String

            Try
                Dim cmd As New SqlCommand("uspMaeAgenciaGrabar", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@SIata", _SIata)
                cmd.Parameters.AddWithValue("@Ia0001", Ia0001)
                cmd.Parameters.AddWithValue("@CodAgencia", CodAgencia)
                cmd.Parameters.AddWithValue("@Nombre", _Nombre)
                cmd.Parameters.AddWithValue("@NombreComercial", NombreComercial)
                cmd.Parameters.AddWithValue("@Ruc", _Ruc)
                cmd.Parameters.AddWithValue("@NroSede", NroSede)
                cmd.Parameters.AddWithValue("@Direccion", _Direccion)
                cmd.Parameters.AddWithValue("@TipoAgencia", TipoAgencia)
                cmd.Parameters.AddWithValue("@Pais", _Pais)
                cmd.Parameters.AddWithValue("@Region", _Region)
                cmd.Parameters.AddWithValue("@Estado", _Estado)
                cmd.Parameters.AddWithValue("@Ciudad", _Ciudad)
                cmd.Parameters.AddWithValue("@CodigoPostal", CodigoPostal)
                cmd.Parameters.AddWithValue("@WebInstitucional", WebInstitucional)
                cmd.Parameters.AddWithValue("@Telefono", Telefono)
                cmd.Parameters.AddWithValue("@Fax", Fax)
                cmd.Parameters.AddWithValue("@EmailVentas", EmailVentas)
                cmd.Parameters.AddWithValue("@EmailAdministrativo", EmailAdministrativo)
                cmd.Parameters.AddWithValue("@Representante", Representante)
                cmd.Parameters.AddWithValue("@TipoTurismo", TipoTurismo)
                cmd.Parameters.AddWithValue("@CuentaCorriente", CuentaCorriente)
                cmd.Parameters.AddWithValue("@ComentariosLegales", ComentariosLegales)
                cmd.Parameters.AddWithValue("@UsuarioCreo", UsuarioCreo)
                cmd.Parameters.AddWithValue("@IpCreacion", IpCreacion)
                cmd.Parameters.AddWithValue("@mensaje", CStr(SqlDbType.VarChar))
                cmd.Parameters("@mensaje").Direction = ParameterDirection.Output
                cnn.Open()
                cmd.ExecuteNonQuery()
                mensaje = cmd.Parameters("@mensaje").Value

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Function


    Public Function RegistrarAerolinea(ByVal CodigoAerolinea As Integer, ByVal _Nombre As String, ByVal _Direccion As String, ByVal PrefijoIata As String,
                                       ByVal _Pais As String, ByVal _Region As String, ByVal _Estado As String, ByVal _Ciudad As String, ByVal _Ruc As String,
                                        ByVal Email As String, ByVal Nro_Sucursal As String, ByVal Tipo As String, ByVal Representante As String,
                                         ByVal Telefono As String, ByVal Fax As String, ByVal CodigoPostal As String, ByVal Web As String, ByVal CuentaCorriente As String,
                                           ByVal ComentariosLegales As String, ByVal UsuarioCreo As String, ByVal IpCreacion As String) As String

        Using cnn As New SqlConnection(conexion)

            Try

                Dim cmd As New SqlCommand("uspMaeAerolineaGrabar", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodigoAerolinea", CodigoAerolinea)
                cmd.Parameters.AddWithValue("@Nombre", _Nombre)
                cmd.Parameters.AddWithValue("@Direccion", _Direccion)
                cmd.Parameters.AddWithValue("@PrefijoIata", PrefijoIata)
                cmd.Parameters.AddWithValue("@Pais", _Pais)
                cmd.Parameters.AddWithValue("@Region", _Region)
                cmd.Parameters.AddWithValue("@Estado", _Estado)
                cmd.Parameters.AddWithValue("@Ciudad", _Ciudad)
                cmd.Parameters.AddWithValue("@Ruc", _Ruc)
                cmd.Parameters.AddWithValue("@Email", Email)
                cmd.Parameters.AddWithValue("@Nro_Sucursal", Nro_Sucursal)
                cmd.Parameters.AddWithValue("@Tipo", Tipo)
                cmd.Parameters.AddWithValue("@Representante", Representante)
                cmd.Parameters.AddWithValue("@Telefono", Telefono)
                cmd.Parameters.AddWithValue("@Fax", Fax)
                cmd.Parameters.AddWithValue("@CodigoPostal", CodigoPostal)
                cmd.Parameters.AddWithValue("@Web", Web)
                cmd.Parameters.AddWithValue("@CuentaCorriente", CuentaCorriente)
                cmd.Parameters.AddWithValue("@ComentariosLegales", ComentariosLegales)
                cmd.Parameters.AddWithValue("@UsuarioCreo", UsuarioCreo)
                cmd.Parameters.AddWithValue("@IpCreacion", IpCreacion)
                cnn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Function



    Public Function RegistrarTercero(ByVal _Ruc As String, ByVal _Razon As String, ByVal Sucursal As String, ByVal _Direccion As String, ByVal Telefono As String, ByVal Fax As String,
                                    ByVal Email As String, ByVal _Pais As String, ByVal _Region As String, ByVal _Estado As String,
                                    ByVal _Ciudad As String, ByVal CuentaCorriente As String, ByVal ComentariosLegales As String, ByVal UsuarioCreo As String,
                                    ByVal IpCreacion As String) As String

        Using cnn As New SqlConnection(conexion)

            Try
                Dim cmd As New SqlCommand("uspMaeTerceroGrabar", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Ruc", _Ruc)
                cmd.Parameters.AddWithValue("@RazonSocial", _Razon)
                cmd.Parameters.AddWithValue("@Sucursal", Sucursal)
                cmd.Parameters.AddWithValue("@Direccion", _Direccion)
                cmd.Parameters.AddWithValue("@Telefono", Telefono)
                cmd.Parameters.AddWithValue("@Fax", Fax)
                cmd.Parameters.AddWithValue("@Email", Email)
                cmd.Parameters.AddWithValue("@Pais", _Pais)
                cmd.Parameters.AddWithValue("@Region", _Region)
                cmd.Parameters.AddWithValue("@Estado", _Estado)
                cmd.Parameters.AddWithValue("@Ciudad", _Ciudad)
                cmd.Parameters.AddWithValue("@CuentaCorriente", CuentaCorriente)
                cmd.Parameters.AddWithValue("@ComentariosLegales", ComentariosLegales)
                cmd.Parameters.AddWithValue("@UsuarioCreo", UsuarioCreo)
                cmd.Parameters.AddWithValue("@IpCreacion", IpCreacion)
                cnn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Function



    Public Function RecordSucursal() As ArrayList

        Dim list As ArrayList = New ArrayList

        Using cnn As New SqlConnection(conexion)
            Try
                Dim cmd As New SqlCommand("RecordSucursal", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cnn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    Do While reader.Read()
                        list.Add(reader.GetInt32(0))
                        list.Add(reader.GetString(1))
                    Loop
                    Console.WriteLine(list)
                Else
                    Console.WriteLine("No hay filas.")
                End If

                reader.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

        Return list

    End Function

    Public Function InsertarRango(ByVal CODIGOEMISOR As String, ByVal RUC As String, ByVal RAZONSOCIAL As String, ByVal SUCURSAL As String, ByVal TIPODOC As String,
                                  ByVal SERIE As String, ByVal RANGOINICIAL As String, ByVal RANGOFINAL As String, ByVal USUARIOCREO As String,
                                   ByVal SRANGO As String, ByVal SREGISTRO As String) As String

        Using cnn As New SqlConnection(conexion)

            Try
                Dim cmd As New SqlCommand("INSERTRANGO", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CODIGOEMISOR", CODIGOEMISOR)
                cmd.Parameters.AddWithValue("@RUC", RUC)
                cmd.Parameters.AddWithValue("@RAZONSOCIAL", RAZONSOCIAL)
                cmd.Parameters.AddWithValue("@SUCURSAL", SUCURSAL)
                cmd.Parameters.AddWithValue("@TIPODOC", TIPODOC)
                cmd.Parameters.AddWithValue("@SERIE", SERIE)
                cmd.Parameters.AddWithValue("@RANGOINICIAL", RANGOINICIAL)
                cmd.Parameters.AddWithValue("@RANGOFINAL", RANGOFINAL)
                cmd.Parameters.AddWithValue("@USUARIOCREO", USUARIOCREO)
                cmd.Parameters.AddWithValue("@SRANGO", SRANGO)
                cmd.Parameters.AddWithValue("@SREGISTRO", SREGISTRO)
                cnn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Function

    Function Convertir(ByVal input As String) As Byte()

        Dim md5Hasher As New MD5CryptoServiceProvider()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return data

    End Function



    Public Function RegistrarUsuario(ByVal UsuarioId As String, ByVal Nombres As String, ByVal Apellidos As String, ByVal Telefono As String, ByVal Direccion As String,
                                     ByVal Email As String, ByVal TipoDocumento As String, ByVal NroDocumento As String, ByVal Password As String, ByVal Moneda As String,
                                     ByVal Clase As String, ByVal IdTipoUsuario As String, ByVal IdCodTipoEmisor As String, ByVal IdSucursal As Integer, ByVal UsuarioCreo As String,
                                      ByVal IpCreacion As String) As String


        Using cnn As New SqlConnection(conexion)

            Dim mensaje As String



            Try
                Dim cmd As New SqlCommand("uspMaeUsuarioGrabar", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@UsuarioId", UsuarioId)
                cmd.Parameters.AddWithValue("@Nombres", Nombres)
                cmd.Parameters.AddWithValue("@Apellidos", Apellidos)
                cmd.Parameters.AddWithValue("@Telefono", Telefono)
                cmd.Parameters.AddWithValue("@Direccion", Direccion)
                cmd.Parameters.AddWithValue("@Email", Email)
                cmd.Parameters.AddWithValue("@TipoDocumento", TipoDocumento)
                cmd.Parameters.AddWithValue("@NroDocumento", NroDocumento)
                cmd.Parameters.AddWithValue("@Password", Convertir(Password))
                cmd.Parameters.AddWithValue("@Moneda", Moneda)
                cmd.Parameters.AddWithValue("@Clase", Clase)
                cmd.Parameters.AddWithValue("@IdTipoUsuario", IdTipoUsuario)
                cmd.Parameters.AddWithValue("@IdCodTipoEmisor", IdCodTipoEmisor)
                cmd.Parameters.AddWithValue("@IdSucursal", CInt(IdSucursal))
                cmd.Parameters.AddWithValue("@UsuarioCreo", UsuarioCreo)
                cmd.Parameters.AddWithValue("@IpCreacion", IpCreacion)
                cmd.Parameters.AddWithValue("@mensaje", CStr(SqlDbType.VarChar))
                cmd.Parameters("@mensaje").Direction = ParameterDirection.Output
                cnn.Open()
                cmd.ExecuteNonQuery()
                mensaje = cmd.Parameters("@mensaje").Value

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Function

End Class
