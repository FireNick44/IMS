namespace Aufgabe05_Kombobox
{
  partial class Form1
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.button_berechnen = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.textBox1_zahl1 = new System.Windows.Forms.TextBox();
      this.textBox3_ergebnis = new System.Windows.Forms.TextBox();
      this.textBox2_zahl2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBox = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button_berechnen);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 450);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(847, 100);
      this.panel1.TabIndex = 0;
      // 
      // button_berechnen
      // 
      this.button_berechnen.BackColor = System.Drawing.SystemColors.ControlLight;
      this.button_berechnen.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button_berechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_berechnen.Location = new System.Drawing.Point(0, 0);
      this.button_berechnen.Name = "button_berechnen";
      this.button_berechnen.Size = new System.Drawing.Size(847, 100);
      this.button_berechnen.TabIndex = 0;
      this.button_berechnen.Text = "Berechnen";
      this.button_berechnen.UseVisualStyleBackColor = false;
      this.button_berechnen.Click += new System.EventHandler(this.button_berechnen_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
      this.splitContainer1.Panel2.Controls.Add(this.label4);
      this.splitContainer1.Panel2.Controls.Add(this.comboBox);
      this.splitContainer1.Size = new System.Drawing.Size(847, 450);
      this.splitContainer1.SplitterDistance = 528;
      this.splitContainer1.TabIndex = 1;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.textBox1_zahl1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.textBox3_ergebnis, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.textBox2_zahl2, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 450);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // textBox1_zahl1
      // 
      this.textBox1_zahl1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.textBox1_zahl1.Location = new System.Drawing.Point(267, 63);
      this.textBox1_zahl1.Name = "textBox1_zahl1";
      this.textBox1_zahl1.Size = new System.Drawing.Size(258, 23);
      this.textBox1_zahl1.TabIndex = 3;
      // 
      // textBox3_ergebnis
      // 
      this.textBox3_ergebnis.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.textBox3_ergebnis.Location = new System.Drawing.Point(267, 363);
      this.textBox3_ergebnis.Name = "textBox3_ergebnis";
      this.textBox3_ergebnis.ReadOnly = true;
      this.textBox3_ergebnis.Size = new System.Drawing.Size(258, 23);
      this.textBox3_ergebnis.TabIndex = 5;
      // 
      // textBox2_zahl2
      // 
      this.textBox2_zahl2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.textBox2_zahl2.Location = new System.Drawing.Point(267, 213);
      this.textBox2_zahl2.Name = "textBox2_zahl2";
      this.textBox2_zahl2.Size = new System.Drawing.Size(258, 23);
      this.textBox2_zahl2.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(3, 150);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(258, 150);
      this.label2.TabIndex = 1;
      this.label2.Text = "Zahl 2:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 300);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(258, 150);
      this.label3.TabIndex = 6;
      this.label3.Text = "Ergebnis:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(258, 150);
      this.label1.TabIndex = 0;
      this.label1.Text = "Zahl 1:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(13, 130);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(109, 17);
      this.label4.TabIndex = 1;
      this.label4.Text = "Grundrechenart";
      // 
      // comboBox
      // 
      this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox.FormattingEnabled = true;
      this.comboBox.Items.AddRange(new object[] {
            "Plus",
            "Minus",
            "Geteilt",
            "Mal",
            "Modulo"});
      this.comboBox.Location = new System.Drawing.Point(16, 150);
      this.comboBox.Name = "comboBox";
      this.comboBox.Size = new System.Drawing.Size(287, 21);
      this.comboBox.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ClientSize = new System.Drawing.Size(847, 550);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button_berechnen;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1_zahl1;
    private System.Windows.Forms.TextBox textBox2_zahl2;
    private System.Windows.Forms.TextBox textBox3_ergebnis;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBox;
    private System.Windows.Forms.Label label3;
  }
}

