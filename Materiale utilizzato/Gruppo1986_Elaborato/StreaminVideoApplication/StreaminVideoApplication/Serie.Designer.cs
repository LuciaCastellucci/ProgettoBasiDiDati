
namespace StreaminVideoApplication
{
    partial class Serie
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
            this.label4 = new System.Windows.Forms.Label();
            this.cercaGenereButton = new System.Windows.Forms.Button();
            this.genereBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cercaButton = new System.Windows.Forms.Button();
            this.titoloBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.visualizzaButton = new System.Windows.Forms.Button();
            this.serieView = new System.Windows.Forms.DataGridView();
            this.indietroButton = new System.Windows.Forms.Button();
            this.dettagliButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dettagliBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serieView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Inserisci il genere:";
            // 
            // cercaGenereButton
            // 
            this.cercaGenereButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cercaGenereButton.Location = new System.Drawing.Point(226, 273);
            this.cercaGenereButton.Name = "cercaGenereButton";
            this.cercaGenereButton.Size = new System.Drawing.Size(75, 23);
            this.cercaGenereButton.TabIndex = 20;
            this.cercaGenereButton.Text = "Cerca";
            this.cercaGenereButton.UseVisualStyleBackColor = true;
            this.cercaGenereButton.Click += new System.EventHandler(this.cercaGenereButton_Click);
            // 
            // genereBox
            // 
            this.genereBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genereBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genereBox.Location = new System.Drawing.Point(26, 276);
            this.genereBox.Name = "genereBox";
            this.genereBox.Size = new System.Drawing.Size(194, 20);
            this.genereBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ricerca per genere";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Inserisci il titolo:";
            // 
            // cercaButton
            // 
            this.cercaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cercaButton.Location = new System.Drawing.Point(226, 166);
            this.cercaButton.Name = "cercaButton";
            this.cercaButton.Size = new System.Drawing.Size(75, 23);
            this.cercaButton.TabIndex = 16;
            this.cercaButton.Text = "Cerca";
            this.cercaButton.UseVisualStyleBackColor = true;
            this.cercaButton.Click += new System.EventHandler(this.cercaButton_Click);
            // 
            // titoloBox
            // 
            this.titoloBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titoloBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titoloBox.Location = new System.Drawing.Point(26, 169);
            this.titoloBox.Name = "titoloBox";
            this.titoloBox.Size = new System.Drawing.Size(194, 20);
            this.titoloBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ricerca per titolo serie";
            // 
            // visualizzaButton
            // 
            this.visualizzaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.visualizzaButton.Location = new System.Drawing.Point(26, 54);
            this.visualizzaButton.Name = "visualizzaButton";
            this.visualizzaButton.Size = new System.Drawing.Size(136, 23);
            this.visualizzaButton.TabIndex = 13;
            this.visualizzaButton.Text = "Visualizza Tutte Le Serie";
            this.visualizzaButton.UseVisualStyleBackColor = true;
            this.visualizzaButton.Click += new System.EventHandler(this.visualizzaButton_Click);
            // 
            // serieView
            // 
            this.serieView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serieView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serieView.Location = new System.Drawing.Point(334, 54);
            this.serieView.Name = "serieView";
            this.serieView.Size = new System.Drawing.Size(486, 475);
            this.serieView.TabIndex = 12;
            this.serieView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serieView_CellContentClick);
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(1, -1);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 11;
            this.indietroButton.Text = "<-- Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // dettagliButton
            // 
            this.dettagliButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dettagliButton.Location = new System.Drawing.Point(226, 390);
            this.dettagliButton.Name = "dettagliButton";
            this.dettagliButton.Size = new System.Drawing.Size(75, 23);
            this.dettagliButton.TabIndex = 22;
            this.dettagliButton.Text = "Vedi dettagli";
            this.dettagliButton.UseVisualStyleBackColor = true;
            this.dettagliButton.Click += new System.EventHandler(this.dettagliButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Inserisci il titolo:";
            // 
            // dettagliBox
            // 
            this.dettagliBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dettagliBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dettagliBox.Location = new System.Drawing.Point(23, 390);
            this.dettagliBox.Name = "dettagliBox";
            this.dettagliBox.Size = new System.Drawing.Size(194, 20);
            this.dettagliBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Visualizza dettagli di una serie";
            // 
            // Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 541);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dettagliBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dettagliButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cercaGenereButton);
            this.Controls.Add(this.genereBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cercaButton);
            this.Controls.Add(this.titoloBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visualizzaButton);
            this.Controls.Add(this.serieView);
            this.Controls.Add(this.indietroButton);
            this.Name = "Serie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.serieView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cercaGenereButton;
        private System.Windows.Forms.TextBox genereBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cercaButton;
        private System.Windows.Forms.TextBox titoloBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button visualizzaButton;
        private System.Windows.Forms.DataGridView serieView;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.Button dettagliButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dettagliBox;
        private System.Windows.Forms.Label label6;
    }
}