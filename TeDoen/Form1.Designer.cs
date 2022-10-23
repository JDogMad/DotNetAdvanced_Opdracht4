namespace TeDoen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtInformatie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTijd = new System.Windows.Forms.CheckBox();
            this.txtTijd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTaakToevoegen = new System.Windows.Forms.Button();
            this.btnVolgendeTaak = new System.Windows.Forms.Button();
            this.btnTaakIsAfgewerkt = new System.Windows.Forms.Button();
            this.btnZetAchteraan = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnDelen = new System.Windows.Forms.Button();
            this.btnFunc1 = new System.Windows.Forms.Button();
            this.btnFunc2 = new System.Windows.Forms.Button();
            this.btnFunc3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Te doen object ";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(52, 87);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(125, 27);
            this.txtTitel.TabIndex = 1;
            // 
            // txtInformatie
            // 
            this.txtInformatie.Location = new System.Drawing.Point(52, 150);
            this.txtInformatie.Name = "txtInformatie";
            this.txtInformatie.Size = new System.Drawing.Size(125, 27);
            this.txtInformatie.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Informatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tijd";
            // 
            // cbTijd
            // 
            this.cbTijd.AutoSize = true;
            this.cbTijd.Checked = true;
            this.cbTijd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTijd.Location = new System.Drawing.Point(52, 213);
            this.cbTijd.Name = "cbTijd";
            this.cbTijd.Size = new System.Drawing.Size(152, 24);
            this.cbTijd.TabIndex = 7;
            this.cbTijd.Text = "tijdstip toevoegen";
            this.cbTijd.UseVisualStyleBackColor = true;
            this.cbTijd.CheckedChanged += new System.EventHandler(this.cbTijd_CheckedChanged);
            // 
            // txtTijd
            // 
            this.txtTijd.Location = new System.Drawing.Point(52, 243);
            this.txtTijd.Name = "txtTijd";
            this.txtTijd.Size = new System.Drawing.Size(125, 27);
            this.txtTijd.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 9;
            // 
            // btnTaakToevoegen
            // 
            this.btnTaakToevoegen.Location = new System.Drawing.Point(305, 298);
            this.btnTaakToevoegen.Name = "btnTaakToevoegen";
            this.btnTaakToevoegen.Size = new System.Drawing.Size(152, 29);
            this.btnTaakToevoegen.TabIndex = 10;
            this.btnTaakToevoegen.Text = "Taak toevoegen ";
            this.btnTaakToevoegen.UseVisualStyleBackColor = true;
            this.btnTaakToevoegen.Click += new System.EventHandler(this.btnTaakToevoegen_Click);
            // 
            // btnVolgendeTaak
            // 
            this.btnVolgendeTaak.Location = new System.Drawing.Point(52, 298);
            this.btnVolgendeTaak.Name = "btnVolgendeTaak";
            this.btnVolgendeTaak.Size = new System.Drawing.Size(152, 29);
            this.btnVolgendeTaak.TabIndex = 11;
            this.btnVolgendeTaak.Text = "Volgende taak ";
            this.btnVolgendeTaak.UseVisualStyleBackColor = true;
            this.btnVolgendeTaak.Click += new System.EventHandler(this.btnVolgendeTaak_Click);
            // 
            // btnTaakIsAfgewerkt
            // 
            this.btnTaakIsAfgewerkt.Location = new System.Drawing.Point(305, 344);
            this.btnTaakIsAfgewerkt.Name = "btnTaakIsAfgewerkt";
            this.btnTaakIsAfgewerkt.Size = new System.Drawing.Size(152, 29);
            this.btnTaakIsAfgewerkt.TabIndex = 12;
            this.btnTaakIsAfgewerkt.Text = "Taak is afgewerkt";
            this.btnTaakIsAfgewerkt.UseVisualStyleBackColor = true;
            this.btnTaakIsAfgewerkt.Click += new System.EventHandler(this.btnTaakIsAfgewerkt_Click);
            // 
            // btnZetAchteraan
            // 
            this.btnZetAchteraan.Location = new System.Drawing.Point(52, 344);
            this.btnZetAchteraan.Name = "btnZetAchteraan";
            this.btnZetAchteraan.Size = new System.Drawing.Size(152, 29);
            this.btnZetAchteraan.TabIndex = 13;
            this.btnZetAchteraan.Text = "Zet achteraan";
            this.btnZetAchteraan.UseVisualStyleBackColor = true;
            this.btnZetAchteraan.Click += new System.EventHandler(this.btnZetAchteraan_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 530);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(445, 179);
            this.txtOutput.TabIndex = 14;
            // 
            // btnDelen
            // 
            this.btnDelen.Location = new System.Drawing.Point(305, 398);
            this.btnDelen.Name = "btnDelen";
            this.btnDelen.Size = new System.Drawing.Size(152, 29);
            this.btnDelen.TabIndex = 15;
            this.btnDelen.Text = "Taak delen";
            this.btnDelen.UseVisualStyleBackColor = true;
            this.btnDelen.Click += new System.EventHandler(this.btnDelen_Click);
            // 
            // btnFunc1
            // 
            this.btnFunc1.Location = new System.Drawing.Point(12, 482);
            this.btnFunc1.Name = "btnFunc1";
            this.btnFunc1.Size = new System.Drawing.Size(127, 29);
            this.btnFunc1.TabIndex = 16;
            this.btnFunc1.Text = "Func 1";
            this.btnFunc1.UseVisualStyleBackColor = true;
            this.btnFunc1.Click += new System.EventHandler(this.ClickOpDeJuisteButton);
            // 
            // btnFunc2
            // 
            this.btnFunc2.Location = new System.Drawing.Point(172, 482);
            this.btnFunc2.Name = "btnFunc2";
            this.btnFunc2.Size = new System.Drawing.Size(127, 29);
            this.btnFunc2.TabIndex = 17;
            this.btnFunc2.Text = "Func 2";
            this.btnFunc2.UseVisualStyleBackColor = true;
            this.btnFunc2.Click += new System.EventHandler(this.ClickOpDeJuisteButton);
            // 
            // btnFunc3
            // 
            this.btnFunc3.Location = new System.Drawing.Point(330, 482);
            this.btnFunc3.Name = "btnFunc3";
            this.btnFunc3.Size = new System.Drawing.Size(127, 29);
            this.btnFunc3.TabIndex = 18;
            this.btnFunc3.Text = "Func 3";
            this.btnFunc3.UseVisualStyleBackColor = true;
            this.btnFunc3.Click += new System.EventHandler(this.ClickOpDeJuisteButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 721);
            this.Controls.Add(this.btnFunc3);
            this.Controls.Add(this.btnFunc2);
            this.Controls.Add(this.btnFunc1);
            this.Controls.Add(this.btnDelen);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnZetAchteraan);
            this.Controls.Add(this.btnTaakIsAfgewerkt);
            this.Controls.Add(this.btnVolgendeTaak);
            this.Controls.Add(this.btnTaakToevoegen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTijd);
            this.Controls.Add(this.cbTijd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInformatie);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTitel;
        private TextBox txtInformatie;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox cbTijd;
        private TextBox txtTijd;
        private Label label5;
        private Button btnTaakToevoegen;
        private Button btnVolgendeTaak;
        private Button btnTaakIsAfgewerkt;
        private Button btnZetAchteraan;
        private TextBox txtOutput;
        private Button btnDelen;
        private Button btnFunc1;
        private Button btnFunc2;
        private Button btnFunc3;
    }
}