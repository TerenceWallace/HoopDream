
Namespace HoopDream.Framework
    Public MustInherit Class Manager

        Private Property _Database As Database

        Protected ReadOnly Property Database As Database
            Get
                Return _Database
            End Get
        End Property

        Friend Sub New()
        End Sub

        Protected Sub New(inDatabase As Database)
            _Database = inDatabase
        End Sub

    End Class
End Namespace
