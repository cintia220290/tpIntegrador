
namespace mateAr_wf_PagoyEnvio
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboFormPago = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodSeguridad = new System.Windows.Forms.TextBox();
            this.txtVto = new System.Windows.Forms.TextBox();
            this.comboCuotas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNvaTarj = new System.Windows.Forms.Button();
            this.txtTarjAgendada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFormEnvio = new System.Windows.Forms.ComboBox();
            this.txtCostoEnvio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDatosSucursal = new System.Windows.Forms.Label();
            this.comboEmpCorreo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDomAgendado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiarDom = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarDom = new System.Windows.Forms.Button();
            this.btnBuscarTarj = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(403, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 484);
            this.panel2.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(235, 444);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 37);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarTarj);
            this.groupBox1.Controls.Add(this.comboFormPago);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCodSeguridad);
            this.groupBox1.Controls.Add(this.txtVto);
            this.groupBox1.Controls.Add(this.comboCuotas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnNvaTarj);
            this.groupBox1.Controls.Add(this.txtTarjAgendada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(373, 404);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmar Pago";
            // 
            // comboFormPago
            // 
            this.comboFormPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFormPago.FormattingEnabled = true;
            this.comboFormPago.Items.AddRange(new object[] {
            "Transferencia",
            "Tarjeta Débito",
            "Tarjeta Crédito"});
            this.comboFormPago.Location = new System.Drawing.Point(178, 123);
            this.comboFormPago.Margin = new System.Windows.Forms.Padding(2);
            this.comboFormPago.Name = "comboFormPago";
            this.comboFormPago.Size = new System.Drawing.Size(175, 24);
            this.comboFormPago.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Forma De Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(10, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Cod. Seguridad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(10, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Vencimiento";
            // 
            // txtCodSeguridad
            // 
            this.txtCodSeguridad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSeguridad.Location = new System.Drawing.Point(178, 327);
            this.txtCodSeguridad.Name = "txtCodSeguridad";
            this.txtCodSeguridad.Size = new System.Drawing.Size(175, 21);
            this.txtCodSeguridad.TabIndex = 29;
            // 
            // txtVto
            // 
            this.txtVto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVto.Location = new System.Drawing.Point(178, 297);
            this.txtVto.Name = "txtVto";
            this.txtVto.Size = new System.Drawing.Size(175, 21);
            this.txtVto.TabIndex = 28;
            // 
            // comboCuotas
            // 
            this.comboCuotas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCuotas.FormattingEnabled = true;
            this.comboCuotas.Items.AddRange(new object[] {
            "1 Cuota ",
            "3 Cuotas ",
            "6 Cuotas",
            "12 Cuotas"});
            this.comboCuotas.Location = new System.Drawing.Point(178, 355);
            this.comboCuotas.Margin = new System.Windows.Forms.Padding(2);
            this.comboCuotas.Name = "comboCuotas";
            this.comboCuotas.Size = new System.Drawing.Size(175, 25);
            this.comboCuotas.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 367);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad de Cuotas";
            // 
            // btnNvaTarj
            // 
            this.btnNvaTarj.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvaTarj.Location = new System.Drawing.Point(85, 237);
            this.btnNvaTarj.Margin = new System.Windows.Forms.Padding(2);
            this.btnNvaTarj.Name = "btnNvaTarj";
            this.btnNvaTarj.Size = new System.Drawing.Size(180, 37);
            this.btnNvaTarj.TabIndex = 15;
            this.btnNvaTarj.Text = "Nueva Tarjeta";
            this.btnNvaTarj.UseVisualStyleBackColor = true;
            // 
            // txtTarjAgendada
            // 
            this.txtTarjAgendada.AutoSize = true;
            this.txtTarjAgendada.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjAgendada.ForeColor = System.Drawing.Color.Black;
            this.txtTarjAgendada.Location = new System.Drawing.Point(10, 214);
            this.txtTarjAgendada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTarjAgendada.Name = "txtTarjAgendada";
            this.txtTarjAgendada.Size = new System.Drawing.Size(64, 16);
            this.txtTarjAgendada.TabIndex = 15;
            this.txtTarjAgendada.Text = "--------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarjeta Agendada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monto $ :";
            // 
            // txtMonto
            // 
            this.txtMonto.AutoSize = true;
            this.txtMonto.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.Black;
            this.txtMonto.Location = new System.Drawing.Point(160, 65);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(36, 28);
            this.txtMonto.TabIndex = 3;
            this.txtMonto.Text = "----";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarDom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboFormEnvio);
            this.groupBox2.Controls.Add(this.txtCostoEnvio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDatosSucursal);
            this.groupBox2.Controls.Add(this.comboEmpCorreo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDomAgendado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnCambiarDom);
            this.groupBox2.Controls.Add(this.txtPedido);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(11, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(373, 404);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmar Envio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Forma de Envio";
            // 
            // comboFormEnvio
            // 
            this.comboFormEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFormEnvio.FormattingEnabled = true;
            this.comboFormEnvio.Items.AddRange(new object[] {
            "Retiro en Sucursal",
            "Envio a Domicilio"});
            this.comboFormEnvio.Location = new System.Drawing.Point(143, 130);
            this.comboFormEnvio.Margin = new System.Windows.Forms.Padding(2);
            this.comboFormEnvio.Name = "comboFormEnvio";
            this.comboFormEnvio.Size = new System.Drawing.Size(185, 24);
            this.comboFormEnvio.TabIndex = 15;
            // 
            // txtCostoEnvio
            // 
            this.txtCostoEnvio.AutoSize = true;
            this.txtCostoEnvio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoEnvio.ForeColor = System.Drawing.Color.Black;
            this.txtCostoEnvio.Location = new System.Drawing.Point(160, 367);
            this.txtCostoEnvio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCostoEnvio.Name = "txtCostoEnvio";
            this.txtCostoEnvio.Size = new System.Drawing.Size(38, 21);
            this.txtCostoEnvio.TabIndex = 14;
            this.txtCostoEnvio.Text = "----";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 376);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Costo de Envio";
            // 
            // txtDatosSucursal
            // 
            this.txtDatosSucursal.AutoSize = true;
            this.txtDatosSucursal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosSucursal.ForeColor = System.Drawing.Color.Black;
            this.txtDatosSucursal.Location = new System.Drawing.Point(25, 159);
            this.txtDatosSucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDatosSucursal.Name = "txtDatosSucursal";
            this.txtDatosSucursal.Size = new System.Drawing.Size(0, 16);
            this.txtDatosSucursal.TabIndex = 12;
            // 
            // comboEmpCorreo
            // 
            this.comboEmpCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmpCorreo.FormattingEnabled = true;
            this.comboEmpCorreo.Items.AddRange(new object[] {
            "OCASA",
            "Andreani",
            "Correo Argentino"});
            this.comboEmpCorreo.Location = new System.Drawing.Point(143, 319);
            this.comboEmpCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.comboEmpCorreo.Name = "comboEmpCorreo";
            this.comboEmpCorreo.Size = new System.Drawing.Size(185, 24);
            this.comboEmpCorreo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mi domicilio";
            // 
            // txtDomAgendado
            // 
            this.txtDomAgendado.AutoSize = true;
            this.txtDomAgendado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomAgendado.ForeColor = System.Drawing.Color.Black;
            this.txtDomAgendado.Location = new System.Drawing.Point(24, 214);
            this.txtDomAgendado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDomAgendado.Name = "txtDomAgendado";
            this.txtDomAgendado.Size = new System.Drawing.Size(60, 16);
            this.txtDomAgendado.TabIndex = 7;
            this.txtDomAgendado.Text = "-------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pedido N° :";
            // 
            // btnCambiarDom
            // 
            this.btnCambiarDom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarDom.Location = new System.Drawing.Point(28, 237);
            this.btnCambiarDom.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarDom.Name = "btnCambiarDom";
            this.btnCambiarDom.Size = new System.Drawing.Size(325, 37);
            this.btnCambiarDom.TabIndex = 4;
            this.btnCambiarDom.Text = "Cambiar Domicilio";
            this.btnCambiarDom.UseVisualStyleBackColor = true;
            // 
            // txtPedido
            // 
            this.txtPedido.AutoSize = true;
            this.txtPedido.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.ForeColor = System.Drawing.Color.Black;
            this.txtPedido.Location = new System.Drawing.Point(139, 70);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(38, 21);
            this.txtPedido.TabIndex = 2;
            this.txtPedido.Text = "----";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 484);
            this.panel1.TabIndex = 0;
            // 
            // btnBuscarDom
            // 
            this.btnBuscarDom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDom.Location = new System.Drawing.Point(116, 179);
            this.btnBuscarDom.Name = "btnBuscarDom";
            this.btnBuscarDom.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarDom.TabIndex = 3;
            this.btnBuscarDom.Text = "Buscar";
            this.btnBuscarDom.UseVisualStyleBackColor = true;
            this.btnBuscarDom.Click += new System.EventHandler(this.btnBuscarDom_Click);
            // 
            // btnBuscarTarj
            // 
            this.btnBuscarTarj.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTarj.Location = new System.Drawing.Point(140, 177);
            this.btnBuscarTarj.Name = "btnBuscarTarj";
            this.btnBuscarTarj.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarTarj.TabIndex = 17;
            this.btnBuscarTarj.Text = "Buscar";
            this.btnBuscarTarj.UseVisualStyleBackColor = true;
            this.btnBuscarTarj.Click += new System.EventHandler(this.btnBuscarTarj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "mateAR";
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMonto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboEmpCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtDomAgendado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambiarDom;
        private System.Windows.Forms.Label txtPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtCostoEnvio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtDatosSucursal;
        private System.Windows.Forms.ComboBox comboCuotas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNvaTarj;
        private System.Windows.Forms.Label txtTarjAgendada;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodSeguridad;
        private System.Windows.Forms.TextBox txtVto;
        private System.Windows.Forms.ComboBox comboFormPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFormEnvio;
        private System.Windows.Forms.Button btnBuscarTarj;
        private System.Windows.Forms.Button btnBuscarDom;
    }
}

