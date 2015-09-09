Public Class MyTest
    Public Function Add(ByVal a, ByVal b) As Integer
        Return a + b
    End Function
    Public Function Substract(ByVal a, ByVal b) As Integer
        Return a - b
    End Function
    Public Function Devide(ByVal a, ByVal b)
        Return a / b
    End Function

    Public Function Multiply(ByVal a, ByVal b) As Integer
        Return a * b
    End Function

    Public Function Funccion(ByVal a, ByVal b)
        Return a * b + a / b - b
    End Function

    Public Function StringAmount()
        Dim vetor(0 To 2) As String
        vetor(0) = "Visual"
        vetor(1) = "Basic"
        vetor(2) = " .NET"
        Return vetor
    End Function

End Class
