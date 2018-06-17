Public Class ExecutionProperies

    Private number1Value As Double
    Public ReadOnly Property number1() As Double
        Get
            Return number1Value
        End Get
    End Property

    Private number2Value As Double
    Public ReadOnly Property number2() As Double
        Get
            Return number2Value
        End Get
    End Property

    Private calculationTypeValue As String
    Public ReadOnly Property calculationType() As String
        Get
            Return calculationTypeValue
        End Get
    End Property

    Sub New(num1 As Double, num2 As Double, calcType As String)
        Me.number1Value = num1
        Me.number2Value = num2
        Me.calculationTypeValue = calcType
    End Sub

End Class
