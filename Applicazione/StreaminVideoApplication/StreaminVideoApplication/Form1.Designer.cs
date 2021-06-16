namespace StreaminVideoApplication
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classificheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticheProduzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticheEconomicheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visioniRealTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totaleAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orarioDiPuntaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempoMedioGiornalieroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classificheToolStripMenuItem,
            this.toolStripMenuItem1,
            this.statisticheProduzioniToolStripMenuItem,
            this.statisticheEconomicheToolStripMenuItem,
            this.visioniRealTimeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totaleAccountToolStripMenuItem,
            this.orarioDiPuntaToolStripMenuItem,
            this.tempoMedioGiornalieroToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 20);
            this.toolStripMenuItem1.Text = "Statistiche Utenti";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // classificheToolStripMenuItem
            // 
            this.classificheToolStripMenuItem.Name = "classificheToolStripMenuItem";
            this.classificheToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.classificheToolStripMenuItem.Text = "Classifiche";
            this.classificheToolStripMenuItem.Click += new System.EventHandler(this.classificheToolStripMenuItem_Click);
            // 
            // statisticheProduzioniToolStripMenuItem
            // 
            this.statisticheProduzioniToolStripMenuItem.Name = "statisticheProduzioniToolStripMenuItem";
            this.statisticheProduzioniToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.statisticheProduzioniToolStripMenuItem.Text = "Statistiche produzioni";
            this.statisticheProduzioniToolStripMenuItem.Click += new System.EventHandler(this.statisticheProduzioniToolStripMenuItem_Click);
            // 
            // statisticheEconomicheToolStripMenuItem
            // 
            this.statisticheEconomicheToolStripMenuItem.Name = "statisticheEconomicheToolStripMenuItem";
            this.statisticheEconomicheToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.statisticheEconomicheToolStripMenuItem.Text = "Statistiche Economiche";
            this.statisticheEconomicheToolStripMenuItem.Click += new System.EventHandler(this.statisticheEconomicheToolStripMenuItem_Click);
            // 
            // visioniRealTimeToolStripMenuItem
            // 
            this.visioniRealTimeToolStripMenuItem.Name = "visioniRealTimeToolStripMenuItem";
            this.visioniRealTimeToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.visioniRealTimeToolStripMenuItem.Text = "Visioni real time";
            this.visioniRealTimeToolStripMenuItem.Click += new System.EventHandler(this.visioniRealTimeToolStripMenuItem_Click);
            // 
            // totaleAccountToolStripMenuItem
            // 
            this.totaleAccountToolStripMenuItem.Name = "totaleAccountToolStripMenuItem";
            this.totaleAccountToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.totaleAccountToolStripMenuItem.Text = "Totale account";
            // 
            // orarioDiPuntaToolStripMenuItem
            // 
            this.orarioDiPuntaToolStripMenuItem.Name = "orarioDiPuntaToolStripMenuItem";
            this.orarioDiPuntaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.orarioDiPuntaToolStripMenuItem.Text = "Orario di punta";
            // 
            // tempoMedioGiornalieroToolStripMenuItem
            // 
            this.tempoMedioGiornalieroToolStripMenuItem.Name = "tempoMedioGiornalieroToolStripMenuItem";
            this.tempoMedioGiornalieroToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.tempoMedioGiornalieroToolStripMenuItem.Text = "Tempo medio giornaliero";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 375);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Streaming Video";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classificheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem totaleAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orarioDiPuntaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempoMedioGiornalieroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticheProduzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticheEconomicheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visioniRealTimeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

