
namespace KAPTUNO4KA
{
    partial class ColorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsertButton = new System.Windows.Forms.Button();
            this.LoadedImage = new System.Windows.Forms.PictureBox();
            this.RGB = new System.Windows.Forms.Label();
            this.panelka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(12, 29);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(105, 40);
            this.InsertButton.TabIndex = 0;
            this.InsertButton.Text = "Add picture";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // LoadedImage
            // 
            this.LoadedImage.Location = new System.Drawing.Point(12, 13);
            this.LoadedImage.Name = "LoadedImage";
            this.LoadedImage.Size = new System.Drawing.Size(776, 425);
            this.LoadedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadedImage.TabIndex = 1;
            this.LoadedImage.TabStop = false;
            // 
            // RGB
            // 
            this.RGB.AutoSize = true;
            this.RGB.Location = new System.Drawing.Point(12, 9);
            this.RGB.Name = "RGB";
            this.RGB.Size = new System.Drawing.Size(0, 17);
            this.RGB.TabIndex = 2;
            // 
            // panelka
            // 
            this.panelka.Location = new System.Drawing.Point(12, 75);
            this.panelka.Name = "panelka";
            this.panelka.Size = new System.Drawing.Size(105, 22);
            this.panelka.TabIndex = 3;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelka);
            this.Controls.Add(this.RGB);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.LoadedImage);
            this.Name = "ColorForm";
            this.Text = "MMMMM KARTUNO4KI";
            this.Click += new System.EventHandler(this.ColorForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LoadedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.PictureBox LoadedImage;
        private System.Windows.Forms.Label RGB;
        private System.Windows.Forms.TextBox panelka;
    }
}

