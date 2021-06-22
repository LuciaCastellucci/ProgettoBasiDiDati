
namespace StreaminVideoApplication
{
    partial class Utenti
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
            this.button1 = new System.Windows.Forms.Button();
            this.utentiView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.utenteButton = new System.Windows.Forms.Button();
            this.utenteBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cercaButton = new System.Windows.Forms.Button();
            this.accountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.visualizzaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.utentiView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<-- Indietro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // utentiView
            // 
            this.utentiView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utentiView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utentiView.Location = new System.Drawing.Point(335, 61);
            this.utentiView.Name = "utentiView";
            this.utentiView.Size = new System.Drawing.Size(466, 458);
            this.utentiView.TabIndex = 1;
            this.utentiView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Inserisci il nome utente:";
            // 
            // utenteButton
            // 
            this.utenteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.utenteButton.Location = new System.Drawing.Point(212, 280);
            this.utenteButton.Name = "utenteButton";
            this.utenteButton.Size = new System.Drawing.Size(75, 23);
            this.utenteButton.TabIndex = 29;
            this.utenteButton.Text = "Cerca";
            this.utenteButton.UseVisualStyleBackColor = true;
            this.utenteButton.Click += new System.EventHandler(this.utenteButton_Click);
            // 
            // utenteBox
            // 
            this.utenteBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.utenteBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.utenteBox.Location = new System.Drawing.Point(12, 283);
            this.utenteBox.Name = "utenteBox";
            this.utenteBox.Size = new System.Drawing.Size(194, 20);
            this.utenteBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ricerca per utente";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Inserisci il nome account:";
            // 
            // cercaButton
            // 
            this.cercaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cercaButton.Location = new System.Drawing.Point(212, 173);
            this.cercaButton.Name = "cercaButton";
            this.cercaButton.Size = new System.Drawing.Size(75, 23);
            this.cercaButton.TabIndex = 25;
            this.cercaButton.Text = "Cerca";
            this.cercaButton.UseVisualStyleBackColor = true;
            this.cercaButton.Click += new System.EventHandler(this.cercaButton_Click);
            // 
            // accountBox
            // 
            this.accountBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accountBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accountBox.Location = new System.Drawing.Point(12, 176);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(194, 20);
            this.accountBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ricerca per account";
            // 
            // visualizzaButton
            // 
            this.visualizzaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.visualizzaButton.Location = new System.Drawing.Point(12, 61);
            this.visualizzaButton.Name = "visualizzaButton";
            this.visualizzaButton.Size = new System.Drawing.Size(136, 23);
            this.visualizzaButton.TabIndex = 22;
            this.visualizzaButton.Text = "Visualizza Tutti";
            this.visualizzaButton.UseVisualStyleBackColor = true;
            this.visualizzaButton.Click += new System.EventHandler(this.visualizzaButton_Click);
            // 
            // Utenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.utenteButton);
            this.Controls.Add(this.utenteBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cercaButton);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visualizzaButton);
            this.Controls.Add(this.utentiView);
            this.Controls.Add(this.button1);
            this.Name = "Utenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utenti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.utentiView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView utentiView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button utenteButton;
        private System.Windows.Forms.TextBox utenteBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cercaButton;
        private System.Windows.Forms.TextBox accountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button visualizzaButton;
    }
}