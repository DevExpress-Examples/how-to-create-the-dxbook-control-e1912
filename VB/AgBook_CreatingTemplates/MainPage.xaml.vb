Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Controls

Namespace AgBook_CreatingTemplates
	Public Class Order
		Private privateCompanyName As String
		Public Property CompanyName() As String
			Get
				Return privateCompanyName
			End Get
			Set(ByVal value As String)
				privateCompanyName = value
			End Set
		End Property
		Private privateCountry As String
		Public Property Country() As String
			Get
				Return privateCountry
			End Get
			Set(ByVal value As String)
				privateCountry = value
			End Set
		End Property
		Private privateCity As String
		Public Property City() As String
			Get
				Return privateCity
			End Get
			Set(ByVal value As String)
				privateCity = value
			End Set
		End Property
		Private privateUnitPrice As Double
		Public Property UnitPrice() As Double
			Get
				Return privateUnitPrice
			End Get
			Set(ByVal value As Double)
				privateUnitPrice = value
			End Set
		End Property
		Private privateQuantity As Integer
		Public Property Quantity() As Integer
			Get
				Return privateQuantity
			End Get
			Set(ByVal value As Integer)
				privateQuantity = value
			End Set
		End Property
	End Class
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			Dim orderList As New List(Of Order)()

			orderList.Add(New Order() With {.CompanyName = "Rancho grande", _
				.City = "Buenos Aires", .Country = "Argentina", .Quantity = 92, .UnitPrice = 576.55})
			orderList.Add(New Order() With {.CompanyName = "Hanari Carnes", _
				.City = "Rio de Janeiro", .Country = "Brazil", .Quantity = 839, .UnitPrice = 1396.10})
			orderList.Add(New Order() With {.CompanyName = "Blondel père et fils", _
				.City = "Strasbourg", .Country = "France", .Quantity = 700, .UnitPrice = 848.75})
			orderList.Add(New Order() With {.CompanyName = "Blauer See Delikatessen", _
				.City = "Mannheim", .Country = "Germany", .Quantity = 140, .UnitPrice = 347.05})
			orderList.Add(New Order() With {.CompanyName = "Antonio Moreno Taquería", _
				.City = "México D.F.", .Country = "Mexico", .Quantity = 359, .UnitPrice = 369.23})

			book.DataSource = orderList
		End Sub
	End Class
End Namespace
