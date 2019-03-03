namespace ClassNode
{
    partial class NodeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeView));
            this.delete = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.maxNumNodeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentNode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.has3D_first = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.gpsLabel = new System.Windows.Forms.Label();
            this.batteryLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(331, 632);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 50);
            this.delete.TabIndex = 2;
            this.delete.Text = "Видалити";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previous.BackgroundImage")));
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.previous.FlatAppearance.BorderSize = 0;
            this.previous.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.previous.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.previous.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previous.Location = new System.Drawing.Point(12, 12);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 75);
            this.previous.TabIndex = 3;
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.next.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.next.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next.Location = new System.Drawing.Point(694, 12);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 75);
            this.next.TabIndex = 4;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // maxNumNodeLabel
            // 
            this.maxNumNodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxNumNodeLabel.AutoSize = true;
            this.maxNumNodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxNumNodeLabel.Location = new System.Drawing.Point(416, 35);
            this.maxNumNodeLabel.Name = "maxNumNodeLabel";
            this.maxNumNodeLabel.Size = new System.Drawing.Size(40, 24);
            this.maxNumNodeLabel.TabIndex = 5;
            this.maxNumNodeLabel.Text = "100";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(398, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // currentNode
            // 
            this.currentNode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentNode.Location = new System.Drawing.Point(350, 32);
            this.currentNode.Name = "currentNode";
            this.currentNode.Size = new System.Drawing.Size(42, 29);
            this.currentNode.TabIndex = 7;
            this.currentNode.Text = "1";
            this.currentNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentNode.TextChanged += new System.EventHandler(this.currentNode_TextChanged);
            this.currentNode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentNode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Координати";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Розміри (см)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(383, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Інші характеристики";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(383, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Список сенсорів";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(35, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "X = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(35, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y = ";
            // 
            // has3D_first
            // 
            this.has3D_first.AutoSize = true;
            this.has3D_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.has3D_first.Location = new System.Drawing.Point(35, 338);
            this.has3D_first.Name = "has3D_first";
            this.has3D_first.Size = new System.Drawing.Size(43, 24);
            this.has3D_first.TabIndex = 14;
            this.has3D_first.Text = "Z = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(35, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Висота = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(35, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ширина = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(35, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Довжина = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(419, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Наявність GPS = ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(419, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(276, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Час роботи акумулятора (с) = ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(419, 578);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 24);
            this.label13.TabIndex = 20;
            this.label13.Text = "Радіус дії (м) = ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(15, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 31);
            this.label14.TabIndex = 21;
            this.label14.Text = "Тип = ";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xLabel.Location = new System.Drawing.Point(76, 230);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(20, 24);
            this.xLabel.TabIndex = 22;
            this.xLabel.Text = "x";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yLabel.Location = new System.Drawing.Point(76, 284);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(19, 24);
            this.yLabel.TabIndex = 23;
            this.yLabel.Text = "y";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zLabel.Location = new System.Drawing.Point(76, 338);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(19, 24);
            this.zLabel.TabIndex = 24;
            this.zLabel.Text = "z";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(125, 465);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(62, 24);
            this.heightLabel.TabIndex = 25;
            this.heightLabel.Text = "height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.Location = new System.Drawing.Point(127, 524);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(54, 24);
            this.widthLabel.TabIndex = 26;
            this.widthLabel.Text = "width";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthLabel.Location = new System.Drawing.Point(145, 578);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(62, 24);
            this.lengthLabel.TabIndex = 27;
            this.lengthLabel.Text = "length";
            // 
            // gpsLabel
            // 
            this.gpsLabel.AutoSize = true;
            this.gpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpsLabel.Location = new System.Drawing.Point(580, 465);
            this.gpsLabel.Name = "gpsLabel";
            this.gpsLabel.Size = new System.Drawing.Size(74, 24);
            this.gpsLabel.TabIndex = 28;
            this.gpsLabel.Text = "hasGps";
            // 
            // batteryLabel
            // 
            this.batteryLabel.AutoSize = true;
            this.batteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batteryLabel.Location = new System.Drawing.Point(690, 524);
            this.batteryLabel.Name = "batteryLabel";
            this.batteryLabel.Size = new System.Drawing.Size(45, 24);
            this.batteryLabel.TabIndex = 29;
            this.batteryLabel.Text = "time";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabel.Location = new System.Drawing.Point(551, 578);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(59, 24);
            this.rangeLabel.TabIndex = 30;
            this.rangeLabel.Text = "range";
            // 
            // NodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 694);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.batteryLabel);
            this.Controls.Add(this.gpsLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.has3D_first);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxNumNodeLabel);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.delete);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NodeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про вузол";
            this.Load += new System.EventHandler(this.NodeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label maxNumNodeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label has3D_first;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label gpsLabel;
        private System.Windows.Forms.Label batteryLabel;
        private System.Windows.Forms.Label rangeLabel;
    }
}