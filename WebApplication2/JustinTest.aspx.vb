Public Class JustinTest
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Const clientScriptManagerName As String = "KarensNewReportTab"
        Dim clientScriptText As String = "alert('I am about to open a new page! Have a nice day'); window.open('http://www.google.com','_blank');"
        ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), clientScriptManagerName, clientScriptText, True)
    End Sub
End Class