Imports System
Imports TestUnitVB
Imports NUnit.Framework

<TestFixture()> _
Public Class NUnitTest
    Private test As MyTest

    <SetUp()> _
    Public Sub Initialize()
        test = New MyTest()
    End Sub
    <TearDown()> _
    Public Sub CleanUp()
        test = Nothing
    End Sub
    <Test()> _
    Public Sub Addition()
        Assert.AreEqual(5, test.Add(2, 3))
    End Sub

    <Ignore("Ignore a Test")> _
    <Test()> _
    Public Sub Substraction()
        Assert.AreEqual(0, test.Substract(2, 2))
    End Sub

    <Test()> _
    Public Sub Divide()
        Assert.AreEqual(1, test.Devide(3, 3))
    End Sub

    <TestCase(2)> _
    <TestCase(2)> _
    <TestCase(2)> _
    Public Sub Multiply(ByVal Mult)
        Assert.AreEqual(4, test.Multiply(2, Mult))
    End Sub

    <Category("Iteration2")> _
    <Test()> _
    Public Sub Funccion()
        Assert.AreEqual(8, test.Funccion(4, 2))
    End Sub

    <Test(), ExpectedException(GetType(IndexOutOfRangeException))> _
    Public Sub StringAmount()
        Assert.AreEqual("Basic", test.StringAmount(-1))
    End Sub
End Class