Imports System.Net.Mail

Namespace App
    ' This module handles any required validation for the application
    Module Validation

        ' Test whether an email is valid or not
        '
        ' String email - The string to be tested
        '
        ' Returns True on Success
        Public Function testEmail(email As String)
            Try
                ' This will throw an error if the format is invalid
                Dim a As New MailAddress(email)
            Catch ex As Exception
                ' Error thrown, so not a valid email address
                Return False
            End Try
            ' No error thrown, so is valid email address
            Return True
        End Function

        ' validateField
        ' Validate a field value based on the given rules
        '
        ' Object value - The value to be validated 
        ' String fieldName - A readable name for the field currently being validated 
        ' Dictionary(Of String, Object) - A list of rules which the value must comply with
        '
        ' Returns true if all rules have been passed
        '
        ' List of rules
        ' Name       (Options)        Description
        ' required   ()               Field can't be empty
        ' min_length (Integer length) Must have specified length
        ' max_lenth  (Integer length) Must not be above the specified length
        ' email      ()               Must be a valid email address
        ' float      ()               Must be a valid float value
        ' is_in      (Array items)    Value must be in given array
        ' <          (Object limit)  Value must be smaller than the given limit
        ' =<         (Object limit)  Value must be smaller than or equal to the given limit
        ' >          (Object limit)  Value must be larger than the given limit
        ' =>         (Object limit)  Value must be larger than or equal to the given limit

        Public Function validateField(value As Object, fieldName As String, rules As Dictionary(Of String, Object))
            ' Loop through each of the rules

            For Each rule In rules
                ' Required Rule
                If rule.Key = "required" Then
                    ' If string is empty, throw error
                    If Trim(value) = "" Then
                        Throw New Exception("Please enter a value into the '" + fieldName + "' field")
                    End If

                ElseIf rule.Key = "min_length" Then
                    ' Minimum Length
                    If Len(value) < rule.Value Then
                        Throw New Exception("The field '" + fieldName + "' must be at least " + rule.Value.ToString() + " characters long")
                    End If
                ElseIf rule.Key = "max_length" Then
                    ' Maximum Length
                    If Len(value) > rule.Value Then
                        Throw New Exception("The field '" + fieldName + "' must be no longer than " + rule.Value.ToString() + " characters long")
                    End If
                ElseIf rule.Key = "email" Then
                    ' Email format check
                    If Not testEmail(value) Then
                        Throw New Exception("Invalid Email Address")
                    End If

                ElseIf rule.Key = "float" Then
                    ' Check is a numeric string
                    If Not IsNumeric(value) Then
                        Throw New Exception("The field '" + fieldName + "' must be a valid number")
                    End If
                ElseIf rule.Key = "is_in" Then
                    ' Is in array
                    Dim items = rule.Value
                    If Not items.Contains(value) Then
                        Throw New Exception("Invalid " + fieldName)
                    End If
                ElseIf rule.Key = "<" Then
                    ' Size Comparison
                    If Not value < rule.Value Then
                        ' Display date message if the comparison is with dates
                        If TypeOf rule.Value Is DateTime Then
                            Throw New Exception(fieldName + " must be before " + rule.Value.ToString())
                        End If
                        Throw New Exception(fieldName + " must be smaller than " + rule.Value.ToString())
                    End If
                ElseIf rule.Key = "=<" Then
                    ' Size Comparison
                    If Not value <= rule.Value Then
                        ' Display date message if the comparison is with dates
                        If TypeOf rule.Value Is DateTime Then
                            Throw New Exception(fieldName + " must be on or before " + rule.Value.ToString())
                        End If
                        Throw New Exception(fieldName + " must be smaller than or equal to " + rule.Value.ToString())
                    End If
                ElseIf rule.Key = ">" Then
                    ' Size Comparison
                    If Not value > rule.Value Then
                        ' Display date message if the comparison is with dates
                        If TypeOf rule.Value Is DateTime Then
                            Throw New Exception(fieldName + " must be after " + rule.Value.ToString())
                        End If
                        Throw New Exception(fieldName + " must be larger than " + rule.Value.ToString())
                    End If
                ElseIf rule.Key = "=>" Then
                    ' Size Comparison
                    If Not value >= rule.Value Then
                        ' Display date message if the comparison is with dates
                        If TypeOf rule.Value Is DateTime Then
                            Throw New Exception(fieldName + " must be on or after " + rule.Value.ToString())
                        End If
                        Throw New Exception(fieldName + " must be larger than or equal to " + rule.Value.ToString())
                    End If
                End If
            Next
        End Function

    End Module
End Namespace