Module Module1

    Sub Main()

        Dim addNode As New AdditionNode
        Dim subNode As New SubtractionNode
        Dim multNode As New MultiplicationNode
        Dim divNode As New DivisionNode
        Dim powNode As New PowerNode

        addNode.nextNode(subNode)
        subNode.nextNode(multNode)
        multNode.nextNode(divNode)
        divNode.nextNode(powNode)

        addNode.execute(New ExecutionProperies(3, 2, "add"))
        addNode.execute(New ExecutionProperies(3, 2, "sub"))
        addNode.execute(New ExecutionProperies(3, 2, "mult"))
        addNode.execute(New ExecutionProperies(3, 2, "div"))
        addNode.execute(New ExecutionProperies(3, 2, "pow"))
        addNode.execute(New ExecutionProperies(3, 2, "???"))

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
