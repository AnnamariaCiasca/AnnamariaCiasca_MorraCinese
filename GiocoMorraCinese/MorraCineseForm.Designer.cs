
namespace GiocoMorraCinese
{
    partial class MorraCineseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSasso = new System.Windows.Forms.Button();
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnForbice = new System.Windows.Forms.Button();
            this.btnGioca = new System.Windows.Forms.Button();
            this.txtUscitaGiocatore = new System.Windows.Forms.TextBox();
            this.txtUscitaPC = new System.Windows.Forms.TextBox();
            this.txtEsito = new System.Windows.Forms.TextBox();
            this.imgProfiloGiocat = new System.Windows.Forms.PictureBox();
            this.imgProfiloPC = new System.Windows.Forms.PictureBox();
            this.imgUscitaGioc = new System.Windows.Forms.PictureBox();
            this.imgUscitaPC = new System.Windows.Forms.PictureBox();
            this.btnRicomincia = new System.Windows.Forms.Button();
            this.txtPunteggioGioc = new System.Windows.Forms.TextBox();
            this.txtPunteggioPC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfiloGiocat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfiloPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUscitaGioc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUscitaPC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSasso
            // 
            this.btnSasso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSasso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSasso.Location = new System.Drawing.Point(12, 72);
            this.btnSasso.Name = "btnSasso";
            this.btnSasso.Size = new System.Drawing.Size(142, 71);
            this.btnSasso.TabIndex = 0;
            this.btnSasso.Text = "Sasso";
            this.btnSasso.UseVisualStyleBackColor = false;
            this.btnSasso.Click += new System.EventHandler(this.btnSasso_Click);
            // 
            // btnCarta
            // 
            this.btnCarta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCarta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarta.Location = new System.Drawing.Point(12, 149);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(142, 71);
            this.btnCarta.TabIndex = 1;
            this.btnCarta.Text = "Carta";
            this.btnCarta.UseVisualStyleBackColor = false;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnForbice
            // 
            this.btnForbice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnForbice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForbice.Location = new System.Drawing.Point(12, 226);
            this.btnForbice.Name = "btnForbice";
            this.btnForbice.Size = new System.Drawing.Size(142, 71);
            this.btnForbice.TabIndex = 2;
            this.btnForbice.Text = "Forbice";
            this.btnForbice.UseVisualStyleBackColor = false;
            this.btnForbice.Click += new System.EventHandler(this.btnForbice_Click);
            // 
            // btnGioca
            // 
            this.btnGioca.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGioca.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGioca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGioca.Location = new System.Drawing.Point(12, 367);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(142, 54);
            this.btnGioca.TabIndex = 3;
            this.btnGioca.Text = "Gioca!";
            this.btnGioca.UseVisualStyleBackColor = false;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // txtUscitaGiocatore
            // 
            this.txtUscitaGiocatore.Location = new System.Drawing.Point(231, 149);
            this.txtUscitaGiocatore.Name = "txtUscitaGiocatore";
            this.txtUscitaGiocatore.Size = new System.Drawing.Size(174, 31);
            this.txtUscitaGiocatore.TabIndex = 4;
            this.txtUscitaGiocatore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUscitaPC
            // 
            this.txtUscitaPC.Location = new System.Drawing.Point(554, 149);
            this.txtUscitaPC.Name = "txtUscitaPC";
            this.txtUscitaPC.Size = new System.Drawing.Size(174, 31);
            this.txtUscitaPC.TabIndex = 5;
            this.txtUscitaPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEsito
            // 
            this.txtEsito.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEsito.Location = new System.Drawing.Point(413, 371);
            this.txtEsito.Name = "txtEsito";
            this.txtEsito.Size = new System.Drawing.Size(143, 34);
            this.txtEsito.TabIndex = 6;
            this.txtEsito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgProfiloGiocat
            // 
            this.imgProfiloGiocat.Image = global::GiocoMorraCinese.Properties.Resources.imgUtente;
            this.imgProfiloGiocat.Location = new System.Drawing.Point(253, 12);
            this.imgProfiloGiocat.Name = "imgProfiloGiocat";
            this.imgProfiloGiocat.Size = new System.Drawing.Size(127, 131);
            this.imgProfiloGiocat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfiloGiocat.TabIndex = 7;
            this.imgProfiloGiocat.TabStop = false;
            this.imgProfiloGiocat.Click += new System.EventHandler(this.imgProfiloGiocat_Click);
            // 
            // imgProfiloPC
            // 
            this.imgProfiloPC.Image = global::GiocoMorraCinese.Properties.Resources.imgPC;
            this.imgProfiloPC.Location = new System.Drawing.Point(575, 12);
            this.imgProfiloPC.Name = "imgProfiloPC";
            this.imgProfiloPC.Size = new System.Drawing.Size(129, 131);
            this.imgProfiloPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfiloPC.TabIndex = 8;
            this.imgProfiloPC.TabStop = false;
            // 
            // imgUscitaGioc
            // 
            this.imgUscitaGioc.Location = new System.Drawing.Point(243, 191);
            this.imgUscitaGioc.Name = "imgUscitaGioc";
            this.imgUscitaGioc.Size = new System.Drawing.Size(150, 150);
            this.imgUscitaGioc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUscitaGioc.TabIndex = 9;
            this.imgUscitaGioc.TabStop = false;
            // 
            // imgUscitaPC
            // 
            this.imgUscitaPC.Location = new System.Drawing.Point(575, 191);
            this.imgUscitaPC.Name = "imgUscitaPC";
            this.imgUscitaPC.Size = new System.Drawing.Size(150, 150);
            this.imgUscitaPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUscitaPC.TabIndex = 10;
            this.imgUscitaPC.TabStop = false;
            // 
            // btnRicomincia
            // 
            this.btnRicomincia.Location = new System.Drawing.Point(642, 371);
            this.btnRicomincia.Name = "btnRicomincia";
            this.btnRicomincia.Size = new System.Drawing.Size(110, 50);
            this.btnRicomincia.TabIndex = 11;
            this.btnRicomincia.Text = "Riprova!";
            this.btnRicomincia.UseVisualStyleBackColor = true;
            this.btnRicomincia.Click += new System.EventHandler(this.btnRicomincia_Click);
            // 
            // txtPunteggioGioc
            // 
            this.txtPunteggioGioc.Location = new System.Drawing.Point(386, 72);
            this.txtPunteggioGioc.Name = "txtPunteggioGioc";
            this.txtPunteggioGioc.Size = new System.Drawing.Size(56, 31);
            this.txtPunteggioGioc.TabIndex = 12;
            this.txtPunteggioGioc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPunteggioPC
            // 
            this.txtPunteggioPC.Location = new System.Drawing.Point(513, 72);
            this.txtPunteggioPC.Name = "txtPunteggioPC";
            this.txtPunteggioPC.Size = new System.Drawing.Size(56, 31);
            this.txtPunteggioPC.TabIndex = 13;
            this.txtPunteggioPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fai la tua scelta!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(450, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 51);
            this.label2.TabIndex = 15;
            this.label2.Text = "VS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MorraCineseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPunteggioPC);
            this.Controls.Add(this.txtPunteggioGioc);
            this.Controls.Add(this.btnRicomincia);
            this.Controls.Add(this.imgUscitaPC);
            this.Controls.Add(this.imgUscitaGioc);
            this.Controls.Add(this.imgProfiloPC);
            this.Controls.Add(this.imgProfiloGiocat);
            this.Controls.Add(this.txtEsito);
            this.Controls.Add(this.txtUscitaPC);
            this.Controls.Add(this.txtUscitaGiocatore);
            this.Controls.Add(this.btnGioca);
            this.Controls.Add(this.btnForbice);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.btnSasso);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MorraCineseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Morra Cinese";
            ((System.ComponentModel.ISupportInitialize)(this.imgProfiloGiocat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfiloPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUscitaGioc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUscitaPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSasso;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button btnForbice;
        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.TextBox txtUscitaGiocatore;
        private System.Windows.Forms.TextBox txtUscitaPC;
        private System.Windows.Forms.TextBox txtEsito;
        private System.Windows.Forms.PictureBox imgProfiloGiocat;
        private System.Windows.Forms.PictureBox imgProfiloPC;
        private System.Windows.Forms.PictureBox imgUscitaGioc;
        private System.Windows.Forms.PictureBox imgUscitaPC;
        private System.Windows.Forms.Button btnRicomincia;
        private System.Windows.Forms.TextBox txtPunteggioGioc;
        private System.Windows.Forms.TextBox txtPunteggioPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

