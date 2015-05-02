namespace GetActicePages
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResponse = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbAllDomains = new System.Windows.Forms.ListBox();
            this.lbActiveDomains = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAllDomainsCount = new System.Windows.Forms.Label();
            this.lblActiveDomainsCount = new System.Windows.Forms.Label();
            this.pbFortschritt = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckDomains = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInactiveDomainsCount = new System.Windows.Forms.Label();
            this.lbInactiveDomains = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPercProgress = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.AutoSize = true;
            this.txtResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResponse.Location = new System.Drawing.Point(457, 251);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(298, 26);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.Text = "Alle noch Aktiven Domains";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(50, 63);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(416, 26);
            this.txtPath.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "durchsuchen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lbAllDomains
            // 
            this.lbAllDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllDomains.FormattingEnabled = true;
            this.lbAllDomains.ItemHeight = 25;
            this.lbAllDomains.Location = new System.Drawing.Point(51, 288);
            this.lbAllDomains.Name = "lbAllDomains";
            this.lbAllDomains.Size = new System.Drawing.Size(348, 479);
            this.lbAllDomains.TabIndex = 5;
            // 
            // lbActiveDomains
            // 
            this.lbActiveDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActiveDomains.FormattingEnabled = true;
            this.lbActiveDomains.ItemHeight = 25;
            this.lbActiveDomains.Location = new System.Drawing.Point(462, 288);
            this.lbActiveDomains.Name = "lbActiveDomains";
            this.lbActiveDomains.Size = new System.Drawing.Size(496, 479);
            this.lbActiveDomains.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(47, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Domains aus CSV Datei";
            // 
            // lblAllDomainsCount
            // 
            this.lblAllDomainsCount.AutoSize = true;
            this.lblAllDomainsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllDomainsCount.Location = new System.Drawing.Point(48, 770);
            this.lblAllDomainsCount.Name = "lblAllDomainsCount";
            this.lblAllDomainsCount.Size = new System.Drawing.Size(202, 25);
            this.lblAllDomainsCount.TabIndex = 8;
            this.lblAllDomainsCount.Text = "Anzahl aller Domains:";
            // 
            // lblActiveDomainsCount
            // 
            this.lblActiveDomainsCount.AutoSize = true;
            this.lblActiveDomainsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveDomainsCount.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblActiveDomainsCount.Location = new System.Drawing.Point(457, 770);
            this.lblActiveDomainsCount.Name = "lblActiveDomainsCount";
            this.lblActiveDomainsCount.Size = new System.Drawing.Size(269, 25);
            this.lblActiveDomainsCount.TabIndex = 9;
            this.lblActiveDomainsCount.Text = "Anzahl aller aktiven Domains:";
            // 
            // pbFortschritt
            // 
            this.pbFortschritt.Location = new System.Drawing.Point(49, 163);
            this.pbFortschritt.Name = "pbFortschritt";
            this.pbFortschritt.Size = new System.Drawing.Size(1427, 37);
            this.pbFortschritt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(48, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Import der zu prüfenden Domains (CSV-Datei)";
            // 
            // btnCheckDomains
            // 
            this.btnCheckDomains.Enabled = false;
            this.btnCheckDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDomains.Location = new System.Drawing.Point(51, 116);
            this.btnCheckDomains.Name = "btnCheckDomains";
            this.btnCheckDomains.Size = new System.Drawing.Size(241, 41);
            this.btnCheckDomains.TabIndex = 12;
            this.btnCheckDomains.Text = "Prüfen der Domains";
            this.btnCheckDomains.UseVisualStyleBackColor = true;
            this.btnCheckDomains.Click += new System.EventHandler(this.btnCheckDomains_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(996, 851);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(225, 42);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Formular Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1251, 851);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(225, 42);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInactiveDomainsCount
            // 
            this.lblInactiveDomainsCount.AutoSize = true;
            this.lblInactiveDomainsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactiveDomainsCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblInactiveDomainsCount.Location = new System.Drawing.Point(975, 770);
            this.lblInactiveDomainsCount.Name = "lblInactiveDomainsCount";
            this.lblInactiveDomainsCount.Size = new System.Drawing.Size(284, 25);
            this.lblInactiveDomainsCount.TabIndex = 17;
            this.lblInactiveDomainsCount.Text = "Anzahl aller inaktiven Domains:";
            // 
            // lbInactiveDomains
            // 
            this.lbInactiveDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInactiveDomains.FormattingEnabled = true;
            this.lbInactiveDomains.ItemHeight = 25;
            this.lbInactiveDomains.Location = new System.Drawing.Point(980, 288);
            this.lbInactiveDomains.Name = "lbInactiveDomains";
            this.lbInactiveDomains.Size = new System.Drawing.Size(496, 479);
            this.lbInactiveDomains.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(975, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Alle inaktive Domains";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = ">>";
            // 
            // lblPercProgress
            // 
            this.lblPercProgress.AutoSize = true;
            this.lblPercProgress.BackColor = System.Drawing.SystemColors.Control;
            this.lblPercProgress.Location = new System.Drawing.Point(712, 128);
            this.lblPercProgress.Name = "lblPercProgress";
            this.lblPercProgress.Size = new System.Drawing.Size(60, 20);
            this.lblPercProgress.TabIndex = 19;
            this.lblPercProgress.Text = "0 von 0";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(764, 851);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(194, 41);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Export als CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(622, 55);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(194, 34);
            this.btnImport.TabIndex = 21;
            this.btnImport.Text = "Import Domains";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 905);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblPercProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInactiveDomainsCount);
            this.Controls.Add(this.lbInactiveDomains);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheckDomains);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbFortschritt);
            this.Controls.Add(this.lblActiveDomainsCount);
            this.Controls.Add(this.lblAllDomainsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbActiveDomains);
            this.Controls.Add(this.lbAllDomains);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtResponse);
            this.Name = "MainForm";
            this.Text = "Get Active Pages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtResponse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbAllDomains;
        private System.Windows.Forms.ListBox lbActiveDomains;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAllDomainsCount;
        private System.Windows.Forms.Label lblActiveDomainsCount;
        private System.Windows.Forms.ProgressBar pbFortschritt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckDomains;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInactiveDomainsCount;
        private System.Windows.Forms.ListBox lbInactiveDomains;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPercProgress;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}

