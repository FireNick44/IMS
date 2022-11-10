namespace M404_B2_Array
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.tbx_eingabe_a = new System.Windows.Forms.TextBox();
      this.tbx_eingabe_l = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.tbx_ausgabe_durch = new System.Windows.Forms.TextBox();
      this.tbx_ausgabe_min = new System.Windows.Forms.TextBox();
      this.tbx_ausgabe_max = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.btn1_add = new System.Windows.Forms.Button();
      this.btn2_delete = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.tableLayoutPanel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 102);
      this.panel1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 350);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(230, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(102, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "In Array aufnehmen:";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.listBox1);
      this.panel2.Controls.Add(this.tableLayoutPanel2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 102);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 348);
      this.panel2.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(237, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(95, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Aus Array löschen:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "label3";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(269, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(35, 13);
      this.label4.TabIndex = 1;
      this.label4.Text = "label4";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(535, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "label5";
      // 
      // tbx_eingabe_a
      // 
      this.tbx_eingabe_a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.tbx_eingabe_a.Location = new System.Drawing.Point(338, 15);
      this.tbx_eingabe_a.Name = "tbx_eingabe_a";
      this.tbx_eingabe_a.Size = new System.Drawing.Size(116, 20);
      this.tbx_eingabe_a.TabIndex = 2;
      // 
      // tbx_eingabe_l
      // 
      this.tbx_eingabe_l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.tbx_eingabe_l.Location = new System.Drawing.Point(338, 66);
      this.tbx_eingabe_l.Name = "tbx_eingabe_l";
      this.tbx_eingabe_l.Size = new System.Drawing.Size(116, 20);
      this.tbx_eingabe_l.TabIndex = 3;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 6;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.label8, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.tbx_ausgabe_durch, 5, 0);
      this.tableLayoutPanel2.Controls.Add(this.tbx_ausgabe_min, 3, 0);
      this.tableLayoutPanel2.Controls.Add(this.tbx_ausgabe_max, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 248);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 100);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(62, 43);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(68, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Maximalwert:";
      // 
      // label7
      // 
      this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(331, 43);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(65, 13);
      this.label7.TabIndex = 1;
      this.label7.Text = "Minimalwert:";
      // 
      // label8
      // 
      this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(592, 43);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(70, 13);
      this.label8.TabIndex = 2;
      this.label8.Text = "Durchschnitt:";
      // 
      // tbx_ausgabe_durch
      // 
      this.tbx_ausgabe_durch.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbx_ausgabe_durch.Location = new System.Drawing.Point(668, 40);
      this.tbx_ausgabe_durch.Name = "tbx_ausgabe_durch";
      this.tbx_ausgabe_durch.Size = new System.Drawing.Size(100, 20);
      this.tbx_ausgabe_durch.TabIndex = 3;
      // 
      // tbx_ausgabe_min
      // 
      this.tbx_ausgabe_min.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbx_ausgabe_min.Location = new System.Drawing.Point(402, 40);
      this.tbx_ausgabe_min.Name = "tbx_ausgabe_min";
      this.tbx_ausgabe_min.Size = new System.Drawing.Size(100, 20);
      this.tbx_ausgabe_min.TabIndex = 4;
      // 
      // tbx_ausgabe_max
      // 
      this.tbx_ausgabe_max.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tbx_ausgabe_max.Location = new System.Drawing.Point(136, 40);
      this.tbx_ausgabe_max.Name = "tbx_ausgabe_max";
      this.tbx_ausgabe_max.Size = new System.Drawing.Size(100, 20);
      this.tbx_ausgabe_max.TabIndex = 5;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 3;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.875F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.25F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.875F));
      this.tableLayoutPanel3.Controls.Add(this.tbx_eingabe_a, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.tbx_eingabe_l, 1, 1);
      this.tableLayoutPanel3.Controls.Add(this.btn1_add, 2, 0);
      this.tableLayoutPanel3.Controls.Add(this.btn2_delete, 2, 1);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 102);
      this.tableLayoutPanel3.TabIndex = 2;
      // 
      // btn1_add
      // 
      this.btn1_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btn1_add.Location = new System.Drawing.Point(460, 14);
      this.btn1_add.Name = "btn1_add";
      this.btn1_add.Size = new System.Drawing.Size(75, 23);
      this.btn1_add.TabIndex = 4;
      this.btn1_add.Text = "Add";
      this.btn1_add.UseVisualStyleBackColor = true;
      this.btn1_add.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btn2_delete
      // 
      this.btn2_delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btn2_delete.Location = new System.Drawing.Point(460, 65);
      this.btn2_delete.Name = "btn2_delete";
      this.btn2_delete.Size = new System.Drawing.Size(75, 23);
      this.btn2_delete.TabIndex = 5;
      this.btn2_delete.Text = "Delete";
      this.btn2_delete.UseVisualStyleBackColor = true;
      this.btn2_delete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(0, 0);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(800, 248);
      this.listBox1.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Arrays";
      this.panel1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox tbx_eingabe_l;
    private System.Windows.Forms.TextBox tbx_eingabe_a;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tbx_ausgabe_durch;
    private System.Windows.Forms.TextBox tbx_ausgabe_min;
    private System.Windows.Forms.TextBox tbx_ausgabe_max;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button btn1_add;
    private System.Windows.Forms.Button btn2_delete;
    private System.Windows.Forms.ListBox listBox1;
  }
}

