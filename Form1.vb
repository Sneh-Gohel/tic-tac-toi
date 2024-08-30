Public Class Form1
    Dim player As Integer
    Dim btn1player, btn2player, btn3player, btn4player, btn5player, btn6player, btn7player, btn8player, btn9player, player1_win_count, player2_win_count, tie_count, tie_check_buffer As Integer
    Dim won_line_buffer As String
    Function draw()
        MessageBox.Show("Match tie", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        tie_count = tie_count + 1
        won_line_buffer = "tie"
        Label1.Text = "This match is " & won_line_buffer
        end_round()
    End Function
    Function end_round()
        Label4.Text = player1_win_count
        Label5.Text = player2_win_count
        Label7.Text = tie_count
        Play_or_restart_btn.Text = "Restart"
        Play_or_restart_btn.Enabled = True
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
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
            won_line_buffer = "Player 1 won"
            player1_win_count = player1_win_count + 1
        Else
            MessageBox.Show("player2 is winner!!!", "Congratulation", MessageBoxButtons.OK)
            won_line_buffer = "Player 2 won"
            player2_win_count = player2_win_count + 1
        End If
        Label1.Text = won_line_buffer & " in this match..."
        end_round()
    End Function
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub btn7_Click_1(sender As Object, e As EventArgs) Handles btn7.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn7player = player
        btn7.Enabled = False
        If player = 1 Then
            btn7.Text = "O"
            If btn7player = 1 And btn5player = 1 And btn3player = 1 Then
                print_msg()
            ElseIf btn1player = 1 And btn4player = 1 And btn7player = 1 Then
                print_msg()
            ElseIf btn7player = 1 And btn8player = 1 And btn9player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn7.Text = "X"
            If btn7player = 2 And btn5player = 2 And btn3player = 2 Then
                print_msg()
            ElseIf btn1player = 2 And btn4player = 2 And btn7player = 2 Then
                print_msg()
            ElseIf btn7player = 2 And btn8player = 2 And btn9player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub btn6_Click_1(sender As Object, e As EventArgs) Handles btn6.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn6player = player
        btn6.Enabled = False
        If player = 1 Then
            btn6.Text = "O"
            If btn4player = 1 And btn5player = 1 And btn6player = 1 Then
                print_msg()
            ElseIf btn3player = 1 And btn6player = 1 And btn9player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn6.Text = "X"
            If btn4player = 2 And btn5player = 2 And btn6player = 2 Then
                print_msg()
            ElseIf btn3player = 2 And btn6player = 2 And btn9player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub btn5_Click_1(sender As Object, e As EventArgs) Handles btn5.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn5player = player
        btn5.Enabled = False
        If player = 1 Then
            btn5.Text = "O"
            If btn5player = 1 And btn4player = 1 And btn6player = 1 Then
                print_msg()
            ElseIf btn1player = 1 And btn5player = 1 And btn9player = 1 Then
                print_msg()
            ElseIf btn7player = 1 And btn5player = 1 And btn3player = 1 Then
                print_msg()
            ElseIf btn2player = 1 And btn5player = 1 And btn8player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn5.Text = "X"
            If btn5player = 2 And btn4player = 2 And btn6player = 2 Then
                print_msg()
            ElseIf btn1player = 2 And btn5player = 2 And btn9player = 2 Then
                print_msg()
            ElseIf btn7player = 2 And btn5player = 2 And btn3player = 2 Then
                print_msg()
            ElseIf btn2player = 2 And btn5player = 2 And btn8player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub btn4_Click_1(sender As Object, e As EventArgs) Handles btn4.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn4player = player
        btn4.Enabled = False
        If player = 1 Then
            btn4.Text = "O"
            If btn4player = 1 And btn5player = 1 And btn6player = 1 Then
                print_msg()
            ElseIf btn1player = 1 And btn4player = 1 And btn7player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn4.Text = "X"
            If btn4player = 2 And btn5player = 2 And btn6player = 2 Then
                print_msg()
            ElseIf btn1player = 2 And btn4player = 2 And btn7player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub btn3_Click_1(sender As Object, e As EventArgs) Handles btn3.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn3player = player
        btn3.Enabled = False
        If player = 1 Then
            btn3.Text = "O"
            If btn3player = 1 And btn1player = 1 And btn2player = 1 Then
                print_msg()
            ElseIf btn3player = 1 And btn5player = 1 And btn7player = 1 Then
                print_msg()
            ElseIf btn3player = 1 And btn6player = 1 And btn9player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn3.Text = "X"
            If btn3player = 2 And btn1player = 2 And btn2player = 2 Then
                print_msg()
            ElseIf btn3player = 2 And btn5player = 2 And btn7player = 2 Then
                print_msg()
            ElseIf btn3player = 2 And btn6player = 2 And btn9player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub btn2_Click_1(sender As Object, e As EventArgs) Handles btn2.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn2player = player
        btn2.Enabled = False
        If player = 1 Then
            btn2.Text = "O"
            If btn2player = 1 And btn1player = 1 And btn3player = 1 Then
                print_msg()
            ElseIf btn2player = 1 And btn5player = 1 And btn8player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn2.Text = "X"
            If btn2player = 2 And btn1player = 2 And btn3player = 2 Then

                print_msg()
            ElseIf btn2player = 2 And btn5player = 2 And btn8player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub btn1_Click_1(sender As Object, e As EventArgs) Handles btn1.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn1player = player
        btn1.Enabled = False
        If player = 1 Then
            btn1.Text = "O"
            If btn1player = 1 And btn2player = 1 And btn3player = 1 Then
                print_msg()
            ElseIf btn1player = 1 And btn5player = 1 And btn9player = 1 Then
                print_msg()
            ElseIf btn1player = 1 And btn4player = 1 And btn7player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn1.Text = "X"
            If btn1player = 2 And btn2player = 2 And btn3player = 2 Then
                print_msg()
            ElseIf btn1player = 2 And btn5player = 2 And btn9player = 2 Then
                print_msg()
            ElseIf btn1player = 2 And btn4player = 2 And btn7player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub btn8_Click_1(sender As Object, e As EventArgs) Handles btn8.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn8player = player
        btn8.Enabled = False
        If player = 1 Then
            btn8.Text = "O"
            If btn8player = 1 And btn2player = 1 And btn5player = 1 Then
                print_msg()
            ElseIf btn7player = 1 And btn8player = 1 And btn9player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn8.Text = "X"
            If btn8player = 2 And btn2player = 2 And btn5player = 2 Then
                print_msg()
            ElseIf btn7player = 2 And btn8player = 2 And btn9player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub btn9_Click_1(sender As Object, e As EventArgs) Handles btn9.Click
        If Form2.sound = True Then
            My.Computer.Audio.Play("sound\sound.wav")
        End If
        btn9player = player
        btn9.Enabled = False
        If player = 1 Then
            btn9.Text = "O"
            If btn9player = 1 And btn5player = 1 And btn1player = 1 Then
                print_msg()
            ElseIf btn7player = 1 And btn8player = 1 And btn9player = 1 Then
                print_msg()
            ElseIf btn3player = 1 And btn6player = 1 And btn9player = 1 Then
                print_msg()
            End If
            player = 2
        Else
            btn9.Text = "X"
            If btn9player = 2 And btn5player = 2 And btn1player = 2 Then
                print_msg()
            ElseIf btn7player = 2 And btn8player = 2 And btn9player = 2 Then
                print_msg()
            ElseIf btn3player = 2 And btn6player = 2 And btn9player = 2 Then
                print_msg()
            End If
            player = 1
        End If
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And btn8.Enabled = False And btn9.Enabled = False And ((player1_win_count + player2_win_count) = tie_check_buffer) Then
            draw()
        End If
    End Sub

    Private Sub reset_btn_Click_1(sender As Object, e As EventArgs) Handles reset_btn.Click
        reset_btn.Enabled = False
        Play_or_restart_btn.Enabled = True
        end_round()
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        player = 1
        Label1.Text = ""
        player1_win_count = 0
        player2_win_count = 0
        tie_check_buffer = 0
        tie_count = 0
        Label7.Text = tie_count
        Label4.Text = player1_win_count
        Label5.Text = player2_win_count
        Play_or_restart_btn.Text = "Play"
    End Sub

    Private Sub Play_or_restart_btn_Click(sender As Object, e As EventArgs) Handles Play_or_restart_btn.Click
        If ((player1_win_count + player2_win_count + 1) Mod 2) = 0 Then
            player = 2
        Else
            player = 1
        End If
        If ((player1_win_count + player2_win_count) = tie_check_buffer) And ((player1_win_count + player2_win_count + tie_count
                ) > 0) Then
            Label1.Text = "Last match was " & won_line_buffer
        ElseIf ((player1_win_count + player2_win_count + tie_count) > 0) Then
            Label1.Text = won_line_buffer & " in last match..."
        End If
        Play_or_restart_btn.Text = "Started..."
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        Play_or_restart_btn.Enabled = False
        reset_btn.Enabled = True
        tie_check_buffer = player1_win_count + player2_win_count
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form4.form4_holder = False Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\White.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            btn1.ForeColor = Color.Black
            btn2.ForeColor = Color.Black
            btn3.ForeColor = Color.Black
            btn4.ForeColor = Color.Black
            btn5.ForeColor = Color.Black
            btn6.ForeColor = Color.Black
            btn7.ForeColor = Color.Black
            btn8.ForeColor = Color.Black
            btn9.ForeColor = Color.Black
            PictureBox1.BackColor = Color.Black
            PictureBox2.BackColor = Color.Black
            PictureBox3.BackColor = Color.Black
            PictureBox4.BackColor = Color.Black
            Button1.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
            Label7.ForeColor = Color.Black
        Else
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\black.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            btn1.ForeColor = Color.Lime
            btn2.ForeColor = Color.RosyBrown
            btn3.ForeColor = Color.Lime
            btn4.ForeColor = Color.RosyBrown
            btn5.ForeColor = Color.Blue
            btn6.ForeColor = Color.RosyBrown
            btn7.ForeColor = Color.Lime
            btn8.ForeColor = Color.RosyBrown
            btn9.ForeColor = Color.Lime
            PictureBox1.BackColor = Color.DeepPink
            PictureBox2.BackColor = Color.DeepPink
            PictureBox3.BackColor = Color.DeepPink
            PictureBox4.BackColor = Color.DeepPink
            Button1.ForeColor = Color.DeepPink
            Label1.ForeColor = Color.DeepPink
            Label2.ForeColor = Color.DeepPink
            Label3.ForeColor = Color.DeepPink
            Label4.ForeColor = Color.DeepPink
            Label5.ForeColor = Color.DeepPink
            Label6.ForeColor = Color.DeepPink
            Label7.ForeColor = Color.DeepPink
        End If
        player = 1
        player1_win_count = 0
        player2_win_count = 0
        Label7.Text = 0
        Label4.Text = player1_win_count
        Label5.Text = player2_win_count
    End Sub
End Class