
namespace Proyecto_BD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCrearBD = new System.Windows.Forms.Button();
            this.txtNombreBD = new System.Windows.Forms.TextBox();
            this.btnUsarBD = new System.Windows.Forms.Button();
            this.btnEliminarBD = new System.Windows.Forms.Button();
            this.Agregarjjjj = new System.Windows.Forms.Button();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.cboxTipoDato = new System.Windows.Forms.ComboBox();
            this.btnBorrarCampo = new System.Windows.Forms.Button();
            this.txtNombreCampo = new System.Windows.Forms.TextBox();
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxBDS = new System.Windows.Forms.ComboBox();
            this.lblBDUSO = new System.Windows.Forms.Label();
            this.btnAddCampo = new System.Windows.Forms.Button();
            this.cboxLongirud = new System.Windows.Forms.ComboBox();
            this.btnEliminarTabla = new System.Windows.Forms.Button();
            this.dgvBasesDeDatos = new System.Windows.Forms.DataGridView();
            this.btnMostrarBasesDeDatos = new System.Windows.Forms.Button();
            this.btnModificarDato = new System.Windows.Forms.Button();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAgregarCamposdat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNTablasCampos = new System.Windows.Forms.Label();
            this.btnUsar = new System.Windows.Forms.Button();
            this.txtManual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminarCampoTBL = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasesDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearBD
            // 
            this.btnCrearBD.BackColor = System.Drawing.Color.Teal;
            this.btnCrearBD.Location = new System.Drawing.Point(1073, 446);
            this.btnCrearBD.Name = "btnCrearBD";
            this.btnCrearBD.Size = new System.Drawing.Size(75, 23);
            this.btnCrearBD.TabIndex = 0;
            this.btnCrearBD.Text = "Crear";
            this.btnCrearBD.UseVisualStyleBackColor = false;
            this.btnCrearBD.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreBD
            // 
            this.txtNombreBD.Location = new System.Drawing.Point(176, 87);
            this.txtNombreBD.Name = "txtNombreBD";
            this.txtNombreBD.Size = new System.Drawing.Size(173, 20);
            this.txtNombreBD.TabIndex = 2;
            // 
            // btnUsarBD
            // 
            this.btnUsarBD.BackColor = System.Drawing.Color.Teal;
            this.btnUsarBD.Location = new System.Drawing.Point(1163, 457);
            this.btnUsarBD.Name = "btnUsarBD";
            this.btnUsarBD.Size = new System.Drawing.Size(75, 23);
            this.btnUsarBD.TabIndex = 3;
            this.btnUsarBD.Text = "Usar";
            this.btnUsarBD.UseVisualStyleBackColor = false;
            this.btnUsarBD.Click += new System.EventHandler(this.btnUsarBD_Click);
            // 
            // btnEliminarBD
            // 
            this.btnEliminarBD.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarBD.Location = new System.Drawing.Point(1073, 482);
            this.btnEliminarBD.Name = "btnEliminarBD";
            this.btnEliminarBD.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarBD.TabIndex = 4;
            this.btnEliminarBD.Text = "Eliminar";
            this.btnEliminarBD.UseVisualStyleBackColor = false;
            this.btnEliminarBD.Click += new System.EventHandler(this.btnEliminarBD_Click);
            // 
            // Agregarjjjj
            // 
            this.Agregarjjjj.BackColor = System.Drawing.Color.Teal;
            this.Agregarjjjj.Location = new System.Drawing.Point(1176, 225);
            this.Agregarjjjj.Name = "Agregarjjjj";
            this.Agregarjjjj.Size = new System.Drawing.Size(108, 41);
            this.Agregarjjjj.TabIndex = 7;
            this.Agregarjjjj.Text = "Agregar";
            this.Agregarjjjj.UseVisualStyleBackColor = false;
            this.Agregarjjjj.Click += new System.EventHandler(this.Agregarjjjj_Click);
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(150, 341);
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(201, 20);
            this.txtNombreTabla.TabIndex = 9;
            // 
            // cboxTipoDato
            // 
            this.cboxTipoDato.FormattingEnabled = true;
            this.cboxTipoDato.Items.AddRange(new object[] {
            "INT",
            "STRING",
            "DECIMAL",
            "DATE"});
            this.cboxTipoDato.Location = new System.Drawing.Point(122, 406);
            this.cboxTipoDato.Name = "cboxTipoDato";
            this.cboxTipoDato.Size = new System.Drawing.Size(229, 21);
            this.cboxTipoDato.TabIndex = 11;
            this.cboxTipoDato.SelectedIndexChanged += new System.EventHandler(this.cboxTipoDato_SelectedIndexChanged);
            // 
            // btnBorrarCampo
            // 
            this.btnBorrarCampo.BackColor = System.Drawing.Color.Teal;
            this.btnBorrarCampo.Location = new System.Drawing.Point(1210, 559);
            this.btnBorrarCampo.Name = "btnBorrarCampo";
            this.btnBorrarCampo.Size = new System.Drawing.Size(92, 41);
            this.btnBorrarCampo.TabIndex = 12;
            this.btnBorrarCampo.Text = "Borrar campo";
            this.btnBorrarCampo.UseVisualStyleBackColor = false;
            this.btnBorrarCampo.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtNombreCampo
            // 
            this.txtNombreCampo.Location = new System.Drawing.Point(157, 372);
            this.txtNombreCampo.Name = "txtNombreCampo";
            this.txtNombreCampo.Size = new System.Drawing.Size(194, 20);
            this.txtNombreCampo.TabIndex = 15;
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.BackColor = System.Drawing.Color.Teal;
            this.btnCrearTabla.Location = new System.Drawing.Point(1148, 87);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(108, 44);
            this.btnCrearTabla.TabIndex = 16;
            this.btnCrearTabla.Text = "Crear Tabla";
            this.btnCrearTabla.UseVisualStyleBackColor = false;
            this.btnCrearTabla.Click += new System.EventHandler(this.button7_Click);
            // 
            // dgvTablas
            // 
            this.dgvTablas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(395, 463);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(171, 137);
            this.dgvTablas.TabIndex = 17;
            this.dgvTablas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablas_CellDoubleClick);
            this.dgvTablas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTablas_DataBindingComplete);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.Location = new System.Drawing.Point(1148, 138);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 44);
            this.button8.TabIndex = 18;
            this.button8.Text = "Mostrar Tablas";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 22;
            // 
            // cboxBDS
            // 
            this.cboxBDS.FormattingEnabled = true;
            this.cboxBDS.Location = new System.Drawing.Point(209, 126);
            this.cboxBDS.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBDS.Name = "cboxBDS";
            this.cboxBDS.Size = new System.Drawing.Size(140, 21);
            this.cboxBDS.TabIndex = 25;
            this.cboxBDS.SelectedIndexChanged += new System.EventHandler(this.cboxBDS_SelectedIndexChanged);
            // 
            // lblBDUSO
            // 
            this.lblBDUSO.AutoSize = true;
            this.lblBDUSO.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDUSO.Location = new System.Drawing.Point(167, 288);
            this.lblBDUSO.Name = "lblBDUSO";
            this.lblBDUSO.Size = new System.Drawing.Size(0, 28);
            this.lblBDUSO.TabIndex = 27;
            // 
            // btnAddCampo
            // 
            this.btnAddCampo.BackColor = System.Drawing.Color.Teal;
            this.btnAddCampo.Location = new System.Drawing.Point(1163, 28);
            this.btnAddCampo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCampo.Name = "btnAddCampo";
            this.btnAddCampo.Size = new System.Drawing.Size(108, 44);
            this.btnAddCampo.TabIndex = 28;
            this.btnAddCampo.Text = "Agregar Campo";
            this.btnAddCampo.UseVisualStyleBackColor = false;
            this.btnAddCampo.Click += new System.EventHandler(this.btnAddCampo_Click);
            // 
            // cboxLongirud
            // 
            this.cboxLongirud.FormattingEnabled = true;
            this.cboxLongirud.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cboxLongirud.Location = new System.Drawing.Point(93, 438);
            this.cboxLongirud.Margin = new System.Windows.Forms.Padding(2);
            this.cboxLongirud.Name = "cboxLongirud";
            this.cboxLongirud.Size = new System.Drawing.Size(258, 21);
            this.cboxLongirud.TabIndex = 30;
            // 
            // btnEliminarTabla
            // 
            this.btnEliminarTabla.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarTabla.Location = new System.Drawing.Point(1141, 397);
            this.btnEliminarTabla.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTabla.Name = "btnEliminarTabla";
            this.btnEliminarTabla.Size = new System.Drawing.Size(108, 44);
            this.btnEliminarTabla.TabIndex = 31;
            this.btnEliminarTabla.Text = "Eliminar Tabla";
            this.btnEliminarTabla.UseVisualStyleBackColor = false;
            this.btnEliminarTabla.Click += new System.EventHandler(this.btnEliminarTabla_Click);
            // 
            // dgvBasesDeDatos
            // 
            this.dgvBasesDeDatos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBasesDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasesDeDatos.Location = new System.Drawing.Point(395, 126);
            this.dgvBasesDeDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBasesDeDatos.Name = "dgvBasesDeDatos";
            this.dgvBasesDeDatos.RowTemplate.Height = 24;
            this.dgvBasesDeDatos.Size = new System.Drawing.Size(171, 137);
            this.dgvBasesDeDatos.TabIndex = 32;
            this.dgvBasesDeDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasesDeDatos_CellContentClick);
            this.dgvBasesDeDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasesDeDatos_CellDoubleClick);
            this.dgvBasesDeDatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBasesDeDatos_DataBindingComplete);
            // 
            // btnMostrarBasesDeDatos
            // 
            this.btnMostrarBasesDeDatos.BackColor = System.Drawing.Color.Teal;
            this.btnMostrarBasesDeDatos.Location = new System.Drawing.Point(1163, 485);
            this.btnMostrarBasesDeDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarBasesDeDatos.Name = "btnMostrarBasesDeDatos";
            this.btnMostrarBasesDeDatos.Size = new System.Drawing.Size(116, 27);
            this.btnMostrarBasesDeDatos.TabIndex = 33;
            this.btnMostrarBasesDeDatos.Text = "Mostrar Bases";
            this.btnMostrarBasesDeDatos.UseVisualStyleBackColor = false;
            this.btnMostrarBasesDeDatos.Click += new System.EventHandler(this.btnMostrarBasesDeDatos_Click);
            // 
            // btnModificarDato
            // 
            this.btnModificarDato.BackColor = System.Drawing.Color.Teal;
            this.btnModificarDato.Location = new System.Drawing.Point(1176, 271);
            this.btnModificarDato.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarDato.Name = "btnModificarDato";
            this.btnModificarDato.Size = new System.Drawing.Size(108, 44);
            this.btnModificarDato.TabIndex = 34;
            this.btnModificarDato.Text = "Modificar";
            this.btnModificarDato.UseVisualStyleBackColor = false;
            this.btnModificarDato.Click += new System.EventHandler(this.btnModificarDato_Click);
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(441, 293);
            this.txtLlave.Margin = new System.Windows.Forms.Padding(2);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(125, 20);
            this.txtLlave.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1108, 533);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Llave:";
            // 
            // txtAgregarCamposdat
            // 
            this.txtAgregarCamposdat.Location = new System.Drawing.Point(612, 386);
            this.txtAgregarCamposdat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgregarCamposdat.Multiline = true;
            this.txtAgregarCamposdat.Name = "txtAgregarCamposdat";
            this.txtAgregarCamposdat.Size = new System.Drawing.Size(303, 131);
            this.txtAgregarCamposdat.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1219, 526);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ingresa Datos a la Tabla:";
            // 
            // lblNTablasCampos
            // 
            this.lblNTablasCampos.AutoSize = true;
            this.lblNTablasCampos.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTablasCampos.Location = new System.Drawing.Point(788, 344);
            this.lblNTablasCampos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNTablasCampos.Name = "lblNTablasCampos";
            this.lblNTablasCampos.Size = new System.Drawing.Size(0, 28);
            this.lblNTablasCampos.TabIndex = 39;
            // 
            // btnUsar
            // 
            this.btnUsar.BackColor = System.Drawing.Color.Teal;
            this.btnUsar.Location = new System.Drawing.Point(1163, 188);
            this.btnUsar.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(93, 41);
            this.btnUsar.TabIndex = 40;
            this.btnUsar.Text = "Usar Tabla";
            this.btnUsar.UseVisualStyleBackColor = false;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // txtManual
            // 
            this.txtManual.Location = new System.Drawing.Point(614, 220);
            this.txtManual.Margin = new System.Windows.Forms.Padding(2);
            this.txtManual.Multiline = true;
            this.txtManual.Name = "txtManual";
            this.txtManual.Size = new System.Drawing.Size(301, 104);
            this.txtManual.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1097, 575);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Estructura de la Tabla:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(609, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(314, 91);
            this.label12.TabIndex = 43;
            this.label12.Text = resources.GetString("label12.Text");
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarCampoTBL
            // 
            this.btnEliminarCampoTBL.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarCampoTBL.Location = new System.Drawing.Point(1176, 328);
            this.btnEliminarCampoTBL.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCampoTBL.Name = "btnEliminarCampoTBL";
            this.btnEliminarCampoTBL.Size = new System.Drawing.Size(108, 44);
            this.btnEliminarCampoTBL.TabIndex = 47;
            this.btnEliminarCampoTBL.Text = "Eliminar";
            this.btnEliminarCampoTBL.UseVisualStyleBackColor = false;
            this.btnEliminarCampoTBL.Click += new System.EventHandler(this.btnEliminarCampoTBL_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Ingresa Base de Datos:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(175, 19);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "Base de Datos Seleccionada:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(29, 171);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(158, 43);
            this.metroButton1.TabIndex = 50;
            this.metroButton1.Text = "Crear";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(193, 171);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(158, 43);
            this.metroButton2.TabIndex = 51;
            this.metroButton2.Text = "Eliminar";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(29, 220);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(322, 43);
            this.metroButton3.TabIndex = 52;
            this.metroButton3.Text = "Usar Base de Datos";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(395, 87);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(171, 32);
            this.metroButton4.TabIndex = 53;
            this.metroButton4.Text = "Mostrar Bases";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 293);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(139, 19);
            this.metroLabel3.TabIndex = 54;
            this.metroLabel3.Text = "Base de Datos en Uso:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 341);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 19);
            this.metroLabel4.TabIndex = 55;
            this.metroLabel4.Text = "Nombre de Tabla:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 372);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(129, 19);
            this.metroLabel5.TabIndex = 56;
            this.metroLabel5.Text = "Nombre de Campo:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(27, 406);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 19);
            this.metroLabel6.TabIndex = 57;
            this.metroLabel6.Text = "Tipo de Dato:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(29, 438);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 58;
            this.metroLabel7.Text = "Longitud:";
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(29, 475);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(158, 33);
            this.metroButton5.TabIndex = 59;
            this.metroButton5.Text = "Agregar Campo";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(193, 475);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(158, 34);
            this.metroButton6.TabIndex = 60;
            this.metroButton6.Text = "Crear Tabla";
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(29, 514);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(322, 34);
            this.metroButton7.TabIndex = 61;
            this.metroButton7.Text = "Eliminar Tabla";
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(395, 423);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(171, 34);
            this.metroButton8.TabIndex = 62;
            this.metroButton8.Text = "Mostrar Tablas";
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(29, 554);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(322, 41);
            this.metroButton9.TabIndex = 63;
            this.metroButton9.Text = "Usar Tabla";
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(395, 293);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 64;
            this.metroLabel8.Text = "Llave:";
            // 
            // metroButton10
            // 
            this.metroButton10.Location = new System.Drawing.Point(395, 326);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(171, 34);
            this.metroButton10.TabIndex = 65;
            this.metroButton10.Text = "Borrar Campo";
            this.metroButton10.Click += new System.EventHandler(this.metroButton10_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(685, 188);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(133, 19);
            this.metroLabel9.TabIndex = 66;
            this.metroLabel9.Text = "Estructura de la Tabla";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(625, 353);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(158, 19);
            this.metroLabel10.TabIndex = 67;
            this.metroLabel10.Text = "Ingrese Datos de la Tabla:";
            // 
            // metroButton11
            // 
            this.metroButton11.Location = new System.Drawing.Point(612, 522);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(149, 37);
            this.metroButton11.TabIndex = 68;
            this.metroButton11.Text = "Agregar";
            this.metroButton11.Click += new System.EventHandler(this.metroButton11_Click);
            // 
            // metroButton12
            // 
            this.metroButton12.Location = new System.Drawing.Point(766, 522);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(149, 37);
            this.metroButton12.TabIndex = 69;
            this.metroButton12.Text = "Eliminar";
            this.metroButton12.Click += new System.EventHandler(this.metroButton12_Click);
            // 
            // metroButton13
            // 
            this.metroButton13.Location = new System.Drawing.Point(612, 563);
            this.metroButton13.Name = "metroButton13";
            this.metroButton13.Size = new System.Drawing.Size(303, 37);
            this.metroButton13.TabIndex = 70;
            this.metroButton13.Text = "Modificar";
            this.metroButton13.Click += new System.EventHandler(this.metroButton13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 634);
            this.Controls.Add(this.metroButton13);
            this.Controls.Add(this.metroButton12);
            this.Controls.Add(this.metroButton11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroButton10);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroButton9);
            this.Controls.Add(this.metroButton8);
            this.Controls.Add(this.metroButton7);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnEliminarCampoTBL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtManual);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.lblNTablasCampos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAgregarCamposdat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLlave);
            this.Controls.Add(this.btnModificarDato);
            this.Controls.Add(this.btnMostrarBasesDeDatos);
            this.Controls.Add(this.dgvBasesDeDatos);
            this.Controls.Add(this.btnEliminarTabla);
            this.Controls.Add(this.cboxLongirud);
            this.Controls.Add(this.btnAddCampo);
            this.Controls.Add(this.lblBDUSO);
            this.Controls.Add(this.cboxBDS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.btnCrearTabla);
            this.Controls.Add(this.txtNombreCampo);
            this.Controls.Add(this.btnBorrarCampo);
            this.Controls.Add(this.cboxTipoDato);
            this.Controls.Add(this.txtNombreTabla);
            this.Controls.Add(this.Agregarjjjj);
            this.Controls.Add(this.btnEliminarBD);
            this.Controls.Add(this.btnUsarBD);
            this.Controls.Add(this.txtNombreBD);
            this.Controls.Add(this.btnCrearBD);
            this.Name = "Form1";
            this.Text = "Gestor de Base de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasesDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearBD;
        private System.Windows.Forms.TextBox txtNombreBD;
        private System.Windows.Forms.Button btnUsarBD;
        private System.Windows.Forms.Button btnEliminarBD;
        private System.Windows.Forms.Button Agregarjjjj;
        private System.Windows.Forms.TextBox txtNombreTabla;
        private System.Windows.Forms.ComboBox cboxTipoDato;
        private System.Windows.Forms.Button btnBorrarCampo;
        private System.Windows.Forms.TextBox txtNombreCampo;
        private System.Windows.Forms.Button btnCrearTabla;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxBDS;
        private System.Windows.Forms.Label lblBDUSO;
        private System.Windows.Forms.Button btnAddCampo;
        private System.Windows.Forms.ComboBox cboxLongirud;
        private System.Windows.Forms.Button btnEliminarTabla;
        private System.Windows.Forms.DataGridView dgvBasesDeDatos;
        private System.Windows.Forms.Button btnMostrarBasesDeDatos;
        private System.Windows.Forms.Button btnModificarDato;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAgregarCamposdat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNTablasCampos;
        private System.Windows.Forms.Button btnUsar;
        private System.Windows.Forms.TextBox txtManual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEliminarCampoTBL;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton metroButton11;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton13;
    }
}

