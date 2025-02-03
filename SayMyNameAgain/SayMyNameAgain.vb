﻿'Malachi Marlow
'Spring 2025
'RCET2265
'Say My Name Again
'https://github.com/MalachiMarlow/SayMyNameAgain.git

Option Explicit On
Option Compare Text
Option Strict On

Module SayMyNameAgain

    Sub Main()
        Dim userInput As String

        Console.WriteLine("What is your name?") 'Ask your name

        userInput = Console.ReadLine() 'Reads user input on next line

        If userInput = "Joe" Then
            Console.WriteLine("Hello! " & userInput)
        ElseIf userInput = "Emily" Then
            Console.WriteLine("Hey " & userInput)
        ElseIf userInput = "Malachi" Then
            Console.WriteLine("Papa cap?!?")
        Else
            Console.WriteLine("Goodbye.")

        End If

    End Sub

End Module
