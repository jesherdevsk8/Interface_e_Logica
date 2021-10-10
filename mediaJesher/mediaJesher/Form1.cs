using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaJesher
{
    public partial class frm_media : Form
    {
        public frm_media()
        {
            InitializeComponent();
        }

        private void Frm_media_Load(object sender, EventArgs e)
        {
            txtBim01.Text = "0";
            txtBim02.Text = "0";
            txtBim03.Text = "0";
            txtBim04.Text = "0";
            lblMedia.Visible = false;
            lblResultadoSituacao.Visible = false;
            lblMediaMostrar.Visible = false;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Single nota01 = 0, nota02 = 0, nota03 = 0, nota04 = 0, media = 0;

            nota01 = Convert.ToSingle(txtBim01.Text);
            nota02 = Convert.ToSingle(txtBim02.Text);
            nota03 = Convert.ToSingle(txtBim03.Text);
            nota04 = Convert.ToSingle(txtBim04.Text);

            media = (nota01 + nota02 + nota03 + nota04) / 4;           
            

            if (media < 5)
            {
                lblMedia.Text = Convert.ToString(media);
                lblMedia.Visible = true;                
                lblResultadoSituacao.Text = "REPROVADO";
                lblMediaMostrar.Text = "I";
                lblResultadoSituacao.Visible = true;               
            }

            else
            {
                lblMedia.Text = Convert.ToString(media);
                lblMedia.Visible = true;
                lblResultadoSituacao.Text = "APROVADO";
                lblResultadoSituacao.Visible = true;

                if (media >= 5 && media < 7)
                {
                    lblMediaMostrar.Visible = true;
                    lblMediaMostrar.Text = "R";
                }
                if (media >= 7 && media < 8)
                {
                    lblMediaMostrar.Visible = true;
                    lblMediaMostrar.Text = "B";
                }
                if (media >= 8 && media <= 10)
                {
                    lblMediaMostrar.Visible = true;
                    lblMediaMostrar.Text = "MB";
                }               

                else                
                {
                    lblMediaMostrar.Visible = false;
                    lblMedia.Visible = false;
                    lblResultadoSituacao.Visible = false;                   
                }
                    
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtBim01.Text = "";
            txtBim02.Text = "";
            txtBim03.Text = "";
            txtBim04.Text = "";
            lblMedia.Visible = false;
            lblResultadoSituacao.Visible = false;
            lblMediaMostrar.Visible = false;

            /* Outro método que pode ser feito
             * txtNome.Clear();
             * txtBim01.Clear();
             * txtBim02.Clear();
             * txtBim03.Clear();
             * txtBim04.Clear();
             */
        }
    }
}
