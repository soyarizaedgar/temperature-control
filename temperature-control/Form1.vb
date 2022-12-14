Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
    End Sub

    Function SEND(action As Char, pin As Integer)
        SerialPort1.Open()
        SerialPort1.WriteLine(action)
        SerialPort1.WriteLine(pin)
        SerialPort1.WriteLine("/")
        SerialPort1.Close()
    End Function

    Function READ_TEMP() As Decimal
        SerialPort1.Open()
        SerialPort1.WriteLine("T")
        Dim temp As Decimal = Val(SerialPort1.ReadLine())
        SerialPort1.Close()
        Return temp
    End Function

    Function STATE_IND(letter As Char)
        If letter = "F" Then
            ind_fan.BackColor = BackColor.LimeGreen
            ind_fan.Text = "ON"
            ind_lamp.BackColor = BackColor.Red
            ind_lamp.Text = "OFF"
        ElseIf letter = "L" Then
            ind_fan.BackColor = BackColor.Red
            ind_fan.Text = "OFF"
            ind_lamp.BackColor = BackColor.LimeGreen
            ind_lamp.Text = "ON"
        ElseIf letter = "B" Then
            ind_fan.BackColor = BackColor.Red
            ind_fan.Text = "OFF"
            ind_lamp.BackColor = BackColor.Red
            ind_lamp.Text = "OFF"
        End If
    End Function

    Function CLOSE_ALL()
        SEND("A", 2)
        SEND("A", 3)
        STATE_IND("B")
    End Function

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        If btnstart.BackColor = BackColor.Red Then
            btnstart.BackColor = BackColor.Green
            Timer1.Enabled = True
        Else
            btnstart.BackColor = BackColor.Red
            Timer1.Enabled = False
            CLOSE_ALL()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim temp As Decimal = READ_TEMP()
        Dim sp_temp As Double = set_point.Value
        Dim range As Decimal = 2

        curr_temp.Text = temp

        If temp >= sp_temp + range Then
            SEND("A", 3)    'TURN OFF LAMP
            SEND("E", 2)    'TURN ON FAN
            STATE_IND("F")
        ElseIf temp <= sp_temp - range Then
            SEND("A", 2)    'TRUN OFF FAN
            SEND("E", 3)    'TURN ON LAMP
            STATE_IND("L")
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        CLOSE_ALL()
        Me.Close()
    End Sub

    Private Sub btn_com_Click(sender As Object, e As EventArgs) Handles btn_com.Click
        SerialPort1.PortName = port_box.Text
    End Sub
End Class
