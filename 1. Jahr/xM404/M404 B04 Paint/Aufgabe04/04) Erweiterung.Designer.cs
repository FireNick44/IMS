namespace Aufgabe04
{
  partial class Erweiterung
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
      this.lblFarbe = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblFarbe
      // 
      this.lblFarbe.AutoSize = true;
      this.lblFarbe.Location = new System.Drawing.Point(72, 69);
      this.lblFarbe.Name = "lblFarbe";
      this.lblFarbe.Size = new System.Drawing.Size(49, 13);
      this.lblFarbe.TabIndex = 0;
      this.lblFarbe.Text = "--------------";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(16, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(167, 51);
      this.button1.TabIndex = 1;
      this.button1.Text = "Farbe";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.OnFarbeClick);
      this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Orange;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.lblFarbe);
      this.panel1.Location = new System.Drawing.Point(588, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 100);
      this.panel1.TabIndex = 2;
      // 
      // Erweiterung
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel1);
      this.Name = "Erweiterung";
      this.Text = "Form1";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblFarbe;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel1;
  }
}

