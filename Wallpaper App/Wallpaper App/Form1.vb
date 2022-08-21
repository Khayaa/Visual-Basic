Public Class Form1

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Calculatebtn_Click(sender As Object, e As EventArgs) Handles Calculatebtn.Click
        Calculate_Singleroll()
    End Sub

    Sub Calculate_Singleroll()
        Dim length_, width_, height_, roll_cov, single_roll, s_area As Double

        length_ = Convert.ToDouble(length.Text)
        width_ = Convert.ToDouble(width.Text)
        height_ = Convert.ToDouble(height.Text)
        roll_cov = Convert.ToDouble(rollcov.Text)


        s_area = (length_ * height_ * 2) + (width_ * height_ * 2)
        single_roll = Math.Ceiling(s_area / roll_cov)
        s_roll.Text = single_roll


    End Sub

    Private Sub height_SelectedValueChanged(sender As Object, e As EventArgs) Handles height.SelectedValueChanged
        s_roll.Clear()
    End Sub

    Private Sub width_SelectedValueChanged(sender As Object, e As EventArgs) Handles width.SelectedValueChanged
        s_roll.Clear()
    End Sub

    Private Sub length_SelectedValueChanged(sender As Object, e As EventArgs) Handles length.SelectedValueChanged
        s_roll.Clear()
    End Sub

    Private Sub rollcov_SelectedValueChanged(sender As Object, e As EventArgs) Handles rollcov.SelectedValueChanged
        s_roll.Clear()
    End Sub
End Class
