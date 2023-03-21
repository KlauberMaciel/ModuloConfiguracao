namespace WindowsFormsAppPrincipal
{
    partial class adicionaGrupoUsuario
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
            System.Windows.Forms.Label nomeGrupoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adicionaGrupoUsuario));
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            resources.ApplyResources(nomeGrupoLabel, "nomeGrupoLabel");
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            resources.ApplyResources(this.nomeGrupoTextBox, "nomeGrupoTextBox");
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // Salvar
            // 
            resources.ApplyResources(this.Salvar, "Salvar");
            this.Salvar.Name = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Cancelar
            // 
            resources.ApplyResources(this.Cancelar, "Cancelar");
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // adicionaGrupoUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adicionaGrupoUsuario";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.adicionaGrupoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Cancelar;
    }
}