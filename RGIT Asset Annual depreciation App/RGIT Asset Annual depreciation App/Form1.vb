Public Class Form1
    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Displaybtn_Click(sender As Object, e As EventArgs) Handles Displaybtn.Click
        Dim asset_cost, salvage_value, double_dec, sumofyear As Double
        Dim useful_life As Integer

        asset_cost = Convert.ToDouble(Asset.Text)
        salvage_value = Convert.ToDouble(salvage.Text)
        useful_life = Convert.ToInt32(Usefulcombo.Text)

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        For i As Integer = 1 To useful_life

            double_dec = Financial.DDB(asset_cost, salvage_value, useful_life, i)
            sumofyear = Financial.SYD(asset_cost, salvage_value, useful_life, i)
            ListBox1.Items.Add(i & vbTab & Math.Round(double_dec, 2))
            ListBox2.Items.Add(i & vbTab & Math.Round(sumofyear, 2))
        Next i
    End Sub
End Class
