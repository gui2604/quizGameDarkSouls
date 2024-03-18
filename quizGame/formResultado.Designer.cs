namespace quizGame
{
    partial class formResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formResultado));
            label1 = new Label();
            lblResultado = new Label();
            btnSair = new Button();
            lstPlacar = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Vivaldi", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(87, 39);
            label1.Name = "label1";
            label1.Size = new Size(154, 44);
            label1.TabIndex = 0;
            label1.Text = "Resultado";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Vivaldi", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblResultado.Location = new Point(115, 533);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(203, 608);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lstPlacar
            // 
            lstPlacar.BackColor = SystemColors.Control;
            lstPlacar.FormattingEnabled = true;
            lstPlacar.ItemHeight = 15;
            lstPlacar.Location = new Point(12, 95);
            lstPlacar.Name = "lstPlacar";
            lstPlacar.Size = new Size(534, 319);
            lstPlacar.TabIndex = 3;
            // 
            // formResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 705);
            Controls.Add(lstPlacar);
            Controls.Add(btnSair);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formResultado";
            Text = "formResultado";
            Load += formResultado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private Button btnSair;
        private ListBox lstPlacar;
    }
}