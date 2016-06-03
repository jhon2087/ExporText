Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class Grupo11

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
    Dim path10 As String = "D:\GeneraDocs\Ventas_global_Boleta\"

    Function Boleta1items10(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000009"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000038820"
        array(9) = "0000000000"
        array(10) = "0000038820"
        array(11) = "0000000000"
        array(12) = "0000003878"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000042695"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB14"
        array(20) = "00000009"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001561"
        array2(9) = "0000000000"
        array2(10) = "0000001561"
        array2(11) = "0000000156"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001717"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001996"
        array3(9) = "0000000000"
        array3(10) = "0000001996"
        array3(11) = "0000000199"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002195"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004666"
        array4(9) = "0000000000"
        array4(10) = "0000004666"
        array4(11) = "0000000466"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005132"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000008316"
        array5(9) = "0000000000"
        array5(10) = "0000008316"
        array5(11) = "0000000831"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000009147"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000005146"
        array6(9) = "0000000000"
        array6(10) = "0000005146"
        array6(11) = "0000000514"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000005660"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000001007"
        array7(9) = "0000000000"
        array7(10) = "0000001007"
        array7(11) = "0000000100"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000001107"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000001450"
        array8(9) = "0000000000"
        array8(10) = "0000001450"
        array8(11) = "0000000145"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000001595"



        Dim array9(16) As String
        array9(0) = "0000000008"
        array9(2) = "BIEN      "
        array9(3) = "GRATUITA  "
        array9(4) = "8"
        array9(5) = "89657     "
        array9(6) = "Por proceso de homologacion                                                                                                                           "
        array9(7) = "0001"
        array9(8) = "0000003014"
        array9(9) = "0000000000"
        array9(10) = "0000003014"
        array9(11) = "0000000301"
        array9(12) = "0000000000"
        array9(13) = "000"
        array9(14) = "0000000000"
        array9(15) = "0000000000"
        array9(16) = "0000003315"



        Dim array10(16) As String
        array10(0) = "0000000009"
        array10(2) = "BIEN      "
        array10(3) = "GRATUITA  "
        array10(4) = "8"
        array10(5) = "89657     "
        array10(6) = "Por proceso de homologacion                                                                                                                           "
        array10(7) = "0001"
        array10(8) = "0000003550"
        array10(9) = "0000000000"
        array10(10) = "0000003550"
        array10(11) = "0000000355"
        array10(12) = "0000000000"
        array10(13) = "000"
        array10(14) = "0000000000"
        array10(15) = "0000000000"
        array10(16) = "0000003905"



        Dim array11(16) As String
        array11(0) = "0000000010"
        array11(2) = "BIEN      "
        array11(3) = "GRATUITA  "
        array11(4) = "8"
        array11(5) = "89657     "
        array11(6) = "Por proceso de homologacion                                                                                                                           "
        array11(7) = "0001"
        array11(8) = "0000008114"
        array11(9) = "0000000000"
        array11(10) = "0000008114"
        array11(11) = "0000000811"
        array11(12) = "0000000000"
        array11(13) = "000"
        array11(14) = "0000000000"
        array11(15) = "0000000000"
        array11(16) = "0000008925"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor1 & fech & "BO.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7, tre8, acu8, tre9, acu9, tre10, acu10, tre11, acu11

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
        For Each value8 As String In array8
            tre8 = value8
            acu8 = acu8 + tre8
        Next
        sw.WriteLine(acu8)
        For Each value9 As String In array9
            tre9 = value9
            acu9 = acu9 + tre9
        Next
        sw.WriteLine(acu9)
        For Each value10 As String In array10
            tre10 = value10
            acu10 = acu10 + tre10
        Next
        sw.WriteLine(acu10)
        For Each value11 As String In array11
            tre11 = value11
            acu11 = acu11 + tre11
        Next
        sw.WriteLine(acu11)
        sw.Close()

        Return array



    End Function

    Function Boleta2items7(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000012"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000031692"
        array(9) = "0000000000"
        array(10) = "0000031692"
        array(11) = "0000000000"
        array(12) = "0000003166"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000042695"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB14"
        array(20) = "00000013"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001561"
        array2(9) = "0000000000"
        array2(10) = "0000001561"
        array2(11) = "0000000156"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001717"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001196"
        array3(9) = "0000000000"
        array3(10) = "0000001196"
        array3(11) = "0000000119"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000001315"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000005446"
        array4(9) = "0000000000"
        array4(10) = "0000005446"
        array4(11) = "0000000544"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005990"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000002116"
        array5(9) = "0000000000"
        array5(10) = "0000002116"
        array5(11) = "0000000211"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000002327"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000006416"
        array6(9) = "0000000000"
        array6(10) = "0000006416"
        array6(11) = "0000000641"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000007055"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000005507"
        array7(9) = "0000000000"
        array7(10) = "0000005507"
        array7(11) = "0000000550"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000006057"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000009450"
        array8(9) = "0000000000"
        array8(10) = "0000009450"
        array8(11) = "0000000945"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000010395"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor2 & fech & "BO.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7, tre8, acu8

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
        For Each value8 As String In array8
            tre8 = value8
            acu8 = acu8 + tre8
        Next
        sw.WriteLine(acu8)
        sw.Close()

        Return array


    End Function


    Function Boleta3items6(ByVal remisor As String, ByVal rcliente As String) As String()



        Dim array(21) As String
        array(0) = "0000000017"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000015751"
        array(9) = "0000000000"
        array(10) = "0000015751"
        array(11) = "0000000000"
        array(12) = "0000001572"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000017323"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB14"
        array(20) = "00000018"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001061"
        array2(9) = "0000000000"
        array2(10) = "0000001061"
        array2(11) = "0000000106"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001167"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001996"
        array3(9) = "0000000000"
        array3(10) = "0000001996"
        array3(11) = "0000000199"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002195"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000005476"
        array4(9) = "0000000000"
        array4(10) = "0000005476"
        array4(11) = "0000000547"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000006023"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000002255"
        array5(9) = "0000000000"
        array5(10) = "0000002255"
        array5(11) = "0000000225"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000002480"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000001656"
        array6(9) = "0000000000"
        array6(10) = "0000001656"
        array6(11) = "0000000165"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000001821"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000003307"
        array7(9) = "0000000000"
        array7(10) = "0000003307"
        array7(11) = "0000000330"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000003637"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor3 & fech & "BO.txt"
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


    Function Boleta4items9(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000009"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000031056"
        array(9) = "0000000000"
        array(10) = "0000031056"
        array(11) = "0000000000"
        array(12) = "0000003102"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000034158"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB14"
        array(20) = "00000014"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001081"
        array2(9) = "0000000000"
        array2(10) = "0000001081"
        array2(11) = "0000000108"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001189"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000009786"
        array3(9) = "0000000000"
        array3(10) = "0000009786"
        array3(11) = "0000000978"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000010764"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000001166"
        array4(9) = "0000000000"
        array4(10) = "0000001166"
        array4(11) = "0000000116"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000001282"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000009316"
        array5(9) = "0000000000"
        array5(10) = "0000009316"
        array5(11) = "0000000931"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000010247"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000003336"
        array6(9) = "0000000000"
        array6(10) = "0000003336"
        array6(11) = "0000000333"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000003669"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000001667"
        array7(9) = "0000000000"
        array7(10) = "0000001667"
        array7(11) = "0000000166"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000001833"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000001330"
        array8(9) = "0000000000"
        array8(10) = "0000001330"
        array8(11) = "0000000133"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000001463"



        Dim array9(16) As String
        array9(0) = "0000000008"
        array9(2) = "BIEN      "
        array9(3) = "GRATUITA  "
        array9(4) = "8"
        array9(5) = "89657     "
        array9(6) = "Por proceso de homologacion                                                                                                                           "
        array9(7) = "0001"
        array9(8) = "0000002224"
        array9(9) = "0000000000"
        array9(10) = "0000002224"
        array9(11) = "0000000222"
        array9(12) = "0000000000"
        array9(13) = "000"
        array9(14) = "0000000000"
        array9(15) = "0000000000"
        array9(16) = "0000002446"



        Dim array10(16) As String
        array10(0) = "0000000009"
        array10(2) = "BIEN      "
        array10(3) = "GRATUITA  "
        array10(4) = "8"
        array10(5) = "89657     "
        array10(6) = "Por proceso de homologacion                                                                                                                           "
        array10(7) = "0001"
        array10(8) = "0000001150"
        array10(9) = "0000000000"
        array10(10) = "0000001150"
        array10(11) = "0000000115"
        array10(12) = "0000000000"
        array10(13) = "000"
        array10(14) = "0000000000"
        array10(15) = "0000000000"
        array10(16) = "0000001265"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor4 & fech & "BO.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7, tre8, acu8, tre9, acu9, tre10, acu10

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
        For Each value8 As String In array8
            tre8 = value8
            acu8 = acu8 + tre8
        Next
        sw.WriteLine(acu8)
        For Each value9 As String In array9
            tre9 = value9
            acu9 = acu9 + tre9
        Next
        sw.WriteLine(acu9)
        For Each value10 As String In array10
            tre10 = value10
            acu10 = acu10 + tre10
        Next
        sw.WriteLine(acu10)
        sw.Close()

        Return array
    End Function



    Function Boleta5items4(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000009"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000011903"
        array(9) = "0000000000"
        array(10) = "0000011903"
        array(11) = "0000000000"
        array(12) = "0000002378"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000013092"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB14"
        array(20) = "00000014"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001981"
        array2(9) = "0000000000"
        array2(10) = "0000001981"
        array2(11) = "0000000198"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002179"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000002210"
        array3(9) = "0000000000"
        array3(10) = "0000002210"
        array3(11) = "0000000221"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002431"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000006306"
        array4(9) = "0000000000"
        array4(10) = "0000006306"
        array4(11) = "0000000630"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000006936"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000001406"
        array5(9) = "0000000000"
        array5(10) = "0000001406"
        array5(11) = "0000000140"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000001546"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor5 & fech & "BO.txt"
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




    Function NotaCreditoBoleta1(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000011"
        array(1) = "NC"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000046920"
        array(9) = "0000000000"
        array(10) = "0000046920"
        array(11) = "0000000000"
        array(12) = "0000004688"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000051605"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB14-00000009"
        array(19) = "BB14"
        array(20) = "00000009"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001561"
        array2(9) = "0000000000"
        array2(10) = "0000001561"
        array2(11) = "0000000156"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001717"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001996"
        array3(9) = "0000000000"
        array3(10) = "0000001996"
        array3(11) = "0000000199"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002195"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004666"
        array4(9) = "0000000000"
        array4(10) = "0000004666"
        array4(11) = "0000000466"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005132"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000008316"
        array5(9) = "0000000000"
        array5(10) = "0000008316"
        array5(11) = "0000000831"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000009147"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000005146"
        array6(9) = "0000000000"
        array6(10) = "0000005146"
        array6(11) = "0000000514"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000005660"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000001007"
        array7(9) = "0000000000"
        array7(10) = "0000001007"
        array7(11) = "0000000100"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000001107"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000001450"
        array8(9) = "0000000000"
        array8(10) = "0000001450"
        array8(11) = "0000000145"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000001595"



        Dim array9(16) As String
        array9(0) = "0000000008"
        array9(2) = "BIEN      "
        array9(3) = "GRATUITA  "
        array9(4) = "8"
        array9(5) = "89657     "
        array9(6) = "Por proceso de homologacion                                                                                                                           "
        array9(7) = "0001"
        array9(8) = "0000003014"
        array9(9) = "0000000000"
        array9(10) = "0000003014"
        array9(11) = "0000000301"
        array9(12) = "0000000000"
        array9(13) = "000"
        array9(14) = "0000000000"
        array9(15) = "0000000000"
        array9(16) = "0000003315"



        Dim array10(16) As String
        array10(0) = "0000000009"
        array10(2) = "BIEN      "
        array10(3) = "GRATUITA  "
        array10(4) = "8"
        array10(5) = "89657     "
        array10(6) = "Por proceso de homologacion                                                                                                                           "
        array10(7) = "0001"
        array10(8) = "0000003550"
        array10(9) = "0000000000"
        array10(10) = "0000003550"
        array10(11) = "0000000355"
        array10(12) = "0000000000"
        array10(13) = "000"
        array10(14) = "0000000000"
        array10(15) = "0000000000"
        array10(16) = "0000003905"



        Dim array11(16) As String
        array11(0) = "0000000010"
        array11(2) = "BIEN      "
        array11(3) = "GRATUITA  "
        array11(4) = "8"
        array11(5) = "89657     "
        array11(6) = "Por proceso de homologacion                                                                                                                           "
        array11(7) = "0001"
        array11(8) = "0000008114"
        array11(9) = "0000000000"
        array11(10) = "0000008114"
        array11(11) = "0000000811"
        array11(12) = "0000000000"
        array11(13) = "000"
        array11(14) = "0000000000"
        array11(15) = "0000000000"
        array11(16) = "0000008925"


        Dim array12(16) As String
        array12(0) = "0000000011"
        array12(2) = "BIEN      "
        array12(3) = "GRATUITA  "
        array12(4) = "8"
        array12(5) = "89657     "
        array12(6) = "Por proceso de homologacion                                                                                                                           "
        array12(7) = "0001"
        array12(8) = "0000008100"
        array12(9) = "0000000000"
        array12(10) = "0000008100"
        array12(11) = "0000000810"
        array12(12) = "0000000000"
        array12(13) = "000"
        array12(14) = "0000000000"
        array12(15) = "0000000000"
        array12(16) = "0000008910"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor6 & fech & "BO.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7, tre8, acu8, tre9, acu9, tre10, acu10, tre11, acu11, tre12, acu12

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
        For Each value8 As String In array8
            tre8 = value8
            acu8 = acu8 + tre8
        Next
        sw.WriteLine(acu8)
        For Each value9 As String In array9
            tre9 = value9
            acu9 = acu9 + tre9
        Next
        sw.WriteLine(acu9)
        For Each value10 As String In array10
            tre10 = value10
            acu10 = acu10 + tre10
        Next
        sw.WriteLine(acu10)
        For Each value11 As String In array11
            tre11 = value11
            acu11 = acu11 + tre11
        Next
        sw.WriteLine(acu11)
        For Each value12 As String In array12
            tre12 = value12
            acu12 = acu12 + tre12
        Next
        sw.WriteLine(acu12)
        sw.Close()

        Return array

    End Function



    Function NotaCreditoBoleta2(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000019"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000033802"
        array(9) = "0000000000"
        array(10) = "0000033802"
        array(11) = "0000000000"
        array(12) = "0000003377"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000045016"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB14-00000013"
        array(19) = "BB14"
        array(20) = "00000013"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001561"
        array2(9) = "0000000000"
        array2(10) = "0000001561"
        array2(11) = "0000000156"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001717"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001196"
        array3(9) = "0000000000"
        array3(10) = "0000001196"
        array3(11) = "0000000119"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000001315"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000005446"
        array4(9) = "0000000000"
        array4(10) = "0000005446"
        array4(11) = "0000000544"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005990"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000002116"
        array5(9) = "0000000000"
        array5(10) = "0000002116"
        array5(11) = "0000000211"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000002327"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000006416"
        array6(9) = "0000000000"
        array6(10) = "0000006416"
        array6(11) = "0000000641"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000007055"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000005507"
        array7(9) = "0000000000"
        array7(10) = "0000005507"
        array7(11) = "0000000550"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000006057"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000009450"
        array8(9) = "0000000000"
        array8(10) = "0000009450"
        array8(11) = "0000000945"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000010395"


        Dim array9(16) As String
        array9(0) = "0000000008"
        array9(2) = "BIEN      "
        array9(3) = "GRATUITA  "
        array9(4) = "8"
        array9(5) = "89657     "
        array9(6) = "Por proceso de homologacion                                                                                                                           "
        array9(7) = "0001"
        array9(8) = "0000002110"
        array9(9) = "0000000000"
        array9(10) = "0000002110"
        array9(11) = "0000000211"
        array9(12) = "0000000000"
        array9(13) = "000"
        array9(14) = "0000000000"
        array9(15) = "0000000000"
        array9(16) = "0000002321"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor7 & fech & "BO.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7, tre8, acu8, tre9, acu9

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
        For Each value8 As String In array8
            tre8 = value8
            acu8 = acu8 + tre8
        Next
        sw.WriteLine(acu8)
        For Each value9 As String In array9
            tre9 = value9
            acu9 = acu9 + tre9
        Next
        sw.WriteLine(acu9)
        sw.Close()

        Return array


    End Function



    Function NotaCreditoBoleta4(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000009"
        array(1) = "NC"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000032206"
        array(9) = "0000000000"
        array(10) = "0000032206"
        array(11) = "0000000000"
        array(12) = "0000003217"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000035423"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB14"
        array(20) = "00000014"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001081"
        array2(9) = "0000000000"
        array2(10) = "0000001081"
        array2(11) = "0000000108"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001189"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000009786"
        array3(9) = "0000000000"
        array3(10) = "0000009786"
        array3(11) = "0000000978"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000010764"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000001166"
        array4(9) = "0000000000"
        array4(10) = "0000001166"
        array4(11) = "0000000116"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000001282"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000009316"
        array5(9) = "0000000000"
        array5(10) = "0000009316"
        array5(11) = "0000000931"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000010247"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000003336"
        array6(9) = "0000000000"
        array6(10) = "0000003336"
        array6(11) = "0000000333"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000003669"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000001667"
        array7(9) = "0000000000"
        array7(10) = "0000001667"
        array7(11) = "0000000166"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000001833"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000001330"
        array8(9) = "0000000000"
        array8(10) = "0000001330"
        array8(11) = "0000000133"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000001463"



        Dim array9(16) As String
        array9(0) = "0000000008"
        array9(2) = "BIEN      "
        array9(3) = "GRATUITA  "
        array9(4) = "8"
        array9(5) = "89657     "
        array9(6) = "Por proceso de homologacion                                                                                                                           "
        array9(7) = "0001"
        array9(8) = "0000002224"
        array9(9) = "0000000000"
        array9(10) = "0000002224"
        array9(11) = "0000000222"
        array9(12) = "0000000000"
        array9(13) = "000"
        array9(14) = "0000000000"
        array9(15) = "0000000000"
        array9(16) = "0000002446"



        Dim array10(16) As String
        array10(0) = "0000000009"
        array10(2) = "BIEN      "
        array10(3) = "GRATUITA  "
        array10(4) = "8"
        array10(5) = "89657     "
        array10(6) = "Por proceso de homologacion                                                                                                                           "
        array10(7) = "0001"
        array10(8) = "0000001150"
        array10(9) = "0000000000"
        array10(10) = "0000001150"
        array10(11) = "0000000115"
        array10(12) = "0000000000"
        array10(13) = "000"
        array10(14) = "0000000000"
        array10(15) = "0000000000"
        array10(16) = "0000001265"

        Dim array11(16) As String
        array11(0) = "0000000010"
        array11(2) = "BIEN      "
        array11(3) = "GRATUITA  "
        array11(4) = "8"
        array11(5) = "89657     "
        array11(6) = "Por proceso de homologacion                                                                                                                           "
        array11(7) = "0001"
        array11(8) = "0000001150"
        array11(9) = "0000000000"
        array11(10) = "0000001150"
        array11(11) = "0000000115"
        array11(12) = "0000000000"
        array11(13) = "000"
        array11(14) = "0000000000"
        array11(15) = "0000000000"
        array11(16) = "0000001265"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor8 & fech & "BO.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7, tre8, acu8, tre9, acu9, tre10, acu10, tre11, acu11

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
        For Each value8 As String In array8
            tre8 = value8
            acu8 = acu8 + tre8
        Next
        sw.WriteLine(acu8)
        For Each value9 As String In array9
            tre9 = value9
            acu9 = acu9 + tre9
        Next
        sw.WriteLine(acu9)
        For Each value10 As String In array10
            tre10 = value10
            acu10 = acu10 + tre10
        Next
        sw.WriteLine(acu10)
        For Each value11 As String In array11
            tre11 = value11
            acu11 = acu11 + tre11
        Next
        sw.WriteLine(acu11)
        sw.Close()

        Return array

    End Function



    Function NotaDebitoBoleta1(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000009"
        array(1) = "ND"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000030706"
        array(9) = "0000000000"
        array(10) = "0000030706"
        array(11) = "0000000000"
        array(12) = "0000003067"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000033770"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB14-00000009"
        array(19) = "BB14"
        array(20) = "00000009"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001561"
        array2(9) = "0000000000"
        array2(10) = "0000001561"
        array2(11) = "0000000156"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001717"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001996"
        array3(9) = "0000000000"
        array3(10) = "0000001996"
        array3(11) = "0000000199"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002195"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004666"
        array4(9) = "0000000000"
        array4(10) = "0000004666"
        array4(11) = "0000000466"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005132"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000008316"
        array5(9) = "0000000000"
        array5(10) = "0000008316"
        array5(11) = "0000000831"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000009147"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000005146"
        array6(9) = "0000000000"
        array6(10) = "0000005146"
        array6(11) = "0000000514"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000005660"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000001007"
        array7(9) = "0000000000"
        array7(10) = "0000001007"
        array7(11) = "0000000100"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000001107"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000001450"
        array8(9) = "0000000000"
        array8(10) = "0000001450"
        array8(11) = "0000000145"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000001595"



        Dim array9(16) As String
        array9(0) = "0000000008"
        array9(2) = "BIEN      "
        array9(3) = "GRATUITA  "
        array9(4) = "8"
        array9(5) = "89657     "
        array9(6) = "Por proceso de homologacion                                                                                                                           "
        array9(7) = "0001"
        array9(8) = "0000003014"
        array9(9) = "0000000000"
        array9(10) = "0000003014"
        array9(11) = "0000000301"
        array9(12) = "0000000000"
        array9(13) = "000"
        array9(14) = "0000000000"
        array9(15) = "0000000000"
        array9(16) = "0000003315"



        Dim array10(16) As String
        array10(0) = "0000000009"
        array10(2) = "BIEN      "
        array10(3) = "GRATUITA  "
        array10(4) = "8"
        array10(5) = "89657     "
        array10(6) = "Por proceso de homologacion                                                                                                                           "
        array10(7) = "0001"
        array10(8) = "0000003550"
        array10(9) = "0000000000"
        array10(10) = "0000003550"
        array10(11) = "0000000355"
        array10(12) = "0000000000"
        array10(13) = "000"
        array10(14) = "0000000000"
        array10(15) = "0000000000"
        array10(16) = "0000003905"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor9 & fech & "BO.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7, tre8, acu8, tre9, acu9, tre10, acu10

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
        For Each value8 As String In array8
            tre8 = value8
            acu8 = acu8 + tre8
        Next
        sw.WriteLine(acu8)
        For Each value9 As String In array9
            tre9 = value9
            acu9 = acu9 + tre9
        Next
        sw.WriteLine(acu9)
        For Each value10 As String In array10
            tre10 = value10
            acu10 = acu10 + tre10
        Next
        sw.WriteLine(acu10)
       
        sw.Close()

        Return array



    End Function


    Function NotaDebitoBoleta2(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000012"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000022242"
        array(9) = "0000000000"
        array(10) = "0000022242"
        array(11) = "0000000000"
        array(12) = "0000002221"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000032300"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB14-00000013"
        array(19) = "BB14"
        array(20) = "00000013"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001561"
        array2(9) = "0000000000"
        array2(10) = "0000001561"
        array2(11) = "0000000156"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001717"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001196"
        array3(9) = "0000000000"
        array3(10) = "0000001196"
        array3(11) = "0000000119"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000001315"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000005446"
        array4(9) = "0000000000"
        array4(10) = "0000005446"
        array4(11) = "0000000544"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005990"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000002116"
        array5(9) = "0000000000"
        array5(10) = "0000002116"
        array5(11) = "0000000211"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000002327"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000006416"
        array6(9) = "0000000000"
        array6(10) = "0000006416"
        array6(11) = "0000000641"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000007055"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000005507"
        array7(9) = "0000000000"
        array7(10) = "0000005507"
        array7(11) = "0000000550"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000006057"


       


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor10 & fech & "BO.txt"
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



    Function NotaDebitoBoleta4(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000009"
        array(1) = "ND"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000029906"
        array(9) = "0000000000"
        array(10) = "0000029906"
        array(11) = "0000000000"
        array(12) = "0000002987"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000032893"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB14-00000014"
        array(19) = "BB14"
        array(20) = "00000014"
        array(21) = "2USERE10            "


        'ITEMS

        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRATUITA  "
        array2(4) = "8"
        array2(5) = "C58-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0001"
        array2(8) = "0000001081"
        array2(9) = "0000000000"
        array2(10) = "0000001081"
        array2(11) = "0000000108"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001189"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000009786"
        array3(9) = "0000000000"
        array3(10) = "0000009786"
        array3(11) = "0000000978"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000010764"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000001166"
        array4(9) = "0000000000"
        array4(10) = "0000001166"
        array4(11) = "0000000116"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000001282"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000009316"
        array5(9) = "0000000000"
        array5(10) = "0000009316"
        array5(11) = "0000000931"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000010247"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000003336"
        array6(9) = "0000000000"
        array6(10) = "0000003336"
        array6(11) = "0000000333"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000003669"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000001667"
        array7(9) = "0000000000"
        array7(10) = "0000001667"
        array7(11) = "0000000166"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000001833"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000001330"
        array8(9) = "0000000000"
        array8(10) = "0000001330"
        array8(11) = "0000000133"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000001463"



        Dim array9(16) As String
        array9(0) = "0000000008"
        array9(2) = "BIEN      "
        array9(3) = "GRATUITA  "
        array9(4) = "8"
        array9(5) = "89657     "
        array9(6) = "Por proceso de homologacion                                                                                                                           "
        array9(7) = "0001"
        array9(8) = "0000002224"
        array9(9) = "0000000000"
        array9(10) = "0000002224"
        array9(11) = "0000000222"
        array9(12) = "0000000000"
        array9(13) = "000"
        array9(14) = "0000000000"
        array9(15) = "0000000000"
        array9(16) = "0000002446"



    


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path10 & remisor & "00" & nrc & "DOC" & cor11 & fech & "BO.txt"
        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4, tre5, acu5, tre6, acu6, tre7, acu7, tre8, acu8, tre9, acu9

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
        For Each value8 As String In array8
            tre8 = value8
            acu8 = acu8 + tre8
        Next
        sw.WriteLine(acu8)
        For Each value9 As String In array9
            tre9 = value9
            acu9 = acu9 + tre9
        Next
        sw.WriteLine(acu9)
        sw.Close()

        Return array

    End Function



End Class
