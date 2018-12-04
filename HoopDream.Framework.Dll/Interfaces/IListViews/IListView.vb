Imports {PROJECT.NAME}.Framework.ViewModels


'*************************************************************
' Class Name:  IVendorsView
' Purpose:  Encapsulates datacolumn names
' Description: 
'***************************************************************
Namespace Framework.Interfaces

    Public Interface IVendorsView

	Sub ShowVendors(ByVal VendorViewModelList As IEnumerable(Of VendorViewModel))
		     

    End Interface
End Namespace
