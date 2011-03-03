Public Class Mini_Calculator
    Private Sub Btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
        lbl_Operator.Text = "+"
        lbl_Result.Text = CInt(Val(txt_FirstNumber.Text)) + CInt(Val(txt_SecondNumber.Text))
    End Sub

    Private Sub Btn_Subtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Subtract.Click
        lbl_Operator.Text = "-"
        lbl_Result.Text = CInt(Val(txt_FirstNumber.Text)) - CInt(Val(txt_SecondNumber.Text))
    End Sub

    Private Sub Btn_Multiplied_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Multiplied.Click
        lbl_Operator.Text = "x"
        lbl_Result.Text = CInt(Val(txt_FirstNumber.Text)) * CInt(Val(txt_SecondNumber.Text))
    End Sub

    Private Sub Btn_Divded_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Divded.Click
        lbl_Operator.Text = "%"
        Dim firstnumber As Integer
        If firstnumber = "0" Then
            MessageBox.Show("Please enter another value other then zero.")
        End If
        lbl_Result.Text = CInt(Val(txt_FirstNumber.Text)) / CInt(Val(txt_SecondNumber.Text))
    End Sub

    Private Sub Btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Clear.Click
        lbl_Operator.Text = ("")
        lbl_Result.Text = ("")
        txt_FirstNumber.Text = ("")
        txt_SecondNumber.Text = ("")
    End Sub

    Private Sub txt_FirstNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FirstNumber.TextChanged
        Dim int_LastCharacter As Integer = txt_FirstNumber.Text.Length - 1
        If int_LastCharacter > -1 Then
            If Char.IsDigit(txt_FirstNumber.Text(int_LastCharacter)) = False Then
                MessageBox.Show("Please ensure that you enter whole numbers only." & vbCrLf & vbCrLf & "Thank You")
                txt_FirstNumber.Clear()
            End If
        End If
    End Sub

    Private Sub txt_SecondNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SecondNumber.TextChanged
        Dim int_LastCharacter As Integer = txt_SecondNumber.Text.Length - 1
        If int_LastCharacter > -1 Then
            If Char.IsDigit(txt_SecondNumber.Text(int_LastCharacter)) = False Then
                MessageBox.Show("Please ensure that you enter numbers only." & vbCrLf & vbCrLf & "Thank You!")
                txt_SecondNumber.Clear()
            End If
        End If
    End Sub

    Private Sub Mini_Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
