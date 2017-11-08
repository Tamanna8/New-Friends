'-------------------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------------------
'Project: Lab 0
'Title: New Friends
'File Name: NewFriends.vb
'Date Completed:2/9/2016
'
'Author: Tamanna Sharma
'Course: CS115 Section-B
'
'Description:This is a very basic program.This program allows the user to have information about
'            new friends in CS115 Section B. In this program,when the user would choose one of
'            the names displayed in the design, the message would be displayed which will be
'            the information about new friends.The user can bold or not bold the information .
'            The user could clear the message as well. There is a button to exit the program. 
'--------------------------------------------------------------------------------------------------
'--------------------------------------------------------------------------------------------------

Option Explicit On
Option Strict On

Public Class frmNewFriends


    Private Sub frmNewFriends_Load(sender As Object, e As EventArgs) Handles Me.Load
        '----------------------------------------------------------------------------------
        'Description:      This will set the start up environment. The lblInformation
        '                  will be blank.
        '----------------------------------------------------------------------------------

    End Sub

    Private Sub radJustin_Click(sender As Object, e As EventArgs) Handles radJustin.Click
        '----------------------------------------------------------------------------------
        'Description:    When user clicks on this radio button,the message will display 
        '               information about Justin.
        '----------------------------------------------------------------------------------
        lblInformation.Text = "Justin is a 29 year old guy and " _
            & "it's been a couple of quarters that he is in Edmonds Community College." _
            & "He had visited Japan,China, and Korea." _
            & "He raise fishes and  he likes to do fishing." _
            & "Justin like to have a farm full of animals." _
            & "His favorite sport is football and he want to do anyhing related " _
            & "to computer science for his future."

    End Sub

    Private Sub radJonathan_Click(sender As Object, e As EventArgs) Handles radJonathan.Click
        '----------------------------------------------------------------------------------
        'Description:    When user clicks on this radio button,the message will display 
        '               information about Jonathan.
        '----------------------------------------------------------------------------------
        lblInformation.Text = "A new friend, I made in the class is Jonathan." _
         & "He is 18 years old and it's been four months that he is in United States." _
          & "He have been to places like China,Japan,Malaysia." _
          & "His favorite sport is swimming and favorite city is Lynnwood." _
          & "He like to play computer games and he want to do anything related to Computer."

    End Sub


    Private Sub radDemetri_Click(sender As Object, e As EventArgs) Handles radDemitri.Click
        '----------------------------------------------------------------------------------
        'Description:    When user clicks on this radio button,the message will display 
        '               information about Demitri.
        '---------------------------------------------------------------------------------
        lblInformation.Text = " Demetri is 18 years old." _
            & "He have been to many places around the world like Russia,Portico and Canada." _
            & "His favorite sport is Soccer and he likes to do photography. " _
            & "Demetri loves driving cars and his favorite car is BMW E46 M3." _
            & "He wants to have a Computer Science Degree."

    End Sub


    Private Sub radMelanie_Click(sender As Object, e As EventArgs) Handles radMelanie.Click
        '----------------------------------------------------------------------------------
        'Description:    When user clicks on this radio button,the message will display 
        '               information about Melanie.
        '----------------------------------------------------------------------------------
        lblInformation.Text = "A new friend, I made in Computer Science class is Melanie." _
            & "She is pretty young,she is 17." _
            & "She have been to places like Brazil, Peru, and Colombia." _
            & "Her favorite sport is surfing." _
            & "She got great plans for her future, she want to be a computer inventer."
    End Sub


    Private Sub radClear_Click(sender As Object, e As EventArgs) Handles radClear.Click
        '----------------------------------------------------------------------------------
        'Description:     When user click on this radio button,the message gets clear
        '                 making the label blank.
        '----------------------------------------------------------------------------------
        lblInformation.Text = String.Empty

    End Sub


    Private Sub chkBold_Click(sender As Object, e As EventArgs) Handles chkBold.Click
        '---------------------------------------------------------------------------------
        'Description: Clicking this check box causes message font to switch between bold
        '               and not bold.
        '---------------------------------------------------------------------------------
        'If chkBold.Checked = False Then
        If lblInformation.Font.Bold = True Then
            lblInformation.Font = New Font("Times New Roman", 12.0, FontStyle.Regular)
        Else
            lblInformation.Font = New Font("Times New Roman", 12.0, FontStyle.Bold)
        End If

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '----------------------------------------------------------------------------------
        'Description:      When the user clicks on this button, the program ends.
        '----------------------------------------------------------------------------------
        Me.Close()

    End Sub

End Class
'------------------------------------------------------------------------------------------
'Description:      
'------------------------------------------------------------------------------------------



