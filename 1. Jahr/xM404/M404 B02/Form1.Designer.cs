namespace M404_B02
{
  partial class Beispiel1
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
      this.btnAusgeben = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnAusgeben
      // 
      this.btnAusgeben.Location = new System.Drawing.Point(72, 65);
      this.btnAusgeben.Name = "btnAusgeben";
      this.btnAusgeben.Size = new System.Drawing.Size(120, 23);
      this.btnAusgeben.TabIndex = 0;
      this.btnAusgeben.Text = "Tag ausgeben";
      this.btnAusgeben.UseVisualStyleBackColor = true;
      this.btnAusgeben.Click += new System.EventHandler(this.btnAusgeben_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(72, 104);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(120, 20);
      this.textBox1.TabIndex = 1;
      // 
      // Beispiel1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(276, 216);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btnAusgeben);
      this.Name = "Beispiel1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAusgeben;
    private System.Windows.Forms.TextBox textBox1;
  }
}

