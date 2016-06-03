
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Grupo9
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
    Dim path8 As String = "D:\GeneraDocs\Ventas_inafectas_Boleta\"


    Function Boleta1items2(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000016"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000003167"
        array(9) = "0000000000"
        array(10) = "0000003167"
        array(11) = "0000000000"
        array(12) = "0000000317"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000003483"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB12"
        array(20) = "00000011"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000001211"
        array2(9) = "0000000000"
        array2(10) = "0000001211"
        array2(11) = "0000000121"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001332"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001956"
        array3(9) = "0000000000"
        array3(10) = "0000001956"
        array3(11) = "0000000195"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002151"





        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor1 & fech & "BO.txt"
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


    Function Boleta2items4(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000011849"
        array(9) = "0000000000"
        array(10) = "0000011849"
        array(11) = "0000000000"
        array(12) = "0000001183"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000013032"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB12"
        array(20) = "00000009"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000001211"
        array2(9) = "0000000000"
        array2(10) = "0000001211"
        array2(11) = "0000000121"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001332"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001956"
        array3(9) = "0000000000"
        array3(10) = "0000001956"
        array3(11) = "0000000195"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002151"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000004456"
        array4(9) = "0000000000"
        array4(10) = "0000004456"
        array4(11) = "0000000445"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000004901"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000004226"
        array5(9) = "0000000000"
        array5(10) = "0000004226"
        array5(11) = "0000000422"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000004648"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor2 & fech & "FA.txt"
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

    Function Boleta3items7(ByVal remisor As String, ByVal rcliente As String) As String()



        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000032841"
        array(9) = "0000000000"
        array(10) = "0000032841"
        array(11) = "0000000000"
        array(12) = "0000003281"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000036122"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB12"
        array(20) = "00000009"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000002229"
        array2(9) = "0000000000"
        array2(10) = "0000002229"
        array2(11) = "0000000222"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002451"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000006001"
        array3(9) = "0000000000"
        array3(10) = "0000006001"
        array3(11) = "0000000600"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000006601"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000006520"
        array4(9) = "0000000000"
        array4(10) = "0000006520"
        array4(11) = "0000000652"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000007172"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000007776"
        array5(9) = "0000000000"
        array5(10) = "0000007776"
        array5(11) = "0000000777"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000008553"


        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRABADO   "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000001587"
        array6(9) = "0000000000"
        array6(10) = "0000001587"
        array6(11) = "0000000158"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000001745"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRABADO   "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000006532"
        array7(9) = "0000000000"
        array7(10) = "0000006532"
        array7(11) = "0000000653"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000007185"


        Dim array8(16) As String
        array8(0) = "0000000007"
        array8(2) = "BIEN      "
        array8(3) = "GRABADO   "
        array8(4) = "8"
        array8(5) = "89657     "
        array8(6) = "Por proceso de homologacion                                                                                                                           "
        array8(7) = "0001"
        array8(8) = "0000002196"
        array8(9) = "0000000000"
        array8(10) = "0000002196"
        array8(11) = "0000000219"
        array8(12) = "0000000000"
        array8(13) = "000"
        array8(14) = "0000000000"
        array8(15) = "0000000000"
        array8(16) = "0000002415"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor3 & fech & "BO.txt"
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



    Function Boleta4items5(ByVal remisor As String, ByVal rcliente As String) As String()



        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000018974"
        array(9) = "0000000000"
        array(10) = "0000018974"
        array(11) = "0000000000"
        array(12) = "0000001896"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000020870"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB12"
        array(20) = "00000014"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000003891"
        array2(9) = "0000000000"
        array2(10) = "0000003891"
        array2(11) = "0000000389"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000004280"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000005121"
        array3(9) = "0000000000"
        array3(10) = "0000005121"
        array3(11) = "0000000512"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000005633"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000003365"
        array4(9) = "0000000000"
        array4(10) = "0000003365"
        array4(11) = "0000000336"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000003701"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000004442"
        array5(9) = "0000000000"
        array5(10) = "0000004442"
        array5(11) = "0000000444"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000004886"


        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRABADO   "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000002155"
        array6(9) = "0000000000"
        array6(10) = "0000002155"
        array6(11) = "0000000215"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000002370"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor4 & fech & "BO.txt"
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


    Function Boleta5items1(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "BO"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000004100"
        array(9) = "0000000000"
        array(10) = "0000004100"
        array(11) = "0000000000"
        array(12) = "0000000410"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000004510"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "BB12"
        array(20) = "00000017"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000004100"
        array2(9) = "0000000000"
        array2(10) = "0000004100"
        array2(11) = "0000000410"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000004510"

        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor5 & fech & "BO.txt"
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


    Function NotaCreditoBoleta1(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000016"
        array(1) = "NC"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000007123"
        array(9) = "0000000000"
        array(10) = "0000007123"
        array(11) = "0000000000"
        array(12) = "0000000712"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000007834"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB12-00000011"
        array(19) = "BB12"
        array(20) = "00000011"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000001211"
        array2(9) = "0000000000"
        array2(10) = "0000001211"
        array2(11) = "0000000121"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001332"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000001956"
        array3(9) = "0000000000"
        array3(10) = "0000001956"
        array3(11) = "0000000195"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002151"

        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000003956"
        array4(9) = "0000000000"
        array4(10) = "0000003956"
        array4(11) = "0000000395"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000004351"





        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor6 & fech & "BO.txt"
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



    Function NotaCreditoBoleta4(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "NC"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000021129"
        array(9) = "0000000000"
        array(10) = "0000021129"
        array(11) = "0000000000"
        array(12) = "0000004051"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000023240"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB12-00000014"
        array(19) = "BB12"
        array(20) = "00000014"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000003891"
        array2(9) = "0000000000"
        array2(10) = "0000003891"
        array2(11) = "0000000389"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000004280"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000005121"
        array3(9) = "0000000000"
        array3(10) = "0000005121"
        array3(11) = "0000000512"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000005633"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000003365"
        array4(9) = "0000000000"
        array4(10) = "0000003365"
        array4(11) = "0000000336"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000003701"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000004442"
        array5(9) = "0000000000"
        array5(10) = "0000004442"
        array5(11) = "0000000444"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000004886"


        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(2) = "BIEN      "
        array6(3) = "GRABADO   "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0001"
        array6(8) = "0000002155"
        array6(9) = "0000000000"
        array6(10) = "0000002155"
        array6(11) = "0000000215"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000002370"


        Dim array7(16) As String
        array7(0) = "0000000006"
        array7(2) = "BIEN      "
        array7(3) = "GRABADO   "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0001"
        array7(8) = "0000002155"
        array7(9) = "0000000000"
        array7(10) = "0000002155"
        array7(11) = "0000000215"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000002370"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor7 & fech & "BO.txt"
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


    Function NotaCreditoBoleta5(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "NC"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000009816"
        array(9) = "0000000000"
        array(10) = "0000009816"
        array(11) = "0000000000"
        array(12) = "0000000981"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000010797"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB12-00000017"
        array(19) = "BB12"
        array(20) = "00000017"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000006133"
        array2(9) = "0000000000"
        array2(10) = "0000006133"
        array2(11) = "0000000613"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000006746"


        Dim array3(16) As String
        array3(0) = "0000000001"
        array3(1) = "0000000002"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "C58-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000003683"
        array3(9) = "0000000000"
        array3(10) = "0000003683"
        array3(11) = "0000000368"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000004051"

        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor8 & fech & "BO.txt"
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

    Function NotaDebitoBoleta1(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000016"
        array(1) = "ND"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000001211"
        array(9) = "0000000000"
        array(10) = "0000001211"
        array(11) = "0000000000"
        array(12) = "0000000121"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000001332"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB12-00000011"
        array(19) = "BB12"
        array(20) = "00000011"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000001211"
        array2(9) = "0000000000"
        array2(10) = "0000001211"
        array2(11) = "0000000121"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001332"





        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor9 & fech & "BO.txt"
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



    Function NotaDebitoBoleta4(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "ND"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000016899"
        array(9) = "0000000000"
        array(10) = "0000016899"
        array(11) = "0000000000"
        array(12) = "0000001681"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000018500"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB12-00000014"
        array(19) = "BB12"
        array(20) = "00000014"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000003891"
        array2(9) = "0000000000"
        array2(10) = "0000003891"
        array2(11) = "0000000389"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000004280"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0001"
        array3(8) = "0000005121"
        array3(9) = "0000000000"
        array3(10) = "0000005121"
        array3(11) = "0000000512"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000005633"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0001"
        array4(8) = "0000003365"
        array4(9) = "0000000000"
        array4(10) = "0000003365"
        array4(11) = "0000000336"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000003701"


        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0001"
        array5(8) = "0000004442"
        array5(9) = "0000000000"
        array5(10) = "0000004442"
        array5(11) = "0000000444"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000004886"




        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor10 & fech & "BO.txt"
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




    Function NotaDebitoBoleta5(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "ND"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000009900"
        array(9) = "0000000000"
        array(10) = "0000009900"
        array(11) = "0000000000"
        array(12) = "0000000990"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000010890"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "BB12-00000017"
        array(19) = "BB12"
        array(20) = "00000017"
        array(21) = "20MO16DE            "


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
        array2(8) = "0000009900"
        array2(9) = "0000000000"
        array2(10) = "0000009900"
        array2(11) = "0000000990"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000010890"

        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path7 & remisor & "00" & nrc & "DOC" & cor11 & fech & "BO.txt"
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
 

End Class
