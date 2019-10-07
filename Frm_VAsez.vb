Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_VAsez
    Inherits System.Windows.Forms.Form

    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_VAsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tsit = ""
    End Sub

    Private Sub napln_lv()
        Lv_VA.Items.Clear()
        For b = 0 To VAcount - 1
            lvi = Lv_VA.Items.Add(CType(VArec.Tables("va").Rows(b)("Vantage"), String))
            If IsDBNull(VArec.Tables("va").Rows(b)("Adv")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(VArec.Tables("va").Rows(b)("Adv"), String))
            End If
            If IsDBNull(VArec.Tables("va").Rows(b)("Pointcost")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(VArec.Tables("va").Rows(b)("Pointcost"), String))
            End If
            If IsDBNull(VArec.Tables("va").Rows(b)("Actchar")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(VArec.Tables("va").Rows(b)("Actchar"), String))
            End If
        Next
    End Sub


    Private Sub Lv_VA_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_VA.ColumnClick
        Lv_VA.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_VA)
    End Sub

    Private Sub Lv_VA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_VA.SelectedIndexChanged
        Tsit = Lv_VA.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class