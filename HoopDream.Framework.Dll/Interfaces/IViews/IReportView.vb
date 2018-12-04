Imports HoopDream.Framework.ViewModels

'*************************************************************
' Name:  IReportsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace HoopDream.Framework.Interfaces

    Public Interface IReportView

        Sub ShowReport(ByVal ViewModel As ReportViewModel)
        Sub ReadUserInput()
    Sub ShowError(ByVal message as String)
    Sub Close()	     

    End Interface
End Namespace
