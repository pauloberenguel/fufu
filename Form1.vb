Imports System.Data.OleDb
Imports fufu.Modulo
Imports fufu.InpOut32_Declarations
Imports System.ComponentModel

Public Class mainform
    Inherits System.Windows.Forms.Form
    Dim temporario As Integer
    Dim bgtrick As Boolean = False
    Dim hDc As Integer
    Const ID_RMC1 = 1
    Private Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As IntPtr) As Integer

    Private Sub btPause_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPause.Click
        Timer1.Enabled = False
        bgtrick = True
        BackgroundWorker1.CancelAsync()
        lblNumero.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub btPlay_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPlay.Click
        BackgroundWorker1.RunWorkerAsync()
        Timer1.Start()
    End Sub

    Private Sub mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To 28
            ListBox1.Items.Add(0)
        Next
        hDc = GetDC(Me.Handle)
    End Sub

    Private Sub mainform_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        FecharBD()
        RMC_DeleteChart(ID_RMC1)
    End Sub

    Private Sub mainform_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        RMC_Paint(ID_RMC1)
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim comando As OleDbCommand
        ListBox1.ScrollAlwaysVisible = False
        Dim nRetVal As Integer
        Dim aData() As Double
        Dim i As Integer

        If numero = 111 Then
            txtNumero.Text = txtNumero.Text.ToString + "1"
            temporario += 1
        End If
        If numero = 127 Then
            txtNumero.Text = txtNumero.Text.ToString + "0"
        End If
        If txtNumero.Text.Length = 8 Then
            Try
                AbrirBD()
                comando = New OleDbCommand("INSERT into meusbytes(numerobyte)values('" & txtNumero.Text & "')", Conexao)
                comando.ExecuteNonQuery()
                FecharBD()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                FecharBD()
            End Try
            'ListBox1.Items.Add(TextBox1.Text)
            ListBox1.Items.Add(temporario)
            txtNumero.Text = ""

            nRetVal = RMC_CreateChartOnDC(hDc, ID_RMC1, 169, 25, 773, 682, RMChart.RMC_Colors.White, _
                                    RMChart.CtrlStyle.RMC_CTRLSTYLEFLAT, False, "", "Tahoma", RMChart.RMC_Colors.AliceBlue)
            If nRetVal < 0 Then GoTo IsError

            nRetVal = RMC_AddRegion(ID_RMC1, 0, 5, -5, -5, "", False)
            If nRetVal < 0 Then GoTo IsError

            nRetVal = RMC_AddCaption(ID_RMC1, 1, "Speedometer", RMChart.RMC_Colors.White, RMChart.RMC_Colors.Black, 12, True)
            If nRetVal < 0 Then GoTo IsError

            nRetVal = RMC_AddGrid(ID_RMC1, 1, RMChart.RMC_Colors.Gray, False, 0, 0, 0, 0, RMChart.GridBicolorMode.RMC_BICOLOR_LABELAXIS)
            If nRetVal < 0 Then GoTo IsError

            nRetVal = RMC_AddDataAxis(ID_RMC1, 1, RMChart.DAxisAlignment.RMC_DATAAXISRIGHT, 0, 10, 0, 10, RMChart.RMC_Colors.Black, RMChart.RMC_Colors.Black, RMChart.AxisLineStyle.RMC_LINESTYLESOLID, 0, "", "", "", RMChart.TextAlignment.RMC_TEXTCENTER)
            If nRetVal < 0 Then GoTo IsError

            nRetVal = RMC_AddLabelAxis(ID_RMC1, 1, "", 1, ListBox1.Items.Count, RMChart.LAxisAlignment.RMC_LABELAXISBOTTOM, 8, RMChart.RMC_Colors.Black, RMChart.TextAlignment.RMC_TEXTCENTER, RMChart.RMC_Colors.Black, RMChart.AxisLineStyle.RMC_LINESTYLESOLID, "Incoming Total Bits")
            If nRetVal < 0 Then GoTo IsError

            ReDim aData((ListBox1.Items.Count - 1))
            For i = 0 To (ListBox1.Items.Count - 1)
                aData(i) = ListBox1.Items.Item(i).ToString
            Next

            nRetVal = RMC_AddLineSeries(ID_RMC1, 1, aData(0), ListBox1.Items.Count, 0, 0, RMChart.LineSeriesType.RMC_LINE, RMChart.LineSeriesStyle.RMC_LINE_CABLE_SHADOW, RMChart.SeriesLineStyles.RMC_LSTYLE_LINE_AREA, False, _
                                            RMChart.RMC_Colors.DeepAzure, RMChart.SeriesSymbolStyles.RMC_SYMBOL_NONE, 1, RMChart.ValueLabels.RMC_VLABEL_NONE, RMChart.Hatchmodes.RMC_HATCHBRUSH_OFF)

            If nRetVal < 0 Then GoTo IsError
            nRetVal = RMC_Draw(ID_RMC1)
IsError:
            temporario = Nothing
            nRetVal = Nothing
        End If
        If ListBox1.Items.Count = 30 Then
            ListBox1.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
        numero = Inp(&H379S)
        lblNumero.Text = numero
        If bgtrick = True Then GoTo stopit
        BackgroundWorker1.RunWorkerAsync()
stopit:
    End Sub
End Class