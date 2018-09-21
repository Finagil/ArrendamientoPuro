Public Class FrmCotizador
    Const TasaIva As Double = 0.16
    Dim TasaFega As Double = 0.0
    Dim TasaVidaMes As Double = 0
    Dim TasaVidaDia As Double = 0
    Dim TasaVidaAnual As Double = 0
    Dim TasaAnualIva As Double = 0
    Dim TasaAnual As Double = 0
    Dim TasaResidual As Double = 0
    Dim Bandera As Boolean = False
    Dim Cat As String
    Dim ContRecur As Double = 0
    Dim FinDeMes As Boolean = False
    Dim Comision As Double = 0.02
    Dim NoRentas As Integer = 0
    Dim RentasDEP As Double = 0
    Dim Amorin As Double = 0
    Dim Residual As Double = 0
    Dim ComisionImp As Double = 0
    Dim ValorFact As Double = 0
    Dim IvaFact As Double = 0
    Dim Ratifica As Double = 2000
    Dim Fondeo As String = "01"
    Dim Coberturas As String = "N"
    Dim NumPagos As Integer = 0
    Dim RPP As Double = 0
    Dim Gastos As Double = 0
    Dim MontoFin As Double = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TasaVidaMes = Me.ClientesTableAdapter.SacaConfiguracion("porc_seg")
        TasaFega = Me.ClientesTableAdapter.SacaConfiguracion("porc_fega")
        TasaVidaDia = TasaVidaMes / 30.4
        TasaVidaAnual = TasaVidaMes * 12
        TasaAnualIva = 0.0 * (1 + TasaIva)


        Me.ClientesTableAdapter.Fill(Me.ProductionDataSet.Clientes)
        Me.LI_PeriodosTableAdapter.Fill(Me.ProductionDataSet.LI_Periodos)
        Me.LI_PlazosTableAdapter.Fill(Me.ProductionDataSet.LI_Plazos)
        FijaTasa()
        TasaAnualIva = Math.Round(TasaAnualIva, 4)

        Me.CmbTipoCot.SelectedIndex = 0
        Me.ComboSeguro.Text = "NO"
        Me.CmbFira.Text = "NO"
        Me.ComboCapital.Text = "NO"
        Me.CmbRentasDep.Text = 0
        TxtTasa.Text = 25
        TxtRatifica.Text = "2,000"
        ''PRUEBAS+++++++++++++++++++++++++++++
        'Dfechacon.Value = "26/08/2015"
        DfechaVenc.Value = CDate(DfechaVenc.Value.ToShortDateString)
        DfechaVenc.Value = DfechaVenc.Value.AddDays(-1 * DfechaVenc.Value.Day).AddMonths(1).AddDays(21)
        If DateDiff(DateInterval.Day, Date.Now, DfechaVenc.Value) > 45 Then
            DfechaVenc.Value = DfechaVenc.Value.AddDays(-1 * DfechaVenc.Value.Day).AddDays(6)
        End If


        'ComboPlazo.Text = "60 meses"
        'TxtMonto.Text = "40,000,000"
        'TxtTasa.Text = 18
        'TxtResidual.Text = 5
        'TxtPagoObj.Text = "8,000,000"
        'TxtRatifica.Text = "5,000"
        'TxtRpp.Text = "1,000"



        'Bandera = True
        ''PRUEBAS+++++++++++++++++++++++++++++
        CmbTipoCot.Focus()

    End Sub

    Private Sub Bcalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcalcular.Click
        If Bandera = False Then
            'If Dfechacon.Value <= Date.Now.AddDays(-1) Then
            '    MessageBox.Show("Fecha de Contrato No valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Dfechacon.Select()
            '    Exit Sub
            'End If

            If DfechaVenc.Value <= Date.Now Then
                MessageBox.Show("Fecha de 1er vencimiento No valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If DfechaVenc.Value <= Dfechacon.Value Then
                MessageBox.Show("Fecha de 1er vencimiento No puede ser menor o igual a la fecha de contratacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If DfechaVenc.Value.DayOfWeek <> DayOfWeek.Friday And ComboPeriodo.Text <> "Mensual" And ComboPeriodo.Text <> "Quincenal" Then
                MessageBox.Show("Fecha de 1er vencimiento No es dia Viernes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If ComboPeriodo.Text = "Mensual" And DfechaVenc.Value.Day <> 6 And DfechaVenc.Value.Day <> 20 Then
                MessageBox.Show("Fecha mensual no valida (debe ser día 6 o 20).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            DfechaVenc.Value = DfechaVenc.Value.ToShortDateString
            Dim DiaUltimo As Date = DfechaVenc.Value
            DiaUltimo = DiaUltimo.AddMonths(1)
            DiaUltimo = DiaUltimo.AddDays(DiaUltimo.Day * (-1))
            If ComboPeriodo.Text = "Quincenal" And DfechaVenc.Value.Day <> 15 And DfechaVenc.Value <> DiaUltimo Then
                MessageBox.Show("Fecha Quincenal no valida (debe ser día 15 o ultimo dia de mes).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
        End If

        If IsNumeric(TxtMonto.Text) = False Then
            MessageBox.Show("Monto Financiado No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
            TxtMonto.SelectAll()
            Exit Sub
        ElseIf IsNumeric(TxtPagoObj.Text) = False Then
            MessageBox.Show("Monto de pago inicial objetivo No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPagoObj.Text = "0"
            TxtPagoObj.Focus()
            Exit Sub
        ElseIf CDbl(TxtPagoObj.Text) < 0 And CmbTipoCot.Text = "Pago Inicial Objetivo" Then
            MessageBox.Show("Monto de pago inicial objetivo No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPagoObj.Text = 0
            TxtPagoObj.SelectAll()
            TxtPagoObj.Focus()
            Exit Sub
        ElseIf CmbRentasDep.SelectedIndex <= 0 And CmbTipoCot.Text = "Rentas Anticipadas" Then
            MessageBox.Show("Número de rentas en deposito no validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbRentasDep.Focus()
            Exit Sub
        ElseIf IsNumeric(TxtGracia.Text) = False Then
            MessageBox.Show("Numero de Dias de Renta no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtGracia.Text = 0
            TxtGracia.SelectAll()
            Exit Sub
        ElseIf IsNumeric(TxtResidual.Text) = False Then
            MessageBox.Show("Residual No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
            TxtMonto.SelectAll()
            Exit Sub
        ElseIf CDbl(TxtMonto.Text) < 2000 Or CDbl(TxtMonto.Text) > 1000000000 Then
            MessageBox.Show("Monto Financiado fuera de Rango valido. (de 2,000 hasta 1,000,000,000)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
            TxtMonto.SelectAll()
            Exit Sub
        Else
            TxtMonto.Text = Format(CDbl(TxtMonto.Text), "N2")
        End If
        If Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue) <= Val(CmbRentasDep.Text) Then
            MessageBox.Show("Número de rentas en depósito no validas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbRentasDep.Select()
            Exit Sub
        End If
        FijaTasa()
        CalculaTabla()
        'CalculaTabla()
        'BtPrint.Enabled = True
        CrystalReportViewer1.Visible = True
        GridAmortizaciones.Visible = False
        BtPrint_Click(Nothing, Nothing)

    End Sub

    Private Sub Dfechacon_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dfechacon.LostFocus
        If Bandera = False Then
            If Dfechacon.Value <= Date.Now.AddDays(-1) Then
                MessageBox.Show("Fecha de Contrato No valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dfechacon.Select()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub DfechaVenc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DfechaVenc.LostFocus
        If Bandera = False Then
            If DfechaVenc.Value <= Date.Now Then
                MessageBox.Show("Fecha de 1er vencimiento No valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If DfechaVenc.Value.DayOfWeek <> DayOfWeek.Friday And ComboPeriodo.Text <> "Mensual" And ComboPeriodo.Text <> "Quincenal" Then
                MessageBox.Show("Fecha de 1er vencimiento No es dia Viernes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            If ComboPeriodo.Text = "Mensual" And DfechaVenc.Value.Day <> 6 And DfechaVenc.Value.Day <> 20 Then
                MessageBox.Show("Fecha mensual no valida (debe ser día 6 o 20).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
            DfechaVenc.Value = DfechaVenc.Value.ToShortDateString
            Dim DiaUltimo As Date = DfechaVenc.Value
            DiaUltimo = DiaUltimo.AddMonths(1)
            DiaUltimo = DiaUltimo.AddDays(DiaUltimo.Day * (-1))
            If ComboPeriodo.Text = "Quincenal" And DfechaVenc.Value.Day <> 15 And DfechaVenc.Value <> DiaUltimo Then
                MessageBox.Show("Fecha Quincenal no valida (debe ser día 15 o ultimo dia de mes).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DfechaVenc.Select()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TxtMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMonto.LostFocus
        If IsNumeric(TxtMonto.Text) = False Then
            MessageBox.Show("Monto Financiado No valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
        ElseIf CDbl(TxtMonto.Text) < 2000 Or CDbl(TxtMonto.Text) > 1000000000 And Bandera = False Then
            MessageBox.Show("Monto Financiado fuera de Rango valido. (de 2,000 hasta 1,000,000,000)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonto.Text = 0
        Else
            TxtMonto.Text = Format(CDbl(TxtMonto.Text), "N")
        End If
    End Sub

    Private Sub BtPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPrint.Click
        Dim rep As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim DS As New ProductionDataSet
        Dim R As ProductionDataSet.ReporteRow
        Dim Poss As Integer = 0

        For Each rr As DataGridViewRow In GridAmortizaciones.Rows
            Poss += 1
            R = DS.Tables("Reporte").NewRow
            R.NoPago = rr.Cells("Pago").Value
            R.FecCon = Dfechacon.Value
            R.FecVen = rr.Cells("FechaVencimiento").Value
            R.Dias = rr.Cells("Dias").Value
            R.Saldo = rr.Cells("Fega").Value - (rr.Cells("Fega").Value / (1 + TasaIva)) 'rr.Cells("SaldoInsoluto").Value
            R.Capital = rr.Cells("capital").Value
            R.Interes = rr.Cells("Interes").Value
            R.Pago = rr.Cells("Pagos").Value
            R.Iva = rr.Cells("IvaInteres").Value
            R.Seguro = rr.Cells("seguro").Value
            R.Fega = rr.Cells("Fega").Value / (1 + TasaIva)
            R.PagoT = (R.Pago * TasaIva) + R.Seguro + R.Pago + R.Fega + R.Saldo
            R.Tasa = TxtTasa.Text
            R.Seg = TasaVidaMes
            If Poss >= NumPagos - NoRentas + 1 And Poss <= NumPagos And NoRentas > 0 Then

            End If
            DS.Tables("Reporte").Rows.Add(R)

        Next
        Dim newrptRepSalCli As New ArrendamientoPuro.Cotizacion
        newrptRepSalCli.SetDataSource(DS)
        If CheckBox1.Checked = True Then
            newrptRepSalCli.SetParameterValue("Nombre", ComboCliente.Text)
        Else
            newrptRepSalCli.SetParameterValue("Nombre", "")
        End If
        Call llenaDatos()
        newrptRepSalCli.SetParameterValue("Residual", Residual * (1 + TasaIva))
        newrptRepSalCli.SetParameterValue("ValorFact", ValorFact * (1 + TasaIva))
        newrptRepSalCli.SetParameterValue("RentasDep", RentasDEP + (RentasDEP * TasaIva))
        newrptRepSalCli.SetParameterValue("Comision", ComisionImp)
        newrptRepSalCli.SetParameterValue("Ratificacion", Ratifica)
        newrptRepSalCli.SetParameterValue("RPP", RPP)
        newrptRepSalCli.SetParameterValue("RPPiva", RPP * TasaIva)
        newrptRepSalCli.SetParameterValue("Fondeo", IIf(Fondeo = "03", "FIRA", "Propios"))
        newrptRepSalCli.SetParameterValue("Iva", TasaIva)
        newrptRepSalCli.SetParameterValue("RentaAnti", Amorin)
        newrptRepSalCli.SetParameterValue("RentaAntiIVA", Amorin * TasaIva)


        CrystalReportViewer1.ReportSource = newrptRepSalCli
        CrystalReportViewer1.Visible = True
        GridAmortizaciones.Visible = False
        TxtTCAP.Visible = False
        TxtTpag.Visible = False
        TxtTint.Visible = False
        TxtTiva.Visible = False
        TxtIvaCap.Visible = False
        TxtTseg.Visible = False
        TxtTtot.Visible = False
        TxtDiasT.Visible = False
        TxtFega.Visible = False
        BtPrint.Enabled = False

    End Sub

    Private Sub ComboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboCliente.SelectedIndexChanged
        If ComboCliente.SelectedValue <> Nothing Then
            Me.AnexosTableAdapter.Fill(Me.ProductionDataSet.Anexos, ComboCliente.SelectedValue)
            FijaTasa()
        End If
    End Sub

    Sub CalculaTabla()
        'Dim MontoFin As Double = CDbl(TxtMonto.Text).ToString("N2") / (1 + TasaIva)
        'MontoFin -= CDbl(TxtPagoObj.Text).ToString("N2") / (1 + TasaIva)
        Dim NoPagos As Integer = 0
        Dim NoPagosAnual As Integer = 0
        Dim Capital As Double = MontoFin
        Dim CapitalSEG As Double = MontoFin
        Dim MesSeguro As String = ""
        Dim FechaAux As Date = DfechaVenc.Value.ToShortDateString
        Dim FechaFin As Date = DfechaVenc.Value
        Dim SegVidaX As Double = TasaVidaDia
        Dim ErrorEnero As Date = DfechaVenc.Value.ToShortDateString
        Dim AmorExtra As Boolean = False
        Dim AjusteFin As Double = 0
        Dim IvaRenta As Double = 0
        Dim Fega As Double = 0
        Dim PagoFin As Double = 0
        Dim SegVid As Double = 0
        Dim Semanas As Integer = Me.LI_PlazosTableAdapter.ScalarSemanas(ComboPlazo.SelectedValue)
        Dim Catorcenas As Integer = Me.LI_PlazosTableAdapter.ScalarCatorcenas(ComboPlazo.SelectedValue)
        Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)
        Dim Quincenas As Integer = Meses * 2
        If ComboSeguro.Text = "NO" Then SegVidaX = 0
        Select Case ComboPeriodo.Text
            Case "Semanal"
                FechaFin = DfechaVenc.Value.AddDays(ComboPeriodo.SelectedValue * Semanas)
                NoPagos = Semanas
                NoPagosAnual = 52
            Case "Catorcenal"
                FechaFin = DfechaVenc.Value.AddDays(ComboPeriodo.SelectedValue * Catorcenas)
                NoPagos = Catorcenas
                NoPagosAnual = 26
            Case "Mensual"
                FechaFin = DfechaVenc.Value.AddMonths(ComboPeriodo.SelectedValue * Meses)
                NoPagos = Meses
                NoPagosAnual = 12
            Case "Quincenal"
                FechaFin = DfechaVenc.Value.AddMonths((Quincenas / 2))
                NoPagos = Quincenas
                NoPagosAnual = 24
        End Select
        If Val(TxtGracia.Text) >= NoPagos Then
            MessageBox.Show("Periodos de gracias invalidos.", "Error Días de Renta.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GridAmortizaciones.Rows.Clear()
            Exit Sub
        End If
        Dim Gracia As Integer = Val(TxtGracia.Text)
        Dim FechaAnt As Date = Dfechacon.Value.ToShortDateString
        Dim Cont As Integer = 0
        Dim Dias As Double = 0
        Dim DiasX As Double = 0
        Dim Interes As Double = 0

        Dim PagoX As Double = 0
        Dim PagoY As Double = 0
        Dim Extra As Double = 0
        Dim Aux As Double = 0
        Dim Aux2 As Double = 0

        GridAmortizaciones.Rows.Clear()
        MesSeguro = FechaAux.ToString("yyyyMM")

        While FechaAux < FechaFin.ToShortDateString
            Cont += 1
            If Cont = 1 Then
                If FechaAux.AddDays(1).Day = 1 And FechaAux.Month <> 2 Then
                    FinDeMes = True
                Else
                    FinDeMes = False
                End If
            End If
            If ComboCapital.Text = "NO" And Cont = 2 Then
                Aux = CDbl(GridAmortizaciones.Rows(0).Cells("Interes").Value)
                Capital = (MontoFin) - (PagoY - Aux).ToString("N2")
            End If
            Dias = DateDiff(DateInterval.Day, FechaAnt, FechaAux)
            If Dias > ComboPeriodo.SelectedValue * 3 And ComboPeriodo.Text = "Semanal" Then
                MessageBox.Show("los dias del vencimiento sobrepasa tres veces el periodo.", "Error Semanas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridAmortizaciones.Rows.Clear()
                Exit Sub
            End If
            If Dias > ComboPeriodo.SelectedValue * 2 And ComboPeriodo.Text = "Catorcenal" Then
                MessageBox.Show("los dias del vencimiento sobrepasa dos veces el periodo.", "Error Catorcena.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridAmortizaciones.Rows.Clear()
                Exit Sub
            End If
            If Dias > 45 And ComboPeriodo.Text = "Mensual" Then
                MessageBox.Show("los dias del vencimiento sobrepasa 45 días.", "Error Meses.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridAmortizaciones.Rows.Clear()
                Exit Sub
            End If
            If Dias > 45 And ComboPeriodo.Text = "Quincenal" Then
                MessageBox.Show("los dias del vencimiento sobrepasa 45 días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridAmortizaciones.Rows.Clear()
                Exit Sub
            End If
            If ComboCapital.Text = "SI" And Gracia = 0 Then
                MessageBox.Show("dias de renta no validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GridAmortizaciones.Rows.Clear()
                Exit Sub
            End If
            Dias = 30 ' todo se calcula con meses de 30 dias
            Interes = (Capital * (TasaAnual / 360) * Dias).ToString("N2")
            If CmbFira.Text = "SI" Then
                Fega = (Capital * (TasaFega / 360) * Dias) * (1 + TasaIva)
            Else
                Fega = 0
            End If
            GridAmortizaciones.Rows.Add(1)
            GridAmortizaciones.Rows(Cont - 1).Cells("pago").Value = Cont
            GridAmortizaciones.Rows(Cont - 1).Cells("FechaVencimiento").Value = FechaAux.ToShortDateString
            GridAmortizaciones.Rows(Cont - 1).Cells("dias").Value = Dias 'DIAS
            If ComboCapital.Text = "SI" And Cont <= Gracia Then
                PagoX = Interes.ToString("N2")
                GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value = 0
                GridAmortizaciones.Rows(Cont - 1).Cells("Pagos").Value = PagoX.ToString("N2")
                AmorExtra = True
            Else
                If Cont = 1 And Gracia = 0 Then
                    If ComboPeriodo.Text <> "Mensual" Then
                        DiasX = ComboPeriodo.SelectedValue
                    Else
                        DiasX = DateDiff(DateInterval.Day, FechaAnt, FechaAnt.AddMonths(ComboPeriodo.SelectedValue))
                    End If
                    PagoX = Pmt((TasaAnual / 360) * 30, NoPagos, Capital * -1, Residual, DueDate.EndOfPeriod)
                    PagoY = Pmt((TasaAnual / 360) * 30, NoPagos, Capital * -1, Residual, DueDate.EndOfPeriod)
                Else
                    If AmorExtra = True Then
                        PagoX = Pmt((TasaAnual / 360) * Dias, NoPagos - (Cont - 1), Capital * -1, Residual, DueDate.EndOfPeriod).ToString("N2")
                        AmorExtra = False
                    End If
                    If ComboCapital.Text = "NO0" And Cont = 2 And Gracia = 0 Then 'CORRIGE PRIMERA AMORTIZACION POR DIFERENCIA 
                        'Aux = (PagoX - CDbl(GridAmortizaciones.Rows(0).Cells("Interes").Value)).ToString("N2")
                        'Capital = CDbl(MontoFin) - Aux
                        'PagoX = Pmt((TasaAnual / 360) * 30, NoPagos - (Cont - 1), Capital * -1, Residual, DueDate.EndOfPeriod).ToString("N2")
                        'Interes = (Capital * (TasaAnual / 360) * Dias).ToString("N2")
                        'GridAmortizaciones.Rows(0).Cells("Capital").Value = PagoX.ToString("N2") - GridAmortizaciones.Rows(0).Cells("Interes").Value ' CAPITAL
                        'GridAmortizaciones.Rows(0).Cells("Pagos").Value = PagoX.ToString("N2")
                        'GridAmortizaciones.Rows(0).Cells("IvaInteres").Value = PagoX * TasaIva.ToString("N2")
                        'Capital += Aux - (GridAmortizaciones.Rows(0).Cells("Capital").Value)
                        'GridAmortizaciones.Rows(0).Cells("PagoTotal").Value = (CDec(GridAmortizaciones.Rows(0).Cells("IvaInteres").Value) + CDec(GridAmortizaciones.Rows(0).Cells("Pagos").Value) + CDec(GridAmortizaciones.Rows(0).Cells("Seguro").Value)).ToString("n2") + Fega
                    ElseIf ComboCapital.Text = "SI" And Cont = Gracia + 1 Then
                        PagoX = Pmt((TasaAnual / 360) * (Dias), NoPagos - (Cont - 1), Capital * -1, Residual, DueDate.EndOfPeriod).ToString("N2")
                    End If
                End If
            End If
            GridAmortizaciones.Rows(Cont - 1).Cells("SaldoInsoluto").Value = Capital.ToString("N2")
            GridAmortizaciones.Rows(Cont - 1).Cells("Interes").Value = Interes.ToString("N2") ' INTERES
            GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value = (PagoX - Interes).ToString("N2") ' CAPITAL
            GridAmortizaciones.Rows(Cont - 1).Cells("ivaCapital").Value = 0 '((PagoX - Interes) * TasaIva).ToString("N2") ' CAPITAL
            GridAmortizaciones.Rows(Cont - 1).Cells("Pagos").Value = PagoX.ToString("N2")

            If MesSeguro <> FechaAux.ToString("yyyyMM") Then
                CapitalSEG = Capital
            End If
            SegVid = (((Capital + Interes) / 1000) * SegVidaX * Dias)
            IvaRenta = (PagoX) * (TasaIva)

            MesSeguro = FechaAux.ToString("yyyyMM")
            GridAmortizaciones.Rows(Cont - 1).Cells("IvaInteres").Value = IvaRenta.ToString("N2")
            GridAmortizaciones.Rows(Cont - 1).Cells("Seguro").Value = SegVid.ToString("N2")
            GridAmortizaciones.Rows(Cont - 1).Cells("Fega").Value = Fega.ToString("N2")
            GridAmortizaciones.Rows(Cont - 1).Cells("PagoTotal").Value = ((PagoX - Interes) + Interes + IvaRenta + SegVid + Fega).ToString("N2")
            Capital = Capital.ToString("N2") - (PagoX.ToString("N2") - Interes.ToString("N2"))

            If NoPagos = Cont Then
                PagoFin = (PagoX - Interes)
                AjusteFin = Capital - Residual
                PagoFin = PagoFin + AjusteFin
                GridAmortizaciones.Rows(Cont - 1).Cells("Capital").Value = PagoFin  ' CAPITAL
                GridAmortizaciones.Rows(Cont - 1).Cells("IVACapital").Value = 0 'PagoFin * TasaIva  ' CAPITAL
                GridAmortizaciones.Rows(Cont - 1).Cells("Pagos").Value = PagoFin + Interes 'Renta
                GridAmortizaciones.Rows(Cont - 1).Cells("IvaInteres").Value = (PagoFin + Interes) * TasaIva.ToString("N2")
                GridAmortizaciones.Rows(Cont - 1).Cells("PagoTotal").Value = (PagoFin + Interes) * TasaIva + (PagoFin + Interes) + Fega + SegVid
            End If


            FechaAnt = FechaAux
            If ComboPeriodo.Text = "Quincenal" Then
                If FechaAux.Day = 15 Then
                    FechaAux = FechaAux.AddMonths(1)
                    FechaAux = FechaAux.AddDays(FechaAux.Day * (-1))
                Else
                    FechaAux = FechaAux.AddDays(15)
                End If
            ElseIf ComboPeriodo.Text <> "Mensual" Then
                FechaAux = FechaAnt.AddDays(ComboPeriodo.SelectedValue)
            Else
                If FinDeMes = False Then
                    FechaAux = FechaAnt.AddMonths(ComboPeriodo.SelectedValue)
                    If Cont = 2 And FechaAnt.Month = 2 And FechaAnt.AddDays(1).Day = 1 Then
                        If ErrorEnero.Day = 29 And FechaAux.Day = 28 Then FechaAux = FechaAux.AddDays(1)
                        If ErrorEnero.Day = 30 And FechaAux.Day = 28 Then FechaAux = FechaAux.AddDays(2)
                        If ErrorEnero.Day = 30 And FechaAux.Day = 29 Then FechaAux = FechaAux.AddDays(1)
                    End If
                Else
                    FechaAux = FechaAnt.AddDays(1)
                    FechaAux = FechaAux.AddMonths(ComboPeriodo.SelectedValue)
                    FechaAux = FechaAux.AddDays(-1)
                End If

            End If
            If Cont = 1 Then
                If GridAmortizaciones.Rows(0).Cells("Capital").Value < 0 Then
                    MessageBox.Show("Primera amortizacion Menor a cero, reconsidere las fecha de contratacion.", "Error de fechas.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GridAmortizaciones.Rows.Clear()
                    Exit Sub
                End If
            End If
        End While


        Dim CapitaT As Double = 0
        Dim PagoT As Double = 0
        Dim InteresT As Double = 0
        Dim IvaT As Double = 0
        Dim IvaCapT As Double = 0
        Dim SegT As Double = 0
        Dim FegaT As Double = 0
        Dim TotalT As Double = 0
        Dim Diferencia As Double = 0
        Dim DiasT As Double = 0
        Dim PagoS(NoPagos) As Double
        Cont = 0
        PagoS(0) = MontoFin * -1
        For Each rr As DataGridViewRow In GridAmortizaciones.Rows
            Cont += 1
            PagoS(Cont) = CDbl(rr.Cells("PagoTotal").Value) - CDbl(rr.Cells("IvaInteres").Value)
            Capital = CDbl(rr.Cells("Capital").Value)
            CapitaT += Capital
            PagoT += CDbl(rr.Cells("Pagos").Value)
            DiasT += CDbl(rr.Cells("Dias").Value)
            InteresT += CDbl(rr.Cells("Interes").Value)
            IvaT += CDbl(rr.Cells("IvaInteres").Value)
            IvaCapT += CDbl(rr.Cells("IvaCapital").Value)
            SegT += CDbl(rr.Cells("Seguro").Value)
            FegaT += CDbl(rr.Cells("Fega").Value)
            TotalT += CDbl(rr.Cells("PagoTotal").Value)
        Next


        If GridAmortizaciones.Rows.Count > 0 Then
            Dim TIR As Double = IRR(PagoS, 0.01)
            Cat = Math.Round((((1 + (TIR)) ^ NoPagosAnual) - 1), 3).ToString("p1")
            'LbAjuste.Text = "CAT: " & Cat & "  Ajuste: " & Diferencia.ToString
        End If


        TxtTCAP.Text = (CapitaT - Diferencia).ToString("N2")
        TxtTpag.Text = PagoT.ToString("N2")
        TxtTint.Text = InteresT.ToString("N2")
        TxtTiva.Text = IvaT.ToString("N2")
        TxtIvaCap.Text = IvaCapT.ToString("N2")
        TxtTseg.Text = SegT.ToString("N2")
        TxtTtot.Text = TotalT.ToString("N2")
        TxtDiasT.Text = DiasT.ToString("N0")
        TxtFega.Text = FegaT.ToString("n2")


    End Sub

    Sub BusquedaTasa(ByVal Capital As Double, ByVal NoPagos As Double, ByVal PagoOBJ As Double)
        Dim Tasa As Double = 0
        Dim Incremento As Double = 0.1
        Dim pago As Double = 0
        Dim Baja As Boolean = False
        Dim Sube As Boolean = True
        Do
            Tasa += Incremento
            pago = Pmt(Tasa / 12, NoPagos, Capital * -1).ToString("N2")

            If pago > PagoOBJ And Sube = True Then
                Incremento = Incremento / 10
                Incremento = Incremento * -1
                Sube = False
                Baja = True
            End If
            If pago < PagoOBJ And Baja = True Then
                Incremento = Incremento / 10
                Incremento = Incremento * -1
                Sube = True
                Baja = False
            End If
        Loop While pago <> PagoOBJ
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCargar.Click
        If Bandera = True Then
            MessageBox.Show("Modo Simulador Activado.", "Modo Simulador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Está seguro de sobreescribir la tabla de Amortizacion", "Cambiar Contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If
        If GridAmortizaciones.Rows.Count > 0 Then
            If CDbl(TxtMonto.Text) - CDbl(TxtPagoObj.Text) <> CDbl(LbImporte.Text) And CmbTipoCot.SelectedIndex = 1 Then
                'MessageBox.Show("El importe del contrato no coincide con la tabla.", "Error de Tabla de Amortizacion.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Exit Sub
            End If
            Dim Taa As New ArrendamientoPuro.ProductionDataSetTableAdapters.EdoctavTableAdapter
            Dim Frecuencia As String = ""
            Dim NoPagos As Integer = 0
            Dim Semanas As Integer = Me.LI_PlazosTableAdapter.ScalarSemanas(ComboPlazo.SelectedValue)
            Dim Catorcenas As Integer = Me.LI_PlazosTableAdapter.ScalarCatorcenas(ComboPlazo.SelectedValue)
            Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)
            Dim Quincenas As Integer = Meses * 2
            Dim RtaDep As New ProductionDataSetTableAdapters.RentasdepTableAdapter
            Dim taOp As New ProductionDataSetTableAdapters.OpcionesTableAdapter
            Select Case ComboPeriodo.Text
                Case "Semanal"
                    NoPagos = Semanas
                    Frecuencia = "DIAS"
                Case "Catorcenal"
                    NoPagos = Catorcenas
                    Frecuencia = "DIAS"
                Case "Mensual"
                    NoPagos = Meses
                    Frecuencia = "MESES"
                Case "Quincenal"
                    NoPagos = Quincenas
                    Frecuencia = "DIAS"
            End Select
            Dim ta As New ArrendamientoPuro.ProductionDataSetTableAdapters.AnexosTableAdapter
            Dim taS As New ArrendamientoPuro.ProductionDataSetTableAdapters.CreditTableAdapter
            Dim Fven As Date = GridAmortizaciones.Rows(GridAmortizaciones.Rows.Count - 1).Cells("FechaVencimiento").Value



            llenaDatos()
            ta.UpdateAnexo(ValorFact + IvaFact, Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue),
                           TasaAnual * 100, Dfechacon.Value.ToString("yyyyMMdd"), GridAmortizaciones.Rows(1).Cells("pagos").Value,
                           DfechaVenc.Value.ToString("yyyyMMdd"), Frecuencia, GridAmortizaciones.Rows(1).Cells("dias").Value, NoPagos, TasaVidaMes,
                           Amorin, NoRentas, RentasDEP, RentasDEP * (TasaIva), Amorin * TasaIva, TasaResidual * 100, ComisionImp * (1 + TasaIva),
                           Fondeo, Coberturas, 0, Gastos, Gastos * TasaIva, IvaFact, Comision * 100, ComboAnexo.SelectedValue)

            taOp.DeleteOpcion(ComboAnexo.SelectedValue)
            taOp.Insert(ComboAnexo.SelectedValue, Residual, Residual * TasaIva, TasaIva, "N", "N")

            Dim letra As String = ""
            Dim LEtraNum As Integer = 0
            Taa.DeleteAnexo(ComboAnexo.SelectedValue)
            RtaDep.DeleteAnexo(ComboAnexo.SelectedValue)

            For Each rr As DataGridViewRow In GridAmortizaciones.Rows
                Fven = rr.Cells("FechaVencimiento").Value
                LEtraNum = rr.Cells("pago").Value
                letra = rr.Cells("pago").Value
                If letra.Length = 1 Then letra = "00" & letra
                If letra.Length = 2 Then letra = "0" & letra
                Taa.Insert(ComboAnexo.SelectedValue, letra, Fven.ToString("yyyyMMdd"), 0, "S", CDbl(rr.Cells("SaldoInsoluto").Value),
                            CDbl(rr.Cells("capital").Value), CDbl(rr.Cells("Interes").Value),
                           (CDbl(rr.Cells("capital").Value) + CDbl(rr.Cells("Interes").Value)) * TasaIva, 0, 0, 0)
                'If LEtraNum >= NoPagos - NoRentas + 1 And LEtraNum <= NoPagos And NoRentas > 0 Then
                '    RtaDep.Insert(ComboAnexo.SelectedValue, letra, Fven.ToString("yyyyMMdd"), 0, "S",
                '                  CDbl(rr.Cells("SaldoInsoluto").Value), CDbl(rr.Cells("capital").Value), CDbl(rr.Cells("Interes").Value),
                '                  (CDbl(rr.Cells("capital").Value) + CDbl(rr.Cells("Interes").Value)) * TasaIva, 0, "N")
                'End If
            Next
            ComboCliente_SelectedIndexChanged(Nothing, Nothing)
            MessageBox.Show("La tabla del contrato " & ComboAnexo.Text & " se cambio con exito.", "Anexo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("No exsiste tabla para cargar.", "Error de Tabla de Amortizacion.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboAnexo.SelectedIndexChanged
        ButtonCargar.Enabled = True
    End Sub

    Private Sub txtSimulador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSimulador.Click
        If Bandera = True Then
            Bandera = False
            Me.Text = "Arrendamiento Puro"
        Else
            Bandera = True
            Me.Text = "Arrendamiento Puro - Modo Simulador (No valida Fecha)"
        End If
    End Sub

    Private Sub CheckFinagil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FijaTasa()
    End Sub

    Private Sub ComboCapital_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCapital.SelectedIndexChanged
        If ComboCapital.Text = "NO" Then
            TxtGracia.Enabled = False
            TxtGracia.Text = 0
        Else
            TxtGracia.Enabled = True
            TxtGracia.Text = 1
        End If
    End Sub

    Private Sub ComboPlazo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPlazo.SelectedIndexChanged
        FijaTasa()
    End Sub

    Sub FijaTasa(Optional b As Boolean = False)
        If ComboPlazo.SelectedIndex >= 0 Then
            Dim Meses As Integer = Me.LI_PlazosTableAdapter.ScalarMeses(ComboPlazo.SelectedValue)

            TasaAnual = Val(TxtTasa.Text) / 100
            TasaResidual = Val(TxtResidual.Text) / 100
            Comision = Val(TxtComision.Text) / 100
            If CmbRentasDep.Text <> "" Then
                NoRentas = CInt(CmbRentasDep.Text)
            End If
            llenaDatos()

            'TxtTasa.Text = TasaAnual.ToString("P02")
            'TxtResidual.Text = tasaresidual.ToString("P02")
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        GridAmortizaciones.Visible = Not GridAmortizaciones.Visible
        CrystalReportViewer1.Visible = Not CrystalReportViewer1.Visible

        TxtTCAP.Visible = Not TxtTCAP.Visible
        TxtTpag.Visible = Not TxtTpag.Visible
        TxtTint.Visible = Not TxtTint.Visible
        TxtTiva.Visible = Not TxtTiva.Visible
        TxtIvaCap.Visible = Not TxtIvaCap.Visible
        TxtTseg.Visible = Not TxtTseg.Visible
        TxtTtot.Visible = Not TxtTtot.Visible
        TxtDiasT.Visible = Not TxtDiasT.Visible
        TxtFega.Visible = Not TxtFega.Visible
    End Sub

    Sub llenaDatos()

        Dim DS As New ProductionDataSet
        Dim Poss As Integer = 0
        Dim IvaResidual As Decimal = 0
        NumPagos = GridAmortizaciones.Rows.Count
        For Each rr As DataGridViewRow In GridAmortizaciones.Rows
            Poss += 1
            If Poss = NumPagos - 1 Then
                RentasDEP = rr.Cells("Pagos").Value * NoRentas
            End If
        Next
        Amorin = CDbl(TxtPagoObj.Text)
        MontoFin = CDbl(TxtMonto.Text) / (1 + TasaIva) - Amorin
        RPP = CDbl(TxtRpp.Text) / (1 + TasaIva)
        Ratifica = CDbl(TxtRatifica.Text) / (1 + TasaIva)
        ComisionImp = MontoFin * Comision

        If Amorin > 0 Then
            ComisionImp = CDbl(TxtMonto.Text) * Comision
            Amorin -= ComisionImp + CDbl(TxtRatifica.Text) + CDbl(TxtRpp.Text)
            BuscaPagoInicial(CDbl(TxtMonto.Text), Amorin)
            MontoFin = CDbl(TxtMonto.Text) / (1 + TasaIva) - (Amorin / (1 + TasaIva))
            ComisionImp = (MontoFin * Comision)
        End If
        Amorin = Amorin / (1 + TasaIva)
        'Residual = CDbl(TxtMonto.Text) * TasaResidual
        Residual = CDbl(MontoFin) * TasaResidual
        'Residual = Residual / (1 + TasaIva)


        ValorFact = CDbl(TxtMonto.Text) / (1 + TasaIva)
        IvaFact = ValorFact * TasaIva

        TxtResidualIMP.Text = (Residual).ToString("n2")
        TxtIVaresidual.Text = ((Residual * TasaIva)).ToString("n2")
        TxtResidualT.Text = (Residual + (Residual * TasaIva)).ToString("n2")
        TxtRentaAnti.Text = Amorin.ToString("n2")

        Gastos = (RPP + Ratifica)
        If CmbFira.Text = "SI" Then
            Fondeo = "03"
            Coberturas = "S"
        Else
            Fondeo = "01"
            Coberturas = "N"
        End If
    End Sub

    Private Sub CmbTipoCot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoCot.SelectedIndexChanged
        If CmbTipoCot.Text = "Pago Inicial Objetivo" Then
            TxtPagoObj.Enabled = True
            TxtPagoObj.Text = 0
            'CmbRentasDep.Enabled = False
            Me.CmbRentasDep.Text = 0
        Else
            TxtPagoObj.Enabled = False
            TxtPagoObj.Text = 0
            'CmbRentasDep.Enabled = True
            Me.CmbRentasDep.Text = 0

        End If
    End Sub

    Sub BuscaPagoInicial(objetivo As Double, ByRef PagoInicial As Double)
        Dim CifraValida As Double
        MontoFin = objetivo - Amorin
        ComisionImp = MontoFin * Comision
        PagoInicial = CDbl(TxtPagoObj.Text) - (ComisionImp + CDbl(TxtRatifica.Text) + CDbl(TxtRpp.Text))
        'calculamos nuevos datos
        MontoFin = objetivo - PagoInicial
        ComisionImp = MontoFin * Comision
        CifraValida = PagoInicial + ComisionImp + CDbl(TxtRatifica.Text) + CDbl(TxtRpp.Text)
        If CifraValida < CDbl(TxtPagoObj.Text) Then
            Amorin = PagoInicial + 0.1
            BuscaPagoInicial(objetivo, PagoInicial + 1)
        Else
            Amorin = PagoInicial
        End If
    End Sub
End Class
