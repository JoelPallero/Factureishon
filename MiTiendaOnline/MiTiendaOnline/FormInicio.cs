using BussinessLayer;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTiendaOnline
{
    public partial class FormInicio : Form
    {

        #region Instancias
        private BusCliente _busCliente;
        private Cliente _cliente;
        private TarjetaDeCompa _tarjetaDeCompa;
        private BusTarjetaDeCompra _busTarjetaDeCompra;
        private Facturacion _facturacion;
        private BusFacturacion _busFacturacion;
        private Items _items;
        private BusItems _busItems;


        #endregion

        public FormInicio()
        {
            InitializeComponent();
            _busCliente = new BusCliente();
            _cliente = new Cliente();
            _tarjetaDeCompa = new TarjetaDeCompa();
            _busTarjetaDeCompra = new BusTarjetaDeCompra();
            _facturacion = new Facturacion();
            _busFacturacion = new BusFacturacion();
            _items = new Items();
            _busItems = new BusItems();
        }

        #region Variables

        private int CantidadProducto;

        private string NombreProd;

        private int ContadorTotal;
        private int IdentificadorDeProducto;
        private decimal PrecioUnitario;
        private decimal PrecioCoco = 950;
        private decimal PrecioManzanilla = 1900;
        private decimal PrecioAlmendra = 1390;
        private decimal PrecioAloeVera = 1670;

        private decimal SubPrecioProd;
        private decimal PrecioFinalFacturado;

        private bool Vacio;

        #endregion


        #region Métodos

        private void LlevarAlCarrito()
        {
            //Dependiendo del valor de esta variable vamos a seleccionar el precio a mostrar
            switch (IdentificadorDeProducto)
            {
                case 1:
                    PrecioUnitario = PrecioCoco;
                    break;
                case 2:
                    PrecioUnitario = PrecioManzanilla;
                    break;
                case 3:
                    PrecioUnitario = PrecioAlmendra;
                    break;
                case 4:
                    PrecioUnitario = PrecioAloeVera;
                    break;
            }

            DTProductosCarrito.Rows.Add(NombreProd, "$" + PrecioUnitario, CantidadProducto, SubPrecioProd);
            PrecioFinalFacturado += SubPrecioProd;
            LblPrecioFinalFacturado.Text = "$" + Convert.ToString(PrecioFinalFacturado);
            ClearVariables();
        }


        private void ClearVariables()
        {
            CantidadProducto = 0;
            NombreProd = string.Empty;
            SubPrecioProd = 0;
            PrecioUnitario = 0;
            IdentificadorDeProducto = 0;
        }

        private void ClearDatosTarjeta()
        {
            foreach (Control text in TabCarrito.Controls)
            {
                if (text is TextBox)
                {
                    text.Text = string.Empty;
                }
            }
        }

        private void GuardarTarjeta()
        {
            //se pasan los datos del text de la tarjeta a la clase Tarjeta en la capa de entidades
            // y luego se guarda en la bdd
            _cliente = _busCliente.ClienteRegistrado(_cliente);
            _tarjetaDeCompa.NroTarjeta = TxtNrosTarjeta.Text;
            _tarjetaDeCompa.CodSeguridad = TxtCodSeguridad.Text;
            _tarjetaDeCompa.IdCliente = _cliente.Id;
            _busTarjetaDeCompra.NuevaTarjeta(_tarjetaDeCompa);
        }

        private void TraerTarjetaGuardada()
        {
            _tarjetaDeCompa = _busTarjetaDeCompra.TraerUltimaTarjeta(_cliente.Id, _tarjetaDeCompa);            
        }

        private void Facturacion()
        {
            //trae la tarjeta que acabo de registrar
            TraerTarjetaGuardada();


            //paso los datos hacia la bdd
            _facturacion.Fecha = DateTime.Now;
            _facturacion.PrecioFinal = PrecioFinalFacturado;
            _facturacion.IdCliente = _cliente.Id;
            _facturacion.IdTarjeta = _tarjetaDeCompa.Id;
            _facturacion.Aprobado = "Ok";
            _busFacturacion.NuevaFactura(_facturacion);
        }

        private void GuardarProductos()
        {
            //traigo el Id la factura que acabo de crear
            _busFacturacion.TraerFacturaCliente(_cliente.Id, _facturacion);
            

            //Y luego guardo todos los productos comprados en la bdd (Items)
            foreach (DataGridViewRow fila in DTProductosCarrito.Rows)
            {
                if (fila is DataGridViewRow)
                {
                    if (ContadorTotal > 0)
                    {
                        _items.NombreProducto = fila.Cells[0].Value.ToString();
                        _items.Cantidad = int.Parse(fila.Cells[2].Value.ToString());
                        _items.SubPrecio = decimal.Parse(fila.Cells[3].Value.ToString());
                        _items.IdFactura = _facturacion.Id;
                        _busItems.RegistrarItem(_items);

                        ContadorTotal--;
                    }
                }
            }
        }

        private void VerificacionText()
        {
            //Aca recorro todos los controles de tipo Textbox y verifico si estan vacios o no
            foreach (Control text in TabCarrito.Controls)
            {
                if (text is TextBox)
                {
                    if (string.IsNullOrEmpty(text.Text))
                    {
                        Vacio = true;
                    }
                    else
                    {
                        Vacio = false;
                    }
                }
            }
        }

        private void VaciarComboBox()
        {
            CmbCoco.SelectedItem = null;
            CmbManzanilla.SelectedItem = null;
            CmbAlmendra.SelectedItem = null;
            CmbAloeVera.SelectedItem = null;
        }

        private void CompraConcretada()
        {
            MessageBox.Show("Tu compra de $" + PrecioFinalFacturado + " se realizó de manera exitosa.", 
                            "Compra exitosa", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }

        #endregion


        #region Eventos
        private void AgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (CmbCoco.Text != string.Empty) //si algun cmb tiene un numero seleccionado ejecuto acciones abajo
            {
                NombreProd = LblNombreCoco.Text;
                CantidadProducto = Convert.ToInt32(CmbCoco.SelectedItem);
                SubPrecioProd = PrecioCoco * CantidadProducto;
                IdentificadorDeProducto = 1;
                LlevarAlCarrito();
                ContadorTotal++;
            }
            if (CmbManzanilla.Text != string.Empty)
            {
                NombreProd = LblNombreManzanilla.Text;
                CantidadProducto = Convert.ToInt32(CmbManzanilla.SelectedItem);
                SubPrecioProd = PrecioManzanilla * CantidadProducto;
                IdentificadorDeProducto = 2;
                LlevarAlCarrito();
                ContadorTotal++;
            }
            if (CmbAlmendra.Text != string.Empty)
            {
                NombreProd = LblNombreAlmendras.Text;
                CantidadProducto = Convert.ToInt32(CmbAlmendra.SelectedItem);
                SubPrecioProd = PrecioAlmendra * CantidadProducto;
                IdentificadorDeProducto = 3;
                LlevarAlCarrito();
                ContadorTotal++;
            }
            if (CmbAloeVera.Text != string.Empty)
            {
                NombreProd = LblNombreAloeVera.Text;
                CantidadProducto = Convert.ToInt32(CmbAloeVera.SelectedItem);
                SubPrecioProd = PrecioAloeVera * CantidadProducto;
                IdentificadorDeProducto = 4;
                LlevarAlCarrito();
                ContadorTotal++;
            }
            VaciarComboBox();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            //Primero verificamos si los Texbox de la tarjeta tienen datos
            VerificacionText();

            //si estan vacios me muestra msj
            if (Vacio)
            {
                MessageBox.Show("Tiene que llenar todos los campos de la tarjeta.",
                                "Campos vacíos", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
            //sino ejecuto código
            else
            {
                //1 guardo la tarjeta
                GuardarTarjeta();
                //2 creo la factura
                Facturacion();
                //3 guardo los productos comprados
                GuardarProductos();
                //4 Muestra msj de confirmación de compra
                CompraConcretada();
            }

            //borrar datos visibles
            ClearDatosTarjeta();
            ContadorTotal = 0;
            DTProductosCarrito.Rows.Clear();
        }


        #endregion

        private void TxtNrosTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se teclean los digitos
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //con esto se desactivan todas las otras teclas no contempladas en las líneas anteriores
                e.Handled = true;
            }
        }
    }
}