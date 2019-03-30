namespace Scrum
{
    partial class FormScrum
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
            this.panelHikaye = new System.Windows.Forms.Panel();
            this.panelBaslanacak = new System.Windows.Forms.Panel();
            this.panelDevamEden = new System.Windows.Forms.Panel();
            this.panelBiten = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonHikayeEkle = new System.Windows.Forms.Button();
            this.buttonGorevEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelHikaye
            // 
            this.panelHikaye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHikaye.Location = new System.Drawing.Point(44, 47);
            this.panelHikaye.Name = "panelHikaye";
            this.panelHikaye.Size = new System.Drawing.Size(183, 314);
            this.panelHikaye.TabIndex = 0;
            // 
            // panelBaslanacak
            // 
            this.panelBaslanacak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBaslanacak.Location = new System.Drawing.Point(254, 47);
            this.panelBaslanacak.Name = "panelBaslanacak";
            this.panelBaslanacak.Size = new System.Drawing.Size(183, 314);
            this.panelBaslanacak.TabIndex = 1;
            // 
            // panelDevamEden
            // 
            this.panelDevamEden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDevamEden.Location = new System.Drawing.Point(464, 47);
            this.panelDevamEden.Name = "panelDevamEden";
            this.panelDevamEden.Size = new System.Drawing.Size(183, 314);
            this.panelDevamEden.TabIndex = 1;
            // 
            // panelBiten
            // 
            this.panelBiten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBiten.Location = new System.Drawing.Point(678, 47);
            this.panelBiten.Name = "panelBiten";
            this.panelBiten.Size = new System.Drawing.Size(183, 314);
            this.panelBiten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hikaye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(294, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlanacak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(509, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Devam Eden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(745, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Biten";
            // 
            // buttonHikayeEkle
            // 
            this.buttonHikayeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHikayeEkle.Location = new System.Drawing.Point(82, 382);
            this.buttonHikayeEkle.Name = "buttonHikayeEkle";
            this.buttonHikayeEkle.Size = new System.Drawing.Size(92, 39);
            this.buttonHikayeEkle.TabIndex = 0;
            this.buttonHikayeEkle.Text = "Hikaye Ekle";
            this.buttonHikayeEkle.UseVisualStyleBackColor = true;
            this.buttonHikayeEkle.Click += new System.EventHandler(this.buttonHikayeEkle_Click);
            // 
            // buttonGorevEkle
            // 
            this.buttonGorevEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGorevEkle.Location = new System.Drawing.Point(293, 382);
            this.buttonGorevEkle.Name = "buttonGorevEkle";
            this.buttonGorevEkle.Size = new System.Drawing.Size(92, 39);
            this.buttonGorevEkle.TabIndex = 1;
            this.buttonGorevEkle.Text = "Görev Ekle";
            this.buttonGorevEkle.UseVisualStyleBackColor = true;
            this.buttonGorevEkle.Click += new System.EventHandler(this.buttonGorevEkle_Click);
            // 
            // FormScrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 446);
            this.Controls.Add(this.buttonGorevEkle);
            this.Controls.Add(this.buttonHikayeEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBiten);
            this.Controls.Add(this.panelDevamEden);
            this.Controls.Add(this.panelBaslanacak);
            this.Controls.Add(this.panelHikaye);
            this.Name = "FormScrum";
            this.Text = "Scrum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHikayeEkle;
        private System.Windows.Forms.Button buttonGorevEkle;
        public System.Windows.Forms.Panel panelHikaye;
        public System.Windows.Forms.Panel panelBaslanacak;
        public System.Windows.Forms.Panel panelDevamEden;
        public System.Windows.Forms.Panel panelBiten;
    }
}

