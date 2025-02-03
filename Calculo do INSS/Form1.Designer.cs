
namespace Calculo_do_INSS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsb = new System.Windows.Forms.TextBox();
            this.txtinss = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário bruto R$";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desc. INSS %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário Líquido R$";
            // 
            // txtsb
            // 
            this.txtsb.BackColor = System.Drawing.Color.White;
            this.txtsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsb.Location = new System.Drawing.Point(470, 70);
            this.txtsb.Name = "txtsb";
            this.txtsb.Size = new System.Drawing.Size(198, 53);
            this.txtsb.TabIndex = 3;
            // 
            // txtinss
            // 
            this.txtinss.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinss.Location = new System.Drawing.Point(470, 165);
            this.txtinss.Name = "txtinss";
            this.txtinss.Size = new System.Drawing.Size(198, 53);
            this.txtinss.TabIndex = 4;
            // 
            // txtsl
            // 
            this.txtsl.Cursor = System.Windows.Forms.Cursors.No;
            this.txtsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(470, 263);
            this.txtsl.Name = "txtsl";
            this.txtsl.ReadOnly = true;
            this.txtsl.Size = new System.Drawing.Size(198, 53);
            this.txtsl.TabIndex = 5;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Image = global::Calculo_do_INSS.Properties.Resources.limpar;
            this.btnlimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpar.Location = new System.Drawing.Point(343, 349);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(186, 61);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Image = global::Calculo_do_INSS.Properties.Resources.fechar;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(598, 349);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(134, 61);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Sai&r";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Image = global::Calculo_do_INSS.Properties.Resources.calculadora;
            this.btncalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncalcular.Location = new System.Drawing.Point(54, 349);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(214, 61);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "&Calcular";
            this.btncalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calculadora INSS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtinss);
            this.Controls.Add(this.txtsb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo do Imposto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsb;
        private System.Windows.Forms.TextBox txtinss;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label4;
    }
}

