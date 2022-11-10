namespace Aufgabe
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
      this.tbxSeiteA = new System.Windows.Forms.TextBox();
      this.tbxSeiteB = new System.Windows.Forms.TextBox();
      this.tbxAusgabeF = new System.Windows.Forms.TextBox();
      this.tbxAusgabeU = new System.Windows.Forms.TextBox();
      this.btn = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tbxSeiteA
      // 
      this.tbxSeiteA.Location = new System.Drawing.Point(12, 43);
      this.tbxSeiteA.Name = "tbxSeiteA";
      this.tbxSeiteA.Size = new System.Drawing.Size(100, 20);
      this.tbxSeiteA.TabIndex = 0;
      // 
      // tbxSeiteB
      // 
      this.tbxSeiteB.Location = new System.Drawing.Point(12, 108);
      this.tbxSeiteB.Name = "tbxSeiteB";
      this.tbxSeiteB.Size = new System.Drawing.Size(100, 20);
      this.tbxSeiteB.TabIndex = 1;
      // 
      // tbxAusgabeF
      // 
      this.tbxAusgabeF.Location = new System.Drawing.Point(354, 43);
      this.tbxAusgabeF.Name = "tbxAusgabeF";
      this.tbxAusgabeF.Size = new System.Drawing.Size(100, 20);
      this.tbxAusgabeF.TabIndex = 2;
      // 
      // tbxAusgabeU
      // 
      this.tbxAusgabeU.Location = new System.Drawing.Point(354, 108);
      this.tbxAusgabeU.Name = "tbxAusgabeU";
      this.tbxAusgabeU.Size = new System.Drawing.Size(100, 20);
      this.tbxAusgabeU.TabIndex = 3;
      // 
      // btn
      // 
      this.btn.Location = new System.Drawing.Point(150, 25);
      this.btn.Name = "btn";
      this.btn.Size = new System.Drawing.Size(169, 103);
      this.btn.TabIndex = 4;
      this.btn.Text = "Berechnen";
      this.btn.UseVisualStyleBackColor = true;
      this.btn.Click += new System.EventHandler(this.button1_Click);
      // 
      // btn2
      // 
      this.btn2.Location = new System.Drawing.Point(12, 151);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(1226, 75);
      this.btn2.TabIndex = 5;
      this.btn2.Text = "Text";
      this.btn2.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Seite A ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 89);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Seite B";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(351, 27);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Fläche";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(351, 89);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Umfang";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1250, 243);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btn);
      this.Controls.Add(this.tbxAusgabeU);
      this.Controls.Add(this.tbxAusgabeF);
      this.Controls.Add(this.tbxSeiteB);
      this.Controls.Add(this.tbxSeiteA);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbxSeiteA;
    private System.Windows.Forms.TextBox tbxSeiteB;
    private System.Windows.Forms.TextBox tbxAusgabeF;
    private System.Windows.Forms.TextBox tbxAusgabeU;
    private System.Windows.Forms.Button btn;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

