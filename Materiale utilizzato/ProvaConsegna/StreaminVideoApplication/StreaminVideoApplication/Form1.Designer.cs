namespace StreaminVideoApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filmButton = new System.Windows.Forms.Button();
            this.serieButton = new System.Windows.Forms.Button();
            this.utentiButton = new System.Windows.Forms.Button();
            this.statisticheButton = new System.Windows.Forms.Button();
            this.classificheButon = new System.Windows.Forms.Button();
            this.visioniButton = new System.Windows.Forms.Button();
            this.inserimentoButton = new System.Windows.Forms.Button();
            this.eliminaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // filmButton
            // 
            resources.ApplyResources(this.filmButton, "filmButton");
            this.filmButton.Name = "filmButton";
            this.filmButton.UseVisualStyleBackColor = true;
            this.filmButton.Click += new System.EventHandler(this.filmButton_Click);
            // 
            // serieButton
            // 
            resources.ApplyResources(this.serieButton, "serieButton");
            this.serieButton.Name = "serieButton";
            this.serieButton.UseVisualStyleBackColor = true;
            this.serieButton.Click += new System.EventHandler(this.serieButton_Click);
            // 
            // utentiButton
            // 
            resources.ApplyResources(this.utentiButton, "utentiButton");
            this.utentiButton.Name = "utentiButton";
            this.utentiButton.UseVisualStyleBackColor = true;
            this.utentiButton.Click += new System.EventHandler(this.utentiButton_Click);
            // 
            // statisticheButton
            // 
            resources.ApplyResources(this.statisticheButton, "statisticheButton");
            this.statisticheButton.Name = "statisticheButton";
            this.statisticheButton.UseVisualStyleBackColor = true;
            this.statisticheButton.Click += new System.EventHandler(this.statisticheButton_Click);
            // 
            // classificheButon
            // 
            resources.ApplyResources(this.classificheButon, "classificheButon");
            this.classificheButon.Name = "classificheButon";
            this.classificheButon.UseVisualStyleBackColor = true;
            this.classificheButon.Click += new System.EventHandler(this.classificheButon_Click);
            // 
            // visioniButton
            // 
            resources.ApplyResources(this.visioniButton, "visioniButton");
            this.visioniButton.Name = "visioniButton";
            this.visioniButton.UseVisualStyleBackColor = true;
            this.visioniButton.Click += new System.EventHandler(this.visioniButton_Click);
            // 
            // inserimentoButton
            // 
            resources.ApplyResources(this.inserimentoButton, "inserimentoButton");
            this.inserimentoButton.Name = "inserimentoButton";
            this.inserimentoButton.UseVisualStyleBackColor = true;
            this.inserimentoButton.Click += new System.EventHandler(this.inserimentoButton_Click);
            // 
            // eliminaButton
            // 
            resources.ApplyResources(this.eliminaButton, "eliminaButton");
            this.eliminaButton.Name = "eliminaButton";
            this.eliminaButton.UseVisualStyleBackColor = true;
            this.eliminaButton.Click += new System.EventHandler(this.eliminaButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eliminaButton);
            this.Controls.Add(this.inserimentoButton);
            this.Controls.Add(this.visioniButton);
            this.Controls.Add(this.classificheButon);
            this.Controls.Add(this.statisticheButton);
            this.Controls.Add(this.utentiButton);
            this.Controls.Add(this.serieButton);
            this.Controls.Add(this.filmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filmButton;
        private System.Windows.Forms.Button serieButton;
        private System.Windows.Forms.Button utentiButton;
        private System.Windows.Forms.Button statisticheButton;
        private System.Windows.Forms.Button classificheButon;
        private System.Windows.Forms.Button visioniButton;
        private System.Windows.Forms.Button inserimentoButton;
        private System.Windows.Forms.Button eliminaButton;
    }
}

