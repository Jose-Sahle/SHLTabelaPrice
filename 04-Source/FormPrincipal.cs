using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using SHL.Library;

using SHL.ControlLibrary.ComponentModel.Converter;
using Headers = SHL.DataGrid.VisualModels;
using DataModel = SHL.DataGrid.DataModels;
using DataTableGrids = SHL.DataGrid.Extensions.GridDataTable;
using Borders = SHL.DataGrid.CommonBorderStyle;

namespace TabelaPrice
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region "Declaraçoes"
            private DataTable   m_dados;
            private int         m_nPrazo;
            private double      m_dParcela;
            private double      m_dIOF;
            private double      m_dTaxaJuros;
            private double      m_dTaxaJurosFinanciamento;
            private double      m_dTaxaJurosEfetiva;
            private double      m_dValorIOF;
            private double      m_dValorTAC;
            private double      m_dValorFinanciado;
            private double      m_dValorFinanciadoEfetivo;
        #endregion

        #region "Eventos"
            private void frmPrincipal_Load(object sender, EventArgs e)
            {
                IniciarControles();
            }

            private void txtPrazo_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    txtPrazoInicial.Text = "1";
                    txtPrazoFinal.Text = txtPrazo.Text;
                }
                catch
                {
                }
            }

            private void cmdCalcular_Click(object sender, EventArgs e)
            {
                Calcular();
            }

            private void optTaxaJurosCalc_CheckedChanged(object sender, EventArgs e)
            {
                EnableControls();
            }

            private void optValorFinanciadoCalc_CheckedChanged(object sender, EventArgs e)
            {
                EnableControls();
            }

            private void optPrazoCalc_CheckedChanged(object sender, EventArgs e)
            {
                EnableControls();
            }

            private void optValorParcelaCalc_CheckedChanged(object sender, EventArgs e)
            {
                EnableControls();
            }

        #endregion

        #region "Métodos Privados
            private void IniciarControles()
            {
                try
                {
                    optTaxaJurosCalc.Checked = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "IniciarControles");
                }
            }

            private void EnableControls()
            {
                try
                {
                    txtPrazo.ReadOnly =!( optValorFinanciadoCalc.Checked || optTaxaJurosCalc.Checked || optValorParcelaCalc.Checked);
                    txtParcela.ReadOnly = !(optPrazoCalc.Checked || optValorFinanciadoCalc.Checked || optTaxaJurosCalc.Checked);
                    txtIOF.ReadOnly = false;
                    txtValorTAC.ReadOnly = false;
                    txtTaxaDeJuros.ReadOnly = !(optPrazoCalc.Checked || optValorFinanciadoCalc.Checked || optValorParcelaCalc.Checked);
                    txtValorFinanciado.ReadOnly = !(optPrazoCalc.Checked || optTaxaJurosCalc.Checked || optValorParcelaCalc.Checked);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "IniciarControles");
                }
            }

            private void LimparCampos()
            {
                //txtTaxaDeJuros.Text = "0";
                txtTaxaDeJurosEfetiva.Text = "0";
                txtJurosAcumulado.Text = "0";
                txtAmortizacaoAcumulada.Text = "0";
            }

            private void Calcular()
            {
                try
                {
                    if (optPrazoCalc.Checked)
                    {
                        CalcularPrazo();
                    }
                    else
                    if(optValorFinanciadoCalc.Checked)
                    {
                        CalcularValorFinanciado();
                    }
                    else
                    if(optTaxaJurosCalc.Checked)
                    {
                        CalcularJuros();
                    }
                    else
                    if(optValorParcelaCalc.Checked)
                    {
                        CalcularParcela();
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Calcular");
                }
            }

            private void CalcularPrazo()
            {
                int nIndex;
                DataRow dwLinha;
                double dPrazo;

                try
                {
                    LimparCampos();

                    m_dTaxaJurosFinanciamento = Convert.ToDouble(txtTaxaDeJuros.Text) / 100;
                    m_dParcela = Convert.ToDouble(txtParcela.Text);
                    m_dIOF = Convert.ToDouble(txtIOF.Text) / 100;
                    m_dValorFinanciado = Convert.ToDouble(txtValorFinanciado.Text);
                    m_dValorTAC = Convert.ToDouble(txtValorTAC.Text);

                    if (m_dTaxaJurosFinanciamento == 0 || m_dParcela == 0 || m_dValorFinanciado == 0)
                    {
                        MessageBox.Show("Preencha os dados corretamente.");
                        return;
                    }

                    dPrazo = Financial.NPer(m_dTaxaJurosFinanciamento, m_dParcela, (-1) * m_dValorFinanciado);

                    m_nPrazo = Convert.ToInt32(Math.Floor(dPrazo)) + 1;

                    m_dValorFinanciadoEfetivo = m_dValorFinanciado / (1 - m_nPrazo * m_dIOF);
                    m_dValorIOF = m_dValorFinanciadoEfetivo - m_dValorFinanciado;
                    m_dValorFinanciadoEfetivo = m_dValorFinanciadoEfetivo + m_dValorTAC;

                    m_dTaxaJurosEfetiva = Financial.Rate(m_nPrazo, m_dParcela, (-1) * m_dValorFinanciadoEfetivo);

                    txtValorEfetivoFinanciado.Text = m_dValorFinanciadoEfetivo.ToString("###,###,##0.00");
                    txtPrazo.Text = (m_nPrazo).ToString("###,###,##0");
                    txtTaxaDeJurosEfetiva.Text = (m_dTaxaJurosEfetiva * 100).ToString("###,###,##0.0000");
                    txtValorIOF.Text = m_dValorIOF.ToString("###,###,##0.00");

                    if (optValorFinanciado.Checked)
                        m_dTaxaJuros = m_dTaxaJurosFinanciamento;
                    else
                        m_dTaxaJuros = m_dTaxaJurosEfetiva;

                    PeriodoAcumulado();

                    m_dados = new DataTable();

                    m_dados.Columns.Add("nPrazo", System.Type.GetType("System.Int32"));
                    m_dados.Columns.Add("dJuros", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dAmortizacao", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dJurosAcumulados", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dAmortizacaoAcumulada", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dSaldoDevedor", System.Type.GetType("System.Decimal"));

                    dwLinha = m_dados.NewRow();

                    dwLinha["nPrazo"] = 0;
                    dwLinha["dJuros"] = 0;
                    dwLinha["dAmortizacao"] = 0;
                    dwLinha["dJurosAcumulados"] = 0;
                    dwLinha["dAmortizacaoAcumulada"] = 0;
                    dwLinha["dSaldoDevedor"] = m_dValorFinanciado;

                    m_dados.Rows.Add(dwLinha);

                    for (nIndex = 1; nIndex <= Convert.ToDouble(txtPrazo.Text); nIndex++)
                    {
                        dwLinha = m_dados.NewRow();

                        dwLinha["nPrazo"] = nIndex;
                        dwLinha["dJuros"] = Juros(nIndex);
                        dwLinha["dAmortizacao"] = Amortizacao(nIndex);
                        dwLinha["dJurosAcumulados"] = JurosAcumulados(nIndex);
                        dwLinha["dAmortizacaoAcumulada"] = AmortizacaoAcumulada(nIndex);
                        dwLinha["dSaldoDevedor"] = SaldoDevedor(nIndex);

                        m_dados.Rows.Add(dwLinha);
                    }

                    PreencherTabela();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private void CalcularParcela()
            {
                int nIndex;
                DataRow dwLinha;

                try
                {
                    LimparCampos();

                    m_nPrazo = Convert.ToInt32(txtPrazo.Text);
                    m_dTaxaJurosFinanciamento = Convert.ToDouble(txtTaxaDeJuros.Text) / 100;
                    m_dIOF = Convert.ToDouble(txtIOF.Text) / 100;
                    m_dValorFinanciado = Convert.ToDouble(txtValorFinanciado.Text);
                    m_dValorTAC = Convert.ToDouble(txtValorTAC.Text);

                    if (m_nPrazo == 0 || m_dTaxaJurosFinanciamento == 0 || m_dValorFinanciado == 0)
                    {
                        MessageBox.Show("Preencha os dados corretamente.");
                        return;
                    }

                    m_dValorFinanciadoEfetivo = m_dValorFinanciado / (1 - m_nPrazo * m_dIOF);
                    m_dValorIOF = m_dValorFinanciadoEfetivo - m_dValorFinanciado;
                    m_dValorFinanciadoEfetivo = m_dValorFinanciadoEfetivo + m_dValorTAC;

                    txtValorEfetivoFinanciado.Text = m_dValorFinanciadoEfetivo.ToString("###,###,##0.00");

                    if (optValorEfetivo.Checked)
                    {
                        m_dParcela = Financial.Pmt(m_dTaxaJurosFinanciamento , m_nPrazo, (-1) * m_dValorFinanciadoEfetivo);
                    }
                    else
                    {
                        m_dParcela = Financial.Pmt(m_dTaxaJurosFinanciamento , m_nPrazo, (-1) * m_dValorFinanciado);
                    }

                    m_dTaxaJurosEfetiva = Financial.Rate(m_nPrazo, m_dParcela, (-1) * m_dValorFinanciadoEfetivo);

                    txtParcela.Text = m_dParcela.ToString("###,###,##0.00");
                    txtTaxaDeJurosEfetiva.Text = (m_dTaxaJurosFinanciamento * 100).ToString("###,###,##0.0000");
                    txtValorIOF.Text = m_dValorIOF.ToString("###,###,##0.00");

                    if (optValorFinanciado.Checked)
                        m_dTaxaJuros = m_dTaxaJurosFinanciamento;
                    else
                        m_dTaxaJuros = m_dTaxaJurosEfetiva;

                    PeriodoAcumulado();

                    m_dados = new DataTable();

                    m_dados.Columns.Add("nPrazo", System.Type.GetType("System.Int32"));
                    m_dados.Columns.Add("dJuros", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dAmortizacao", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dJurosAcumulados", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dAmortizacaoAcumulada", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dSaldoDevedor", System.Type.GetType("System.Decimal"));

                    dwLinha = m_dados.NewRow();

                    dwLinha["nPrazo"] = 0;
                    dwLinha["dJuros"] = 0;
                    dwLinha["dAmortizacao"] = 0;
                    dwLinha["dJurosAcumulados"] = 0;
                    dwLinha["dAmortizacaoAcumulada"] = 0;
                    dwLinha["dSaldoDevedor"] = m_dValorFinanciado;

                    m_dados.Rows.Add(dwLinha);

                    for (nIndex = 1; nIndex <= Convert.ToDouble(txtPrazo.Text); nIndex++)
                    {
                        dwLinha = m_dados.NewRow();

                        dwLinha["nPrazo"] = nIndex;
                        dwLinha["dJuros"] = Juros(nIndex);
                        dwLinha["dAmortizacao"] = Amortizacao(nIndex);
                        dwLinha["dJurosAcumulados"] = JurosAcumulados(nIndex);
                        dwLinha["dAmortizacaoAcumulada"] = AmortizacaoAcumulada(nIndex);
                        dwLinha["dSaldoDevedor"] = SaldoDevedor(nIndex);

                        m_dados.Rows.Add(dwLinha);
                    }

                    PreencherTabela();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Calcular");
                }
            }

            private void CalcularValorFinanciado()
            {
                int nIndex;
                DataRow dwLinha;

                try
                {
                    LimparCampos();

                    m_nPrazo = Convert.ToInt32(txtPrazo.Text);
                    m_dParcela = Convert.ToDouble(txtParcela.Text);
                    m_dIOF = Convert.ToDouble(txtIOF.Text) / 100;
                    m_dTaxaJurosFinanciamento = Convert.ToDouble(txtTaxaDeJuros.Text) / 100;
                    m_dValorTAC = Convert.ToDouble(txtValorTAC.Text);

                    if (m_nPrazo == 0 || m_dParcela == 0 || m_dTaxaJurosFinanciamento == 0)
                    {
                        MessageBox.Show("Preencha os dados corretamente.");
                        return;
                    }

                    m_dValorFinanciado = (Financial.PV(m_dTaxaJurosFinanciamento, m_nPrazo, (-1) * m_dParcela));

                    m_dValorFinanciadoEfetivo = m_dValorFinanciado / (1 - m_nPrazo * m_dIOF);
                    m_dValorIOF = m_dValorFinanciadoEfetivo - m_dValorFinanciado;
                    m_dValorFinanciadoEfetivo = m_dValorFinanciadoEfetivo + m_dValorTAC;

                    txtValorEfetivoFinanciado.Text = m_dValorFinanciadoEfetivo.ToString("###,###,##0.00");

                    m_dTaxaJurosFinanciamento = Financial.Rate(m_nPrazo, m_dParcela, (-1) * m_dValorFinanciado);
                    m_dTaxaJurosEfetiva = Financial.Rate(m_nPrazo, m_dParcela, (-1) * m_dValorFinanciadoEfetivo);

                    txtValorFinanciado.Text = (m_dValorFinanciado).ToString("###,###,##0.00");
                    txtTaxaDeJuros.Text = (m_dTaxaJurosFinanciamento * 100).ToString("###,###,##0.0000");
                    txtTaxaDeJurosEfetiva.Text = (m_dTaxaJurosEfetiva * 100).ToString("###,###,##0.0000");
                    txtValorIOF.Text = m_dValorIOF.ToString("###,###,##0.00");

                    if (optValorFinanciado.Checked)
                        m_dTaxaJuros = m_dTaxaJurosFinanciamento;
                    else
                        m_dTaxaJuros = m_dTaxaJurosEfetiva;

                    PeriodoAcumulado();

                    m_dados = new DataTable();

                    m_dados.Columns.Add("nPrazo", System.Type.GetType("System.Int32"));
                    m_dados.Columns.Add("dJuros", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dAmortizacao", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dJurosAcumulados", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dAmortizacaoAcumulada", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dSaldoDevedor", System.Type.GetType("System.Decimal"));

                    dwLinha = m_dados.NewRow();

                    dwLinha["nPrazo"] = 0;
                    dwLinha["dJuros"] = 0;
                    dwLinha["dAmortizacao"] = 0;
                    dwLinha["dJurosAcumulados"] = 0;
                    dwLinha["dAmortizacaoAcumulada"] = 0;
                    dwLinha["dSaldoDevedor"] = m_dValorFinanciado;

                    m_dados.Rows.Add(dwLinha);

                    for (nIndex = 1; nIndex <= Convert.ToDouble(txtPrazo.Text); nIndex++)
                    {
                        dwLinha = m_dados.NewRow();

                        dwLinha["nPrazo"] = nIndex;
                        dwLinha["dJuros"] = Juros(nIndex);
                        dwLinha["dAmortizacao"] = Amortizacao(nIndex);
                        dwLinha["dJurosAcumulados"] = JurosAcumulados(nIndex);
                        dwLinha["dAmortizacaoAcumulada"] = AmortizacaoAcumulada(nIndex);
                        dwLinha["dSaldoDevedor"] = SaldoDevedor(nIndex);

                        m_dados.Rows.Add(dwLinha);
                    }

                    PreencherTabela();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private void CalcularJuros()
            {
                int nIndex;
                DataRow dwLinha;

                try
                {
                    LimparCampos();

                    m_nPrazo = Convert.ToInt32(txtPrazo.Text);
                    m_dParcela = Convert.ToDouble(txtParcela.Text);
                    m_dIOF = Convert.ToDouble(txtIOF.Text) / 100;
                    m_dValorFinanciado = Convert.ToDouble(txtValorFinanciado.Text);
                    m_dValorTAC = Convert.ToDouble(txtValorTAC.Text);

                    if (m_nPrazo == 0 || m_dParcela == 0 || m_dValorFinanciado == 0)
                    {
                        MessageBox.Show("Preencha os dados corretamente.");
                        return;
                    }

                    m_dValorFinanciadoEfetivo = m_dValorFinanciado / (1 - m_nPrazo * m_dIOF);
                    m_dValorIOF = m_dValorFinanciadoEfetivo - m_dValorFinanciado;
                    m_dValorFinanciadoEfetivo = m_dValorFinanciadoEfetivo + m_dValorTAC;

                    txtValorEfetivoFinanciado.Text = m_dValorFinanciadoEfetivo.ToString("###,###,##0.00");

                    m_dTaxaJurosFinanciamento = Financial.Rate(m_nPrazo, m_dParcela, (-1) * m_dValorFinanciado);
                    m_dTaxaJurosEfetiva = Financial.Rate(m_nPrazo, m_dParcela, (-1) * m_dValorFinanciadoEfetivo);

                    txtTaxaDeJuros.Text = (m_dTaxaJurosFinanciamento * 100).ToString("###,###,##0.0000");
                    txtTaxaDeJurosEfetiva.Text = (m_dTaxaJurosEfetiva * 100).ToString("###,###,##0.0000");
                    txtValorIOF.Text = m_dValorIOF.ToString("###,###,##0.00");

                    if (optValorFinanciado.Checked)
                        m_dTaxaJuros = m_dTaxaJurosFinanciamento;
                    else
                        m_dTaxaJuros = m_dTaxaJurosEfetiva;

                    PeriodoAcumulado();

                    m_dados = new DataTable();

                    m_dados.Columns.Add("nPrazo", System.Type.GetType("System.Int32"));
                    m_dados.Columns.Add("dJuros", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dAmortizacao", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dJurosAcumulados", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dAmortizacaoAcumulada", System.Type.GetType("System.Decimal"));
                    m_dados.Columns.Add("dSaldoDevedor", System.Type.GetType("System.Decimal"));

                    dwLinha = m_dados.NewRow();

                    dwLinha["nPrazo"] = 0;
                    dwLinha["dJuros"] = 0;
                    dwLinha["dAmortizacao"] = 0;
                    dwLinha["dJurosAcumulados"] = 0;
                    dwLinha["dAmortizacaoAcumulada"] = 0;
                    dwLinha["dSaldoDevedor"] = m_dValorFinanciado;

                    m_dados.Rows.Add(dwLinha);

                    for (nIndex = 1; nIndex <= Convert.ToDouble(txtPrazo.Text); nIndex++)
                    {
                        dwLinha = m_dados.NewRow();

                        dwLinha["nPrazo"] = nIndex;
                        dwLinha["dJuros"] = Juros(nIndex);
                        dwLinha["dAmortizacao"] = Amortizacao(nIndex);
                        dwLinha["dJurosAcumulados"] = JurosAcumulados(nIndex);
                        dwLinha["dAmortizacaoAcumulada"] = AmortizacaoAcumulada(nIndex);
                        dwLinha["dSaldoDevedor"] = SaldoDevedor(nIndex);

                        m_dados.Rows.Add(dwLinha);
                    }

                    PreencherTabela();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private DataTableGrids.CellColumnTemplate[] FormatarTabela(DataTableGrids.CellColumnTemplate[] pCellColumnTemplate)
            {
                Headers.Common oCampo = null;
                DataModel.DataModelBase oEditor;
                NumberTypeConverter oNumberConverter = null;

                DataTableGrids.CellColumnTemplate[] oCellColumnTemplate = null;

                try
                {
                    oCampo = new Headers.Common(false);
                    oCampo.TextAlignment = ContentAlignment.MiddleRight;

                    oNumberConverter = new NumberTypeConverter(typeof(decimal));
                    oNumberConverter.Format = "###,###,##0.00";

                    oCellColumnTemplate = new DataTableGrids.CellColumnTemplate[6];

                    // 0 - Prazo
                    oCellColumnTemplate[0] = DataGridStyles.FormatarColuna(ref pCellColumnTemplate, "nPrazo", "Prazo", 0, 50, true);

                    // 1 - Juros
                    oCellColumnTemplate[1] = DataGridStyles.FormatarColuna(ref pCellColumnTemplate, "dJuros", "Juros", 1, 100, true);
                    oCellColumnTemplate[1].VisualModel = oCampo;
                    oEditor = (DataModel.DataModelBase)oCellColumnTemplate[1].DataModel;
                    oEditor.TypeConverter = oNumberConverter;

                    // 2 - Amortizacao
                    oCellColumnTemplate[2] = DataGridStyles.FormatarColuna(ref pCellColumnTemplate, "dAmortizacao", "Amortização", 2, 100, true);
                    oCellColumnTemplate[2].VisualModel = oCampo;
                    oEditor = (DataModel.DataModelBase)oCellColumnTemplate[2].DataModel;
                    oEditor.TypeConverter = oNumberConverter;

                    // 3 - JurosAcumulados
                    oCellColumnTemplate[3] = DataGridStyles.FormatarColuna(ref pCellColumnTemplate, "dJurosAcumulados", "Juros Acumulados", 3, 150, true);
                    oCellColumnTemplate[3].VisualModel = oCampo;
                    oEditor = (DataModel.DataModelBase)oCellColumnTemplate[3].DataModel;
                    oEditor.TypeConverter = oNumberConverter;

                    // 4 - dAmortizacaoAcumulada
                    oCellColumnTemplate[4] = DataGridStyles.FormatarColuna(ref pCellColumnTemplate, "dAmortizacaoAcumulada", "Amortização Acumulada", 4, 150, true);
                    oCellColumnTemplate[4].VisualModel = oCampo;
                    oEditor = (DataModel.DataModelBase)oCellColumnTemplate[4].DataModel;
                    oEditor.TypeConverter = oNumberConverter;

                    // 5 - dSaldoDevedor
                    oCellColumnTemplate[5] = DataGridStyles.FormatarColuna(ref pCellColumnTemplate, "dSaldoDevedor", "Saldo Devedor", 5, 150, true);
                    oCellColumnTemplate[5].VisualModel = oCampo;
                    oEditor = (DataModel.DataModelBase)oCellColumnTemplate[5].DataModel;
                    oEditor.TypeConverter = oNumberConverter;

                    return oCellColumnTemplate;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    oCellColumnTemplate = null;
                }
            }

            private void PreencherTabela()
            {
                Headers.Header oTitulo = null;
                DataTableGrids.CellColumnTemplate[] oTemplateColumns;

                DataColumn[] orwPrimaKey = null;

                try
                {
                    m_dados.DefaultView.AllowNew = false;
                    m_dados.DefaultView.AllowEdit = false;
                    m_dados.DefaultView.AllowDelete = false;

                    // Defini PrimaryKeys
                    orwPrimaKey = new DataColumn[1];
                    orwPrimaKey[0] = m_dados.Columns["nPrazo"];
                    m_dados.PrimaryKey = orwPrimaKey;
                    m_dados.TableName = "Financiamento";

                    // Configura a aparência dos cabeçalhos
                    oTitulo = new Headers.Header(false);
                    oTitulo.BackColor = this.BackColor;
                    oTitulo.BackColor = this.BackColor;
                    oTitulo.FocusBackColor = this.BackColor;
                    oTitulo.HeaderLightBorderWidth = 1;
                    oTitulo.HeaderShadowBorderWidth = 1;
                    oTitulo.FocusBackColor = this.BackColor;
                    oTitulo.TextAlignment = ContentAlignment.MiddleCenter;

                    // Captura as colunas, e determina quais serão apresentadas
                    oTemplateColumns = DataTableGrids.GetColumnsFromDataTable(m_dados, false, "");
                    oTemplateColumns = FormatarTabela(oTemplateColumns);

                    // Relaicona o DataTable com o DatGrid
                    dtgTabelaPrice.LoadDataSource(m_dados, DataTableGrids.GridDataTableStyle.Default, oTemplateColumns, oTitulo, oTitulo);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    oTitulo = null;
                    oTemplateColumns = null;
                    orwPrimaKey = null;
                }
            }

            private double Exponencial(double pBase, double pExpoente)
            {
                double dResultado;
                try
                {
                    dResultado = Math.Exp(pExpoente * Math.Log(pBase));

                    return dResultado; 
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private double FVA(double pTaxaJuros, int pPrazo)
            {
                double dTxJuros;
                double dNumerador;
                double dNumerando;
                double dResultado;

                try
                {
                    dTxJuros = (1 + pTaxaJuros);
                    
                    dNumerador = Exponencial(1 + pTaxaJuros, pPrazo) - 1;
                    dNumerando = Exponencial(1 + pTaxaJuros, pPrazo) * pTaxaJuros;

                    dResultado = dNumerador / dNumerando;

                    return dResultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private void PeriodoAcumulado()
            {
                int nPrazoInicial;
                int nPrazoFinal;

                try
                {
                    nPrazoInicial = Convert.ToInt32(txtPrazoInicial.Text);
                    nPrazoFinal = Convert.ToInt32(txtPrazoFinal.Text);

                    if (nPrazoInicial == 0 || nPrazoFinal == 0)
                    {
                        return;
                    }

                    txtJurosAcumulado.Text = JurosAcumulados(nPrazoInicial-1, nPrazoFinal).ToString("###,###,##0.00");
                    txtAmortizacaoAcumulada.Text = AmortizacaoAcumulada(nPrazoInicial - 1, nPrazoFinal).ToString("###,###,##0.00");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private double Juros(int pPrazo)
            {
                double dJuros;

                try
                {
                    dJuros = m_dTaxaJuros * m_dParcela * FVA(m_dTaxaJuros, m_nPrazo - pPrazo + 1);

                    return dJuros;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private double JurosAcumulados(int pPrazo)
            {
                double dJuros;

                try
                {
                    dJuros = m_dParcela * (pPrazo - FVA(m_dTaxaJuros, m_nPrazo) + FVA(m_dTaxaJuros, m_nPrazo - pPrazo));

                    return dJuros;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private double JurosAcumulados(int pPrazoInicial, int pPrazoFinal)
            {
                double dJuros;

                try
                {
                    dJuros = m_dParcela * ((pPrazoFinal - pPrazoInicial) - FVA(m_dTaxaJuros, m_nPrazo - pPrazoInicial) + FVA(m_dTaxaJuros, m_nPrazo - pPrazoInicial - (pPrazoFinal - pPrazoInicial)));

                    return dJuros;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private double Amortizacao(int pPrazo)
            {
                double dAmortizacao;

                try
                {
                    dAmortizacao = (m_dParcela - m_dTaxaJuros * m_dValorFinanciado) * (Exponencial(1 + m_dTaxaJuros, (pPrazo - 1)));

                    return dAmortizacao;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private double AmortizacaoAcumulada(int pPrazo)
            {
                double dAmortizacao;

                try
                {
                    dAmortizacao = m_dParcela * (FVA(m_dTaxaJuros, m_nPrazo) - FVA(m_dTaxaJuros, m_nPrazo - pPrazo));

                    return dAmortizacao;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private double AmortizacaoAcumulada(int pPrazoInicial, int pPrazoFinal)
            {
                double dAmortizacao;

                try
                {
                    dAmortizacao = m_dParcela * (FVA(m_dTaxaJuros, m_nPrazo - pPrazoInicial) - FVA(m_dTaxaJuros, m_nPrazo - pPrazoInicial - (pPrazoFinal - pPrazoInicial)));

                    return dAmortizacao;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            private double SaldoDevedor(int pPrazo)
            {
                double dSaldoDevedor;

                try
                {
                    dSaldoDevedor = m_dParcela * FVA(m_dTaxaJuros, m_nPrazo - pPrazo);

                    return dSaldoDevedor;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        #endregion
    }
}