Imports MySql.Data.MySqlClient

Public Class Form1

    Dim Attempt As Integer = 1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Tb_Password.UseSystemPasswordChar = True

        tb_admin_password.UseSystemPasswordChar = True







    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login_Cashier.Click



        If Attempt <= 3 Then
            Dim Username As String = Tb_Username.Text
            Dim Password As String = Tb_Password.Text


            If String.IsNullOrEmpty(Username) And String.IsNullOrEmpty(Password) Then
                MessageBox.Show("Please fill out properly!")
                Return
            End If

            Try
                connectDB()

                Dim sql As String = "SELECT * FROM login WHERE username = @Username AND password = @Password And isactive = 1 and  UserRole = 'Cashier'"

                Using myCmd As New MySqlCommand(sql, myConn)
                    myCmd.Parameters.AddWithValue("@Username", Username)
                    myCmd.Parameters.AddWithValue("@Password", Password)

                    Using reader As MySqlDataReader = myCmd.ExecuteReader()

                        If reader.Read() Then

                            MessageBox.Show("Logged in Succesfully.")

                            CashierForm.lbl_user.Text = "Hello, " + Tb_Username.Text

                            CashierForm.Show()
                            Tb_Password.Clear()
                            Tb_Username.Clear()


                            Me.Close()


                        Else

                            MessageBox.Show("Invalid login remaining attempt:" & 3 - Attempt)

                            Tb_Password.Clear()

                            Attempt += 1


                        End If
                    End Using
                End Using




                'Module1.ConfirmLogin()
                'Me.Close()









            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try



        Else
            MessageBox.Show("Max attempt is already used")

        End If



    End Sub

    Sub CaplslockState()


        If Control.IsKeyLocked(Keys.CapsLock) Then
            lbl_CaplockIndi.Visible = True
            lbl_CaplockIndi.ForeColor = Color.Green
            lbl_capslockindi_admin.Visible = True
            lbl_capslockindi_admin.ForeColor = Color.Green





            lbl_CaplockIndi.Text = "Capslock Is On"

            lbl_capslockindi_admin.Text = "Capslock Is On"

        Else
            lbl_CaplockIndi.Visible = False
            lbl_capslockindi_admin.Visible = False

        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CaplslockState()
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        CaplslockState()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then


            Tb_Password.UseSystemPasswordChar = False

        Else

            Tb_Password.UseSystemPasswordChar = True
        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged


        If CheckBox2.Checked = True Then

            tb_admin_password.UseSystemPasswordChar = False

        Else

            tb_admin_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Admin_Panel.Show()
        tb_admin_password.Clear()
        tb_admin_username.Clear()


        Panel1.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Panel1.Show()

        Tb_Password.Clear()
        Tb_Username.Clear()


        Admin_Panel.Hide()






    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Admin_Panel_Paint(sender As Object, e As PaintEventArgs) Handles Admin_Panel.Paint

    End Sub

    Private Sub btn_login_admin_Click(sender As Object, e As EventArgs) Handles btn_login_admin.Click



        If Attempt <= 3 Then
            Dim Username As String = tb_admin_username.Text
            Dim Password As String = tb_admin_password.Text


            If String.IsNullOrEmpty(Username) And String.IsNullOrEmpty(Password) Then
                MessageBox.Show("Please fill out properly!")
                Return
            End If

            Try
                connectDB()

                Dim sql As String = "SELECT * FROM login WHERE username = @Username AND password = @Password And isactive = 1 And UserRole = 'Admin'"

                Using myCmd As New MySqlCommand(sql, myConn)
                    myCmd.Parameters.AddWithValue("@Username", Username)
                    myCmd.Parameters.AddWithValue("@Password", Password)

                    Using reader As MySqlDataReader = myCmd.ExecuteReader()
                        If reader.Read() Then

                            MessageBox.Show("Logged in Succesfully.")
                            AdminForm.Show()
                            tb_admin_password.Clear()
                            tb_admin_username.Clear()
                            Me.Hide()


                        Else



                            MessageBox.Show("Invalid login remaining attempt:" & 3 - Attempt)

                            Tb_Password.Clear()

                            Attempt += 1






                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try



        Else
            MessageBox.Show("Max attempt is already used")

        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class
