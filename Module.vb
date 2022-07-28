Imports System.Data.OleDb

Module InpOut32_Declarations 'Inp e Out de para a porta usando inpout32.dll.
    Public Declare Function Inp Lib "inpout32.dll" Alias "Inp32" (ByVal PortAddress As Short) As Short
    Public Declare Sub Out Lib "inpout32.dll" Alias "Out32" (ByVal PortAddress As Short, ByVal Value As Short)
End Module

Module Modulo
    Public Conexao As New OleDbConnection("Provider=Microsoft.Jet.OleDB.4.0;" & "Data Source=" & Application.StartupPath & "\bancodedados.mdb")

    Public Sub AbrirBD()
        If Conexao.State = ConnectionState.Closed Then
            Conexao.Open()
        End If
    End Sub

    Public Sub FecharBD()
        If Conexao.State = ConnectionState.Open Then
            Conexao.Close()
        End If
    End Sub
    Public numero As Integer
End Module
