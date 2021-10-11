
namespace mateAr_wf_PagoyEnvio
{
    partial class Nueva_Tarjeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboTipoTarj = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bntCancelarDom = new System.Windows.Forms.Button();
            this.btnGuardarDom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomTitular = new System.Windows.Forms.TextBox();
            this.txtDniTitular = new System.Windows.Forms.TextBox();
            this.txtNumTarj = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.comboTipoTarj);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bntCancelarDom);
            this.panel1.Controls.Add(this.btnGuardarDom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNomTitular);
            this.panel1.Controls.Add(this.txtDniTitular);
            this.panel1.Controls.Add(this.txtNumTarj);
            this.panel1.Controls.Add(this.txtBanco);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 426);
            this.panel1.TabIndex = 0;
            // 
            // comboTipoTarj
            // 
            this.comboTipoTarj.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoTarj.FormattingEnabled = true;
            this.comboTipoTarj.Items.AddRange(new object[] {
            "Débito",
            "Crédito"});
            this.comboTipoTarj.Location = new System.Drawing.Point(169, 50);
            this.comboTipoTarj.Margin = new System.Windows.Forms.Padding(2);
            this.comboTipoTarj.Name = "comboTipoTarj";
            this.comboTipoTarj.Size = new System.Drawing.Size(185, 24);
            this.comboTipoTarj.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(18, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tipo";
            // 
            // bntCancelarDom
            // 
            this.bntCancelarDom.BackColor = System.Drawing.Color.DarkSalmon;
            this.bntCancelarDom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelarDom.Location = new System.Drawing.Point(163, 356);
            this.bntCancelarDom.Name = "bntCancelarDom";
            this.bntCancelarDom.Size = new System.Drawing.Size(129, 44);
            this.bntCancelarDom.TabIndex = 29;
            this.bntCancelarDom.Text = "Cancelar";
            this.bntCancelarDom.UseVisualStyleBackColor = false;
            this.bntCancelarDom.Click += new System.EventHandler(this.bntCancelarDom_Click);
            // 
            // btnGuardarDom
            // 
            this.btnGuardarDom.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardarDom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDom.Location = new System.Drawing.Point(298, 356);
            this.btnGuardarDom.Name = "btnGuardarDom";
            this.btnGuardarDom.Size = new System.Drawing.Size(129, 44);
            this.btnGuardarDom.TabIndex = 28;
            this.btnGuardarDom.Text = "Guardar";
            this.btnGuardarDom.UseVisualStyleBackColor = false;
            this.btnGuardarDom.Click += new System.EventHandler(this.btnGuardarDom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dni Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre Titular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero";
            // 
            // txtNomTitular
            // 
            this.txtNomTitular.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomTitular.Location = new System.Drawing.Point(169, 163);
            this.txtNomTitular.Name = "txtNomTitular";
            this.txtNomTitular.Size = new System.Drawing.Size(258, 21);
            this.txtNomTitular.TabIndex = 20;
            // 
            // txtDniTitular
            // 
            this.txtDniTitular.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniTitular.Location = new System.Drawing.Point(169, 200);
            this.txtDniTitular.Name = "txtDniTitular";
            this.txtDniTitular.Size = new System.Drawing.Size(258, 21);
            this.txtDniTitular.TabIndex = 17;
            // 
            // txtNumTarj
            // 
            this.txtNumTarj.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTarj.Location = new System.Drawing.Point(169, 127);
            this.txtNumTarj.Name = "txtNumTarj";
            this.txtNumTarj.Size = new System.Drawing.Size(258, 21);
            this.txtNumTarj.TabIndex = 16;
            // 
            // txtBanco
            // 
            this.txtBanco.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.Location = new System.Drawing.Point(169, 89);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(258, 21);
            this.txtBanco.TabIndex = 15;
            // 
            // Nueva_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Nueva_Tarjeta";
            this.Text = "Nueva Tarjeta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomTitular;
        private System.Windows.Forms.TextBox txtDniTitular;
        private System.Windows.Forms.TextBox txtNumTarj;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Button bntCancelarDom;
        private System.Windows.Forms.Button btnGuardarDom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTipoTarj;
    }
}