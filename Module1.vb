Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public reader As SqlDataReader
    Public ds As New DataSet
    Public adapter As New SqlDataAdapter
    Public dbDataSet As New DataTable
    Public bsource As New BindingSource
    Public query, user As String
End Module
