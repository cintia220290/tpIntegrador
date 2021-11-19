
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFormEnvio = new System.Windows.Forms.ComboBox();
            this.txtCostoEnvio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDatosSucursal = new System.Windows.Forms.Label();
            this.comboSucursal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiarDom = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoConEnvio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTotalFinal = new System.Windows.Forms.Label();
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
            this.panel2.Size = new System.Drawing.Size(395, 517);
            this.panel2.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(234, 468);
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
            this.groupBox1.Controls.Add(this.txtTotalFinal);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtMontoConEnvio);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboFormPago);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCodSeguridad);
            this.groupBox1.Controls.Add(this.txtVto);
            this.groupBox1.Controls.Add(this.comboCuotas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnNvaTarj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(373, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmar Pago";
            // 
            // comboFormPago
            // 
            this.comboFormPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFormPago.FormattingEnabled = true;
            this.comboFormPago.Items.AddRange(new object[] {
            "Tarjeta Debito",
            "Tarjeta Credito"});
            this.comboFormPago.Location = new System.Drawing.Point(178, 112);
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
            this.label11.Location = new System.Drawing.Point(25, 119);
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
            this.label9.Location = new System.Drawing.Point(175, 232);
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
            this.label10.Location = new System.Drawing.Point(4, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Vencimiento";
            // 
            // txtCodSeguridad
            // 
            this.txtCodSeguridad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSeguridad.Location = new System.Drawing.Point(303, 228);
            this.txtCodSeguridad.Name = "txtCodSeguridad";
            this.txtCodSeguridad.Size = new System.Drawing.Size(50, 21);
            this.txtCodSeguridad.TabIndex = 29;
            // 
            // txtVto
            // 
            this.txtVto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVto.Location = new System.Drawing.Point(100, 230);
            this.txtVto.Name = "txtVto";
            this.txtVto.Size = new System.Drawing.Size(56, 21);
            this.txtVto.TabIndex = 28;
            // 
            // comboCuotas
            // 
            this.comboCuotas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCuotas.FormattingEnabled = true;
            this.comboCuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.comboCuotas.Location = new System.Drawing.Point(178, 269);
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
            this.label8.Location = new System.Drawing.Point(4, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad de Cuotas";
            // 
            // btnNvaTarj
            // 
            this.btnNvaTarj.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvaTarj.Location = new System.Drawing.Point(141, 163);
            this.btnNvaTarj.Margin = new System.Windows.Forms.Padding(2);
            this.btnNvaTarj.Name = "btnNvaTarj";
            this.btnNvaTarj.Size = new System.Drawing.Size(212, 37);
            this.btnNvaTarj.TabIndex = 15;
            this.btnNvaTarj.Text = "Registrar Tarjeta";
            this.btnNvaTarj.UseVisualStyleBackColor = true;
            this.btnNvaTarj.Click += new System.EventHandler(this.btnNvaTarj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboFormEnvio);
            this.groupBox2.Controls.Add(this.txtCostoEnvio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDatosSucursal);
            this.groupBox2.Controls.Add(this.comboSucursal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnCambiarDom);
            this.groupBox2.Controls.Add(this.txtPedido);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(11, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(373, 468);
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
            this.txtCostoEnvio.Location = new System.Drawing.Point(158, 327);
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
            this.label7.Location = new System.Drawing.Point(34, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Costo de Envio $";
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
            // comboSucursal
            // 
            this.comboSucursal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSucursal.FormattingEnabled = true;
            this.comboSucursal.Items.AddRange(new object[] {
            "Av. Fulvio Pagani 487-CORDOBA",
            "9 de Julio 1256-BS AS"});
            this.comboSucursal.Location = new System.Drawing.Point(143, 176);
            this.comboSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.comboSucursal.Name = "comboSucursal";
            this.comboSucursal.Size = new System.Drawing.Size(185, 24);
            this.comboSucursal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sucursal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 9;
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
            this.btnCambiarDom.Location = new System.Drawing.Point(37, 245);
            this.btnCambiarDom.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarDom.Name = "btnCambiarDom";
            this.btnCambiarDom.Size = new System.Drawing.Size(284, 37);
            this.btnCambiarDom.TabIndex = 4;
            this.btnCambiarDom.Text = "Registrar Domicilio";
            this.btnCambiarDom.UseVisualStyleBackColor = true;
            this.btnCambiarDom.Click += new System.EventHandler(this.btnCambiarDom_Click);
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
            this.panel1.Size = new System.Drawing.Size(395, 517);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(25, 74);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Monto a pagar $ :";
            // 
            // txtMontoConEnvio
            // 
            this.txtMontoConEnvio.AutoSize = true;
            this.txtMontoConEnvio.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoConEnvio.ForeColor = System.Drawing.Color.Black;
            this.txtMontoConEnvio.Location = new System.Drawing.Point(155, 65);
            this.txtMontoConEnvio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMontoConEnvio.Name = "txtMontoConEnvio";
            this.txtMontoConEnvio.Size = new System.Drawing.Size(36, 28);
            this.txtMontoConEnvio.TabIndex = 34;
            this.txtMontoConEnvio.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(128, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "(Completar solo si retira en Sucursal)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 21);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(265, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(79, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Calcular Monto a Pagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.AutoSize = true;
            this.txtTotalFinal.Location = new System.Drawing.Point(120, 364);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.Size = new System.Drawing.Size(135, 36);
            this.txtTotalFinal.TabIndex = 35;
            this.txtTotalFinal.Text = "------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 516);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodSeguridad;
        private System.Windows.Forms.TextBox txtVto;
        private System.Windows.Forms.ComboBox comboFormPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFormEnvio;
        private System.Windows.Forms.Label txtMontoConEnvio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtTotalFinal;
        private System.Windows.Forms.Button button3;
    }
}

