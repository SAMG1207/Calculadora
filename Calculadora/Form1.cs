using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operador = "";
        bool resultadoFinal = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Tab)
            {
                return; // No bloquear estas teclas
            }
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                return; // Permitir estos caracteres
            }
            e.Handled = true;
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            resultadoFinal = false;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            bool firstNumberisNegative = txtOutput.Text.Length == 2 && txtOutput.Text.StartsWith("-");
            if (txtOutput.Text.Length == 1 || firstNumberisNegative)
            {
                txtOutput.Text = "";
                resultadoFinal = false;
            }
            else
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1); // Ir borrando de uno en uno
            }
        }

        private void add_number(object sender, EventArgs e)
        {
           Button button = sender as Button;
            if(resultadoFinal == false)
            {
                if (button != null) { txtOutput.Text += button.Text; }
            }
            else
            {
                txtOutput.Text = "";
                resultadoFinal = false;
                if (button != null) { txtOutput.Text += button.Text; }
            }
            
        }

        private void add_point(object sender, EventArgs e)
        {
            string[] partes = txtOutput.Text.Split(" ");
            if(partes.Length > 0 )
            {
                string ultimaParte = partes[^1]; 
                if (!ultimaParte.Contains("."))
                {
                    txtOutput.Text += ".";
                }
            }
            else
            {
                txtOutput.Text += "0.";
            }
        }

        private void prc_btn_Click(Object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                txtOutput.Text = "ERROR";
            }

        }

        private void add_oper(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (resultadoFinal == false)
            {
                bool onlyNumbersAndPoints = txtOutput.Text.All(c => char.IsDigit(c) || c == '.' || c == '-');

                if (txtOutput.Text.Length == 0 && button.Text == "-")
                {
                    txtOutput.Text = "-"; // Agregar signo negativo al principio
                }
                else if (txtOutput.Text.Length == 0 && button.Text != "-")
                {
                    txtOutput.Text = "";
                }
                // Si el texto tiene algo y presionamos "-", y el último carácter es un operador (espacio)
                else if (txtOutput.Text.Length > 0 && button.Text == "-" && txtOutput.Text.EndsWith(" "))
                {
                    txtOutput.Text += "-"; // Si hay un operador y el usuario presiona "-", lo agregamos
                }
                // Si ya hay un número o punto en la pantalla, agregamos el operador con espacios para separar
                else if (txtOutput.Text.Length > 0 && onlyNumbersAndPoints && button != null)
                {
                    txtOutput.Text += " " + button.Text + " "; // Agregar el operador (por ejemplo: "5 +")
                }
                // Si no hay nada válido para agregar, borra la pantalla y permite iniciar de nuevo
                else
                {
                    txtOutput.Text = "";
                    resultadoFinal = false;

                    if (button != null)
                    {
                        txtOutput.Text += button.Text; // Agregar el operador
                    }
                }
            }
        }




        private void equals(Object sender, EventArgs e)
        {
            string[] partes = txtOutput.Text.Split(" ");
            if (partes.Length == 3 )
            {
                try
                {
                    double num1 = double.Parse(partes[0], new CultureInfo("en-US"));
                    operador = partes[1];
                    double num2 = double.Parse(partes[2], new CultureInfo("en-US"));

                    switch (operador)
                    {
                        case "+":
                            txtOutput.Text = (num1 + num2).ToString();
                            resultadoFinal = true;
                            break;

                        case "-":
                            txtOutput.Text= (num1 - num2).ToString();
                            resultadoFinal = true;
                            break;
                        
                        case "X":
                            txtOutput.Text=(num1 * num2).ToString();
                            resultadoFinal = true;
                            break;

                        case "/":
                            if (num2 != 0)
                            {
                                txtOutput.Text = (num1 / num2).ToString();
                                resultadoFinal = true;
                                
                            }
                            else
                            {

                                txtOutput.Text = "DIVISION BY ZERO";
                                resultadoFinal = false;
                                var timer = new System.Windows.Forms.Timer();
                                timer.Interval = 500;
                                timer.Tick += (s, args) =>
                                {
                                    txtOutput.Text = ""; // Restablece el texto a "0"
                                    timer.Stop();         // Detiene el Timer para evitar ejecuciones futuras
                                    timer.Dispose();      // Libera los recursos del Timer
                                };

                                timer.Start();
                                
                            }
                            break;
                        
                        default:
                            txtOutput.Text = "";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "ERROR";
                }
            }
        }
    }
}

