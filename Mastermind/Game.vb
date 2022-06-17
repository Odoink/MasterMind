Public Class Game
    Private lstSelectedColors As List(Of Color)
    Public lstPossibleColors As New List(Of Color)({Color.Red, Color.Blue, Color.Orange, Color.Yellow, Color.Green, Color.Purple})
    Private lstCode As New List(Of Color)
    Private lstBoard = New List(Of List(Of Label))
    Private MainForm As Form1
    Private currentTry As Integer
    Const intCodeLength = 3
    Const intMaxTries = 11 '11 omdat 0 naar 11 12 is'
    Const intMaxSameColors = 2

    Public Sub New(form As Form1)
        MainForm = form
        lstSelectedColors = New List(Of Color)
    End Sub

    'Execute funcion if code is solved or no more tries left'
    Public Sub OnEnd(result As Boolean)
        lstCode.Clear()
        MainForm.CheckBox1.Visible = True
        Dim buttonLst = MainForm.Controls.OfType(Of Button)
        For i = 0 To buttonLst.Count - 1 Step 1
            If buttonLst(i).Name = "restartBtn" Then
                buttonLst(i).Visible = True
            Else
                buttonLst(i).Enabled = False
            End If
        Next

        'show message determind by result'
        If result Then
            MessageBox.Show($"Code opgelost na {currentTry + 1} beurten.")
        Else
            MessageBox.Show("Helaas, code is niet opgelost")
        End If


    End Sub



    Private Sub EnableButtons()
        Dim btnList = MainForm.Controls.OfType(Of Button)
        For i = 0 To btnList.Count - 1 Step 1
            btnList(i).Enabled = True
        Next
    End Sub

    Public Sub Guess()
        If lstSelectedColors.Count = 4 Then
            Dim result = CheckWin()
            ShowResult(result)
            currentTry += 1
            lstSelectedColors.Clear()
        End If
    End Sub

    Public Sub Start(Optional maxSameColors As Boolean = Nothing)
        ClearBoard()
        EnableButtons()
        CreateBoard()
        CreateCode(maxSameColors)
        currentTry = 0
    End Sub

    'Create the code'
    Private Sub CreateCode(Optional boolMaxSameColors As Boolean = Nothing)
        Dim intMaxSameColors = 1
        If boolMaxSameColors Then
            intMaxSameColors = 2
        End If
        Dim rnd = New Random()
        For i = 0 To intCodeLength Step 1
            Dim intIdx = rnd.Next(0, lstPossibleColors.Count)
            Dim colors = lstCode.FindAll(Function(c) c.Name = lstPossibleColors(intIdx).Name)
            Dim blnColorStatus = colors.Count >= intMaxSameColors
            Debug.WriteLine($"{colors.Count > intMaxSameColors}")
            While blnColorStatus
                intIdx = rnd.Next(0, lstPossibleColors.Count)
                colors = lstCode.FindAll(Function(c) c.Name = lstPossibleColors(intIdx).Name)
                blnColorStatus = colors.Count >= intMaxSameColors
            End While

            lstCode.Add(lstPossibleColors(intIdx))
            Debug.WriteLine($"{lstPossibleColors(intIdx).Name}")
        Next

    End Sub

    Private Function IsInCorrectPlace() As List(Of Boolean)
        Dim correctPositions = New List(Of Boolean)
        For i = 0 To intCodeLength Step 1
            correctPositions.Add(lstCode(i) = lstSelectedColors(i))
            Debug.WriteLine($"{lstCode(i) = lstSelectedColors(i)}")
        Next
        Return correctPositions
    End Function

    Public Function CheckWin() As List(Of Color)
        If currentTry = 11 Then
            OnEnd(False)
        End If

        Dim lstResult = New List(Of Color)({Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow})
        Dim lstCorrectPositions = IsInCorrectPlace()
        Dim codeCopy = lstCode.ToList()
        Dim intCorrectCounter As Integer = 0
        For i = 0 To intCodeLength Step 1
            If lstCorrectPositions(i) Then
                lstResult(i) = Color.Red
                codeCopy(i) = Color.Black
                intCorrectCounter += 1
            End If
        Next
        For i = 0 To intCodeLength Step 1
            If codeCopy.Contains(lstSelectedColors(i)) And Not lstCorrectPositions(i) Then
                lstResult(i) = Color.White
                codeCopy(codeCopy.IndexOf(lstSelectedColors(i))) = Color.Black
            End If
        Next
        If intCorrectCounter = 4 Then
            OnEnd(True)
        End If
        Return lstResult
    End Function

    Private Sub ShowResult(result As List(Of Color))
        'Sorteer list bij kleurnaam alfabetisch'
        Dim data = From f In result Order By f.Name
        Dim dataList = data.ToList()
        'Verander Geel naar Grijs'
        For i As Integer = 0 To 3 Step 1
            If Equals(dataList(i), Color.Yellow) Then
                dataList(i) = Color.DarkGray
            End If
        Next
        For i As Integer = 0 To result.Count - 1 Step 1
            Debug.WriteLine($"{data(i)}")
        Next
        'resultaat zijn de onderste 4 labels'
        For i = 4 To 7 Step 1
            Dim resultLabel As Label = lstBoard(currentTry)(i)
            resultLabel.BackColor = dataList(i - 4)
            'Debug.WriteLine($"{currentTry}")
        Next
        'Dim testLabel As Label = lstBoard(7)(2)
        'testLabel.BackColor = Color.Red
    End Sub
    'On button pressed'

    Private Sub ShowSelectedColor()
        For i = 0 To lstSelectedColors.Count - 1 Step 1
            Dim label As Label = lstBoard(currentTry)(i)
            label.BackColor = lstSelectedColors(i)
        Next
    End Sub
    Public Sub HandeButtonPress(color As Color)
        If lstSelectedColors.Count < 4 Then
            Dim colorCount = lstSelectedColors.FindAll(Function(c) c.Name = color.Name)
            If colorCount.Count < 2 Then
                lstSelectedColors.Add(color)
                ShowSelectedColor()
            End If
        End If
    End Sub

    'Create the board'
    Public Sub CreateBoard()
        Dim yPos = 60
        For x = 0 To intMaxTries Step 1
            Dim lstRow = New List(Of Label)
            For y = 0 To 7 Step 1
                Dim lblBox = New Label()
                'lblBox.Tag = New Coordinates(x, y
                lblBox.BackColor = Color.Gray
                lblBox.AutoSize = False
                lblBox.Size = New Size(60, 60)
                If y < 4 Then
                    lblBox.Location = New Point(y * 60, x * 60)
                Else
                    lblBox.Location = New Point(y * 60 + 60, x * 60)
                End If

                lblBox.Margin = New Padding(100, 100, 0, 0)
                lblBox.BorderStyle = BorderStyle.Fixed3D
                MainForm.pnlBox.Controls.Add(lblBox)
                lstRow.Add(lblBox)

            Next
            yPos += 60
            lstBoard.Add(lstRow)
        Next
    End Sub

    'Verwijder gekozen kleuren als de keuze nog niet definitief is'
    Public Sub deleteChosenColors()
        lstSelectedColors.Clear()
        For i = 0 To 3 Step 1
            Dim label As Label = lstBoard(currentTry)(i)
            label.BackColor = Color.Gray
        Next
    End Sub

    'Maak bord leeg'
    Private Sub ClearBoard()
        If lstBoard.Count > 0 Then
            For i = 0 To intMaxTries Step 1
                For j = 0 To 7 Step 1
                    Dim label As Label = lstBoard(i)(j)
                    label.BackColor = Color.Gray
                Next
            Next
        End If
    End Sub

End Class