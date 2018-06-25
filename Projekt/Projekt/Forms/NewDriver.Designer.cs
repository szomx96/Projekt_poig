﻿namespace Projekt.Forms
{
    partial class NewDriver
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDriverName = new System.Windows.Forms.Label();
            this.labelDriverSurname = new System.Windows.Forms.Label();
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.textBoxDriverSurname = new System.Windows.Forms.TextBox();
            this.buttonDriverAdd = new System.Windows.Forms.Button();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxDriver.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDriverName
            // 
            this.labelDriverName.AutoSize = true;
            this.labelDriverName.Location = new System.Drawing.Point(6, 36);
            this.labelDriverName.Name = "labelDriverName";
            this.labelDriverName.Size = new System.Drawing.Size(37, 17);
            this.labelDriverName.TabIndex = 0;
            this.labelDriverName.Text = "Imię:";
            // 
            // labelDriverSurname
            // 
            this.labelDriverSurname.AutoSize = true;
            this.labelDriverSurname.Location = new System.Drawing.Point(6, 75);
            this.labelDriverSurname.Name = "labelDriverSurname";
            this.labelDriverSurname.Size = new System.Drawing.Size(71, 17);
            this.labelDriverSurname.TabIndex = 1;
            this.labelDriverSurname.Text = "Nazwisko:";
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Location = new System.Drawing.Point(83, 36);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(154, 22);
            this.textBoxDriverName.TabIndex = 2;
            // 
            // textBoxDriverSurname
            // 
            this.textBoxDriverSurname.Location = new System.Drawing.Point(83, 75);
            this.textBoxDriverSurname.Name = "textBoxDriverSurname";
            this.textBoxDriverSurname.Size = new System.Drawing.Size(154, 22);
            this.textBoxDriverSurname.TabIndex = 3;
            // 
            // buttonDriverAdd
            // 
            this.buttonDriverAdd.Location = new System.Drawing.Point(110, 263);
            this.buttonDriverAdd.Name = "buttonDriverAdd";
            this.buttonDriverAdd.Size = new System.Drawing.Size(174, 34);
            this.buttonDriverAdd.TabIndex = 4;
            this.buttonDriverAdd.Text = "Dodaj";
            this.buttonDriverAdd.UseVisualStyleBackColor = true;
            this.buttonDriverAdd.Click += new System.EventHandler(this.buttonDriverAdd_Click_1);
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.textBoxPassword);
            this.groupBoxDriver.Controls.Add(this.labelPassword);
            this.groupBoxDriver.Controls.Add(this.labelDriverName);
            this.groupBoxDriver.Controls.Add(this.labelDriverSurname);
            this.groupBoxDriver.Controls.Add(this.textBoxDriverSurname);
            this.groupBoxDriver.Controls.Add(this.textBoxDriverName);
            this.groupBoxDriver.Location = new System.Drawing.Point(18, 79);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(257, 162);
            this.groupBoxDriver.TabIndex = 5;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Kierowca";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(18, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 31);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "<- Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 115);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 17);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Hasło:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(83, 115);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(154, 22);
            this.textBoxPassword.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NewDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxDriver);
            this.Controls.Add(this.buttonDriverAdd);
            this.Name = "NewDriver";
            this.Size = new System.Drawing.Size(312, 345);
            this.groupBoxDriver.ResumeLayout(false);
            this.groupBoxDriver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDriverName;
        private System.Windows.Forms.Label labelDriverSurname;
        private System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.TextBox textBoxDriverSurname;
        private System.Windows.Forms.Button buttonDriverAdd;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
