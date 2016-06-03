

Public Class ProveedorClienteBE


    Private Ruc As String
    Private RazonSocial As String
    Private Direccion As String


    Public Property _Ruc() As String
        Get
            Return Ruc
        End Get
        Set(ByVal value As String)
            Ruc = value
        End Set
    End Property



    Public Property _RazonSocial() As String
        Get
            Return RazonSocial
        End Get
        Set(ByVal value As String)
            RazonSocial = value
        End Set
    End Property


    Public Property _Direccion() As String
        Get
            Return Direccion
        End Get
        Set(ByVal value As String)
            Direccion = value
        End Set
    End Property



End Class
