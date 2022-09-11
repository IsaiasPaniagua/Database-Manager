using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_BD
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            CargarBDS();
            cboxBDS.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //Variables y metodos Globales
        public string texto;
        public string path;
        public string ElegirTabla;
        public string ElegirBD;
        public string NameTabla;
        TextWriter Tabla_dat;
        TextWriter Tabla_est;
        public string DEL = ";";
        List<string> Campos_est = new List<string>();
        //Boton para mostrar todas las bases de datos
        private void button4_Click(object sender, EventArgs e)
        {
            //DirectoryInfo di = new DirectoryInfo(@"C:\Users\LATITUDE\Downloads\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos");
            //DirectoryInfo[] BDS = di.GetDirectories();
            //if(BDS.Length > 0)
            //{
            //    foreach(DirectoryInfo dri in BDS)
            //    {
            //        cboxBDS.Items.Add(dri);
            //    }
            //}
            //else { MessageBox.Show("No existe ninguna base de datos...");}
        }

        //Boton para crear carpetas
        private void button1_Click(object sender, EventArgs e)
        {
            string NameBD = txtNombreBD.Text;
            string BD = Application.StartupPath + @"\Bases de Datos\" + NameBD;
            try
            {
                if (Directory.Exists(BD))
                {
                    MessageBox.Show("Esta Base de datos ya existe");
                }
                else
                {
                    MessageBox.Show("Base de Datos Creada");
                    Directory.CreateDirectory(BD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            cboxBDS.Items.Clear();
            txtNombreBD.Text = "";
            CargarBDS();
            CargarDBS_DGV();
        }
        // Funcion para cargar las bases de datos al cbox
        private void CargarBDS()
        {
            // cargamos al combobox las bases de datos que tenemos por el momento
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos");
            DirectoryInfo[] BDS = di.GetDirectories();
            if (BDS.Length > 0)
            {
                foreach (DirectoryInfo dri in BDS)
                {
                    cboxBDS.Items.Add(dri);
                }
            }
            else { MessageBox.Show("No existe ninguna Base De Datos"); }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Boton para eliminar las bases de datos
        private void btnEliminarBD_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + ElegirBD);
                MessageBox.Show("Base De datos Eliminada");
                cboxBDS.Text = "";
                cboxBDS.Items.Clear();
                CargarBDS();
                CargarDBS_DGV();
                lblBDUSO.Text = "";
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Metodo de seleccion y asignacion para el uso de la base de datos o su eliminacion
        private void cboxBDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElegirBD = cboxBDS.Text;
        }

        // Boton para usar la base de datos
        private void btnUsarBD_Click(object sender, EventArgs e)
        {
            lblBDUSO.Text = ElegirBD;
            cboxBDS.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Boton para crear tablas
        private void button7_Click(object sender, EventArgs e)
        {
            Tabla_dat = new StreamWriter(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text+"\\"+ txtNombreTabla.Text + ".dat.txt");
            Tabla_est = new StreamWriter(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt");
            if (cboxTipoDato.Text == "DATE")
            {
                cboxLongirud.Text = "8";
            };
            //Campos_est.Add(DEL+txtNombreCampo.Text + DEL + cboxTipoDato.Text + DEL + cboxLongirud.Text);
            //foreach (var item in Campos_est)
            //{
            //    Tabla_est.WriteLine(item.ToString());
            //}
            Tabla_est.Close();
            if (txtNombreCampo.Text == "" && cboxTipoDato.Text == "" && cboxLongirud.Text =="")
            {

            }
            else
            {
                texto = txtNombreCampo.Text + DEL + cboxTipoDato.Text + DEL + cboxLongirud.Text + "\r\n";
                path = @"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt";

                File.AppendAllText(path, texto);
            }
            MessageBox.Show("Tabla Creada");
            txtNombreCampo.Text = "";
            cboxTipoDato.Text = "";
            cboxLongirud.Text = "";
            CargarTBS_DGV();
            Tabla_est.Close();
            Tabla_dat.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // Funcion para deshabilitar la longitud cuando el tipo de dato es DATE
        private void cboxTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTipoDato.Text == "DATE")
            {
                cboxLongirud.Items.Clear();
                cboxLongirud.Enabled = false;
                cboxLongirud.Text = "8";
            }
            else if(cboxTipoDato.Text == "STRING")
            {
                cboxLongirud.Items.Clear();
                cboxLongirud.Items.Add("10");
                cboxLongirud.Items.Add("15");
                cboxLongirud.Items.Add("20");
                cboxLongirud.Items.Add("25");
                cboxLongirud.Items.Add("30");
            }
            else
            {
                cboxLongirud.Items.Clear();
                cboxLongirud.Enabled = true;
                cboxLongirud.Text = "";
            }
        }
        // Boton para agregar un nuevo campo
        private void btnAddCampo_Click(object sender, EventArgs e)
        {
            if (cboxTipoDato.Text == "DATE")
            {
                cboxLongirud.Text = "8";
            }
            texto = txtNombreCampo.Text + DEL + cboxTipoDato.Text + DEL + cboxLongirud.Text + "\r\n";
            path = @"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt";

            File.AppendAllText(path, texto);

            MessageBox.Show("Campo Agregado");
            txtNombreCampo.Text = "";
            cboxTipoDato.Text = "";
            cboxLongirud.Text = "";
        }
        // Boton para eliminar las tablas
        private void btnEliminarTabla_Click(object sender, EventArgs e)
        {
            
            File.Delete(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".dat.txt");
            File.Delete(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt");
            MessageBox.Show("Tabla eliminada");
               
            txtNombreTabla.Text = "";
            txtNombreCampo.Text = "";
            cboxTipoDato.Text = "";
            cboxLongirud.Text = "";
            CargarTBS_DGV();
        }
        //Boton para mostrar en el DataGriedView las Tablas Creadas
        private void button8_Click(object sender, EventArgs e)
        {
            CargarTBS_DGV();
        }
        // Metodo para cargar las tablas a nuestro DGV
        private void CargarTBS_DGV()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text);
            FileInfo[] TablasBDE = dir.GetFiles("*est.txt");
            dgvTablas.DataSource = TablasBDE;
        }
        // Boton para mostrar todas las bases de datos
        private void btnMostrarBasesDeDatos_Click(object sender, EventArgs e)
        {
            CargarDBS_DGV();
        }
        private void CargarDBS_DGV()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos");
            DirectoryInfo[] BDS = dir.GetDirectories();
            dgvBasesDeDatos.DataSource = BDS;
        }
        // Funcion para ocultar las columnas del dgv
        private void dgvBasesDeDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvBasesDeDatos.Columns["FullName"].Visible = false;
            this.dgvBasesDeDatos.Columns["Parent"].Visible = false;
            this.dgvBasesDeDatos.Columns["Exists"].Visible = false;
            this.dgvBasesDeDatos.Columns["Root"].Visible = false;
            this.dgvBasesDeDatos.Columns["Extension"].Visible = false;
            this.dgvBasesDeDatos.Columns["CreationTime"].Visible = false;
            this.dgvBasesDeDatos.Columns["CreationTimeUtc"].Visible = false;
            this.dgvBasesDeDatos.Columns["LastAccessTime"].Visible = false;
            this.dgvBasesDeDatos.Columns["LastAccessTimeUtc"].Visible = false;
            this.dgvBasesDeDatos.Columns["LastWriteTime"].Visible = false;
            this.dgvBasesDeDatos.Columns["LastWriteTimeUtc"].Visible = false;
            this.dgvBasesDeDatos.Columns["Attributes"].Visible = false;
        }
        // Funcion para ocultar las columnas del dgv
        private void dgvTablas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvTablas.Columns["Length"].Visible = false;
            this.dgvTablas.Columns["DirectoryName"].Visible = false;
            this.dgvTablas.Columns["Directory"].Visible = false;
            this.dgvTablas.Columns["IsReadOnly"].Visible = false;
            this.dgvTablas.Columns["Exists"].Visible = false;
            this.dgvTablas.Columns["FullName"].Visible = false;
            this.dgvTablas.Columns["Extension"].Visible = false;
            this.dgvTablas.Columns["CreationTime"].Visible = false;
            this.dgvTablas.Columns["CreationTimeUtc"].Visible = false;
            this.dgvTablas.Columns["LastAccessTime"].Visible = false;
            this.dgvTablas.Columns["LastAccessTimeUtc"].Visible = false;
            this.dgvTablas.Columns["LastWriteTime"].Visible = false;
            this.dgvTablas.Columns["LastWriteTimeUtc"].Visible = false;
            this.dgvTablas.Columns["Attributes"].Visible = false;
        }
        // Funcion para al momento de seleccionar usar esa base de datos
        private void dgvBasesDeDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            lblBDUSO.Text = dgvBasesDeDatos.CurrentCell.Value.ToString();
            cboxBDS.Text = dgvBasesDeDatos.CurrentCell.Value.ToString();
        }
        // Funcion para al momento de seleccionar usar esa Tabla
        private void dgvTablas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreTabla.Text = dgvTablas.CurrentCell.Value.ToString();
        }

        private void dgvBasesDeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Boton para modificar algun dato
        private void btnModificarDato_Click(object sender, EventArgs e)
        {
            Agregar_Modificar_Eliminar();
            MessageBox.Show("Datos Modificados");
        }
        // Metodo para modificar un dato de la tabla
        private void BorrarCampo()
        {
            var Mpath = @"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt";

            var nombreCampo = txtLlave.Text;

            var EliminarCampo = "";

            var lines = File.ReadAllLines(Mpath);

            var remplazar = lines.Select(x =>
            {
                if (x.StartsWith(nombreCampo))
                    return EliminarCampo;
                return x;
            });
            File.WriteAllLines(Mpath, remplazar);
            
        }
        private void Agregar_Modificar_Eliminar()
        {
            File.Delete(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".dat.txt");
            Tabla_dat = new StreamWriter(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".dat.txt");
            Tabla_dat.Close();
            string text = txtAgregarCamposdat.Text;
            path = @"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + lblNTablasCampos.Text + ".dat.txt";

            File.AppendAllText(path, text);
        }
        private void Agregarjjjj_Click(object sender, EventArgs e)
        {
            //string filep = @"C:\Users\LATITUDE\Downloads\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt";
            //List<string> lineas = File.ReadAllLines(filep).ToList();
            //foreach (var item in lineas)
            //{
            //    MessageBox.Show(item);
            //}
            Agregar_Modificar_Eliminar();
            MessageBox.Show("Datos Agregados");
        }
    
        // Boton para borrar campos
        private void button6_Click(object sender, EventArgs e)
        {
            BorrarCampo();
            MessageBox.Show("Campo Eliminado");
            txtLlave.Text = "";
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            //lblNTablasCampos.Text = txtNombreTabla.Text;
            //string Tbl = @"C:\Users\LATITUDE\Downloads\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + lblNTablasCampos.Text + ".est.txt";
            //List<string> Campos = File.ReadAllLines(Tbl).ToList();
            //foreach (var item in Campos)
            //{
            //    txtManual.Text = item;
            //}
            lblNTablasCampos.Text = txtNombreTabla.Text;
            TextReader Leer = new StreamReader(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + lblNTablasCampos.Text + ".est.txt");
            TextReader Leer1 = new StreamReader(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + lblNTablasCampos.Text + ".dat.txt");
            txtManual.Text = Leer.ReadToEnd();
            txtAgregarCamposdat.Text = Leer1.ReadToEnd();
            Leer.Close();
            Leer1.Close();
        }

        private void btnEliminarCampoTBL_Click(object sender, EventArgs e)
        {
            Agregar_Modificar_Eliminar();
            MessageBox.Show("Dato/s Eliminado/s");
        }

        // AQUI EMPIEZAN LOS BOTONES DEL METRO

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string NameBD = txtNombreBD.Text;
            string BD = Application.StartupPath + @"\Bases de Datos\" + NameBD;
            try
            {
                if (Directory.Exists(BD))
                {
                    MessageBox.Show("Esta Base de datos ya existe");
                }
                else
                {
                    MessageBox.Show("Base de Datos Creada");
                    Directory.CreateDirectory(BD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            cboxBDS.Items.Clear();
            txtNombreBD.Text = "";
            CargarBDS();
            CargarDBS_DGV();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + ElegirBD, true);

                MessageBox.Show("Base De datos Eliminada");
                cboxBDS.Text = "";
                cboxBDS.Items.Clear();
                txtAgregarCamposdat.Text = "";
                txtManual.Text = "";
                CargarBDS();
                CargarDBS_DGV();
                lblBDUSO.Text = "";
                CargarTBS_DGV();
                txtNombreTabla.Text = "";
                lblNTablasCampos.Text = "";
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            lblBDUSO.Text = ElegirBD;
            cboxBDS.Text = "";
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            CargarDBS_DGV();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (cboxTipoDato.Text == "DATE")
            {
                cboxLongirud.Text = "8";
            }
            texto = txtNombreCampo.Text + DEL + cboxTipoDato.Text + DEL + cboxLongirud.Text + "\r\n";
            path = @"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt";

            File.AppendAllText(path, texto);

            MessageBox.Show("Campo Agregado");
            txtNombreCampo.Text = "";
            cboxTipoDato.Text = "";
            cboxLongirud.Text = "";
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Tabla_dat = new StreamWriter(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".dat.txt");
            Tabla_est = new StreamWriter(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt");
            if (cboxTipoDato.Text == "DATE")
            {
                cboxLongirud.Text = "8";
            };
            //Campos_est.Add(DEL+txtNombreCampo.Text + DEL + cboxTipoDato.Text + DEL + cboxLongirud.Text);
            //foreach (var item in Campos_est)
            //{
            //    Tabla_est.WriteLine(item.ToString());
            //}
            Tabla_est.Close();
            if (txtNombreCampo.Text == "" && cboxTipoDato.Text == "" && cboxLongirud.Text == "")
            {

            }
            else
            {
                texto = txtNombreCampo.Text + DEL + cboxTipoDato.Text + DEL + cboxLongirud.Text + "\r\n";
                path = @"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt";

                File.AppendAllText(path, texto);
            }
            MessageBox.Show("Tabla Creada");
            txtNombreCampo.Text = "";
            cboxTipoDato.Text = "";
            cboxLongirud.Text = "";
            CargarTBS_DGV();
            Tabla_est.Close();
            Tabla_dat.Close();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".dat.txt");
            File.Delete(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + txtNombreTabla.Text + ".est.txt");
            MessageBox.Show("Tabla eliminada");

            txtNombreTabla.Text = "";
            txtNombreCampo.Text = "";
            cboxTipoDato.Text = "";
            cboxLongirud.Text = "";
            lblNTablasCampos.Text = "";
            txtManual.Text = "";
            txtAgregarCamposdat.Text = "";
            CargarTBS_DGV();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            CargarTBS_DGV();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            lblNTablasCampos.Text = txtNombreTabla.Text;
            TextReader Leer = new StreamReader(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + lblNTablasCampos.Text + ".est.txt");
            TextReader Leer1 = new StreamReader(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + lblNTablasCampos.Text + ".dat.txt");
            txtManual.Text = Leer.ReadToEnd();
            txtAgregarCamposdat.Text = Leer1.ReadToEnd();
            Leer.Close();
            Leer1.Close();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            BorrarCampo();
            TextReader Leer = new StreamReader(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + lblNTablasCampos.Text + ".est.txt");
            TextReader Leer1 = new StreamReader(@"C:\Users\LATITUDE\Desktop\Proyecto BD\Proyecto BD\bin\Debug\Bases de Datos\" + lblBDUSO.Text + "\\" + lblNTablasCampos.Text + ".dat.txt");
            txtManual.Text = Leer.ReadToEnd();
            txtAgregarCamposdat.Text = Leer1.ReadToEnd();
            Leer.Close();
            Leer1.Close();
            MessageBox.Show("Campo Eliminado");
            txtLlave.Text = "";
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            Agregar_Modificar_Eliminar();
            MessageBox.Show("Datos Agregados");
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            Agregar_Modificar_Eliminar();
            MessageBox.Show("Datos Modificados");
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            Agregar_Modificar_Eliminar();
            MessageBox.Show("Dato/s Eliminado/s");
        }
    }
}
