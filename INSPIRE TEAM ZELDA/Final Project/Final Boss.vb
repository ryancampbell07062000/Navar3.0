Public Class Final_Boss
    Dim Mon1kill As Integer = 0
    Dim Mon2kill As Integer = 0
    Dim Mon3kill As Integer = 0
    Dim Mon4kill As Integer = 0
    Dim Scorp1kill As Integer = 0
    Dim Scorp2kill As Integer = 0
    'Dim bomb2kill As Integer = 0
    'Dim bomb3kill As Integer = 0
    'Dim bomb5kill As Integer = 0
    'Dim bomb7kill As Integer = 0
    'Dim bomb8kill As Integer = 0
    'Dim bomb10kill As Integer = 0
    Private Property slides As Integer

    Private Sub Final_Boss_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim prevy As Integer = playerUp.Top
        Dim prevx As Integer = playerUp.Left

        Dim prevw As Integer = playerDown.Top
        Dim preve As Integer = playerDown.Left

        Dim prevr As Integer = playerRight.Top
        Dim prevt As Integer = playerRight.Left

        Dim prevj As Integer = playerLeft.Top
        Dim prevu As Integer = playerLeft.Left
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
                Dungeon_1.Close()

                Tutorial.Close()
                MenuZel.Close()
        End Select
        obsticle10.Visible = False ' Invisible wall
        obsticle11.Visible = False
        obsticle12.Visible = False
        obsticle13.Visible = False

        ' Return player to previous spot when he runs into wall

        ''''' UP'''''

        If testcollision(playerUp, obsticle) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle2) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        'If testcollision(playerUp, obsticle3) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        'End If
        'If testcollision(playerUp, obsticle4) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        'End If
        'If testcollision(playerUp, obsticle5) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        'End If

        'If testcollision(playerUp, obsticle7) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        'End If
        'If testcollision(playerUp, obsticle8) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        'End If
        'If testcollision(playerUp, obsticle9) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        '  End If
        If testcollision(playerUp, obsticle10) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle11) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle12) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle13) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle14) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If


        ' Return player to previous spot when he runs into wall
        ''''''DOWN''''''''''''''
        If testcollision(playerDown, obsticle) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle2) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        'If testcollision(playerDown, obsticle3) = True Then
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If
        'If testcollision(playerDown, obsticle4) = True Then
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If
        'If testcollision(playerDown, obsticle5) = True Then
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If

        'If testcollision(playerDown, obsticle7) = True Then
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If
        'If testcollision(playerDown, obsticle8) = True Then
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If
        'If testcollision(playerDown, obsticle9) = True Then
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If
        If testcollision(playerDown, obsticle10) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle11) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle12) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle13) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle14) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If



        ' Return player to previous spot when he runs into wall
        ''''LEFT'''''
        If testcollision(playerLeft, obsticle) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle2) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        'If testcollision(playerLeft, obsticle3) = True Then
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        'End If
        'If testcollision(playerLeft, obsticle4) = True Then
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        'End If
        'If testcollision(playerLeft, obsticle5) = True Then
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        'End If

        'If testcollision(playerLeft, obsticle7) = True Then
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        'End If
        'If testcollision(playerLeft, obsticle8) = True Then
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        'End If
        'If testcollision(playerLeft, obsticle9) = True Then
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        'End If
        If testcollision(playerLeft, obsticle10) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle11) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle12) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle13) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle14) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If


        ' Return player to previous spot when he runs into wall
        '''''''''RIGHT'''''''''
        If testcollision(playerRight, obsticle) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle2) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        'If testcollision(playerRight, obsticle3) = True Then
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        'End If
        'If testcollision(playerRight, obsticle4) = True Then
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        'End If
        'If testcollision(playerRight, obsticle5) = True Then
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        'End If

        'If testcollision(playerRight, obsticle7) = True Then
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        'End If
        'If testcollision(playerLeft, obsticle8) = True Then
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        'End If
        'If testcollision(playerRight, obsticle9) = True Then
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        'End If
        If testcollision(playerRight, obsticle10) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle11) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle12) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle13) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle14) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If


        ''''WIN GAME

        If testcollision(playerRight, princess) Then
            MessageBox.Show("You Win!")
        End If

        ''<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>'
        ' '''''''''Get Hurt ON LAVA TOUCH''''''''''''
        ''<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>'


        pbHealth.Value = PlayerStats.numHealth
        If testcollision(Lava1, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 10
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(Lava2, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 10
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(Lava3, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 10
        End If
    End Sub
    Function testcollision(ByRef pic1 As PictureBox, ByVal pic2 As PictureBox) As Boolean ' Collision Function
        If pic1.Top < pic2.Bottom And pic1.Left < pic2.Right And pic1.Bottom > pic2.Top And pic1.Right > pic2.Left Then
            Return True
        End If
        Return False
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        pbHealth.Value = PlayerStats.numHealth
        If testcollision(picMonster1, playerDown) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster1, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster1, playerRight) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
        If testcollision(picMonster1, playerLeft) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 3
        End If
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


        If testcollision(picScorp1, playerDown) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 4
        End If
        If testcollision(picScorp1, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 4
        End If
        If testcollision(picScorp1, playerRight) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 4
        End If
        If testcollision(picScorp1, playerLeft) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 4
        End If
        If testcollision(picScorp2, playerDown) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 4
        End If
        If testcollision(picScorp2, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 4
        End If
        If testcollision(picScorp2, playerRight) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 4
        End If
        If testcollision(picScorp2, playerLeft) = True Then
            PlayerStats.numHealth = PlayerStats.numHealth - 4
        End If

        'If testcollision(bomb1, playerLeft) = True Then
        '    PlayerStats.numHealth = PlayerStats.numHealth - 4
        'End If


        pbHealth.Value = PlayerStats.numHealth
        If testcollision(bomb2, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If

        pbHealth.Value = PlayerStats.numHealth
        If testcollision(bomb3, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(bomb5, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(bomb7, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(bomb8, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(bomb10, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If
       



        '<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>
        '>>>>>>>>>>>>>KILL MONSTERS<<<<<<<<<<<<<
        '<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>
        If Mon1kill = 1 Then
            If testcollision(playerDown, hitBox1) = True Then
                Mon1Timer.Enabled = False
                picMonster1.Visible = False
                picMonster1.Left = 0
            End If
            If testcollision(playerUp, hitBox1) = True Then
                Mon1Timer.Enabled = False
                picMonster1.Visible = False
                picMonster1.Left = 0
            End If
            If testcollision(playerRight, hitBox1) = True Then
                Mon1Timer.Enabled = False
                picMonster1.Visible = False
                picMonster1.Left = 0
            End If
            If testcollision(playerLeft, hitBox1) = True Then
                Mon1Timer.Enabled = False
                picMonster1.Visible = False
                picMonster1.Left = 0
            End If
        End If

        If Mon2kill = 1 Then
            If testcollision(playerDown, hitBox2) = True Then
                Mon2Timer.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerUp, hitBox2) = True Then
                Mon2Timer.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerRight, hitBox2) = True Then
                Mon2Timer.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerLeft, hitBox2) = True Then
                Mon2Timer.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
        End If

        If Mon3kill = 1 Then
            If testcollision(playerDown, hitBox3) = True Then
                Mon3Timer.Enabled = False
                picMonster3.Visible = False
                picMonster3.Left = 0
            End If
            If testcollision(playerUp, hitBox3) = True Then
                Mon3Timer.Enabled = False
                picMonster3.Visible = False
                picMonster3.Left = 0
            End If
            If testcollision(playerRight, hitBox3) = True Then
                Mon3Timer.Enabled = False
                picMonster3.Visible = False
                picMonster3.Left = 0
            End If
            If testcollision(playerLeft, hitBox3) = True Then
                Mon3Timer.Enabled = False
                picMonster3.Visible = False
                picMonster3.Left = 0
            End If
        End If
        If Mon4kill = 1 Then
            If testcollision(playerDown, hitBox4) = True Then
                Mon4Timer.Enabled = False
                picMonster4.Visible = False
                picMonster4.Left = 0
            End If
            If testcollision(playerUp, hitBox4) = True Then
                Mon4Timer.Enabled = False
                picMonster4.Visible = False
                picMonster4.Left = 0
            End If
            If testcollision(playerRight, hitBox4) = True Then
                Mon4Timer.Enabled = False
                picMonster4.Visible = False
                picMonster4.Left = 0
            End If
            If testcollision(playerLeft, hitBox4) = True Then
                Mon4Timer.Enabled = False
                picMonster4.Visible = False
                picMonster4.Left = 0
            End If
        End If

        If Scorp1kill = 1 Then
            If testcollision(playerDown, hitBox5) = True Then
                Scorp1Timer.Enabled = False
                picScorp1.Visible = False
                picScorp1.Left = 0
            End If
            If testcollision(playerUp, hitBox5) = True Then
                Scorp1Timer.Enabled = False
                picScorp1.Visible = False
                picScorp1.Left = 0
            End If
            If testcollision(playerRight, hitBox5) = True Then
                Scorp1Timer.Enabled = False
                picScorp1.Visible = False
                picScorp1.Left = 0
            End If
            If testcollision(playerLeft, hitBox5) = True Then
                Scorp1Timer.Enabled = False
                picScorp1.Visible = False
                picScorp1.Left = 0
            End If
        End If
        If Scorp2kill = 1 Then
            If testcollision(playerDown, hitBox6) = True Then
                Scorp2Timer.Enabled = False
                picScorp2.Visible = False
                picScorp2.Left = 0
            End If
            If testcollision(playerUp, hitBox6) = True Then
                Scorp2Timer.Enabled = False
                picScorp2.Visible = False
                picScorp2.Left = 0
            End If
            If testcollision(playerRight, hitBox6) = True Then
                Scorp2Timer.Enabled = False
                picScorp2.Visible = False
                picScorp2.Left = 0
            End If
            If testcollision(playerLeft, hitBox6) = True Then
                Scorp2Timer.Enabled = False
                picScorp2.Visible = False
                picScorp2.Left = 0
            End If
        End If



    End Sub

    Private Sub picMonster1_Click(sender As Object, e As EventArgs) Handles picMonster1.Click
        Mon1kill = 1
    End Sub

    Private Sub picMonster2_Click(sender As Object, e As EventArgs) Handles picMonster2.Click
        Mon2kill = 1
    End Sub

    Private Sub picMonster3_Click(sender As Object, e As EventArgs) Handles picMonster3.Click
        Mon3kill = 1
    End Sub

    Private Sub picMonster4_Click(sender As Object, e As EventArgs) Handles picMonster4.Click
        Mon4kill = 1
    End Sub

    Private Sub Mon1Timer_Tick(sender As Object, e As EventArgs) Handles Mon1Timer.Tick
        If picMonster1.Location.X > 200 Then
            picMonster1.Left -= 30
        ElseIf picMonster1.Location.X < 325 Then
            picMonster1.Left += 200
        End If
        If hitBox1.Location.X > 135 Then
            hitBox1.Left -= 30
        ElseIf hitBox1.Location.X < 325 Then
            hitBox1.Left += 200
        End If
    End Sub

    Private Sub Mon2Timer_Tick(sender As Object, e As EventArgs) Handles Mon2Timer.Tick
        If picMonster2.Location.X > 200 Then
            picMonster2.Left -= 30
        ElseIf picMonster2.Location.X < 325 Then
            picMonster2.Left += 200
        End If
        If hitBox2.Location.X > 135 Then
            hitBox2.Left -= 30
        ElseIf hitBox2.Location.X < 325 Then
            hitBox2.Left += 200
        End If
    End Sub

    Private Sub Mon3Timer_Tick(sender As Object, e As EventArgs) Handles Mon3Timer.Tick
        If picMonster3.Location.X > 680 Then
            picMonster3.Left -= 45
        ElseIf picMonster3.Location.X < 730 Then
            picMonster3.Left += 340
        End If
        If hitBox3.Location.X > 645 Then
            hitBox3.Left -= 45
        ElseIf hitBox3.Location.X < 730 Then
            hitBox3.Left += 340
        End If
    End Sub

    Private Sub Mon4Timer_Tick(sender As Object, e As EventArgs) Handles Mon4Timer.Tick
        If picMonster4.Location.X > 680 Then
            picMonster4.Left -= 45
        ElseIf picMonster4.Location.X < 730 Then
            picMonster4.Left += 340
        End If
        If hitBox4.Location.X > 645 Then
            hitBox4.Left -= 45
        ElseIf hitBox4.Location.X < 730 Then
            hitBox4.Left += 340
        End If

    End Sub

    Private Sub Scorp1Timer_Tick(sender As Object, e As EventArgs) Handles Scorp1Timer.Tick
        If picScorp1.Location.Y > 160 Then
            picScorp1.Top -= 25
        ElseIf picScorp1.Location.Y < 220 Then
            picScorp1.Top += 85
        End If
    End Sub

    Private Sub Scorp2Timer_Tick(sender As Object, e As EventArgs) Handles Scorp2Timer.Tick
        If picScorp2.Location.Y > 442 Then
            picScorp2.Top -= 25
        ElseIf picScorp2.Location.Y < 500 Then
            picScorp2.Top += 85
        End If
    End Sub

    Private Sub picScorp1_Click(sender As Object, e As EventArgs) Handles picScorp1.Click
        Scorp1kill = 1
    End Sub

    Private Sub picScorp2_Click(sender As Object, e As EventArgs) Handles picScorp2.Click
        Scorp2kill = 1
    End Sub

    Private Sub BossTimer_Tick(sender As Object, e As EventArgs) Handles BossTimer.Tick
        ' If bomb1.Location.X Then

        ' End If
    End Sub

    Private Sub Bomb2Timer_Tick(sender As Object, e As EventArgs) Handles Bomb2Timer.Tick
        If bomb2.Location.X > 710 Then
            bomb2.Left -= 30
        ElseIf bomb2.Location.X < 800 Then
            bomb2.Left += 150
        End If
    End Sub

    Private Sub Bomb3Timer_Tick(sender As Object, e As EventArgs) Handles Bomb3Timer.Tick
        If bomb3.Location.X > 710 Then
            bomb3.Left -= 30
        ElseIf bomb3.Location.X < 800 Then
            bomb3.Left += 150
        End If
    End Sub

    Private Sub Bomb7Timer_Tick(sender As Object, e As EventArgs) Handles Bomb7Timer.Tick
        If bomb7.Location.X < 1055 Then
            bomb7.Left += 30
        ElseIf bomb7.Location.X > 1000 Then
            bomb7.Left -= 150
        End If
    End Sub

    Private Sub Bomb8Timer_Tick(sender As Object, e As EventArgs) Handles Bomb8Timer.Tick
        If bomb8.Location.X < 1055 Then
            bomb8.Left += 30
        ElseIf bomb8.Location.X > 1000 Then
            bomb8.Left -= 150
        End If
    End Sub

    Private Sub Bomb5Timer_Tick(sender As Object, e As EventArgs) Handles Bomb5Timer.Tick
        If bomb5.Location.Y < 550 Then
            bomb5.Top += 30
        ElseIf bomb5.Location.Y > 420 Then
            bomb5.Top -= 150
        End If


    End Sub

    Private Sub bomb10Timer_Tick(sender As Object, e As EventArgs) Handles bomb10Timer.Tick
        If bomb10.Location.Y > 160 Then
            bomb10.Top -= 30
        ElseIf bomb10.Location.Y < 298 Then
            bomb10.Top += 150
        End If

      
    End Sub

    Private Sub bomb10_Click(sender As Object, e As EventArgs) Handles bomb10.Click

    End Sub

    Private Sub BOSS_Click(sender As Object, e As EventArgs) Handles BOSS.Click

    End Sub

    Private Function bomb1() As PictureBox
        Throw New NotImplementedException
    End Function

End Class