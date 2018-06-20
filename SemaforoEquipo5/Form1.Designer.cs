namespace SemaforoEquipo5
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.grpPanelDeControl = new System.Windows.Forms.GroupBox();
            this.btnIntermitentes = new System.Windows.Forms.Button();
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIntervaloVer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.txtIntervaloAm = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbSemAVerde = new System.Windows.Forms.PictureBox();
            this.pbSemBVerde = new System.Windows.Forms.PictureBox();
            this.pbSemCVerde = new System.Windows.Forms.PictureBox();
            this.pbSemDVerde = new System.Windows.Forms.PictureBox();
            this.pbSemAAmarillo = new System.Windows.Forms.PictureBox();
            this.pbSemBAmarillo = new System.Windows.Forms.PictureBox();
            this.pbSemCAmarillo = new System.Windows.Forms.PictureBox();
            this.pbSemDAmarillo = new System.Windows.Forms.PictureBox();
            this.pbSemARojo = new System.Windows.Forms.PictureBox();
            this.pbSemBRojo = new System.Windows.Forms.PictureBox();
            this.pbSemCRojo = new System.Windows.Forms.PictureBox();
            this.pbSemDRojo = new System.Windows.Forms.PictureBox();
            this.prmContador = new System.Windows.Forms.Timer(this.components);
            this.sgContador = new System.Windows.Forms.Timer(this.components);
            this.grpPanelDeControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervaloVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervaloAm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemAVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemBVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemCVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemDVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemAAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemBAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemCAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemDAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemARojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemBRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemCRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemDRojo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPanelDeControl
            // 
            this.grpPanelDeControl.Controls.Add(this.btnIntermitentes);
            this.grpPanelDeControl.Controls.Add(this.btnEncender);
            this.grpPanelDeControl.Controls.Add(this.btnApagar);
            this.grpPanelDeControl.Location = new System.Drawing.Point(14, 17);
            this.grpPanelDeControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPanelDeControl.Name = "grpPanelDeControl";
            this.grpPanelDeControl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPanelDeControl.Size = new System.Drawing.Size(290, 67);
            this.grpPanelDeControl.TabIndex = 4;
            this.grpPanelDeControl.TabStop = false;
            this.grpPanelDeControl.Text = "Panel de control";
            // 
            // btnIntermitentes
            // 
            this.btnIntermitentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntermitentes.Location = new System.Drawing.Point(196, 25);
            this.btnIntermitentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIntermitentes.Name = "btnIntermitentes";
            this.btnIntermitentes.Size = new System.Drawing.Size(87, 31);
            this.btnIntermitentes.TabIndex = 6;
            this.btnIntermitentes.Text = "Intermitentes";
            this.btnIntermitentes.UseVisualStyleBackColor = true;
            this.btnIntermitentes.Click += new System.EventHandler(this.btnIntermitentes_Click);
            // 
            // btnEncender
            // 
            this.btnEncender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncender.Location = new System.Drawing.Point(7, 25);
            this.btnEncender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(87, 31);
            this.btnEncender.TabIndex = 4;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.Location = new System.Drawing.Point(101, 25);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(87, 31);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIntervaloVer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSegundos);
            this.groupBox1.Controls.Add(this.btnConfigurar);
            this.groupBox1.Controls.Add(this.txtIntervaloAm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(710, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(220, 227);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion";
            // 
            // txtIntervaloVer
            // 
            this.txtIntervaloVer.Location = new System.Drawing.Point(131, 25);
            this.txtIntervaloVer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIntervaloVer.Name = "txtIntervaloVer";
            this.txtIntervaloVer.Size = new System.Drawing.Size(54, 21);
            this.txtIntervaloVer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Intervalo Amarillo:";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSegundos.Location = new System.Drawing.Point(10, 152);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(66, 42);
            this.lblSegundos.TabIndex = 18;
            this.lblSegundos.Text = "[S]";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfigurar.Location = new System.Drawing.Point(7, 97);
            this.btnConfigurar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(178, 47);
            this.btnConfigurar.TabIndex = 3;
            this.btnConfigurar.Text = "Establecer Configuracion";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // txtIntervaloAm
            // 
            this.txtIntervaloAm.Location = new System.Drawing.Point(131, 61);
            this.txtIntervaloAm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIntervaloAm.Name = "txtIntervaloAm";
            this.txtIntervaloAm.Size = new System.Drawing.Size(54, 21);
            this.txtIntervaloAm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intervalo Verde:";
            // 
            // pbLeft
            // 
            this.pbLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLeft.BackgroundImage")));
            this.pbLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLeft.Location = new System.Drawing.Point(14, 91);
            this.pbLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(689, 558);
            this.pbLeft.TabIndex = 2;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.pbLeft_Click);
            // 
            // pbSemAVerde
            // 
            this.pbSemAVerde.BackColor = System.Drawing.Color.Lime;
            this.pbSemAVerde.Location = new System.Drawing.Point(418, 115);
            this.pbSemAVerde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemAVerde.Name = "pbSemAVerde";
            this.pbSemAVerde.Size = new System.Drawing.Size(17, 19);
            this.pbSemAVerde.TabIndex = 6;
            this.pbSemAVerde.TabStop = false;
            // 
            // pbSemBVerde
            // 
            this.pbSemBVerde.BackColor = System.Drawing.Color.Lime;
            this.pbSemBVerde.Location = new System.Drawing.Point(497, 418);
            this.pbSemBVerde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemBVerde.Name = "pbSemBVerde";
            this.pbSemBVerde.Size = new System.Drawing.Size(17, 19);
            this.pbSemBVerde.TabIndex = 7;
            this.pbSemBVerde.TabStop = false;
            // 
            // pbSemCVerde
            // 
            this.pbSemCVerde.BackColor = System.Drawing.Color.Lime;
            this.pbSemCVerde.Location = new System.Drawing.Point(263, 524);
            this.pbSemCVerde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemCVerde.Name = "pbSemCVerde";
            this.pbSemCVerde.Size = new System.Drawing.Size(17, 19);
            this.pbSemCVerde.TabIndex = 8;
            this.pbSemCVerde.TabStop = false;
            // 
            // pbSemDVerde
            // 
            this.pbSemDVerde.BackColor = System.Drawing.Color.Lime;
            this.pbSemDVerde.Location = new System.Drawing.Point(185, 235);
            this.pbSemDVerde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemDVerde.Name = "pbSemDVerde";
            this.pbSemDVerde.Size = new System.Drawing.Size(17, 19);
            this.pbSemDVerde.TabIndex = 9;
            this.pbSemDVerde.TabStop = false;
            // 
            // pbSemAAmarillo
            // 
            this.pbSemAAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.pbSemAAmarillo.Location = new System.Drawing.Point(392, 115);
            this.pbSemAAmarillo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemAAmarillo.Name = "pbSemAAmarillo";
            this.pbSemAAmarillo.Size = new System.Drawing.Size(17, 19);
            this.pbSemAAmarillo.TabIndex = 10;
            this.pbSemAAmarillo.TabStop = false;
            // 
            // pbSemBAmarillo
            // 
            this.pbSemBAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.pbSemBAmarillo.Location = new System.Drawing.Point(497, 384);
            this.pbSemBAmarillo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemBAmarillo.Name = "pbSemBAmarillo";
            this.pbSemBAmarillo.Size = new System.Drawing.Size(17, 19);
            this.pbSemBAmarillo.TabIndex = 11;
            this.pbSemBAmarillo.TabStop = false;
            // 
            // pbSemCAmarillo
            // 
            this.pbSemCAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.pbSemCAmarillo.Location = new System.Drawing.Point(289, 526);
            this.pbSemCAmarillo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemCAmarillo.Name = "pbSemCAmarillo";
            this.pbSemCAmarillo.Size = new System.Drawing.Size(17, 19);
            this.pbSemCAmarillo.TabIndex = 12;
            this.pbSemCAmarillo.TabStop = false;
            // 
            // pbSemDAmarillo
            // 
            this.pbSemDAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.pbSemDAmarillo.Location = new System.Drawing.Point(185, 269);
            this.pbSemDAmarillo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemDAmarillo.Name = "pbSemDAmarillo";
            this.pbSemDAmarillo.Size = new System.Drawing.Size(17, 19);
            this.pbSemDAmarillo.TabIndex = 13;
            this.pbSemDAmarillo.TabStop = false;
            // 
            // pbSemARojo
            // 
            this.pbSemARojo.BackColor = System.Drawing.Color.Red;
            this.pbSemARojo.Location = new System.Drawing.Point(366, 115);
            this.pbSemARojo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemARojo.Name = "pbSemARojo";
            this.pbSemARojo.Size = new System.Drawing.Size(17, 19);
            this.pbSemARojo.TabIndex = 14;
            this.pbSemARojo.TabStop = false;
            // 
            // pbSemBRojo
            // 
            this.pbSemBRojo.BackColor = System.Drawing.Color.Red;
            this.pbSemBRojo.Location = new System.Drawing.Point(497, 354);
            this.pbSemBRojo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemBRojo.Name = "pbSemBRojo";
            this.pbSemBRojo.Size = new System.Drawing.Size(17, 19);
            this.pbSemBRojo.TabIndex = 15;
            this.pbSemBRojo.TabStop = false;
            // 
            // pbSemCRojo
            // 
            this.pbSemCRojo.BackColor = System.Drawing.Color.Red;
            this.pbSemCRojo.Location = new System.Drawing.Point(312, 524);
            this.pbSemCRojo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemCRojo.Name = "pbSemCRojo";
            this.pbSemCRojo.Size = new System.Drawing.Size(17, 19);
            this.pbSemCRojo.TabIndex = 16;
            this.pbSemCRojo.TabStop = false;
            // 
            // pbSemDRojo
            // 
            this.pbSemDRojo.BackColor = System.Drawing.Color.Red;
            this.pbSemDRojo.Location = new System.Drawing.Point(185, 299);
            this.pbSemDRojo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSemDRojo.Name = "pbSemDRojo";
            this.pbSemDRojo.Size = new System.Drawing.Size(17, 19);
            this.pbSemDRojo.TabIndex = 17;
            this.pbSemDRojo.TabStop = false;
            // 
            // prmContador
            // 
            this.prmContador.Interval = 500;
            this.prmContador.Tick += new System.EventHandler(this.prmContador_Tick);
            // 
            // sgContador
            // 
            this.sgContador.Tick += new System.EventHandler(this.sgContador_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(936, 667);
            this.Controls.Add(this.pbSemDRojo);
            this.Controls.Add(this.pbSemCRojo);
            this.Controls.Add(this.pbSemBRojo);
            this.Controls.Add(this.pbSemARojo);
            this.Controls.Add(this.pbSemDAmarillo);
            this.Controls.Add(this.pbSemCAmarillo);
            this.Controls.Add(this.pbSemBAmarillo);
            this.Controls.Add(this.pbSemAAmarillo);
            this.Controls.Add(this.pbSemDVerde);
            this.Controls.Add(this.pbSemCVerde);
            this.Controls.Add(this.pbSemBVerde);
            this.Controls.Add(this.pbSemAVerde);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPanelDeControl);
            this.Controls.Add(this.pbLeft);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.Text = "Semaforo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpPanelDeControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervaloVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervaloAm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemAVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemBVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemCVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemDVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemAAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemBAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemCAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemDAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemARojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemBRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemCRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSemDRojo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPanelDeControl;
        private System.Windows.Forms.Button btnIntermitentes;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.NumericUpDown txtIntervaloAm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbSemAVerde;
        private System.Windows.Forms.PictureBox pbSemBVerde;
        private System.Windows.Forms.PictureBox pbSemCVerde;
        private System.Windows.Forms.PictureBox pbSemDVerde;
        private System.Windows.Forms.PictureBox pbSemAAmarillo;
        private System.Windows.Forms.PictureBox pbSemBAmarillo;
        private System.Windows.Forms.PictureBox pbSemCAmarillo;
        private System.Windows.Forms.PictureBox pbSemDAmarillo;
        private System.Windows.Forms.PictureBox pbSemARojo;
        private System.Windows.Forms.PictureBox pbSemBRojo;
        private System.Windows.Forms.PictureBox pbSemCRojo;
        private System.Windows.Forms.PictureBox pbSemDRojo;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Timer prmContador;
        private System.Windows.Forms.Timer sgContador;
        private System.Windows.Forms.NumericUpDown txtIntervaloVer;
        private System.Windows.Forms.Label label2;
    }
}

