
namespace Tesla
{
    partial class FormTesla
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
            this.lblcarrental = new System.Windows.Forms.Label();
            this.lblalugue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbmodels = new System.Windows.Forms.PictureBox();
            this.lblvalorhora = new System.Windows.Forms.Label();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.checkBoxmodels = new System.Windows.Forms.CheckBox();
            this.checkBoxmodelx = new System.Windows.Forms.CheckBox();
            this.checkBoxmodel3 = new System.Windows.Forms.CheckBox();
            this.checkBoxmodely = new System.Windows.Forms.CheckBox();
            this.checkBoxcybertruck = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbmodels)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcarrental
            // 
            this.lblcarrental.AutoSize = true;
            this.lblcarrental.BackColor = System.Drawing.Color.Transparent;
            this.lblcarrental.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrental.ForeColor = System.Drawing.Color.Gold;
            this.lblcarrental.Location = new System.Drawing.Point(307, 27);
            this.lblcarrental.Name = "lblcarrental";
            this.lblcarrental.Size = new System.Drawing.Size(181, 30);
            this.lblcarrental.TabIndex = 0;
            this.lblcarrental.Text = "CarRental.com";
            // 
            // lblalugue
            // 
            this.lblalugue.AutoSize = true;
            this.lblalugue.BackColor = System.Drawing.Color.Transparent;
            this.lblalugue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalugue.ForeColor = System.Drawing.Color.LightYellow;
            this.lblalugue.Location = new System.Drawing.Point(355, 62);
            this.lblalugue.Name = "lblalugue";
            this.lblalugue.Size = new System.Drawing.Size(81, 13);
            this.lblalugue.TabIndex = 1;
            this.lblalugue.Text = "Alugue o seu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tesla.Properties.Resources.teslalogo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tesla.Properties.Resources.teslalogo;
            this.pictureBox2.Location = new System.Drawing.Point(712, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pcbmodels
            // 
            this.pcbmodels.BackColor = System.Drawing.Color.Transparent;
            this.pcbmodels.Location = new System.Drawing.Point(215, 243);
            this.pcbmodels.Name = "pcbmodels";
            this.pcbmodels.Size = new System.Drawing.Size(196, 153);
            this.pcbmodels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbmodels.TabIndex = 4;
            this.pcbmodels.TabStop = false;
            // 
            // lblvalorhora
            // 
            this.lblvalorhora.AutoSize = true;
            this.lblvalorhora.BackColor = System.Drawing.Color.Transparent;
            this.lblvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorhora.ForeColor = System.Drawing.Color.LightGray;
            this.lblvalorhora.Location = new System.Drawing.Point(424, 254);
            this.lblvalorhora.Name = "lblvalorhora";
            this.lblvalorhora.Size = new System.Drawing.Size(81, 16);
            this.lblvalorhora.TabIndex = 6;
            this.lblvalorhora.Text = "Valor/hora";
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorhora.Location = new System.Drawing.Point(420, 273);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(89, 26);
            this.txtvalorhora.TabIndex = 7;
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Location = new System.Drawing.Point(534, 273);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(67, 26);
            this.txthora.TabIndex = 9;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.LightGray;
            this.lblhora.Location = new System.Drawing.Point(541, 254);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(50, 16);
            this.lblhora.TabIndex = 8;
            this.lblhora.Text = "Horas";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(420, 366);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(96, 26);
            this.txttotal.TabIndex = 11;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.LightGray;
            this.lbltotal.Location = new System.Drawing.Point(421, 347);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(90, 16);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "Total/pagar";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalcular.ForeColor = System.Drawing.Color.GhostWhite;
            this.btncalcular.Location = new System.Drawing.Point(420, 310);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(183, 27);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // checkBoxmodels
            // 
            this.checkBoxmodels.AutoSize = true;
            this.checkBoxmodels.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxmodels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxmodels.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxmodels.Location = new System.Drawing.Point(157, 155);
            this.checkBoxmodels.Name = "checkBoxmodels";
            this.checkBoxmodels.Size = new System.Drawing.Size(72, 17);
            this.checkBoxmodels.TabIndex = 13;
            this.checkBoxmodels.Text = "Model S";
            this.checkBoxmodels.UseVisualStyleBackColor = false;
            this.checkBoxmodels.CheckedChanged += new System.EventHandler(this.checkBoxmodels_CheckedChanged);
            // 
            // checkBoxmodelx
            // 
            this.checkBoxmodelx.AutoSize = true;
            this.checkBoxmodelx.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxmodelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxmodelx.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxmodelx.Location = new System.Drawing.Point(259, 155);
            this.checkBoxmodelx.Name = "checkBoxmodelx";
            this.checkBoxmodelx.Size = new System.Drawing.Size(72, 17);
            this.checkBoxmodelx.TabIndex = 14;
            this.checkBoxmodelx.Text = "Model X";
            this.checkBoxmodelx.UseVisualStyleBackColor = false;
            this.checkBoxmodelx.CheckedChanged += new System.EventHandler(this.checkBoxmodelx_CheckedChanged);
            // 
            // checkBoxmodel3
            // 
            this.checkBoxmodel3.AutoSize = true;
            this.checkBoxmodel3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxmodel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxmodel3.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxmodel3.Location = new System.Drawing.Point(358, 155);
            this.checkBoxmodel3.Name = "checkBoxmodel3";
            this.checkBoxmodel3.Size = new System.Drawing.Size(71, 17);
            this.checkBoxmodel3.TabIndex = 15;
            this.checkBoxmodel3.Text = "Model 3";
            this.checkBoxmodel3.UseVisualStyleBackColor = false;
            this.checkBoxmodel3.CheckedChanged += new System.EventHandler(this.checkBoxmodel3_CheckedChanged);
            // 
            // checkBoxmodely
            // 
            this.checkBoxmodely.AutoSize = true;
            this.checkBoxmodely.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxmodely.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxmodely.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxmodely.Location = new System.Drawing.Point(462, 155);
            this.checkBoxmodely.Name = "checkBoxmodely";
            this.checkBoxmodely.Size = new System.Drawing.Size(72, 17);
            this.checkBoxmodely.TabIndex = 16;
            this.checkBoxmodely.Text = "Model Y";
            this.checkBoxmodely.UseVisualStyleBackColor = false;
            this.checkBoxmodely.CheckedChanged += new System.EventHandler(this.checkBoxmodely_CheckedChanged);
            // 
            // checkBoxcybertruck
            // 
            this.checkBoxcybertruck.AutoSize = true;
            this.checkBoxcybertruck.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxcybertruck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxcybertruck.ForeColor = System.Drawing.Color.Crimson;
            this.checkBoxcybertruck.Location = new System.Drawing.Point(570, 155);
            this.checkBoxcybertruck.Name = "checkBoxcybertruck";
            this.checkBoxcybertruck.Size = new System.Drawing.Size(95, 17);
            this.checkBoxcybertruck.TabIndex = 17;
            this.checkBoxcybertruck.Text = "Cyber Truck";
            this.checkBoxcybertruck.UseVisualStyleBackColor = false;
            this.checkBoxcybertruck.CheckedChanged += new System.EventHandler(this.checkBoxcybertruck_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Crimson;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnReset.Location = new System.Drawing.Point(523, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 26);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(156, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "R$ 80,3 hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(258, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "R$ 77,4 hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(357, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "R$ 97,1 hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(461, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "R$ 85,8 hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(574, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "R$ 142,4 hora";
            // 
            // FormTesla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tesla.Properties.Resources.road2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.checkBoxcybertruck);
            this.Controls.Add(this.checkBoxmodely);
            this.Controls.Add(this.checkBoxmodel3);
            this.Controls.Add(this.checkBoxmodelx);
            this.Controls.Add(this.checkBoxmodels);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.lblvalorhora);
            this.Controls.Add(this.pcbmodels);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblalugue);
            this.Controls.Add(this.lblcarrental);
            this.Name = "FormTesla";
            this.Text = "Tesla Corp.";
            this.Load += new System.EventHandler(this.FormTesla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbmodels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcarrental;
        private System.Windows.Forms.Label lblalugue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbmodels;
        private System.Windows.Forms.Label lblvalorhora;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.CheckBox checkBoxmodels;
        private System.Windows.Forms.CheckBox checkBoxmodelx;
        private System.Windows.Forms.CheckBox checkBoxmodel3;
        private System.Windows.Forms.CheckBox checkBoxmodely;
        private System.Windows.Forms.CheckBox checkBoxcybertruck;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

