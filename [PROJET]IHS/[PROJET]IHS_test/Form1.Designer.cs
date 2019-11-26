namespace _PROJET_IHS_test
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAlarme = new System.Windows.Forms.Label();
            this.labelNombre1 = new System.Windows.Forms.Label();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.labelReponse = new System.Windows.Forms.Label();
            this.labelOperateur = new System.Windows.Forms.Label();
            this.labelEgal = new System.Windows.Forms.Label();
            this.labelAvancement = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fondEcranImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondEcranImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.labelAlarme);
            this.groupBox1.Location = new System.Drawing.Point(686, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(181, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxAlarme";
            // 
            // labelAlarme
            // 
            this.labelAlarme.AutoSize = true;
            this.labelAlarme.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelAlarme.ForeColor = System.Drawing.Color.Red;
            this.labelAlarme.Location = new System.Drawing.Point(33, 41);
            this.labelAlarme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlarme.Name = "labelAlarme";
            this.labelAlarme.Size = new System.Drawing.Size(129, 32);
            this.labelAlarme.TabIndex = 0;
            this.labelAlarme.Text = "ALARME";
            // 
            // labelNombre1
            // 
            this.labelNombre1.AutoSize = true;
            this.labelNombre1.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre1.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelNombre1.ForeColor = System.Drawing.Color.Yellow;
            this.labelNombre1.Location = new System.Drawing.Point(61, 90);
            this.labelNombre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre1.Name = "labelNombre1";
            this.labelNombre1.Size = new System.Drawing.Size(138, 100);
            this.labelNombre1.TabIndex = 1;
            this.labelNombre1.Text = "10";
            // 
            // labelNombre2
            // 
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre2.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelNombre2.ForeColor = System.Drawing.Color.Yellow;
            this.labelNombre2.Location = new System.Drawing.Point(699, 170);
            this.labelNombre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(90, 100);
            this.labelNombre2.TabIndex = 2;
            this.labelNombre2.Text = "5";
            // 
            // labelReponse
            // 
            this.labelReponse.AutoSize = true;
            this.labelReponse.BackColor = System.Drawing.Color.Transparent;
            this.labelReponse.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelReponse.ForeColor = System.Drawing.Color.Yellow;
            this.labelReponse.Location = new System.Drawing.Point(365, 389);
            this.labelReponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReponse.Name = "labelReponse";
            this.labelReponse.Size = new System.Drawing.Size(138, 100);
            this.labelReponse.TabIndex = 3;
            this.labelReponse.Text = "15";
            // 
            // labelOperateur
            // 
            this.labelOperateur.AutoSize = true;
            this.labelOperateur.BackColor = System.Drawing.Color.Transparent;
            this.labelOperateur.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelOperateur.ForeColor = System.Drawing.Color.Yellow;
            this.labelOperateur.Location = new System.Drawing.Point(365, 149);
            this.labelOperateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOperateur.Name = "labelOperateur";
            this.labelOperateur.Size = new System.Drawing.Size(93, 100);
            this.labelOperateur.TabIndex = 4;
            this.labelOperateur.Text = "+";
            // 
            // labelEgal
            // 
            this.labelEgal.AutoSize = true;
            this.labelEgal.BackColor = System.Drawing.Color.Transparent;
            this.labelEgal.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelEgal.ForeColor = System.Drawing.Color.Yellow;
            this.labelEgal.Location = new System.Drawing.Point(107, 389);
            this.labelEgal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEgal.Name = "labelEgal";
            this.labelEgal.Size = new System.Drawing.Size(93, 100);
            this.labelEgal.TabIndex = 5;
            this.labelEgal.Text = "=";
            this.labelEgal.Click += new System.EventHandler(this.Label5_Click);
            // 
            // labelAvancement
            // 
            this.labelAvancement.AutoSize = true;
            this.labelAvancement.Location = new System.Drawing.Point(8, 1);
            this.labelAvancement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAvancement.Name = "labelAvancement";
            this.labelAvancement.Size = new System.Drawing.Size(67, 13);
            this.labelAvancement.TabIndex = 6;
            this.labelAvancement.Text = "Avancement";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fondEcranImage
            // 
            this.fondEcranImage.Image = ((System.Drawing.Image)(resources.GetObject("fondEcranImage.Image")));
            this.fondEcranImage.Location = new System.Drawing.Point(1, 1);
            this.fondEcranImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fondEcranImage.Name = "fondEcranImage";
            this.fondEcranImage.Size = new System.Drawing.Size(887, 569);
            this.fondEcranImage.TabIndex = 7;
            this.fondEcranImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(927, 614);
            this.Controls.Add(this.labelAvancement);
            this.Controls.Add(this.labelEgal);
            this.Controls.Add(this.labelOperateur);
            this.Controls.Add(this.labelReponse);
            this.Controls.Add(this.labelNombre2);
            this.Controls.Add(this.labelNombre1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fondEcranImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "IHS Test Utilisateur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondEcranImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAlarme;
        private System.Windows.Forms.Label labelNombre1;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label labelReponse;
        private System.Windows.Forms.Label labelOperateur;
        private System.Windows.Forms.Label labelEgal;
        private System.Windows.Forms.Label labelAvancement;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox fondEcranImage;
    }
}

