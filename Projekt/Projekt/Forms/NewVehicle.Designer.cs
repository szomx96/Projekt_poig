﻿namespace Projekt.Forms
{
    partial class NewVehicle
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
            this.groupBoxVehicle = new System.Windows.Forms.GroupBox();
            this.textBoxVolumeValue = new System.Windows.Forms.TextBox();
            this.textBoxCapacityValue = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationNrValue = new System.Windows.Forms.TextBox();
            this.labelVehicleVolume = new System.Windows.Forms.Label();
            this.labelVehicleCapacity = new System.Windows.Forms.Label();
            this.labelVehicleNumber = new System.Windows.Forms.Label();
            this.buttonVehicleAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.Controls.Add(this.textBoxVolumeValue);
            this.groupBoxVehicle.Controls.Add(this.textBoxCapacityValue);
            this.groupBoxVehicle.Controls.Add(this.textBoxRegistrationNrValue);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleVolume);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleCapacity);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleNumber);
            this.groupBoxVehicle.Location = new System.Drawing.Point(15, 71);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(363, 182);
            this.groupBoxVehicle.TabIndex = 0;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Pojazd";
            // 
            // textBoxVolumeValue
            // 
            this.textBoxVolumeValue.Location = new System.Drawing.Point(149, 128);
            this.textBoxVolumeValue.Name = "textBoxVolumeValue";
            this.textBoxVolumeValue.Size = new System.Drawing.Size(151, 22);
            this.textBoxVolumeValue.TabIndex = 5;
            // 
            // textBoxCapacityValue
            // 
            this.textBoxCapacityValue.Location = new System.Drawing.Point(149, 88);
            this.textBoxCapacityValue.Name = "textBoxCapacityValue";
            this.textBoxCapacityValue.Size = new System.Drawing.Size(151, 22);
            this.textBoxCapacityValue.TabIndex = 4;
            // 
            // textBoxRegistrationNrValue
            // 
            this.textBoxRegistrationNrValue.Location = new System.Drawing.Point(149, 50);
            this.textBoxRegistrationNrValue.MaxLength = 8;
            this.textBoxRegistrationNrValue.Name = "textBoxRegistrationNrValue";
            this.textBoxRegistrationNrValue.Size = new System.Drawing.Size(151, 22);
            this.textBoxRegistrationNrValue.TabIndex = 3;
            // 
            // labelVehicleVolume
            // 
            this.labelVehicleVolume.AutoSize = true;
            this.labelVehicleVolume.Location = new System.Drawing.Point(16, 128);
            this.labelVehicleVolume.Name = "labelVehicleVolume";
            this.labelVehicleVolume.Size = new System.Drawing.Size(81, 17);
            this.labelVehicleVolume.TabIndex = 2;
            this.labelVehicleVolume.Text = "Pojemność:";
            // 
            // labelVehicleCapacity
            // 
            this.labelVehicleCapacity.AutoSize = true;
            this.labelVehicleCapacity.Location = new System.Drawing.Point(16, 88);
            this.labelVehicleCapacity.Name = "labelVehicleCapacity";
            this.labelVehicleCapacity.Size = new System.Drawing.Size(83, 17);
            this.labelVehicleCapacity.TabIndex = 1;
            this.labelVehicleCapacity.Text = "Ładowność:";
            // 
            // labelVehicleNumber
            // 
            this.labelVehicleNumber.AutoSize = true;
            this.labelVehicleNumber.Location = new System.Drawing.Point(16, 50);
            this.labelVehicleNumber.Name = "labelVehicleNumber";
            this.labelVehicleNumber.Size = new System.Drawing.Size(111, 17);
            this.labelVehicleNumber.TabIndex = 0;
            this.labelVehicleNumber.Text = "Nr rejestracyjny:";
            // 
            // buttonVehicleAdd
            // 
            this.buttonVehicleAdd.Location = new System.Drawing.Point(209, 259);
            this.buttonVehicleAdd.Name = "buttonVehicleAdd";
            this.buttonVehicleAdd.Size = new System.Drawing.Size(169, 31);
            this.buttonVehicleAdd.TabIndex = 1;
            this.buttonVehicleAdd.Text = "Dodaj";
            this.buttonVehicleAdd.UseVisualStyleBackColor = true;
            this.buttonVehicleAdd.Click += new System.EventHandler(this.buttonVehicleAdd_Click_1);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 31);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "<- Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // NewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonVehicleAdd);
            this.Controls.Add(this.groupBoxVehicle);
            this.Name = "NewVehicle";
            this.Size = new System.Drawing.Size(464, 360);
            this.groupBoxVehicle.ResumeLayout(false);
            this.groupBoxVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVehicle;
        private System.Windows.Forms.TextBox textBoxCapacityValue;
        private System.Windows.Forms.TextBox textBoxRegistrationNrValue;
        private System.Windows.Forms.Label labelVehicleVolume;
        private System.Windows.Forms.Label labelVehicleCapacity;
        private System.Windows.Forms.Label labelVehicleNumber;
        private System.Windows.Forms.TextBox textBoxVolumeValue;
        private System.Windows.Forms.Button buttonVehicleAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}
