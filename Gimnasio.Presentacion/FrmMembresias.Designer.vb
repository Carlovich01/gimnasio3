﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMembresias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        panelListado = New Panel()
        pbReiniciar = New PictureBox()
        btnActualizar = New Button()
        btnEliminar = New Button()
        BtnPagar = New Button()
        cbOpcionBuscar = New ComboBox()
        lblTotal = New Label()
        dgvListado = New DataGridView()
        tbBuscar = New TextBox()
        btnInsertar = New Button()
        panelDatosIngreso = New Panel()
        pbReiniciarPlan = New PictureBox()
        pbReiniciarMiembro = New PictureBox()
        tbIDmiembro = New TextBox()
        tbIDmembresia = New TextBox()
        lblPlan = New Label()
        lblDatosIngreso = New Label()
        lblMiembro = New Label()
        dgvPlan = New DataGridView()
        tbBuscarPlan = New TextBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        cbBuscarOpcionPlan = New ComboBox()
        dgvMiembro = New DataGridView()
        tbBuscarMiembro = New TextBox()
        cbOpcionBuscarMiembro = New ComboBox()
        panelPagoIngreso = New Panel()
        tbIDpago = New TextBox()
        lblPagoIngreso = New Label()
        btnCancelarPago = New Button()
        btnGuardarPago = New Button()
        cbMetodo = New ComboBox()
        tbNotas = New TextBox()
        tbComprobante = New TextBox()
        tbMonto = New TextBox()
        lblNotas = New Label()
        lblComprobante = New Label()
        lblMetodo = New Label()
        lblMonto = New Label()
        panelListado.SuspendLayout()
        CType(pbReiniciar, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvListado, ComponentModel.ISupportInitialize).BeginInit()
        panelDatosIngreso.SuspendLayout()
        CType(pbReiniciarPlan, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbReiniciarMiembro, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPlan, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvMiembro, ComponentModel.ISupportInitialize).BeginInit()
        panelPagoIngreso.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelListado
        ' 
        panelListado.Controls.Add(pbReiniciar)
        panelListado.Controls.Add(btnActualizar)
        panelListado.Controls.Add(btnEliminar)
        panelListado.Controls.Add(BtnPagar)
        panelListado.Controls.Add(cbOpcionBuscar)
        panelListado.Controls.Add(lblTotal)
        panelListado.Controls.Add(dgvListado)
        panelListado.Controls.Add(tbBuscar)
        panelListado.Controls.Add(btnInsertar)
        panelListado.Dock = DockStyle.Fill
        panelListado.Location = New Point(0, 0)
        panelListado.Name = "panelListado"
        panelListado.Size = New Size(1008, 729)
        panelListado.TabIndex = 0
        ' 
        ' pbReiniciar
        ' 
        pbReiniciar.BackColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        pbReiniciar.Cursor = Cursors.Hand
        pbReiniciar.Image = My.Resources.Resources.reiniciar
        pbReiniciar.Location = New Point(963, 11)
        pbReiniciar.Name = "pbReiniciar"
        pbReiniciar.Size = New Size(34, 30)
        pbReiniciar.SizeMode = PictureBoxSizeMode.Zoom
        pbReiniciar.TabIndex = 43
        pbReiniciar.TabStop = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnActualizar.Cursor = Cursors.Hand
        btnActualizar.Font = New Font("Segoe UI", 12.0F)
        btnActualizar.Location = New Point(242, 685)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(87, 31)
        btnActualizar.TabIndex = 42
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.Font = New Font("Segoe UI", 12.0F)
        btnEliminar.Location = New Point(352, 685)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(90, 30)
        btnEliminar.TabIndex = 41
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnPagar
        ' 
        BtnPagar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnPagar.Cursor = Cursors.Hand
        BtnPagar.Font = New Font("Segoe UI", 12.0F)
        BtnPagar.Location = New Point(125, 684)
        BtnPagar.Name = "BtnPagar"
        BtnPagar.Size = New Size(90, 31)
        BtnPagar.TabIndex = 40
        BtnPagar.Text = "Pagar"
        BtnPagar.UseVisualStyleBackColor = True
        ' 
        ' cbOpcionBuscar
        ' 
        cbOpcionBuscar.Cursor = Cursors.Hand
        cbOpcionBuscar.DropDownStyle = ComboBoxStyle.DropDownList
        cbOpcionBuscar.Font = New Font("Segoe UI", 12.0F)
        cbOpcionBuscar.FormattingEnabled = True
        cbOpcionBuscar.Items.AddRange(New Object() {"Buscar por DNI", "Buscar por Plan ", "Membresias Activas", "Membresias Inactivas"})
        cbOpcionBuscar.Location = New Point(720, 12)
        cbOpcionBuscar.Name = "cbOpcionBuscar"
        cbOpcionBuscar.Size = New Size(233, 29)
        cbOpcionBuscar.TabIndex = 39
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.FromArgb(CByte(5), CByte(18), CByte(26))
        lblTotal.Font = New Font("Segoe UI", 12.0F)
        lblTotal.ForeColor = Color.White
        lblTotal.Location = New Point(811, 686)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(42, 21)
        lblTotal.TabIndex = 37
        lblTotal.Text = "Total"
        ' 
        ' dgvListado
        ' 
        dgvListado.AllowUserToAddRows = False
        dgvListado.AllowUserToDeleteRows = False
        dgvListado.AllowUserToOrderColumns = True
        dgvListado.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListado.BackgroundColor = Color.FromArgb(CByte(85), CByte(96), CByte(105))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListado.GridColor = Color.FromArgb(CByte(5), CByte(18), CByte(26))
        dgvListado.Location = New Point(11, 56)
        dgvListado.MultiSelect = False
        dgvListado.Name = "dgvListado"
        dgvListado.ReadOnly = True
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListado.Size = New Size(986, 618)
        dgvListado.TabIndex = 35
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Font = New Font("Segoe UI", 12.0F)
        tbBuscar.Location = New Point(11, 12)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(683, 29)
        tbBuscar.TabIndex = 36
        ' 
        ' btnInsertar
        ' 
        btnInsertar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnInsertar.Cursor = Cursors.Hand
        btnInsertar.Font = New Font("Segoe UI", 12.0F)
        btnInsertar.Location = New Point(11, 685)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New Size(92, 28)
        btnInsertar.TabIndex = 38
        btnInsertar.Text = "Insertar"
        btnInsertar.UseVisualStyleBackColor = True
        ' 
        ' panelDatosIngreso
        ' 
        panelDatosIngreso.Controls.Add(pbReiniciarPlan)
        panelDatosIngreso.Controls.Add(pbReiniciarMiembro)
        panelDatosIngreso.Controls.Add(tbIDmiembro)
        panelDatosIngreso.Controls.Add(tbIDmembresia)
        panelDatosIngreso.Controls.Add(lblPlan)
        panelDatosIngreso.Controls.Add(lblDatosIngreso)
        panelDatosIngreso.Controls.Add(lblMiembro)
        panelDatosIngreso.Controls.Add(dgvPlan)
        panelDatosIngreso.Controls.Add(tbBuscarPlan)
        panelDatosIngreso.Controls.Add(btnGuardar)
        panelDatosIngreso.Controls.Add(btnCancelar)
        panelDatosIngreso.Controls.Add(cbBuscarOpcionPlan)
        panelDatosIngreso.Controls.Add(dgvMiembro)
        panelDatosIngreso.Controls.Add(tbBuscarMiembro)
        panelDatosIngreso.Controls.Add(cbOpcionBuscarMiembro)
        panelDatosIngreso.Location = New Point(12, 83)
        panelDatosIngreso.Name = "panelDatosIngreso"
        panelDatosIngreso.Size = New Size(968, 551)
        panelDatosIngreso.TabIndex = 43
        panelDatosIngreso.Visible = False
        ' 
        ' pbReiniciarPlan
        ' 
        pbReiniciarPlan.BackColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        pbReiniciarPlan.Cursor = Cursors.Hand
        pbReiniciarPlan.Image = My.Resources.Resources.reiniciar
        pbReiniciarPlan.Location = New Point(907, 249)
        pbReiniciarPlan.Name = "pbReiniciarPlan"
        pbReiniciarPlan.Size = New Size(34, 30)
        pbReiniciarPlan.SizeMode = PictureBoxSizeMode.Zoom
        pbReiniciarPlan.TabIndex = 63
        pbReiniciarPlan.TabStop = False
        ' 
        ' pbReiniciarMiembro
        ' 
        pbReiniciarMiembro.BackColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        pbReiniciarMiembro.Cursor = Cursors.Hand
        pbReiniciarMiembro.Image = My.Resources.Resources.reiniciar
        pbReiniciarMiembro.Location = New Point(907, 56)
        pbReiniciarMiembro.Name = "pbReiniciarMiembro"
        pbReiniciarMiembro.Size = New Size(34, 30)
        pbReiniciarMiembro.SizeMode = PictureBoxSizeMode.Zoom
        pbReiniciarMiembro.TabIndex = 62
        pbReiniciarMiembro.TabStop = False
        ' 
        ' tbIDmiembro
        ' 
        tbIDmiembro.AccessibleRole = AccessibleRole.SplitButton
        tbIDmiembro.Location = New Point(609, 11)
        tbIDmiembro.Name = "tbIDmiembro"
        tbIDmiembro.Size = New Size(100, 23)
        tbIDmiembro.TabIndex = 61
        tbIDmiembro.Visible = False
        ' 
        ' tbIDmembresia
        ' 
        tbIDmembresia.AccessibleRole = AccessibleRole.SplitButton
        tbIDmembresia.Location = New Point(774, 13)
        tbIDmembresia.Name = "tbIDmembresia"
        tbIDmembresia.Size = New Size(100, 23)
        tbIDmembresia.TabIndex = 57
        tbIDmembresia.Visible = False
        ' 
        ' lblPlan
        ' 
        lblPlan.AutoSize = True
        lblPlan.Font = New Font("Segoe UI", 12.0F)
        lblPlan.ForeColor = Color.White
        lblPlan.Location = New Point(13, 249)
        lblPlan.Name = "lblPlan"
        lblPlan.Size = New Size(60, 21)
        lblPlan.TabIndex = 53
        lblPlan.Text = "Plan(*):"
        ' 
        ' lblDatosIngreso
        ' 
        lblDatosIngreso.AutoSize = True
        lblDatosIngreso.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDatosIngreso.ForeColor = Color.White
        lblDatosIngreso.Location = New Point(13, 13)
        lblDatosIngreso.Name = "lblDatosIngreso"
        lblDatosIngreso.Size = New Size(83, 21)
        lblDatosIngreso.TabIndex = 52
        lblDatosIngreso.Text = "Seleccione"
        ' 
        ' lblMiembro
        ' 
        lblMiembro.AutoSize = True
        lblMiembro.Font = New Font("Segoe UI", 12.0F)
        lblMiembro.ForeColor = Color.White
        lblMiembro.Location = New Point(13, 60)
        lblMiembro.Name = "lblMiembro"
        lblMiembro.Size = New Size(94, 21)
        lblMiembro.TabIndex = 48
        lblMiembro.Text = "Miembro(*):"
        ' 
        ' dgvPlan
        ' 
        dgvPlan.AllowUserToAddRows = False
        dgvPlan.AllowUserToDeleteRows = False
        dgvPlan.AllowUserToOrderColumns = True
        dgvPlan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPlan.BackgroundColor = Color.FromArgb(CByte(85), CByte(96), CByte(105))
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvPlan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPlan.GridColor = Color.FromArgb(CByte(5), CByte(18), CByte(26))
        dgvPlan.Location = New Point(13, 292)
        dgvPlan.MultiSelect = False
        dgvPlan.Name = "dgvPlan"
        dgvPlan.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvPlan.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPlan.Size = New Size(928, 178)
        dgvPlan.TabIndex = 56
        ' 
        ' tbBuscarPlan
        ' 
        tbBuscarPlan.Font = New Font("Segoe UI", 12.0F)
        tbBuscarPlan.Location = New Point(113, 249)
        tbBuscarPlan.Name = "tbBuscarPlan"
        tbBuscarPlan.Size = New Size(596, 29)
        tbBuscarPlan.TabIndex = 57
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnGuardar.BackColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        btnGuardar.FlatAppearance.MouseDownBackColor = Color.White
        btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 12.0F)
        btnGuardar.Location = New Point(13, 488)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(83, 31)
        btnGuardar.TabIndex = 54
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCancelar.BackColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        btnCancelar.Cursor = Cursors.Hand
        btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatAppearance.MouseDownBackColor = Color.White
        btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Segoe UI", 12.0F)
        btnCancelar.Location = New Point(162, 488)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(82, 31)
        btnCancelar.TabIndex = 55
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' cbBuscarOpcionPlan
        ' 
        cbBuscarOpcionPlan.Cursor = Cursors.Hand
        cbBuscarOpcionPlan.DropDownStyle = ComboBoxStyle.DropDownList
        cbBuscarOpcionPlan.Font = New Font("Segoe UI", 12.0F)
        cbBuscarOpcionPlan.FormattingEnabled = True
        cbBuscarOpcionPlan.Items.AddRange(New Object() {"Buscar por nombre"})
        cbBuscarOpcionPlan.Location = New Point(722, 249)
        cbBuscarOpcionPlan.Name = "cbBuscarOpcionPlan"
        cbBuscarOpcionPlan.Size = New Size(172, 29)
        cbBuscarOpcionPlan.TabIndex = 58
        ' 
        ' dgvMiembro
        ' 
        dgvMiembro.AllowUserToAddRows = False
        dgvMiembro.AllowUserToDeleteRows = False
        dgvMiembro.AllowUserToOrderColumns = True
        dgvMiembro.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMiembro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMiembro.BackgroundColor = Color.FromArgb(CByte(85), CByte(96), CByte(105))
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvMiembro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvMiembro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMiembro.GridColor = Color.FromArgb(CByte(5), CByte(18), CByte(26))
        dgvMiembro.Location = New Point(13, 100)
        dgvMiembro.MultiSelect = False
        dgvMiembro.Name = "dgvMiembro"
        dgvMiembro.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvMiembro.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvMiembro.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMiembro.Size = New Size(928, 129)
        dgvMiembro.TabIndex = 49
        ' 
        ' tbBuscarMiembro
        ' 
        tbBuscarMiembro.Font = New Font("Segoe UI", 12.0F)
        tbBuscarMiembro.Location = New Point(113, 57)
        tbBuscarMiembro.Name = "tbBuscarMiembro"
        tbBuscarMiembro.Size = New Size(596, 29)
        tbBuscarMiembro.TabIndex = 50
        ' 
        ' cbOpcionBuscarMiembro
        ' 
        cbOpcionBuscarMiembro.Cursor = Cursors.Hand
        cbOpcionBuscarMiembro.DropDownStyle = ComboBoxStyle.DropDownList
        cbOpcionBuscarMiembro.Font = New Font("Segoe UI", 12.0F)
        cbOpcionBuscarMiembro.FormattingEnabled = True
        cbOpcionBuscarMiembro.Items.AddRange(New Object() {"Buscar por nombre", "Buscar por DNI"})
        cbOpcionBuscarMiembro.Location = New Point(722, 57)
        cbOpcionBuscarMiembro.Name = "cbOpcionBuscarMiembro"
        cbOpcionBuscarMiembro.Size = New Size(172, 29)
        cbOpcionBuscarMiembro.TabIndex = 51
        ' 
        ' panelPagoIngreso
        ' 
        panelPagoIngreso.BackColor = Color.FromArgb(CByte(5), CByte(18), CByte(26))
        panelPagoIngreso.Controls.Add(tbIDpago)
        panelPagoIngreso.Controls.Add(lblPagoIngreso)
        panelPagoIngreso.Controls.Add(btnCancelarPago)
        panelPagoIngreso.Controls.Add(btnGuardarPago)
        panelPagoIngreso.Controls.Add(cbMetodo)
        panelPagoIngreso.Controls.Add(tbNotas)
        panelPagoIngreso.Controls.Add(tbComprobante)
        panelPagoIngreso.Controls.Add(tbMonto)
        panelPagoIngreso.Controls.Add(lblNotas)
        panelPagoIngreso.Controls.Add(lblComprobante)
        panelPagoIngreso.Controls.Add(lblMetodo)
        panelPagoIngreso.Controls.Add(lblMonto)
        panelPagoIngreso.ForeColor = Color.White
        panelPagoIngreso.Location = New Point(49, 26)
        panelPagoIngreso.Name = "panelPagoIngreso"
        panelPagoIngreso.Size = New Size(607, 504)
        panelPagoIngreso.TabIndex = 60
        panelPagoIngreso.Visible = False
        ' 
        ' tbIDpago
        ' 
        tbIDpago.AccessibleRole = AccessibleRole.SplitButton
        tbIDpago.Location = New Point(443, 69)
        tbIDpago.Name = "tbIDpago"
        tbIDpago.Size = New Size(100, 23)
        tbIDpago.TabIndex = 58
        tbIDpago.Visible = False
        ' 
        ' lblPagoIngreso
        ' 
        lblPagoIngreso.AutoSize = True
        lblPagoIngreso.Font = New Font("Segoe UI", 12.0F)
        lblPagoIngreso.ForeColor = Color.White
        lblPagoIngreso.Location = New Point(209, 71)
        lblPagoIngreso.Name = "lblPagoIngreso"
        lblPagoIngreso.Size = New Size(191, 21)
        lblPagoIngreso.TabIndex = 21
        lblPagoIngreso.Text = "Ingrese los datos del pago"
        ' 
        ' btnCancelarPago
        ' 
        btnCancelarPago.BackColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        btnCancelarPago.Cursor = Cursors.Hand
        btnCancelarPago.FlatStyle = FlatStyle.Flat
        btnCancelarPago.Font = New Font("Segoe UI", 12.0F)
        btnCancelarPago.ForeColor = Color.Black
        btnCancelarPago.Location = New Point(364, 399)
        btnCancelarPago.Name = "btnCancelarPago"
        btnCancelarPago.Size = New Size(85, 34)
        btnCancelarPago.TabIndex = 20
        btnCancelarPago.Text = "Cancelar"
        btnCancelarPago.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarPago
        ' 
        btnGuardarPago.BackColor = Color.FromArgb(CByte(123), CByte(179), CByte(75))
        btnGuardarPago.Cursor = Cursors.Hand
        btnGuardarPago.FlatStyle = FlatStyle.Flat
        btnGuardarPago.Font = New Font("Segoe UI", 12.0F)
        btnGuardarPago.ForeColor = Color.Black
        btnGuardarPago.Location = New Point(200, 399)
        btnGuardarPago.Name = "btnGuardarPago"
        btnGuardarPago.Size = New Size(83, 34)
        btnGuardarPago.TabIndex = 19
        btnGuardarPago.Text = "Guardar"
        btnGuardarPago.UseVisualStyleBackColor = False
        ' 
        ' cbMetodo
        ' 
        cbMetodo.Cursor = Cursors.Hand
        cbMetodo.DropDownStyle = ComboBoxStyle.DropDownList
        cbMetodo.Font = New Font("Segoe UI", 12.0F)
        cbMetodo.ForeColor = SystemColors.ControlText
        cbMetodo.FormattingEnabled = True
        cbMetodo.Items.AddRange(New Object() {"Efectivo", "Tarjeta Débito", "Tarjeta Crédito", "Transferencia Bancaria", "Mercado Pago", "Otro"})
        cbMetodo.Location = New Point(200, 202)
        cbMetodo.Name = "cbMetodo"
        cbMetodo.Size = New Size(343, 29)
        cbMetodo.TabIndex = 18
        ' 
        ' tbNotas
        ' 
        tbNotas.Font = New Font("Segoe UI", 12.0F)
        tbNotas.ForeColor = SystemColors.ControlText
        tbNotas.Location = New Point(200, 307)
        tbNotas.Name = "tbNotas"
        tbNotas.Size = New Size(343, 29)
        tbNotas.TabIndex = 17
        ' 
        ' tbComprobante
        ' 
        tbComprobante.Font = New Font("Segoe UI", 12.0F)
        tbComprobante.ForeColor = SystemColors.ControlText
        tbComprobante.Location = New Point(200, 251)
        tbComprobante.Name = "tbComprobante"
        tbComprobante.Size = New Size(343, 29)
        tbComprobante.TabIndex = 16
        ' 
        ' tbMonto
        ' 
        tbMonto.Font = New Font("Segoe UI", 12.0F)
        tbMonto.ForeColor = SystemColors.ControlText
        tbMonto.Location = New Point(200, 145)
        tbMonto.Name = "tbMonto"
        tbMonto.ReadOnly = True
        tbMonto.Size = New Size(343, 29)
        tbMonto.TabIndex = 15
        ' 
        ' lblNotas
        ' 
        lblNotas.AutoSize = True
        lblNotas.Font = New Font("Segoe UI", 12.0F)
        lblNotas.ForeColor = Color.White
        lblNotas.Location = New Point(118, 310)
        lblNotas.Name = "lblNotas"
        lblNotas.Size = New Size(51, 21)
        lblNotas.TabIndex = 14
        lblNotas.Text = "Notas"
        ' 
        ' lblComprobante
        ' 
        lblComprobante.AutoSize = True
        lblComprobante.Font = New Font("Segoe UI", 12.0F)
        lblComprobante.ForeColor = Color.White
        lblComprobante.Location = New Point(64, 259)
        lblComprobante.Name = "lblComprobante"
        lblComprobante.Size = New Size(128, 21)
        lblComprobante.TabIndex = 13
        lblComprobante.Text = "N° Comprobante"
        ' 
        ' lblMetodo
        ' 
        lblMetodo.AutoSize = True
        lblMetodo.Font = New Font("Segoe UI", 12.0F)
        lblMetodo.ForeColor = Color.White
        lblMetodo.Location = New Point(107, 202)
        lblMetodo.Name = "lblMetodo"
        lblMetodo.Size = New Size(85, 21)
        lblMetodo.TabIndex = 12
        lblMetodo.Text = "Metodo (*)"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Font = New Font("Segoe UI", 12.0F)
        lblMonto.ForeColor = Color.White
        lblMonto.Location = New Point(115, 145)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(77, 21)
        lblMonto.TabIndex = 11
        lblMonto.Text = "Monto (*)"
        ' 
        ' FrmMembresias
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(5), CByte(18), CByte(26))
        ClientSize = New Size(1008, 729)
        Controls.Add(panelPagoIngreso)
        Controls.Add(panelDatosIngreso)
        Controls.Add(panelListado)
        Name = "FrmMembresias"
        Text = "FrmMembresias"
        panelListado.ResumeLayout(False)
        panelListado.PerformLayout()
        CType(pbReiniciar, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvListado, ComponentModel.ISupportInitialize).EndInit()
        panelDatosIngreso.ResumeLayout(False)
        panelDatosIngreso.PerformLayout()
        CType(pbReiniciarPlan, ComponentModel.ISupportInitialize).EndInit()
        CType(pbReiniciarMiembro, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPlan, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvMiembro, ComponentModel.ISupportInitialize).EndInit()
        panelPagoIngreso.ResumeLayout(False)
        panelPagoIngreso.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelListado As Panel
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents BtnPagar As Button
    Friend WithEvents cbOpcionBuscar As ComboBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents panelDatosIngreso As Panel
    Friend WithEvents lblDatosIngreso As Label
    Friend WithEvents dgvMiembro As DataGridView
    Friend WithEvents lblMiembro As Label
    Friend WithEvents tbBuscarMiembro As TextBox
    Friend WithEvents cbOpcionBuscarMiembro As ComboBox
    Friend WithEvents dgvPlan As DataGridView
    Friend WithEvents tbBuscarPlan As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cbBuscarOpcionPlan As ComboBox
    Friend WithEvents lblPlan As Label
    Friend WithEvents panelPagoIngreso As Panel
    Friend WithEvents btnCancelarPago As Button
    Friend WithEvents btnGuardarPago As Button
    Friend WithEvents cbMetodo As ComboBox
    Friend WithEvents tbNotas As TextBox
    Friend WithEvents tbComprobante As TextBox
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents lblNotas As Label
    Friend WithEvents lblComprobante As Label
    Friend WithEvents lblMetodo As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblPagoIngreso As Label
    Friend WithEvents pbReiniciar As PictureBox
    Friend WithEvents tbIDplan As TextBox
    Friend WithEvents tbIDmembresia As TextBox
    Friend WithEvents tbIDpago As TextBox
    Friend WithEvents tbIDmiembro As TextBox
    Friend WithEvents pbReiniciarMiembro As PictureBox
    Friend WithEvents pbReiniciarPlan As PictureBox
End Class