using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;  // <--- Biblioteca adicionada

namespace Jogo_de_palavras
{
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        
        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close(); Outra maneira de fechar
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtigreja.Text = "";
            txtescola.Text = "";
            txtsalada.Text = "";
            txtsorvete.Text = "";
            txtsapo.Text = "";
            txtalface.Text = "";
            txttomate.Text = "";
            txtervilha.Text = "";
                                                             // Aqui coloque o local de onde está as imagens no teu dispositivo
            pcbigreja.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbescola.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbsalada.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbsorvete.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbsapo.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbalface.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbtomate.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbervilha.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
        }

        private void btnconcluido_click(object sender, EventArgs e)
        {
            string r01, r02, r03, r04, r05, r06, r07, r08;
            


            r01 = txtigreja.Text;            

            r02 = txtescola.Text;            

            r03 = txtsalada.Text;          

            r04 = txtsorvete.Text;           

            r05 = txtsapo.Text;           

            r06 = txtalface.Text;                 

            r07 = txttomate.Text;            

            r08 = txtervilha.Text;


            if (txtigreja.Text == "e" || txtigreja.Text == "E")
            {
                pcbigreja.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/certo.png");
            }
            else 
            {
                pcbigreja.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/erro.png");
            }

            if (txtescola.Text == "o" || txtescola.Text ==  "O" )
            {
               pcbescola.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/certo.png");
            }
            else
            {
                pcbescola.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/erro.png");
            }

            if (txtsalada.Text == "a" || txtsalada.Text == "A")
            {
                pcbsalada.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/certo.png");
            }
            else
            {
                pcbsalada.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/erro.png");
            }

            if (txtsorvete.Text == "e" || txtsorvete.Text == "E")
            {
                pcbsorvete.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/TP - TOF/Abril/aula 27.04.2021/certo.png");
            }
            else
            {
                pcbsorvete.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/erro.png");
            }

            if (txtsapo.Text == "p" || txtsapo.Text == "P")
            {
                pcbsapo.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/certo.png");
            }
            else
            {
                pcbsapo.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/erro.png");
            }

            if (txtalface.Text == "l" || txtalface.Text == "L")
            {
                pcbalface.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/certo.png");
            }
            else
            {
                pcbalface.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º ModuloTP - TOF/Abril/aula 27.04.2021/erro.png");
            }

            if (txttomate.Text == "a" || txttomate.Text == "A")
            {
                pcbtomate.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/certo.png");
            }
            else
            {
                pcbtomate.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/erro.png");
            }

            if (txtervilha.Text == "i" || txtervilha.Text == "I")
            {
                pcbervilha.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/certo.png");
            }
            else
            {
                pcbervilha.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/erro.png");
            }


        }

        private void frm_load(object sender, EventArgs e)
        {
            pcb1.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/hacker.png");
            pcb2.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/hacker.png");

            pcbigreja.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbescola.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbsalada.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png"); 
            pcbsorvete.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbsapo.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbalface.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbtomate.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");
            pcbervilha.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Abril/aula 27.04.2021/interrogacao.png");

        }


    }
}
