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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.AutoSize = true;
            this.txtResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtResponse.Location = new System.Drawing.Point(14, 14);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(125, 18);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.Text = "Aktive Domains";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(21, 45);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(279, 20);
            this.txtPath.TabIndex = 2;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(303, 40);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(84, 22);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "durchsuchen";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lbAllDomains
            // 
            this.lbAllDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllDomains.FormattingEnabled = true;
            this.lbAllDomains.ItemHeight = 16;
            this.lbAllDomains.Location = new System.Drawing.Point(14, 37);
            this.lbAllDomains.Margin = new System.Windows.Forms.Padding(2);
            this.lbAllDomains.Name = "lbAllDomains";
            this.lbAllDomains.Size = new System.Drawing.Size(233, 308);
            this.lbAllDomains.TabIndex = 5;
            // 
            // lbActiveDomains
            // 
            this.lbActiveDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActiveDomains.FormattingEnabled = true;
            this.lbActiveDomains.ItemHeight = 16;
            this.lbActiveDomains.Location = new System.Drawing.Point(17, 38);
            this.lbActiveDomains.Margin = new System.Windows.Forms.Padding(2);
            this.lbActiveDomains.Name = "lbActiveDomains";
            this.lbActiveDomains.Size = new System.Drawing.Size(332, 308);
            this.lbActiveDomains.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alle importierten Domains";
            // 
            // lblAllDomainsCount
            // 
            this.lblAllDomainsCount.AutoSize = true;
            this.lblAllDomainsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllDomainsCount.Location = new System.Drawing.Point(12, 350);
            this.lblAllDomainsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllDomainsCount.Name = "lblAllDomainsCount";
            this.lblAllDomainsCount.Size = new System.Drawing.Size(145, 17);
            this.lblAllDomainsCount.TabIndex = 8;
            this.lblAllDomainsCount.Text = "Anzahl aller Domains:";
            // 
            // lblActiveDomainsCount
            // 
            this.lblActiveDomainsCount.AutoSize = true;
            this.lblActiveDomainsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveDomainsCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActiveDomainsCount.Location = new System.Drawing.Point(14, 351);
            this.lblActiveDomainsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveDomainsCount.Name = "lblActiveDomainsCount";
            this.lblActiveDomainsCount.Size = new System.Drawing.Size(194, 17);
            this.lblActiveDomainsCount.TabIndex = 9;
            this.lblActiveDomainsCount.Text = "Anzahl aller aktiven Domains:";
            // 
            // pbFortschritt
            // 
            this.pbFortschritt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbFortschritt.Location = new System.Drawing.Point(15, 113);
            this.pbFortschritt.Margin = new System.Windows.Forms.Padding(2);
            this.pbFortschritt.Name = "pbFortschritt";
            this.pbFortschritt.RightToLeftLayout = true;
            this.pbFortschritt.Size = new System.Drawing.Size(1000, 24);
            this.pbFortschritt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bitte die zu importierende Datei auswählen (CSV)";
            // 
            // btnCheckDomains
            // 
            this.btnCheckDomains.Enabled = false;
            this.btnCheckDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDomains.Location = new System.Drawing.Point(16, 82);
            this.btnCheckDomains.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckDomains.Name = "btnCheckDomains";
            this.btnCheckDomains.Size = new System.Drawing.Size(161, 27);
            this.btnCheckDomains.TabIndex = 12;
            this.btnCheckDomains.Text = "Prüfen der Domains";
            this.btnCheckDomains.UseVisualStyleBackColor = true;
            this.btnCheckDomains.Click += new System.EventHandler(this.btnCheckDomains_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(695, 553);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 27);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Formular Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(865, 553);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 27);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInactiveDomainsCount
            // 
            this.lblInactiveDomainsCount.AutoSize = true;
            this.lblInactiveDomainsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactiveDomainsCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInactiveDomainsCount.Location = new System.Drawing.Point(359, 351);
            this.lblInactiveDomainsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInactiveDomainsCount.Name = "lblInactiveDomainsCount";
            this.lblInactiveDomainsCount.Size = new System.Drawing.Size(205, 17);
            this.lblInactiveDomainsCount.TabIndex = 17;
            this.lblInactiveDomainsCount.Text = "Anzahl aller inaktiven Domains:";
            // 
            // lbInactiveDomains
            // 
            this.lbInactiveDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInactiveDomains.FormattingEnabled = true;
            this.lbInactiveDomains.ItemHeight = 16;
            this.lbInactiveDomains.Location = new System.Drawing.Point(362, 38);
            this.lbInactiveDomains.Margin = new System.Windows.Forms.Padding(2);
            this.lbInactiveDomains.Name = "lbInactiveDomains";
            this.lbInactiveDomains.Size = new System.Drawing.Size(332, 308);
            this.lbInactiveDomains.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(359, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Inaktive Domains";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = ">>";
            // 
            // lblPercProgress
            // 
            this.lblPercProgress.AutoSize = true;
            this.lblPercProgress.BackColor = System.Drawing.SystemColors.Control;
            this.lblPercProgress.Location = new System.Drawing.Point(506, 89);
            this.lblPercProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercProgress.Name = "lblPercProgress";
            this.lblPercProgress.Size = new System.Drawing.Size(43, 13);
            this.lblPercProgress.TabIndex = 19;
            this.lblPercProgress.Text = "0 von 0";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(540, 553);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(129, 27);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Export als CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(391, 40);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(60, 22);
            this.btnImport.TabIndex = 21;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbAllDomains);
            this.panel1.Controls.Add(this.lblAllDomainsCount);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(15, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 385);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtResponse);
            this.panel2.Controls.Add(this.lbActiveDomains);
            this.panel2.Controls.Add(this.lblActiveDomainsCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbInactiveDomains);
            this.panel2.Controls.Add(this.lblInactiveDomainsCount);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(306, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 385);
            this.panel2.TabIndex = 23;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblPercProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheckDomains);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbFortschritt);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtPath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Domain Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtResponse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenFile;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

