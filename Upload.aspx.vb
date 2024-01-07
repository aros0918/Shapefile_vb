Imports System

Imports System.Collections.Generic

Imports System.Linq

Imports System.Web

Imports System.Web.UI

Imports System.Web.UI.WebControls

Imports System.IO
Public Class Upload
    Inherits System.Web.UI.Page
    Private UploadDir As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Place files in a website subfolder named Uploads.

        UploadDir = Path.Combine(Request.PhysicalApplicationPath, "Uploads")

    End Sub
    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Check that files are actually being submitted.
        If Uploader.HasFiles Then
            For Each file As HttpPostedFile In Uploader.PostedFiles
                ' Check the extension.
                Dim Ext As String = Path.GetExtension(file.FileName)
                Dim SrvFName As String = ""
                Dim FullUpldPath As String = ""
                Select Case Ext.ToLower()
                    Case ".dbf", ".prj", ".shp", ".shx", ".zip"
                        ' Using this code, the saved file will retain its original
                        ' file name when it’s placed on the server.
                        SrvFName = Path.GetFileName(file.FileName)
                        FullUpldPath = Path.Combine(UploadDir, SrvFName)
                        Try
                            file.SaveAs(FullUpldPath)
                            lblInfo.Text += "File " + SrvFName
                            lblInfo.Text += " uploaded successfully to" + FullUpldPath + "<br />"
                        Catch ex As Exception
                            lblInfo.Text += ex.Message + "<br />"
                        End Try
                    Case Else
                        lblInfo.Text += "File " + file.FileName + " is not allowed." + "<br />"
                End Select
            Next
        Else
            lblInfo.Text = "You did not specify any files to upload."
        End If
    End Sub

End Class