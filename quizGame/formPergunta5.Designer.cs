namespace quizGame
{
    partial class formPergunta5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPergunta5));
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnVerificar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(652, 33);
            label1.TabIndex = 0;
            label1.Text = "Qual o nome do lobo de Artórias, O Caminhante do Abismo?";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(36, 325);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 229);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.ForeColor = SystemColors.Control;
            radioButton4.Location = new Point(55, 183);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(222, 27);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Freki, o Caminhante Branco";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = SystemColors.Control;
            radioButton3.Location = new Point(55, 132);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(120, 27);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Geri, O Mítico";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.Control;
            radioButton2.Location = new Point(55, 85);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(192, 27);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Fenrir, O Lobo do Norte";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.Control;
            radioButton1.Location = new Point(55, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(226, 27);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sif, O Grande Lobo Cinzento";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(195, 592);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 33);
            btnVerificar.TabIndex = 5;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // formPergunta5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 705);
            Controls.Add(btnVerificar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formPergunta5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formPergunta5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnVerificar;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
    }
}