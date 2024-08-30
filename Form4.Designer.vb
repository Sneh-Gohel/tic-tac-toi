<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.single_player_btn = New System.Windows.Forms.Button()
        Me.two_player_btn = New System.Windows.Forms.Button()
        Me.setting_btn = New System.Windows.Forms.Button()
        Me.sound_btn = New System.Windows.Forms.Button()
        Me.theme_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.form_change = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'single_player_btn
        '
        Me.single_player_btn.BackColor = System.Drawing.Color.Transparent
        Me.single_player_btn.Font = New System.Drawing.Font("Algerian", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.single_player_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.single_player_btn.Location = New System.Drawing.Point(226, 86)
        Me.single_player_btn.Name = "single_player_btn"
        Me.single_player_btn.Size = New System.Drawing.Size(324, 78)
        Me.single_player_btn.TabIndex = 0
        Me.single_player_btn.Text = "1-Player"
        Me.single_player_btn.UseVisualStyleBackColor = False
        '
        'two_player_btn
        '
        Me.two_player_btn.BackColor = System.Drawing.Color.Transparent
        Me.two_player_btn.Font = New System.Drawing.Font("Algerian", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.two_player_btn.Location = New System.Drawing.Point(226, 212)
        Me.two_player_btn.Name = "two_player_btn"
        Me.two_player_btn.Size = New System.Drawing.Size(324, 78)
        Me.two_player_btn.TabIndex = 1
        Me.two_player_btn.Text = "2-Player"
        Me.two_player_btn.UseVisualStyleBackColor = False
        '
        'setting_btn
        '
        Me.setting_btn.BackColor = System.Drawing.Color.Transparent
        Me.setting_btn.Font = New System.Drawing.Font("Algerian", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.setting_btn.Location = New System.Drawing.Point(226, 341)
        Me.setting_btn.Name = "setting_btn"
        Me.setting_btn.Size = New System.Drawing.Size(324, 78)
        Me.setting_btn.TabIndex = 2
        Me.setting_btn.Text = "Setting"
        Me.setting_btn.UseVisualStyleBackColor = False
        '
        'sound_btn
        '
        Me.sound_btn.BackColor = System.Drawing.Color.Transparent
        Me.sound_btn.Enabled = False
        Me.sound_btn.Font = New System.Drawing.Font("Algerian", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.sound_btn.Location = New System.Drawing.Point(226, 148)
        Me.sound_btn.Name = "sound_btn"
        Me.sound_btn.Size = New System.Drawing.Size(324, 78)
        Me.sound_btn.TabIndex = 4
        Me.sound_btn.Text = "sound : on"
        Me.sound_btn.UseVisualStyleBackColor = False
        Me.sound_btn.Visible = False
        '
        'theme_btn
        '
        Me.theme_btn.BackColor = System.Drawing.Color.Transparent
        Me.theme_btn.Enabled = False
        Me.theme_btn.Font = New System.Drawing.Font("Algerian", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.theme_btn.Location = New System.Drawing.Point(226, 272)
        Me.theme_btn.Name = "theme_btn"
        Me.theme_btn.Size = New System.Drawing.Size(324, 78)
        Me.theme_btn.TabIndex = 5
        Me.theme_btn.Text = "theme : light"
        Me.theme_btn.UseVisualStyleBackColor = False
        Me.theme_btn.Visible = False
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Transparent
        Me.back_btn.Enabled = False
        Me.back_btn.Font = New System.Drawing.Font("Algerian", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.back_btn.Location = New System.Drawing.Point(703, 12)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(112, 68)
        Me.back_btn.TabIndex = 6
        Me.back_btn.Text = "<-"
        Me.back_btn.UseVisualStyleBackColor = False
        Me.back_btn.Visible = False
        '
        'form_change
        '
        Me.form_change.BackColor = System.Drawing.Color.Transparent
        Me.form_change.Font = New System.Drawing.Font("Algerian", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.form_change.Location = New System.Drawing.Point(703, 12)
        Me.form_change.Name = "form_change"
        Me.form_change.Size = New System.Drawing.Size(112, 68)
        Me.form_change.TabIndex = 7
        Me.form_change.Text = "<-"
        Me.form_change.UseMnemonic = False
        Me.form_change.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 525)
        Me.ControlBox = False
        Me.Controls.Add(Me.form_change)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.theme_btn)
        Me.Controls.Add(Me.sound_btn)
        Me.Controls.Add(Me.setting_btn)
        Me.Controls.Add(Me.two_player_btn)
        Me.Controls.Add(Me.single_player_btn)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents single_player_btn As Button
    Friend WithEvents two_player_btn As Button
    Friend WithEvents setting_btn As Button
    Friend WithEvents sound_btn As Button
    Friend WithEvents theme_btn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents form_change As Button
End Class
