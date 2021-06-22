
namespace StreaminVideoApplication
{
    partial class Classifiche
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
            this.classificheView = new System.Windows.Forms.DataGridView();
            this.filmButton = new System.Windows.Forms.Button();
            this.serieButton = new System.Windows.Forms.Button();
            this.utentiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classificheView)).BeginInit();
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
            // classificheView
            // 
            this.classificheView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classificheView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classificheView.Location = new System.Drawing.Point(324, 87);
            this.classificheView.Name = "classificheView";
            this.classificheView.Size = new System.Drawing.Size(492, 444);
            this.classificheView.TabIndex = 1;
            this.classificheView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classificheView_CellContentClick);
            // 
            // filmButton
            // 
            this.filmButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filmButton.Location = new System.Drawing.Point(12, 87);
            this.filmButton.Name = "filmButton";
            this.filmButton.Size = new System.Drawing.Size(183, 23);
            this.filmButton.TabIndex = 2;
            this.filmButton.Text = "Top 10 film più visti";
            this.filmButton.UseVisualStyleBackColor = true;
            this.filmButton.Click += new System.EventHandler(this.filmButton_Click);
            // 
            // serieButton
            // 
            this.serieButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.serieButton.Location = new System.Drawing.Point(12, 177);
            this.serieButton.Name = "serieButton";
            this.serieButton.Size = new System.Drawing.Size(183, 23);
            this.serieButton.TabIndex = 3;
            this.serieButton.Text = "Top 10 serie tv più viste";
            this.serieButton.UseVisualStyleBackColor = true;
            this.serieButton.Click += new System.EventHandler(this.serieButton_Click);
            // 
            // utentiButton
            // 
            this.utentiButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.utentiButton.Location = new System.Drawing.Point(12, 270);
            this.utentiButton.Name = "utentiButton";
            this.utentiButton.Size = new System.Drawing.Size(183, 40);
            this.utentiButton.TabIndex = 4;
            this.utentiButton.Text = "Top 10 utenti che hanno passato più tempo sulla piattaforma";
            this.utentiButton.UseVisualStyleBackColor = true;
            this.utentiButton.Click += new System.EventHandler(this.utentiButton_Click);
            // 
            // Classifiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 532);
            this.Controls.Add(this.utentiButton);
            this.Controls.Add(this.serieButton);
            this.Controls.Add(this.filmButton);
            this.Controls.Add(this.classificheView);
            this.Controls.Add(this.indietroButton);
            this.Name = "Classifiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classifiche";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.classificheView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.DataGridView classificheView;
        private System.Windows.Forms.Button filmButton;
        private System.Windows.Forms.Button serieButton;
        private System.Windows.Forms.Button utentiButton;
    }
}