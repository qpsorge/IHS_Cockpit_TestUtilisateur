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
            this.groupBox1.Location = new System.Drawing.Point(1029, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxAlarme";
            // 
            // labelAlarme
            // 
            this.labelAlarme.AutoSize = true;
            this.labelAlarme.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.labelAlarme.ForeColor = System.Drawing.Color.Red;
            this.labelAlarme.Location = new System.Drawing.Point(50, 63);
            this.labelAlarme.Name = "labelAlarme";
            this.labelAlarme.Size = new System.Drawing.Size(187, 46);
            this.labelAlarme.TabIndex = 0;
            this.labelAlarme.Text = "ALARME";
            // 
            // labelNombre1
            // 
            this.labelNombre1.AutoSize = true;
            this.labelNombre1.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelNombre1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelNombre1.Location = new System.Drawing.Point(92, 139);
            this.labelNombre1.Name = "labelNombre1";
            this.labelNombre1.Size = new System.Drawing.Size(207, 150);
            this.labelNombre1.TabIndex = 1;
            this.labelNombre1.Text = "10";
            // 
            // labelNombre2
            // 
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelNombre2.ForeColor = System.Drawing.Color.Blue;
            this.labelNombre2.Location = new System.Drawing.Point(1049, 261);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(135, 150);
            this.labelNombre2.TabIndex = 2;
            this.labelNombre2.Text = "5";
            // 
            // labelReponse
            // 
            this.labelReponse.AutoSize = true;
            this.labelReponse.BackColor = System.Drawing.Color.Turquoise;
            this.labelReponse.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelReponse.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelReponse.Location = new System.Drawing.Point(547, 599);
            this.labelReponse.Name = "labelReponse";
            this.labelReponse.Size = new System.Drawing.Size(207, 150);
            this.labelReponse.TabIndex = 3;
            this.labelReponse.Text = "15";
            // 
            // labelOperateur
            // 
            this.labelOperateur.AutoSize = true;
            this.labelOperateur.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelOperateur.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelOperateur.Location = new System.Drawing.Point(547, 230);
            this.labelOperateur.Name = "labelOperateur";
            this.labelOperateur.Size = new System.Drawing.Size(139, 150);
            this.labelOperateur.TabIndex = 4;
            this.labelOperateur.Text = "+";
            // 
            // labelEgal
            // 
            this.labelEgal.AutoSize = true;
            this.labelEgal.Font = new System.Drawing.Font("Arial", 65F, System.Drawing.FontStyle.Bold);
            this.labelEgal.ForeColor = System.Drawing.Color.Magenta;
            this.labelEgal.Location = new System.Drawing.Point(160, 599);
            this.labelEgal.Name = "labelEgal";
            this.labelEgal.Size = new System.Drawing.Size(139, 150);
            this.labelEgal.TabIndex = 5;
            this.labelEgal.Text = "=";
            this.labelEgal.Click += new System.EventHandler(this.Label5_Click);
            // 
            // labelAvancement
            // 
            this.labelAvancement.AutoSize = true;
            this.labelAvancement.Location = new System.Drawing.Point(12, 1);
            this.labelAvancement.Name = "labelAvancement";
            this.labelAvancement.Size = new System.Drawing.Size(98, 20);
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
            this.fondEcranImage.Name = "fondEcranImage";
            this.fondEcranImage.Size = new System.Drawing.Size(1331, 875);
            this.fondEcranImage.TabIndex = 7;
            this.fondEcranImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1390, 945);
            this.Controls.Add(this.labelAvancement);
            this.Controls.Add(this.labelEgal);
            this.Controls.Add(this.labelOperateur);
            this.Controls.Add(this.labelReponse);
            this.Controls.Add(this.labelNombre2);
            this.Controls.Add(this.labelNombre1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fondEcranImage);
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

