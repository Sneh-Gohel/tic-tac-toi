Imports System.Linq.Expressions

Public Class Form2
    Dim player As Integer
    Dim player1_win_count, player1_lost_count, player_draw_count As Integer
    Dim btn1player, btn2player, btn3player, btn4player, btn5player, btn6player, btn7player, btn8player, btn9player As Integer
    Dim t1, t2, t3, t4, t5, t6, t7, t8, t9 As Boolean
    Dim ans As Boolean = False
    Public sound As Boolean = True
    Function draw_msg()
        MessageBox.Show("Match is draw!!!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information)
        all_btn_disable()
        btn_player_remover()
        start.Text = "Restart"
        start.Enabled = True
        easy.Enabled = True
        medium.Enabled = True
        hard.Enabled = True
        t1 = False
        t2 = False
        t3 = False
        t4 = False
        t5 = False
        t6 = False
        t7 = False
        t8 = False
        t9 = False
        player_draw_count += 1
        label_draw_count.Text = player_draw_count
    End Function
    Function cpu_text_writer()
        If Button1.Enabled = False And t1 = True Then
            t1 = False
            Button1.Text = "X"
        ElseIf Button2.Enabled = False And t2 = True Then
            t2 = False
            Button2.Text = "X"
        ElseIf Button3.Enabled = False And t3 = True Then
            t3 = False
            Button3.Text = "X"
        ElseIf Button4.Enabled = False And t4 = True Then
            t4 = False
            Button4.Text = "X"
        ElseIf Button5.Enabled = False And t5 = True Then
            t5 = False
            Button5.Text = "X"
        ElseIf Button6.Enabled = False And t6 = True Then
            t6 = False
            Button6.Text = "X"
        ElseIf Button7.Enabled = False And t7 = True Then
            t7 = False
            Button7.Text = "X"
        ElseIf Button8.Enabled = False And t8 = True Then
            t8 = False
            Button8.Text = "X"
        ElseIf Button9.Enabled = False And t9 = True Then
            t9 = False
            Button9.Text = "X"
        End If
    End Function
    Function btn_text_remover()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
    End Function
    Private Sub easy_Click(sender As Object, e As EventArgs) Handles easy.Click
        easy.BackColor = Color.Blue
        If medium.BackColor = Color.Blue Then
            medium.BackColor = Color.Red
        ElseIf hard.BackColor = Color.Blue Then
            hard.BackColor = Color.Red
        End If
    End Sub
    Private Sub medium_Click(sender As Object, e As EventArgs) Handles medium.Click
        medium.BackColor = Color.Blue
        If easy.BackColor = Color.Blue Then
            easy.BackColor = Color.Red
        ElseIf hard.BackColor = Color.Blue Then
            hard.BackColor = Color.Red
        End If
    End Sub
    Private Sub hard_Click(sender As Object, e As EventArgs) Handles hard.Click
        hard.BackColor = Color.Blue
        If easy.BackColor = Color.Blue Then
            easy.BackColor = Color.Red
        ElseIf medium.BackColor = Color.Blue Then
            medium.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form4.Show()
        Me.Close()
    End Sub

    Function all_btn_disable()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Function
    Function all_btn_enable()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        t1 = True
        t2 = True
        t3 = True
        t4 = True
        t5 = True
        t6 = True
        t7 = True
        t8 = True
        t9 = True
    End Function
    Function btn_player_remover()
        btn1player = 0
        btn2player = 0
        btn3player = 0
        btn4player = 0
        btn5player = 0
        btn6player = 0
        btn7player = 0
        btn8player = 0
        btn9player = 0
    End Function
    Function print_msg()
        If player = 1 Then
            MessageBox.Show("player1 is winner!!!", "Congratulation", MessageBoxButtons.OK)
            player1_win_count = player1_win_count + 1
            label_win_count.Text = player1_win_count
        ElseIf player = 2 Then
            MessageBox.Show("player2 is winner!!!", "Congratulation", MessageBoxButtons.OK)
            player1_lost_count = player1_lost_count + 1
            label_lost_count.Text = player1_lost_count
        End If
        all_btn_disable()
        btn_player_remover()
        start.Text = "Restart"
        start.Enabled = True
        easy.Enabled = True
        medium.Enabled = True
        hard.Enabled = True
        t1 = False
        t2 = False
        t3 = False
        t4 = False
        t5 = False
        t6 = False
        t7 = False
        t8 = False
        t9 = False
        ans = True
    End Function
    Function cpu_player()
        If Button1.Enabled = True And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Button1.Enabled = False
            btn1player = 2
            Button1.Text = "X"
        ElseIf Button1.Enabled = False And Button2.Enabled = True And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Button2.Enabled = False
            btn2player = 2
            Button2.Text = "X"
        ElseIf Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = True And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Button3.Enabled = False
            btn3player = 2
            Button3.Text = "X"
        ElseIf Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = True And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Button4.Enabled = False
            btn4player = 2
            Button4.Text = "X"
        ElseIf Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = True And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Button5.Enabled = False
            btn5player = 2
            Button5.Text = "X"
        ElseIf Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = True And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Button6.Enabled = False
            btn6player = 2
            Button6.Text = "X"
        ElseIf Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = True And Button8.Enabled = False And Button9.Enabled = False Then
            Button7.Enabled = False
            btn7player = 2
            Button7.Text = "X"
        ElseIf Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = True And Button9.Enabled = False Then
            Button8.Enabled = False
            btn8player = 2
            Button8.Text = "X"
        ElseIf Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = True Then
            Button9.Enabled = False
            btn9player = 2
            Button9.Text = "X"


            'End If

        ElseIf hard.Enabled = True And Button1.Enabled = True And Button2.Enabled = True And Button3.Enabled = True And Button4.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = True And Button8.Enabled = True And Button9.Enabled = True Then
            Button5.Enabled = False
            btn5player = 2



        ElseIf Button1.Enabled = True And Button2.Enabled = True And Button3.Enabled = True And Button4.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = True And Button8.Enabled = True And Button9.Enabled = True Then
            Dim st As String = Convert.ToString(Random.Next(1, 9))
            Select Case st
                Case "1"
                    Button1.Enabled = False
                    btn1player = 2
                    'MsgBox("Button 1 is enable")
                Case "2"
                    Button2.Enabled = False
                    btn2player = 2
                    'MsgBox("Button 2 is enable")
                Case "3"
                    Button3.Enabled = False
                    btn3player = 2
                    'MsgBox("Button 3 is enable")
                Case "4"
                    Button4.Enabled = False
                    btn4player = 2
                    'MsgBox("Button 4 is enable")
                Case "5"
                    Button5.Enabled = False
                    btn5player = 2
                    'MsgBox("Button 5 is enable")
                Case "6"
                    Button6.Enabled = False
                    btn6player = 2
                    'MsgBox("Button 6 is enable")
                Case "7"
                    Button7.Enabled = False
                    btn7player = 2
                    'MsgBox("Button 7 is enable")
                Case "8"
                    Button8.Enabled = False
                    btn8player = 2
                    'MsgBox("Button 8 is enable")
                Case "9"
                    Button9.Enabled = False
                    btn9player = 2
                    'MsgBox("Button 9 is enable")
            End Select


            'End If


        ElseIf easy.Enabled = True Then
            If Button1.Enabled = True And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button2.Enabled = True And Button1.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button3.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button4.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button5.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button6.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button7.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button6.Enabled = False And Button5.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button8.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button5.Enabled = False And Button9.Enabled = False Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button9.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button5.Enabled = False Then
                Button9.Enabled = False
                btn9player = 2
                'it will change in differnt mode \
                'for button1
            ElseIf btn2player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button4.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition check
            ElseIf btn4player = 1 And btn7player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' third condition check
            ElseIf btn5player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                'button 1 all conditions complete
                'for button2 
                'first condition
            ElseIf btn1player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second condition
            ElseIf btn5player = 1 And btn8player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'all consition for button2 is completed
                ' for button3
                ' first condition
            ElseIf btn1player = 1 And btn2player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn6player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                ' third condition
            ElseIf btn5player = 1 And btn7player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button 3 is completed
                ' for button4
                ' first condition
            ElseIf btn1player = 1 And btn7player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn5player = 1 And btn6player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button 4 is completed
                ' for button5
                ' first condition
            ElseIf btn1player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' second condition
            ElseIf btn7player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'third condition
            ElseIf btn2player = 1 And btn8player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' fourth condition
            ElseIf btn4player = 1 And btn6player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 1 And btn6player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 1 And btn6player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 1 And btn6player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button5 is completed
                ' for button6
                ' first condition
            ElseIf btn9player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn3player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn3player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn9player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn9player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn9player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                'second condition
            ElseIf btn4player = 1 And btn5player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button6 is completed
                ' for button7
                'first condition
            ElseIf btn1player = 1 And btn4player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second condition
            ElseIf btn5player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'third condition
            ElseIf btn8player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condition for button7 is completed
                ' for button8
                'first condition
            ElseIf btn2player = 1 And btn5player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn7player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condtion for button8 is completed
                ' for button9
                'first condition
            ElseIf btn1player = 1 And btn5player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                'second condition
            ElseIf btn6player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                'third condition
            ElseIf btn7player = 1 And btn8player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condition for button9 is completed
            ElseIf btn2player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button4.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition check
            ElseIf btn4player = 2 And btn7player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' third condition check
            ElseIf btn5player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                'button 1 all conditions complete
                'for button2 
                'first condition
            ElseIf btn1player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second condition
            ElseIf btn5player = 2 And btn8player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'all consition for button2 is completed
                ' for button3
                ' first condition
            ElseIf btn1player = 2 And btn2player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn6player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                ' third condition
            ElseIf btn5player = 2 And btn7player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button 3 is completed
                ' for button4
                ' first condition
            ElseIf btn1player = 2 And btn7player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn5player = 2 And btn6player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button 4 is completed
                ' for button5
                ' first condition
            ElseIf btn1player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' second condition
            ElseIf btn7player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'third condition
            ElseIf btn2player = 2 And btn8player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' fourth condition
            ElseIf btn4player = 2 And btn6player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 2 And btn6player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 2 And btn6player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 2 And btn6player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button5 is completed
                ' for button6
                ' first condition
            ElseIf btn9player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn3player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn3player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn9player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn9player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn9player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                'second condition
            ElseIf btn4player = 2 And btn5player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button6 is completed
                ' for button7
                'first condition
            ElseIf btn1player = 2 And btn4player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second condition
            ElseIf btn5player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'third condition
            ElseIf btn8player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condition for button7 is completed
                ' for button8
                'first condition
            ElseIf btn2player = 2 And btn5player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn7player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condtion for button8 is completed
                ' for button9
                'first condition
            ElseIf btn1player = 2 And btn5player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                'second condition
            ElseIf btn6player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                'third condition
            ElseIf btn7player = 2 And btn8player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condition for button9 is completed
                ' all buttons conditions complted
                'start conditions
            ElseIf Button1.Enabled = True And Button2.Enabled = True And Button3.Enabled = True And Button4.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = True And Button8.Enabled = True And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'sperate space filler
                ' for button1
            ElseIf Button1.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button1.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button1.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button1.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button1.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button1.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button1.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button1.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button2
            ElseIf Button2.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button2.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button2.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button2.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button2.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button2.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button2.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button2.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button3
            ElseIf Button3.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button3.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button3.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button3.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button3.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button3.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button3.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button3.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button4
            ElseIf Button4.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button4.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button4.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button4.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button4.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button4.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button4.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button4.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' for button5
            ElseIf Button5.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button5.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button5.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button5.Enabled = False And Button1.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button5.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button5.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button5.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button5.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button6
            ElseIf Button6.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button6.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button6.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button6.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button6.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button6.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button6.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button6.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button7
            ElseIf Button7.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button7.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button7.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button7.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button7.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button7.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button7.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button7.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button8
            ElseIf Button8.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button8.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button8.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button8.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button8.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button8.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button8.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button8.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button9
            ElseIf Button9.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button9.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button9.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button9.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button9.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button9.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button9.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button9.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            End If
        ElseIf medium.Enabled = True Then
            If Button1.Enabled = True And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button2.Enabled = True And Button1.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button3.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button4.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button5.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button6.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button7.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button6.Enabled = False And Button5.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button8.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button5.Enabled = False And Button9.Enabled = False Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button9.Enabled = True And Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button5.Enabled = False Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf Button1.Enabled = True And Button2.Enabled = True And Button3.Enabled = False And Button4.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = True And Button8.Enabled = True And Button9.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
                'it will change in differnt mode \
                'for button1
            ElseIf btn2player = 1 And btn3player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button4.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition check
            ElseIf btn4player = 1 And btn7player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn4player = 1 And btn7player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' third condition check
            ElseIf btn5player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                'button 1 all conditions complete
                'for button2 
                'first condition
            ElseIf btn1player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second condition
            ElseIf btn5player = 1 And btn8player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'all consition for button2 is completed
                ' for button3
                ' first condition
            ElseIf btn1player = 1 And btn2player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn6player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn4player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                ' third condition
            ElseIf btn5player = 1 And btn7player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 1 And btn7player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button 3 is completed
                ' for button4
                ' first condition
            ElseIf btn1player = 1 And btn7player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn7player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn5player = 1 And btn6player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button 4 is completed
                ' for button5
                ' first condition
            ElseIf btn1player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' second condition
            ElseIf btn7player = 1 And btn3player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn7player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'third condition
            ElseIf btn2player = 1 And btn8player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' fourth condition
            ElseIf btn4player = 1 And btn6player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 1 And btn6player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 1 And btn6player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 1 And btn6player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 1 And btn6player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button5 is completed
                ' for button6
                ' first condition
            ElseIf btn9player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn9player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn3player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn3player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn9player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn9player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn9player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                'second condition
            ElseIf btn4player = 1 And btn5player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 1 And btn5player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button6 is completed
                ' for button7
                'first condition
            ElseIf btn1player = 1 And btn4player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn4player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second condition
            ElseIf btn5player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'third condition
            ElseIf btn8player = 1 And btn9player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condition for button7 is completed
                ' for button8
                'first condition
            ElseIf btn2player = 1 And btn5player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn2player = 1 And btn5player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn7player = 1 And btn9player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condtion for button8 is completed
                ' for button9
                'first condition
            ElseIf btn1player = 1 And btn5player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And btn5player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                'second condition
            ElseIf btn6player = 1 And btn3player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn6player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                'third condition
            ElseIf btn7player = 1 And btn8player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condition for button9 is completed
                ' This is new condition for check is cpu player win
                ' for button1
            ElseIf btn2player = 2 And btn3player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button4.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition check
            ElseIf btn4player = 2 And btn7player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn4player = 2 And btn7player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' third condition check
            ElseIf btn5player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                'button 1 all conditions complete
                'for button2 
                'first condition
            ElseIf btn1player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second condition
            ElseIf btn5player = 2 And btn8player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'all consition for button2 is completed
                ' for button3
                ' first condition
            ElseIf btn1player = 2 And btn2player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn6player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                ' third condition
            ElseIf btn5player = 2 And btn7player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And btn7player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button 3 is completed
                ' for button4
                ' first condition
            ElseIf btn1player = 2 And btn7player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn7player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn5player = 2 And btn6player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button 4 is completed
                ' for button5
                ' first condition
            ElseIf btn1player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' second condition
            ElseIf btn7player = 2 And btn3player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn7player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'third condition
            ElseIf btn2player = 2 And btn8player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ans_check()
                player = 1
                ' fourth condition
            ElseIf btn4player = 2 And btn6player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 2 And btn6player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 2 And btn6player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 2 And btn6player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 2 And btn6player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button5 is completed
                ' for button6
                ' first condition
            ElseIf btn9player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn9player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn3player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn3player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn9player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn9player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn9player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                'second condition
            ElseIf btn4player = 2 And btn5player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 2 And btn5player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all condition for button6 is completed
                ' for button7
                'first condition
            ElseIf btn1player = 2 And btn4player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn4player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second condition
            ElseIf btn5player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'third condition
            ElseIf btn8player = 2 And btn9player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condition for button7 is completed
                ' for button8
                'first condition
            ElseIf btn2player = 2 And btn5player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn2player = 2 And btn5player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' second condition
            ElseIf btn7player = 2 And btn9player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condtion for button8 is completed
                ' for button9
                'first condition
            ElseIf btn1player = 2 And btn5player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 2 And btn5player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                'second condition
            ElseIf btn6player = 2 And btn3player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn6player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                'third condition
            ElseIf btn7player = 2 And btn8player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all condition for button9 is completed
                ' all buttons conditions complted
                'start conditions
            ElseIf Button1.Enabled = True And Button2.Enabled = True And Button3.Enabled = True And Button4.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = True And Button8.Enabled = True And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'sperate space filler
                ' for button1
            ElseIf Button1.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button1.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button1.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button1.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button1.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button1.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button1.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button1.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button2
            ElseIf Button2.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button2.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button2.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button2.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button2.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button2.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button2.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button2.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button3
            ElseIf Button3.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button3.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button3.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button3.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button3.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button3.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button3.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button3.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button4
            ElseIf Button4.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button4.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button4.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button4.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button4.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button4.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button4.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button4.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' for button5
            ElseIf Button5.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button5.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button5.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button5.Enabled = False And Button1.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button5.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button5.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button5.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button5.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button6
            ElseIf Button6.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button6.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button6.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button6.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button6.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button6.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button6.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button6.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button7
            ElseIf Button7.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button7.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button7.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button7.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button7.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button7.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button7.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button7.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button8
            ElseIf Button8.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button8.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button8.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button8.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button8.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button8.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button8.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button8.Enabled = False And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'for button9
            ElseIf Button9.Enabled = False And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button9.Enabled = False And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button9.Enabled = False And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button9.Enabled = False And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button9.Enabled = False And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button9.Enabled = False And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button9.Enabled = False And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf Button9.Enabled = False And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            End If
        ElseIf hard.Enabled = True Then
            If Button1.Enabled = True And Button2.Enabled = True And Button3.Enabled = False And Button4.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = True And Button8.Enabled = True And Button9.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button1.Enabled = True And Button2.Enabled = True And Button3.Enabled = True And Button4.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = False And Button8.Enabled = True And Button9.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button1.Enabled = True And Button2.Enabled = True And Button3.Enabled = True And Button4.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = True And Button8.Enabled = True And Button9.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
                ' This is case for check the all condition for win cpu player
                ' For button1
            ElseIf btn3player = 2 And btn2player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 2 And btn4player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn9player = 2 And btn5player = 2 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
                'all the condition is resoled for the button1
                'For button2
            ElseIf btn1player = 2 And btn3player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 2 And btn8player = 2 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                ' all the condition is resoled for the button2
                ' For button3
            ElseIf btn1player = 2 And btn2player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn7player = 2 And btn5player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn6player = 2 And btn9player = 2 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all the condition is resold for the button3
                ' For button4
            ElseIf btn1player = 2 And btn7player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 2 And btn6player = 2 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
                ' all the condition is resold for the button4
                ' for button5
            ElseIf btn1player = 2 And btn9player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn2player = 2 And btn8player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn3player = 2 And btn7player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 2 And btn6player = 2 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
                ' all the condition is resold for the button5
                ' for button6
            ElseIf btn3player = 2 And btn9player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 2 And btn4player = 2 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
                ' all the condition is resold for the button6
                ' for button7
            ElseIf btn1player = 2 And btn4player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn3player = 2 And btn5player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn8player = 2 And btn9player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
                ' all the condition is resold for the button7
                ' for button8
            ElseIf btn2player = 2 And btn5player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn7player = 2 And btn9player = 2 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
                ' all the condition is resold for the button8
                ' for button9
            ElseIf btn1player = 2 And btn5player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn3player = 2 And btn6player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn7player = 2 And btn8player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' This is case for check the all condition for block the winning chance of the player
                ' For button1
            ElseIf btn3player = 1 And btn2player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 1 And btn4player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn9player = 1 And btn5player = 1 And Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
                'all the condition is resoled for the button1
                'For button2
            ElseIf btn1player = 1 And btn3player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And btn8player = 1 And Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                ' all the condition is resoled for the button2
                ' For button3
            ElseIf btn1player = 1 And btn2player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn7player = 1 And btn5player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn6player = 1 And btn9player = 1 And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                ' all the condition is resold for the button3
                ' For button4
            ElseIf btn1player = 1 And btn7player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn5player = 1 And btn6player = 1 And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
                ' all the condition is resold for the button4
                ' for button5
            ElseIf btn1player = 1 And btn9player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn2player = 1 And btn8player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn3player = 1 And btn7player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 1 And btn6player = 1 And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
                ' all the condition is resold for the button5
                ' for button6
            ElseIf btn3player = 1 And btn9player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And btn4player = 1 And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
                ' all the condition is resold for the button6
                ' for button7
            ElseIf btn1player = 1 And btn4player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn3player = 1 And btn5player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn8player = 1 And btn9player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
                ' all the condition is resold for the button7
                ' for button8
            ElseIf btn2player = 1 And btn5player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn7player = 1 And btn9player = 1 And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
                ' all the condition is resold for button8
                ' for button9
            ElseIf btn1player = 1 And btn5player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn3player = 1 And btn6player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn7player = 1 And btn8player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' all the conditin is resold for button9
            ElseIf Button1.Enabled = True And Button2.Enabled = True And Button5.Enabled = True And Button6.Enabled = True And Button7.Enabled = True And Button8.Enabled = True And Button9.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn1player = 1 And btn2player = 1 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn1player = 2 And btn2player = 2 And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                'second choise
                ' button 1
            ElseIf btn1player = 2 And Button2.Enabled = True And Button3.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 2 And Button5.Enabled = True And Button9.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And Button4.Enabled = True And Button7.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
                ' button 2
            ElseIf btn2player = 2 And Button1.Enabled = True And Button3.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 2 And Button5.Enabled = True And Button8.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
                ' button 3
            ElseIf btn3player = 2 And Button2.Enabled = True And Button1.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn3player = 2 And Button6.Enabled = True And Button9.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn3player = 2 And Button5.Enabled = True And Button7.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
                ' button 4
            ElseIf btn4player = 2 And Button5.Enabled = True And Button6.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 2 And Button1.Enabled = True And Button7.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
                ' button5
            ElseIf btn5player = 2 And Button1.Enabled = True And Button9.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 2 And Button2.Enabled = True And Button8.Enabled = True Then
                Button2.Enabled = False
                btn8player = 2
            ElseIf btn5player = 2 And Button7.Enabled = True And Button3.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn5player = 2 And Button4.Enabled = True And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
                ' button 6
            ElseIf btn6player = 2 And Button9.Enabled = True And Button3.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn6player = 2 And Button4.Enabled = True And Button5.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
                player = 1
                ' button 7
            ElseIf btn7player = 2 And Button1.Enabled = True And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 2 And Button5.Enabled = True And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn7player = 2 And Button8.Enabled = True And Button9.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
                ' button 8
            ElseIf btn8player = 2 And Button2.Enabled = True And Button5.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn8player = 2 And Button7.Enabled = True And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                ' button 9
            ElseIf btn9player = 2 And Button6.Enabled = True And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn9player = 2 And Button1.Enabled = True And Button5.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn9player = 2 And Button7.Enabled = True And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
                '{
                '   { (for button1)
            ElseIf btn1player = 1 And Button4.Enabled = True And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn1player = 2 And Button7.Enabled = True And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn1player = 1 And Button2.Enabled = True And Button5.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn1player = 1 And Button3.Enabled = True And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn1player = 1 And Button3.Enabled = True And Button5.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
                '   (end for button1)}
                '   { (for button2)}
            ElseIf btn2player = 1 And Button4.Enabled = True And Button5.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn2player = 1 And Button7.Enabled = True And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn2player = 1 And Button1.Enabled = True And Button4.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn2player = 1 And Button3.Enabled = True And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn2player = 1 And Button9.Enabled = True And Button1.Enabled = True And Button5.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn2player = 1 And Button3.Enabled = True And Button5.Enabled = True And Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
                '   (end for button2)}
                '   {(for button3)
            ElseIf btn3player = 1 And Button4.Enabled = True And Button5.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn3player = 1 And Button7.Enabled = False And Button8.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf btn3player = 1 And Button1.Enabled = True And Button3.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn3player = 1 And Button2.Enabled = True And Button5.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
                '   (end for button3)}
                '   {(for button4)
            ElseIf btn4player = 1 And Button1.Enabled = True And Button2.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn4player = 1 And Button7.Enabled = True And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
            ElseIf btn4player = 1 And Button2.Enabled = True And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn4player = 1 And Button3.Enabled = True And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
                '   (end for button4)}
                '   {(fot button5)
            ElseIf btn5player = 1 And Button1.Enabled = True And Button4.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn5player = 1 And Button3.Enabled = True And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn5player = 1 And Button2.Enabled = True And Button3.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn5player = 1 And Button9.Enabled = True And Button8.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
                '   (end for button5)}
                '   {(for button6)
            ElseIf btn6player = 1 And Button2.Enabled = True And Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn6player = 1 And Button7.Enabled = True And Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            ElseIf btn6player = 1 And Button1.Enabled = True And Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn6player = 1 And Button2.Enabled = True And Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
                '   (end for button6)}
                '   {(for button7)
            ElseIf btn7player = 1 And Button1.Enabled = True And Button2.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn7player = 1 And Button4.Enabled = True And Button5.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn7player = 1 And Button2.Enabled = True And Button5.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf btn7player = 1 And Button6.Enabled = True And Button5.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
                '   (end for button8)}
                '   {(for button8)
            ElseIf btn8player = 1 And Button7.Enabled = True And Button4.Enabled = True Then
                Button7.Enabled = False
                btn8player = 2
            ElseIf btn8player = 1 And Button9.Enabled = True And Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf btn8player = 1 And Button3.Enabled = True And Button2.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf btn8player = 1 And Button6.Enabled = True And Button5.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
                '   (end for button9)}
                '   {(for button9)
            ElseIf btn9player = 1 And Button1.Enabled = True And Button2.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf btn9player = 1 And Button5.Enabled = True And Button6.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf btn9player = 1 And Button4.Enabled = True And Button7.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf btn9player = 1 And Button2.Enabled = True And Button8.Enabled = True Then
                Button8.Enabled = False
                btn8player = 2
                '   (end for button9)}
                '}
            ElseIf Button1.Enabled = True Then
                Button1.Enabled = False
                btn1player = 2
            ElseIf Button2.Enabled = True Then
                Button2.Enabled = False
                btn2player = 2
            ElseIf Button3.Enabled = True Then
                Button3.Enabled = False
                btn3player = 2
            ElseIf Button4.Enabled = True Then
                Button4.Enabled = False
                btn4player = 2
            ElseIf Button5.Enabled = True Then
                Button5.Enabled = False
                btn5player = 2
            ElseIf Button6.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button7.Enabled = True Then
                Button6.Enabled = False
                btn6player = 2
            ElseIf Button7.Enabled = True Then
                Button7.Enabled = False
                btn7player = 2
            ElseIf Button9.Enabled = True Then
                Button9.Enabled = False
                btn9player = 2
            End If
        End If
        player = 2
        cpu_text_writer()
        ans_check()
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        If ans = False Then
            If Button1.Enabled = False Then
                If Button2.Enabled = False Then
                    If Button3.Enabled = False Then
                        If Button4.Enabled = False Then
                            If Button5.Enabled = False Then
                                If Button6.Enabled = False Then
                                    If Button7.Enabled = False Then
                                        If Button8.Enabled = False Then
                                            If Button9.Enabled = False Then
                                                draw_msg()
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        player = 1
    End Function
    Function ans_check()
        If btn1player = 1 And btn2player = 1 And btn3player = 1 And Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            print_msg()
        ElseIf btn1player = 1 And btn5player = 1 And btn9player = 1 And Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            print_msg()
        ElseIf btn1player = 1 And btn4player = 1 And btn7player = 1 And Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            print_msg()
        ElseIf btn2player = 1 And btn5player = 1 And btn8player = 1 And Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            print_msg()
        ElseIf btn3player = 1 And btn6player = 1 And btn9player = 1 And Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            print_msg()
        ElseIf btn3player = 1 And btn5player = 1 And btn7player = 1 And Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            print_msg()
        ElseIf btn4player = 1 And btn5player = 1 And btn6player = 1 And Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            print_msg()
        ElseIf btn7player = 1 And btn8player = 1 And btn9player = 1 And Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            print_msg()
        ElseIf btn1player = 2 And btn2player = 2 And btn3player = 2 And Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            print_msg()
        ElseIf btn1player = 2 And btn5player = 2 And btn9player = 2 And Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            print_msg()
        ElseIf btn1player = 2 And btn4player = 2 And btn7player = 2 And Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            print_msg()
        ElseIf btn5player = 2 And btn2player = 2 And btn8player = 2 And Button5.Text = "X" And Button2.Text = "X" And Button8.Text = "X" Then
            print_msg()
        ElseIf btn5player = 2 And btn7player = 2 And btn3player = 2 And Button5.Text = "X" And Button7.Text = "X" And Button3.Text = "X" Then
            print_msg()
        ElseIf btn4player = 2 And btn5player = 2 And btn6player = 2 And Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            print_msg()
        ElseIf btn7player = 2 And btn8player = 2 And btn9player = 2 And Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            print_msg()
        End If
    End Function

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        ans = False
        start.Enabled = False
        If easy.BackColor = Color.Blue Then
            medium.Enabled = False
            hard.Enabled = False
        ElseIf medium.BackColor = Color.Blue Then
            easy.Enabled = False
            hard.Enabled = False
        ElseIf hard.BackColor = Color.Blue Then
            easy.Enabled = False
            medium.Enabled = False
        End If
        start.Text = "Started..."
        all_btn_enable()
        btn_player_remover()
        btn_text_remover()
        t1 = True
        t2 = True
        t3 = True
        t4 = True
        t5 = True
        t6 = True
        t7 = True
        t8 = True
        t9 = True
        If ((player1_win_count + player1_lost_count + player_draw_count) Mod 2) <> 0 Then
            cpu_player()
        End If
    End Sub
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        ans = False
        easy.Enabled = True
        medium.Enabled = True
        hard.Enabled = True
        all_btn_disable()
        start.Text = "start"
        start.Enabled = True
        btn_player_remover()
        btn_text_remover()
        player1_win_count = 0
        player1_lost_count = 0
        player_draw_count = 0
        label_win_count.Text = player1_win_count
        label_lost_count.Text = player1_lost_count
        label_draw_count.Text = player_draw_count

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btn1player = 1
        Button1.Enabled = False
        Button1.Text = "O"
        ans_check()
        player = 2
        t1 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        btn2player = 1
        Button2.Enabled = False
        Button2.Text = "O"
        ans_check()
        player = 2
        t2 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        btn3player = 1
        Button3.Enabled = False
        Button3.Text = "O"
        ans_check()
        player = 2
        t3 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        btn4player = 1
        Button4.Enabled = False
        Button4.Text = "O"
        ans_check()
        player = 2
        t4 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        btn5player = 1
        Button5.Enabled = False
        Button5.Text = "O"
        ans_check()
        player = 2
        t5 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        btn6player = 1
        Button6.Enabled = False
        Button6.Text = "O"
        ans_check()
        player = 2
        t6 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        btn7player = 1
        Button7.Enabled = False
        Button7.Text = "O"
        ans_check()
        player = 2
        t7 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        btn8player = 1
        Button8.Enabled = False
        Button8.Text = "O"
        ans_check()
        player = 2
        t8 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        btn9player = 1
        Button9.Enabled = False
        Button9.Text = "O"
        ans_check()
        player = 2
        t9 = False
        If Me.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        cpu_player()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form4.form4_holder = False Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\White.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Button1.ForeColor = Color.Black
            Button2.ForeColor = Color.Black
            Button3.ForeColor = Color.Black
            Button4.ForeColor = Color.Black
            Button5.ForeColor = Color.Black
            Button6.ForeColor = Color.Black
            Button7.ForeColor = Color.Black
            Button8.ForeColor = Color.Black
            Button9.ForeColor = Color.Black
            Button10.ForeColor = Color.Black
            PictureBox1.BackColor = Color.Black
            PictureBox2.BackColor = Color.Black
            PictureBox3.BackColor = Color.Black
            PictureBox4.BackColor = Color.Black
            Label1.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
            label_draw_count.ForeColor = Color.Black
            label_lost_count.ForeColor = Color.Black
            label_win_count.ForeColor = Color.Black
        Else
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\black.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Button1.ForeColor = Color.Lime
            Button2.ForeColor = Color.RosyBrown
            Button3.ForeColor = Color.Lime
            Button4.ForeColor = Color.RosyBrown
            Button5.ForeColor = Color.Blue
            Button6.ForeColor = Color.RosyBrown
            Button7.ForeColor = Color.Lime
            Button8.ForeColor = Color.RosyBrown
            Button9.ForeColor = Color.Lime
            Button10.ForeColor = Color.DeepPink
            PictureBox1.BackColor = Color.DeepPink
            PictureBox2.BackColor = Color.DeepPink
            PictureBox3.BackColor = Color.DeepPink
            PictureBox4.BackColor = Color.DeepPink
            Button1.ForeColor = Color.DeepPink
            Label1.ForeColor = Color.Blue
            Label4.ForeColor = Color.Blue
            Label6.ForeColor = Color.Blue
            label_draw_count.ForeColor = Color.Blue
            label_lost_count.ForeColor = Color.Blue
            label_win_count.ForeColor = Color.Blue
        End If
        easy.BackColor = Color.Blue
        medium.BackColor = Color.Red
        hard.BackColor = Color.Red
        easy.Enabled = True
        medium.Enabled = True
        hard.Enabled = True
        start.Enabled = True
        reset.Enabled = True
        all_btn_disable()
        btn_text_remover()
        btn_player_remover()
        player1_win_count = 0
        player1_lost_count = 0
        player_draw_count = 0
        label_win_count.Text = player1_win_count
        label_lost_count.Text = player1_lost_count
        label_draw_count.Text = player_draw_count
    End Sub
End Class