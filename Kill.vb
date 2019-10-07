Option Strict Off
Option Explicit On
Friend Class Kill_Renamed
	
	
	
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
        ' tato funkce vyžaduje seèíst úrovnì v daném oboru
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
End Class