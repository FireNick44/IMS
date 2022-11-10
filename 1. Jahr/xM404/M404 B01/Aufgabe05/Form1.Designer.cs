namespace Aufgabe05
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tb1 = new System.Windows.Forms.TextBox();
      this.tb2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tb3 = new System.Windows.Forms.TextBox();
      this.button_plus = new System.Windows.Forms.Button();
      this.button_minus = new System.Windows.Forms.Button();
      this.button_mal = new System.Windows.Forms.Button();
      this.button_div = new System.Windows.Forms.Button();
      this.button_mod = new System.Windows.Forms.Button();
      this.button_exit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Zahl 1:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Zahl 2:";
      // 
      // tb1
      // 
      this.tb1.Location = new System.Drawing.Point(75, 13);
      this.tb1.Name = "tb1";
      this.tb1.Size = new System.Drawing.Size(100, 20);
      this.tb1.TabIndex = 2;
      // 
      // tb2
      // 
      this.tb2.Location = new System.Drawing.Point(75, 40);
      this.tb2.Name = "tb2";
      this.tb2.Size = new System.Drawing.Size(100, 20);
      this.tb2.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 90);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Ergebnis:";
      // 
      // tb3
      // 
      this.tb3.Location = new System.Drawing.Point(75, 87);
      this.tb3.Name = "tb3";
      this.tb3.ReadOnly = true;
      this.tb3.Size = new System.Drawing.Size(100, 20);
      this.tb3.TabIndex = 5;
      this.tb3.TabStop = false;
      this.tb3.TextChanged += new System.EventHandler(this.tb3_TextChanged);
      // 
      // button_plus
      // 
      this.button_plus.Location = new System.Drawing.Point(209, 12);
      this.button_plus.Name = "button_plus";
      this.button_plus.Size = new System.Drawing.Size(38, 33);
      this.button_plus.TabIndex = 6;
      this.button_plus.Text = "+";
      this.button_plus.UseVisualStyleBackColor = true;
      this.button_plus.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_minus
      // 
      this.button_minus.Location = new System.Drawing.Point(254, 12);
      this.button_minus.Name = "button_minus";
      this.button_minus.Size = new System.Drawing.Size(38, 33);
      this.button_minus.TabIndex = 7;
      this.button_minus.Text = "-";
      this.button_minus.UseVisualStyleBackColor = true;
      this.button_minus.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_mal
      // 
      this.button_mal.Location = new System.Drawing.Point(210, 51);
      this.button_mal.Name = "button_mal";
      this.button_mal.Size = new System.Drawing.Size(38, 33);
      this.button_mal.TabIndex = 8;
      this.button_mal.Text = " x";
      this.button_mal.UseVisualStyleBackColor = true;
      this.button_mal.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_div
      // 
      this.button_div.Location = new System.Drawing.Point(254, 51);
      this.button_div.Name = "button_div";
      this.button_div.Size = new System.Drawing.Size(38, 33);
      this.button_div.TabIndex = 9;
      this.button_div.Text = " /";
      this.button_div.UseVisualStyleBackColor = true;
      this.button_div.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_mod
      // 
      this.button_mod.Location = new System.Drawing.Point(210, 90);
      this.button_mod.Name = "button_mod";
      this.button_mod.Size = new System.Drawing.Size(82, 33);
      this.button_mod.TabIndex = 10;
      this.button_mod.Text = " Mod";
      this.button_mod.UseVisualStyleBackColor = true;
      this.button_mod.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_exit
      // 
      this.button_exit.Location = new System.Drawing.Point(12, 138);
      this.button_exit.Name = "button_exit";
      this.button_exit.Size = new System.Drawing.Size(280, 33);
      this.button_exit.TabIndex = 11;
      this.button_exit.Text = "EXIT LIFE";
      this.button_exit.UseVisualStyleBackColor = true;
      this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(307, 181);
      this.Controls.Add(this.button_exit);
      this.Controls.Add(this.button_mod);
      this.Controls.Add(this.button_div);
      this.Controls.Add(this.button_mal);
      this.Controls.Add(this.button_minus);
      this.Controls.Add(this.button_plus);
      this.Controls.Add(this.tb3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tb2);
      this.Controls.Add(this.tb1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tb1;
    private System.Windows.Forms.TextBox tb2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tb3;
    private System.Windows.Forms.Button button_plus;
    private System.Windows.Forms.Button button_minus;
    private System.Windows.Forms.Button button_mal;
    private System.Windows.Forms.Button button_div;
    private System.Windows.Forms.Button button_mod;
    private System.Windows.Forms.Button button_exit;
  }
}

