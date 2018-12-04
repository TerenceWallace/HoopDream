Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IReportsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IReportsView

        Sub ShowReports(ByVal ReportViewModelList As IEnumerable(Of ReportViewModel))

    End Interface
End Namespace
