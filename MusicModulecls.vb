Public Class MM

    'Programmer: Jason Hensley
    '
    'Email: elitecobra@hotmail.com
    '
    'Website: http://www.vbcodesource.com
    '
    'Version: 2.4 Final
    '
    'Description: Designed to be simple and easy to use.
    'You can easily make a complete mp3, wave, asf,
    'midi player, ect. with this Class Module.
    '
    '2.4 Update: The code has be a tab optimized for VB.Net.
    'Still needs some work done. A few bugs has been fixed.
    '

    'Api to send the commands to the mci device
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    'Used to store the Filename
    Public FileName As String

    'Play a music file
    Public Sub Play()
        Try
            mciSendString("close song", 0, 0, 0) 'Close the previous song
            FileName = Chr(34) + Trim(FileName) + Chr(34) 'put " and " at the beinning and end of the filename
            mciSendString("open " & FileName & " alias song", 0, 0, 0) 'open the filename with the alias named song
            mciSendString("play song", 0, 0, 0) 'play the song
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Used to convert the short filename to the long filename
    Public Function GetLongFilename(ByVal sShortName As String) As String
        Dim sLongName As String
        Dim sTemp As String
        Dim iSlashPos As Integer
        Try
            'Add \ to short name to prevent Instr from failing
            sShortName = sShortName & "\"

            'Start from 4 to ignore the "[Drive Letter]:\" characters
            iSlashPos = InStr(4, sShortName, "\")

            'Pull out each string between \ character for conversion
            While iSlashPos
                sTemp = Dir(Left$(sShortName, iSlashPos - 1), _
                  vbNormal + vbHidden + vbSystem + vbDirectory)
                If sTemp = "" Then
                    'Error 52 - Bad File Name or Number
                    GetLongFilename = ""
                    Exit Function
                End If
                sLongName = sLongName & "\" & sTemp
                iSlashPos = InStr(iSlashPos + 1, sShortName, "\")
            End While

            'Prefix with the drive letter
            GetLongFilename = Left$(sShortName, 2) & sLongName
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Check if the song has ended. Good for repeat play, ect.
    Public Function EndOfSong() As Boolean
        Dim ThePos As Integer
        Dim TheDur As Integer
        Try
            ThePos = GetPositioninSec()
            TheDur = GetDurationInSec()
            If ThePos = 0 Or TheDur = 0 Then Exit Function
            If ThePos = TheDur Then
                EndOfSong = True
            Else
                EndOfSong = False
            End If
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Returns the current device in use
    Public Function DeviceName() As String
        Dim TheData As String
        Try
            TheData = Space$(128)
            mciSendString("sysinfo song installname", TheData, 128, 0) 'retrieve the devicename
            DeviceName = TheData
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Mute just the right channel. True = Mute,False = UnMute
    Public Function SetRightChannelOff(ByVal Off As Boolean) As Boolean
        Try
            If Off = True Then
                mciSendString("setaudio song right off", 0, 0, 0)
            Else
                mciSendString("setaudio song right on", 0, 0, 0)
            End If
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Mute just the left channel. True = Mute,False = UnMute
    Public Function SetLeftChannelOff(ByVal Off As Boolean) As Boolean
        Try
            If Off = True Then
                mciSendString("setaudio song left off", 0, 0, 0)
                SetLeftChannelOff = True
            Else
                mciSendString("setaudio song left on", 0, 0, 0)
                SetLeftChannelOff = False
            End If
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Open and load a .m3u playlist
    Public Sub OpenPlaylist(ByVal TheList As String, ByVal Listbox As ListBox)
        Dim test As String
        Try
            If TheList = "" Then Exit Sub
            FileOpen(1, TheList, OpenMode.Input)
            While Not EOF(1)
                Input(1, test)
                Listbox.Items.Add(RTrim(test))
            End While
            FileClose(1)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Get the time remaining in milli-seconds
    Public Function GetTimeRemaininginMS() As Integer
        Try
            GetTimeRemaininginMS = GetDurationInMS() - GetPositioninMS()
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the time remaining in seconds
    Public Function GetTimeRemaininginSec() As Integer
        Try
            GetTimeRemaininginSec = GetDurationInSec() - GetPositioninSec()
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the value of the playing speed
    Public Function GetSpeed() As Integer
        Dim Rate As String
        Try
            Rate = Space$(30)
            mciSendString("status song play speed", Rate, 30, 0)
            Rate = CLng(Rate)
            GetSpeed = Rate
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the time remaining in a user friendly format
    Public Function GetFormatTimeRemaining() As String
        Try
            GetFormatTimeRemaining = GetThisTime(GetTimeRemaininginMS)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Used to find the last backslash of the file path
    Private Function GetLastBackSlash(ByVal text As String) As String
        Dim i, Pos As Integer
        Dim lastslash As Integer
        Try
            For i = 1 To Len(text)
                Pos = InStr(i, text, "\", vbTextCompare)
                If Pos <> 0 Then lastslash = Pos
            Next i
            GetLastBackSlash = Right(text, Len(text) - lastslash)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Used for getting the Right/Left of a string
    Private Function RightLeft(ByVal source As String, ByVal token As String) As String
        Dim i As Integer
        Try
            RightLeft = ""
            For i = Len(source) To 1 Step -1
                If Mid(source, i, 1) = token Then
                    RightLeft = Left(source, i - 1)
                    Exit Function
                End If
            Next i
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Strip the path and ext. from list2 and add to list1
    Public Sub ListNoChar(ByVal List1 As ListBox, ByVal List2 As ListBox)
        Dim x As Integer
        Dim NoChar As String
        Dim NoEnd As String
        Try
            For x = 0 To List2.Items.Count - 1
                NoChar = GetLastBackSlash(List2.Items(x))
                NoEnd = RightLeft(NoChar, ".")
                List1.Items.Add(NoEnd)
            Next x
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Strip the path and ext. from a single file
    Public Sub ListSingleNoChar(ByVal q As String)
        Dim x As String
        Dim NoChar As String
        Dim NoEnd As String
        Try

            x = q
            NoChar = GetLastBackSlash(x)
            NoEnd = RightLeft(NoChar, ".")
            Song = NoEnd
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Take the .ext off the end of a file
    Private Function NoEndChar(ByVal List1 As ListBox, ByVal List2 As ListBox) As String
        Dim n As Integer
        Try
            For n = 0 To List2.Items.Count - 1
                NoEndChar = Left(List2.Items(n), 1)
            Next n
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Save a playlist in the .m3u format
    Public Sub SavePlaylist(ByVal TheList As String, ByVal Listbox As ListBox)
        Dim i As Integer
        Dim a As String
        Try
            FileOpen(1, TheList, OpenMode.Output)
            For i = 0 To Listbox.Items.Count - 1
                a$ = Listbox.Items(i)
                Print(1, a$ & vbNewLine)
            Next
            FileClose(1)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Set the left channel to a desired volume
    Public Function SetLeftVolume(ByVal Value As Integer) As Integer
        '1000 = max | 0 = min
        Try
            mciSendString("setaudio song left volume to " & Value, 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Set the right channel volume
    Public Function SetRightVolume(ByVal Value As Integer) As Integer
        '1000 = max | 0 = min
        Try
            mciSendString("setaudio song right volume to " & Value, 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Set all audio off(mute)
    Public Function SetAudioOff()
        Try
            mciSendString("set song audio all off", 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Set all audio on(Unmute)
    Public Function SetAudioOn()
        Try
            mciSendString("set song audio all on", 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Set the speed for the song to be played
    Public Function SetSpeed(ByVal speed As Integer)
        Try
            mciSendString("set song speed " & speed, "", 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Set the volume for both channels
    Public Function SetVolume(ByVal Value As Integer) As Integer
        '1000 = max | 0 = min
        Try
            mciSendString("setaudio song volume to " & Value, 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the position in MilliSeconds
    Public Function GetPositioninMS() As Integer
        Static Stat As String
        Try
            Stat = Space$(128)
            mciSendString("set song time format milliseconds", 0, 0, 0)
            mciSendString("status song position", Stat, 128, 0)
            GetPositioninMS = Val(Stat)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the Position in Seconds
    Public Function GetPositioninSec() As Integer
        Try
            GetPositioninSec = Val(GetPositioninMS() \ 1000)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the positon in a user friendly format
    Public Function GetFormatPosition() As String
        Dim Sec As Integer
        Dim Mins As Integer
        Try
            Sec = Val(GetPositioninSec())
            If Sec < 60 Then GetFormatPosition = "0:" & Format(Sec, "00")
            If Sec > 59 Then
                Mins = Int(Sec / 60)
                Sec = Sec - (Mins * 60)
                GetFormatPosition = Format(Mins, "0") & ":" & Format(Sec, "00")
            End If
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Calculates the bitrate of a mp3 file only
    Public Function GetMP3Bitrate() As Integer
        Dim ThePath As String
        Dim TheSize As Integer
        Dim Ext As String
        Try
            ThePath = FileName
            Ext = Microsoft.VisualBasic.Strings.Right(ThePath, 4)
            If Ext = "mp3" & Chr(34) Then
                'Strip off the quotations from the filename that was added with Chr$(34)
                ThePath = FileName
                TheSize = Len(ThePath) - 1
                ThePath = Right(ThePath, TheSize)
                ThePath = Left(ThePath, Len(ThePath) - 1)
                '
                TheSize = FileLen(ThePath)
                TheSize = TheSize * 8

                GetMP3Bitrate = TheSize \ GetDurationInSec()
            Else
                GetMP3Bitrate = 0
            End If
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Change the position of the song in seconds
    Public Sub ChangePosition(ByVal TheSecond As Integer)
        Try
            TheSecond = TheSecond * 1000
            If IsPlaying() = True Then mciSendString("play song from " & TheSecond, 0, 0, 0)
            If IsPlaying() = False Then mciSendString("seek song to " & TheSecond, 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Close the mci device
    Public Function CloseAudio()
        Try
            mciSendString("close all", 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Stop playing the song
    Public Sub StopPlay()
        Try
            mciSendString("stop song", 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Pause the song
    Public Sub Pause()
        Try
            mciSendString("pause song", 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Get duration in Milliseconds
    Public Function GetDurationInMS() As Integer
        Dim TotalTime As String
        Try
            TotalTime = Space$(128)
            mciSendString("status song length", TotalTime, 128, 0&)
            GetDurationInMS = Val(TotalTime)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the bitrate in kb instead of bits
    Public Function GetFormatMP3Bitrate() As Integer
        Try
            GetFormatMP3Bitrate = GetMP3Bitrate() \ 1000
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the left channel volume
    Public Function GetLeftVolume() As Integer
        Dim LeftLevel As String
        Try
            LeftLevel = Space(128)
            mciSendString("status song left volume", LeftLevel, 128, 0)
            GetLeftVolume = Val(LeftLevel)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the right channel volume value
    Public Function GetRightVolume() As Integer
        Dim Rightlevel As String
        Try
            Rightlevel = Space$(128)
            mciSendString("status song right volume", Rightlevel, 128, 0)
            GetRightVolume = Val(Rightlevel)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the volume value for both channels
    Public Function GetVolume() As Integer
        Dim TheLevel As String
        Try
            TheLevel = Space$(128)
            mciSendString("status song volume", TheLevel, 128, 0)
            GetVolume = Val(TheLevel)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the duration in a user friendly format
    Public Function GetFormatDuration() As String
        Dim Stat As String
        Dim T As String
        Dim lTotalTime As Integer
        Try
            Stat = Space$(128)
            mciSendString("set song time format ms", Stat, 128, 0&)
            mciSendString("status song length", Stat, 128, 0&)
            lTotalTime = Val(Stat)
            T = GetThisTime(lTotalTime)
            GetFormatDuration = T
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Used to format the position and duration
    Private Function GetThisTime(ByVal timein As Integer) As String
        Dim conH As Integer
        Dim conM As Integer
        Dim conS As Integer
        Dim remTime As Integer
        Dim strRetTime As String
        Try
            remTime = timein / 1000
            conH = Int(remTime / 3600)
            remTime = remTime Mod 3600
            conM = Int(remTime / 60)
            remTime = remTime Mod 60
            conS = remTime
            If conH > 0 Then
                strRetTime = Trim(Str(conH)) & ":"
            Else
                strRetTime = ""
            End If
            If conM >= 10 Then
                strRetTime = strRetTime & Trim(Str(conM))
            ElseIf conM > 0 Then
                strRetTime = strRetTime & Trim(Str(conM))
            Else
                strRetTime = strRetTime & "0"
            End If
            strRetTime = strRetTime & ":"
            If conS >= 10 Then
                strRetTime = strRetTime & Trim(Str(conS))
            ElseIf conS > 0 Then
                strRetTime = strRetTime & "0" & Trim(Str(conS))
            Else
                strRetTime = strRetTime & "00"
            End If
            GetThisTime = strRetTime
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Get the Duration in Seconds
    Public Function GetDurationInSec() As Integer
        Try
            GetDurationInSec = GetDurationInMS() \ 1000
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Resume a paused song
    Public Sub ResumePlay()
        Try
            mciSendString("resume song", 0, 0, 0)
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Sub

    'Check the status to see if the music is playing, stopped, ect.
    Public Function GetStatus() As String
        Dim Status As String
        Try
            Status = Space$(128)
            mciSendString("status song mode", Status, 128, 0)
            GetStatus = Status
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    'Check to see if a song is playing
    Public Function IsPlaying() As Boolean
        Dim Stat As String
        Try
            Stat = Space$(7)
            mciSendString("status song mode", Stat, 128, 0)
            If Stat = "playing" Then
                IsPlaying = True
            Else
                IsPlaying = False
            End If
        Catch
            MsgBox(Err.Description, , " Internal Error")
        End Try
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

    End Sub
End Class
