
namespace Projeto_Jesher
{
    partial class frmControle
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblhoras = new System.Windows.Forms.Label();
            this.txthorasextras = new System.Windows.Forms.TextBox();
            this.lbloutros = new System.Windows.Forms.Label();
            this.txtoutros = new System.Windows.Forms.TextBox();
            this.lbltotalreceitas = new System.Windows.Forms.Label();
            this.txttotalreceitas = new System.Windows.Forms.TextBox();
            this.lblsupermercado = new System.Windows.Forms.Label();
            this.txtsupermercado = new System.Windows.Forms.TextBox();
            this.lbltotaldespesas = new System.Windows.Forms.Label();
            this.txttotaldespesas = new System.Windows.Forms.TextBox();
            this.lblfarmacia = new System.Windows.Forms.Label();
            this.txtfarmacia = new System.Windows.Forms.TextBox();
            this.btncalcularsituacaomensal = new System.Windows.Forms.Button();
            this.lblcombustivel = new System.Windows.Forms.Label();
            this.txtcombustivel = new System.Windows.Forms.TextBox();
            this.btncalculardespesas = new System.Windows.Forms.Button();
            this.btncalcularreceitas = new System.Windows.Forms.Button();
            this.txtlucromensal = new System.Windows.Forms.TextBox();
            this.lblsituacaomensal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(95, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECEITAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(527, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESPESAS";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.BackColor = System.Drawing.Color.Transparent;
            this.lblsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblsalario.Location = new System.Drawing.Point(33, 105);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(93, 25);
            this.lblsalario.TabIndex = 2;
            this.lblsalario.Text = "Salário:";
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(194, 99);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(135, 31);
            this.txtsalario.TabIndex = 3;
            // 
            // lblhoras
            // 
            this.lblhoras.AutoSize = true;
            this.lblhoras.BackColor = System.Drawing.Color.Transparent;
            this.lblhoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoras.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblhoras.Location = new System.Drawing.Point(33, 148);
            this.lblhoras.Name = "lblhoras";
            this.lblhoras.Size = new System.Drawing.Size(155, 25);
            this.lblhoras.TabIndex = 4;
            this.lblhoras.Text = "Horas Extras:";
            // 
            // txthorasextras
            // 
            this.txthorasextras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorasextras.Location = new System.Drawing.Point(194, 142);
            this.txthorasextras.Name = "txthorasextras";
            this.txthorasextras.Size = new System.Drawing.Size(135, 31);
            this.txthorasextras.TabIndex = 5;
            // 
            // lbloutros
            // 
            this.lbloutros.AutoSize = true;
            this.lbloutros.BackColor = System.Drawing.Color.Transparent;
            this.lbloutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutros.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbloutros.Location = new System.Drawing.Point(33, 189);
            this.lbloutros.Name = "lbloutros";
            this.lbloutros.Size = new System.Drawing.Size(89, 25);
            this.lbloutros.TabIndex = 6;
            this.lbloutros.Text = "Outros:";
            // 
            // txtoutros
            // 
            this.txtoutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoutros.Location = new System.Drawing.Point(194, 183);
            this.txtoutros.Name = "txtoutros";
            this.txtoutros.Size = new System.Drawing.Size(135, 31);
            this.txtoutros.TabIndex = 7;
            // 
            // lbltotalreceitas
            // 
            this.lbltotalreceitas.AutoSize = true;
            this.lbltotalreceitas.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalreceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalreceitas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltotalreceitas.Location = new System.Drawing.Point(106, 255);
            this.lbltotalreceitas.Name = "lbltotalreceitas";
            this.lbltotalreceitas.Size = new System.Drawing.Size(137, 37);
            this.lbltotalreceitas.TabIndex = 8;
            this.lbltotalreceitas.Text = "TOTAL:";
            // 
            // txttotalreceitas
            // 
            this.txttotalreceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalreceitas.Location = new System.Drawing.Point(108, 295);
            this.txttotalreceitas.Name = "txttotalreceitas";
            this.txttotalreceitas.Size = new System.Drawing.Size(135, 31);
            this.txttotalreceitas.TabIndex = 9;
            // 
            // lblsupermercado
            // 
            this.lblsupermercado.AutoSize = true;
            this.lblsupermercado.BackColor = System.Drawing.Color.Transparent;
            this.lblsupermercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupermercado.ForeColor = System.Drawing.Color.Red;
            this.lblsupermercado.Location = new System.Drawing.Point(428, 105);
            this.lblsupermercado.Name = "lblsupermercado";
            this.lblsupermercado.Size = new System.Drawing.Size(171, 25);
            this.lblsupermercado.TabIndex = 10;
            this.lblsupermercado.Text = "Supermercado:";
            // 
            // txtsupermercado
            // 
            this.txtsupermercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupermercado.Location = new System.Drawing.Point(619, 99);
            this.txtsupermercado.Name = "txtsupermercado";
            this.txtsupermercado.Size = new System.Drawing.Size(135, 31);
            this.txtsupermercado.TabIndex = 11;
            // 
            // lbltotaldespesas
            // 
            this.lbltotaldespesas.AutoSize = true;
            this.lbltotaldespesas.BackColor = System.Drawing.Color.Transparent;
            this.lbltotaldespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldespesas.ForeColor = System.Drawing.Color.Red;
            this.lbltotaldespesas.Location = new System.Drawing.Point(526, 255);
            this.lbltotaldespesas.Name = "lbltotaldespesas";
            this.lbltotaldespesas.Size = new System.Drawing.Size(137, 37);
            this.lbltotaldespesas.TabIndex = 12;
            this.lbltotaldespesas.Text = "TOTAL:";
            // 
            // txttotaldespesas
            // 
            this.txttotaldespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldespesas.Location = new System.Drawing.Point(528, 295);
            this.txttotaldespesas.Name = "txttotaldespesas";
            this.txttotaldespesas.Size = new System.Drawing.Size(135, 31);
            this.txttotaldespesas.TabIndex = 13;
            // 
            // lblfarmacia
            // 
            this.lblfarmacia.AutoSize = true;
            this.lblfarmacia.BackColor = System.Drawing.Color.Transparent;
            this.lblfarmacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfarmacia.ForeColor = System.Drawing.Color.Red;
            this.lblfarmacia.Location = new System.Drawing.Point(428, 145);
            this.lblfarmacia.Name = "lblfarmacia";
            this.lblfarmacia.Size = new System.Drawing.Size(116, 25);
            this.lblfarmacia.TabIndex = 15;
            this.lblfarmacia.Text = "Farmácia:";
            // 
            // txtfarmacia
            // 
            this.txtfarmacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfarmacia.Location = new System.Drawing.Point(619, 139);
            this.txtfarmacia.Name = "txtfarmacia";
            this.txtfarmacia.Size = new System.Drawing.Size(135, 31);
            this.txtfarmacia.TabIndex = 16;
            // 
            // btncalcularsituacaomensal
            // 
            this.btncalcularsituacaomensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcularsituacaomensal.Location = new System.Drawing.Point(302, 379);
            this.btncalcularsituacaomensal.Name = "btncalcularsituacaomensal";
            this.btncalcularsituacaomensal.Size = new System.Drawing.Size(175, 42);
            this.btncalcularsituacaomensal.TabIndex = 17;
            this.btncalcularsituacaomensal.Text = "&Calcular";
            this.btncalcularsituacaomensal.UseVisualStyleBackColor = true;
            this.btncalcularsituacaomensal.Click += new System.EventHandler(this.btnCalcular3_click);
            // 
            // lblcombustivel
            // 
            this.lblcombustivel.AutoSize = true;
            this.lblcombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblcombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcombustivel.ForeColor = System.Drawing.Color.Red;
            this.lblcombustivel.Location = new System.Drawing.Point(428, 189);
            this.lblcombustivel.Name = "lblcombustivel";
            this.lblcombustivel.Size = new System.Drawing.Size(148, 25);
            this.lblcombustivel.TabIndex = 18;
            this.lblcombustivel.Text = "Combustível:";
            // 
            // txtcombustivel
            // 
            this.txtcombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcombustivel.Location = new System.Drawing.Point(619, 183);
            this.txtcombustivel.Name = "txtcombustivel";
            this.txtcombustivel.Size = new System.Drawing.Size(135, 31);
            this.txtcombustivel.TabIndex = 19;
            // 
            // btncalculardespesas
            // 
            this.btncalculardespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculardespesas.Location = new System.Drawing.Point(579, 342);
            this.btncalculardespesas.Name = "btncalculardespesas";
            this.btncalculardespesas.Size = new System.Drawing.Size(175, 42);
            this.btncalculardespesas.TabIndex = 20;
            this.btncalculardespesas.Text = "&Calcular";
            this.btncalculardespesas.UseVisualStyleBackColor = true;
            this.btncalculardespesas.Click += new System.EventHandler(this.btnCalcular2_click);
            // 
            // btncalcularreceitas
            // 
            this.btncalcularreceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcularreceitas.Location = new System.Drawing.Point(38, 342);
            this.btncalcularreceitas.Name = "btncalcularreceitas";
            this.btncalcularreceitas.Size = new System.Drawing.Size(175, 42);
            this.btncalcularreceitas.TabIndex = 21;
            this.btncalcularreceitas.Text = "&Calcular";
            this.btncalcularreceitas.UseVisualStyleBackColor = true;
            this.btncalcularreceitas.Click += new System.EventHandler(this.btnCalcular_click);
            // 
            // txtlucromensal
            // 
            this.txtlucromensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlucromensal.Location = new System.Drawing.Point(49, 70);
            this.txtlucromensal.Name = "txtlucromensal";
            this.txtlucromensal.Size = new System.Drawing.Size(135, 31);
            this.txtlucromensal.TabIndex = 17;
            // 
            // lblsituacaomensal
            // 
            this.lblsituacaomensal.AutoSize = true;
            this.lblsituacaomensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsituacaomensal.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblsituacaomensal.Location = new System.Drawing.Point(25, 23);
            this.lblsituacaomensal.Name = "lblsituacaomensal";
            this.lblsituacaomensal.Size = new System.Drawing.Size(197, 31);
            this.lblsituacaomensal.TabIndex = 18;
            this.lblsituacaomensal.Text = "Lucro Mensal:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lblsituacaomensal);
            this.panel1.Controls.Add(this.txtlucromensal);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(271, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 126);
            this.panel1.TabIndex = 14;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Red;
            this.btnlimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlimpar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.Snow;
            this.btnlimpar.Location = new System.Drawing.Point(715, 415);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(85, 35);
            this.btnlimpar.TabIndex = 22;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnLimpar_click);
            // 
            // frmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcularreceitas);
            this.Controls.Add(this.btncalculardespesas);
            this.Controls.Add(this.txtcombustivel);
            this.Controls.Add(this.lblcombustivel);
            this.Controls.Add(this.btncalcularsituacaomensal);
            this.Controls.Add(this.txtfarmacia);
            this.Controls.Add(this.lblfarmacia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttotaldespesas);
            this.Controls.Add(this.lbltotaldespesas);
            this.Controls.Add(this.txtsupermercado);
            this.Controls.Add(this.lblsupermercado);
            this.Controls.Add(this.txttotalreceitas);
            this.Controls.Add(this.lbltotalreceitas);
            this.Controls.Add(this.txtoutros);
            this.Controls.Add(this.lbloutros);
            this.Controls.Add(this.txthorasextras);
            this.Controls.Add(this.lblhoras);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmControle";
            this.Text = "Controle de Despesas";
            this.Load += new System.EventHandler(this.frmControle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblhoras;
        private System.Windows.Forms.TextBox txthorasextras;
        private System.Windows.Forms.Label lbloutros;
        private System.Windows.Forms.TextBox txtoutros;
        private System.Windows.Forms.Label lbltotalreceitas;
        private System.Windows.Forms.TextBox txttotalreceitas;
        private System.Windows.Forms.Label lblsupermercado;
        private System.Windows.Forms.TextBox txtsupermercado;
        private System.Windows.Forms.Label lbltotaldespesas;
        private System.Windows.Forms.TextBox txttotaldespesas;
        private System.Windows.Forms.Label lblfarmacia;
        private System.Windows.Forms.TextBox txtfarmacia;
        private System.Windows.Forms.Button btncalcularsituacaomensal;
        private System.Windows.Forms.Label lblcombustivel;
        private System.Windows.Forms.TextBox txtcombustivel;
        private System.Windows.Forms.Button btncalculardespesas;
        private System.Windows.Forms.Button btncalcularreceitas;
        private System.Windows.Forms.TextBox txtlucromensal;
        private System.Windows.Forms.Label lblsituacaomensal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlimpar;
    }
}

