Module DataReaderExtensions
    Public strCnxLabRoe As String = ""
    Public strCnx As String = ""

    ''' <summary>
    ''' Reads fieldName from Data Reader. If fieldName is DbNull, returns String.Empty.
    ''' </summary>
    ''' <returns>Safely returns a string. No need to check for DbNull.</returns>
    <System.Runtime.CompilerServices.Extension()> _
    Public Function ReadNullAsEmptyString(ByVal reader As IDataReader, ByVal fieldName As String) As String
        If IsDBNull(reader(fieldName)) Then
            Return String.Empty
        Else
            Return reader(fieldName).ToString.Trim
        End If
        Return False
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Function ReadNullAsEmptyDate(ByVal reader As IDataReader, ByVal fieldName As String) As Nullable(Of Date)
        If IsDBNull(reader(fieldName)) Then
            'Return Nothing
            Return "01/01/1900"
        Else
            Return reader(fieldName).ToString.Trim
        End If
        'Return False
    End Function


    ''' <summary>
    ''' Lee el valor del reader, los campos numericos que son nulos se convierten a cero
    ''' </summary>
    ''' <returns>Safely returns a string. No need to check for DbNull.</returns>
    <System.Runtime.CompilerServices.Extension()> _
    Public Function ReadNullAsNumeric(ByVal reader As IDataReader, ByVal fieldName As String) As String
        If IsDBNull(reader(fieldName)) Then
            Return 0
        Else
            Return reader(fieldName).ToString.Trim
        End If
        Return False
    End Function

    ''' <summary>
    ''' Lee el valor del reader, los campos numericos que son nulos se convierten a cero
    ''' </summary>
    ''' <returns>Safely returns a string. No need to check for DbNull.</returns>
    <System.Runtime.CompilerServices.Extension()> _
    Public Function ReadNullAsBoolean(ByVal reader As IDataReader, ByVal fieldName As String) As String
        If IsDBNull(reader(fieldName)) Then
            Return False
        Else
            Return reader(fieldName).ToString.Trim
        End If
        Return False
    End Function

    ''' <summary>
    ''' Reads fieldOrdinal from Data Reader. If fieldOrdinal is DbNull, returns String.Empty.
    ''' </summary>
    ''' <returns>Safely returns a string. No need to check for DbNull.</returns>
    <System.Runtime.CompilerServices.Extension()> _
    Public Function ReadString(ByVal reader As IDataReader, ByVal fieldOrdinal As Integer) As String
        If IsDBNull(reader(fieldOrdinal)) Then
            Return ""
        Else
            Return reader(fieldOrdinal)
        End If
        Return False
    End Function

    
End Module
