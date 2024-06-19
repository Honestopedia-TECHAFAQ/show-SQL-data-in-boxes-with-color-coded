Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindData()
        End If
    End Sub

    Private Sub BindData()
        Dim dataAccess As New DataAccess()
        Dim dataTable As DataTable = dataAccess.GetData()
        
        Dim htmlContent As String = ""

        For Each row As DataRow In dataTable.Rows
            Dim boxClass As String = GetColorClass(row("Status").ToString())
            htmlContent &= $"<div class='data-box {boxClass}'>" &
                           $"<h3>{row("Title")}</h3>" &
                           $"<p>{row("Description")}</p>" &
                           $"<span>{Convert.ToDateTime(row("Date")).ToString("yyyy-MM-dd")}</span>" &
                           $"</div>"
        Next

        data-container.InnerHtml = htmlContent
    End Sub

    Private Function GetColorClass(status As String) As String
        Select Case status.ToLower()
            Case "active"
                Return "green"
            Case "inactive"
                Return "red"
            Case "pending"
                Return "yellow"
            Case Else
                Return "gray"
        End Select
    End Function
End Class
