Public Class ComboBoxForm
    'TODO remove global feilds after debug
    'up to 10 users Name, Age
    Dim userInfo(2, 1) As String 'Temp 3 users
    Dim userIndex As Integer = 0
    Const NAMEFIELDINDEX = 0I
    Const AGEFIELDINDEX = 1I
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
        End Try

        'TODO clear textboxes then select added item
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
    End Sub

    'Updates text boxes from aligned array
    Private Sub MainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainComboBox.SelectedIndexChanged

        Me.Text = MainComboBox.SelectedIndex
        userIndex = MainComboBox.SelectedIndex

        NameTextBox.Text = userInfo(userIndex, NAMEFIELDINDEX)
        AgeTextBox.Text = userInfo(userIndex, AGEFIELDINDEX)

    End Sub


    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Dim tempItem As String
        'TODO remove from array and combo box
        Try
            tempItem = MainComboBox.SelectedItem.ToString

            'TODO align array with combo box

            For Each item In userInfo
                Console.WriteLine(item)
            Next

            'MainComboBox.Items.Remove(MainComboBox.SelectedItem)
        Catch
        End Try
    End Sub

End Class
