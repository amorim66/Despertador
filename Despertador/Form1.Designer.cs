
namespace Despertador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.criarDes = new System.Windows.Forms.Button();
            this.criarH = new System.Windows.Forms.Button();
            this.btnAn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txth = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.txtm1 = new System.Windows.Forms.TextBox();
            this.txth1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtd);
            this.groupBox1.Controls.Add(this.txts);
            this.groupBox1.Controls.Add(this.txtm);
            this.groupBox1.Controls.Add(this.txth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despertador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txts1);
            this.groupBox2.Controls.Add(this.txtm1);
            this.groupBox2.Controls.Add(this.txth1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(283, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hora";
            // 
            // criarDes
            // 
            this.criarDes.Location = new System.Drawing.Point(108, 323);
            this.criarDes.Name = "criarDes";
            this.criarDes.Size = new System.Drawing.Size(75, 23);
            this.criarDes.TabIndex = 2;
            this.criarDes.Text = "Criar";
            this.criarDes.UseVisualStyleBackColor = true;
            this.criarDes.Click += new System.EventHandler(this.criarDes_Click);
            // 
            // criarH
            // 
            this.criarH.Location = new System.Drawing.Point(358, 323);
            this.criarH.Name = "criarH";
            this.criarH.Size = new System.Drawing.Size(75, 23);
            this.criarH.TabIndex = 3;
            this.criarH.Text = "Criar";
            this.criarH.UseVisualStyleBackColor = true;
            this.criarH.Click += new System.EventHandler(this.criarH_Click);
            // 
            // btnAn
            // 
            this.btnAn.Location = new System.Drawing.Point(206, 379);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(134, 32);
            this.btnAn.TabIndex = 4;
            this.btnAn.Text = "Analisar";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minuto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(24, 56);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(100, 26);
            this.txth.TabIndex = 4;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(24, 114);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(100, 26);
            this.txtm.TabIndex = 5;
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(24, 172);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(100, 26);
            this.txts.TabIndex = 6;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(24, 225);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(173, 26);
            this.txtd.TabIndex = 7;
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(32, 172);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 26);
            this.txts1.TabIndex = 12;
            // 
            // txtm1
            // 
            this.txtm1.Location = new System.Drawing.Point(32, 114);
            this.txtm1.Name = "txtm1";
            this.txtm1.Size = new System.Drawing.Size(100, 26);
            this.txtm1.TabIndex = 11;
            // 
            // txth1
            // 
            this.txth1.Location = new System.Drawing.Point(32, 56);
            this.txth1.Name = "txth1";
            this.txth1.Size = new System.Drawing.Size(100, 26);
            this.txth1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Segundo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Minuto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.criarH);
            this.Controls.Add(this.criarDes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.TextBox txtm1;
        private System.Windows.Forms.TextBox txth1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button criarDes;
        private System.Windows.Forms.Button criarH;
        private System.Windows.Forms.Button btnAn;
    }
}

