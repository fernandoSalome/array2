namespace ValidarCNPJ_CPF_PIS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_cnpj = new System.Windows.Forms.RadioButton();
            this.rdb_cpf = new System.Windows.Forms.RadioButton();
            this.rdb_pis = new System.Windows.Forms.RadioButton();
            this.btnValidar = new System.Windows.Forms.Button();
            this.maskValor = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o número a validar e marque o seu tipo";
            // 
            // rdb_cnpj
            // 
            this.rdb_cnpj.AutoSize = true;
            this.rdb_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_cnpj.Location = new System.Drawing.Point(130, 117);
            this.rdb_cnpj.Name = "rdb_cnpj";
            this.rdb_cnpj.Size = new System.Drawing.Size(80, 28);
            this.rdb_cnpj.TabIndex = 2;
            this.rdb_cnpj.TabStop = true;
            this.rdb_cnpj.Text = "CNPJ";
            this.rdb_cnpj.UseVisualStyleBackColor = true;
            this.rdb_cnpj.CheckedChanged += new System.EventHandler(this.rdb_cnpj_CheckedChanged);
            // 
            // rdb_cpf
            // 
            this.rdb_cpf.AutoSize = true;
            this.rdb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_cpf.Location = new System.Drawing.Point(216, 117);
            this.rdb_cpf.Name = "rdb_cpf";
            this.rdb_cpf.Size = new System.Drawing.Size(68, 28);
            this.rdb_cpf.TabIndex = 3;
            this.rdb_cpf.TabStop = true;
            this.rdb_cpf.Text = "CPF";
            this.rdb_cpf.UseVisualStyleBackColor = true;
            this.rdb_cpf.CheckedChanged += new System.EventHandler(this.rdb_cpf_CheckedChanged);
            // 
            // rdb_pis
            // 
            this.rdb_pis.AutoSize = true;
            this.rdb_pis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_pis.Location = new System.Drawing.Point(290, 117);
            this.rdb_pis.Name = "rdb_pis";
            this.rdb_pis.Size = new System.Drawing.Size(59, 28);
            this.rdb_pis.TabIndex = 4;
            this.rdb_pis.TabStop = true;
            this.rdb_pis.Text = "PIS";
            this.rdb_pis.UseVisualStyleBackColor = true;
            this.rdb_pis.CheckedChanged += new System.EventHandler(this.rdb_pis_CheckedChanged);
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(139, 162);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(199, 34);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Iniciar Validação";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // maskValor
            // 
            this.maskValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskValor.Location = new System.Drawing.Point(107, 70);
            this.maskValor.Name = "maskValor";
            this.maskValor.Size = new System.Drawing.Size(258, 29);
            this.maskValor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 238);
            this.Controls.Add(this.maskValor);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.rdb_pis);
            this.Controls.Add(this.rdb_cpf);
            this.Controls.Add(this.rdb_cnpj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validando CNPJ, CPF e PIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_cnpj;
        private System.Windows.Forms.RadioButton rdb_cpf;
        private System.Windows.Forms.RadioButton rdb_pis;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.MaskedTextBox maskValor;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

