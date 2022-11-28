namespace M404_Beispiel_01
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
      this.tbxEingabe = new System.Windows.Forms.TextBox();
      this.btnVerdopple = new System.Windows.Forms.Button();
      this.tbxAusgabe = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Zahl eingeben";
      // 
      // tbxEingabe
      // 
      this.tbxEingabe.Location = new System.Drawing.Point(33, 58);
      this.tbxEingabe.Name = "tbxEingabe";
      this.tbxEingabe.Size = new System.Drawing.Size(100, 20);
      this.tbxEingabe.TabIndex = 1;
      // 
      // btnVerdopple
      // 
      this.btnVerdopple.Location = new System.Drawing.Point(139, 55);
      this.btnVerdopple.Name = "btnVerdopple";
      this.btnVerdopple.Size = new System.Drawing.Size(75, 23);
      this.btnVerdopple.TabIndex = 2;
      this.btnVerdopple.Text = "verdoppeln";
      this.btnVerdopple.UseVisualStyleBackColor = true;
      this.btnVerdopple.Click += new System.EventHandler(this.VerdoppelnClick);
      // 
      // tbxAusgabe
      // 
      this.tbxAusgabe.Location = new System.Drawing.Point(230, 57);
      this.tbxAusgabe.Name = "tbxAusgabe";
      this.tbxAusgabe.Size = new System.Drawing.Size(100, 20);
      this.tbxAusgabe.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(230, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Ergebnis";
      //Gelöscht
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 164);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbxAusgabe);
      this.Controls.Add(this.btnVerdopple);
      this.Controls.Add(this.tbxEingabe);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Verdoppeln";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbxEingabe;
    private System.Windows.Forms.Button btnVerdopple;
    private System.Windows.Forms.TextBox tbxAusgabe;
    private System.Windows.Forms.Label label2;
  }
}

