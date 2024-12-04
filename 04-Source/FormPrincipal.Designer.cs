namespace TabelaPrice
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgTabelaPrice = new SHL.DataGrid.Extensions.GridDataTable();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtValorIOF = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblValorIOF = new System.Windows.Forms.Label();
            this.txtValorTAC = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblTAC = new System.Windows.Forms.Label();
            this.txtTaxaDeJurosEfetiva = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblTaxaDeJurosEfetiva = new System.Windows.Forms.Label();
            this.txtTaxaDeJuros = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblTaxaDeJuros = new System.Windows.Forms.Label();
            this.txtValorEfetivoFinanciado = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblValorEfetivoFinanciado = new System.Windows.Forms.Label();
            this.txtAmortizacaoAcumulada = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblPrazoAcumulado = new System.Windows.Forms.Label();
            this.txtJurosAcumulado = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblJurosAcumulados = new System.Windows.Forms.Label();
            this.txtPrazoFinal = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblPrazoFinal = new System.Windows.Forms.Label();
            this.txtPrazoInicial = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblPrazoInicial = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.txtPrazo = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.txtParcela = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblParcela = new System.Windows.Forms.Label();
            this.txtIOF = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblIOF = new System.Windows.Forms.Label();
            this.txtValorFinanciado = new SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric();
            this.lblValorFinanciado = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.optValorEfetivo = new System.Windows.Forms.RadioButton();
            this.optValorFinanciado = new System.Windows.Forms.RadioButton();
            this.grpOperacao = new System.Windows.Forms.GroupBox();
            this.optValorParcelaCalc = new System.Windows.Forms.RadioButton();
            this.optPrazoCalc = new System.Windows.Forms.RadioButton();
            this.optValorFinanciadoCalc = new System.Windows.Forms.RadioButton();
            this.optTaxaJurosCalc = new System.Windows.Forms.RadioButton();
            this.grpCalculoParcelas = new System.Windows.Forms.GroupBox();
            this.grpDados.SuspendLayout();
            this.grpOperacao.SuspendLayout();
            this.grpCalculoParcelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTabelaPrice
            // 
            this.dtgTabelaPrice.AllowAlternateColor = true;
            this.dtgTabelaPrice.AlternateBackColor = System.Drawing.Color.Gainsboro;
            this.dtgTabelaPrice.AlternateForeColor = System.Drawing.Color.Black;
            this.dtgTabelaPrice.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.dtgTabelaPrice.AutoSizeMinHeight = 10;
            this.dtgTabelaPrice.AutoSizeMinWidth = 10;
            this.dtgTabelaPrice.AutoStretchColumnsToFitWidth = false;
            this.dtgTabelaPrice.AutoStretchRowsToFitHeight = false;
            this.dtgTabelaPrice.BackColor = System.Drawing.Color.White;
            this.dtgTabelaPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgTabelaPrice.ContextMenuStyle = SHL.DataGrid.ContextMenuStyle.CopyPasteSelection;
            this.dtgTabelaPrice.EnableDelete = true;
            this.dtgTabelaPrice.EnableEdit = true;
            this.dtgTabelaPrice.FocusStyle = SHL.DataGrid.FocusStyle.None;
            this.dtgTabelaPrice.GridToolTipActive = true;
            this.dtgTabelaPrice.Location = new System.Drawing.Point(21, 225);
            this.dtgTabelaPrice.Name = "dtgTabelaPrice";
            this.dtgTabelaPrice.Size = new System.Drawing.Size(763, 250);
            this.dtgTabelaPrice.SpecialKeys = ( (SHL.DataGrid.GridSpecialKeys)( ( ( ( ( ( ( ( ( SHL.DataGrid.GridSpecialKeys.Ctrl_C | SHL.DataGrid.GridSpecialKeys.Ctrl_V )
                        | SHL.DataGrid.GridSpecialKeys.Ctrl_X )
                        | SHL.DataGrid.GridSpecialKeys.Delete )
                        | SHL.DataGrid.GridSpecialKeys.Arrows )
                        | SHL.DataGrid.GridSpecialKeys.Tab )
                        | SHL.DataGrid.GridSpecialKeys.PageDownUp )
                        | SHL.DataGrid.GridSpecialKeys.Enter )
                        | SHL.DataGrid.GridSpecialKeys.Escape ) ) );
            this.dtgTabelaPrice.TabIndex = 0;
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtValorIOF);
            this.grpDados.Controls.Add(this.lblValorIOF);
            this.grpDados.Controls.Add(this.txtValorTAC);
            this.grpDados.Controls.Add(this.lblTAC);
            this.grpDados.Controls.Add(this.txtTaxaDeJurosEfetiva);
            this.grpDados.Controls.Add(this.lblTaxaDeJurosEfetiva);
            this.grpDados.Controls.Add(this.txtTaxaDeJuros);
            this.grpDados.Controls.Add(this.lblTaxaDeJuros);
            this.grpDados.Controls.Add(this.txtValorEfetivoFinanciado);
            this.grpDados.Controls.Add(this.lblValorEfetivoFinanciado);
            this.grpDados.Controls.Add(this.txtAmortizacaoAcumulada);
            this.grpDados.Controls.Add(this.lblPrazoAcumulado);
            this.grpDados.Controls.Add(this.txtJurosAcumulado);
            this.grpDados.Controls.Add(this.lblJurosAcumulados);
            this.grpDados.Controls.Add(this.txtPrazoFinal);
            this.grpDados.Controls.Add(this.lblPrazoFinal);
            this.grpDados.Controls.Add(this.txtPrazoInicial);
            this.grpDados.Controls.Add(this.lblPrazoInicial);
            this.grpDados.Controls.Add(this.cmdCalcular);
            this.grpDados.Controls.Add(this.txtPrazo);
            this.grpDados.Controls.Add(this.txtParcela);
            this.grpDados.Controls.Add(this.lblParcela);
            this.grpDados.Controls.Add(this.txtIOF);
            this.grpDados.Controls.Add(this.lblIOF);
            this.grpDados.Controls.Add(this.txtValorFinanciado);
            this.grpDados.Controls.Add(this.lblValorFinanciado);
            this.grpDados.Controls.Add(this.lblPrazo);
            this.grpDados.Location = new System.Drawing.Point(22, 48);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(762, 171);
            this.grpDados.TabIndex = 1;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do Financiamento";
            // 
            // txtValorIOF
            // 
            this.txtValorIOF.EnableAutoValidation = false;
            this.txtValorIOF.EnableEnterKeyValidate = true;
            this.txtValorIOF.EnableEscapeKeyUndo = true;
            this.txtValorIOF.EnableLastValidValue = true;
            this.txtValorIOF.ErrorProvider = null;
            this.txtValorIOF.ErrorProviderMessage = "Invalid value";
            this.txtValorIOF.ForceFormatText = true;
            this.txtValorIOF.Location = new System.Drawing.Point(117, 80);
            this.txtValorIOF.Name = "txtValorIOF";
            this.txtValorIOF.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtValorIOF.ReadOnly = true;
            this.txtValorIOF.Size = new System.Drawing.Size(111, 20);
            this.txtValorIOF.TabIndex = 14;
            this.txtValorIOF.Text = "0";
            this.txtValorIOF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorIOF
            // 
            this.lblValorIOF.AutoSize = true;
            this.lblValorIOF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblValorIOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblValorIOF.ForeColor = System.Drawing.Color.Blue;
            this.lblValorIOF.Location = new System.Drawing.Point(18, 84);
            this.lblValorIOF.Name = "lblValorIOF";
            this.lblValorIOF.Size = new System.Drawing.Size(51, 13);
            this.lblValorIOF.TabIndex = 23;
            this.lblValorIOF.Text = "Valor IOF";
            // 
            // txtValorTAC
            // 
            this.txtValorTAC.EnableAutoValidation = false;
            this.txtValorTAC.EnableEnterKeyValidate = true;
            this.txtValorTAC.EnableEscapeKeyUndo = true;
            this.txtValorTAC.EnableLastValidValue = true;
            this.txtValorTAC.ErrorProvider = null;
            this.txtValorTAC.ErrorProviderMessage = "Invalid value";
            this.txtValorTAC.ForceFormatText = true;
            this.txtValorTAC.Location = new System.Drawing.Point(432, 20);
            this.txtValorTAC.Name = "txtValorTAC";
            this.txtValorTAC.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtValorTAC.Size = new System.Drawing.Size(53, 20);
            this.txtValorTAC.TabIndex = 9;
            this.txtValorTAC.Text = "0";
            this.txtValorTAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTAC
            // 
            this.lblTAC.AutoSize = true;
            this.lblTAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblTAC.ForeColor = System.Drawing.Color.Blue;
            this.lblTAC.Location = new System.Drawing.Point(402, 23);
            this.lblTAC.Name = "lblTAC";
            this.lblTAC.Size = new System.Drawing.Size(28, 13);
            this.lblTAC.TabIndex = 22;
            this.lblTAC.Text = "TAC";
            // 
            // txtTaxaDeJurosEfetiva
            // 
            this.txtTaxaDeJurosEfetiva.EnableAutoValidation = false;
            this.txtTaxaDeJurosEfetiva.EnableEnterKeyValidate = true;
            this.txtTaxaDeJurosEfetiva.EnableEscapeKeyUndo = true;
            this.txtTaxaDeJurosEfetiva.EnableLastValidValue = true;
            this.txtTaxaDeJurosEfetiva.ErrorProvider = null;
            this.txtTaxaDeJurosEfetiva.ErrorProviderMessage = "Invalid value";
            this.txtTaxaDeJurosEfetiva.ForceFormatText = true;
            this.txtTaxaDeJurosEfetiva.Location = new System.Drawing.Point(614, 53);
            this.txtTaxaDeJurosEfetiva.Name = "txtTaxaDeJurosEfetiva";
            this.txtTaxaDeJurosEfetiva.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtTaxaDeJurosEfetiva.ReadOnly = true;
            this.txtTaxaDeJurosEfetiva.Size = new System.Drawing.Size(104, 20);
            this.txtTaxaDeJurosEfetiva.TabIndex = 13;
            this.txtTaxaDeJurosEfetiva.Text = "0";
            this.txtTaxaDeJurosEfetiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTaxaDeJurosEfetiva
            // 
            this.lblTaxaDeJurosEfetiva.AutoSize = true;
            this.lblTaxaDeJurosEfetiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTaxaDeJurosEfetiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblTaxaDeJurosEfetiva.ForeColor = System.Drawing.Color.Blue;
            this.lblTaxaDeJurosEfetiva.Location = new System.Drawing.Point(498, 55);
            this.lblTaxaDeJurosEfetiva.Name = "lblTaxaDeJurosEfetiva";
            this.lblTaxaDeJurosEfetiva.Size = new System.Drawing.Size(110, 13);
            this.lblTaxaDeJurosEfetiva.TabIndex = 20;
            this.lblTaxaDeJurosEfetiva.Text = "Taxa de Juros Efetiva";
            // 
            // txtTaxaDeJuros
            // 
            this.txtTaxaDeJuros.EnableAutoValidation = false;
            this.txtTaxaDeJuros.EnableEnterKeyValidate = true;
            this.txtTaxaDeJuros.EnableEscapeKeyUndo = true;
            this.txtTaxaDeJuros.EnableLastValidValue = true;
            this.txtTaxaDeJuros.ErrorProvider = null;
            this.txtTaxaDeJuros.ErrorProviderMessage = "Invalid value";
            this.txtTaxaDeJuros.ForceFormatText = true;
            this.txtTaxaDeJuros.Location = new System.Drawing.Point(614, 20);
            this.txtTaxaDeJuros.Name = "txtTaxaDeJuros";
            this.txtTaxaDeJuros.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtTaxaDeJuros.ReadOnly = true;
            this.txtTaxaDeJuros.Size = new System.Drawing.Size(104, 20);
            this.txtTaxaDeJuros.TabIndex = 10;
            this.txtTaxaDeJuros.Text = "0";
            this.txtTaxaDeJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTaxaDeJuros
            // 
            this.lblTaxaDeJuros.AutoSize = true;
            this.lblTaxaDeJuros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTaxaDeJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblTaxaDeJuros.ForeColor = System.Drawing.Color.Blue;
            this.lblTaxaDeJuros.Location = new System.Drawing.Point(498, 23);
            this.lblTaxaDeJuros.Name = "lblTaxaDeJuros";
            this.lblTaxaDeJuros.Size = new System.Drawing.Size(74, 13);
            this.lblTaxaDeJuros.TabIndex = 18;
            this.lblTaxaDeJuros.Text = "Taxa de Juros";
            // 
            // txtValorEfetivoFinanciado
            // 
            this.txtValorEfetivoFinanciado.EnableAutoValidation = false;
            this.txtValorEfetivoFinanciado.EnableEnterKeyValidate = true;
            this.txtValorEfetivoFinanciado.EnableEscapeKeyUndo = true;
            this.txtValorEfetivoFinanciado.EnableLastValidValue = true;
            this.txtValorEfetivoFinanciado.ErrorProvider = null;
            this.txtValorEfetivoFinanciado.ErrorProviderMessage = "Invalid value";
            this.txtValorEfetivoFinanciado.ForceFormatText = true;
            this.txtValorEfetivoFinanciado.Location = new System.Drawing.Point(381, 53);
            this.txtValorEfetivoFinanciado.Name = "txtValorEfetivoFinanciado";
            this.txtValorEfetivoFinanciado.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtValorEfetivoFinanciado.ReadOnly = true;
            this.txtValorEfetivoFinanciado.Size = new System.Drawing.Size(104, 20);
            this.txtValorEfetivoFinanciado.TabIndex = 12;
            this.txtValorEfetivoFinanciado.Text = "0";
            this.txtValorEfetivoFinanciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorEfetivoFinanciado
            // 
            this.lblValorEfetivoFinanciado.AutoSize = true;
            this.lblValorEfetivoFinanciado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblValorEfetivoFinanciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblValorEfetivoFinanciado.ForeColor = System.Drawing.Color.Blue;
            this.lblValorEfetivoFinanciado.Location = new System.Drawing.Point(249, 55);
            this.lblValorEfetivoFinanciado.Name = "lblValorEfetivoFinanciado";
            this.lblValorEfetivoFinanciado.Size = new System.Drawing.Size(122, 13);
            this.lblValorEfetivoFinanciado.TabIndex = 15;
            this.lblValorEfetivoFinanciado.Text = "Valor Efetivo Financiado";
            // 
            // txtAmortizacaoAcumulada
            // 
            this.txtAmortizacaoAcumulada.EnableAutoValidation = false;
            this.txtAmortizacaoAcumulada.EnableEnterKeyValidate = true;
            this.txtAmortizacaoAcumulada.EnableEscapeKeyUndo = true;
            this.txtAmortizacaoAcumulada.EnableLastValidValue = true;
            this.txtAmortizacaoAcumulada.ErrorProvider = null;
            this.txtAmortizacaoAcumulada.ErrorProviderMessage = "Invalid value";
            this.txtAmortizacaoAcumulada.ForceFormatText = true;
            this.txtAmortizacaoAcumulada.Location = new System.Drawing.Point(524, 112);
            this.txtAmortizacaoAcumulada.Name = "txtAmortizacaoAcumulada";
            this.txtAmortizacaoAcumulada.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtAmortizacaoAcumulada.ReadOnly = true;
            this.txtAmortizacaoAcumulada.Size = new System.Drawing.Size(104, 20);
            this.txtAmortizacaoAcumulada.TabIndex = 18;
            this.txtAmortizacaoAcumulada.Text = "0";
            this.txtAmortizacaoAcumulada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrazoAcumulado
            // 
            this.lblPrazoAcumulado.AutoSize = true;
            this.lblPrazoAcumulado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrazoAcumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblPrazoAcumulado.ForeColor = System.Drawing.Color.Blue;
            this.lblPrazoAcumulado.Location = new System.Drawing.Point(423, 112);
            this.lblPrazoAcumulado.Name = "lblPrazoAcumulado";
            this.lblPrazoAcumulado.Size = new System.Drawing.Size(93, 13);
            this.lblPrazoAcumulado.TabIndex = 14;
            this.lblPrazoAcumulado.Text = "Amort. Acumulada";
            // 
            // txtJurosAcumulado
            // 
            this.txtJurosAcumulado.EnableAutoValidation = false;
            this.txtJurosAcumulado.EnableEnterKeyValidate = true;
            this.txtJurosAcumulado.EnableEscapeKeyUndo = true;
            this.txtJurosAcumulado.EnableLastValidValue = true;
            this.txtJurosAcumulado.ErrorProvider = null;
            this.txtJurosAcumulado.ErrorProviderMessage = "Invalid value";
            this.txtJurosAcumulado.ForceFormatText = true;
            this.txtJurosAcumulado.Location = new System.Drawing.Point(313, 112);
            this.txtJurosAcumulado.Name = "txtJurosAcumulado";
            this.txtJurosAcumulado.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtJurosAcumulado.ReadOnly = true;
            this.txtJurosAcumulado.Size = new System.Drawing.Size(104, 20);
            this.txtJurosAcumulado.TabIndex = 17;
            this.txtJurosAcumulado.Text = "0";
            this.txtJurosAcumulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblJurosAcumulados
            // 
            this.lblJurosAcumulados.AutoSize = true;
            this.lblJurosAcumulados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJurosAcumulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblJurosAcumulados.ForeColor = System.Drawing.Color.Blue;
            this.lblJurosAcumulados.Location = new System.Drawing.Point(210, 115);
            this.lblJurosAcumulados.Name = "lblJurosAcumulados";
            this.lblJurosAcumulados.Size = new System.Drawing.Size(93, 13);
            this.lblJurosAcumulados.TabIndex = 12;
            this.lblJurosAcumulados.Text = "Juros Acumulados";
            // 
            // txtPrazoFinal
            // 
            this.txtPrazoFinal.EnableAutoValidation = false;
            this.txtPrazoFinal.EnableEnterKeyValidate = true;
            this.txtPrazoFinal.EnableEscapeKeyUndo = true;
            this.txtPrazoFinal.EnableLastValidValue = true;
            this.txtPrazoFinal.ErrorProvider = null;
            this.txtPrazoFinal.ErrorProviderMessage = "Invalid value";
            this.txtPrazoFinal.ForceFormatText = true;
            this.txtPrazoFinal.Location = new System.Drawing.Point(152, 112);
            this.txtPrazoFinal.Name = "txtPrazoFinal";
            this.txtPrazoFinal.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtPrazoFinal.Size = new System.Drawing.Size(35, 20);
            this.txtPrazoFinal.TabIndex = 16;
            this.txtPrazoFinal.Text = "0";
            this.txtPrazoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrazoFinal
            // 
            this.lblPrazoFinal.AutoSize = true;
            this.lblPrazoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblPrazoFinal.ForeColor = System.Drawing.Color.Blue;
            this.lblPrazoFinal.Location = new System.Drawing.Point(123, 115);
            this.lblPrazoFinal.Name = "lblPrazoFinal";
            this.lblPrazoFinal.Size = new System.Drawing.Size(23, 13);
            this.lblPrazoFinal.TabIndex = 9;
            this.lblPrazoFinal.Text = "Até";
            // 
            // txtPrazoInicial
            // 
            this.txtPrazoInicial.EnableAutoValidation = false;
            this.txtPrazoInicial.EnableEnterKeyValidate = true;
            this.txtPrazoInicial.EnableEscapeKeyUndo = true;
            this.txtPrazoInicial.EnableLastValidValue = true;
            this.txtPrazoInicial.ErrorProvider = null;
            this.txtPrazoInicial.ErrorProviderMessage = "Invalid value";
            this.txtPrazoInicial.ForceFormatText = true;
            this.txtPrazoInicial.Location = new System.Drawing.Point(78, 112);
            this.txtPrazoInicial.Name = "txtPrazoInicial";
            this.txtPrazoInicial.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtPrazoInicial.Size = new System.Drawing.Size(35, 20);
            this.txtPrazoInicial.TabIndex = 15;
            this.txtPrazoInicial.Text = "0";
            this.txtPrazoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrazoInicial
            // 
            this.lblPrazoInicial.AutoSize = true;
            this.lblPrazoInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrazoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblPrazoInicial.ForeColor = System.Drawing.Color.Blue;
            this.lblPrazoInicial.Location = new System.Drawing.Point(18, 118);
            this.lblPrazoInicial.Name = "lblPrazoInicial";
            this.lblPrazoInicial.Size = new System.Drawing.Size(49, 13);
            this.lblPrazoInicial.TabIndex = 7;
            this.lblPrazoInicial.Text = "Prazo de";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.cmdCalcular.Location = new System.Drawing.Point(664, 140);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(92, 25);
            this.cmdCalcular.TabIndex = 19;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // txtPrazo
            // 
            this.txtPrazo.EnableAutoValidation = false;
            this.txtPrazo.EnableEnterKeyValidate = true;
            this.txtPrazo.EnableEscapeKeyUndo = true;
            this.txtPrazo.EnableLastValidValue = true;
            this.txtPrazo.ErrorProvider = null;
            this.txtPrazo.ErrorProviderMessage = "Invalid value";
            this.txtPrazo.ForceFormatText = true;
            this.txtPrazo.Location = new System.Drawing.Point(119, 20);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtPrazo.Size = new System.Drawing.Size(35, 20);
            this.txtPrazo.TabIndex = 6;
            this.txtPrazo.Text = "0";
            this.txtPrazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrazo.TextChanged += new System.EventHandler(this.txtPrazo_TextChanged);
            // 
            // txtParcela
            // 
            this.txtParcela.EnableAutoValidation = false;
            this.txtParcela.EnableEnterKeyValidate = true;
            this.txtParcela.EnableEscapeKeyUndo = true;
            this.txtParcela.EnableLastValidValue = true;
            this.txtParcela.ErrorProvider = null;
            this.txtParcela.ErrorProviderMessage = "Invalid value";
            this.txtParcela.ForceFormatText = true;
            this.txtParcela.Location = new System.Drawing.Point(213, 20);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtParcela.Size = new System.Drawing.Size(74, 20);
            this.txtParcela.TabIndex = 7;
            this.txtParcela.Text = "0";
            this.txtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblParcela.ForeColor = System.Drawing.Color.Blue;
            this.lblParcela.Location = new System.Drawing.Point(164, 23);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(43, 13);
            this.lblParcela.TabIndex = 6;
            this.lblParcela.Text = "Parcela";
            // 
            // txtIOF
            // 
            this.txtIOF.EnableAutoValidation = false;
            this.txtIOF.EnableEnterKeyValidate = true;
            this.txtIOF.EnableEscapeKeyUndo = true;
            this.txtIOF.EnableLastValidValue = true;
            this.txtIOF.ErrorProvider = null;
            this.txtIOF.ErrorProviderMessage = "Invalid value";
            this.txtIOF.ForceFormatText = true;
            this.txtIOF.Location = new System.Drawing.Point(318, 20);
            this.txtIOF.Name = "txtIOF";
            this.txtIOF.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtIOF.Size = new System.Drawing.Size(53, 20);
            this.txtIOF.TabIndex = 8;
            this.txtIOF.Text = "0,0123";
            this.txtIOF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIOF
            // 
            this.lblIOF.AutoSize = true;
            this.lblIOF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblIOF.ForeColor = System.Drawing.Color.Blue;
            this.lblIOF.Location = new System.Drawing.Point(293, 23);
            this.lblIOF.Name = "lblIOF";
            this.lblIOF.Size = new System.Drawing.Size(24, 13);
            this.lblIOF.TabIndex = 4;
            this.lblIOF.Text = "IOF";
            // 
            // txtValorFinanciado
            // 
            this.txtValorFinanciado.EnableAutoValidation = false;
            this.txtValorFinanciado.EnableEnterKeyValidate = true;
            this.txtValorFinanciado.EnableEscapeKeyUndo = true;
            this.txtValorFinanciado.EnableLastValidValue = true;
            this.txtValorFinanciado.ErrorProvider = null;
            this.txtValorFinanciado.ErrorProviderMessage = "Invalid value";
            this.txtValorFinanciado.ForceFormatText = true;
            this.txtValorFinanciado.Location = new System.Drawing.Point(117, 52);
            this.txtValorFinanciado.Name = "txtValorFinanciado";
            this.txtValorFinanciado.NumericCharStyle = ( (SHL.ControlLibrary.Windows.Forms.NumericCharStyle)( ( SHL.ControlLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SHL.ControlLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol ) ) );
            this.txtValorFinanciado.Size = new System.Drawing.Size(111, 20);
            this.txtValorFinanciado.TabIndex = 11;
            this.txtValorFinanciado.Text = "0";
            this.txtValorFinanciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorFinanciado
            // 
            this.lblValorFinanciado.AutoSize = true;
            this.lblValorFinanciado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblValorFinanciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblValorFinanciado.ForeColor = System.Drawing.Color.Blue;
            this.lblValorFinanciado.Location = new System.Drawing.Point(18, 56);
            this.lblValorFinanciado.Name = "lblValorFinanciado";
            this.lblValorFinanciado.Size = new System.Drawing.Size(86, 13);
            this.lblValorFinanciado.TabIndex = 2;
            this.lblValorFinanciado.Text = "Valor Financiado";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblPrazo.ForeColor = System.Drawing.Color.Blue;
            this.lblPrazo.Location = new System.Drawing.Point(18, 23);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(34, 13);
            this.lblPrazo.TabIndex = 0;
            this.lblPrazo.Text = "Prazo";
            // 
            // optValorEfetivo
            // 
            this.optValorEfetivo.AutoSize = true;
            this.optValorEfetivo.Checked = true;
            this.optValorEfetivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optValorEfetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.optValorEfetivo.ForeColor = System.Drawing.Color.Blue;
            this.optValorEfetivo.Location = new System.Drawing.Point(34, 19);
            this.optValorEfetivo.Name = "optValorEfetivo";
            this.optValorEfetivo.Size = new System.Drawing.Size(85, 17);
            this.optValorEfetivo.TabIndex = 5;
            this.optValorEfetivo.TabStop = true;
            this.optValorEfetivo.Text = "Valor Efetivo";
            this.optValorEfetivo.UseVisualStyleBackColor = true;
            // 
            // optValorFinanciado
            // 
            this.optValorFinanciado.AutoSize = true;
            this.optValorFinanciado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optValorFinanciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.optValorFinanciado.ForeColor = System.Drawing.Color.Blue;
            this.optValorFinanciado.Location = new System.Drawing.Point(165, 19);
            this.optValorFinanciado.Name = "optValorFinanciado";
            this.optValorFinanciado.Size = new System.Drawing.Size(104, 17);
            this.optValorFinanciado.TabIndex = 4;
            this.optValorFinanciado.Text = "Valor Financiado";
            this.optValorFinanciado.UseVisualStyleBackColor = true;
            // 
            // grpOperacao
            // 
            this.grpOperacao.Controls.Add(this.optValorParcelaCalc);
            this.grpOperacao.Controls.Add(this.optPrazoCalc);
            this.grpOperacao.Controls.Add(this.optValorFinanciadoCalc);
            this.grpOperacao.Controls.Add(this.optTaxaJurosCalc);
            this.grpOperacao.Location = new System.Drawing.Point(22, -1);
            this.grpOperacao.Name = "grpOperacao";
            this.grpOperacao.Size = new System.Drawing.Size(447, 49);
            this.grpOperacao.TabIndex = 27;
            this.grpOperacao.TabStop = false;
            this.grpOperacao.Text = "Encontrar:";
            // 
            // optValorParcelaCalc
            // 
            this.optValorParcelaCalc.AutoSize = true;
            this.optValorParcelaCalc.Checked = true;
            this.optValorParcelaCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optValorParcelaCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.optValorParcelaCalc.ForeColor = System.Drawing.Color.Blue;
            this.optValorParcelaCalc.Location = new System.Drawing.Point(257, 19);
            this.optValorParcelaCalc.Name = "optValorParcelaCalc";
            this.optValorParcelaCalc.Size = new System.Drawing.Size(88, 17);
            this.optValorParcelaCalc.TabIndex = 2;
            this.optValorParcelaCalc.TabStop = true;
            this.optValorParcelaCalc.Text = "Valor Parcela";
            this.optValorParcelaCalc.UseVisualStyleBackColor = true;
            this.optValorParcelaCalc.CheckedChanged += new System.EventHandler(this.optValorParcelaCalc_CheckedChanged);
            // 
            // optPrazoCalc
            // 
            this.optPrazoCalc.AutoSize = true;
            this.optPrazoCalc.Checked = true;
            this.optPrazoCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optPrazoCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.optPrazoCalc.ForeColor = System.Drawing.Color.Blue;
            this.optPrazoCalc.Location = new System.Drawing.Point(365, 19);
            this.optPrazoCalc.Name = "optPrazoCalc";
            this.optPrazoCalc.Size = new System.Drawing.Size(52, 17);
            this.optPrazoCalc.TabIndex = 3;
            this.optPrazoCalc.TabStop = true;
            this.optPrazoCalc.Text = "Prazo";
            this.optPrazoCalc.UseVisualStyleBackColor = true;
            this.optPrazoCalc.CheckedChanged += new System.EventHandler(this.optPrazoCalc_CheckedChanged);
            // 
            // optValorFinanciadoCalc
            // 
            this.optValorFinanciadoCalc.AutoSize = true;
            this.optValorFinanciadoCalc.Checked = true;
            this.optValorFinanciadoCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optValorFinanciadoCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.optValorFinanciadoCalc.ForeColor = System.Drawing.Color.Blue;
            this.optValorFinanciadoCalc.Location = new System.Drawing.Point(133, 19);
            this.optValorFinanciadoCalc.Name = "optValorFinanciadoCalc";
            this.optValorFinanciadoCalc.Size = new System.Drawing.Size(104, 17);
            this.optValorFinanciadoCalc.TabIndex = 1;
            this.optValorFinanciadoCalc.TabStop = true;
            this.optValorFinanciadoCalc.Text = "Valor Financiado";
            this.optValorFinanciadoCalc.UseVisualStyleBackColor = true;
            this.optValorFinanciadoCalc.CheckedChanged += new System.EventHandler(this.optValorFinanciadoCalc_CheckedChanged);
            // 
            // optTaxaJurosCalc
            // 
            this.optTaxaJurosCalc.AutoSize = true;
            this.optTaxaJurosCalc.Checked = true;
            this.optTaxaJurosCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optTaxaJurosCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.optTaxaJurosCalc.ForeColor = System.Drawing.Color.Blue;
            this.optTaxaJurosCalc.Location = new System.Drawing.Point(21, 19);
            this.optTaxaJurosCalc.Name = "optTaxaJurosCalc";
            this.optTaxaJurosCalc.Size = new System.Drawing.Size(92, 17);
            this.optTaxaJurosCalc.TabIndex = 0;
            this.optTaxaJurosCalc.TabStop = true;
            this.optTaxaJurosCalc.Text = "Taxa de Juros";
            this.optTaxaJurosCalc.UseVisualStyleBackColor = true;
            this.optTaxaJurosCalc.CheckedChanged += new System.EventHandler(this.optTaxaJurosCalc_CheckedChanged);
            // 
            // grpCalculoParcelas
            // 
            this.grpCalculoParcelas.Controls.Add(this.optValorEfetivo);
            this.grpCalculoParcelas.Controls.Add(this.optValorFinanciado);
            this.grpCalculoParcelas.Location = new System.Drawing.Point(475, -1);
            this.grpCalculoParcelas.Name = "grpCalculoParcelas";
            this.grpCalculoParcelas.Size = new System.Drawing.Size(308, 49);
            this.grpCalculoParcelas.TabIndex = 28;
            this.grpCalculoParcelas.TabStop = false;
            this.grpCalculoParcelas.Text = "Parcelas baseadas em:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 487);
            this.Controls.Add(this.grpCalculoParcelas);
            this.Controls.Add(this.grpOperacao);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.dtgTabelaPrice);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela Price";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpOperacao.ResumeLayout(false);
            this.grpOperacao.PerformLayout();
            this.grpCalculoParcelas.ResumeLayout(false);
            this.grpCalculoParcelas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SHL.DataGrid.Extensions.GridDataTable dtgTabelaPrice;
        private System.Windows.Forms.GroupBox grpDados;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtValorFinanciado;
        private System.Windows.Forms.Label lblValorFinanciado;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Button cmdCalcular;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtPrazo;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtParcela;
        private System.Windows.Forms.Label lblParcela;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtIOF;
        private System.Windows.Forms.Label lblIOF;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtAmortizacaoAcumulada;
        private System.Windows.Forms.Label lblPrazoAcumulado;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtJurosAcumulado;
        private System.Windows.Forms.Label lblJurosAcumulados;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtPrazoFinal;
        private System.Windows.Forms.Label lblPrazoFinal;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtPrazoInicial;
        private System.Windows.Forms.Label lblPrazoInicial;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtValorEfetivoFinanciado;
        private System.Windows.Forms.Label lblValorEfetivoFinanciado;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtTaxaDeJuros;
        private System.Windows.Forms.Label lblTaxaDeJuros;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtTaxaDeJurosEfetiva;
        private System.Windows.Forms.Label lblTaxaDeJurosEfetiva;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtValorIOF;
        private System.Windows.Forms.Label lblValorIOF;
        private SHL.ControlLibrary.Windows.Forms.TextBoxTypedNumeric txtValorTAC;
        private System.Windows.Forms.Label lblTAC;
        private System.Windows.Forms.RadioButton optValorEfetivo;
        private System.Windows.Forms.RadioButton optValorFinanciado;
        private System.Windows.Forms.GroupBox grpOperacao;
        private System.Windows.Forms.RadioButton optPrazoCalc;
        private System.Windows.Forms.RadioButton optValorFinanciadoCalc;
        private System.Windows.Forms.RadioButton optTaxaJurosCalc;
        private System.Windows.Forms.GroupBox grpCalculoParcelas;
        private System.Windows.Forms.RadioButton optValorParcelaCalc;
    }
}

