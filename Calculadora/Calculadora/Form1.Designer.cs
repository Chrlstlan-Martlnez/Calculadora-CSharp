namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.label1 = new System.Windows.Forms.Label();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.botonDec = new System.Windows.Forms.Button();
            this.botonBor = new System.Windows.Forms.Button();
            this.botonNeg = new System.Windows.Forms.Button();
            this.botonLim = new System.Windows.Forms.Button();
            this.botonDiv = new System.Windows.Forms.Button();
            this.botonIgu = new System.Windows.Forms.Button();
            this.botonMul = new System.Windows.Forms.Button();
            this.botonSum = new System.Windows.Forms.Button();
            this.botonRes = new System.Windows.Forms.Button();
            this.botonClaro = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.botonRosado = new System.Windows.Forms.Button();
            this.botonAzul = new System.Windows.Forms.Button();
            this.botonOscuro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.White;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.Black;
            this.boton1.Location = new System.Drawing.Point(6, 245);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(50, 45);
            this.boton1.TabIndex = 16;
            this.boton1.Tag = "1";
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.clickNum);
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.Color.White;
            this.boton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.ForeColor = System.Drawing.Color.Black;
            this.boton5.Location = new System.Drawing.Point(57, 199);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(50, 45);
            this.boton5.TabIndex = 24;
            this.boton5.Tag = "5";
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.clickNum);
            // 
            // boton6
            // 
            this.boton6.BackColor = System.Drawing.Color.White;
            this.boton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.ForeColor = System.Drawing.Color.Black;
            this.boton6.Location = new System.Drawing.Point(108, 199);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(50, 45);
            this.boton6.TabIndex = 25;
            this.boton6.Tag = "6";
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = false;
            this.boton6.Click += new System.EventHandler(this.clickNum);
            // 
            // boton9
            // 
            this.boton9.BackColor = System.Drawing.Color.White;
            this.boton9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.ForeColor = System.Drawing.Color.Black;
            this.boton9.Location = new System.Drawing.Point(108, 153);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(50, 45);
            this.boton9.TabIndex = 26;
            this.boton9.Tag = "9";
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = false;
            this.boton9.Click += new System.EventHandler(this.clickNum);
            // 
            // boton8
            // 
            this.boton8.BackColor = System.Drawing.Color.White;
            this.boton8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.ForeColor = System.Drawing.Color.Black;
            this.boton8.Location = new System.Drawing.Point(57, 153);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(50, 45);
            this.boton8.TabIndex = 27;
            this.boton8.Tag = "8";
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = false;
            this.boton8.Click += new System.EventHandler(this.clickNum);
            // 
            // boton7
            // 
            this.boton7.BackColor = System.Drawing.Color.White;
            this.boton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.ForeColor = System.Drawing.Color.Black;
            this.boton7.Location = new System.Drawing.Point(6, 153);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(50, 45);
            this.boton7.TabIndex = 28;
            this.boton7.Tag = "7";
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = false;
            this.boton7.Click += new System.EventHandler(this.clickNum);
            // 
            // boton4
            // 
            this.boton4.BackColor = System.Drawing.Color.White;
            this.boton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.ForeColor = System.Drawing.Color.Black;
            this.boton4.Location = new System.Drawing.Point(6, 199);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(50, 45);
            this.boton4.TabIndex = 29;
            this.boton4.Tag = "4";
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.clickNum);
            // 
            // boton3
            // 
            this.boton3.BackColor = System.Drawing.Color.White;
            this.boton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.ForeColor = System.Drawing.Color.Black;
            this.boton3.Location = new System.Drawing.Point(108, 245);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(50, 45);
            this.boton3.TabIndex = 30;
            this.boton3.Tag = "3";
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.clickNum);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.Color.White;
            this.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.Color.Black;
            this.boton2.Location = new System.Drawing.Point(57, 245);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(50, 45);
            this.boton2.TabIndex = 31;
            this.boton2.Tag = "2";
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.clickNum);
            // 
            // boton0
            // 
            this.boton0.BackColor = System.Drawing.Color.White;
            this.boton0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.ForeColor = System.Drawing.Color.Black;
            this.boton0.Location = new System.Drawing.Point(6, 291);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(101, 45);
            this.boton0.TabIndex = 32;
            this.boton0.Tag = "0";
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = false;
            this.boton0.Click += new System.EventHandler(this.clickNum);
            // 
            // botonDec
            // 
            this.botonDec.BackColor = System.Drawing.Color.White;
            this.botonDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonDec.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDec.ForeColor = System.Drawing.Color.Black;
            this.botonDec.Location = new System.Drawing.Point(108, 291);
            this.botonDec.Name = "botonDec";
            this.botonDec.Size = new System.Drawing.Size(50, 45);
            this.botonDec.TabIndex = 33;
            this.botonDec.Text = ".";
            this.botonDec.UseVisualStyleBackColor = false;
            this.botonDec.Click += new System.EventHandler(this.botonDec_Click);
            // 
            // botonBor
            // 
            this.botonBor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(238)))));
            this.botonBor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonBor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBor.ForeColor = System.Drawing.Color.Black;
            this.botonBor.Location = new System.Drawing.Point(6, 107);
            this.botonBor.Name = "botonBor";
            this.botonBor.Size = new System.Drawing.Size(50, 45);
            this.botonBor.TabIndex = 34;
            this.botonBor.Text = "DEL";
            this.botonBor.UseVisualStyleBackColor = false;
            this.botonBor.Click += new System.EventHandler(this.botonBor_Click);
            // 
            // botonNeg
            // 
            this.botonNeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(238)))));
            this.botonNeg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonNeg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNeg.ForeColor = System.Drawing.Color.Black;
            this.botonNeg.Location = new System.Drawing.Point(108, 107);
            this.botonNeg.Name = "botonNeg";
            this.botonNeg.Size = new System.Drawing.Size(50, 45);
            this.botonNeg.TabIndex = 35;
            this.botonNeg.Text = "+-";
            this.botonNeg.UseVisualStyleBackColor = false;
            this.botonNeg.Click += new System.EventHandler(this.botonNeg_Click);
            // 
            // botonLim
            // 
            this.botonLim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(238)))));
            this.botonLim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonLim.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLim.ForeColor = System.Drawing.Color.Black;
            this.botonLim.Location = new System.Drawing.Point(57, 107);
            this.botonLim.Name = "botonLim";
            this.botonLim.Size = new System.Drawing.Size(50, 45);
            this.botonLim.TabIndex = 36;
            this.botonLim.Text = "CLR";
            this.botonLim.UseVisualStyleBackColor = false;
            this.botonLim.Click += new System.EventHandler(this.botonLim_Click);
            // 
            // botonDiv
            // 
            this.botonDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(212)))));
            this.botonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonDiv.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDiv.ForeColor = System.Drawing.Color.Black;
            this.botonDiv.Location = new System.Drawing.Point(159, 107);
            this.botonDiv.Name = "botonDiv";
            this.botonDiv.Size = new System.Drawing.Size(50, 45);
            this.botonDiv.TabIndex = 41;
            this.botonDiv.Tag = "/";
            this.botonDiv.Text = "/";
            this.botonDiv.UseVisualStyleBackColor = false;
            this.botonDiv.Click += new System.EventHandler(this.clickOper);
            // 
            // botonIgu
            // 
            this.botonIgu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(212)))));
            this.botonIgu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonIgu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIgu.ForeColor = System.Drawing.Color.Black;
            this.botonIgu.Location = new System.Drawing.Point(159, 291);
            this.botonIgu.Name = "botonIgu";
            this.botonIgu.Size = new System.Drawing.Size(50, 45);
            this.botonIgu.TabIndex = 40;
            this.botonIgu.Text = "=";
            this.botonIgu.UseVisualStyleBackColor = false;
            this.botonIgu.Click += new System.EventHandler(this.botonIgu_Click);
            // 
            // botonMul
            // 
            this.botonMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(212)))));
            this.botonMul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonMul.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMul.ForeColor = System.Drawing.Color.Black;
            this.botonMul.Location = new System.Drawing.Point(159, 153);
            this.botonMul.Name = "botonMul";
            this.botonMul.Size = new System.Drawing.Size(50, 45);
            this.botonMul.TabIndex = 39;
            this.botonMul.Tag = "*";
            this.botonMul.Text = "*";
            this.botonMul.UseVisualStyleBackColor = false;
            this.botonMul.Click += new System.EventHandler(this.clickOper);
            // 
            // botonSum
            // 
            this.botonSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(212)))));
            this.botonSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonSum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSum.ForeColor = System.Drawing.Color.Black;
            this.botonSum.Location = new System.Drawing.Point(159, 245);
            this.botonSum.Name = "botonSum";
            this.botonSum.Size = new System.Drawing.Size(50, 45);
            this.botonSum.TabIndex = 38;
            this.botonSum.Tag = "+";
            this.botonSum.Text = "+";
            this.botonSum.UseVisualStyleBackColor = false;
            this.botonSum.Click += new System.EventHandler(this.clickOper);
            // 
            // botonRes
            // 
            this.botonRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(212)))));
            this.botonRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonRes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRes.ForeColor = System.Drawing.Color.Black;
            this.botonRes.Location = new System.Drawing.Point(159, 199);
            this.botonRes.Name = "botonRes";
            this.botonRes.Size = new System.Drawing.Size(50, 45);
            this.botonRes.TabIndex = 37;
            this.botonRes.Tag = "-";
            this.botonRes.Text = "-";
            this.botonRes.UseVisualStyleBackColor = false;
            this.botonRes.Click += new System.EventHandler(this.clickOper);
            // 
            // botonClaro
            // 
            this.botonClaro.BackColor = System.Drawing.Color.White;
            this.botonClaro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonClaro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonClaro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.botonClaro.Location = new System.Drawing.Point(6, 6);
            this.botonClaro.Name = "botonClaro";
            this.botonClaro.Size = new System.Drawing.Size(34, 21);
            this.botonClaro.TabIndex = 42;
            this.botonClaro.UseVisualStyleBackColor = false;
            this.botonClaro.Click += new System.EventHandler(this.botonClaro_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.botonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonCerrar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.botonCerrar.Location = new System.Drawing.Point(184, 6);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(25, 21);
            this.botonCerrar.TabIndex = 45;
            this.botonCerrar.Text = "X";
            this.botonCerrar.UseVisualStyleBackColor = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // botonRosado
            // 
            this.botonRosado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(189)))), ((int)(((byte)(221)))));
            this.botonRosado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonRosado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRosado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.botonRosado.Location = new System.Drawing.Point(126, 6);
            this.botonRosado.Name = "botonRosado";
            this.botonRosado.Size = new System.Drawing.Size(34, 21);
            this.botonRosado.TabIndex = 46;
            this.botonRosado.UseVisualStyleBackColor = false;
            this.botonRosado.Click += new System.EventHandler(this.botonRosado_Click);
            // 
            // botonAzul
            // 
            this.botonAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(116)))), ((int)(((byte)(179)))));
            this.botonAzul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonAzul.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAzul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.botonAzul.Location = new System.Drawing.Point(86, 6);
            this.botonAzul.Name = "botonAzul";
            this.botonAzul.Size = new System.Drawing.Size(34, 21);
            this.botonAzul.TabIndex = 47;
            this.botonAzul.UseVisualStyleBackColor = false;
            this.botonAzul.Click += new System.EventHandler(this.botonAzul_Click);
            // 
            // botonOscuro
            // 
            this.botonOscuro.BackColor = System.Drawing.Color.Black;
            this.botonOscuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonOscuro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonOscuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.botonOscuro.Location = new System.Drawing.Point(46, 6);
            this.botonOscuro.Name = "botonOscuro";
            this.botonOscuro.Size = new System.Drawing.Size(34, 21);
            this.botonOscuro.TabIndex = 48;
            this.botonOscuro.UseVisualStyleBackColor = false;
            this.botonOscuro.Click += new System.EventHandler(this.botonOscuro_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(203, 35);
            this.label2.TabIndex = 49;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(215, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonOscuro);
            this.Controls.Add(this.botonAzul);
            this.Controls.Add(this.botonRosado);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botonClaro);
            this.Controls.Add(this.botonDiv);
            this.Controls.Add(this.botonIgu);
            this.Controls.Add(this.botonMul);
            this.Controls.Add(this.botonSum);
            this.Controls.Add(this.botonRes);
            this.Controls.Add(this.botonLim);
            this.Controls.Add(this.botonNeg);
            this.Controls.Add(this.botonBor);
            this.Controls.Add(this.botonDec);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button botonDec;
        private System.Windows.Forms.Button botonBor;
        private System.Windows.Forms.Button botonNeg;
        private System.Windows.Forms.Button botonLim;
        private System.Windows.Forms.Button botonDiv;
        private System.Windows.Forms.Button botonIgu;
        private System.Windows.Forms.Button botonMul;
        private System.Windows.Forms.Button botonSum;
        private System.Windows.Forms.Button botonRes;
        private System.Windows.Forms.Button botonClaro;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Button botonRosado;
        private System.Windows.Forms.Button botonAzul;
        private System.Windows.Forms.Button botonOscuro;
        private System.Windows.Forms.Label label2;
    }
}

