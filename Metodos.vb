Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Metodos


    Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
    Dim f1 As String = Replace(fecha, "/", "")
    Dim fech As String = Microsoft.VisualBasic.Right(f1, 6)
    Dim fpos As String = fech + 4
    Dim cor1 As String = "0000000001"
    Dim cor2 As String = "0000000002"
    Dim cor3 As String = "0000000003"
    Dim cor4 As String = "0000000004"
    Dim cor5 As String = "0000000005"
    Dim path As String = "D:\GeneraDocs\Ventas_grabadas_IGV\"


    Function FacturaItem1(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000007623"
        array(9) = "0000000000"
        array(10) = "0000007623"
        array(11) = "0000000000"
        array(12) = "0000003772"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000008995"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF11"
        array(20) = "00000009"
        array(21) = "USERDEMO            "


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
        array2(11) = "0000000218"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001429"


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
        array3(11) = "0000000352"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002308"


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
        array4(11) = "0000000802"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005258"

        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor1 & fech & "FA.txt"
        Dim sw As New System.IO.StreamWriter(fic)
        sw.WriteLine("3333")
        sw.Close()


        Dim tre As String, acu, tre2, acu2, tre3, acu3, tre4, acu4

        For Each value As String In array
            tre = value
            acu = acu + tre
        Next
        Dim sw4 As New System.IO.StreamWriter(fic)
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


    Function FacturaItem2(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000004665"
        array(9) = "0000000000"
        array(10) = "0000004665"
        array(11) = "0000000000"
        array(12) = "0000000839"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000005504"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF11"
        array(20) = "00000009"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "SVV-REE   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000003612"
        array2(9) = "0000000000"
        array2(10) = "0000003612"
        array2(11) = "0000000650"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000004262"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0004"
        array3(8) = "0000001053"
        array3(9) = "0000000000"
        array3(10) = "0000001053"
        array3(11) = "0000000189"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000001242"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor2 & fech & "FA.txt"
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

    Function FacturaItem3(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000005132"
        array(9) = "0000000000"
        array(10) = "0000005132"
        array(11) = "0000000000"
        array(12) = "0000000923"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000006055"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF11"
        array(20) = "00000010"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "CVF-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000005132"
        array2(9) = "0000000000"
        array2(10) = "0000005132"
        array2(11) = "0000000923"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000006055"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor3 & fech & "FA.txt"
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

    Function FacturaItem4(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000021286"
        array(9) = "0000000000"
        array(10) = "0000021286"
        array(11) = "0000000000"
        array(12) = "0000003757"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000025043"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF11"
        array(20) = "00000011"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "CVF-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000002133"
        array2(9) = "0000000000"
        array2(10) = "0000002133"
        array2(11) = "0000000383"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002516"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0004"
        array3(8) = "0000002562"
        array3(9) = "0000000000"
        array3(10) = "0000002562"
        array3(11) = "0000000389"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002951"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0004"
        array4(8) = "0000003362"
        array4(9) = "0000000000"
        array4(10) = "0000003362"
        array4(11) = "0000000605"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000003967"

        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0004"
        array5(8) = "0000005687"
        array5(9) = "0000000000"
        array5(10) = "0000005687"
        array5(11) = "0000001023"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000006710"


        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(1) = "0000000001"
        array6(2) = "BIEN      "
        array6(3) = "GRABADO   "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0004"
        array6(8) = "0000007542"
        array6(9) = "0000000000"
        array6(10) = "0000007542"
        array6(11) = "0000001357"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000008899"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor4 & fech & "FA.txt"
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

    Function FacturaItem5(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000015994"
        array(9) = "0000000000"
        array(10) = "0000015994"
        array(11) = "0000000000"
        array(12) = "0000002818"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000018812"
        array(16) = "1"
        array(17) = "NA"
        array(18) = "0000000000000"
        array(19) = "FF11"
        array(20) = "00000012"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "CVF-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000008834"
        array2(9) = "0000000000"
        array2(10) = "0000008834"
        array2(11) = "0000001590"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000010424"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0004"
        array3(8) = "0000003141"
        array3(9) = "0000000000"
        array3(10) = "0000003141"
        array3(11) = "0000000565"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000003706"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0004"
        array4(8) = "0000001368"
        array4(9) = "0000000000"
        array4(10) = "0000001368"
        array4(11) = "0000000246"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000001614"

        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0004"
        array5(8) = "0000002651"
        array5(9) = "0000000000"
        array5(10) = "0000002651"
        array5(11) = "0000000417"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000003068"

        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor5 & fech & "FA.txt"
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


    Function NotaCreditoFactura2(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000007623"
        array(9) = "0000000000"
        array(10) = "0000007623"
        array(11) = "0000000000"
        array(12) = "0000003772"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000008995"
        array(16) = "1"
        array(17) = "NC"
        array(18) = "FF11-00000009"
        array(19) = "FF11"
        array(20) = "00000007"
        array(21) = "USERDEMO            "


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
        array2(11) = "0000000218"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000001429"


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
        array3(11) = "0000000352"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002308"


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
        array4(11) = "0000000802"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000005258"

    

        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor1 & fech & "FA.txt"
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
        sw.Close()

        Return array

    End Function

    Function NotaCreditoFactura3(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000007147"
        array(9) = "0000000000"
        array(10) = "0000007147"
        array(11) = "0000000000"
        array(12) = "0000000923"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000008432"
        array(16) = "1"
        array(17) = "NC"
        array(18) = "FF11-00000010"
        array(19) = "FF11"
        array(20) = "00000009"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "CVF-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000005132"
        array2(9) = "0000000000"
        array2(10) = "0000005132"
        array2(11) = "0000001285"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000006055"


        Dim array3(16) As String
        array3(0) = "0000000001"
        array3(1) = "0000000001"
        array3(2) = "SERVICIO  "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "CVF-RRF   "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0004"
        array3(8) = "0000002015"
        array3(9) = "0000000000"
        array3(10) = "0000002015"
        array3(11) = "0000000362"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002377"




        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor3 & fech & "FA.txt"
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


    Function NotaCreditoFactura4(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000022785"
        array(9) = "0000000000"
        array(10) = "0000022785"
        array(11) = "0000000000"
        array(12) = "0000004026"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000026711"
        array(16) = "1"
        array(17) = "NC"
        array(18) = "FF11-00000011"
        array(19) = "FF11"
        array(20) = "00000011"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "CVF-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000002133"
        array2(9) = "0000000000"
        array2(10) = "0000002133"
        array2(11) = "0000000383"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002516"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0004"
        array3(8) = "0000002562"
        array3(9) = "0000000000"
        array3(10) = "0000002562"
        array3(11) = "0000000389"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002951"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0004"
        array4(8) = "0000003362"
        array4(9) = "0000000000"
        array4(10) = "0000003362"
        array4(11) = "0000000605"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000003967"

        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0004"
        array5(8) = "0000005687"
        array5(9) = "0000000000"
        array5(10) = "0000005687"
        array5(11) = "0000001023"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000006710"


        Dim array6(16) As String
        array6(0) = "0000000005"
        array6(1) = "0000000001"
        array6(2) = "BIEN      "
        array6(3) = "GRABADO   "
        array6(4) = "8"
        array6(5) = "89657     "
        array6(6) = "Por proceso de homologacion                                                                                                                           "
        array6(7) = "0004"
        array6(8) = "0000007542"
        array6(9) = "0000000000"
        array6(10) = "0000007542"
        array6(11) = "0000001357"
        array6(12) = "0000000000"
        array6(13) = "000"
        array6(14) = "0000000000"
        array6(15) = "0000000000"
        array6(16) = "0000008899"


        Dim array7(16) As String
        array7(0) = "0000000005"
        array7(1) = "0000000001"
        array7(2) = "BIEN      "
        array7(3) = "GRABADO   "
        array7(4) = "8"
        array7(5) = "89657     "
        array7(6) = "Por proceso de homologacion                                                                                                                           "
        array7(7) = "0004"
        array7(8) = "0000001499"
        array7(9) = "0000000000"
        array7(10) = "0000001499"
        array7(11) = "0000000269"
        array7(12) = "0000000000"
        array7(13) = "000"
        array7(14) = "0000000000"
        array7(15) = "0000000000"
        array7(16) = "0000001768"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor4 & fech & "FA.txt"
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

    Function NotaDebitoFactura2(ByVal remisor As String, ByVal rcliente As String) As String()


        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000003612"
        array(9) = "0000000000"
        array(10) = "0000003612"
        array(11) = "0000000000"
        array(12) = "0000000650"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000004262"
        array(16) = "1"
        array(17) = "ND"
        array(18) = "FF11-00000009"
        array(19) = "ND11"
        array(20) = "00000009"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "SVV-REE   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000003612"
        array2(9) = "0000000000"
        array2(10) = "0000003612"
        array2(11) = "0000000650"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000004262"



        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor2 & fech & "FA.txt"
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

    Function NotaDebitoFactura3(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000005132"
        array(9) = "0000000000"
        array(10) = "0000005132"
        array(11) = "0000000000"
        array(12) = "0000000923"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000006055"
        array(16) = "1"
        array(17) = "ND"
        array(18) = "FF11-00000010"
        array(19) = "FF11"
        array(20) = "00000010"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "CVF-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000005132"
        array2(9) = "0000000000"
        array2(10) = "0000005132"
        array2(11) = "0000000923"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000006055"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor3 & fech & "FA.txt"
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



    Function NotaDebitoFactura4(ByVal remisor As String, ByVal rcliente As String) As String()

        Dim array(21) As String
        array(0) = "0000000001"
        array(1) = "FA"
        array(2) = "00"
        array(3) = remisor
        array(4) = rcliente
        array(5) = fech
        array(6) = fpos
        array(7) = "PEN"
        array(8) = "0000008057"
        array(9) = "0000000000"
        array(10) = "0000008057"
        array(11) = "0000000000"
        array(12) = "0000002400"
        array(13) = "0000000000"
        array(14) = "0000000000"
        array(15) = "0000016144"
        array(16) = "1"
        array(17) = "ND"
        array(18) = "FF11-00000011"
        array(19) = "FF11"
        array(20) = "00000011"
        array(21) = "USERDEMO            "


        Dim array2(16) As String
        array2(0) = "0000000001"
        array2(1) = "0000000001"
        array2(2) = "SERVICIO  "
        array2(3) = "GRABADO   "
        array2(4) = "8"
        array2(5) = "CVF-RRF   "
        array2(6) = "Por proceso de homologacion                                                                                                                           "
        array2(7) = "0004"
        array2(8) = "0000002133"
        array2(9) = "0000000000"
        array2(10) = "0000002133"
        array2(11) = "0000000383"
        array2(12) = "0000000000"
        array2(13) = "000"
        array2(14) = "0000000000"
        array2(15) = "0000000000"
        array2(16) = "0000002516"


        Dim array3(16) As String
        array3(0) = "0000000002"
        array3(1) = "0000000001"
        array3(2) = "BIEN      "
        array3(3) = "GRABADO   "
        array3(4) = "8"
        array3(5) = "89657     "
        array3(6) = "Por proceso de homologacion                                                                                                                           "
        array3(7) = "0004"
        array3(8) = "0000002562"
        array3(9) = "0000000000"
        array3(10) = "0000002562"
        array3(11) = "0000000389"
        array3(12) = "0000000000"
        array3(13) = "000"
        array3(14) = "0000000000"
        array3(15) = "0000000000"
        array3(16) = "0000002951"


        Dim array4(16) As String
        array4(0) = "0000000003"
        array4(1) = "0000000001"
        array4(2) = "BIEN      "
        array4(3) = "GRABADO   "
        array4(4) = "8"
        array4(5) = "89657     "
        array4(6) = "Por proceso de homologacion                                                                                                                           "
        array4(7) = "0004"
        array4(8) = "0000003362"
        array4(9) = "0000000000"
        array4(10) = "0000003362"
        array4(11) = "0000000605"
        array4(12) = "0000000000"
        array4(13) = "000"
        array4(14) = "0000000000"
        array4(15) = "0000000000"
        array4(16) = "0000003967"

        Dim array5(16) As String
        array5(0) = "0000000004"
        array5(1) = "0000000001"
        array5(2) = "BIEN      "
        array5(3) = "GRABADO   "
        array5(4) = "8"
        array5(5) = "89657     "
        array5(6) = "Por proceso de homologacion                                                                                                                           "
        array5(7) = "0004"
        array5(8) = "0000005687"
        array5(9) = "0000000000"
        array5(10) = "0000005687"
        array5(11) = "0000001023"
        array5(12) = "0000000000"
        array5(13) = "000"
        array5(14) = "0000000000"
        array5(15) = "0000000000"
        array5(16) = "0000006710"


        Dim nrc As Integer = CInt(Int((9 * Rnd()) + 1))
        Dim fic As String = path & remisor & "00" & nrc & "DOC" & cor4 & fech & "FA.txt"
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
