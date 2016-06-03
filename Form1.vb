Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Form1

    Dim path As String = "C:\inbox\"
    Dim fmt As String = "0000000000.##"
    Dim cnt As String = "0000.##"


    Public Sub Limpiar(ByVal Grupo As Windows.Forms.GroupBox)
        Dim lmp As Object
        For Each lmp In Grupo.Controls
            If lmp.GetType Is GetType(System.Windows.Forms.TextBox) Then
                lmp.Clear()
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub



    Function CrearTxt()

        'Dim intValue As Integer = CInt(TextBox26.Text)
        'Dim correlativo As String = intValue.ToString(fmt)


        Dim fic As String = path + TextBox1.Text + TextBox2.Text + TextBox25.Text + TextBox26.Text + TextBox27.Text + "BO.txt"
        Dim str As New System.IO.StreamWriter(fic)
        Dim linea1 As String, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14,
            item15, item16, item17, item18, item19, item20

        linea1 = TextBox4.Text + TextBox3.Text + TextBox29.Text + TextBox30.Text + TextBox33.Text + TextBox32.Text +
        TextBox31.Text + TextBox28.Text + TextBox37.Text + TextBox36.Text + TextBox35.Text + TextBox34.Text + TextBox41.Text +
        TextBox40.Text + TextBox39.Text + TextBox38.Text + TextBox45.Text + TextBox44.Text + TextBox43.Text + TextBox42.Text +
        TextBox49.Text + TextBox48.Text


        item1 = TextBox67.Text + TextBox66.Text + TextBox65.Text + TextBox64.Text + TextBox63.Text + TextBox62.Text +
        TextBox61.Text + TextBox60.Text + TextBox59.Text + TextBox58.Text + TextBox57.Text + TextBox56.Text + TextBox55.Text +
        TextBox54.Text + TextBox53.Text + TextBox52.Text + TextBox5.Text

        item2 = TextBox22.Text + TextBox21.Text + TextBox20.Text + TextBox19.Text + TextBox18.Text + TextBox17.Text +
        TextBox16.Text + TextBox15.Text + TextBox14.Text + TextBox13.Text + TextBox12.Text + TextBox11.Text + TextBox10.Text +
        TextBox9.Text + TextBox8.Text + TextBox7.Text + TextBox6.Text

        item3 = TextBox78.Text + TextBox77.Text + TextBox76.Text + TextBox75.Text + TextBox74.Text + TextBox73.Text +
        TextBox72.Text + TextBox71.Text + TextBox70.Text + TextBox69.Text + TextBox68.Text + TextBox51.Text + TextBox50.Text +
        TextBox47.Text + TextBox46.Text + TextBox24.Text + TextBox23.Text

        item4 = TextBox95.Text + TextBox94.Text + TextBox93.Text + TextBox92.Text + TextBox91.Text + TextBox90.Text +
        TextBox89.Text + TextBox88.Text + TextBox87.Text + TextBox86.Text + TextBox85.Text + TextBox84.Text + TextBox83.Text +
        TextBox82.Text + TextBox81.Text + TextBox80.Text + TextBox79.Text

        item5 = TextBox112.Text + TextBox111.Text + TextBox110.Text + TextBox109.Text + TextBox108.Text + TextBox107.Text +
        TextBox106.Text + TextBox105.Text + TextBox104.Text + TextBox103.Text + TextBox102.Text + TextBox101.Text + TextBox100.Text +
        TextBox99.Text + TextBox98.Text + TextBox97.Text + TextBox96.Text

        item6 = TextBox129.Text + TextBox128.Text + TextBox127.Text + TextBox126.Text + TextBox125.Text + TextBox124.Text +
        TextBox123.Text + TextBox122.Text + TextBox121.Text + TextBox120.Text + TextBox119.Text + TextBox118.Text + TextBox117.Text +
        TextBox116.Text + TextBox115.Text + TextBox114.Text + TextBox113.Text

        item7 = TextBox146.Text + TextBox145.Text + TextBox144.Text + TextBox143.Text + TextBox142.Text + TextBox141.Text +
        TextBox140.Text + TextBox139.Text + TextBox138.Text + TextBox137.Text + TextBox136.Text + TextBox135.Text + TextBox134.Text +
        TextBox133.Text + TextBox132.Text + TextBox131.Text + TextBox130.Text

        item8 = TextBox163.Text + TextBox162.Text + TextBox161.Text + TextBox160.Text + TextBox159.Text + TextBox158.Text +
        TextBox157.Text + TextBox156.Text + TextBox155.Text + TextBox154.Text + TextBox153.Text + TextBox152.Text + TextBox151.Text +
        TextBox150.Text + TextBox149.Text + TextBox148.Text + TextBox147.Text


        item9 = TextBox180.Text + TextBox179.Text + TextBox178.Text + TextBox177.Text + TextBox176.Text + TextBox175.Text +
        TextBox174.Text + TextBox173.Text + TextBox172.Text + TextBox171.Text + TextBox170.Text + TextBox169.Text + TextBox168.Text +
        TextBox167.Text + TextBox166.Text + TextBox165.Text + TextBox164.Text



        item10 = TextBox197.Text + TextBox196.Text + TextBox195.Text + TextBox194.Text + TextBox193.Text + TextBox192.Text +
       TextBox191.Text + TextBox190.Text + TextBox189.Text + TextBox188.Text + TextBox187.Text + TextBox186.Text + TextBox185.Text +
       TextBox184.Text + TextBox183.Text + TextBox182.Text + TextBox181.Text

        item11 = TextBox214.Text + TextBox213.Text + TextBox212.Text + TextBox211.Text + TextBox210.Text + TextBox209.Text +
       TextBox208.Text + TextBox207.Text + TextBox206.Text + TextBox205.Text + TextBox204.Text + TextBox203.Text + TextBox202.Text +
       TextBox201.Text + TextBox200.Text + TextBox199.Text + TextBox198.Text

        item12 = TextBox231.Text + TextBox230.Text + TextBox229.Text + TextBox228.Text + TextBox227.Text + TextBox226.Text +
       TextBox225.Text + TextBox224.Text + TextBox223.Text + TextBox222.Text + TextBox221.Text + TextBox220.Text + TextBox219.Text +
       TextBox218.Text + TextBox217.Text + TextBox216.Text + TextBox215.Text


        item13 = TextBox248.Text + TextBox247.Text + TextBox246.Text + TextBox245.Text + TextBox244.Text + TextBox243.Text +
       TextBox242.Text + TextBox241.Text + TextBox240.Text + TextBox239.Text + TextBox238.Text + TextBox237.Text + TextBox236.Text +
       TextBox235.Text + TextBox234.Text + TextBox233.Text + TextBox232.Text

        item14 = TextBox265.Text + TextBox264.Text + TextBox263.Text + TextBox262.Text + TextBox261.Text + TextBox260.Text +
       TextBox259.Text + TextBox258.Text + TextBox257.Text + TextBox256.Text + TextBox255.Text + TextBox254.Text + TextBox253.Text +
       TextBox252.Text + TextBox251.Text + TextBox250.Text + TextBox249.Text

        item15 = TextBox282.Text + TextBox281.Text + TextBox280.Text + TextBox279.Text + TextBox278.Text + TextBox277.Text +
       TextBox276.Text + TextBox275.Text + TextBox274.Text + TextBox273.Text + TextBox272.Text + TextBox271.Text + TextBox270.Text +
       TextBox269.Text + TextBox268.Text + TextBox267.Text + TextBox266.Text

        item16 = TextBox299.Text + TextBox298.Text + TextBox297.Text + TextBox296.Text + TextBox295.Text + TextBox294.Text +
       TextBox293.Text + TextBox292.Text + TextBox291.Text + TextBox290.Text + TextBox289.Text + TextBox288.Text + TextBox287.Text +
       TextBox286.Text + TextBox285.Text + TextBox284.Text + TextBox283.Text

        item17 = TextBox316.Text + TextBox315.Text + TextBox314.Text + TextBox313.Text + TextBox312.Text + TextBox311.Text +
       TextBox310.Text + TextBox309.Text + TextBox308.Text + TextBox307.Text + TextBox306.Text + TextBox305.Text + TextBox304.Text +
       TextBox303.Text + TextBox302.Text + TextBox301.Text + TextBox300.Text

        item18 = TextBox333.Text + TextBox332.Text + TextBox331.Text + TextBox330.Text + TextBox329.Text + TextBox328.Text +
       TextBox327.Text + TextBox326.Text + TextBox325.Text + TextBox324.Text + TextBox323.Text + TextBox322.Text + TextBox321.Text +
       TextBox320.Text + TextBox319.Text + TextBox318.Text + TextBox317.Text


        item19 = TextBox350.Text + TextBox349.Text + TextBox348.Text + TextBox347.Text + TextBox346.Text + TextBox345.Text +
       TextBox344.Text + TextBox343.Text + TextBox342.Text + TextBox341.Text + TextBox340.Text + TextBox339.Text + TextBox338.Text +
       TextBox337.Text + TextBox336.Text + TextBox335.Text + TextBox334.Text


        item20 = TextBox367.Text + TextBox366.Text + TextBox365.Text + TextBox364.Text + TextBox363.Text + TextBox362.Text +
       TextBox361.Text + TextBox360.Text + TextBox359.Text + TextBox358.Text + TextBox357.Text + TextBox356.Text + TextBox355.Text +
       TextBox354.Text + TextBox353.Text + TextBox352.Text + TextBox351.Text



        str.WriteLine(linea1)
        str.WriteLine(item1)
        str.WriteLine(item2)
        str.WriteLine(item3)
        str.WriteLine(item4)
        str.WriteLine(item5)
        str.WriteLine(item6)
        str.WriteLine(item7)
        str.WriteLine(item8)
        str.WriteLine(item9)
        str.WriteLine(item10)
        str.WriteLine(item11)
        str.WriteLine(item12)
        str.WriteLine(item13)
        str.WriteLine(item14)
        str.WriteLine(item15)
        str.WriteLine(item16)
        str.WriteLine(item17)
        str.WriteLine(item18)
        str.WriteLine(item19)
        str.WriteLine(item20)
        str.Close()

        MsgBox("EL ARCHIVO A SIDO CREADO EN LA RUTA  " + path)

        Limpiar(Me.GroupBox1) 'donde GroupBox1 es el valor de la propiedad name del GroupBox que contiene los textbox
        Limpiar(Me.GroupBox2)
        Limpiar(Me.GroupBox3)
        Limpiar(Me.GroupBox4)
        Limpiar(Me.GroupBox5)
        Limpiar(Me.GroupBox6)
        Limpiar(Me.GroupBox7)
        Limpiar(Me.GroupBox8)
        Limpiar(Me.GroupBox9)
        Limpiar(Me.GroupBox10)
        Limpiar(Me.GroupBox11)
        Limpiar(Me.GroupBox12)
        Limpiar(Me.GroupBox13)
        Limpiar(Me.GroupBox14)
        Limpiar(Me.GroupBox15)
        Limpiar(Me.GroupBox16)
        Limpiar(Me.GroupBox17)
        Limpiar(Me.GroupBox18)
        Limpiar(Me.GroupBox19)
        Limpiar(Me.GroupBox20)

        Limpiar(Me.GroupBox12)
        Limpiar(Me.GroupBox12)



    End Function





    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        CrearTxt()
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        Me.Close()

    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class

