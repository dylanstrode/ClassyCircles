Public Class MainForm

    Private Circles(2) As CCircle

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Circles(0) = New CCircle(50, 50, 20)
        Circles(1) = New CCircle(150, 150, 30)
        Circles(2) = New CCircle(250, 50, 40)

    End Sub

    Private Sub Display_Paint(sender As Object, e As PaintEventArgs) Handles Display.Paint

        Dim g As Graphics

        g = e.Graphics

        For Each Circle In Circles
            Circle.Draw(g)
        Next


    End Sub
End Class
