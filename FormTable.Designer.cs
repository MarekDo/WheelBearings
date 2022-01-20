
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
            this.lbxBrandCarList = new System.Windows.Forms.ListBox();
            this.tbxBrandCar = new System.Windows.Forms.TextBox();
            this.CarBrandLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
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
            // lbxBrandCarList
            // 
            this.lbxBrandCarList.FormattingEnabled = true;
            this.lbxBrandCarList.Location = new System.Drawing.Point(111, 133);
            this.lbxBrandCarList.Name = "lbxBrandCarList";
            this.lbxBrandCarList.Size = new System.Drawing.Size(593, 121);
            this.lbxBrandCarList.TabIndex = 2;
            // 
            // tbxBrandCar
            // 
            this.tbxBrandCar.Location = new System.Drawing.Point(221, 50);
            this.tbxBrandCar.Name = "tbxBrandCar";
            this.tbxBrandCar.Size = new System.Drawing.Size(212, 20);
            this.tbxBrandCar.TabIndex = 3;
            // 
            // CarBrandLabel
            // 
            this.CarBrandLabel.AutoSize = true;
            this.CarBrandLabel.Location = new System.Drawing.Point(111, 50);
            this.CarBrandLabel.Name = "CarBrandLabel";
            this.CarBrandLabel.Size = new System.Drawing.Size(85, 13);
            this.CarBrandLabel.TabIndex = 4;
            this.CarBrandLabel.Text = "Wyszukaj markę";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(221, 91);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(212, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Szukaj";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CarBrandLabel);
            this.Controls.Add(this.tbxBrandCar);
            this.Controls.Add(this.lbxBrandCarList);
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
        private System.Windows.Forms.ListBox lbxBrandCarList;
        private System.Windows.Forms.TextBox tbxBrandCar;
        private System.Windows.Forms.Label CarBrandLabel;
        private System.Windows.Forms.Button SearchButton;
    }
}