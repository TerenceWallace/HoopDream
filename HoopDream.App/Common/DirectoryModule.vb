

Imports System.Windows.Forms

Namespace HoopDream.Common
    Module DirectoryModule

        Friend ReadOnly Property DataDirectory() As String
            Get
                Return Application.StartupPath + "\Database\"
            End Get
        End Property

        Friend ReadOnly Property ParentDirectory() As String
            Get
                Dim dir As New DirectoryInfo(Application.StartupPath)
                Return dir.Parent.FullName
            End Get
        End Property
    End Module
End Namespace
