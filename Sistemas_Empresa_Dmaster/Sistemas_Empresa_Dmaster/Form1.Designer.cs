namespace Sistemas_Empresa_Dmaster
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
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendar.Location = new System.Drawing.Point(367, 100);
            this.calendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.calendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(136, 26);
            this.calendar.TabIndex = 0;
            this.calendar.ValueChanged += new System.EventHandler(this.calendar_ValueChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(367, 158);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(136, 28);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(367, 221);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(136, 28);
            this.btFechar.TabIndex = 2;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(17, 105);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(344, 18);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Inativar produtos com movimentação menor que:";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirmar a data que selecionou:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encerra o ajuste:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "INATIVAÇÃO DE PRODUTOS SEM ESTOQUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

