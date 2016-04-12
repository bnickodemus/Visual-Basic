

Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim maxheight, initialHeight, timeToMaxHeight, v As Double

        initialHeight = CDbl(TextBox1.Text)

        v = CDbl(TextBox2.Text)

        timeToMaxHeight = v / 32

        maxheight = initialHeight + v * (timeToMaxHeight) - 16 * (timeToMaxHeight) ^ 2

        MsgBox(maxheight & " feet")

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim v As Double = CDbl(TextBox2.Text)

        Dim initialheight As Double = CDbl(TextBox1.Text)

        Dim t, height As Double

        Dim hitsGround As Boolean = False

        CalculateTime(v, initialheight, t, height, hitsGround)

    End Sub



    Private Function CalculateTime(v As Double, initialHeight As Double, t As Double, Height As Double, hitsground As Boolean) As Double

        Do Until hitsground

            Height = CInt(initialHeight + v * t - 16 * t ^ 2)

            If Height <= 1 Then

                hitsground = True

            End If

            t += 0.1

        Loop

        Return MsgBox(t & " seconds")

    End Function



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim height As Double = CDbl(TextBox1.Text)

        ListBox1.Items.Clear()

        ListBox1.Items.Add("           Time" & "           Height")

        CalculateChart()

    End Sub



    Private Sub CalculateChart()

        Dim initialHeight As Double = CDbl(TextBox1.Text)

        Dim v As Double = CDbl(TextBox2.Text)

        Dim height, t As Double

        t = 0.0

        height = 0

        Dim hitsGround As Boolean = False

        WhenHitsGround(initialHeight, v, height, t, hitsGround)

    End Sub



    Private Sub WhenHitsGround(initialheight As Double, v As Double, height As Double, t As Double, hitsground As Boolean)

        Do Until hitsground

            Dim Str = height

            height = initialheight + v * t - 16 * t ^ 2

            ListBox1.Items.Add("            " & t.ToString("N") & "            " & height.ToString("N1"))

            t = CDec(t + 0.25)

            If height <= 1 Then

                hitsground = True

            End If

        Loop

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Close()

    End Sub



End Class
