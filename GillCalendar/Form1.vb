Public Class Form1
    'TODO: Change and sync music to Bazzi - Smile
    Dim sngCount As Single
    Dim strDate As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sngCount = 0
        strDate = dtpDate.Value.Second
        Me.BackgroundImage = GillCalendar.My.Resources.Gill1
        My.Computer.Audio.Play(My.Resources.kalinkawav, AudioPlayMode.BackgroundLoop)
        StartPosition = FormStartPosition.Manual
        Location = New Point(Rnd() * 2000, Rnd() * 600)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If strDate.Equals(dtpDate.Value.Second) = False Then
            sngCount = sngCount + 1
            If sngCount Mod 21 = 0 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill1
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 1 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill2
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 2 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill3
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 3 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill4
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 4 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill5
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 5 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill6
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 6 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill7
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 7 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill8
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 8 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill9
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 9 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill10
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 10 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill11
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 11 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill12
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 12 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill13
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 13 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill14
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 14 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill15
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 15 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill16
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 16 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill17
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 17 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill18
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 18 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill19
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 19 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill20
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            ElseIf sngCount Mod 21 = 20 Then
                Me.BackgroundImage = GillCalendar.My.Resources.Gill21
                Me.BackgroundImageLayout = BackgroundImageLayout.Stretch
            End If
            Timer1.Interval = Timer1.Interval * 0.993
        End If
    End Sub
End Class
