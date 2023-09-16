

Public Class CashierForm


    Dim Selection = 1




    Private Sub btn_CASHIERLOGOUT_Click(sender As Object, e As EventArgs) Handles btn_CASHIERLOGOUT.Click
        Form1.Show()

        Me.Close()

        lbl_user.Text = ""






    End Sub

    Private Sub BTN_ALLITEMS_Click(sender As Object, e As EventArgs) Handles BTN_ALLITEMS.Click

        Selection = 1
        showitems()

    End Sub

    Private Sub BTN_FOOD_Click(sender As Object, e As EventArgs) Handles BTN_FOOD.Click

        Selection = 2
        showitems()
    End Sub

    Private Sub BTN_DRINKS_Click(sender As Object, e As EventArgs) Handles BTN_DRINKS.Click

        Selection = 3
        showitems()
    End Sub

    Private Sub BTN_DESERT_Click(sender As Object, e As EventArgs) Handles BTN_DESSERT.Click

        Selection = 4
        showitems()
    End Sub

    Private Sub CashierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start() ' Start a timer to update the date and time periodically

        showitems()

    End Sub


    Private Sub showitems()
        Select Case Selection
            Case 1
                ' Open PANEL_ALLITEMS
                Panel_ALLITEMS.Visible = True
                panel_FOOD.Visible = False
                Panel_DRINKS.Visible = False
                panel_DESSERT.Visible = False
            Case 2
                ' Open PANEL_FOOD
                Panel_ALLITEMS.Visible = False
                panel_FOOD.Visible = True
                Panel_DRINKS.Visible = False
                panel_DESSERT.Visible = False
            Case 3
                ' Open PANEL_DRINKS
                Panel_ALLITEMS.Visible = False
                panel_FOOD.Visible = False
                Panel_DRINKS.Visible = True
                panel_DESSERT.Visible = False
            Case 4
                ' Open PANEL_DESERT
                Panel_ALLITEMS.Visible = False
                panel_FOOD.Visible = False
                Panel_DRINKS.Visible = False
                panel_DESSERT.Visible = True
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the StatusLabel's text with the current date and time
        ToolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub UserActivity_Tick(sender As Object, e As EventArgs) Handles UserActivity.Tick
        LogoutUser()
    End Sub

    Private Sub CashierForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        UserActivity.Stop()
        UserActivity.Start()
    End Sub

    Private Sub LogoutUser()
        ' Add code here to perform logout actions, such as clearing session data and returning to the login page
        ' For example:

        Me.Close() ' Hide the current form
        Form1.Show()

        ' Show the login form
    End Sub

End Class