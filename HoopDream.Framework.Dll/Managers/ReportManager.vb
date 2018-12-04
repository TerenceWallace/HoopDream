
Imports HoopDream.Framework.Entities
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions

'*************************************************************
' File Name:  ReportManager
' Purpose:  Data Manager Object
' Description: Sends and receives data from the database, formats, and returns requested object(s). 
'***************************************************************
Namespace HoopDream.Framework.Managers

    Public NotInheritable Class ReportManager
        Inherits Manager
        Implements IReportManager

        Public Sub New(inDatabase As Database)
            MyBase.New(inDatabase)
        End Sub

#Region "Count"
        Public Function Count() As Integer Implements IReportManager.Count
            Return Database.Reports.Count
        End Function
#End Region

#Region "Create"
        Public Function Create() As Report Implements IReportManager.Create
            Return New Report
        End Function
#End Region

#Region "GetByPrimaryKey"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetByPrimaryKey(ByVal ReportID As Integer) As Report Implements IReportManager.GetByPrimaryKey
            Dim biz As Report = (From e As Report In Database.Reports()
                                 Where e.ReportID = ReportID
                                 Select e).FirstOrDefault

            Return biz
        End Function
#End Region

#Region "GetAll"
        <DataObjectMethod(DataObjectMethodType.[Select], True)>
        Public Function GetAll() As System.Collections.Generic.List(Of Report) Implements IReportManager.GetAll
            Return Database.Reports.ToList
        End Function
#End Region

#Region "Insert"
        <DataObjectMethod(DataObjectMethodType.Insert, True)>
        Public Function Insert(ByVal biz As Report) As Integer Implements IReportManager.Insert
            Return Database.Insert(biz)
        End Function
#End Region

#Region "Update"
        <DataObjectMethod(DataObjectMethodType.Update, True)>
        Public Sub Update(ByVal biz As Report) Implements IReportManager.Update
            Database.Update(biz)
        End Sub
#End Region

#Region "Delete"
        <DataObjectMethod(DataObjectMethodType.Delete, True)>
        Public Sub Delete(ByVal biz As Report) Implements IReportManager.Delete
            If biz IsNot Nothing Then
                If biz.ReportID > 0 Then
                    Database.Delete(biz)
                End If
            End If
        End Sub
#End Region

#Region "DeleteAll"
        <DataObjectMethod(DataObjectMethodType.Delete, False)>
        Public Sub DeleteAll() Implements IReportManager.DeleteAll
            Database.Reports.All(Function(e) CBool(Database.Delete(e)))
        End Sub
#End Region

#Region "GetByCriteria"
        Public Function GetByCriteria(ByVal CommandText As String) As System.Collections.Generic.List(Of Report) Implements IReportManager.GetByCriteria
            Dim recordList As List(Of Report) = Database.Reports.AsQueryable.Where(CommandText).ToList()

            Return recordList
        End Function
#End Region



#Region "GetReportsByItemID"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetReportsByItemID(ByVal ItemID As Integer) As List(Of Report) Implements IReportManager.GetReportsByItemID
            Dim recordList As List(Of Report) = (From biz As Report In Database.Reports
                                                 Where biz.ItemID = ItemID
                                                 Select biz).ToList

            Return recordList
        End Function
#End Region

#Region "GetReportsByPlayerID"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetReportsByPlayerID(ByVal PlayerID As Integer) As List(Of Report) Implements IReportManager.GetReportsByPlayerID
            Dim recordList As List(Of Report) = (From biz As Report In Database.Reports
                                                 Where biz.PlayerID = PlayerID
                                                 Select biz).ToList

            Return recordList
        End Function
#End Region

#Region "GetReportsByTeamID"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetReportsByTeamID(ByVal TeamID As Integer) As List(Of Report) Implements IReportManager.GetReportsByTeamID
            Dim recordList As List(Of Report) = (From biz As Report In Database.Reports
                                                 Where biz.TeamID = TeamID
                                                 Select biz).ToList

            Return recordList
        End Function
#End Region



    End Class
End Namespace
