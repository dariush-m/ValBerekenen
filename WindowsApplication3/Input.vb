Public Class Input



    Public Density As Double



    Public Function MateriaalDichtheid(ByVal Material As String)
        Select Case Material
            Case "Goud"
                Return 19300
            Case "Zilver"
                Return 10490
            Case "Hout"
                Return 7500
            Case "IJzer"
                Return 7360
            Case "Lood"
                Return 11300
            Case Else
                Throw New System.Exception("Error: Er is geen materiaal geselecteerd!.")
        End Select

    End Function




    Private Sub Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMaterials.SelectedIndexChanged
        btnCustom.Checked = False
        btnMaterial.Checked = True


    End Sub

    Private Sub tbCustom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCustom.TextChanged
        btnCustom.Checked = True
        btnMaterial.Checked = False
    End Sub

    Private Sub TbCycles_TextChanged(sender As Object, e As EventArgs) Handles tbCycles.TextChanged
        cbCycles.Checked = True
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalc.Click



        If Not IsNumeric(tbRadius.Text) Or tbRadius.Text = "0" Then
            lblWarningRadius.Text = "Dit klopt niet"
            lblWarningRadius.Visible = True
        Else
            lblWarningRadius.Visible = False
        End If



        If Not IsNumeric(tbHeight.Text) Or tbHeight.Text = "0" Then
            lblWarningHeight.Text = "Dit klopt niet"
            lblWarningHeight.Visible = True
        Else
            lblWarningHeight.Visible = False
        End If


        If cbCycles.Checked Then

            If Not IsNumeric(tbCycles.Text) Then
                lblWarningCycles.Text = "Dit klopt niet"
                lblWarningCycles.Visible = True
            Else
                lblWarningCycles.Visible = False
            End If
        Else
            lblWarningCycles.Visible = False
        End If



        If btnMaterial.Checked Then

            If cbMaterials.SelectedItem = Nothing Then
                lblWarningMaterial.Text = "Dit klopt niet"
                lblWarningMaterial.Visible = True
            Else
                lblWarningMaterial.Visible = False
            End If
        End If

        If btnCustom.Checked Then

            If Not IsNumeric(tbCustom.Text) Then
                lblWarningCustom.Text = "Dit klopt niet"
                lblWarningCustom.Visible = True
            Else
                lblWarningCustom.Visible = False
            End If

        End If




        If IsNumeric(tbRadius.Text) And IsNumeric(tbHeight.Text) Then

            If cbCycles.Checked And IsNumeric(tbCycles.Text) Or Not cbCycles.Checked Then


                If btnMaterial.Checked Then

                    If Not cbMaterials.SelectedItem = Nothing Then


                        Density = MateriaalDichtheid(cbMaterials.SelectedItem)


                        Dim Calculation = New Calculation()
                        Calculation.Show()
                        Calculation.Simulation(cbCycles.Checked)


                    End If

                ElseIf btnCustom.Checked Then

                    If IsNumeric(tbCustom.Text) Then

                        Density = tbCustom.Text
                        Dim Calculation = New Calculation()
                        Calculation.Show()
                        Calculation.Simulation(cbCycles.Checked)

                    End If

                End If
            End If

        End If



    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears all textboxes
        tbRadius.Text = ""
        tbHeight.Text = ""
        tbCustom.Text = ""
        tbCycles.Text = ""

        'Resets all the selectabes
        cbMaterials.SelectedItem = Nothing
        btnCustom.Checked = False
        btnMaterial.Checked = True
        cbCycles.Checked = False

        'Resetting all warnings
        lblWarningRadius.Visible = False
        lblWarningHeight.Visible = False
        lblWarningMaterial.Visible = False
        lblWarningCustom.Visible = False
        lblWarningCycles.Visible = False

    End Sub


End Class