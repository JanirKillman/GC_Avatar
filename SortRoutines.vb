Public Class SortRoutines
    Public Class CompareListViewItems
        Implements IComparer

        Shared bSortDirection As Boolean = True
        Dim sRoutineToUse As String = "String"
        Dim lView As ListView     'the listview in question
        Dim iColumn As Integer    'the column to sort
        Dim lvCollection As ListView.ListViewItemCollection
        Dim bSafeToSort As Boolean = False

        Sub New(ByVal itemIndex As Integer, ByVal lvListView As ListView)
            iColumn = itemIndex
            lView = lvListView
            bSortDirection = Not bSortDirection
            lvCollection = New ListView.ListViewItemCollection(lvListView)
            determineType()
        End Sub

        Private Function determineType() As Boolean

            'There need to be at least 2 elements to sort
            If (lView.Items.Count < 2) Then
                bSafeToSort = False
                Return False
            End If

            'If a value is Null, a subitem might not be added
            If (checkForNull() = True) Then
                bSafeToSort = False
                Return False
            End If

            'If there are values in each element, let's determine the type
            If (isItADate() = True) Then
                sRoutineToUse = "Date"
            ElseIf (isItANumber() = True) Then
                sRoutineToUse = "Number"
            Else
                sRoutineToUse = "String"
            End If

        End Function

        Private Function checkForNull() As Boolean

            Dim lvTest As ListViewItem
            Dim sItemContents As String

            For Each lvTest In lvCollection
                Try
                    If iColumn = 0 Then
                        sItemContents = lvTest.Text
                    Else
                        sItemContents = lvTest.SubItems(iColumn).Text
                    End If
                Catch
                    Return True
                End Try
            Next

            bSafeToSort = True
            Return False  'we are good to go

        End Function

        Private Function isItADate() As Boolean

            Dim lvTest As ListViewItem   'assigned a new row
            Dim oObjectToTest As Object  'recipient of the assignment
            Dim sItemContents As String  'contents of the element

            '-- Loop through each element
            For Each lvTest In lvCollection

                If iColumn = 0 Then
                    sItemContents = lvTest.Text
                Else
                    sItemContents = lvTest.SubItems(iColumn).Text
                End If

                Try
                    oObjectToTest = CDate(sItemContents)
                Catch
                    Return False
                End Try

            Next

            Return True

        End Function

        Private Function isItANumber() As Boolean

            Dim lvTest As ListViewItem   'assigned a new row
            Dim oObjectToTest As Object  'recipient of the assignment
            Dim sItemContents As String  'contents of the element

            '-- Loop through each element
            For Each lvTest In lvCollection

                If iColumn = 0 Then
                    sItemContents = lvTest.Text
                Else
                    sItemContents = lvTest.SubItems(iColumn).Text
                End If

                Try
                    oObjectToTest = CDbl(sItemContents)
                Catch
                    Return False
                End Try
            Next

            Return True

        End Function

        Function compare(ByVal oFirst As Object, _
                         ByVal oSecond As Object) As Integer _
            Implements System.Collections.IComparer.Compare

            If bSafeToSort = False Then Exit Function

            Try

            Dim lvElement1 As ListViewItem = CType(oFirst, ListViewItem)
            Dim lvElement2 As ListViewItem = CType(oSecond, ListViewItem)

            If sRoutineToUse = "String" Then

                If bSortDirection = True Then
                    If iColumn = 0 Then
                        Return String.Compare(lvElement1.Text, lvElement2.Text)
                    Else
                        Return String.Compare(lvElement1.SubItems(iColumn).Text, _
                                              lvElement2.SubItems(iColumn).Text)
                    End If
                Else
                    If iColumn = 0 Then
                        Return String.Compare(lvElement2.Text, lvElement1.Text)
                    Else
                        Return String.Compare(lvElement2.SubItems(iColumn).Text, _
                                              lvElement1.SubItems(iColumn).Text)
                    End If
                End If

            ElseIf sRoutineToUse = "Number" Then

                If bSortDirection = True Then
                    If iColumn = 0 Then
                        Return Math.Sign(CLng(lvElement1.Text - lvElement2.Text))
                    Else
                        Return Math.Sign(CLng(lvElement1.SubItems(iColumn).Text _
                          - lvElement2.SubItems(iColumn).Text))
                    End If
                Else
                    If iColumn = 0 Then
                        Return Math.Sign(CLng(lvElement2.Text - lvElement1.Text))
                    Else
                        Return Math.Sign(CLng(lvElement2.SubItems(iColumn).Text _
                          - lvElement1.SubItems(iColumn).Text))
                    End If
                End If
            Else  'It's a date
                If bSortDirection = True Then
                    If iColumn = 0 Then
                        Return Date.Compare(Date.Parse(lvElement1.Text), _
                               Date.Parse(lvElement2.Text))
                    Else
                        Return Date.Compare( _
                               Date.Parse(lvElement1.SubItems(iColumn).Text), _
                               Date.Parse(lvElement2.SubItems(iColumn).Text))
                    End If
                Else
                    If iColumn = 0 Then
                        Return Date.Compare(Date.Parse(lvElement2.Text), _
                               Date.Parse(lvElement1.Text))
                    Else
                        Return Date.Compare( _
                               Date.Parse(lvElement2.SubItems(iColumn).Text), _
                               Date.Parse(lvElement1.SubItems(iColumn).Text))
                    End If
                End If
            End If

            Catch ex As Exception
            End Try

        End Function
    End Class

End Class
