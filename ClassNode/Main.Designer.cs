namespace ClassNode
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.viewNodeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._17 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Indecator_green = new System.Windows.Forms.PictureBox();
            this.Indecator_red = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Indecator_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indecator_red)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стан мережі";
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.Location = new System.Drawing.Point(62, 19);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(197, 78);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Згенерувати мережу";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // viewNodeButton
            // 
            this.viewNodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewNodeButton.Location = new System.Drawing.Point(324, 19);
            this.viewNodeButton.Name = "viewNodeButton";
            this.viewNodeButton.Size = new System.Drawing.Size(197, 78);
            this.viewNodeButton.TabIndex = 4;
            this.viewNodeButton.Text = "Переглянути вузли";
            this.viewNodeButton.UseVisualStyleBackColor = true;
            this.viewNodeButton.Click += new System.EventHandler(this.viewNodeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(597, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 584);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this._17);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 565);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // _17
            // 
            this._17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._17.Location = new System.Drawing.Point(3, 3);
            this._17.Name = "_17";
            this._17.Size = new System.Drawing.Size(447, 78);
            this._17.TabIndex = 0;
            this._17.Text = "Кнопка для коду";
            this._17.UseVisualStyleBackColor = true;
            this._17.Click += new System.EventHandler(this._17_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(694, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Індивідуальні завдання";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Indecator_green);
            this.groupBox2.Controls.Add(this.generateButton);
            this.groupBox2.Controls.Add(this.viewNodeButton);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 584);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(62, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Опис мережі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Indecator_green
            // 
            this.Indecator_green.Image = ((System.Drawing.Image)(resources.GetObject("Indecator_green.Image")));
            this.Indecator_green.Location = new System.Drawing.Point(151, 453);
            this.Indecator_green.Name = "Indecator_green";
            this.Indecator_green.Size = new System.Drawing.Size(159, 125);
            this.Indecator_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Indecator_green.TabIndex = 2;
            this.Indecator_green.TabStop = false;
            // 
            // Indecator_red
            // 
            this.Indecator_red.Image = ((System.Drawing.Image)(resources.GetObject("Indecator_red.Image")));
            this.Indecator_red.Location = new System.Drawing.Point(225, 502);
            this.Indecator_red.Name = "Indecator_red";
            this.Indecator_red.Size = new System.Drawing.Size(159, 125);
            this.Indecator_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Indecator_red.TabIndex = 3;
            this.Indecator_red.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Indecator_red);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система Моделювання сенсорних мереж КН-41 2019";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Indecator_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indecator_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button viewNodeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Indecator_red;
        private System.Windows.Forms.PictureBox Indecator_green;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _17;
    }
}

