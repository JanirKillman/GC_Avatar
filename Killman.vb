Option Strict Off
Option Explicit On
Public Class Killman

    Public Function Dice(ByRef DType As String, ByRef Numb As Short) As Long
        Dim N As Long
        Dim x As Short
        Select Case DType
            Case Is = "k4"
                N = 4
            Case Is = "k6"
                N = 6
            Case Is = "k8"
                N = 8
            Case Is = "k10"
                N = 10
            Case Is = "k12"
                N = 12
            Case Is = "k20"
                N = 20
            Case Is = "k30"
                N = 30
            Case Is = "k100"
                N = 100
            Case Is = "k1k"
                N = 1000
        End Select
        For x = 1 To Numb
            Dice = Dice + Int((Rnd() * N) + 1)
        Next
    End Function

    Public Function AttBonus(ByRef AttValue As Short) As String
        ' funkce vrací bonus nezáporné vlastnosti do 100
        Dim a As Short
        If AttValue < 0 Then
            AttBonus = ""
            Exit Function
        End If
        If AttValue > 9 And AttValue < 13 Then
            AttBonus = "+0"
        End If
        If AttValue > 12 Then
            a = Int((AttValue - 12) / 2)
            AttBonus = "+" & a
        End If
        If AttValue < 10 Then
            a = 6 - Int((AttValue + 1) / 2)
            AttBonus = "-" & a
        End If
    End Function

    Public Function HPCount(ByRef Levels As Short, ByRef Job As String, ByRef FodlB As Short, ByRef Spec As String) As Long
        ' tato funkce vyžaduje sečíst úrovně v daném oboru
        Dim x As Short
        Select Case Job
            Case Is = "War"
                Select Case Spec
                    Case Is = "Boost"
                        HPCount = Levels * (10 + FodlB)
                    Case Is = "Upp"
                        HPCount = (10 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 4) + 1) + 6
                        Next
                    Case Is = "Med"
                        HPCount = Levels * (5 + FodlB)
                    Case Else
                        HPCount = (10 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 10) + 1)
                        Next
                End Select
            Case Is = "Ran"
                Select Case Spec
                    Case Is = "Boost"
                        HPCount = Levels * (8 + FodlB)
                    Case Is = "Upp"
                        HPCount = (8 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 3) + 1) + 5
                        Next
                    Case Is = "Med"
                        HPCount = Int(Levels * (5.5 + FodlB))
                    Case Else
                        HPCount = (8 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 6) + 3)
                        Next
                End Select
            Case Is = "Alch"
                Select Case Spec
                    Case Is = "Boost"
                        HPCount = Levels * (7 + FodlB)
                    Case Is = "Upp"
                        HPCount = (7 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 3) + 1) + 4
                        Next
                    Case Is = "Med"
                        HPCount = Int(Levels * (4.5 + FodlB))
                    Case Else
                        HPCount = (7 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 6) + 2)
                        Next
                End Select
            Case Is = "Wiz"
                Select Case Spec
                    Case Is = "Boost"
                        HPCount = Levels * (6 + FodlB)
                    Case Is = "Upp"
                        HPCount = (6 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 3) + 1) + 3
                        Next
                    Case Is = "Med"
                        HPCount = Int(Levels * (3.5 + FodlB))
                    Case Else
                        HPCount = (6 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 6) + 1)
                        Next
                End Select
            Case Is = "Rog"
                Select Case Spec
                    Case Is = "Boost"
                        HPCount = Levels * (6 + FodlB)
                    Case Is = "Upp"
                        HPCount = (6 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 3) + 1) + 3
                        Next
                    Case Is = "Med"
                        HPCount = Int(Levels * (3.5 + FodlB))
                    Case Else
                        HPCount = (6 + FodlB) + ((Levels - 1) * FodlB)
                        For x = 1 To (Levels - 1)
                            HPCount = HPCount + Int((Rnd() * 6) + 1)
                        Next
                End Select
        End Select
    End Function

    Public Function GetFileCount(ByRef Path As String) As Long
        Dim I As String
        I = Dir(Path)
        GetFileCount = 0
        Do While I <> ""
            If I <> "." And I <> ".." Then
                GetFileCount += 1
            End If
            I = Dir()
        Loop
    End Function

    Public Function CLA(ByRef Classes As String, ByRef Levels As String) As String
        Dim a, b, c As Int16
        CLA = Classes
        c = 1
        For a = 1 To Len(CLA) + 15
            If a > Len(CLA) Then
                Exit For
            End If
            If Mid(CLA, a, 1) = "," Then
                For b = c To Len(Levels)
                    If Mid(Levels, b, 1) = "," Then
                        CLA = Mid(CLA, 1, a - 1) & " " & Mid(Levels, c, b - c) & Mid(CLA, a, Len(CLA) - (a - 1))
                        a = a + (b - c) + 1
                        c = b + 2
                        Exit For
                    End If
                Next
            End If
        Next
        CLA = CLA & " " & Mid(Levels, c, 3)
    End Function

    Public Function LC(ByRef Levels As String) As Integer
        Dim a, b As Int16
        LC = 0
        b = 1
        For a = 1 To Len(Levels)
            If Mid(Levels, a, 1) = "," Then
                If Mid(Levels, b, 1) = "," Then
                    LC += CInt(Mid(Levels, b + 2, (a - b) - 2))
                Else
                    LC += CInt(Mid(Levels, b, a - b))
                End If
                b = a
            End If
        Next
        If Mid(Levels, b, 1) = "," Then
            LC += CInt(Mid(Levels, b + 2, (a - (b + 1))))
        Else
            LC += CInt(Mid(Levels, b, (a - (b - 1))))
        End If

    End Function

End Class