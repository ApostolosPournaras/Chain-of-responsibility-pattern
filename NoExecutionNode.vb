Public Class NoExecutionNode
    Implements IChain

    Public Sub execute(executionProperies As ExecutionProperies) Implements IChain.execute
        Console.WriteLine("dummy node does not perform any opperation. Try 'add', 'sub', 'mult', 'div' or 'pow'.")
    End Sub

    Public Sub nextNode(node As IChain) Implements IChain.nextNode
        Console.WriteLine("dummy node does not perform any opperation.")
    End Sub

End Class