Public Class Form1
    Private game As Game
    Private blnSameColors As Boolean

    Public Sub New(blnChecked As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        blnSameColors = blnChecked
    End Sub

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        game = New Game(Me)
        game.Start(blnSameColors)
    End Sub

    Private Sub BlueBtn_Click(sender As Object, e As EventArgs) Handles BlueBtn.Click
        game.HandeButtonPress(Color.Blue)
    End Sub

    Private Sub RedBtn_Click(sender As Object, e As EventArgs) Handles RedBtn.Click
        game.HandeButtonPress(Color.Red)
    End Sub

    Private Sub YellowBtn_Click(sender As Object, e As EventArgs) Handles YellowBtn.Click
        game.HandeButtonPress(Color.Yellow)
    End Sub

    Private Sub OrangeBtn_Click(sender As Object, e As EventArgs) Handles OrangeBtn.Click
        game.HandeButtonPress(Color.Orange)
    End Sub

    Private Sub PurpleBtn_Click(sender As Object, e As EventArgs) Handles PurpleBtn.Click
        game.HandeButtonPress(Color.Purple)
    End Sub

    Private Sub GreenBtn_Click(sender As Object, e As EventArgs) Handles GreenBtn.Click
        game.HandeButtonPress(Color.Green)
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        game.deleteChosenColors()
    End Sub

    Private Sub restartBtn_Click(sender As Object, e As EventArgs) Handles restartBtn.Click
        game.Start(CheckBox1.Checked)
        restartBtn.Visible = False
        CheckBox1.Visible = False
    End Sub

    Private Sub GuessBtn_Click(sender As Object, e As EventArgs) Handles GuessBtn.Click
        game.Guess()
    End Sub
End Class
