<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCotizador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.ComboPlazo = New System.Windows.Forms.ComboBox()
        Me.LIPlazosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New ArrendamientoPuro.ProductionDataSet()
        Me.ComboPeriodo = New System.Windows.Forms.ComboBox()
        Me.LIPeriodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboSeguro = New System.Windows.Forms.ComboBox()
        Me.LI_PlazosTableAdapter = New ArrendamientoPuro.ProductionDataSetTableAdapters.LI_PlazosTableAdapter()
        Me.LI_PeriodosTableAdapter = New ArrendamientoPuro.ProductionDataSetTableAdapters.LI_PeriodosTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Dfechacon = New System.Windows.Forms.DateTimePicker()
        Me.DfechaVenc = New System.Windows.Forms.DateTimePicker()
        Me.Bcalcular = New System.Windows.Forms.Button()
        Me.GridAmortizaciones = New System.Windows.Forms.DataGridView()
        Me.ComboCapital = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTCAP = New System.Windows.Forms.TextBox()
        Me.TxtTint = New System.Windows.Forms.TextBox()
        Me.TxtTpag = New System.Windows.Forms.TextBox()
        Me.TxtTiva = New System.Windows.Forms.TextBox()
        Me.TxtTseg = New System.Windows.Forms.TextBox()
        Me.TxtTtot = New System.Windows.Forms.TextBox()
        Me.BtPrint = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Cotizacion1 = New ArrendamientoPuro.Cotizacion()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New ArrendamientoPuro.ProductionDataSetTableAdapters.ClientesTableAdapter()
        Me.TxtDiasT = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboAnexo = New System.Windows.Forms.ComboBox()
        Me.AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.AnexosTableAdapter = New ArrendamientoPuro.ProductionDataSetTableAdapters.AnexosTableAdapter()
        Me.ButtonCargar = New System.Windows.Forms.Button()
        Me.LbImporte = New System.Windows.Forms.Label()
        Me.txtSimulador = New System.Windows.Forms.Button()
        Me.TxtGracia = New System.Windows.Forms.TextBox()
        Me.TxtResidual = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbRentasDep = New System.Windows.Forms.ComboBox()
        Me.TxtComision = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtPagoObj = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtRatifica = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbFira = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtFega = New System.Windows.Forms.TextBox()
        Me.TxtResidualIMP = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtIVaresidual = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtResidualT = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtRpp = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CmbTipoCot = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtRentaAnti = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtIvaCap = New System.Windows.Forms.TextBox()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoInsoluto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaCapital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaInteres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LIPlazosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIPeriodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAmortizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tasa Anual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Plazo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Periodicidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Seguro de Vida"
        '
        'TxtTasa
        '
        Me.TxtTasa.Location = New System.Drawing.Point(12, 67)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(74, 20)
        Me.TxtTasa.TabIndex = 1
        Me.TxtTasa.Text = "1"
        '
        'ComboPlazo
        '
        Me.ComboPlazo.DataSource = Me.LIPlazosBindingSource
        Me.ComboPlazo.DisplayMember = "Descripcion"
        Me.ComboPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPlazo.FormattingEnabled = True
        Me.ComboPlazo.Location = New System.Drawing.Point(165, 24)
        Me.ComboPlazo.Name = "ComboPlazo"
        Me.ComboPlazo.Size = New System.Drawing.Size(94, 21)
        Me.ComboPlazo.TabIndex = 2
        Me.ComboPlazo.ValueMember = "id"
        '
        'LIPlazosBindingSource
        '
        Me.LIPlazosBindingSource.DataMember = "LI_Plazos"
        Me.LIPlazosBindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboPeriodo
        '
        Me.ComboPeriodo.DataSource = Me.LIPeriodosBindingSource
        Me.ComboPeriodo.DisplayMember = "Descripcion"
        Me.ComboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPeriodo.FormattingEnabled = True
        Me.ComboPeriodo.Location = New System.Drawing.Point(165, 64)
        Me.ComboPeriodo.Name = "ComboPeriodo"
        Me.ComboPeriodo.Size = New System.Drawing.Size(94, 21)
        Me.ComboPeriodo.TabIndex = 3
        Me.ComboPeriodo.ValueMember = "Dias"
        '
        'LIPeriodosBindingSource
        '
        Me.LIPeriodosBindingSource.DataMember = "LI_Periodos"
        Me.LIPeriodosBindingSource.DataSource = Me.ProductionDataSet
        '
        'ComboSeguro
        '
        Me.ComboSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSeguro.FormattingEnabled = True
        Me.ComboSeguro.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboSeguro.Location = New System.Drawing.Point(165, 104)
        Me.ComboSeguro.Name = "ComboSeguro"
        Me.ComboSeguro.Size = New System.Drawing.Size(59, 21)
        Me.ComboSeguro.TabIndex = 4
        '
        'LI_PlazosTableAdapter
        '
        Me.LI_PlazosTableAdapter.ClearBeforeFill = True
        '
        'LI_PeriodosTableAdapter
        '
        Me.LI_PeriodosTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(161, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Valor Facturas"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(165, 144)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(92, 20)
        Me.TxtMonto.TabIndex = 5
        Me.TxtMonto.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(572, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Contrato"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(572, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha 1ra Renta"
        '
        'Dfechacon
        '
        Me.Dfechacon.CustomFormat = ""
        Me.Dfechacon.Location = New System.Drawing.Point(575, 22)
        Me.Dfechacon.Name = "Dfechacon"
        Me.Dfechacon.Size = New System.Drawing.Size(198, 20)
        Me.Dfechacon.TabIndex = 15
        '
        'DfechaVenc
        '
        Me.DfechaVenc.Location = New System.Drawing.Point(575, 61)
        Me.DfechaVenc.Name = "DfechaVenc"
        Me.DfechaVenc.Size = New System.Drawing.Size(200, 20)
        Me.DfechaVenc.TabIndex = 16
        '
        'Bcalcular
        '
        Me.Bcalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcalcular.Location = New System.Drawing.Point(597, 175)
        Me.Bcalcular.Name = "Bcalcular"
        Me.Bcalcular.Size = New System.Drawing.Size(258, 23)
        Me.Bcalcular.TabIndex = 20
        Me.Bcalcular.Text = "Calcular Rentas"
        Me.Bcalcular.UseVisualStyleBackColor = True
        '
        'GridAmortizaciones
        '
        Me.GridAmortizaciones.AllowUserToAddRows = False
        Me.GridAmortizaciones.AllowUserToDeleteRows = False
        Me.GridAmortizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAmortizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pago, Me.FechaVencimiento, Me.Dias, Me.SaldoInsoluto, Me.Capital, Me.Interes, Me.IvaCapital, Me.pagos, Me.IvaInteres, Me.Seguro, Me.Fega, Me.PagoTotal})
        Me.GridAmortizaciones.Location = New System.Drawing.Point(18, 204)
        Me.GridAmortizaciones.Name = "GridAmortizaciones"
        Me.GridAmortizaciones.ReadOnly = True
        Me.GridAmortizaciones.Size = New System.Drawing.Size(977, 403)
        Me.GridAmortizaciones.TabIndex = 16
        Me.GridAmortizaciones.Visible = False
        '
        'ComboCapital
        '
        Me.ComboCapital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCapital.FormattingEnabled = True
        Me.ComboCapital.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboCapital.Location = New System.Drawing.Point(309, 66)
        Me.ComboCapital.Name = "ComboCapital"
        Me.ComboCapital.Size = New System.Drawing.Size(59, 21)
        Me.ComboCapital.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(305, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Periodo de Gracia"
        '
        'TxtTCAP
        '
        Me.TxtTCAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTCAP.Location = New System.Drawing.Point(283, 613)
        Me.TxtTCAP.Name = "TxtTCAP"
        Me.TxtTCAP.ReadOnly = True
        Me.TxtTCAP.Size = New System.Drawing.Size(80, 18)
        Me.TxtTCAP.TabIndex = 19
        Me.TxtTCAP.Text = "0.00"
        Me.TxtTCAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTCAP.Visible = False
        '
        'TxtTint
        '
        Me.TxtTint.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTint.Location = New System.Drawing.Point(365, 613)
        Me.TxtTint.Name = "TxtTint"
        Me.TxtTint.ReadOnly = True
        Me.TxtTint.Size = New System.Drawing.Size(80, 18)
        Me.TxtTint.TabIndex = 20
        Me.TxtTint.Text = "0.00"
        Me.TxtTint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTint.Visible = False
        '
        'TxtTpag
        '
        Me.TxtTpag.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTpag.Location = New System.Drawing.Point(529, 613)
        Me.TxtTpag.Name = "TxtTpag"
        Me.TxtTpag.ReadOnly = True
        Me.TxtTpag.Size = New System.Drawing.Size(80, 18)
        Me.TxtTpag.TabIndex = 21
        Me.TxtTpag.Text = "0.00"
        Me.TxtTpag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTpag.Visible = False
        '
        'TxtTiva
        '
        Me.TxtTiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTiva.Location = New System.Drawing.Point(612, 613)
        Me.TxtTiva.Name = "TxtTiva"
        Me.TxtTiva.ReadOnly = True
        Me.TxtTiva.Size = New System.Drawing.Size(79, 18)
        Me.TxtTiva.TabIndex = 22
        Me.TxtTiva.Text = "0.00"
        Me.TxtTiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTiva.Visible = False
        '
        'TxtTseg
        '
        Me.TxtTseg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTseg.Location = New System.Drawing.Point(695, 613)
        Me.TxtTseg.Name = "TxtTseg"
        Me.TxtTseg.ReadOnly = True
        Me.TxtTseg.Size = New System.Drawing.Size(78, 18)
        Me.TxtTseg.TabIndex = 23
        Me.TxtTseg.Text = "0.00"
        Me.TxtTseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTseg.Visible = False
        '
        'TxtTtot
        '
        Me.TxtTtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTtot.Location = New System.Drawing.Point(869, 613)
        Me.TxtTtot.Name = "TxtTtot"
        Me.TxtTtot.ReadOnly = True
        Me.TxtTtot.Size = New System.Drawing.Size(80, 18)
        Me.TxtTtot.TabIndex = 24
        Me.TxtTtot.Text = "0.00"
        Me.TxtTtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTtot.Visible = False
        '
        'BtPrint
        '
        Me.BtPrint.Enabled = False
        Me.BtPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPrint.Location = New System.Drawing.Point(19, 613)
        Me.BtPrint.Name = "BtPrint"
        Me.BtPrint.Size = New System.Drawing.Size(131, 37)
        Me.BtPrint.TabIndex = 25
        Me.BtPrint.Text = "Imprimir"
        Me.BtPrint.UseVisualStyleBackColor = True
        Me.BtPrint.Visible = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(20, 204)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(975, 403)
        Me.CrystalReportViewer1.TabIndex = 26
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ComboCliente
        '
        Me.ComboCliente.DataSource = Me.ClientesBindingSource
        Me.ComboCliente.DisplayMember = "Nombre"
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(18, 177)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(424, 21)
        Me.ComboCliente.TabIndex = 17
        Me.ComboCliente.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ProductionDataSet
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Cliente "
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TxtDiasT
        '
        Me.TxtDiasT.Enabled = False
        Me.TxtDiasT.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiasT.Location = New System.Drawing.Point(165, 613)
        Me.TxtDiasT.Name = "TxtDiasT"
        Me.TxtDiasT.Size = New System.Drawing.Size(45, 18)
        Me.TxtDiasT.TabIndex = 108
        Me.TxtDiasT.Text = "0"
        Me.TxtDiasT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(164, 632)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox1.TabIndex = 109
        Me.CheckBox1.Text = "Cliente"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboAnexo
        '
        Me.ComboAnexo.DataSource = Me.AnexosBindingSource
        Me.ComboAnexo.DisplayMember = "AnexoX"
        Me.ComboAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAnexo.FormattingEnabled = True
        Me.ComboAnexo.Location = New System.Drawing.Point(871, 24)
        Me.ComboAnexo.Name = "ComboAnexo"
        Me.ComboAnexo.Size = New System.Drawing.Size(126, 21)
        Me.ComboAnexo.TabIndex = 110
        Me.ComboAnexo.ValueMember = "Anexo"
        '
        'AnexosBindingSource
        '
        Me.AnexosBindingSource.DataMember = "Anexos"
        Me.AnexosBindingSource.DataSource = Me.ProductionDataSet
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(868, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 111
        Me.Label13.Text = "Anexos Sin Pago"
        '
        'AnexosTableAdapter
        '
        Me.AnexosTableAdapter.ClearBeforeFill = True
        '
        'ButtonCargar
        '
        Me.ButtonCargar.Enabled = False
        Me.ButtonCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCargar.Location = New System.Drawing.Point(869, 73)
        Me.ButtonCargar.Name = "ButtonCargar"
        Me.ButtonCargar.Size = New System.Drawing.Size(128, 37)
        Me.ButtonCargar.TabIndex = 112
        Me.ButtonCargar.Text = "Cargar Tabla"
        Me.ButtonCargar.UseVisualStyleBackColor = True
        '
        'LbImporte
        '
        Me.LbImporte.AutoSize = True
        Me.LbImporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "Impeq", True))
        Me.LbImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.Location = New System.Drawing.Point(868, 49)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(19, 13)
        Me.LbImporte.TabIndex = 113
        Me.LbImporte.Text = "..."
        '
        'txtSimulador
        '
        Me.txtSimulador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimulador.Location = New System.Drawing.Point(869, 125)
        Me.txtSimulador.Name = "txtSimulador"
        Me.txtSimulador.Size = New System.Drawing.Size(128, 37)
        Me.txtSimulador.TabIndex = 114
        Me.txtSimulador.Text = "Simulador"
        Me.txtSimulador.UseVisualStyleBackColor = True
        '
        'TxtGracia
        '
        Me.TxtGracia.Location = New System.Drawing.Point(374, 66)
        Me.TxtGracia.Name = "TxtGracia"
        Me.TxtGracia.Size = New System.Drawing.Size(26, 20)
        Me.TxtGracia.TabIndex = 8
        Me.TxtGracia.Text = "1"
        '
        'TxtResidual
        '
        Me.TxtResidual.Location = New System.Drawing.Point(310, 24)
        Me.TxtResidual.Name = "TxtResidual"
        Me.TxtResidual.Size = New System.Drawing.Size(59, 20)
        Me.TxtResidual.TabIndex = 6
        Me.TxtResidual.Text = "20"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(307, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Valor Residual"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(305, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 13)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Rentas en Depósito"
        '
        'CmbRentasDep
        '
        Me.CmbRentasDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRentasDep.FormattingEnabled = True
        Me.CmbRentasDep.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CmbRentasDep.Location = New System.Drawing.Point(308, 104)
        Me.CmbRentasDep.Name = "CmbRentasDep"
        Me.CmbRentasDep.Size = New System.Drawing.Size(59, 21)
        Me.CmbRentasDep.TabIndex = 9
        '
        'TxtComision
        '
        Me.TxtComision.Location = New System.Drawing.Point(310, 144)
        Me.TxtComision.Name = "TxtComision"
        Me.TxtComision.Size = New System.Drawing.Size(59, 20)
        Me.TxtComision.TabIndex = 10
        Me.TxtComision.Text = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(307, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Comisión"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(980, 613)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 123
        Me.Label14.Text = "."
        '
        'TxtPagoObj
        '
        Me.TxtPagoObj.Location = New System.Drawing.Point(447, 24)
        Me.TxtPagoObj.Name = "TxtPagoObj"
        Me.TxtPagoObj.Size = New System.Drawing.Size(92, 20)
        Me.TxtPagoObj.TabIndex = 11
        Me.TxtPagoObj.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(443, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 125
        Me.Label15.Text = "Pago Inicial Obj."
        '
        'TxtRatifica
        '
        Me.TxtRatifica.Location = New System.Drawing.Point(447, 64)
        Me.TxtRatifica.Name = "TxtRatifica"
        Me.TxtRatifica.Size = New System.Drawing.Size(59, 20)
        Me.TxtRatifica.TabIndex = 12
        Me.TxtRatifica.Text = "2,000.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(444, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 127
        Me.Label16.Text = "Gastos Legales"
        '
        'CmbFira
        '
        Me.CmbFira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFira.FormattingEnabled = True
        Me.CmbFira.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbFira.Location = New System.Drawing.Point(447, 143)
        Me.CmbFira.Name = "CmbFira"
        Me.CmbFira.Size = New System.Drawing.Size(59, 21)
        Me.CmbFira.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(446, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 13)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "Recursos FIRA"
        '
        'TxtFega
        '
        Me.TxtFega.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFega.Location = New System.Drawing.Point(777, 613)
        Me.TxtFega.Name = "TxtFega"
        Me.TxtFega.ReadOnly = True
        Me.TxtFega.Size = New System.Drawing.Size(89, 18)
        Me.TxtFega.TabIndex = 130
        Me.TxtFega.Text = "0.00"
        Me.TxtFega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtFega.Visible = False
        '
        'TxtResidualIMP
        '
        Me.TxtResidualIMP.Location = New System.Drawing.Point(575, 104)
        Me.TxtResidualIMP.Name = "TxtResidualIMP"
        Me.TxtResidualIMP.ReadOnly = True
        Me.TxtResidualIMP.Size = New System.Drawing.Size(99, 20)
        Me.TxtResidualIMP.TabIndex = 132
        Me.TxtResidualIMP.Text = "0.00"
        Me.TxtResidualIMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(572, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Residual"
        '
        'TxtIVaresidual
        '
        Me.TxtIVaresidual.Location = New System.Drawing.Point(680, 104)
        Me.TxtIVaresidual.Name = "TxtIVaresidual"
        Me.TxtIVaresidual.ReadOnly = True
        Me.TxtIVaresidual.Size = New System.Drawing.Size(99, 20)
        Me.TxtIVaresidual.TabIndex = 134
        Me.TxtIVaresidual.Text = "0.00"
        Me.TxtIVaresidual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(677, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "Iva Residual"
        '
        'TxtResidualT
        '
        Me.TxtResidualT.Location = New System.Drawing.Point(575, 145)
        Me.TxtResidualT.Name = "TxtResidualT"
        Me.TxtResidualT.ReadOnly = True
        Me.TxtResidualT.Size = New System.Drawing.Size(99, 20)
        Me.TxtResidualT.TabIndex = 136
        Me.TxtResidualT.Text = "0.00"
        Me.TxtResidualT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(572, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 13)
        Me.Label20.TabIndex = 137
        Me.Label20.Text = "Residual Total"
        '
        'TxtRpp
        '
        Me.TxtRpp.Location = New System.Drawing.Point(447, 104)
        Me.TxtRpp.Name = "TxtRpp"
        Me.TxtRpp.Size = New System.Drawing.Size(59, 20)
        Me.TxtRpp.TabIndex = 13
        Me.TxtRpp.Text = "0.00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(444, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 13)
        Me.Label21.TabIndex = 139
        Me.Label21.Text = "RPP"
        '
        'CmbTipoCot
        '
        Me.CmbTipoCot.DisplayMember = "id"
        Me.CmbTipoCot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoCot.FormattingEnabled = True
        Me.CmbTipoCot.Items.AddRange(New Object() {"Pago Inicial Objetivo", "Rentas Anticipadas"})
        Me.CmbTipoCot.Location = New System.Drawing.Point(12, 25)
        Me.CmbTipoCot.Name = "CmbTipoCot"
        Me.CmbTipoCot.Size = New System.Drawing.Size(138, 21)
        Me.CmbTipoCot.TabIndex = 0
        Me.CmbTipoCot.ValueMember = "id"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 13)
        Me.Label22.TabIndex = 141
        Me.Label22.Text = "Tipo de Cotización"
        '
        'TxtRentaAnti
        '
        Me.TxtRentaAnti.Location = New System.Drawing.Point(687, 145)
        Me.TxtRentaAnti.Name = "TxtRentaAnti"
        Me.TxtRentaAnti.ReadOnly = True
        Me.TxtRentaAnti.Size = New System.Drawing.Size(92, 20)
        Me.TxtRentaAnti.TabIndex = 142
        Me.TxtRentaAnti.Text = "0.00"
        Me.TxtRentaAnti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(683, 129)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 13)
        Me.Label23.TabIndex = 143
        Me.Label23.Text = "Renta Anticipada"
        '
        'TxtIvaCap
        '
        Me.TxtIvaCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIvaCap.Location = New System.Drawing.Point(448, 613)
        Me.TxtIvaCap.Name = "TxtIvaCap"
        Me.TxtIvaCap.ReadOnly = True
        Me.TxtIvaCap.Size = New System.Drawing.Size(78, 18)
        Me.TxtIvaCap.TabIndex = 144
        Me.TxtIvaCap.Text = "0.00"
        Me.TxtIvaCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIvaCap.Visible = False
        '
        'Pago
        '
        Me.Pago.HeaderText = "No Pago"
        Me.Pago.Name = "Pago"
        Me.Pago.ReadOnly = True
        Me.Pago.Width = 40
        '
        'FechaVencimiento
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaVencimiento.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        Me.FechaVencimiento.Width = 70
        '
        'Dias
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Dias.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dias.HeaderText = "Días"
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        Me.Dias.Width = 40
        '
        'SaldoInsoluto
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SaldoInsoluto.DefaultCellStyle = DataGridViewCellStyle3
        Me.SaldoInsoluto.HeaderText = "Saldo Insoluto"
        Me.SaldoInsoluto.Name = "SaldoInsoluto"
        Me.SaldoInsoluto.ReadOnly = True
        Me.SaldoInsoluto.Width = 80
        '
        'Capital
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.Capital.DefaultCellStyle = DataGridViewCellStyle4
        Me.Capital.HeaderText = "Capital"
        Me.Capital.Name = "Capital"
        Me.Capital.ReadOnly = True
        Me.Capital.Width = 80
        '
        'Interes
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.Interes.DefaultCellStyle = DataGridViewCellStyle5
        Me.Interes.HeaderText = "Interes"
        Me.Interes.Name = "Interes"
        Me.Interes.ReadOnly = True
        Me.Interes.Width = 80
        '
        'IvaCapital
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n2"
        Me.IvaCapital.DefaultCellStyle = DataGridViewCellStyle6
        Me.IvaCapital.HeaderText = "IvaCapital"
        Me.IvaCapital.Name = "IvaCapital"
        Me.IvaCapital.ReadOnly = True
        Me.IvaCapital.Width = 80
        '
        'pagos
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.pagos.DefaultCellStyle = DataGridViewCellStyle7
        Me.pagos.HeaderText = "Pago"
        Me.pagos.Name = "pagos"
        Me.pagos.ReadOnly = True
        Me.pagos.Width = 80
        '
        'IvaInteres
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.IvaInteres.DefaultCellStyle = DataGridViewCellStyle8
        Me.IvaInteres.HeaderText = "Iva Renta"
        Me.IvaInteres.Name = "IvaInteres"
        Me.IvaInteres.ReadOnly = True
        Me.IvaInteres.Width = 80
        '
        'Seguro
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.Seguro.DefaultCellStyle = DataGridViewCellStyle9
        Me.Seguro.HeaderText = "Seguro de Vida"
        Me.Seguro.Name = "Seguro"
        Me.Seguro.ReadOnly = True
        Me.Seguro.Width = 80
        '
        'Fega
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Fega.DefaultCellStyle = DataGridViewCellStyle10
        Me.Fega.HeaderText = "Fega"
        Me.Fega.Name = "Fega"
        Me.Fega.ReadOnly = True
        '
        'PagoTotal
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.PagoTotal.DefaultCellStyle = DataGridViewCellStyle11
        Me.PagoTotal.HeaderText = "Pago Total"
        Me.PagoTotal.Name = "PagoTotal"
        Me.PagoTotal.ReadOnly = True
        Me.PagoTotal.Width = 80
        '
        'FrmCotizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 655)
        Me.Controls.Add(Me.TxtIvaCap)
        Me.Controls.Add(Me.TxtRentaAnti)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.CmbTipoCot)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TxtRpp)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TxtResidualT)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtIVaresidual)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxtResidualIMP)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtFega)
        Me.Controls.Add(Me.CmbFira)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtRatifica)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtPagoObj)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtComision)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbRentasDep)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtResidual)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtGracia)
        Me.Controls.Add(Me.txtSimulador)
        Me.Controls.Add(Me.LbImporte)
        Me.Controls.Add(Me.ButtonCargar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboAnexo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtDiasT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboCliente)
        Me.Controls.Add(Me.BtPrint)
        Me.Controls.Add(Me.TxtTtot)
        Me.Controls.Add(Me.TxtTseg)
        Me.Controls.Add(Me.TxtTiva)
        Me.Controls.Add(Me.TxtTpag)
        Me.Controls.Add(Me.TxtTint)
        Me.Controls.Add(Me.TxtTCAP)
        Me.Controls.Add(Me.ComboCapital)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Bcalcular)
        Me.Controls.Add(Me.DfechaVenc)
        Me.Controls.Add(Me.Dfechacon)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboSeguro)
        Me.Controls.Add(Me.ComboPeriodo)
        Me.Controls.Add(Me.ComboPlazo)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridAmortizaciones)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmCotizador"
        Me.Text = "Arrendamiento Puro "
        CType(Me.LIPlazosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIPeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAmortizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTasa As System.Windows.Forms.TextBox
    Friend WithEvents ComboPlazo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSeguro As System.Windows.Forms.ComboBox
    Friend WithEvents ProductionDataSet As ArrendamientoPuro.ProductionDataSet
    Friend WithEvents LIPlazosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LI_PlazosTableAdapter As ArrendamientoPuro.ProductionDataSetTableAdapters.LI_PlazosTableAdapter
    Friend WithEvents LIPeriodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LI_PeriodosTableAdapter As ArrendamientoPuro.ProductionDataSetTableAdapters.LI_PeriodosTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Dfechacon As System.Windows.Forms.DateTimePicker
    Friend WithEvents DfechaVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bcalcular As System.Windows.Forms.Button
    Friend WithEvents GridAmortizaciones As System.Windows.Forms.DataGridView
    Friend WithEvents ComboCapital As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTCAP As System.Windows.Forms.TextBox
    Friend WithEvents TxtTint As System.Windows.Forms.TextBox
    Friend WithEvents TxtTpag As System.Windows.Forms.TextBox
    Friend WithEvents TxtTiva As System.Windows.Forms.TextBox
    Friend WithEvents TxtTseg As System.Windows.Forms.TextBox
    Friend WithEvents TxtTtot As System.Windows.Forms.TextBox
    Friend WithEvents BtPrint As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Cotizacion1 As ArrendamientoPuro.Cotizacion
    Friend WithEvents ComboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ArrendamientoPuro.ProductionDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TxtDiasT As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboAnexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents AnexosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexosTableAdapter As ArrendamientoPuro.ProductionDataSetTableAdapters.AnexosTableAdapter
    Friend WithEvents ButtonCargar As System.Windows.Forms.Button
    Friend WithEvents LbImporte As System.Windows.Forms.Label
    Friend WithEvents txtSimulador As System.Windows.Forms.Button
    Friend WithEvents TxtGracia As System.Windows.Forms.TextBox
    Friend WithEvents TxtResidual As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbRentasDep As ComboBox
    Friend WithEvents TxtComision As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtPagoObj As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtRatifica As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CmbFira As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtFega As TextBox
    Friend WithEvents TxtResidualIMP As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtIVaresidual As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtResidualT As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtRpp As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents CmbTipoCot As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtRentaAnti As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtIvaCap As TextBox
    Friend WithEvents Pago As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Dias As DataGridViewTextBoxColumn
    Friend WithEvents SaldoInsoluto As DataGridViewTextBoxColumn
    Friend WithEvents Capital As DataGridViewTextBoxColumn
    Friend WithEvents Interes As DataGridViewTextBoxColumn
    Friend WithEvents IvaCapital As DataGridViewTextBoxColumn
    Friend WithEvents pagos As DataGridViewTextBoxColumn
    Friend WithEvents IvaInteres As DataGridViewTextBoxColumn
    Friend WithEvents Seguro As DataGridViewTextBoxColumn
    Friend WithEvents Fega As DataGridViewTextBoxColumn
    Friend WithEvents PagoTotal As DataGridViewTextBoxColumn
End Class
