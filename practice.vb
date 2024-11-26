Imports System

Public Module Hello
   Public Sub Main(  )
      Console.WriteLine("hello, world")
   End Sub
End Module


Dim numbers As New Integer() {5,6,4,8,5}

For ctr As Integer = 0 To 6
   Dim grade As String = If(ctr = 0, "kindergarten", $"grade {ctr}")
   Console.WriteLine($"Students in {grade}: {students(ctr)}")
Next

Module SimpleArray
   Public Sub Main()
      ' Declare an array with 7 elements.
      Dim students(6) As Integer

      ' Assign values to each element.
      students(0) = 23
      students(1) = 19
      students(2) = 21
      students(3) = 17
      students(4) = 19
      students(5) = 20
      students(6) = 22

      ' Display the value of each element.
      For ctr As Integer = 0 To 6
         Dim grade As String = If(ctr = 0, "kindergarten", $"grade {ctr}")
         Console.WriteLine($"Students in {grade}: {students(ctr)}")
      Next
   End Sub

   Public Function second()

      Dim yes As Boolean = False

   End Function
End Module
