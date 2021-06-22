
namespace StreaminVideoApplication
{
    partial class Statistiche
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
            this.statisticheView = new System.Windows.Forms.DataGridView();
            this.utentiButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.accountBox = new System.Windows.Forms.TextBox();
            this.serieButton = new System.Windows.Forms.Button();
            this.iscrizioniButton = new System.Windows.Forms.Button();
            this.iscrizioniBox = new System.Windows.Forms.TextBox();
            this.orarioButton = new System.Windows.Forms.Button();
            this.incassoButton = new System.Windows.Forms.Button();
            this.orarioView = new System.Windows.Forms.DataGridView();
            this.incassoView = new System.Windows.Forms.DataGridView();
            this.medioView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.statisticheView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orarioView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incassoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medioView)).BeginInit();
            this.SuspendLayout();
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(3, 2);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 0;
            this.indietroButton.Text = "<-- Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // statisticheView
            // 
            this.statisticheView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statisticheView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.statisticheView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticheView.Location = new System.Drawing.Point(223, 212);
            this.statisticheView.Name = "statisticheView";
            this.statisticheView.Size = new System.Drawing.Size(406, 57);
            this.statisticheView.TabIndex = 1;
            this.statisticheView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statisticheView_CellContentClick);
            // 
            // utentiButton
            // 
            this.utentiButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.utentiButton.Location = new System.Drawing.Point(13, 77);
            this.utentiButton.Name = "utentiButton";
            this.utentiButton.Size = new System.Drawing.Size(211, 25);
            this.utentiButton.TabIndex = 2;
            this.utentiButton.Text = "Numero medio di utenti per ogni account";
            this.utentiButton.UseVisualStyleBackColor = true;
            this.utentiButton.Click += new System.EventHandler(this.utentiButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accountButton.Location = new System.Drawing.Point(13, 152);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(141, 23);
            this.accountButton.TabIndex = 3;
            this.accountButton.Text = "Numero totale di account";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // accountBox
            // 
            this.accountBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accountBox.Location = new System.Drawing.Point(180, 152);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(100, 20);
            this.accountBox.TabIndex = 4;
            // 
            // serieButton
            // 
            this.serieButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.serieButton.Location = new System.Drawing.Point(13, 228);
            this.serieButton.Name = "serieButton";
            this.serieButton.Size = new System.Drawing.Size(188, 23);
            this.serieButton.TabIndex = 5;
            this.serieButton.Text = "Serie Tv più lunga sulla piattaforma";
            this.serieButton.UseVisualStyleBackColor = true;
            this.serieButton.Click += new System.EventHandler(this.serieButton_Click);
            // 
            // iscrizioniButton
            // 
            this.iscrizioniButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iscrizioniButton.Location = new System.Drawing.Point(13, 307);
            this.iscrizioniButton.Name = "iscrizioniButton";
            this.iscrizioniButton.Size = new System.Drawing.Size(141, 38);
            this.iscrizioniButton.TabIndex = 6;
            this.iscrizioniButton.Text = "Numero Iscrizioni del mese corrente";
            this.iscrizioniButton.UseVisualStyleBackColor = true;
            this.iscrizioniButton.Click += new System.EventHandler(this.incassoButton_Click);
            // 
            // iscrizioniBox
            // 
            this.iscrizioniBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iscrizioniBox.Location = new System.Drawing.Point(180, 317);
            this.iscrizioniBox.Name = "iscrizioniBox";
            this.iscrizioniBox.Size = new System.Drawing.Size(100, 20);
            this.iscrizioniBox.TabIndex = 7;
            // 
            // orarioButton
            // 
            this.orarioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orarioButton.Location = new System.Drawing.Point(13, 392);
            this.orarioButton.Name = "orarioButton";
            this.orarioButton.Size = new System.Drawing.Size(141, 23);
            this.orarioButton.TabIndex = 8;
            this.orarioButton.Text = "Orario di punta";
            this.orarioButton.UseVisualStyleBackColor = true;
            this.orarioButton.Click += new System.EventHandler(this.orarioButton_Click);
            // 
            // incassoButton
            // 
            this.incassoButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incassoButton.Location = new System.Drawing.Point(13, 462);
            this.incassoButton.Name = "incassoButton";
            this.incassoButton.Size = new System.Drawing.Size(141, 23);
            this.incassoButton.TabIndex = 9;
            this.incassoButton.Text = "Incasso Annuo";
            this.incassoButton.UseVisualStyleBackColor = true;
            this.incassoButton.Click += new System.EventHandler(this.incassoButton_Click_1);
            // 
            // orarioView
            // 
            this.orarioView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orarioView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.orarioView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orarioView.Location = new System.Drawing.Point(180, 379);
            this.orarioView.Name = "orarioView";
            this.orarioView.Size = new System.Drawing.Size(179, 53);
            this.orarioView.TabIndex = 10;
            // 
            // incassoView
            // 
            this.incassoView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incassoView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.incassoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incassoView.Location = new System.Drawing.Point(180, 450);
            this.incassoView.Name = "incassoView";
            this.incassoView.Size = new System.Drawing.Size(179, 53);
            this.incassoView.TabIndex = 11;
            // 
            // medioView
            // 
            this.medioView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.medioView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.medioView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medioView.Location = new System.Drawing.Point(251, 67);
            this.medioView.Name = "medioView";
            this.medioView.Size = new System.Drawing.Size(179, 53);
            this.medioView.TabIndex = 12;
            // 
            // Statistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 533);
            this.Controls.Add(this.medioView);
            this.Controls.Add(this.incassoView);
            this.Controls.Add(this.orarioView);
            this.Controls.Add(this.incassoButton);
            this.Controls.Add(this.orarioButton);
            this.Controls.Add(this.iscrizioniBox);
            this.Controls.Add(this.iscrizioniButton);
            this.Controls.Add(this.serieButton);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.utentiButton);
            this.Controls.Add(this.statisticheView);
            this.Controls.Add(this.indietroButton);
            this.Name = "Statistiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiche";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.statisticheView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orarioView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incassoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medioView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.DataGridView statisticheView;
        private System.Windows.Forms.Button utentiButton;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.TextBox accountBox;
        private System.Windows.Forms.Button serieButton;
        private System.Windows.Forms.Button iscrizioniButton;
        private System.Windows.Forms.TextBox iscrizioniBox;
        private System.Windows.Forms.Button orarioButton;
        private System.Windows.Forms.Button incassoButton;
        private System.Windows.Forms.DataGridView orarioView;
        private System.Windows.Forms.DataGridView incassoView;
        private System.Windows.Forms.DataGridView medioView;
    }
}