using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Jesher
{
    public partial class frmControle : Form
    {
        public frmControle()
        {
            InitializeComponent();
        }    
        private void frmControle_Load(object sender, EventArgs e)
        {
            txtsalario.Text = "0";
            txthorasextras.Text = "0";
            txtoutros.Text = "0";
            txtsupermercado.Text = "0";
            txtfarmacia.Text = "0";
            txtcombustivel.Text = "0";
        }

        private void btnCalcular_click(object sender, EventArgs e)
        {
            double salario, horasextras, outros, total1;

            salario = Convert.ToDouble(txtsalario.Text);
            horasextras = Convert.ToDouble(txthorasextras.Text);
            outros = Convert.ToDouble(txtoutros.Text);

            total1 = (salario + horasextras + outros);

            txttotalreceitas.Text = Convert.ToString(total1);

        }

        private void btnCalcular2_click(object sender, EventArgs e)
        {
            double supermercado, farmacia, combustivel, total2;

            supermercado = Convert.ToDouble(txtsupermercado.Text);
            farmacia = Convert.ToDouble(txtfarmacia.Text);
            combustivel = Convert.ToDouble(txtcombustivel.Text);

            total2 = (supermercado + farmacia + combustivel);

            txttotaldespesas.Text = Convert.ToString(total2);
        }

        private void btnCalcular3_click(object sender, EventArgs e)
        {
            double totalreceitas, totaldespesas, total3;

            totalreceitas = Convert.ToDouble(txttotalreceitas.Text);
            totaldespesas = Convert.ToDouble(txttotaldespesas.Text);

            total3 = (totalreceitas - totaldespesas);

            txtlucromensal.Text = Convert.ToString(total3);
        }

        private void btnLimpar_click(object sender, EventArgs e)
        {
            txtsalario.Text = "";
            txthorasextras.Text = "";
            txtoutros.Text = "";
            txttotalreceitas.Text = "";
            txtsupermercado.Text = "";
            txtfarmacia.Text = "";
            txtcombustivel.Text = "";
            txttotaldespesas.Text = "";
            txtlucromensal.Text = "";
        }
    }
}
