using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Tesla
{
    public partial class FormTesla : Form
    {
        public FormTesla()
        {
            InitializeComponent();
        }

        private void FormTesla_Load(object sender, EventArgs e)
        {
                                              // Coloque aqui o local das imagens que está no seu dispositivo
            pcbmodels.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Maio/aula 04.05.2021/interrogacao.png");
            checkBoxmodels.Checked = false;
            checkBoxmodel3.Checked = false;
            checkBoxmodelx.Checked = false;
            checkBoxmodely.Checked = false;
            checkBoxcybertruck.Checked = false;


        }


        private void checkBoxmodels_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmodels.Checked == true)
            {
                pcbmodels.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Maio/aula 04.05.2021/models.jpg");
                checkBoxmodel3.Checked = false;
                checkBoxmodelx.Checked = false;
                checkBoxmodely.Checked = false;
                checkBoxcybertruck.Checked = false;
                txtvalorhora.Text = ("");
                txthora.Text = ("");
                txttotal.Text = ("");
            }
            
        }

        private void checkBoxmodelx_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmodelx.Checked == true)
            {
                pcbmodels.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Maio/aula 04.05.2021/modelx.jpg");
                checkBoxmodel3.Checked = false;
                checkBoxmodels.Checked = false;
                checkBoxmodely.Checked = false;
                checkBoxcybertruck.Checked = false;
                txtvalorhora.Text = ("");
                txthora.Text = ("");
                txttotal.Text = ("");
            }
        }

        private void checkBoxmodel3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmodel3.Checked == true)
            {
                pcbmodels.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Maio/aula 04.05.2021/model3.jpg");
                checkBoxmodelx.Checked = false;
                checkBoxmodels.Checked = false;
                checkBoxmodely.Checked = false;
                checkBoxcybertruck.Checked = false;
                txtvalorhora.Text = ("");
                txthora.Text = ("");
                txttotal.Text = ("");
            }
        }

        private void checkBoxmodely_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmodely.Checked == true)
            {
                pcbmodels.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Maio/aula 04.05.2021/model y.jpg");
                checkBoxmodelx.Checked = false;
                checkBoxmodels.Checked = false;
                checkBoxmodel3.Checked = false;
                checkBoxcybertruck.Checked = false;
                txtvalorhora.Text = ("");
                txthora.Text = ("");
                txttotal.Text = ("");
            }
        }

        private void checkBoxcybertruck_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcybertruck.Checked == true)
            {
                pcbmodels.Image = System.Drawing.Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Maio/aula 04.05.2021/CyberTruck.jpg");
                checkBoxmodelx.Checked = false;
                checkBoxmodels.Checked = false;
                checkBoxmodel3.Checked = false;
                checkBoxmodely.Checked = false;
                txtvalorhora.Text = ("");
                txthora.Text = ("");
                txttotal.Text = ("");
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double Valor_Hora = double.Parse(txtvalorhora.Text);
            double Hora = double.Parse(txthora.Text);
            double Total;

            Total = Valor_Hora * Hora;

            txttotal.Text = Convert.ToString(Total);

           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pcbmodels.Image = Image.FromFile("C:/Users/Jesher/Desktop/ETEC - Desen. sistemas/1º Modulo/TP - TOF/Maio/aula 04.05.2021/interrogacao.png");
            checkBoxmodels.Checked = false;
            checkBoxmodel3.Checked = false;
            checkBoxmodelx.Checked = false;
            checkBoxmodely.Checked = false;
            checkBoxcybertruck.Checked = false;
            txtvalorhora.Text = ("");
            txthora.Text = ("");
            txttotal.Text = ("");
        }
    }
}
