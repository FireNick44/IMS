namespace IPT2__B03
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
      this.btnSpeichern = new System.Windows.Forms.Button();
      this.btnVerwerfen = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnSpeichern
      // 
      this.btnSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSpeichern.Location = new System.Drawing.Point(35, 29);
      this.btnSpeichern.Name = "btnSpeichern";
      this.btnSpeichern.Size = new System.Drawing.Size(216, 48);
      this.btnSpeichern.TabIndex = 0;
      this.btnSpeichern.Text = "Änderungen speichern";
      this.btnSpeichern.UseVisualStyleBackColor = true;
      this.btnSpeichern.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnVerwerfen
      // 
      this.btnVerwerfen.Location = new System.Drawing.Point(265, 29);
      this.btnVerwerfen.Name = "btnVerwerfen";
      this.btnVerwerfen.Size = new System.Drawing.Size(216, 48);
      this.btnVerwerfen.TabIndex = 1;
      this.btnVerwerfen.Text = "Änderungen verwerfen";
      this.btnVerwerfen.UseVisualStyleBackColor = true;
      this.btnVerwerfen.Click += new System.EventHandler(this.btnVerwerfen_Click);
      // 
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(0, 0);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(232, 404);
      this.listBox1.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnVerwerfen);
      this.panel1.Controls.Add(this.btnSpeichern);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(232, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(534, 111);
      this.panel1.TabIndex = 3;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(125, 28);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(356, 20);
      this.textBox1.TabIndex = 4;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.comboBox1);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.textBox6);
      this.panel2.Controls.Add(this.textBox4);
      this.panel2.Controls.Add(this.textBox3);
      this.panel2.Controls.Add(this.textBox2);
      this.panel2.Controls.Add(this.textBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(232, 111);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(534, 293);
      this.panel2.TabIndex = 5;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(125, 60);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(356, 20);
      this.textBox2.TabIndex = 5;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(125, 95);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(356, 20);
      this.textBox3.TabIndex = 6;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(125, 127);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(107, 20);
      this.textBox4.TabIndex = 7;
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(282, 127);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(199, 20);
      this.textBox6.TabIndex = 9;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(32, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 16);
      this.label1.TabIndex = 10;
      this.label1.Text = "Vorname:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(32, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 16);
      this.label2.TabIndex = 11;
      this.label2.Text = "Nachname:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(32, 96);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 16);
      this.label3.TabIndex = 12;
      this.label3.Text = "Strasse:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(32, 128);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 16);
      this.label4.TabIndex = 13;
      this.label4.Text = "Plz:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(248, 128);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(28, 16);
      this.label5.TabIndex = 14;
      this.label5.Text = "Ort:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(32, 161);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(35, 16);
      this.label6.TabIndex = 15;
      this.label6.Text = "Typ:";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(125, 161);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(356, 21);
      this.comboBox1.TabIndex = 16;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(766, 404);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSpeichern;
    private System.Windows.Forms.Button btnVerwerfen;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox2;
  }
}

