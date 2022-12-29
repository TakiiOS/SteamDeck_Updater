Imports System.IO
Imports System.Text
Imports System.Net
Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("https://steamdeck-packages.steamos.cloud/misc/windows/drivers/Aerith%20Windows%20Driver_2209130944.zip", Environment.CurrentDirectory & "/apu.zip")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sd As String
        Dim filestream As StreamReader
        filestream = File.OpenText("http://www.sitename/file.txt")
    End Sub
End Class
