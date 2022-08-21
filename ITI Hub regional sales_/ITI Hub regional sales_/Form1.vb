Public Class Form1

    Private Sub Displaybtn_Click(sender As Object, e As EventArgs) Handles Displaybtn.Click
        Dim ts(3, 6), totalsales, tsgp(6), tskzn(6), tswc(6), gp, kzn, wc, pgp, pkzn, pwc As Integer
        '''Use Array intializer to initialize ts(3,6) for Multi-dimensional Array
        tsgp(0) = 90000
        tsgp(1) = 85000
        tsgp(2) = 80000
        tsgp(3) = 83000
        tsgp(4) = 87000
        tsgp(5) = 80000

        tskzn(0) = 120000
        tskzn(1) = 190000
        tskzn(2) = 175000
        tskzn(3) = 188000
        tskzn(4) = 125000
        tskzn(5) = 163000

        tswc(0) = 65000
        tswc(1) = 64000
        tswc(2) = 71000
        tswc(3) = 67000
        tswc(4) = 65000
        tswc(5) = 64000

        For i As Integer = 0 To tsgp.Length - 1 ''// tsqp.lenght
            gp = gp + tsgp(i)
            wc = wc + tswc(i)
            kzn = kzn + tskzn(i)
        Next i
        totalsales = gp + wc + kzn
        tb1.Text = "R " & gp
        tb2.Text = "R " & kzn
        tb3.Text = "R " & wc
        tb4.Text = "R " & totalsales

        pgp = gp / totalsales * 100
        pwc = wc / totalsales * 100
        pkzn = kzn / totalsales * 100

        tb7.Text = pgp & " %"
        tb6.Text = pkzn & " %"
        tb5.Text = pwc & " %"

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub
End Class
