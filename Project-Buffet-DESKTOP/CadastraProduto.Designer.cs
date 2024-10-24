namespace Project_Buffet_DESKTOP
{
    partial class txtID
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
            label1 = new Label();
            txtIDPro = new TextBox();
            label2 = new Label();
            txtIDCate = new TextBox();
            label3 = new Label();
            txtProduto = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 3);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "ID_Produto:";
            // 
            // txtIDPro
            // 
            txtIDPro.Location = new Point(5, 21);
            txtIDPro.Name = "txtIDPro";
            txtIDPro.Size = new Size(68, 23);
            txtIDPro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 3);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "ID_Categoria:";
            // 
            // txtIDCate
            // 
            txtIDCate.Location = new Point(105, 21);
            txtIDCate.Name = "txtIDCate";
            txtIDCate.Size = new Size(68, 23);
            txtIDCate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 3);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome do Produto:";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(218, 21);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(106, 23);
            txtProduto.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(49, 87);
            button1.Name = "button1";
            button1.Size = new Size(91, 60);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(218, 87);
            button2.Name = "button2";
            button2.Size = new Size(91, 60);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 170);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtProduto);
            Controls.Add(label3);
            Controls.Add(txtIDCate);
            Controls.Add(label2);
            Controls.Add(txtIDPro);
            Controls.Add(label1);
            Name = "txtID";
            Text = "CadastraProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIDPro;
        private Label label2;
        private TextBox txtIDCate;
        private Label label3;
        private TextBox txtProduto;
        private Button button1;
        private Button button2;
    }
}