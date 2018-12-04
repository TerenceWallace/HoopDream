

'*************************************************************
' Class Name:  RefreshEventArgs
' Description: 
'***************************************************************
Namespace HoopDream.Framework

    Public Class RefreshEntityEventArgs
        Inherits System.EventArgs

        Public Property Type() As EntityType = EntityType.Players

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal e As EntityType)
            MyBase.New
            _Type = e
        End Sub

    End Class
End Namespace
