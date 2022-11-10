namespace M404_B3_Personen_Applikation
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
      this.cmbPersonen = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtVornamen = new System.Windows.Forms.TextBox();
      this.txtAlter = new System.Windows.Forms.TextBox();
      this.txtHaarfarbe = new System.Windows.Forms.TextBox();
      this.IstPersonenDetails = new System.Windows.Forms.ListBox();
      this.cmdNeuePerson = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // cmbPersonen
      // 
      this.cmbPersonen.FormattingEnabled = true;
      this.cmbPersonen.Location = new System.Drawing.Point(15, 212);
      this.cmbPersonen.Name = "cmbPersonen";
      this.cmbPersonen.Size = new System.Drawing.Size(194, 21);
      this.cmbPersonen.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 53);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "ID";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Name";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 105);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Vorname";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 131);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(28, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Alter";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(9, 157);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(54, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Haarfarbe";
      // 
      // txtID
      // 
      this.txtID.Location = new System.Drawing.Point(109, 50);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(100, 20);
      this.txtID.TabIndex = 6;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(109, 76);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(100, 20);
      this.txtName.TabIndex = 7;
      // 
      // txtVornamen
      // 
      this.txtVornamen.Location = new System.Drawing.Point(109, 102);
      this.txtVornamen.Name = "txtVornamen";
      this.txtVornamen.Size = new System.Drawing.Size(100, 20);
      this.txtVornamen.TabIndex = 8;
      // 
      // txtAlter
      // 
      this.txtAlter.Location = new System.Drawing.Point(109, 128);
      this.txtAlter.Name = "txtAlter";
      this.txtAlter.Size = new System.Drawing.Size(100, 20);
      this.txtAlter.TabIndex = 9;
      // 
      // txtHaarfarbe
      // 
      this.txtHaarfarbe.Location = new System.Drawing.Point(109, 154);
      this.txtHaarfarbe.Name = "txtHaarfarbe";
      this.txtHaarfarbe.Size = new System.Drawing.Size(100, 20);
      this.txtHaarfarbe.TabIndex = 10;
      this.txtHaarfarbe.Click += new System.EventHandler(this.txtHaarfarbe_Click);
      // 
      // IstPersonenDetails
      // 
      this.IstPersonenDetails.FormattingEnabled = true;
      this.IstPersonenDetails.Location = new System.Drawing.Point(15, 317);
      this.IstPersonenDetails.Name = "IstPersonenDetails";
      this.IstPersonenDetails.Size = new System.Drawing.Size(354, 121);
      this.IstPersonenDetails.TabIndex = 11;
      // 
      // cmdNeuePerson
      // 
      this.cmdNeuePerson.Location = new System.Drawing.Point(231, 53);
      this.cmdNeuePerson.Name = "cmdNeuePerson";
      this.cmdNeuePerson.Size = new System.Drawing.Size(138, 124);
      this.cmdNeuePerson.TabIndex = 12;
      this.cmdNeuePerson.Text = "Neues Personenobjekt intanziieren und eine Referenz des statischen Arrays darauf " +
    "setzen";
      this.cmdNeuePerson.UseVisualStyleBackColor = true;
      this.cmdNeuePerson.Click += new System.EventHandler(this.cmdNeuePerson_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(231, 210);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(138, 72);
      this.button1.TabIndex = 13;
      this.button1.Text = "Personenobjekt im Kombinationsfeld anzeigen";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.panel1.Location = new System.Drawing.Point(12, 183);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(357, 10);
      this.panel1.TabIndex = 14;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(387, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.cmdNeuePerson);
      this.Controls.Add(this.IstPersonenDetails);
      this.Controls.Add(this.txtHaarfarbe);
      this.Controls.Add(this.txtAlter);
      this.Controls.Add(this.txtVornamen);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbPersonen);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbPersonen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtVornamen;
    private System.Windows.Forms.TextBox txtAlter;
    private System.Windows.Forms.TextBox txtHaarfarbe;
    private System.Windows.Forms.ListBox IstPersonenDetails;
    private System.Windows.Forms.Button cmdNeuePerson;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel1;
  }
}

