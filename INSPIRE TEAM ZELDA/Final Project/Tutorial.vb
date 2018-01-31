Public Class Tutorial
    Dim Mon1kill As Integer = 0
    Dim Mon2kill As Integer = 0

    Private Sub Tutorial_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim prevy As Integer = playerUp.Top
        Dim prevx As Integer = playerUp.Left

        Dim prevw As Integer = playerDown.Top
        Dim preve As Integer = playerDown.Left

        Dim prevr As Integer = playerRight.Top
        Dim prevt As Integer = playerRight.Left

        Dim prevj As Integer = playerLeft.Top
        Dim prevu As Integer = playerLeft.Left




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
        obsticle.Visible = False ' Invisible wall
        obsticle2.Visible = False
        obsticle3.Visible = False
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

        If testcollision(playerRight, obsticle7) = True Then
            playerRight.Top = prevr
            playerRight.Left = prevt
        End If
        If testcollision(playerRight, obsticle8) = True Then
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




        If testcollision(playerDown, Dungeon) = True Then
            Dungeon_1.ShowDialog()
        End If
    End Sub

    Function testcollision(ByRef pic1 As PictureBox, ByVal pic2 As PictureBox) As Boolean ' Collision function
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
        If Mon1kill = 1 Then
            If testcollision(playerDown, picHitbox1) = True Then
                Timer2.Enabled = False
                picMonster1.Visible = False
                picMonster1.Left = 0
            End If
            If testcollision(playerUp, picHitbox1) = True Then
                Timer2.Enabled = False
                picMonster1.Visible = False
                picMonster1.Left = 0
            End If
            If testcollision(playerRight, picHitbox1) = True Then
                Timer2.Enabled = False
                picMonster1.Visible = False
                picMonster1.Left = 0
            End If
            If testcollision(playerLeft, picHitbox1) = True Then
                Timer2.Enabled = False
                picMonster1.Visible = False
                picMonster1.Left = 0
            End If
        End If
        If Mon2kill = 1 Then
            If testcollision(playerDown, picHitbox2) = True Then
                Timer3.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerUp, picHitbox2) = True Then
                Timer3.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerRight, picHitbox2) = True Then
                Timer3.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
            If testcollision(playerLeft, picHitbox2) = True Then
                Timer3.Enabled = False
                picMonster2.Visible = False
                picMonster2.Left = 0
            End If
        End If
    End Sub
    Private Sub picMonster2_Click(sender As Object, e As EventArgs) Handles picMonster2.Click
        Mon2kill = 1
    End Sub
    Private Sub picMonster1_Click(sender As Object, e As EventArgs) Handles picMonster1.Click
        Mon1kill = 1
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If picMonster2.Location.Y > 375 Then
            picMonster2.Top -= 30
        ElseIf picMonster2.Location.Y < 545 Then
            picMonster2.Top += 175
        End If
        If picHitbox2.Location.Y > 375 Then
            picHitbox2.Top -= 30
        ElseIf picHitbox2.Location.Y < 545 Then
            picHitbox2.Top += 175
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If picMonster1.Location.X > 50 Then
            picMonster1.Left -= 50
        ElseIf picMonster1.Location.X < 300 Then
            picMonster1.Left += 375
        End If
        If picHitbox1.Location.X > 50 Then
            picHitbox1.Left -= 50
        ElseIf picHitbox1.Location.X < 300 Then
            picHitbox1.Left += 375
        End If
    End Sub
End Class