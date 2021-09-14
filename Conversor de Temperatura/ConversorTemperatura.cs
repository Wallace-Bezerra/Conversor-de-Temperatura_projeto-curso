using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Temperatura
{
    public partial class ConversorTemperatura : Form
    {
        public ConversorTemperatura()
        {
            InitializeComponent();
        }

        private void button_RealizarConversao_Click(object sender, EventArgs e)
        {
            double Resultado_ConverterCtoF, Resultado_ConverterFtoC;



            // verifica os campos vazios
            if (Convert.ToString(textBox_Temp1.Text) == "" || comboBox_1Temp.Text == "" || comboBox_2Temp.Text == "")
            {
                MessageBox.Show("Digite Corretamente!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if(comboBox_1Temp.Text == "Celsius" && comboBox_2Temp.Text == "Celsius" || comboBox_1Temp.Text == "Fahrenheit" && comboBox_2Temp.Text == "Fahrenheit")
            else if (comboBox_1Temp.Text == comboBox_2Temp.Text)
            {
                    button_RealizarConversao.Enabled = false;
                    MessageBox.Show("Temperaturas Iguais!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_RealizarConversao.Enabled = true;
            }
            
           else if (comboBox_1Temp.Text == "Celsius" && comboBox_2Temp.Text == "Fahrenheit")

           {
                    
                    Resultado_ConverterCtoF = Convert.ToDouble(textBox_Temp1.Text) * 1.8 + 32;
                    textBox_Resultado.Text = Convert.ToString(Resultado_ConverterCtoF.ToString("F2") + " F° ");

           }
                    else if (comboBox_1Temp.Text == "Fahrenheit" && comboBox_2Temp.Text == "Celsius")
                    {
                        Resultado_ConverterFtoC = (Convert.ToDouble(textBox_Temp1.Text) - 32) / 1.8;
                        textBox_Resultado.Text = Convert.ToString(Resultado_ConverterFtoC.ToString("F2")+ " C° ");
                        
                    }

               
            
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            label_Letra_Temperatura.Text = string.Empty;


            foreach(Control componente in this.Controls)
            { 
                if(componente is TextBox)
                {
                    (componente as TextBox).Clear();
                }
                else if (componente is ComboBox)
                {
                    (componente as ComboBox).SelectedIndex = -1;
                }                        
                
            }            
        }

        private void comboBox_1Temp_SelectionChangeCommitted(object sender, EventArgs e)
        {
           if(comboBox_1Temp.Text == "Celsius" )
            {
                label_Letra_Temperatura.Text = "C°";
            }
           else if (comboBox_1Temp.Text == "Fahrenheit")
            {
                label_Letra_Temperatura.Text = "F°";
            }
           else
            {
                label_Letra_Temperatura.Text = string.Empty;
            }
        }
    }
}
