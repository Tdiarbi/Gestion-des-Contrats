Imports System
Imports System.IO
Imports System.Data.SqlClient
Module Module1
    Public user, role As String
    Public txtid As String
    Public sumODS As Double
    Public montant1, montant2, montant3, montant4 As Double
    Public sumcontrat As Double
    Public con As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=Contrat;Integrated Security=True")
    Public cmd As New SqlCommand
    Public con1 As SqlConnection = New SqlConnection("Data Source=DELL-SERV7;Initial Catalog=Contrat;Integrated Security=True")

End Module
