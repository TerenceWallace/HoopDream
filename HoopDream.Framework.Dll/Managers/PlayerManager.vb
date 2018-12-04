
Imports HoopDream.Framework.Entities
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions

'*************************************************************
' File Name:  PlayerManager
' Purpose:  Data Manager Object
' Description: Sends and receives data from the database, formats, and returns requested object(s). 
'***************************************************************
Namespace HoopDream.Framework.Managers

    Public NotInheritable Class PlayerManager
        Inherits Manager
        Implements IPlayerManager

        Public Sub New(inDatabase As Database)
            MyBase.New(inDatabase)
        End Sub

#Region "Count"
        Public Function Count() As Integer Implements IPlayerManager.Count
            Return Database.Players.Count
        End Function
#End Region

#Region "Create"
        Public Function Create() As Player Implements IPlayerManager.Create
            Return New Player
        End Function
#End Region

#Region "GetByPrimaryKey"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetByPrimaryKey(ByVal PlayerID As Integer) As Player Implements IPlayerManager.GetByPrimaryKey
            Dim biz As Player = (From e As Player In Database.Players()
                                 Where e.PlayerID = PlayerID
                                 Select e).FirstOrDefault

            Return biz
        End Function
#End Region

#Region "GetAll"
        <DataObjectMethod(DataObjectMethodType.[Select], True)>
        Public Function GetAll() As System.Collections.Generic.List(Of Player) Implements IPlayerManager.GetAll
            Return Database.Players.ToList
        End Function
#End Region

#Region "Insert"
        <DataObjectMethod(DataObjectMethodType.Insert, True)>
        Public Function Insert(ByVal biz As Player) As Integer Implements IPlayerManager.Insert
            Return Database.Insert(biz)
        End Function
#End Region

#Region "Update"
        <DataObjectMethod(DataObjectMethodType.Update, True)>
        Public Sub Update(ByVal biz As Player) Implements IPlayerManager.Update
            Database.Update(biz)
        End Sub
#End Region

#Region "Delete"
        <DataObjectMethod(DataObjectMethodType.Delete, True)>
        Public Sub Delete(ByVal biz As Player) Implements IPlayerManager.Delete
            If biz IsNot Nothing Then
                If biz.PlayerID > 0 Then
                    Database.Delete(biz)
                End If
            End If
        End Sub
#End Region

#Region "DeleteAll"
        <DataObjectMethod(DataObjectMethodType.Delete, False)>
        Public Sub DeleteAll() Implements IPlayerManager.DeleteAll
            Database.Players.All(Function(e) CBool(Database.Delete(e)))
        End Sub
#End Region

#Region "GetByCriteria"
        Public Function GetByCriteria(ByVal CommandText As String) As System.Collections.Generic.List(Of Player) Implements IPlayerManager.GetByCriteria
            Dim recordList As List(Of Player) = Database.Players.AsQueryable.Where(CommandText).ToList()

            Return recordList
        End Function
#End Region





    End Class
End Namespace
