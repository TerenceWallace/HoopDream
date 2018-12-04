
Imports HoopDream.Framework.Entities
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Text.RegularExpressions

'*************************************************************
' File Name:  PositionManager
' Purpose:  Data Manager Object
' Description: Sends and receives data from the database, formats, and returns requested object(s). 
'***************************************************************
Namespace HoopDream.Framework.Managers

    Public NotInheritable Class PositionManager
        Inherits Manager
        Implements IPositionManager

        Public Sub New(inDatabase As Database)
            MyBase.New(inDatabase)
        End Sub

#Region "Count"
        Public Function Count() As Integer Implements IPositionManager.Count
            Return Database.Positions.Count
        End Function
#End Region

#Region "Create"
        Public Function Create() As Position Implements IPositionManager.Create
            Return New Position
        End Function
#End Region

#Region "GetByPrimaryKey"
        <DataObjectMethod(DataObjectMethodType.[Select], False)>
        Public Function GetByPrimaryKey(ByVal PositionID As Integer) As Position Implements IPositionManager.GetByPrimaryKey
            Dim biz As Position = (From e As Position In Database.Positions()
                                   Where e.PositionID = PositionID
                                   Select e).FirstOrDefault

            Return biz
        End Function
#End Region

#Region "GetAll"
        <DataObjectMethod(DataObjectMethodType.[Select], True)>
        Public Function GetAll() As System.Collections.Generic.List(Of Position) Implements IPositionManager.GetAll
            Return Database.Positions.ToList
        End Function
#End Region

#Region "Insert"
        <DataObjectMethod(DataObjectMethodType.Insert, True)>
        Public Function Insert(ByVal biz As Position) As Integer Implements IPositionManager.Insert
            Return Database.Insert(biz)
        End Function
#End Region

#Region "Update"
        <DataObjectMethod(DataObjectMethodType.Update, True)>
        Public Sub Update(ByVal biz As Position) Implements IPositionManager.Update
            Database.Update(biz)
        End Sub
#End Region

#Region "Delete"
        <DataObjectMethod(DataObjectMethodType.Delete, True)>
        Public Sub Delete(ByVal biz As Position) Implements IPositionManager.Delete
            If biz IsNot Nothing Then
                If biz.PositionID > 0 Then
                    Database.Delete(biz)
                End If
            End If
        End Sub
#End Region

#Region "DeleteAll"
        <DataObjectMethod(DataObjectMethodType.Delete, False)>
        Public Sub DeleteAll() Implements IPositionManager.DeleteAll
            Database.Positions.All(Function(e) CBool(Database.Delete(e)))
        End Sub
#End Region

#Region "GetByCriteria"
        Public Function GetByCriteria(ByVal CommandText As String) As System.Collections.Generic.List(Of Position) Implements IPositionManager.GetByCriteria
            Dim recordList As List(Of Position) = Database.Positions.AsQueryable.Where(CommandText).ToList()

            Return recordList
        End Function
#End Region





    End Class
End Namespace
