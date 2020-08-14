Imports System.Collections.Generic
Imports System.Windows

Public Partial Class MainWindow
	Inherits Window
		
	Public Structure MyEntry
		Public Property namen As String
	    Public Property id As Integer
	    Public Property proz As Double
		Public Property aColor As String
	End Structure
	
	Public Property items = new List(Of MyEntry)

	Public Sub New()
		InitializeComponent()
		
		Dim ca1 As MyEntry
		ca1.id = 2
		ca1.namen = "wetter"
		ca1.proz = 77.1
		ca1.aColor = "#aaff00"
		Dim ca2 As MyEntry
		ca2.id = 5
		ca2.namen = "wetter xyö"
		ca2.proz = 8.0
		ca2.aColor = "#0000ff"
		
		items.Add(ca1)
		items.Add(ca2)
		
		cb_t.ItemsSource = items
	End Sub
	
End Class