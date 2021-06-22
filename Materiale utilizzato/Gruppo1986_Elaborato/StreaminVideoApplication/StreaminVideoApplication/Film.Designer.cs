
namespace StreaminVideoApplication
{
    partial class Film
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
            this.indietroButton = new System.Windows.Forms.Button();
            this.filmView = new System.Windows.Forms.DataGridView();
            this.visualizzaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titoloBox = new System.Windows.Forms.TextBox();
            this.cercaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cercaGenereButton = new System.Windows.Forms.Button();
            this.genereBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmView)).BeginInit();
            this.SuspendLayout();
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(1, 1);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 0;
            this.indietroButton.Text = "<-- Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // filmView
            // 
            this.filmView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmView.Location = new System.Drawing.Point(334, 56);
            this.filmView.Name = "filmView";
            this.filmView.Size = new System.Drawing.Size(486, 475);
            this.filmView.TabIndex = 1;
            this.filmView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmView_CellContentClick);
            // 
            // visualizzaButton
            // 
            this.visualizzaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.visualizzaButton.Location = new System.Drawing.Point(26, 56);
            this.visualizzaButton.Name = "visualizzaButton";
            this.visualizzaButton.Size = new System.Drawing.Size(136, 23);
            this.visualizzaButton.TabIndex = 2;
            this.visualizzaButton.Text = "Visualizza Tutti";
            this.visualizzaButton.UseVisualStyleBackColor = true;
            this.visualizzaButton.Click += new System.EventHandler(this.visualizzaButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ricerca per titolo";
            // 
            // titoloBox
            // 
            this.titoloBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titoloBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titoloBox.Location = new System.Drawing.Point(26, 171);
            this.titoloBox.Name = "titoloBox";
            this.titoloBox.Size = new System.Drawing.Size(194, 20);
            this.titoloBox.TabIndex = 4;
            // 
            // cercaButton
            // 
            this.cercaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cercaButton.Location = new System.Drawing.Point(226, 168);
            this.cercaButton.Name = "cercaButton";
            this.cercaButton.Size = new System.Drawing.Size(75, 23);
            this.cercaButton.TabIndex = 5;
            this.cercaButton.Text = "Cerca";
            this.cercaButton.UseVisualStyleBackColor = true;
            this.cercaButton.Click += new System.EventHandler(this.cercaButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inserisci il titolo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ricerca per genere";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inserisci il genere:";
            // 
            // cercaGenereButton
            // 
            this.cercaGenereButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cercaGenereButton.Location = new System.Drawing.Point(226, 275);
            this.cercaGenereButton.Name = "cercaGenereButton";
            this.cercaGenereButton.Size = new System.Drawing.Size(75, 23);
            this.cercaGenereButton.TabIndex = 9;
            this.cercaGenereButton.Text = "Cerca";
            this.cercaGenereButton.UseVisualStyleBackColor = true;
            this.cercaGenereButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // genereBox
            // 
            this.genereBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genereBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genereBox.Location = new System.Drawing.Point(26, 278);
            this.genereBox.Name = "genereBox";
            this.genereBox.Size = new System.Drawing.Size(194, 20);
            this.genereBox.TabIndex = 8;
            this.genereBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cercaGenereButton);
            this.Controls.Add(this.genereBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cercaButton);
            this.Controls.Add(this.titoloBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visualizzaButton);
            this.Controls.Add(this.filmView);
            this.Controls.Add(this.indietroButton);
            this.Name = "Film";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.filmView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.DataGridView filmView;
        private System.Windows.Forms.Button visualizzaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titoloBox;
        private System.Windows.Forms.Button cercaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cercaGenereButton;
        private System.Windows.Forms.TextBox genereBox;
    }
}