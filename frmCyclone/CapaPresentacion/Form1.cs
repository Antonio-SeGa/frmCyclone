using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias necesarias paa generar reportes con iText
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace frmCyclone
{
    public partial class frmExploiter : Form
    {
        CapaNegocio.FN_Exploiter ObjExploiter = new CapaNegocio.FN_Exploiter(); // Objeto exploiter
        private int renglon = 0;
        public frmExploiter()
        {
            InitializeComponent();
        }

        private void btnAgregaExploiter_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar si los textbox estan vacios
                if (txtCodExploiter.Text == "" || txtCodEmpleado.Text == "" ||
                    cbxNivelAcceso.Text == "" || txtNomUsuario.Text == "" ||
                    txtPassUsuario.Text == "" || cbxEstatus.Text == "")
                {
                    MessageBox.Show("Acompleta los campos de resgistro.",
                                "Registro Exploiter Incompletp",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
                else
                {
                    //mandar parametros de lo que se ingresa en los textbox
                    ObjExploiter.parInsertExploiter(txtCodExploiter.Text,
                                                txtCodEmpleado.Text,
                                                cbxNivelAcceso.Text,
                                                txtNomUsuario.Text,
                                                txtPassUsuario.Text,
                                                cbxEstatus.Text);
                    MessageBox.Show("Se creo correctamente el registro Exploiter.",
                                    "Registro Exploiter",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    cargaExploiter();
                    limpiar();
                }
            }
            //Cachear un error presentado
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error Registro Exploiter",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void frmExploiter_Load(object sender, EventArgs e)
        {
            //al cargar el fromualrio  caragara los datos a la tabla
            cargaExploiter();
        }

        private void cargaExploiter() 
        {
            //cargar los datos en el datagreatview
            CapaNegocio.FN_Exploiter ObjExploiterTabla = new CapaNegocio.FN_Exploiter(); // Objeto Todos exploiter
            dgvExploiter.DataSource = ObjExploiterTabla.CargaTablaExploiter();
        }

        private void btnEliminaExploiter_Click(object sender, EventArgs e)
        {
            try
            {
                //si la caja de texto est vacia 
                //Solicitar seleccionar informacion del datagreatview
                //de lo contrario 
                if (txtCodExploiter.Text == "")
                {
                    MessageBox.Show("Seleccione el registro Exploiter ha eliminar.",
                                "Exploiter no seleccionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
                else
                {
                    ObjExploiter.parDeleteExploiter(txtCodExploiter.Text);
                    MessageBox.Show("Se elimino correctamente el registro Exploiter.",
                                    "Registro Exploiter Eliminado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    cargaExploiter();
                }
            }
            //Cachear un error presentado
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error Eliminacion Exploiter",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dgvExploiter_CellClick(object sender, DataGridViewCellEventArgs myDataExp)
        {
            renglon = myDataExp.RowIndex;

            if (renglon != -1)
            {
                //(String) Obj:intentara comvertir el objeto a string y fallara si no hay una convercion valida.
                // obj ToString: devolvera un string que reprecenta al dieño del objeto(nombre de la clase objeto).
                txtCodExploiter.Text = dgvExploiter.Rows[renglon].Cells[0].Value.ToString();
                txtCodEmpleado.Text = dgvExploiter.Rows[renglon].Cells[1].Value.ToString();
                cbxNivelAcceso.Text = (string)dgvExploiter.Rows[renglon].Cells[2].Value;
                txtNomUsuario.Text = (string)dgvExploiter.Rows[renglon].Cells[3].Value;
                txtPassUsuario.Text = (string)dgvExploiter.Rows[renglon].Cells[4].Value;
                cbxEstatus.Text = (string)dgvExploiter.Rows[renglon].Cells[5].Value;
            }
        }

        public void limpiar() 
        {
            txtCodExploiter.Clear();
            txtCodEmpleado.Clear();
            cbxNivelAcceso.Text = "";
            txtNomUsuario.Clear();
            txtPassUsuario.Clear();
            cbxEstatus.Text = "";
        }

        private void btnActualizaExploiter_Click(object sender, EventArgs e)
        {
            try
            {
                //verificar si el campo de cosigo exploiter esta vacio
                if (txtCodExploiter.Text == "")
                

                    MessageBox.Show("Seleccione el registro Exploiter ha modificar.",
                                "Exploiter no seleccionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                
                else
                {
                    //mandar parametros de lo que se ingresa en los textbox
                    ObjExploiter.parUpdateExploiter(txtCodExploiter.Text,
                                                txtCodEmpleado.Text,
                                                cbxNivelAcceso.Text,
                                                txtNomUsuario.Text,
                                                txtPassUsuario.Text,
                                                cbxEstatus.Text);
                    MessageBox.Show("Se actualizo correctamente el Exploiter.",
                                    "Actualizacion Exploiter",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    cargaExploiter();
                    limpiar();
                }
            }
            //Cachear un error presentado
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error Actualizacion Exploiter",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnReporteExploiter_Click(object sender, EventArgs e)
        {
            Random rdnFolio = new Random();
            int folio = rdnFolio.Next(10000,99999);
            string fecha = DateTime.Now.Date.ToString("dd-MM-yyyy");
            string rutaArchivo = @"C:\Users\Windows 10\source\repos\frmCyclone\frmCyclone\Reportes\";
            //Creamos una variable de tipo archivo que se cargará en la memoria principal
            iTextSharp.text.Document documentExploiter = new Document();

            //Creamos la instancia para generar el archivo PDF
            //Le pasamos el documento creado arriba y con capacidad para abrir o Crear un nuevo documnto           
            PdfWriter write = PdfWriter.GetInstance(documentExploiter, new FileStream(rutaArchivo + folio + "_ReporteExploiter_" + fecha + ".pdf", FileMode.OpenOrCreate)); //modificar ruta - Modificar nombre

            //Abrimos el documento
            documentExploiter.Open();
            //cramos una fuente para nuestro texto
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);
            Phrase objPrint = new Phrase("A", fuente);

            PdfPCell cell;

            //Se crea el encabezado del documento  
            PdfPTable header = new PdfPTable(3);
            header.TotalWidth = documentExploiter.PageSize.Width - documentExploiter.Left - documentExploiter.RightMargin;
            header.DefaultCell.Border = 0;

            //Contenido del encabenzado
            cell = new PdfPCell(new Paragraph("Folio: " + folio));
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Border = 0;
            header.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Registros Exploiter"));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = 0;
            header.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Fecha: " + fecha));
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.Border = 0;
            header.AddCell(cell);            
            header.WriteSelectedRows(0,-1,documentExploiter.LeftMargin,write.PageSize.GetTop(documentExploiter.TopMargin) + 30,write.DirectContent);

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF
            PdfPTable datatable = new PdfPTable(dgvExploiter.ColumnCount);
            for (int i = 0; i < dgvExploiter.ColumnCount; i++)
            {               
                objPrint = new Phrase(dgvExploiter.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;               
                datatable.AddCell(objPrint);
            }


            //SE GENERA EL CONTENIDO DE LA TABLA
            for (int i = 0; i < dgvExploiter.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvExploiter.ColumnCount; j++)
                {
                    objPrint = new Phrase(dgvExploiter[j, i].Value.ToString());
                    datatable.AddCell(objPrint);
                }
                datatable.CompleteRow();
            }
            documentExploiter.Add(datatable);

            //se crea el pie de paguina del documento
            PdfPTable footer = new PdfPTable(3);
            footer.TotalWidth = documentExploiter.PageSize.Width - documentExploiter.Left - documentExploiter.RightMargin;
            footer.DefaultCell.Border = 0;

            footer.AddCell(new Paragraph());

                //Añadir el numero de pagina
            cell = new PdfPCell(new Paragraph("Pagina " + write.PageNumber));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Border = 0;
            footer.AddCell(cell);

            footer.AddCell(new Paragraph());
            footer.WriteSelectedRows(0, -1, documentExploiter.LeftMargin, write.PageSize.GetBottom(documentExploiter.BottomMargin) - 10, write.DirectContent);


            //cerrar el documento
            documentExploiter.Close();

            //mensaje de creacion de documento
            MessageBox.Show("Se ha generado el reporte correctamente",
                            "Reporte",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
    
}
