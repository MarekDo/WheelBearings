
namespace WheelBearings
{
    partial class FormTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.wheelBearingKitsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wheelBearingKitsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(13, 13);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(95, 13);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "Marka samochodu";
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCar);
            this.Name = "FormTable";
            this.Text = "FormTable";
            this.Load += new System.EventHandler(this.FormTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wheelBearingKitsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource wheelBearingKitsDataSetBindingSource;
        private System.Windows.Forms.Label lblCar;
    }
}