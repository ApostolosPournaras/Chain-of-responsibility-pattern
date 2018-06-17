Public Class AdditionNode
    Implements IChain

    Private nextInChain As IChain

    Sub New()
        Me.nextInChain = New NoExecutionNode()
    End Sub

    Public Sub execute(executionProperies As ExecutionProperies) Implements IChain.execute
        If executionProperies.calculationType = "add" Then
            Console.WriteLine(executionProperies.number1 & " + " & executionProperies.number2 & " = " & (executionProperies.number1 + executionProperies.number2))
        Else
            nextInChain.execute(executionProperies)
        End If
    End Sub

    Public Sub nextNode(node As IChain) Implements IChain.nextNode
        Me.nextInChain = node
    End Sub

End Class