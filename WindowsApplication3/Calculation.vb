Public Class Calculation




    Public Sub Output(ByVal x As Double, ByVal y1 As Double, ByVal y2 As Double)

        If y1 < 0 Then
            'Chart1.Series(0).Points.AddXY(Math.Sqrt(2 * StartH / g), 0)
            'EndSim = True
        Else
            Console.WriteLine("Time: " + CStr(x) + " Height: " + CStr(y1) + " Velocity: " + CStr(y2))
            Chart1.Series(0).Points.AddXY(x, y1)
        End If

    End Sub
    Public Function LuchtDichtheid(ByVal height)

        height /= 10 ^ 3


        Select Case height
            Case 0 To 12
                Return 1.3
            Case 13 To 30
                Return 1 * 10 ^ -1
            Case 31 To 45
                Return 1 * 10 * -2
            Case 46 To 70
                Return 1 * 10 ^ -3
            Case 71 To 80
                Return 1 * 10 ^ -5
            Case 81 To 150
                Return 1 * 10 ^ -7
            Case 151 To 200
                Return 1 * 10 ^ -9
            Case 201 To 300
                Return 1 * 10 ^ -11
            Case 301 To 400
                Return 1 * 10 ^ -13
            Case Is > 401
                Return 1 * 10 ^ -16
            Case Else
                Return 0
        End Select

    End Function








    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Setting up graph
        Chart1.Titles.Add("Val van een bal")
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("Default")

        With Chart1.ChartAreas("Default")
            .AxisX.Title = "Tijd in secondes"
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = "Hoogte in meters"
        End With

        Chart1.Series.Clear()
        Chart1.Series.Add("Hoogte")
        Chart1.Series("Hoogte").Color = Color.Red
        Chart1.Series("Hoogte").ChartType = DataVisualization.Charting.SeriesChartType.Line

        'Simulation(False)

        'For t = 0 To Duratie Step dt

        '    Output(t, h, v)

        '    Dim Fwl As Double = 0.5 * LuchtDichtheid(h) * 0.47 * Area * v ^ 2
        '    Dim Fres As Double = Fg - Fwl
        '    Dim a As Double = Fres / m
        '    'Dim dv As Double = a * dt
        '    dh = v * dh
        '    v = v + a
        '    h = h - v


        '    If h < 0 Then
        '        ' Exit For
        '    End If

        'Next
        'Console.WriteLine("Done")
    End Sub



    Public Sub Simulation(ByVal Limited)




        'Inputs
        Dim r As Double = CDbl(Input.tbRadius.Text)
        Console.WriteLine(r)
        Dim h As Double = CDbl(Input.tbHeight.Text)
        Console.WriteLine(h)
        Dim dt As Double = 1
        Dim Duratie As Double = CDbl(Input.tbCycles.Text)
        Dim Rho As Double = CDbl(Input.Density)
        Console.WriteLine(Rho)
        'Dim t As Double = 0
        Dim dh As Double = 1
        Dim v As Double = 0
        'Dim Limited As Boolean = False


        'Constants
        Dim G As Double = 6.67484 * 10 ^ -11

        'Caluculated


        Dim Volume As Double = (4 / 3) * Math.PI * r ^ 3 'Volume
        Dim m As Double = Rho * Volume 'Mass
        Dim Fg As Double = G * (5.972 * (10 ^ 24)) * m / ((6.371 * 10 ^ 6 + h) ^ 2) 'Gravitational force


        Dim Area As Double = Math.PI * r ^ 2 'Area
        'Dim Fz As Double = m * 9.81







        If Limited Then
            For t As Double = 0 To Duratie Step dt

                Output(t, h, v)
                'Dim Fg As Double = (G * (5.972 * 10 ^ 24) * m) / ((6.371 * 10 ^ 6 + h) ^ 2)
                Dim Fwl As Double = 0.5 * LuchtDichtheid(h) * 0.34 * Area * v ^ 2
                Console.WriteLine(CStr(LuchtDichtheid(h)))
                'Dim Fwl As Double = 0.37 * Area * (v ^ 2)
                'Dim Fwl As Double = 99999
                'Console.WriteLine("Luchtweerstand is " + CStr(Fwl))
                Dim Fres As Double = Fg - Fwl
                Dim a As Double = Fres / m
                Dim dv As Double = a * dt
                v += dv

                dh = v * dh
                h -= v


                If h < 0 Then
                    Exit For
                End If

            Next
            Console.WriteLine("Done")


        Else
            Dim t As Double = 0
            Do Until 0 > h
                'Output(t, h, v)
                ''Dim Fg As Double = (G * (5.972 * 10 ^ 24) * m) / ((6.371 * 10 ^ 6 + h) ^ 2)
                'Dim Fwl As Double = 0.5 * LuchtDichtheid(h) * 0.47 * Area * v ^ 2
                ''Console.WriteLine("Luchtweerstand is " + CStr(Fwl))
                'Dim Fres As Double = Fg - Fwl
                'Dim a As Double = Fres / m
                ''Dim dv As Double = a * dt
                'dh = v * dh
                'v += a
                'h -= v
                ''If h < 0 Then
                ''    ' Exit For
                ''End If

                't += 1

                Output(t, h, v)
                'Dim Fg As Double = (G * (5.972 * 10 ^ 24) * m) / ((6.371 * 10 ^ 6 + h) ^ 2)
                Dim Fwl As Double = 0.5 * LuchtDichtheid(h) * 0.34 * Area * v ^ 2
                Console.WriteLine(CStr(LuchtDichtheid(h)))
                'Dim Fwl As Double = 0.37 * Area * (v ^ 2)
                'Dim Fwl As Double = 99999
                'Console.WriteLine("Luchtweerstand is " + CStr(Fwl))
                Dim Fres As Double = Fg - Fwl
                Dim a As Double = Fres / m
                Dim dv As Double = a * dt
                v += dv

                dh = v * dh
                h -= v


                If h < 0 Then
                    Exit Do
                End If

                t += 1


            Loop


        End If

    End Sub
End Class
