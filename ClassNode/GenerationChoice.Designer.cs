namespace ClassNode
{
    partial class GenerationChoice
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
            this.randomGeneration = new System.Windows.Forms.Button();
            this.handGeneration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomGeneration
            // 
            this.randomGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomGeneration.Location = new System.Drawing.Point(12, 36);
            this.randomGeneration.Name = "randomGeneration";
            this.randomGeneration.Size = new System.Drawing.Size(289, 73);
            this.randomGeneration.TabIndex = 0;
            this.randomGeneration.Text = "Випадкова";
            this.randomGeneration.UseVisualStyleBackColor = true;
            this.randomGeneration.Click += new System.EventHandler(this.randomGeneration_Click);
            // 
            // handGeneration
            // 
            this.handGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.handGeneration.Location = new System.Drawing.Point(12, 115);
            this.handGeneration.Name = "handGeneration";
            this.handGeneration.Size = new System.Drawing.Size(289, 73);
            this.handGeneration.TabIndex = 1;
            this.handGeneration.Text = "Вручну";
            this.handGeneration.UseVisualStyleBackColor = true;
            this.handGeneration.Click += new System.EventHandler(this.handGeneration_Click);
            // 
            // GenerationChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 406);
            this.Controls.Add(this.handGeneration);
            this.Controls.Add(this.randomGeneration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerationChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вибір генерації";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randomGeneration;
        private System.Windows.Forms.Button handGeneration;
    }
}