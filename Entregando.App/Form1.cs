using Entregando.App.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Entregando.App
{
    public partial class Form1 : Form
    {
        #region Members
        int empleadoId;
        DateTime? fecha;
        string placa;
        #endregion

        #region Ctor
        public Form1()
        {
            InitializeComponent();
        } 
        #endregion

        #region Methods
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (empleadoId > 0)
            {
                if (fecha == null)
                {
                    CallApiService api = new CallApiService();
                    var result = api.GetCustomerDetailsByCustomerId(empleadoId);
                    if (result.Error)
                        WarningLabel.Text = string.Format("* {0}", result.Messaje);
                    else
                        viajesGridView1.DataSource = result.Data;
                    if (result.Data == null || result.Data.Count() <= 0)
                        WarningLabel.Text = "No se encontrarón viajes.";
                    else
                        WarningLabel.Text = "";
                }
                else
                {
                    CallApiService api = new CallApiService();
                    var result = api.GetCustomerDetailsByFilter(fecha.Value, empleadoId, placa);
                    if (result.Error)
                        WarningLabel.Text = string.Format("* {0}", result.Messaje);
                    else
                        viajesGridView1.DataSource = result.Data;
                    if (result.Data == null || result.Data.Count() <= 0)
                        WarningLabel.Text = "No se encontrarón viajes.";
                    else
                        WarningLabel.Text = "";
                }
            }
            else
            {
                WarningLabel.Text = "* El id del empleado no es valido.";
            }
        }

        private void InputEmpleadoId_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(InputEmpleadoId.Text, out int value);
            empleadoId = value;
        }

        private void dateTimeFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeFecha.Checked)
                fecha = dateTimeFecha.Value;
            else
                fecha = null;
        }

        private void PlacaInput_TextChanged(object sender, EventArgs e)
        {
            placa = PlacaInput.Text;
        }
        #endregion

        #region Private methods

        #endregion
    }
}
