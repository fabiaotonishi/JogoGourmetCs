namespace JogoGourmet
{
    partial class Jogo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensagem = new Label();
            tbpLayout = new TableLayoutPanel();
            btnOk = new Button();
            tbpLayout.SuspendLayout();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.Anchor = AnchorStyles.Bottom;
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(200, 0);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Padding = new Padding(0, 20, 0, 10);
            lblMensagem.Size = new Size(82, 50);
            lblMensagem.TabIndex = 0;
            lblMensagem.Text = "Mensagem";
            lblMensagem.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbpLayout
            // 
            tbpLayout.ColumnCount = 1;
            tbpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbpLayout.Controls.Add(btnOk, 0, 1);
            tbpLayout.Controls.Add(lblMensagem, 0, 0);
            tbpLayout.Dock = DockStyle.Fill;
            tbpLayout.Location = new Point(0, 0);
            tbpLayout.Name = "tbpLayout";
            tbpLayout.RowCount = 2;
            tbpLayout.RowStyles.Add(new RowStyle());
            tbpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbpLayout.Size = new Size(482, 103);
            tbpLayout.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top;
            btnOk.Location = new Point(201, 53);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(80, 30);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Jogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 103);
            Controls.Add(tbpLayout);
            Name = "Jogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Gourmet";
            tbpLayout.ResumeLayout(false);
            tbpLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMensagem;
        private TableLayoutPanel tbpLayout;
        private Button btnOk;
    }
}