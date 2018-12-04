Imports System.Threading.Tasks
Imports HoopDream.Framework.Entities

Namespace HoopDream
    Public Class FormMain


        Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Initialize()
            Databind()
            InitializeHandlers()
        End Sub

#Region "InitializeHandlers"
        Private Sub InitializeHandlers()

        End Sub
#End Region

#Region "Initialize"
        ''' <summary>
        ''' This procedure adds style to the what the user will see on screen.  It also
        ''' formats the columns that will display (i.e. Currency, Text, Number, etc.)
        ''' </summary>
        Private Sub Initialize()
            Try

            Catch ex As Exception
                ' If something craps out let the user know what went wrong
                MessageBox.Show(ex.ToString)
            End Try
        End Sub
#End Region


#Region "Databind"
        ''' <summary>
        ''' This procedure begins the Databinding process
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub Databind()
            Try
                Me.PlayerList1.Databind()
            Catch ex As Exception
                ' If something craps out let the user know what went wrong
                MessageBox.Show(ex.ToString)
            End Try
        End Sub
#End Region

        Private Sub miRefresh_Click(sender As Object, e As EventArgs) Handles miRefresh.Click
            WebService.Start()

            MessageBox.Show("Download completed")
            Databind()
        End Sub

        Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
            Me.Close()
        End Sub
    End Class
End Namespace