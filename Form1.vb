Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Text = Val(TextBox2.Text) + Val(TextBox3.Text) - Val(TextBox4.Text)
        ComboBox1.Items.Add("001")
        ComboBox1.Items.Add("002")
        ComboBox1.Items.Add("003")
        ComboBox1.Items.Add("004")
        ComboBox1.Items.Add("005")
        ComboBox2.Items.Add("Operator")
        ComboBox2.Items.Add("Engineer")
        ComboBox2.Items.Add("Staff")
        ComboBox2.Items.Add("Marketing")
        ComboBox3.Items.Add("Menikah")
        ComboBox3.Items.Add("Belum Menikah")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "001"
                TextBox1.Text = "Wawan"
            Case "002"
                TextBox1.Text = "Harsono"
            Case "003"
                TextBox1.Text = "Monica"
            Case "004"
                TextBox1.Text = "Soraya"
            Case "005"
                TextBox1.Text = "Faujan"
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Operator"
                TextBox2.Text = 10000000
            Case "Engineer"
                TextBox2.Text = 15000000
            Case "Staff"
                TextBox2.Text = 12500000
            Case "Marketing"
                TextBox2.Text = 17500000
        End Select
        TextBox4.Text = 0.1 * TextBox2.Text
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.Text
            Case "Menikah"
                TextBox3.Text = 0.1 * TextBox2.Text
            Case "Belum Menikah"
                TextBox3.Text = 0
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Yakin Mau Keluar?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) <> Windows.Forms.DialogResult.Yes Then
        Else
            Me.Close()
        End If
    End Sub

End Class
