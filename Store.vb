Option Strict Off
Option Explicit On
Friend Class Store
    'toto je k přehrání souboru.
    Private Declare Function mciExecute Lib "winmm.dll" (ByVal lpstrCommand As String) As Integer 'na jeden řádek


    Private Sub PlaySound()
        Dim x As Object
        x = mciExecute("Play C:\Windows\Media\Tada.wav")
    End Sub


    ' změna tlačítka při pohybu myši.
    'Public Declare Function SetCapture Lib "user32" (ByVal hwnd As Long) As Long
    'Public Declare Function ReleaseCapture Lib "user32" () As Long
    'každou deklaraci na jeden řádek

    'With cmdButton
    '   .Style = 1
    '   If Button = 0 Then
    '     If (x < 0) Or (y < 0) Or (x > .Width) Or (y > .Height) Then
    '       'Ukazatel je mimo tlačítko, uvolnit události sledování
    '       ReleaseCapture
    '       .BackColor = vbRed
    '     Else
    '       'Myš je nad tlačítkem, začínáme sledovat pro obdržení
    '       'zprávy, kdy myš opustí tlačítko
    '       SetCapture .hwnd
    '       .BackColor = vbBlue
    '     End If
    '   End If
    '   End With




    'pauza
    'Private Declare Sub Sleep _
    ''                Lib "kernel32" _
    ''                (ByVal dwMilliseconds As Long)
    'dwMilliseconds je typu Long , jedná se o počet tisícin vteřiny (1000 =1 vteřina).




    'vložení objektu do RTF boxu


    'Jak vložit např. obrázek to RichTechBoxu? Jistě znáte dialog Vložit ze souboru, obrázek ....


    '--------------------------------------------------------------------------------

    'Potřebujete, aby si uživatel vkládal do RTFBoxu obrázek nebo nějaký soubor? Lze využít služeb Win32API. Já vám zde poradím krok za krokem jak na to.


    'Postup

    'Vytvořte Standard EXE projekt ve VB. Do seznamu komponent vložte Microsoft Rich Text Control (pravým tlačítkem na ControlBoxu a volba Components). Přidejte RichTextBox a jedno tlačítko Command1 na formulář. Vložte do kódu formuláře následující kód.


    'Option Explicit
    'Deklarace API funkci a procedur
    '  Private Declare Function OleUIInsertObject _
    ''                 Lib "oledlg.dll" _
    'Alias "OleUIInsertObjectA" _
    '(inParam As Any) As Long
    '  Private Declare Function ProgIDFromCLSID _
    'Lib "ole32.dll" _
    '(clsid As Any, _
    'strAddess As Long) As Long
    '  Private Declare Sub CoTaskMemFree _
    'Lib "ole32.dll" _
    '(ByVal pvoid As Long)
    '  Private Declare Sub CopyMemory _
    'Lib "kernel32" _
    'Alias "RtlMoveMemory" _
    '(Destination As Any, _
    'Source As Any, _
    'ByVal Length As Long)
    ' Private Declare Function lstrlenW _
    'Lib "kernel32" _
    '(ByVal lpString As Long _
    ') As Long
    'Konstannty
    ' Const IOF_SHOWHELP = &H1
    ' Const IOF_SELECTCREATENEW = &H2
    ' Const IOF_SELECTCREATEFROMFILE = &H4
    ' Const IOF_CHECKLINK = &H8
    ' Const IOF_CHECKDISPLAYASICON = &H10
    ' Const IOF_CREATENEWOBJECT = &H20
    ' Const IOF_CREATEFILEOBJECT = &H40
    ' Const IOF_CREATELINKOBJECT = &H80
    ' Const IOF_DISABLELINK = &H100
    ' Const IOF_VERIFYSERVERSEXIST = &H200
    ' Const IOF_DISABLEDISPLAYASICON = &H400
    ' Const IOF_HIDECHANGEICON = &H800
    ' Const IOF_SHOWINSERTCONTROL = &H1000
    ' Const IOF_SELECTCREATECONTROL = &H2000

    'Konstanty navratovych kodu
    ' Const OLEUI_FALSE = 0
    ' Const OLEUI_SUCCESS = 1
    ' Const OLEUI_OK = 1
    ' Const OLEUI_CANCEL = 2

    ' GUID, IID, CLSID, atd
    ' Private Type GUID
    '     Data1 As Long
    '     Data2 As Integer
    '     Data3 As Integer
    '     Data4(0 To 7) As Byte
    ' End Type

    'UDT pouzite v OleUIInsertObject.
    '   Private Type OleUIInsertObjectType
    '       cbStruct As Long
    '       dwFlags As Long
    '       hWndOwner As Long
    '       lpszCaption  As String
    '       lpfnHook As Long
    '       lCustData As Long
    '       hInstance  As Long
    '       lpszTemplate As String
    '       hResource As Long
    '       clsid As GUID
    '       lpszFile As String
    '       cchFile As Long
    '       cClsidExclude As Long
    '       lpClsidExclude As Long
    '       IID As GUID
    '       oleRender As Long
    '       lpFormatEtc As Long
    '       lpIOleClientSite As Long
    '       lpIStorage As Long
    '       ppvObj As Long
    '       sc As Long
    '       hMetaPict As Long
    '   End Type
    '
    '   Private Sub Command1_Click()
    '     Dim UIInsertObj As OleUIInsertObjectType
    '     Dim retValue As Long
    '     Dim lpolestr As Long
    '     Dim strsize As Long
    '     Dim ProgId As String
    '
    '     On Error GoTo err 'Pri chybe skoc na err
    '
    '     'Priprav strukturu
    '     With UIInsertObj
    '       .cbStruct = LenB(UIInsertObj)
    '       .dwFlags = IOF_SELECTCREATENEW
    '       .hWndOwner = Me.hwnd
    '       .lpszFile = String(256, " ")
    '       .cchFile = Len(.lpszFile)
    '     End With
    '
    '     'Zobraz dialog box
    '     retValue = OleUIInsertObject(UIInsertObj)
    '
    '     If (retValue = OLEUI_OK) Then
    '       If ((UIInsertObj.dwFlags And _
    ''            IOF_SELECTCREATENEW) = _
    ''            IOF_SELECTCREATENEW) Then
    '          retValue = ProgIDFromCLSID(UIInsertObj.clsid, _
    ''                                     lpolestr)
    '          strsize = lstrlenW(lpolestr) + 1
    '          ProgId = String(strsize, 0)
    '          CopyMemory ByVal StrPtr(ProgId), _
    ''                     ByVal lpolestr, strsize * 2
    '          CoTaskMemFree lpolestr
    '          RichTextBox1.OLEObjects.Add , , "", ProgId
    '       Else
    '          RichTextBox1.OLEObjects.Add , _
    ''          , UIInsertObj.lpszFile
    '       End If
    '      End If
    '   Exit Sub
    '
    'err:
    '       MsgBox "Doslo k chybe cislo: " & _
    ''              err.Number & _
    ''              "Popis chyby:" & _
    ''              vbNewLine & err.Description
    '   End Sub
    '
    'Tak a to je vše, nyní můžete vyzkoušet všechny možnosti systémového dialogu pro vkládání OLE objektu. Na závěr malé upozornění, Dialogové okno je vždy ve stejném jazyce jako Systém WINDOWS.
End Class