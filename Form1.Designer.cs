namespace Alterador_de_IP
{
    partial class FrmHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkNissan = new System.Windows.Forms.CheckBox();
            this.ChkVW = new System.Windows.Forms.CheckBox();
            this.ChkGM = new System.Windows.Forms.CheckBox();
            this.RbGEM = new System.Windows.Forms.RadioButton();
            this.RbOnix = new System.Windows.Forms.RadioButton();
            this.RbUP = new System.Windows.Forms.RadioButton();
            this.RbMBQ = new System.Windows.Forms.RadioButton();
            this.RbFrontier = new System.Windows.Forms.RadioButton();
            this.RbVersa = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 80);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alteração - IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Treinamento";
            // 
            // ChkNissan
            // 
            this.ChkNissan.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkNissan.BackgroundImage = global::Alterador_de_IP.Properties.Resources.nissan_logo_1;
            this.ChkNissan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChkNissan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkNissan.FlatAppearance.BorderSize = 0;
            this.ChkNissan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkNissan.Location = new System.Drawing.Point(366, 148);
            this.ChkNissan.Name = "ChkNissan";
            this.ChkNissan.Size = new System.Drawing.Size(120, 112);
            this.ChkNissan.TabIndex = 4;
            this.ChkNissan.UseVisualStyleBackColor = true;
            this.ChkNissan.CheckedChanged += new System.EventHandler(this.ChkNissan_CheckedChanged);
            // 
            // ChkVW
            // 
            this.ChkVW.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkVW.BackgroundImage = global::Alterador_de_IP.Properties.Resources.volkswagen_vw_logo_1;
            this.ChkVW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChkVW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkVW.FlatAppearance.BorderSize = 0;
            this.ChkVW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkVW.Location = new System.Drawing.Point(201, 148);
            this.ChkVW.Name = "ChkVW";
            this.ChkVW.Size = new System.Drawing.Size(104, 112);
            this.ChkVW.TabIndex = 3;
            this.ChkVW.UseVisualStyleBackColor = true;
            this.ChkVW.CheckedChanged += new System.EventHandler(this.ChkVW_CheckedChanged);
            // 
            // ChkGM
            // 
            this.ChkGM.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkGM.BackgroundImage = global::Alterador_de_IP.Properties.Resources.novo_logo_gm_png_1024x1024;
            this.ChkGM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChkGM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkGM.FlatAppearance.BorderSize = 0;
            this.ChkGM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkGM.Location = new System.Drawing.Point(27, 148);
            this.ChkGM.Name = "ChkGM";
            this.ChkGM.Size = new System.Drawing.Size(104, 112);
            this.ChkGM.TabIndex = 2;
            this.ChkGM.UseVisualStyleBackColor = true;
            this.ChkGM.CheckedChanged += new System.EventHandler(this.ChkGM_CheckedChanged);
            // 
            // RbGEM
            // 
            this.RbGEM.AutoSize = true;
            this.RbGEM.Location = new System.Drawing.Point(47, 288);
            this.RbGEM.Name = "RbGEM";
            this.RbGEM.Size = new System.Drawing.Size(49, 17);
            this.RbGEM.TabIndex = 5;
            this.RbGEM.TabStop = true;
            this.RbGEM.Text = "GEM";
            this.RbGEM.UseVisualStyleBackColor = true;
            this.RbGEM.Visible = false;
            this.RbGEM.CheckedChanged += new System.EventHandler(this.RbGEM_CheckedChanged);
            // 
            // RbOnix
            // 
            this.RbOnix.AutoSize = true;
            this.RbOnix.Location = new System.Drawing.Point(47, 311);
            this.RbOnix.Name = "RbOnix";
            this.RbOnix.Size = new System.Drawing.Size(46, 17);
            this.RbOnix.TabIndex = 6;
            this.RbOnix.TabStop = true;
            this.RbOnix.Text = "Onix";
            this.RbOnix.UseVisualStyleBackColor = true;
            this.RbOnix.Visible = false;
            this.RbOnix.CheckedChanged += new System.EventHandler(this.RbOnix_CheckedChanged);
            // 
            // RbUP
            // 
            this.RbUP.AutoSize = true;
            this.RbUP.Location = new System.Drawing.Point(230, 315);
            this.RbUP.Name = "RbUP";
            this.RbUP.Size = new System.Drawing.Size(40, 17);
            this.RbUP.TabIndex = 8;
            this.RbUP.TabStop = true;
            this.RbUP.Text = "UP";
            this.RbUP.UseVisualStyleBackColor = true;
            this.RbUP.Visible = false;
            this.RbUP.CheckedChanged += new System.EventHandler(this.RbUP_CheckedChanged);
            // 
            // RbMBQ
            // 
            this.RbMBQ.AutoSize = true;
            this.RbMBQ.Location = new System.Drawing.Point(230, 288);
            this.RbMBQ.Name = "RbMBQ";
            this.RbMBQ.Size = new System.Drawing.Size(49, 17);
            this.RbMBQ.TabIndex = 7;
            this.RbMBQ.TabStop = true;
            this.RbMBQ.Text = "MBQ";
            this.RbMBQ.UseVisualStyleBackColor = true;
            this.RbMBQ.Visible = false;
            this.RbMBQ.CheckedChanged += new System.EventHandler(this.RbMBQ_CheckedChanged);
            // 
            // RbFrontier
            // 
            this.RbFrontier.AutoSize = true;
            this.RbFrontier.Location = new System.Drawing.Point(403, 311);
            this.RbFrontier.Name = "RbFrontier";
            this.RbFrontier.Size = new System.Drawing.Size(60, 17);
            this.RbFrontier.TabIndex = 10;
            this.RbFrontier.TabStop = true;
            this.RbFrontier.Text = "Frontier";
            this.RbFrontier.UseVisualStyleBackColor = true;
            this.RbFrontier.Visible = false;
            this.RbFrontier.CheckedChanged += new System.EventHandler(this.RbFrontier_CheckedChanged);
            // 
            // RbVersa
            // 
            this.RbVersa.AutoSize = true;
            this.RbVersa.Location = new System.Drawing.Point(403, 288);
            this.RbVersa.Name = "RbVersa";
            this.RbVersa.Size = new System.Drawing.Size(52, 17);
            this.RbVersa.TabIndex = 9;
            this.RbVersa.TabStop = true;
            this.RbVersa.Text = "Versa";
            this.RbVersa.UseVisualStyleBackColor = true;
            this.RbVersa.Visible = false;
            this.RbVersa.CheckedChanged += new System.EventHandler(this.RbVersa_CheckedChanged);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(519, 370);
            this.Controls.Add(this.RbFrontier);
            this.Controls.Add(this.RbVersa);
            this.Controls.Add(this.RbUP);
            this.Controls.Add(this.RbMBQ);
            this.Controls.Add(this.RbOnix);
            this.Controls.Add(this.RbGEM);
            this.Controls.Add(this.ChkNissan);
            this.Controls.Add(this.ChkVW);
            this.Controls.Add(this.ChkGM);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treinamento-IP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkGM;
        private System.Windows.Forms.CheckBox ChkVW;
        private System.Windows.Forms.CheckBox ChkNissan;
        private System.Windows.Forms.RadioButton RbGEM;
        private System.Windows.Forms.RadioButton RbOnix;
        private System.Windows.Forms.RadioButton RbUP;
        private System.Windows.Forms.RadioButton RbMBQ;
        private System.Windows.Forms.RadioButton RbFrontier;
        private System.Windows.Forms.RadioButton RbVersa;
    }
}

