namespace WindowsFormsAppPrincipal
{
    partial class AdicionarPermissao
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
            System.Windows.Forms.Label descrisaaoLabel;
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descrisaaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalver = new System.Windows.Forms.Button();
            descrisaaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // descrisaaoLabel
            // 
            descrisaaoLabel.AutoSize = true;
            descrisaaoLabel.Location = new System.Drawing.Point(176, 203);
            descrisaaoLabel.Name = "descrisaaoLabel";
            descrisaaoLabel.Size = new System.Drawing.Size(72, 16);
            descrisaaoLabel.TabIndex = 1;
            descrisaaoLabel.Text = "Descrição:";
            // 
            // descrisaaoTextBox
            // 
            this.descrisaaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Descrisaao", true));
            this.descrisaaoTextBox.Location = new System.Drawing.Point(262, 200);
            this.descrisaaoTextBox.Name = "descrisaaoTextBox";
            this.descrisaaoTextBox.Size = new System.Drawing.Size(255, 22);
            this.descrisaaoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar Permissão";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(602, 384);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalver
            // 
            this.buttonSalver.Location = new System.Drawing.Point(510, 384);
            this.buttonSalver.Name = "buttonSalver";
            this.buttonSalver.Size = new System.Drawing.Size(75, 23);
            this.buttonSalver.TabIndex = 4;
            this.buttonSalver.Text = "Salvar";
            this.buttonSalver.UseVisualStyleBackColor = true;
            this.buttonSalver.Click += new System.EventHandler(this.buttonSalver_Click);
            // 
            // AdicionarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalver);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(descrisaaoLabel);
            this.Controls.Add(this.descrisaaoTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarPermissao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Permissão";
            this.Load += new System.EventHandler(this.AdicionarPermissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.TextBox descrisaaoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalver;
    }
}