namespace Carnet_adresses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btRechercheNomComplet = new System.Windows.Forms.Button();
            this.btRechercheMail = new System.Windows.Forms.Button();
            this.tbRechercheNomComplet = new System.Windows.Forms.TextBox();
            this.tbRechercheCourriel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.btTrie = new System.Windows.Forms.Button();
            this.btActualiser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTel);
            this.groupBox1.Controls.Add(this.tbCourriel);
            this.groupBox1.Controls.Add(this.tbAdresse);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btValider);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un contact";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(104, 183);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(123, 26);
            this.tbTel.TabIndex = 10;
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(104, 148);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(123, 26);
            this.tbCourriel.TabIndex = 9;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(104, 116);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(123, 26);
            this.tbAdresse.TabIndex = 8;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(104, 83);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(123, 26);
            this.tbPrenom.TabIndex = 7;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(104, 48);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(123, 26);
            this.tbNom.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Téléphone : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Courriel :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(104, 265);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(77, 31);
            this.btValider.TabIndex = 0;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet d\'adresse";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btActualiser);
            this.groupBox2.Controls.Add(this.btTrie);
            this.groupBox2.Controls.Add(this.btRechercheNomComplet);
            this.groupBox2.Controls.Add(this.btRechercheMail);
            this.groupBox2.Controls.Add(this.tbRechercheNomComplet);
            this.groupBox2.Controls.Add(this.tbRechercheCourriel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbContacts);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(393, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 320);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des contacts";
            // 
            // btRechercheNomComplet
            // 
            this.btRechercheNomComplet.Location = new System.Drawing.Point(252, 281);
            this.btRechercheNomComplet.Name = "btRechercheNomComplet";
            this.btRechercheNomComplet.Size = new System.Drawing.Size(112, 29);
            this.btRechercheNomComplet.TabIndex = 6;
            this.btRechercheNomComplet.Text = "Rechercher";
            this.btRechercheNomComplet.UseVisualStyleBackColor = true;
            this.btRechercheNomComplet.Click += new System.EventHandler(this.btRechercheNomComplet_Click);
            // 
            // btRechercheMail
            // 
            this.btRechercheMail.Location = new System.Drawing.Point(252, 217);
            this.btRechercheMail.Name = "btRechercheMail";
            this.btRechercheMail.Size = new System.Drawing.Size(112, 29);
            this.btRechercheMail.TabIndex = 5;
            this.btRechercheMail.Text = "Rechercher";
            this.btRechercheMail.UseVisualStyleBackColor = true;
            this.btRechercheMail.Click += new System.EventHandler(this.btRechercheMail_Click);
            // 
            // tbRechercheNomComplet
            // 
            this.tbRechercheNomComplet.Location = new System.Drawing.Point(36, 284);
            this.tbRechercheNomComplet.Name = "tbRechercheNomComplet";
            this.tbRechercheNomComplet.Size = new System.Drawing.Size(173, 26);
            this.tbRechercheNomComplet.TabIndex = 4;
            // 
            // tbRechercheCourriel
            // 
            this.tbRechercheCourriel.Location = new System.Drawing.Point(36, 220);
            this.tbRechercheCourriel.Name = "tbRechercheCourriel";
            this.tbRechercheCourriel.Size = new System.Drawing.Size(173, 26);
            this.tbRechercheCourriel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Rechercher par nom complet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Rechercher par mail";
            // 
            // lbContacts
            // 
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.ItemHeight = 20;
            this.lbContacts.Location = new System.Drawing.Point(6, 36);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(358, 84);
            this.lbContacts.TabIndex = 0;
            // 
            // btTrie
            // 
            this.btTrie.Location = new System.Drawing.Point(197, 126);
            this.btTrie.Name = "btTrie";
            this.btTrie.Size = new System.Drawing.Size(144, 31);
            this.btTrie.TabIndex = 7;
            this.btTrie.Text = "Trier par nom complet";
            this.btTrie.UseVisualStyleBackColor = true;
            this.btTrie.Click += new System.EventHandler(this.btTrie_Click);
            // 
            // btActualiser
            // 
            this.btActualiser.Location = new System.Drawing.Point(36, 126);
            this.btActualiser.Name = "btActualiser";
            this.btActualiser.Size = new System.Drawing.Size(144, 31);
            this.btActualiser.TabIndex = 8;
            this.btActualiser.Text = "Actualiser";
            this.btActualiser.UseVisualStyleBackColor = true;
            this.btActualiser.Click += new System.EventHandler(this.btActualiser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Carnet d\'adresse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbContacts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btRechercheNomComplet;
        private System.Windows.Forms.Button btRechercheMail;
        private System.Windows.Forms.TextBox tbRechercheNomComplet;
        private System.Windows.Forms.TextBox tbRechercheCourriel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btActualiser;
        private System.Windows.Forms.Button btTrie;
    }
}

