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
        MainComboBox.Items.Add(NameTextBox.Text)

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

        'TODO clear textboxes then select added item
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
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

        'TODO remove from array and combo box
        Try

            tempIndex = MainComboBox.SelectedIndex
            userInfo(tempIndex, 0) = ""
            userInfo(tempIndex, 1) = ""

            tempItem = MainComboBox.SelectedItem.ToString
            MainComboBox.Items.Remove(tempItem)
            'TODO align array with combo box


            'MainComboBox.Items.Remove(MainComboBox.SelectedItem)
        Catch
        End Try

        'For Each item In userInfo
        '    Console.WriteLine(item)
        '    If item = "" Then
        '        Console.WriteLine("Got One")
        '    End If
        'Next

        'For ageFeild = 0 To 1
        For NameField = 0 To 2
            If userInfo(NameField, 0) = "" Then
                userInfo(NameField, 0) = userInfo(NameField + 1, 0)
                userInfo(NameField, 1) = userInfo(NameField + 1, 1)
                'TODO remove duplicates from array
                'TODO display current contents of Array as is
            End If
        Next
        'Next

    End Sub

    Sub FakeData()
        userInfo(0, 0) = "Jim"
        userInfo(0, 1) = "23"
        userInfo(1, 0) = "Bob"
        userInfo(1, 1) = "43"
        userInfo(2, 0) = "Terry"
        userInfo(2, 1) = "12"
        MainComboBox.Items.Add(userInfo(0, 0))
        MainComboBox.Items.Add(userInfo(1, 0))
        MainComboBox.Items.Add(userInfo(2, 0))

    End Sub

    Private Sub ComboBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FakeData()
    End Sub
End Class
