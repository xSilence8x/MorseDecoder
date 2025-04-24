namespace MorseDecoder
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textInputLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEncode = new System.Windows.Forms.TabPage();
            this.textOutputLabel = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.tabPageDecode = new System.Windows.Forms.TabPage();
            this.labelWarningDecode = new System.Windows.Forms.Label();
            this.btnConvertDe = new System.Windows.Forms.Button();
            this.textOutputLabelDe = new System.Windows.Forms.Label();
            this.textOutputDe = new System.Windows.Forms.TextBox();
            this.textInputDe = new System.Windows.Forms.TextBox();
            this.textInputLabelDe = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEncode.SuspendLayout();
            this.tabPageDecode.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInputLabel
            // 
            this.textInputLabel.AutoSize = true;
            this.textInputLabel.Location = new System.Drawing.Point(79, 21);
            this.textInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textInputLabel.Name = "textInputLabel";
            this.textInputLabel.Size = new System.Drawing.Size(180, 23);
            this.textInputLabel.TabIndex = 2;
            this.textInputLabel.Text = "Vložte text k překladu:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.fileToolStripMenuItem.Text = "Soubor";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.exitToolStripMenuItem.Text = "Ukončit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(118, 27);
            this.aboutToolStripMenuItem.Text = "O programu";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEncode);
            this.tabControl1.Controls.Add(this.tabPageDecode);
            this.tabControl1.Location = new System.Drawing.Point(19, 45);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 582);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageEncode
            // 
            this.tabPageEncode.Controls.Add(this.textOutputLabel);
            this.tabPageEncode.Controls.Add(this.labelWarning);
            this.tabPageEncode.Controls.Add(this.btnStop);
            this.tabPageEncode.Controls.Add(this.btnPlay);
            this.tabPageEncode.Controls.Add(this.btnConvert);
            this.tabPageEncode.Controls.Add(this.textOutput);
            this.tabPageEncode.Controls.Add(this.textInput);
            this.tabPageEncode.Controls.Add(this.textInputLabel);
            this.tabPageEncode.Location = new System.Drawing.Point(4, 32);
            this.tabPageEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEncode.Name = "tabPageEncode";
            this.tabPageEncode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageEncode.Size = new System.Drawing.Size(956, 546);
            this.tabPageEncode.TabIndex = 0;
            this.tabPageEncode.Text = "Zakódovat";
            this.tabPageEncode.UseVisualStyleBackColor = true;
            // 
            // textOutputLabel
            // 
            this.textOutputLabel.AutoSize = true;
            this.textOutputLabel.Location = new System.Drawing.Point(79, 215);
            this.textOutputLabel.Name = "textOutputLabel";
            this.textOutputLabel.Size = new System.Drawing.Size(134, 23);
            this.textOutputLabel.TabIndex = 14;
            this.textOutputLabel.Text = "Zašifrovaný text:";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(217, 215);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(74, 23);
            this.labelWarning.TabIndex = 13;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(491, 361);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 40);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(357, 361);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(112, 40);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "Přehrát";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConvert.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(426, 165);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 40);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Zakóduj";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textOutput
            // 
            this.textOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOutput.Location = new System.Drawing.Point(79, 243);
            this.textOutput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(786, 105);
            this.textOutput.TabIndex = 9;
            // 
            // textInput
            // 
            this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInput.Location = new System.Drawing.Point(79, 49);
            this.textInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(786, 105);
            this.textInput.TabIndex = 8;
            // 
            // tabPageDecode
            // 
            this.tabPageDecode.Controls.Add(this.labelWarningDecode);
            this.tabPageDecode.Controls.Add(this.btnConvertDe);
            this.tabPageDecode.Controls.Add(this.textOutputLabelDe);
            this.tabPageDecode.Controls.Add(this.textOutputDe);
            this.tabPageDecode.Controls.Add(this.textInputDe);
            this.tabPageDecode.Controls.Add(this.textInputLabelDe);
            this.tabPageDecode.Location = new System.Drawing.Point(4, 32);
            this.tabPageDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDecode.Name = "tabPageDecode";
            this.tabPageDecode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDecode.Size = new System.Drawing.Size(956, 546);
            this.tabPageDecode.TabIndex = 1;
            this.tabPageDecode.Text = "Dekódovat";
            this.tabPageDecode.UseVisualStyleBackColor = true;
            this.tabPageDecode.Click += new System.EventHandler(this.tabPageDecode_Click);
            // 
            // labelWarningDecode
            // 
            this.labelWarningDecode.AutoSize = true;
            this.labelWarningDecode.ForeColor = System.Drawing.Color.Red;
            this.labelWarningDecode.Location = new System.Drawing.Point(217, 215);
            this.labelWarningDecode.Name = "labelWarningDecode";
            this.labelWarningDecode.Size = new System.Drawing.Size(74, 23);
            this.labelWarningDecode.TabIndex = 5;
            // 
            // btnConvertDe
            // 
            this.btnConvertDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConvertDe.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConvertDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertDe.Location = new System.Drawing.Point(426, 165);
            this.btnConvertDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvertDe.Name = "btnConvertDe";
            this.btnConvertDe.Size = new System.Drawing.Size(112, 40);
            this.btnConvertDe.TabIndex = 4;
            this.btnConvertDe.Text = "Dekóduj";
            this.btnConvertDe.UseVisualStyleBackColor = true;
            this.btnConvertDe.Click += new System.EventHandler(this.btnConvertDe_Click);
            // 
            // textOutputLabelDe
            // 
            this.textOutputLabelDe.AutoSize = true;
            this.textOutputLabelDe.Location = new System.Drawing.Point(79, 215);
            this.textOutputLabelDe.Name = "textOutputLabelDe";
            this.textOutputLabelDe.Size = new System.Drawing.Size(136, 23);
            this.textOutputLabelDe.TabIndex = 3;
            this.textOutputLabelDe.Text = "Dešifrovaný text:";
            // 
            // textOutputDe
            // 
            this.textOutputDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOutputDe.Location = new System.Drawing.Point(79, 243);
            this.textOutputDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textOutputDe.Multiline = true;
            this.textOutputDe.Name = "textOutputDe";
            this.textOutputDe.Size = new System.Drawing.Size(786, 105);
            this.textOutputDe.TabIndex = 2;
            // 
            // textInputDe
            // 
            this.textInputDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInputDe.Location = new System.Drawing.Point(79, 49);
            this.textInputDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textInputDe.Multiline = true;
            this.textInputDe.Name = "textInputDe";
            this.textInputDe.Size = new System.Drawing.Size(786, 105);
            this.textInputDe.TabIndex = 1;
            // 
            // textInputLabelDe
            // 
            this.textInputLabelDe.AutoSize = true;
            this.textInputLabelDe.Location = new System.Drawing.Point(79, 21);
            this.textInputLabelDe.Name = "textInputLabelDe";
            this.textInputLabelDe.Size = new System.Drawing.Size(180, 23);
            this.textInputLabelDe.TabIndex = 0;
            this.textInputLabelDe.Text = "Vložte text k překladu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 707);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Morseovka 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageEncode.ResumeLayout(false);
            this.tabPageEncode.PerformLayout();
            this.tabPageDecode.ResumeLayout(false);
            this.tabPageDecode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textInputLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEncode;
        private System.Windows.Forms.TabPage tabPageDecode;
        private System.Windows.Forms.Label textOutputLabel;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textInputDe;
        private System.Windows.Forms.Label textInputLabelDe;
        private System.Windows.Forms.Button btnConvertDe;
        private System.Windows.Forms.Label textOutputLabelDe;
        private System.Windows.Forms.TextBox textOutputDe;
        private System.Windows.Forms.Label labelWarningDecode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

