'Laura Riley
'RCET0265
'Spring 2021
'Diner Menu Program
'

Public Class DinerMenuForm

    'Displays the soup of the day
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "~Soup of the day~ " & vbCrLf & "Bacon Potoato Soup"
    End Sub

    'Displays the chefs special salad
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "~The Chefs Special~" & vbCrLf &
            "The salad is made from a special organic array of grasses and leaves" _
            & " with fresh berries added and topped with a crisp vinigret." _
            & "Your taste buds will thank you for generations to come."
    End Sub

    'Displays the fish of the day
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "~Fresh Found Fish~" & vbCrLf _
           & "Fish found in the area today is the Bluehead Sucker native to the Protneuf River" & vbCrLf _
           & "*Note: we are not responsible for any ill side effects of ingesting anything that " _
           & "comes from the Portneuf River."
    End Sub

    'Exits the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
