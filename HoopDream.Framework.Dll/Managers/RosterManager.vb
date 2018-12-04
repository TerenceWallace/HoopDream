
Imports HoopDream.Framework.Entities
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions

'*************************************************************
' File Name:  RosterManager
' Purpose:  Data Manager Object
' Description: Sends and receives data from the database, formats, and returns requested object(s). 
'***************************************************************
Namespace HoopDream.Framework.Managers

    Public NotInheritable Class RosterManager
        Inherits Manager
        Implements IRosterManager

        Public Sub New(inDatabase As Database)
            MyBase.New(inDatabase)
        End Sub

#Region "Count"
        Public Function Count() As Integer Implements IRosterManager.Count
            Return Database.Rosters.Count
        End Function
#End Region

#Region "Create"
        Public Function Create() As Roster Implements IRosterManager.Create
            Return New Roster
        End Function
#End Region

#Region "GetByPrimaryKey"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetByPrimaryKey(ByVal RosterID As Integer) As Roster Implements IRosterManager.GetByPrimaryKey
            Dim biz As Roster = (From e As Roster In Database.Rosters()
                                 Where e.RosterID = RosterID
                                 Select e).FirstOrDefault

            Return biz
        End Function
#End Region

#Region "GetAll"
        <DataObjectMethod(DataObjectMethodType.[Select], True)>
        Public Function GetAll() As System.Collections.Generic.List(Of Roster) Implements IRosterManager.GetAll
            Return Database.Rosters.ToList
        End Function
#End Region

#Region "Insert"
        <DataObjectMethod(DataObjectMethodType.Insert, True)>
        Public Function Insert(ByVal biz As Roster) As Integer Implements IRosterManager.Insert
            Return Database.Insert(biz)
        End Function
#End Region

#Region "Update"
        <DataObjectMethod(DataObjectMethodType.Update, True)>
        Public Sub Update(ByVal biz As Roster) Implements IRosterManager.Update
            Database.Update(biz)
        End Sub
#End Region

#Region "Delete"
        <DataObjectMethod(DataObjectMethodType.Delete, True)>
        Public Sub Delete(ByVal biz As Roster) Implements IRosterManager.Delete
            If biz IsNot Nothing Then
                If biz.RosterID > 0 Then
                    Database.Delete(biz)
                End If
            End If
        End Sub
#End Region

#Region "DeleteAll"
        <DataObjectMethod(DataObjectMethodType.Delete, False)>
        Public Sub DeleteAll() Implements IRosterManager.DeleteAll
            Database.Rosters.All(Function(e) CBool(Database.Delete(e)))
        End Sub
#End Region

#Region "GetByCriteria"
        Public Function GetByCriteria(ByVal CommandText As String) As System.Collections.Generic.List(Of Roster) Implements IRosterManager.GetByCriteria
            Dim recordList As List(Of Roster) = Database.Rosters.AsQueryable.Where(CommandText).ToList()

            Return recordList
        End Function
#End Region

#Region "GetRostersByPlayerID"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetRostersByPlayerID(ByVal PlayerID As Integer) As List(Of Roster) Implements IRosterManager.GetRostersByPlayerID
            Dim recordList As List(Of Roster) = (From biz As Roster In Database.Rosters
                                                 Where biz.PlayerID = PlayerID
                                                 Select biz).ToList

            Return recordList
        End Function
#End Region

#Region "GetRostersByPositionID"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetRostersByPositionID(ByVal PositionID As Integer) As List(Of Roster) Implements IRosterManager.GetRostersByPositionID
            Dim recordList As List(Of Roster) = (From biz As Roster In Database.Rosters
                                                 Where biz.PositionID = PositionID
                                                 Select biz).ToList

            Return recordList
        End Function
#End Region



    End Class
End Namespace
