﻿Public Class Computer
    Implements IDisposable

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

    Public ReadOnly Property FreeMemory() As String
        Get
            'Using the My namespace
            Return Format(Expression:=CLng(My.Computer.Info.AvailablePhysicalMemory) \ 1024, Style:="#,###,##0") & " K"
        End Get
    End Property

    Public ReadOnly Property TotalMemory() As String
        Get
            'Using the  My namespace
            Return Format(Expression:=CLng(My.Computer.Info.TotalPhysicalMemory) \ 1024, Style:="#,###,##0") & " K"
        End Get
    End Property
End Class
