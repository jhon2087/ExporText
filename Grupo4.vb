Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Grupo4



    Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
    Dim f1 As String = Replace(fecha, "/", "")
    Dim fech As String = Microsoft.VisualBasic.Right(f1, 6)
    Dim fpos As String = fech + 4
    Dim cor1 As String = "0000000001"
    Dim cor2 As String = "0000000002"
    Dim cor3 As String = "0000000003"
    Dim cor4 As String = "0000000004"
    Dim cor5 As String = "0000000005"
    Dim cor6 As String = "0000000006"
    Dim cor7 As String = "0000000007"
    Dim cor8 As String = "0000000008"
    Dim cor9 As String = "0000000009"
    Dim cor10 As String = "0000000010"
    Dim cor11 As String = "0000000011"
    Dim path3 As String = "D:\GeneraDocs\Ventas_gratuitas\"


    Function Factura1Item2(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000006442"
        array(9) = "0000000000"
        array(10) = "0000006442"
        array(11) = "0000000000"
        array(12) = "0000001158"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000007500"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000002254"
        array2(9) = "0000000000"
        array2(10) = "0000002254"
        array2(11) = "0000000405"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002659"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000004188"
        array3(9) = "0000000000"
        array3(10) = "0000004188"
        array3(11) = "0000000753"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000004841"


      


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor1 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)
      

        sw.Close()

        Return array


    End Function



    Function Factura2Item1(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000002412"
        array(9) = "0000000000"
        array(10) = "0000002412"
        array(11) = "0000000000"
        array(12) = "0000000434"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000002846"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000002412"
        array2(9) = "0000000000"
        array2(10) = "0000002412"
        array2(11) = "0000000434"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002846"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor2 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
      

        sw.Close()

        Return array

    End Function


    Function Factura3Item4(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000017616"
        array(9) = "0000000000"
        array(10) = "0000017616"
        array(11) = "0000000000"
        array(12) = "0000001761"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000019377"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001212"
        array2(9) = "0000000000"
        array2(10) = "0000001212"
        array2(11) = "0000000121"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001333"

        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000008452"
        array3(9) = "0000000000"
        array3(10) = "0000008452"
        array3(11) = "0000000845"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000009297"



        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "SERVICIO  "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "C58-RRF   "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000002411"
        array4(9) = "0000000000"
        array4(10) = "0000002411"
        array4(11) = "0000000241"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000002652"



        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "SERVICIO  "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "C58-RRF   "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000005541"
        array5(9) = "0000000000"
        array5(10) = "0000005541"
        array5(11) = "0000000554"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000006095"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor3 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)
        For Each value4 As String In array4
            tre4 = value4
            acu4 = acu4 + tre4
        Next
        sw.WriteLine(acu4)
        For Each value5 As String In array5
            tre5 = value5
            acu5 = acu5 + tre5
        Next
        sw.WriteLine(acu5)


        sw.Close()

        Return array


    End Function



    Function Factura4Item3(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000012968"
        array(9) = "0000000000"
        array(10) = "0000012968"
        array(11) = "0000000000"
        array(12) = "0000001296"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000014264"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000002645"
        array2(9) = "0000000000"
        array2(10) = "0000002645"
        array2(11) = "0000000264"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002909"



        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000005552"
        array3(9) = "0000000000"
        array3(10) = "0000005552"
        array3(11) = "0000000555"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000006107"



        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "SERVICIO  "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "C58-RRF   "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004771"
        array4(9) = "0000000000"
        array4(10) = "0000004771"
        array4(11) = "0000000477"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005248"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor4 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)
        For Each value4 As String In array4
            tre4 = value4
            acu4 = acu4 + tre4
        Next
        sw.WriteLine(acu4)
        sw.Close()

        Return array

    End Function



    Function Factura5Item5(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000025300"
        array(9) = "0000000000"
        array(10) = "0000025300"
        array(11) = "0000000000"
        array(12) = "0000002530"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000027829"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000002995"
        array2(9) = "0000000000"
        array2(10) = "0000002995"
        array2(11) = "0000000299"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000003294"



        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000005552"
        array3(9) = "0000000000"
        array3(10) = "0000005552"
        array3(11) = "0000000555"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000006107"



        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "SERVICIO  "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "C58-RRF   "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004771"
        array4(9) = "0000000000"
        array4(10) = "0000004771"
        array4(11) = "0000000477"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005248"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "SERVICIO  "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "C58-RRF   "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000002871"
        array5(9) = "0000000000"
        array5(10) = "0000002871"
        array5(11) = "0000000287"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000003158"


        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(1) = "0000000001"
        array6(2) = "SERVICIO  "
        array6(3) = "GRABADO   "
        array6(4) = "8"
        array6(5) = "C58-RRF   "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000009111"
        array6(9) = "0000000000"
        array6(10) = "0000009111"
        array6(11) = "0000000911"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000010022"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor5 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)
        For Each value4 As String In array4
            tre4 = value4
            acu4 = acu4 + tre4
        Next
        sw.WriteLine(acu4)
        For Each value5 As String In array5
            tre5 = value5
            acu5 = acu5 + tre5
        Next
        sw.WriteLine(acu5)
        For Each value6 As String In array6
            tre6 = value6
            acu6 = acu6 + tre6
        Next
        sw.WriteLine(acu6)
        sw.Close()

        Return array


    End Function



    Function NotaCreditoGrupo4Factura2(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "NC"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000005304"
        array(9) = "0000000000"
        array(10) = "0000005304"
        array(11) = "0000000000"
        array(12) = "0000000530"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000006027"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "FF14-00000009"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000002412"
        array2(9) = "0000000000"
        array2(10) = "0000002412"
        array2(11) = "0000000434"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002846"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000002892"
        array3(9) = "0000000000"
        array3(10) = "0000002892"
        array3(11) = "0000000289"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000003181"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor6 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)

        sw.Close()

        Return array

    End Function



    Function NotaCreditoGrupo4Factura3(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "NC"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000024257"
        array(9) = "0000000000"
        array(10) = "0000024257"
        array(11) = "0000000000"
        array(12) = "0000002425"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000026682"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "FF14-00000011"
        array(19) = "FF14"
        array(20) = "00000011"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001212"
        array2(9) = "0000000000"
        array2(10) = "0000001212"
        array2(11) = "0000000121"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001333"

        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000008452"
        array3(9) = "0000000000"
        array3(10) = "0000008452"
        array3(11) = "0000000845"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000009297"



        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "SERVICIO  "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "C58-RRF   "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000002411"
        array4(9) = "0000000000"
        array4(10) = "0000002411"
        array4(11) = "0000000241"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000002652"



        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "SERVICIO  "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "C58-RRF   "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000005541"
        array5(9) = "0000000000"
        array5(10) = "0000005541"
        array5(11) = "0000000554"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000006095"



        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(1) = "0000000001"
        array6(2) = "SERVICIO  "
        array6(3) = "GRABADO   "
        array6(4) = "8"
        array6(5) = "C58-RRF   "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000006641"
        array6(9) = "0000000000"
        array6(10) = "0000006641"
        array6(11) = "0000000664"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000007305"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor7 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)
        For Each value4 As String In array4
            tre4 = value4
            acu4 = acu4 + tre4
        Next
        sw.WriteLine(acu4)
        For Each value5 As String In array5
            tre5 = value5
            acu5 = acu5 + tre5
        Next
        sw.WriteLine(acu5)
        For Each value6 As String In array6
            tre6 = value6
            acu6 = acu6 + tre6
        Next
        sw.WriteLine(acu6)

        sw.Close()

        Return array

    End Function


    Function NotaCreditoGrupo4Factura5(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "NC"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000031811"
        array(9) = "0000000000"
        array(10) = "0000031811"
        array(11) = "0000000000"
        array(12) = "0000003181"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000034991"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "FF14-00000009"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000002995"
        array2(9) = "0000000000"
        array2(10) = "0000002995"
        array2(11) = "0000000299"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000003294"



        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000005552"
        array3(9) = "0000000000"
        array3(10) = "0000005552"
        array3(11) = "0000000555"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000006107"



        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "SERVICIO  "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "C58-RRF   "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004771"
        array4(9) = "0000000000"
        array4(10) = "0000004771"
        array4(11) = "0000000477"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005248"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "SERVICIO  "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "C58-RRF   "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000002871"
        array5(9) = "0000000000"
        array5(10) = "0000002871"
        array5(11) = "0000000287"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000003158"


        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(1) = "0000000001"
        array6(2) = "SERVICIO  "
        array6(3) = "GRABADO   "
        array6(4) = "8"
        array6(5) = "C58-RRF   "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000009111"
        array6(9) = "0000000000"
        array6(10) = "0000009111"
        array6(11) = "0000000911"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000010022"

        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(1) = "0000000001"
        array7(2) = "SERVICIO  "
        array7(3) = "GRABADO   "
        array7(4) = "8"
        array7(5) = "C58-RRF   "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000006511"
        array7(9) = "0000000000"
        array7(10) = "0000006511"
        array7(11) = "0000000651"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000007162"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor8 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)
        For Each value4 As String In array4
            tre4 = value4
            acu4 = acu4 + tre4
        Next
        sw.WriteLine(acu4)
        For Each value5 As String In array5
            tre5 = value5
            acu5 = acu5 + tre5
        Next
        sw.WriteLine(acu5)
        For Each value6 As String In array6
            tre6 = value6
            acu6 = acu6 + tre6
        Next
        sw.WriteLine(acu6)
        For Each value7 As String In array7
            tre7 = value7
            acu7 = acu7 + tre7
        Next
        sw.WriteLine(acu7)
        sw.Close()

        Return array

    End Function


    Function NotaDebitoGrupo4Factura2(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "ND"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000002937"
        array(9) = "0000000000"
        array(10) = "0000002937"
        array(11) = "0000000000"
        array(12) = "0000000293"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000003230"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "FF14-00000012"
        array(19) = "FF14"
        array(20) = "00000012"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000002937"
        array2(9) = "0000000000"
        array2(10) = "0000002937"
        array2(11) = "0000000293"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000003230"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor9 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)


        sw.Close()

        Return array

    End Function


    Function NotaDebitoGrupo4Factura3(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "ND"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000012075"
        array(9) = "0000000000"
        array(10) = "0000012075"
        array(11) = "0000000000"
        array(12) = "0000001207"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000013282"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "FF14-00000009"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001212"
        array2(9) = "0000000000"
        array2(10) = "0000001212"
        array2(11) = "0000000121"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001333"

        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000008452"
        array3(9) = "0000000000"
        array3(10) = "0000008452"
        array3(11) = "0000000845"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000009297"



        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "SERVICIO  "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "C58-RRF   "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000002411"
        array4(9) = "0000000000"
        array4(10) = "0000002411"
        array4(11) = "0000000241"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000002652"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor10 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)
        For Each value4 As String In array4
            tre4 = value4
            acu4 = acu4 + tre4
        Next
        sw.WriteLine(acu4)
        sw.Close()

        Return array

    End Function

    Function NotaDebitoGrupo4Factura5(ByVal remisor As String, ByVal rcliente As String) As String()



        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "ND"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000016189"
        array(9) = "0000000000"
        array(10) = "0000016189"
        array(11) = "0000000000"
        array(12) = "0000001618"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000017807"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "FF14-00000009"
        array(19) = "FF14"
        array(20) = "00000009"
        array(21) = "DEMOUSER20164       "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000002995"
        array2(9) = "0000000000"
        array2(10) = "0000002995"
        array2(11) = "0000000299"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000003294"



        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000005552"
        array3(9) = "0000000000"
        array3(10) = "0000005552"
        array3(11) = "0000000555"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000006107"



        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "SERVICIO  "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "C58-RRF   "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004771"
        array4(9) = "0000000000"
        array4(10) = "0000004771"
        array4(11) = "0000000477"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005248"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "SERVICIO  "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "C58-RRF   "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000002871"
        array5(9) = "0000000000"
        array5(10) = "0000002871"
        array5(11) = "0000000287"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000003158"


     


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path3 & remisor & "00" & nrc & "DOC" & cor11 & fech & "FA.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine(acu)
        For Each value2 As String In array2
            tre2 = value2
            acu2 = acu2 + tre2
        Next
        sw.WriteLine(acu2)
        For Each value3 As String In array3
            tre3 = value3
            acu3 = acu3 + tre3
        Next
        sw.WriteLine(acu3)
        For Each value4 As String In array4
            tre4 = value4
            acu4 = acu4 + tre4
        Next
        sw.WriteLine(acu4)
        For Each value5 As String In array5
            tre5 = value5
            acu5 = acu5 + tre5
        Next
        sw.WriteLine(acu5)
      
        sw.Close()

        Return array




    End Function
End Class
