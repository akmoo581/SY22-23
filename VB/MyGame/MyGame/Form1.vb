Public Class Form1
    Const Speed As Integer = 10
    Dim direction As Point

    'This is where you can handle any collisions in the game
    '
    '  p1 has collided with p2
    '  you can return true to let it go through it
    '  or 
    '  you can return false to not let it go through
    '
    '  you could also do other actions like change directions or add points etc.
    Public Function Collision(p1 As PictureBox, p2 As PictureBox) As Boolean
        Debug.Print(p1.Name + " ran into " + p2.Name)

        'Any pictureboxes whose name start with TARGET that get run into will be removed
        If p2.Name.ToUpper.StartsWith("TARGET") Then 'remove targets when they are hit
            Remove(p2)
        End If

        'Any BULLET pictures will be removed when they collide
        If p1.Name.ToUpper.StartsWith("BULLET") Then
            '(don't remove them if they collide with the player - like when they start out
            If Not p2.Name.ToUpper.StartsWith("PLAYER") Then 'remove bullets when they collide with others
                Remove(p1)
            End If
        End If

        'Anything that runs into a wall will stop
        If p2.Name.ToUpper.StartsWith("WALL") Then
            Return False 'don't let anything through walls
        End If

        'if none of the above happened, let the object move
        Return True ' let it move
    End Function

    'Handle the keyboard - you could add your own keys if you wanted
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.W
                direction = New Point(0, -Speed)
                moveto(player, 0, -Speed)
            Case Keys.S
                direction = New Point(0, Speed)
                moveto(player, 0, Speed)
            Case Keys.A
                direction = New Point(-Speed, 0)
                moveto(player, -Speed, 0)
            Case Keys.D
                direction = New Point(Speed, 0)
                moveto(player, Speed, 0)
            Case Keys.Space
                'Add a bullet in the direction the player is facing
                '  AddAt(BulletPictureBox2, Player.Location, direction)
        End Select
    End Sub

    'You can make items appear using a time
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim r As New Random
        AddAt(p2, New Point(r.Next), "CHASE")
        AddAt(P6, New Point(r.Next), "FOLLOW")
        AddAt(P7, New Point(r.Next), "RANDOM")
        AddAt(P4, New Point(r.Next), "RANDOM")
        AddAt(P8, New Point(r.Next), "RANDOM")
        AddAt(P3, New Point(r.Next), "CHASE")
        AddAt(P10, New Point(r.Next), "CHASE")
        AddAt(P5, New Point(r.Next), "CHASE")
        AddAt(P9, New Point(r.Next), "FOLLOW")
    End Sub


    'Don't mess with the code below, this updates the game
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateGame()
        moveto(p2, 0, -Speed)
        moveto(P3, 0, -Speed)
        moveto(P4, 0, -Speed)
        moveto(P5, 0, -Speed)
        moveto(P6, 0, -Speed)
        moveto(P7, 0, -Speed)
        moveto(P8, 0, -Speed)
        moveto(P9, 0, -Speed)
        moveto(P10, 0, -Speed)
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As New Random
        AddAt(P5, New Point(r.Next), New Point(100, 200))
        AddAt(P5, New Point(64, 78), New Point(0, -10))
    End Sub
End Class
