Public Class MenuZel
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        Tutorial.Timer1.Interval = 400
        Tutorial.Timer2.Interval = 400
        Tutorial.Timer3.Interval = 400
        Dungeon_1.Timer1.Interval = 400
        Dungeon_1.Timer2.Interval = 400
        Dungeon_1.Timer3.Interval = 400
        Dungeon_1.Timer4.Interval = 400
        Dungeon_1.Timer5.Interval = 400
        Dungeon_1.Timer6.Interval = 400
        Dungeon_Up.Timer1.Interval = 400
        Dungeon_Up.Timer2.Interval = 400
        Dungeon_Up.Timer3.Interval = 400
        'Final_Boss.Timer1.Interval = 400
        'Final_Boss.Timer1.Interval = 400
        'Final_Boss.Timer1.Interval = 400
        'Final_Boss.Timer1.Interval = 400
        'Final_Boss.Timer1.Interval = 400
        'Final_Boss.Timer1.Interval = 400


        Tutorial.ShowDialog()

    End Sub
    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        Tutorial.Timer1.Interval = 300
        Tutorial.Timer2.Interval = 300
        Tutorial.Timer3.Interval = 300
        Dungeon_1.Timer1.Interval = 300
        Dungeon_1.Timer2.Interval = 300
        Dungeon_1.Timer3.Interval = 300
        Dungeon_1.Timer4.Interval = 300
        Dungeon_1.Timer5.Interval = 300
        Dungeon_1.Timer6.Interval = 300
        Dungeon_Up.Timer1.Interval = 300
        Dungeon_Up.Timer2.Interval = 300
        Dungeon_Up.Timer3.Interval = 300
        Tutorial.ShowDialog()
    End Sub
    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        Tutorial.Timer1.Interval = 50
        Tutorial.Timer2.Interval = 50
        Tutorial.Timer3.Interval = 50
        Dungeon_1.Timer1.Interval = 50
        Dungeon_1.Timer2.Interval = 50
        Dungeon_1.Timer3.Interval = 50
        Dungeon_1.Timer4.Interval = 50
        Dungeon_1.Timer5.Interval = 50
        Dungeon_1.Timer6.Interval = 50
        Dungeon_Up.Timer1.Interval = 50
        Dungeon_Up.Timer2.Interval = 50
        Dungeon_Up.Timer3.Interval = 50
        Tutorial.ShowDialog()
    End Sub
    Private Sub MenuZel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    My.Computer.Audio.Play(My.Resources.Title_Theme, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Hero_Of_Inspiration_Medley_1_, AudioPlayMode.BackgroundLoop)
    End Sub
End Class