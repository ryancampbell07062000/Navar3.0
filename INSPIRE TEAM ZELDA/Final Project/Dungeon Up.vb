Public Class Dungeon_Up

    Private Property slides As Integer

    Private Property firstClicked As Object

    Private Property secondClicked As Object

    Private Property Visable As PictureBox

    'Private Property pbHealth As Object



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim prevy As Integer = playerUp.Top
        Dim prevx As Integer = playerUp.Left

        Dim prevw As Integer = playerUp.Top
        Dim preve As Integer = playerUp.Left

        Dim prevr As Integer = playerRight.Top
        Dim prevt As Integer = playerRight.Left

        Dim prevj As Integer = playerLeft.Top
        Dim prevu As Integer = playerLeft.Left


        '<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>
        ''''''Move Player With Keys'''''
        '<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>
        Select Case e.KeyCode
            Case Keys.Up

                playerRight.Top -= 17

                playerRight.Visible = False
                playerUp.Visible = True
                playerUp.Top -= 17
                playerLeft.Visible = False
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
                Final_Boss.Close()
                MenuZel.Close()
        End Select


        obsticle.Visible = False 'Invisible wall
        obsticle2.Visible = False
        obsticle3.Visible = False
        obsticle4.Visible = False
        obsticle5.Visible = False
        obsticle6.Visible = False
        obsticle7.Visible = False
        obsticle8.Visible = False
        ' obsticle11.Visible = False
        'down.Visible = False

        '<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ' Return player to previous spot when he runs into wall
        '<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        If testcollision(playerUp, obsticle) = True Then
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
        'If testcollision(playerUp, obsticle9) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        'End If
        'If testcollision(playerUp, obsticle10) = True Then
        '    playerUp.Top = prevj
        '    playerUp.Left = prevu
        'End If
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
        If testcollision(playerUp, obsticle15) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle16) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle17) = True Then
            playerUp.Top = prevj
            playerUp.Left = prevu
        End If
        If testcollision(playerUp, obsticle18) = True Then
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
        'If testcollision(playerDown, obsticle9) = True Then
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If
        'If testcollision(playerDown, obsticle10) = True Then
        '    playerDown.Top = prevw
        '    playerDown.Left = preve
        'End If
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
        If testcollision(playerDown, obsticle15) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle16) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle17) = True Then
            playerDown.Top = prevw
            playerDown.Left = preve
        End If
        If testcollision(playerDown, obsticle18) = True Then
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
        'If testcollision(playerLeft, obsticle9) = True Then
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        'End If
        'If testcollision(playerLeft, obsticle10) = True Then
        '    playerLeft.Top = prevy
        '    playerLeft.Left = prevx
        'End If
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
        If testcollision(playerLeft, obsticle15) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle16) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle17) = True Then
            playerLeft.Top = prevy
            playerLeft.Left = prevx
        End If
        If testcollision(playerLeft, obsticle18) = True Then
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
        'If testcollision(playerRight, obsticle9) = True Then
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        'End If
        'If testcollision(playerRight, obsticle10) = True Then
        '    playerRight.Top = prevr
        '    playerRight.Left = prevt
        'End If
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
        If testcollision(playerRight, obsticle15) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle16) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle17) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle18) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If



        If testcollision(playerUp, down) = True Then
            Me.Close()
        End If

        If testcollision(playerRight, picKey) Then
            picKey.Visible = False
        End If
        If picKey.Visible = False Then
            Dungeon_1.obsKey.Left = 0
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
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(Lava4, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 10
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(Lava5, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 10
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(Lava6, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 10
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(Lava7, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 10
        End If
        pbHealth.Value = PlayerStats.numHealth
        If testcollision(Lava8, playerUp) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 10
        End If
        'Dim fireballs(3) As PictureBox
        'fireballs(1) = FireDown2
        'fireballs(2) = FireMid2
        'fireballs(3) = FireTop2

        'For index As Integer = 1 To 3
        '    If fireballs(index).Location.X > 320 Then
        '        fireballs(index).Left -= 10
        '    ElseIf fireballs(index).Location.X < 400 Then
        '        fireballs(index).Left += 580
        '    End If

        'Next
        'FireMid2.Location = FireMid2 * 2



      
    End Sub

    Function testcollision(ByRef pic1 As PictureBox, ByVal pic2 As PictureBox) As Boolean ' Collision function
        If pic1.Top < pic2.Bottom And pic1.Left < pic2.Right And pic1.Bottom > pic2.Top And pic1.Right > pic2.Left Then
            Return True
        End If
        Return False
    End Function

    'Private Function obsticle11() As PictureBox
    '    Throw New NotImplementedException
    'End Function

    Private Function FireUp() As Object
        Throw New NotImplementedException
    End Function

    Private Function FireUp2() As Object
        Throw New NotImplementedException
    End Function

    Private Function FireUp3() As Object
        Throw New NotImplementedException
    End Function

    Private Function Fireball() As Object
        Throw New NotImplementedException
    End Function

    Private Function Fireball2() As Object
        Throw New NotImplementedException
    End Function

    Private Function Fireball3() As Object
        Throw New NotImplementedException
    End Function



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim fireballs(3) As PictureBox
        'fireballs(1) = FireDown2
        'fireballs(2) = FireMid2
        'fireballs(3) = FireTop2

        'For index As Integer = 1 To 3
        '    If fireballs(index).Location.X > 320 Then
        '        fireballs(index).Left -= 10
        '    ElseIf fireballs(index).Location.X < 400 Then
        '        fireballs(index).Left += 580
        '    End If

        'Next
        'FireMid2.Location = FireMid2 * 2
        If FireTop2.Location.X > 320 Then
            FireTop2.Left -= 5
        ElseIf FireTop2.Location.X < 400 Then
            FireTop2.Left += 580
        End If


        If FireMid2.Location.X > 320 Then
            FireMid2.Left -= 10
        ElseIf FireMid2.Location.X < 400 Then
            FireMid2.Left += 580
        End If


        If FireDown2.Location.X > 320 Then
            FireDown2.Left -= 5
        ElseIf FireDown2.Location.X < 400 Then
            FireDown2.Left += 580
        End If

        If FireMT.Location.X > 320 Then
            FireMT.Left -= 20
        ElseIf FireMT.Location.X < 400 Then
            FireMT.Left += 580
        End If

        If FireMD.Location.X > 320 Then
            FireMD.Left -= 20
        ElseIf FireMD.Location.X < 400 Then
            FireMD.Left += 580
        End If


        pbHealth.Value = PlayerStats.numHealth
        If testcollision(FireDown2, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If

        pbHealth.Value = PlayerStats.numHealth
        If testcollision(FireMid2, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If

        pbHealth.Value = PlayerStats.numHealth
        If testcollision(FireTop2, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If

        pbHealth.Value = PlayerStats.numHealth
        If testcollision(FireMT, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If

        pbHealth.Value = PlayerStats.numHealth
        If testcollision(FireMD, playerRight) Then
            PlayerStats.numHealth = PlayerStats.numHealth - 5
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        

    End Sub

    Private Function KeyCode() As Object
        Throw New NotImplementedException
    End Function



    Private Sub FireMid2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dungeon_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbHealth.Value = PlayerStats.numHealth
    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles obsticle17.Click

    End Sub
End Class