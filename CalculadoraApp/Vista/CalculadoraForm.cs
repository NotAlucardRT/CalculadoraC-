using System;
using System.Drawing;
using System.Windows.Forms;
using CalculadoraApp.Controlador;
using CalculadoraApp.Modelo;

namespace CalculadoraApp.Vista
{
    public class CalculadoraForm : Form
    {
        private TextBox txtA;
        private TextBox txtB;
        private Label lblResultado;
        private Button btnSumar, btnRestar, btnMultiplicar, btnDividir;
        private CalculadoraControlador controller;

        public CalculadoraForm()
        {
            controller = new CalculadoraControlador();
            InicializarComponentes();
            EstiloVentana();
        }

        private void EstiloVentana()
        {
            this.Text = "Calculadora";
            this.Size = new Size(400, 300);
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 12);
        }

        private void InicializarComponentes()
        {
            txtA = new TextBox
            {
                Location = new Point(30, 30),
                Width = 320,
                Font = new Font("Segoe UI", 14),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White
            };

            txtB = new TextBox
            {
                Location = new Point(30, 70),
                Width = 320,
                Font = new Font("Segoe UI", 14),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White
            };

            lblResultado = new Label
            {
                Location = new Point(30, 110),
                Width = 320,
                Height = 30,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Text = "Resultado:",
                TextAlign = ContentAlignment.MiddleLeft
            };

            btnSumar = CrearBoton("Sumar", new Point(30, 160), ColorTranslator.FromHtml("#34C759"));     // Verde
            btnRestar = CrearBoton("Restar", new Point(210, 160), ColorTranslator.FromHtml("#FF3B30"));   // Rojo
            btnMultiplicar = CrearBoton("Multiplicar", new Point(30, 210), ColorTranslator.FromHtml("#007AFF")); // Azul
            btnDividir = CrearBoton("Dividir", new Point(210, 210), ColorTranslator.FromHtml("#AF52DE")); // Morado

            Controls.Add(txtA);
            Controls.Add(txtB);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(btnRestar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
        }

        private Button CrearBoton(string texto, Point ubicacion, Color colorFondo)
        {
            var boton = new Button
            {
                Text = texto,
                Location = ubicacion,
                Width = 140,
                Height = 40,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                BackColor = colorFondo,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            boton.FlatAppearance.BorderSize = 0;
            boton.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, boton.Width, boton.Height, 20, 20));

            boton.Click += (s, e) => EjecutarOperacion(texto);
            return boton;
        }

        private void EjecutarOperacion(string operacion)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                Operacion operacionSeleccionada = operacion switch
                {
                    "Sumar" => new Suma(),
                    "Restar" => new Resta(),
                    "Multiplicar" => new Multiplicacion(),
                    "Dividir" => new Division(),
                    _ => throw new InvalidOperationException("Operación no válida.")
                };
                double resultado = controller.EjecutarOperacion(operacionSeleccionada, a, b);
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
    }
}
