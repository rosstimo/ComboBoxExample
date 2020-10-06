Public Class ComboBoxForm
    'TODO remove global fields after debug
    'up to 10 users Name, Age
    Dim userInfo(2, 1) As String 'Temp 3 users
    Dim userIndex As Integer = 0I
    Const NAMEFIELDINDEX% = 0I
    Const AGEFIELDINDEX% = 1I
    'IndexOutOfRangeException


    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

        'Load Name into ComboBox
        'MainComboBox.Items.Add(NameTextBox.Text)

        'Load Name and age into an array
        userIndex = CInt(MainComboBox.Items.Count) - 1

        'Add info to Array
        'IndexOutOfRangeException when array is full
        'TODO replace array with list or Dictionary
        Try
            userInfo(userIndex, NAMEFIELDINDEX) = NameTextBox.Text
            userInfo(userIndex, AGEFIELDINDEX) = AgeTextBox.Text
        Catch tooManyUsers As IndexOutOfRangeException
            'deal with problem
            MsgBox("Only 10 Users Please")
        Catch ex As Exception
            MsgBox($"Uh Oh!!{vbNewLine}{ex.Message}")
        End Try

        'TODO clear text boxes then select added item
        'NameTextBox.Text = ""
        'AgeTextBox.Text = ""
    End Sub

    Sub UpdateComboBox()
        MainComboBox.Items.Clear()

        For i = LBound(userInfo) To UBound(userInfo)
            If userInfo(i, NAMEFIELDINDEX%) <> "" Then
                MainComboBox.Items.Add(userInfo(i, NAMEFIELDINDEX%))
            End If
        Next
        'TODO if broke something
        If MainComboBox.SelectedIndex <> -1 Then
            MainComboBox.SelectedIndex = 0
        End If
        'MainComboBox.SelectNextControl()
    End Sub



    'Updates text boxes from aligned array
    Private Sub MainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainComboBox.SelectedIndexChanged

        Me.Text = MainComboBox.SelectedIndex

        userIndex% = MainComboBox.SelectedIndex

        NameTextBox.Text = userInfo(userIndex%, NAMEFIELDINDEX%)
        AgeTextBox.Text = userInfo(userIndex%, AGEFIELDINDEX%)

    End Sub


    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim tempItem As String
        Dim tempIndex As Integer

        Try

            tempIndex = MainComboBox.SelectedIndex
            userInfo(tempIndex, 0) = ""
            userInfo(tempIndex, 1) = ""

            'tempItem = MainComboBox.SelectedItem.ToString
            'MainComboBox.Items.Remove(tempItem)

        Catch
        End Try


        'Shift array

        For NameField = LBound(userInfo) To UBound(userInfo)
            If userInfo(NameField, 0) = "" And NameField <> UBound(userInfo) Then

                userInfo(NameField, 0) = userInfo(NameField + 1, 0)
                userInfo(NameField, 1) = userInfo(NameField + 1, 1)

            End If
        Next

        'TODO remove duplicates from array
        userInfo(UBound(userInfo), 0) = ""
        userInfo(UBound(userInfo), 1) = ""

        UpdateComboBox()
        NameTextBox.Text = ""
        AgeTextBox.Text = ""

        Console.Beep()

    End Sub

    Sub FakeData()
        userInfo(0, 0) = "Jim"
        userInfo(0, 1) = "23"
        userInfo(1, 0) = "Bob"
        userInfo(1, 1) = "43"
        userInfo(2, 0) = "Terry"
        userInfo(2, 1) = "12"
        'MainComboBox.Items.Add(userInfo(0, 0))
        'MainComboBox.Items.Add(userInfo(1, 0))
        'MainComboBox.Items.Add(userInfo(2, 0))

    End Sub

    Private Sub ComboBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FakeData()
        UpdateComboBox()
        RadioButton1.Checked = True
        EvaluateTextBoxes()

        'GoButton.Enabled = False
    End Sub

    Sub EvaluateTextBoxes() Handles NameTextBox.KeyUp, AgeTextBox.KeyUp

        If NameTextBox.Text <> "" And AgeTextBox.Text <> "" Then
            GoButton.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
        Else
            GoButton.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
        End If

    End Sub


End Class
