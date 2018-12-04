Imports System
Imports System.Data
Imports System.Reflection
Imports System.ComponentModel
Imports Arkitech.Platform.Common

Namespace HoopDream.Common

    Public Class SortableBindingList(Of T)
        Inherits BindingList(Of T)
        Private _isSorted As Boolean

        Public Sub New()
            MyBase.New
        End Sub

        Sub New(ByVal lst As IList(Of T))
            MyBase.New(lst)
        End Sub

        Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub ApplySortCore(ByVal prop As PropertyDescriptor, ByVal direction As ListSortDirection)
            Dim items As List(Of T) = TryCast(Me.Items, List(Of T))

            If Nothing IsNot items Then
                Dim pc As New PropertyComparer(Of T)(prop, direction)
                items.Sort(pc)

                ' Set sorted
                _isSorted = True
            Else
                ' Set sorted
                _isSorted = False
            End If
        End Sub

        Protected Overrides ReadOnly Property IsSortedCore() As Boolean
            Get
                Return _isSorted
            End Get
        End Property

        Protected Overrides Sub RemoveSortCore()
            _isSorted = False
        End Sub
    End Class

End Namespace
