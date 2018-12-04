
Imports HoopDream.Framework.Entities
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions

'*************************************************************
' File Name:  TeamManager
' Purpose:  Data Manager Object
' Description: Sends and receives data from the database, formats, and returns requested object(s). 
'***************************************************************
Namespace HoopDream.Framework.Managers

    Public NotInheritable Class TeamManager
        Inherits Manager
        Implements ITeamManager

        Public Sub New(inDatabase As Database)
            MyBase.New(inDatabase)
        End Sub

#Region "Count"
        Public Function Count() As Integer Implements ITeamManager.Count
            Return Database.Teams.Count
        End Function
#End Region

#Region "Create"
        Public Function Create() As Team Implements ITeamManager.Create
            Return New Team
        End Function
#End Region

#Region "GetByPrimaryKey"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetByPrimaryKey(ByVal TeamID As Integer) As Team Implements ITeamManager.GetByPrimaryKey
            Dim biz As Team = (From e As Team In Database.Teams()
                               Where e.TeamID = TeamID
                               Select e).FirstOrDefault

            Return biz
        End Function
#End Region

#Region "GetAll"
        <DataObjectMethod(DataObjectMethodType.[Select], True)>
        Public Function GetAll() As System.Collections.Generic.List(Of Team) Implements ITeamManager.GetAll
            Return Database.Teams.ToList
        End Function
#End Region

#Region "Insert"
        <DataObjectMethod(DataObjectMethodType.Insert, True)>
        Public Function Insert(ByVal biz As Team) As Integer Implements ITeamManager.Insert
            Return Database.Insert(biz)
        End Function
#End Region

#Region "Update"
        <DataObjectMethod(DataObjectMethodType.Update, True)>
        Public Sub Update(ByVal biz As Team) Implements ITeamManager.Update
            Database.Update(biz)
        End Sub
#End Region

#Region "Delete"
        <DataObjectMethod(DataObjectMethodType.Delete, True)>
        Public Sub Delete(ByVal biz As Team) Implements ITeamManager.Delete
            If biz IsNot Nothing Then
                If biz.TeamID > 0 Then
                    Database.Delete(biz)
                End If
            End If
        End Sub
#End Region

#Region "DeleteAll"
        <DataObjectMethod(DataObjectMethodType.Delete, False)>
        Public Sub DeleteAll() Implements ITeamManager.DeleteAll
            Database.Teams.All(Function(e) CBool(Database.Delete(e)))
        End Sub
#End Region

#Region "GetByCriteria"
        Public Function GetByCriteria(ByVal CommandText As String) As System.Collections.Generic.List(Of Team) Implements ITeamManager.GetByCriteria
            Dim recordList As List(Of Team) = Database.Teams.AsQueryable.Where(CommandText).ToList()

            Return recordList
        End Function
#End Region





    End Class
End Namespace
