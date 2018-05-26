Namespace CarPerformance

    Public Class Car
        Implements IDisposable
        Public Color As String
        Public HorsePower As Integer
        Private intSpeed As Integer
        Private intNumberOfDoors As Integer

        Public Sub New()
            'Set the default values
            Color = "White"
            intSpeed = 0
            intNumberOfDoors = 5
        End Sub

        'Speed—read-only property to return the speed
        Public ReadOnly Property Speed() As Integer
            Get
                Return intSpeed
            End Get
        End Property

        'Accelerate—add mph to the speed
        Public Sub Accelerate(accelerateBy As Integer)
            'Adjust the speed
            intSpeed += accelerateBy
        End Sub

        'NumberOfDoors—get/set the number of doors
        Public Property NumberOfDoors() As Integer
            'Called when the property is read
            Get
                Return intNumberOfDoors
            End Get
            'Called when the property is set
            Set(value As Integer)
                'Is the new value between two and five
                If value >= 2 And value <= 5 Then
                    intNumberOfDoors = value
                End If
            End Set
        End Property

        'IsMoving—is the car moving?
        Public Function IsMoving() As Boolean
            'Is the car's speed zero?
            If Speed = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        'CalculateAccelerationRate—assume a constant for a normal car
        Public Overridable Function CalculateAccelerationRate() As Double
            'If we assume a normal car goes from 0–60 in 14 seconds,
            'that's an average rate of 4.2 mph/s
            Return 4.2
        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean ' 要检测冗余调用

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: 释放托管状态(托管对象)。
                End If

                ' TODO: 释放未托管资源(未托管对象)并在以下内容中替代 Finalize()。
                ' TODO: 将大型字段设置为 null。
            End If
            disposedValue = True
        End Sub

        ' TODO: 仅当以上 Dispose(disposing As Boolean)拥有用于释放未托管资源的代码时才替代 Finalize()。
        'Protected Overrides Sub Finalize()
        '    ' 请勿更改此代码。将清理代码放入以上 Dispose(disposing As Boolean)中。
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' Visual Basic 添加此代码以正确实现可释放模式。
        Public Sub Dispose() Implements IDisposable.Dispose
            ' 请勿更改此代码。将清理代码放入以上 Dispose(disposing As Boolean)中。
            Dispose(True)
            ' TODO: 如果在以上内容中替代了 Finalize()，则取消注释以下行。
            ' GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Namespace