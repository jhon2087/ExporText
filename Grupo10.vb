Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Grupo10


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
    Dim path9 As String = "D:\GeneraDocs\Ventas_gratuitas_Boleta\"



    Function Boleta1items7(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000031069"
        array(9) = "0000000000"
        array(10) = "0000031069"
        array(11) = "0000000000"
        array(12) = "0000000000"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000031069"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB13"
        array(20) = "00000009"
        array(21) = "2016DE10            "


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
        array2(8) = "0000001211"
        array2(9) = "0000000000"
        array2(10) = "0000001211"
        array2(11) = "0000000000"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001211"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001956"
        array3(9) = "0000000000"
        array3(10) = "0000001956"
        array3(11) = "0000000000"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000001956"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004456"
        array4(9) = "0000000000"
        array4(10) = "0000004456"
        array4(11) = "0000000000"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000004456"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000004226"
        array5(9) = "0000000000"
        array5(10) = "0000004226"
        array5(11) = "0000000000"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000004226"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000008226"
        array6(9) = "0000000000"
        array6(10) = "0000008226"
        array6(11) = "0000000000"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000008226"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000005874"
        array7(9) = "0000000000"
        array7(10) = "0000005874"
        array7(11) = "0000000000"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000005874"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000005120"
        array8(9) = "0000000000"
        array8(10) = "0000005120"
        array8(11) = "0000000000"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000005120"




        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path9 & remisor & "00" & nrc & "DOC" & cor1 & fech & "FA.txt"
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



    Function Boleta2items2(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000003467"
        array(9) = "0000000000"
        array(10) = "0000003467"
        array(11) = "0000000000"
        array(12) = "0000000000"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000003467"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB13"
        array(20) = "00000010"
        array(21) = "2016DE10            "


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
        array2(8) = "0000001481"
        array2(9) = "0000000000"
        array2(10) = "0000001481"
        array2(11) = "0000000000"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001481"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001986"
        array3(9) = "0000000000"
        array3(10) = "0000001986"
        array3(11) = "0000000000"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000001986"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path9 & remisor & "00" & nrc & "DOC" & cor2 & fech & "FA.txt"
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



    Function Boleta3items5(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000003"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000017792"
        array(9) = "0000000000"
        array(10) = "0000017792"
        array(11) = "0000000000"
        array(12) = "0000000000"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000017792"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB13"
        array(20) = "00000012"
        array(21) = "2016DE10            "


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
        array2(8) = "0000001191"
        array2(9) = "0000000000"
        array2(10) = "0000001191"
        array2(11) = "0000000000"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001191"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001487"
        array3(9) = "0000000000"
        array3(10) = "0000001487"
        array3(11) = "0000000000"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000001487"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004847"
        array4(9) = "0000000000"
        array4(10) = "0000004847"
        array4(11) = "0000000000"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000004847"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000001846"
        array5(9) = "0000000000"
        array5(10) = "0000001846"
        array5(11) = "0000000000"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000001846"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000008421"
        array6(9) = "0000000000"
        array6(10) = "0000008421"
        array6(11) = "0000000000"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000008421"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path9 & remisor & "00" & nrc & "DOC" & cor3 & fech & "FA.txt"
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



    Function Boleta4items4(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000006"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000013821"
        array(9) = "0000000000"
        array(10) = "0000013821"
        array(11) = "0000000000"
        array(12) = "0000000000"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000013821"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB13"
        array(20) = "00000015"
        array(21) = "2016DE10            "


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
        array2(8) = "0000003144"
        array2(9) = "0000000000"
        array2(10) = "0000003144"
        array2(11) = "0000000000"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000003144"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000006144"
        array3(9) = "0000000000"
        array3(10) = "0000006144"
        array3(11) = "0000000000"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000006144"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000003147"
        array4(9) = "0000000000"
        array4(10) = "0000003147"
        array4(11) = "0000000000"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000003147"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000001386"
        array5(9) = "0000000000"
        array5(10) = "0000001386"
        array5(11) = "0000000000"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000001386"




        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path9 & remisor & "00" & nrc & "DOC" & cor4 & fech & "FA.txt"
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




    Function Boleta5items9(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000034897"
        array(9) = "0000000000"
        array(10) = "0000034897"
        array(11) = "0000000000"
        array(12) = "0000000000"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000034897"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB13"
        array(20) = "00000018"
        array(21) = "2016DE10            "


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
        array2(8) = "0000001044"
        array2(9) = "0000000000"
        array2(10) = "0000001044"
        array2(11) = "0000000000"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001044"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRATUITA  "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000007547"
        array3(9) = "0000000000"
        array3(10) = "0000007547"
        array3(11) = "0000000000"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000007547"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRATUITA  "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004155"
        array4(9) = "0000000000"
        array4(10) = "0000004155"
        array4(11) = "0000000000"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000004155"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRATUITA  "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000001234"
        array5(9) = "0000000000"
        array5(10) = "0000001234"
        array5(11) = "0000000000"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000001234"

        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRATUITA  "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000006566"
        array6(9) = "0000000000"
        array6(10) = "0000006566"
        array6(11) = "0000000000"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000006566"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRATUITA  "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000006910"
        array7(9) = "0000000000"
        array7(10) = "0000006910"
        array7(11) = "0000000000"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000006910"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRATUITA  "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000002210"
        array8(9) = "0000000000"
        array8(10) = "0000002210"
        array8(11) = "0000000000"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000002210"


        Dim array9(16) As String
        array9(0) = "0000000008"
        array9(2) = "BIEN      "
        array9(3) = "GRATUITA  "
        array9(4) = "8"
        array9(5) = "89657     "
        array9(6) = "Por proceso de homologacion                                                                                                                           "
        array9(7) = "0001"
        array9(8) = "0000001911"
        array9(9) = "0000000000"
        array9(10) = "0000001911"
        array9(11) = "0000000000"
        array9(12) = "0000000000"
        array9(13) = "000"
        array9(14) = "0000000000"
        array9(15) = "0000000000"
        array9(16) = "0000001911"


        Dim array10(16) As String
        array10(0) = "0000000009"
        array10(2) = "BIEN      "
        array10(3) = "GRATUITA  "
        array10(4) = "8"
        array10(5) = "89657     "
        array10(6) = "Por proceso de homologacion                                                                                                                           "
        array10(7) = "0001"
        array10(8) = "0000003320"
        array10(9) = "0000000000"
        array10(10) = "0000003320"
        array10(11) = "0000000000"
        array10(12) = "0000000000"
        array10(13) = "000"
        array10(14) = "0000000000"
        array10(15) = "0000000000"
        array10(16) = "0000003320"




        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path9 & remisor & "00" & nrc & "DOC" & cor5 & fech & "FA.txt"
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
End Class
