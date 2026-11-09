#nullable disable
namespace EstructurasDatos
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPrincipal = new TabControl();
            tabArreglos = new TabPage();
            tlp1 = new TableLayoutPanel();
            pnl1 = new Panel();
            lblTamanio = new Label();
            nudTamanio = new NumericUpDown();
            btnGenerar = new Button();
            lblNuevoTam = new Label();
            nudNuevoTam = new NumericUpDown();
            btnRedimensionar = new Button();
            btnAgregar = new Button();
            btnLimpiarLog1 = new Button();
            lblInfoArr = new Label();
            lst1 = new ListView();
            colIndice = new ColumnHeader();
            colValor = new ColumnHeader();
            colOrigen = new ColumnHeader();
            txtLog1 = new TextBox();
            tabHeap = new TabPage();
            tlp2 = new TableLayoutPanel();
            pnl2 = new Panel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            lblPromedio = new Label();
            nudPromedio = new NumericUpDown();
            btnInsertarInicio = new Button();
            btnInsertarFinal = new Button();
            btnEliminar = new Button();
            btnReferencias = new Button();
            btnWeak = new Button();
            btnGC = new Button();
            btnVaciar = new Button();
            lblMemoria = new Label();
            lst2 = new ListView();
            colPos = new ColumnHeader();
            colNombre = new ColumnHeader();
            colMatricula = new ColumnHeader();
            colPromedio = new ColumnHeader();
            colIdObj = new ColumnHeader();
            colSig = new ColumnHeader();
            txtLog2 = new TextBox();
            tabDesempeno = new TabPage();
            tlp3 = new TableLayoutPanel();
            pnl3 = new Panel();
            lblN = new Label();
            nudN = new NumericUpDown();
            btnEjecutarMem = new Button();
            lblEstadoMem = new Label();
            lblNotaMem = new Label();
            lst3 = new ListView();
            colEstructura = new ColumnHeader();
            colTiempo = new ColumnHeader();
            colMemoria = new ColumnHeader();
            colGen0 = new ColumnHeader();
            colGen1 = new ColumnHeader();
            colGen2 = new ColumnHeader();
            colComplejidad = new ColumnHeader();
            colVerif = new ColumnHeader();
            txtLog3 = new TextBox();
            tabAlgoritmos = new TabPage();
            tlp4 = new TableLayoutPanel();
            pnl4 = new Panel();
            lblTamanios = new Label();
            txtTamanios = new TextBox();
            btnComparar = new Button();
            lblEstadoAlg = new Label();
            lblNotaAlg = new Label();
            lst4 = new ListView();
            colN = new ColumnHeader();
            colBurbuja = new ColumnHeader();
            colMerge = new ColumnHeader();
            colCompB = new ColumnHeader();
            colCompM = new ColumnHeader();
            colMemM = new ColumnHeader();
            colFactor = new ColumnHeader();
            txtLog4 = new TextBox();
            tabPrincipal.SuspendLayout();
            tabArreglos.SuspendLayout();
            tlp1.SuspendLayout();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTamanio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNuevoTam).BeginInit();
            tabHeap.SuspendLayout();
            tlp2.SuspendLayout();
            pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPromedio).BeginInit();
            tabDesempeno.SuspendLayout();
            tlp3.SuspendLayout();
            pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudN).BeginInit();
            tabAlgoritmos.SuspendLayout();
            tlp4.SuspendLayout();
            pnl4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabArreglos);
            tabPrincipal.Controls.Add(tabHeap);
            tabPrincipal.Controls.Add(tabDesempeno);
            tabPrincipal.Controls.Add(tabAlgoritmos);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(0, 0);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(1100, 720);
            tabPrincipal.TabIndex = 0;
            // 
            // tabArreglos
            // 
            tabArreglos.Controls.Add(tlp1);
            tabArreglos.Location = new Point(4, 24);
            tabArreglos.Name = "tabArreglos";
            tabArreglos.Padding = new Padding(3);
            tabArreglos.Size = new Size(1092, 692);
            tabArreglos.TabIndex = 0;
            tabArreglos.Text = "Arreglos y redimensión";
            tabArreglos.UseVisualStyleBackColor = true;
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.Controls.Add(pnl1, 0, 0);
            tlp1.Controls.Add(lst1, 0, 1);
            tlp1.Controls.Add(txtLog1, 0, 2);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(3, 3);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 3;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tlp1.Size = new Size(1086, 686);
            tlp1.TabIndex = 0;
            // 
            // pnl1
            // 
            pnl1.Controls.Add(lblTamanio);
            pnl1.Controls.Add(nudTamanio);
            pnl1.Controls.Add(btnGenerar);
            pnl1.Controls.Add(lblNuevoTam);
            pnl1.Controls.Add(nudNuevoTam);
            pnl1.Controls.Add(btnRedimensionar);
            pnl1.Controls.Add(btnAgregar);
            pnl1.Controls.Add(btnLimpiarLog1);
            pnl1.Controls.Add(lblInfoArr);
            pnl1.Dock = DockStyle.Fill;
            pnl1.Location = new Point(3, 3);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(1080, 119);
            pnl1.TabIndex = 0;
            // 
            // lblTamanio
            // 
            lblTamanio.AutoSize = true;
            lblTamanio.Location = new Point(15, 18);
            lblTamanio.Name = "lblTamanio";
            lblTamanio.Size = new Size(87, 15);
            lblTamanio.TabIndex = 0;
            lblTamanio.Text = "Tamaño inicial:";
            // 
            // nudTamanio
            // 
            nudTamanio.Location = new Point(115, 14);
            nudTamanio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTamanio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTamanio.Name = "nudTamanio";
            nudTamanio.Size = new Size(80, 23);
            nudTamanio.TabIndex = 1;
            nudTamanio.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(210, 12);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(210, 28);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar arreglo aleatorio";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblNuevoTam
            // 
            lblNuevoTam.AutoSize = true;
            lblNuevoTam.Location = new Point(445, 18);
            lblNuevoTam.Name = "lblNuevoTam";
            lblNuevoTam.Size = new Size(89, 15);
            lblNuevoTam.TabIndex = 3;
            lblNuevoTam.Text = "Nuevo tamaño:";
            // 
            // nudNuevoTam
            // 
            nudNuevoTam.Location = new Point(540, 14);
            nudNuevoTam.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudNuevoTam.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNuevoTam.Name = "nudNuevoTam";
            nudNuevoTam.Size = new Size(80, 23);
            nudNuevoTam.TabIndex = 4;
            nudNuevoTam.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // btnRedimensionar
            // 
            btnRedimensionar.Location = new Point(635, 12);
            btnRedimensionar.Name = "btnRedimensionar";
            btnRedimensionar.Size = new Size(230, 28);
            btnRedimensionar.TabIndex = 5;
            btnRedimensionar.Text = "Redimensionar";
            btnRedimensionar.UseVisualStyleBackColor = true;
            btnRedimensionar.Click += btnRedimensionar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 52);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(180, 28);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar elemento";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiarLog1
            // 
            btnLimpiarLog1.Location = new Point(210, 52);
            btnLimpiarLog1.Name = "btnLimpiarLog1";
            btnLimpiarLog1.Size = new Size(210, 28);
            btnLimpiarLog1.TabIndex = 7;
            btnLimpiarLog1.Text = "Limpiar registro";
            btnLimpiarLog1.UseVisualStyleBackColor = true;
            btnLimpiarLog1.Click += btnLimpiarLog1_Click;
            // 
            // lblInfoArr
            // 
            lblInfoArr.AutoSize = true;
            lblInfoArr.Location = new Point(15, 95);
            lblInfoArr.Name = "lblInfoArr";
            lblInfoArr.Size = new Size(150, 15);
            lblInfoArr.TabIndex = 8;
            lblInfoArr.Text = "Arreglo: (aún no generado)";
            // 
            // lst1
            // 
            lst1.Columns.AddRange(new ColumnHeader[] { colIndice, colValor, colOrigen });
            lst1.Dock = DockStyle.Fill;
            lst1.FullRowSelect = true;
            lst1.GridLines = true;
            lst1.Location = new Point(3, 128);
            lst1.MultiSelect = false;
            lst1.Name = "lst1";
            lst1.Size = new Size(1080, 405);
            lst1.TabIndex = 1;
            lst1.UseCompatibleStateImageBehavior = false;
            lst1.View = View.Details;
            // 
            // colIndice
            // 
            colIndice.Name = "colIndice";
            colIndice.Text = "Índice";
            colIndice.Width = 80;
            // 
            // colValor
            // 
            colValor.Name = "colValor";
            colValor.Text = "Valor";
            colValor.TextAlign = HorizontalAlignment.Right;
            colValor.Width = 120;
            // 
            // colOrigen
            // 
            colOrigen.Name = "colOrigen";
            colOrigen.Text = "Estado del elemento";
            colOrigen.Width = 280;
            // 
            // txtLog1
            // 
            txtLog1.BackColor = Color.White;
            txtLog1.Dock = DockStyle.Fill;
            txtLog1.Font = new Font("Consolas", 9F);
            txtLog1.Location = new Point(3, 539);
            txtLog1.Multiline = true;
            txtLog1.Name = "txtLog1";
            txtLog1.ReadOnly = true;
            txtLog1.ScrollBars = ScrollBars.Vertical;
            txtLog1.Size = new Size(1080, 144);
            txtLog1.TabIndex = 2;
            // 
            // tabHeap
            // 
            tabHeap.Controls.Add(tlp2);
            tabHeap.Location = new Point(4, 24);
            tabHeap.Name = "tabHeap";
            tabHeap.Padding = new Padding(3);
            tabHeap.Size = new Size(192, 72);
            tabHeap.TabIndex = 1;
            tabHeap.Text = "Memoria dinámica";
            tabHeap.UseVisualStyleBackColor = true;
            // 
            // tlp2
            // 
            tlp2.ColumnCount = 1;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp2.Controls.Add(pnl2, 0, 0);
            tlp2.Controls.Add(lst2, 0, 1);
            tlp2.Controls.Add(txtLog2, 0, 2);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(3, 3);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 3;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tlp2.Size = new Size(186, 66);
            tlp2.TabIndex = 0;
            // 
            // pnl2
            // 
            pnl2.Controls.Add(lblNombre);
            pnl2.Controls.Add(txtNombre);
            pnl2.Controls.Add(lblMatricula);
            pnl2.Controls.Add(txtMatricula);
            pnl2.Controls.Add(lblPromedio);
            pnl2.Controls.Add(nudPromedio);
            pnl2.Controls.Add(btnInsertarInicio);
            pnl2.Controls.Add(btnInsertarFinal);
            pnl2.Controls.Add(btnEliminar);
            pnl2.Controls.Add(btnReferencias);
            pnl2.Controls.Add(btnWeak);
            pnl2.Controls.Add(btnGC);
            pnl2.Controls.Add(btnVaciar);
            pnl2.Controls.Add(lblMemoria);
            pnl2.Dock = DockStyle.Fill;
            pnl2.Location = new Point(3, 3);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(180, 119);
            pnl2.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 14);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(265, 18);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(60, 15);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(335, 14);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(110, 23);
            txtMatricula.TabIndex = 3;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(465, 18);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(62, 15);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Promedio:";
            // 
            // nudPromedio
            // 
            nudPromedio.Location = new Point(535, 14);
            nudPromedio.Name = "nudPromedio";
            nudPromedio.Size = new Size(70, 23);
            nudPromedio.TabIndex = 5;
            nudPromedio.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // btnInsertarInicio
            // 
            btnInsertarInicio.Location = new Point(630, 12);
            btnInsertarInicio.Name = "btnInsertarInicio";
            btnInsertarInicio.Size = new Size(150, 28);
            btnInsertarInicio.TabIndex = 6;
            btnInsertarInicio.Text = "Insertar al inicio";
            btnInsertarInicio.UseVisualStyleBackColor = true;
            btnInsertarInicio.Click += btnInsertarInicio_Click;
            // 
            // btnInsertarFinal
            // 
            btnInsertarFinal.Location = new Point(790, 12);
            btnInsertarFinal.Name = "btnInsertarFinal";
            btnInsertarFinal.Size = new Size(150, 28);
            btnInsertarFinal.TabIndex = 7;
            btnInsertarFinal.Text = "Insertar al final";
            btnInsertarFinal.UseVisualStyleBackColor = true;
            btnInsertarFinal.Click += btnInsertarFinal_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(15, 52);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 28);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar por matrícula";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnReferencias
            // 
            btnReferencias.Location = new Point(195, 52);
            btnReferencias.Name = "btnReferencias";
            btnReferencias.Size = new Size(210, 28);
            btnReferencias.TabIndex = 9;
            btnReferencias.Text = "Demo: referencias en el Heap";
            btnReferencias.UseVisualStyleBackColor = true;
            btnReferencias.Click += btnReferencias_Click;
            // 
            // btnWeak
            // 
            btnWeak.Location = new Point(415, 52);
            btnWeak.Name = "btnWeak";
            btnWeak.Size = new Size(220, 28);
            btnWeak.TabIndex = 10;
            btnWeak.Text = "Demo: recolección de basura";
            btnWeak.UseVisualStyleBackColor = true;
            btnWeak.Click += btnWeak_Click;
            // 
            // btnGC
            // 
            btnGC.Location = new Point(645, 52);
            btnGC.Name = "btnGC";
            btnGC.Size = new Size(150, 28);
            btnGC.TabIndex = 11;
            btnGC.Text = "Forzar GC.Collect()";
            btnGC.UseVisualStyleBackColor = true;
            btnGC.Click += btnGC_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(805, 52);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(135, 28);
            btnVaciar.TabIndex = 12;
            btnVaciar.Text = "Vaciar lista";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // lblMemoria
            // 
            lblMemoria.AutoSize = true;
            lblMemoria.Location = new Point(15, 95);
            lblMemoria.Name = "lblMemoria";
            lblMemoria.Size = new Size(138, 15);
            lblMemoria.TabIndex = 13;
            lblMemoria.Text = "Memoria administrada: -";
            // 
            // lst2
            // 
            lst2.Columns.AddRange(new ColumnHeader[] { colPos, colNombre, colMatricula, colPromedio, colIdObj, colSig });
            lst2.Dock = DockStyle.Fill;
            lst2.FullRowSelect = true;
            lst2.GridLines = true;
            lst2.Location = new Point(0, 0);
            lst2.MultiSelect = false;
            lst2.Name = "lst2";
            lst2.Size = new Size(121, 97);
            lst2.TabIndex = 1;
            lst2.UseCompatibleStateImageBehavior = false;
            lst2.View = View.Details;
            // 
            // colPos
            // 
            colPos.Name = "colPos";
            colPos.Text = "Pos.";
            colPos.Width = 50;
            // 
            // colNombre
            // 
            colNombre.Name = "colNombre";
            colNombre.Text = "Nombre";
            colNombre.Width = 200;
            // 
            // colMatricula
            // 
            colMatricula.Name = "colMatricula";
            colMatricula.Text = "Matrícula";
            colMatricula.Width = 120;
            // 
            // colPromedio
            // 
            colPromedio.Name = "colPromedio";
            colPromedio.Text = "Promedio";
            colPromedio.TextAlign = HorizontalAlignment.Right;
            colPromedio.Width = 90;
            // 
            // colIdObj
            // 
            colIdObj.Name = "colIdObj";
            colIdObj.Text = "ID del objeto (hash)";
            colIdObj.Width = 170;
            // 
            // colSig
            // 
            colSig.Name = "colSig";
            colSig.Text = "Apunta a (Siguiente)";
            colSig.Width = 170;
            // 
            // txtLog2
            // 
            txtLog2.BackColor = Color.White;
            txtLog2.Dock = DockStyle.Fill;
            txtLog2.Font = new Font("Consolas", 9F);
            txtLog2.Location = new Point(3, -81);
            txtLog2.Multiline = true;
            txtLog2.Name = "txtLog2";
            txtLog2.ReadOnly = true;
            txtLog2.ScrollBars = ScrollBars.Vertical;
            txtLog2.Size = new Size(180, 144);
            txtLog2.TabIndex = 2;
            // 
            // tabDesempeno
            // 
            tabDesempeno.Controls.Add(tlp3);
            tabDesempeno.Location = new Point(4, 24);
            tabDesempeno.Name = "tabDesempeno";
            tabDesempeno.Padding = new Padding(3);
            tabDesempeno.Size = new Size(192, 72);
            tabDesempeno.TabIndex = 2;
            tabDesempeno.Text = "Desempeño estático vs dinámico";
            tabDesempeno.UseVisualStyleBackColor = true;
            // 
            // tlp3
            // 
            tlp3.ColumnCount = 1;
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp3.Controls.Add(pnl3, 0, 0);
            tlp3.Controls.Add(lst3, 0, 1);
            tlp3.Controls.Add(txtLog3, 0, 2);
            tlp3.Dock = DockStyle.Fill;
            tlp3.Location = new Point(3, 3);
            tlp3.Name = "tlp3";
            tlp3.RowCount = 3;
            tlp3.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp3.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tlp3.Size = new Size(186, 66);
            tlp3.TabIndex = 0;
            // 
            // pnl3
            // 
            pnl3.Controls.Add(lblN);
            pnl3.Controls.Add(nudN);
            pnl3.Controls.Add(btnEjecutarMem);
            pnl3.Controls.Add(lblEstadoMem);
            pnl3.Controls.Add(lblNotaMem);
            pnl3.Dock = DockStyle.Fill;
            pnl3.Location = new Point(3, 3);
            pnl3.Name = "pnl3";
            pnl3.Size = new Size(180, 104);
            pnl3.TabIndex = 0;
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(15, 18);
            lblN.Name = "lblN";
            lblN.Size = new Size(136, 15);
            lblN.TabIndex = 0;
            lblN.Text = "Elementos a insertar (N):";
            // 
            // nudN
            // 
            nudN.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudN.Location = new Point(180, 14);
            nudN.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudN.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudN.Name = "nudN";
            nudN.Size = new Size(100, 23);
            nudN.TabIndex = 1;
            nudN.Value = new decimal(new int[] { 20000, 0, 0, 0 });
            // 
            // btnEjecutarMem
            // 
            btnEjecutarMem.Location = new Point(300, 12);
            btnEjecutarMem.Name = "btnEjecutarMem";
            btnEjecutarMem.Size = new Size(190, 28);
            btnEjecutarMem.TabIndex = 2;
            btnEjecutarMem.Text = "Ejecutar pruebas";
            btnEjecutarMem.UseVisualStyleBackColor = true;
            btnEjecutarMem.Click += btnEjecutarMem_Click;
            // 
            // lblEstadoMem
            // 
            lblEstadoMem.AutoSize = true;
            lblEstadoMem.Location = new Point(510, 18);
            lblEstadoMem.Name = "lblEstadoMem";
            lblEstadoMem.Size = new Size(35, 15);
            lblEstadoMem.TabIndex = 3;
            lblEstadoMem.Text = "Listo.";
            // 
            // lblNotaMem
            // 
            lblNotaMem.Location = new Point(15, 55);
            lblNotaMem.Name = "lblNotaMem";
            lblNotaMem.Size = new Size(1000, 45);
            lblNotaMem.TabIndex = 4;
            lblNotaMem.Text = resources.GetString("lblNotaMem.Text");
            // 
            // lst3
            // 
            lst3.Columns.AddRange(new ColumnHeader[] { colEstructura, colTiempo, colMemoria, colGen0, colGen1, colGen2, colComplejidad, colVerif });
            lst3.Dock = DockStyle.Fill;
            lst3.FullRowSelect = true;
            lst3.GridLines = true;
            lst3.Location = new Point(0, 0);
            lst3.MultiSelect = false;
            lst3.Name = "lst3";
            lst3.Size = new Size(121, 97);
            lst3.TabIndex = 1;
            lst3.UseCompatibleStateImageBehavior = false;
            lst3.View = View.Details;
            // 
            // colEstructura
            // 
            colEstructura.Name = "colEstructura";
            colEstructura.Text = "Estructura";
            colEstructura.Width = 330;
            // 
            // colTiempo
            // 
            colTiempo.Name = "colTiempo";
            colTiempo.Text = "Tiempo (ms)";
            colTiempo.TextAlign = HorizontalAlignment.Right;
            colTiempo.Width = 110;
            // 
            // colMemoria
            // 
            colMemoria.Name = "colMemoria";
            colMemoria.Text = "Memoria asignada (KB)";
            colMemoria.TextAlign = HorizontalAlignment.Right;
            colMemoria.Width = 160;
            // 
            // colGen0
            // 
            colGen0.Name = "colGen0";
            colGen0.Text = "GC Gen0";
            colGen0.TextAlign = HorizontalAlignment.Right;
            colGen0.Width = 80;
            // 
            // colGen1
            // 
            colGen1.Name = "colGen1";
            colGen1.Text = "GC Gen1";
            colGen1.TextAlign = HorizontalAlignment.Right;
            colGen1.Width = 80;
            // 
            // colGen2
            // 
            colGen2.Name = "colGen2";
            colGen2.Text = "GC Gen2";
            colGen2.TextAlign = HorizontalAlignment.Right;
            colGen2.Width = 80;
            // 
            // colComplejidad
            // 
            colComplejidad.Name = "colComplejidad";
            colComplejidad.Text = "Complejidad";
            colComplejidad.Width = 120;
            // 
            // colVerif
            // 
            colVerif.Name = "colVerif";
            colVerif.Text = "Verificación";
            colVerif.TextAlign = HorizontalAlignment.Right;
            colVerif.Width = 110;
            // 
            // txtLog3
            // 
            txtLog3.BackColor = Color.White;
            txtLog3.Dock = DockStyle.Fill;
            txtLog3.Font = new Font("Consolas", 9F);
            txtLog3.Location = new Point(3, -101);
            txtLog3.Multiline = true;
            txtLog3.Name = "txtLog3";
            txtLog3.ReadOnly = true;
            txtLog3.ScrollBars = ScrollBars.Vertical;
            txtLog3.Size = new Size(180, 164);
            txtLog3.TabIndex = 2;
            // 
            // tabAlgoritmos
            // 
            tabAlgoritmos.Controls.Add(tlp4);
            tabAlgoritmos.Location = new Point(4, 24);
            tabAlgoritmos.Name = "tabAlgoritmos";
            tabAlgoritmos.Padding = new Padding(3);
            tabAlgoritmos.Size = new Size(192, 72);
            tabAlgoritmos.TabIndex = 3;
            tabAlgoritmos.Text = "Algoritmos";
            tabAlgoritmos.UseVisualStyleBackColor = true;
            // 
            // tlp4
            // 
            tlp4.ColumnCount = 1;
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp4.Controls.Add(pnl4, 0, 0);
            tlp4.Controls.Add(lst4, 0, 1);
            tlp4.Controls.Add(txtLog4, 0, 2);
            tlp4.Dock = DockStyle.Fill;
            tlp4.Location = new Point(3, 3);
            tlp4.Name = "tlp4";
            tlp4.RowCount = 3;
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 170F));
            tlp4.Size = new Size(186, 66);
            tlp4.TabIndex = 0;
            // 
            // pnl4
            // 
            pnl4.Controls.Add(lblTamanios);
            pnl4.Controls.Add(txtTamanios);
            pnl4.Controls.Add(btnComparar);
            pnl4.Controls.Add(lblEstadoAlg);
            pnl4.Controls.Add(lblNotaAlg);
            pnl4.Dock = DockStyle.Fill;
            pnl4.Location = new Point(3, 3);
            pnl4.Name = "pnl4";
            pnl4.Size = new Size(180, 104);
            pnl4.TabIndex = 0;
            // 
            // lblTamanios
            // 
            lblTamanios.AutoSize = true;
            lblTamanios.Location = new Point(15, 18);
            lblTamanios.Name = "lblTamanios";
            lblTamanios.Size = new Size(268, 15);
            lblTamanios.TabIndex = 0;
            lblTamanios.Text = "Tamaños de N (separados por coma, máx. 50000):";
            // 
            // txtTamanios
            // 
            txtTamanios.Location = new Point(310, 14);
            txtTamanios.Name = "txtTamanios";
            txtTamanios.Size = new Size(300, 23);
            txtTamanios.TabIndex = 1;
            txtTamanios.Text = "500,1000,2000,5000,10000,20000";
            // 
            // btnComparar
            // 
            btnComparar.Location = new Point(630, 12);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(270, 28);
            btnComparar.TabIndex = 2;
            btnComparar.Text = "Comparar Burbuja vs Merge Sort";
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += btnComparar_Click;
            // 
            // lblEstadoAlg
            // 
            lblEstadoAlg.AutoSize = true;
            lblEstadoAlg.Location = new Point(15, 58);
            lblEstadoAlg.Name = "lblEstadoAlg";
            lblEstadoAlg.Size = new Size(35, 15);
            lblEstadoAlg.TabIndex = 3;
            lblEstadoAlg.Text = "Listo.";
            // 
            // lblNotaAlg
            // 
            lblNotaAlg.Location = new Point(15, 80);
            lblNotaAlg.Name = "lblNotaAlg";
            lblNotaAlg.Size = new Size(1000, 25);
            lblNotaAlg.TabIndex = 4;
            lblNotaAlg.Text = "Problema: ordenar n enteros. Burbuja: tiempo O(n²), espacio O(1). Merge sort: tiempo O(n log n), espacio O(n).";
            // 
            // lst4
            // 
            lst4.Columns.AddRange(new ColumnHeader[] { colN, colBurbuja, colMerge, colCompB, colCompM, colMemM, colFactor });
            lst4.Dock = DockStyle.Fill;
            lst4.FullRowSelect = true;
            lst4.GridLines = true;
            lst4.Location = new Point(0, 0);
            lst4.MultiSelect = false;
            lst4.Name = "lst4";
            lst4.Size = new Size(121, 97);
            lst4.TabIndex = 1;
            lst4.UseCompatibleStateImageBehavior = false;
            lst4.View = View.Details;
            // 
            // colN
            // 
            colN.Name = "colN";
            colN.Text = "N";
            colN.TextAlign = HorizontalAlignment.Right;
            colN.Width = 90;
            // 
            // colBurbuja
            // 
            colBurbuja.Name = "colBurbuja";
            colBurbuja.Text = "Burbuja (ms)";
            colBurbuja.TextAlign = HorizontalAlignment.Right;
            colBurbuja.Width = 120;
            // 
            // colMerge
            // 
            colMerge.Name = "colMerge";
            colMerge.Text = "Merge Sort (ms)";
            colMerge.TextAlign = HorizontalAlignment.Right;
            colMerge.Width = 130;
            // 
            // colCompB
            // 
            colCompB.Name = "colCompB";
            colCompB.Text = "Comparaciones burbuja";
            colCompB.TextAlign = HorizontalAlignment.Right;
            colCompB.Width = 170;
            // 
            // colCompM
            // 
            colCompM.Name = "colCompM";
            colCompM.Text = "Comparaciones merge";
            colCompM.TextAlign = HorizontalAlignment.Right;
            colCompM.Width = 160;
            // 
            // colMemM
            // 
            colMemM.Name = "colMemM";
            colMemM.Text = "Memoria extra merge (KB)";
            colMemM.TextAlign = HorizontalAlignment.Right;
            colMemM.Width = 175;
            // 
            // colFactor
            // 
            colFactor.Name = "colFactor";
            colFactor.Text = "Burbuja ÷ Merge";
            colFactor.TextAlign = HorizontalAlignment.Right;
            colFactor.Width = 130;
            // 
            // txtLog4
            // 
            txtLog4.BackColor = Color.White;
            txtLog4.Dock = DockStyle.Fill;
            txtLog4.Font = new Font("Consolas", 9F);
            txtLog4.Location = new Point(3, -101);
            txtLog4.Multiline = true;
            txtLog4.Name = "txtLog4";
            txtLog4.ReadOnly = true;
            txtLog4.ScrollBars = ScrollBars.Vertical;
            txtLog4.Size = new Size(180, 164);
            txtLog4.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 720);
            Controls.Add(tabPrincipal);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form 1";
            Load += Form1_Load;
            tabPrincipal.ResumeLayout(false);
            tabArreglos.ResumeLayout(false);
            tlp1.ResumeLayout(false);
            tlp1.PerformLayout();
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTamanio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNuevoTam).EndInit();
            tabHeap.ResumeLayout(false);
            tlp2.ResumeLayout(false);
            tlp2.PerformLayout();
            pnl2.ResumeLayout(false);
            pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPromedio).EndInit();
            tabDesempeno.ResumeLayout(false);
            tlp3.ResumeLayout(false);
            tlp3.PerformLayout();
            pnl3.ResumeLayout(false);
            pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudN).EndInit();
            tabAlgoritmos.ResumeLayout(false);
            tlp4.ResumeLayout(false);
            tlp4.PerformLayout();
            pnl4.ResumeLayout(false);
            pnl4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabArreglos;
        private System.Windows.Forms.TabPage tabHeap;
        private System.Windows.Forms.TabPage tabDesempeno;
        private System.Windows.Forms.TabPage tabAlgoritmos;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.ListView lst1;
        private System.Windows.Forms.TextBox txtLog1;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.NumericUpDown nudTamanio;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblNuevoTam;
        private System.Windows.Forms.NumericUpDown nudNuevoTam;
        private System.Windows.Forms.Button btnRedimensionar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiarLog1;
        private System.Windows.Forms.Label lblInfoArr;
        private System.Windows.Forms.ColumnHeader colIndice;
        private System.Windows.Forms.ColumnHeader colValor;
        private System.Windows.Forms.ColumnHeader colOrigen;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ListView lst2;
        private System.Windows.Forms.TextBox txtLog2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.NumericUpDown nudPromedio;
        private System.Windows.Forms.Button btnInsertarInicio;
        private System.Windows.Forms.Button btnInsertarFinal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReferencias;
        private System.Windows.Forms.Button btnWeak;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.ColumnHeader colPos;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colMatricula;
        private System.Windows.Forms.ColumnHeader colPromedio;
        private System.Windows.Forms.ColumnHeader colIdObj;
        private System.Windows.Forms.ColumnHeader colSig;
        private System.Windows.Forms.TableLayoutPanel tlp3;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.ListView lst3;
        private System.Windows.Forms.TextBox txtLog3;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Button btnEjecutarMem;
        private System.Windows.Forms.Label lblEstadoMem;
        private System.Windows.Forms.Label lblNotaMem;
        private System.Windows.Forms.ColumnHeader colEstructura;
        private System.Windows.Forms.ColumnHeader colTiempo;
        private System.Windows.Forms.ColumnHeader colMemoria;
        private System.Windows.Forms.ColumnHeader colGen0;
        private System.Windows.Forms.ColumnHeader colGen1;
        private System.Windows.Forms.ColumnHeader colGen2;
        private System.Windows.Forms.ColumnHeader colComplejidad;
        private System.Windows.Forms.ColumnHeader colVerif;
        private System.Windows.Forms.TableLayoutPanel tlp4;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.ListView lst4;
        private System.Windows.Forms.TextBox txtLog4;
        private System.Windows.Forms.Label lblTamanios;
        private System.Windows.Forms.TextBox txtTamanios;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblEstadoAlg;
        private System.Windows.Forms.Label lblNotaAlg;
        private System.Windows.Forms.ColumnHeader colN;
        private System.Windows.Forms.ColumnHeader colBurbuja;
        private System.Windows.Forms.ColumnHeader colMerge;
        private System.Windows.Forms.ColumnHeader colCompB;
        private System.Windows.Forms.ColumnHeader colCompM;
        private System.Windows.Forms.ColumnHeader colMemM;
        private System.Windows.Forms.ColumnHeader colFactor;
    }
}
