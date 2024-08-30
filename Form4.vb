Public Class Form4
    Public form4_holder As Boolean
    Private Sub setting_btn_Click(sender As Object, e As EventArgs) Handles setting_btn.Click
        single_player_btn.Enabled = False
        single_player_btn.Visible = False
        two_player_btn.Enabled = False
        two_player_btn.Visible = False
        setting_btn.Enabled = False
        setting_btn.Visible = False
        form_change.Enabled = False
        form_change.Visible = False
        sound_btn.Visible = True
        sound_btn.Enabled = True
        theme_btn.Visible = True
        theme_btn.Enabled = True
        back_btn.Visible = True
        back_btn.Enabled = True
    End Sub
    Private Sub single_player_btn_Click(sender As Object, e As EventArgs) Handles single_player_btn.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub two_player_btn_Click(sender As Object, e As EventArgs) Handles two_player_btn.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        sound_btn.Enabled = False
        sound_btn.Visible = False
        theme_btn.Enabled = False
        theme_btn.Visible = False
        back_btn.Enabled = False
        back_btn.Visible = False
        single_player_btn.Visible = True
        single_player_btn.Enabled = True
        two_player_btn.Visible = True
        two_player_btn.Enabled = True
        setting_btn.Visible = True
        setting_btn.Enabled = True
        form_change.Visible = True
        form_change.Enabled = True
    End Sub
    Private Sub form_change_Click(sender As Object, e As EventArgs) Handles form_change.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub theme_btn_Click(sender As Object, e As EventArgs) Handles theme_btn.Click
        If form4_holder = False Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\black.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Form1.BackgroundImage = System.Drawing.Image.FromFile("pic\black.jpg")
            Form1.BackgroundImageLayout = ImageLayout.Stretch
            Form2.BackgroundImage = System.Drawing.Image.FromFile("pic\black.jpg")
            Form2.BackgroundImageLayout = ImageLayout.Stretch
            Me.form4_holder = True
            single_player_btn.ForeColor = Color.BlueViolet
            sound_btn.ForeColor = Color.BlueViolet
            two_player_btn.ForeColor = Color.BlueViolet
            theme_btn.ForeColor = Color.BlueViolet
            setting_btn.ForeColor = Color.BlueViolet
            back_btn.ForeColor = Color.BlueViolet
            form_change.ForeColor = Color.BlueViolet
            theme_btn.Text = "theme : Dark"
        Else
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\White.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Form1.BackgroundImage = System.Drawing.Image.FromFile("pic\White.jpg")
            Form1.BackgroundImageLayout = ImageLayout.Stretch
            Form2.BackgroundImage = System.Drawing.Image.FromFile("pic\White.jpg")
            Form2.BackgroundImageLayout = ImageLayout.Stretch
            Me.form4_holder = False
            single_player_btn.ForeColor = Color.Blue
            sound_btn.ForeColor = Color.Blue
            two_player_btn.ForeColor = Color.Blue
            theme_btn.ForeColor = Color.Blue
            setting_btn.ForeColor = Color.Blue
            back_btn.ForeColor = Color.Blue
            form_change.ForeColor = Color.Blue
            theme_btn.Text = "theme : light"
        End If
    End Sub

    Private Sub sound_btn_Click(sender As Object, e As EventArgs) Handles sound_btn.Click
        If Form2.sound = True Then
            Form2.sound = False
            sound_btn.Text = "SOUND : OFF"
        Else
            Form2.sound = True
            sound_btn.Text = "SOUND : ON"
        End If
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.form4_holder = False Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\White.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\black.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub Form4_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If 1 Then
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\White.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Me.BackgroundImage = System.Drawing.Image.FromFile("pic\black.jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub
End Class