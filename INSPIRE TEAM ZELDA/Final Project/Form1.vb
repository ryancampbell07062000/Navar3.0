Public Class Dungeon_1
  
    Dim Mon10kill As Integer = 0
    Dim Mon2kill As Integer = 0
    Dim Mon3kill As Integer = 0
    Dim Mon4kill As Integer = 0
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim prevy As Integer = playerUp.Top
        Dim prevx As Integer = playerUp.Left

        Dim prevw As Integer = playerDown.Top
        Dim preve As Integer = playerDown.Left

        Dim prevr As Integer = playerRight.Top
        Dim prevt As Integer = playerRight.Left

        Dim prevj As Integer = playerLeft.Top
        Dim prevu As Integer = playerLeft.Left

        Dim prevxM1 As Integer = picMonster10.Top
        Dim prevyM1 As Integer = picMonster2.Left

        Select Case e.KeyCode ' Move player
            Case Keys.Up

                playerRight.Top -= 17

                playerRight.Visible = False
                playerUp.Visible = True
                playerUp.Top -= 17
                playerLeft.Visible = False ' When a player faces a direction, the other pictures are invisible
                playerDown.Visible = False
                playerDown.Top -= 17
                playerLeft.Top -= 17

            Case Keys.Down

                playerRight.Top += 17

                playerUp.Top += 17
                playerDown.Top += 17
                playerLeft.Top += 17
                playerRight.Visible = False
                playerUp.Visible = False
                playerLeft.Visible = False
                playerDown.Visible = True

            Case Keys.Left

                playerRight.Left -= 17
                playerUp.Left -= 17
                playerRight.Visible = False
                playerUp.Visible = False
                playerDown.Visible = False
                playerLeft.Visible = True
                playerDown.Left -= 17
                playerLeft.Left -= 17

            Case Keys.Right

                playerRight.Left += 17
                playerUp.Left += 17
                playerUp.Visible = False
                playerLeft.Visible = False
                playerDown.Visible = False
                playerDown.Left += 17
                playerLeft.Left += 17
                playerRight.Visible = True
            Case Keys.Q
                Me.Close()
                Final_Boss.Close()
                Dungeon_Up.Close()
                Tutorial.Close()
                MenuZel.Close()
        End Select
        obsticle3.Visible = False ' Invisible wall
        obsticle4.Visible = False
        obsticle5.Visible = False
        obsticle6.Visible = False
        obsticle7.Visible = False
        obsticle8.Visible = False
        obsticle9.Visible = False
        obsticle10.Visible = False
        obsticle11.Visible = False
        obsticle12.Visible = False
        obsticle13.Visible = False
        obsticle14.Visible = False
        obsticle15.Visible = False
        obsticle16.Visible = False
        obsticle17.Visible = False
        obsticle18.Visible = False

        If testcollision(playerUp, obsticle) = True Then ' Return player to previous spot when he runs into wall
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle2) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle3) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle4) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle5) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle6) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle7) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle8) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle9) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle10) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If

        If testcollision(playerUp, obsticle12) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If


        If testcollision(playerDown, obsticle) = True Then ' Return player to previous spot when he runs into wall
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle2) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle3) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle4) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle5) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle6) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle7) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle8) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle9) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle10) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle12) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerLeft, obsticle) = True Then ' Return player to previous spot when he runs into wall
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle2) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle3) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle4) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle5) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle6) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle7) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle8) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle9) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle10) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle12) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If

        If testcollision(playerRight, obsticle) = True Then ' Return player to previous spot when he runs into wall
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle2) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle3) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle4) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle5) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle6) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle7) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerLeft, obsticle8) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle9) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle10) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle12) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If

        If testcollision(playerUp, Right) = True Then
            Me.Close()
            Dungeon_Up.Close()
        End If
        up.Visible = False
        If testcollision(playerUp, up) = True Then
            Dungeon_Up.ShowDialog()
        End If
        BossRoom.Visible = False
        If testcollision(playerDown, BossRoom) = True Then
            Final_Boss.ShowDialog()
        End If
        'If testcollision(playerDown, obsKey) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If

    End Sub
    Function testcollision(ByRef pic1 As PictureBox, ByVal pic2 As PictureBox) As Boolean ' Collision function
        If pic1.Top < pic2.Bottom And pic1.Left < pic2.Right And pic1.Bottom > pic2.Top And pic1.Right > pic2.Left Then
            Return True
        End If
        Return False
    End Function
    Private Sub Dungeon_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbHealth.Value = PlayerStats.numHealth
        Timer7.Interval = 500
        Timer7.Enabled = True
    End Sub
    Private Function testcollision(pictureBox As PictureBox, dungeon_Up As Dungeon_Up) As Boolean
        Throw New NotImplementedException
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(picMonster2, playerDown) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster2, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster2, playerRight) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster2, playerLeft) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster4, playerDown) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster4, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster4, playerRight) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster4, playerLeft) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster10, playerDown) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster10, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster10, playerRight) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster10, playerLeft) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster3, playerDown) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster3, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster3, playerRight) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster3, playerLeft) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If Mon2kill = 1 Then
            If testcollision(playerDown, picHitbox6) = True Then
                Timer4.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerUp, picHitbox6) = True Then
                Timer4.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerRight, picHitbox6) = True Then
                Timer4.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerLeft, picHitbox6) = True Then
                Timer4.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
        End If
        If Mon10kill = 1 Then
            If testcollision(playerDown, picHitbox8) = True Then
                Timer2.Enabled = False
                picMonster10.Visible = False
                picMonster10.Left = 0
            End If
            If testcollision(playerUp, picHitbox8) = True Then
                Timer2.Enabled = False
                picMonster10.Visible = False
                picMonster10.Left = 0
            End If
            If testcollision(playerRight, picHitbox8) = True Then
                Timer2.Enabled = False
                picMonster10.Visible = False
                picMonster10.Left = 0
            End If
            If testcollision(playerLeft, picHitbox8) = True Then
                Timer2.Enabled = False
                picMonster10.Visible = False
                picMonster10.Left = 0
            End If
        End If
        If Mon4kill = 1 Then
            If testcollision(playerDown, picHitbox7) = True Then
                Timer5.Enabled = False
                picMonster4.Visible = False
                picMonster4.Left = 0
            End If
            If testcollision(playerUp, picHitbox7) = True Then
                Timer5.Enabled = False
                picMonster4.Visible = False
                picMonster4.Left = 0
            End If
            If testcollision(playerRight, picHitbox7) = True Then
                Timer5.Enabled = False
                picMonster4.Visible = False
                picMonster4.Left = 0
            End If
            If testcollision(playerLeft, picHitbox7) = True Then
                Timer5.Enabled = False
                picMonster4.Visible = False
                picMonster4.Left = 0
            End If
        End If
        If Mon3kill = 1 Then
            If testcollision(playerDown, picHitbox3) = True Then
                Timer3.Enabled = False
                picMonster3.Visible = False
                picMonster3.Left = 0
            End If
            If testcollision(playerUp, picHitbox3) = True Then
                Timer3.Enabled = False
                picMonster3.Visible = False
                picMonster3.Left = 0
            End If
            If testcollision(playerRight, picHitbox3) = True Then
                Timer3.Enabled = False
                picMonster3.Visible = False
                picMonster3.Left = 0
            End If
            If testcollision(playerLeft, picHitbox3) = True Then
                Timer3.Enabled = False
                picMonster3.Visible = False
                picMonster3.Left = 0
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If picMonster10.Location.X > 185 Then
            picMonster10.Left -= 50
        ElseIf picMonster10.Location.X < 345 Then
            picMonster10.Left += 500
        End If
        If picHitbox8.Location.X > 185 Then
            picHitbox8.Left -= 50
        ElseIf picHitbox8.Location.X < 345 Then
            picHitbox8.Left += 500
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If picMonster3.Location.Y > 280 Then
            picMonster3.Top -= 30
        ElseIf picMonster3.Location.Y < 400 Then
            picMonster3.Top += 230
        End If
        If picHitbox3.Location.Y > 280 Then
            picHitbox3.Top -= 30
        ElseIf picHitbox3.Location.Y < 400 Then
            picHitbox3.Top += 230
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If picMonster2.Location.X > 335 Then
            picMonster2.Left -= 50
        ElseIf picMonster2.Location.X < 918 Then
            picMonster2.Left += 500
        End If
        If picHitbox6.Location.X > 335 Then
            picHitbox6.Left -= 50
        ElseIf picHitbox6.Location.X < 918 Then
            picHitbox6.Left += 500
        End If
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If picMonster4.Location.Y > 280 Then
            picMonster4.Top -= 50
        ElseIf picMonster4.Location.Y < 400 Then
            picMonster4.Top += 250
        End If
        If picHitbox7.Location.Y > 280 Then
            picHitbox7.Top -= 50
        ElseIf picHitbox7.Location.Y < 400 Then
            picHitbox7.Top += 250
        End If
    End Sub
    Private Sub picMonster10_Click(sender As Object, e As EventArgs) Handles picMonster10.Click
        Mon10kill = 1
    End Sub
    Private Sub picMonster3_Click(sender As Object, e As EventArgs) Handles picMonster3.Click
        Mon3kill = 1
    End Sub
    Private Sub picMonster2_Click(sender As Object, e As EventArgs) Handles picMonster2.Click
        Mon2kill = 1
    End Sub
    Private Sub picMonster4_Click(sender As Object, e As EventArgs) Handles picMonster4.Click
        Mon4kill = 1
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PicHelpMe.Click

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Static s1 As Boolean
        Static i As Long
        i = i + 1
        If i < 120 Then
            s1 = Not s1
            If s1 Then
                PicHelpMe.BackColor = Color.Black
                PicHelpMe.ForeColor = Color.Coral
            Else
                PicHelpMe.BackColor = Color.White
                PicHelpMe.ForeColor = Color.Beige
            End If
        Else
            Timer7.Enabled = False
            i = 0
        End If
    End Sub
End Class
