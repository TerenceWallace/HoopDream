Option Explicit On

Imports HoopDream.Framework.ViewModels


'*************************************************************
' Class Name:  PlayerEventArgs
' Description: 
'***************************************************************
Namespace HoopDream.Framework

    Public Class PlayerEventArgs
        Inherits System.EventArgs

        Public Property ViewModel() As PlayerViewModel

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal vm As PlayerViewModel)
            MyBase.New
            _ViewModel = vm
        End Sub

    End Class
End Namespace
