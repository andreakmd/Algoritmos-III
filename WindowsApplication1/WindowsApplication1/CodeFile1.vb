Public Class Cine
    Private _nombre As String
    Private _cedula As String
    Private _pelicula As String
    Private _hora As String
    Private _sala As String
    Private _asiento As String

    Public Sub New(nombre As String, ByVal cedula As String, ByVal pelicula As String, hora As String, sala As String, asiento As String)
        Me._nombre = nombre
        Me._cedula = cedula
        Me._pelicula = pelicula
        Me._hora = hora
        Me._sala = sala
        Me._asiento = asiento
    End Sub
    Public Property nombre As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property
    Public Property cedula As String
        Get
            Return Me._cedula
        End Get
        Set(value As String)
            Me._cedula = value
        End Set
    End Property
    Public Property pelicula
        Get
            Return Me._pelicula
        End Get
        Set(value)
            Me._pelicula = value
        End Set
    End Property
    Public Property hora
        Get
            Return Me._hora
        End Get
        Set(value)
            Me._hora = value
        End Set
    End Property
    Public Property sala
        Get
            Return Me._sala
        End Get
        Set(value)
            Me._sala = value
        End Set
    End Property
    Public Property asiento
        Get
            Return Me._asiento
        End Get
        Set(value)
            Me._asiento = value
        End Set
    End Property

End Class
