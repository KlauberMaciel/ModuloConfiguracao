namespace WindowsFormsAppPrincipal
{
    partial class BuscarGrupoUsuario
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
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.Adicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Adicionar_per = new System.Windows.Forms.Button();
            this.Excluir_Permissao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(12, 152);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(409, 225);
            this.grupoUsuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // permissaosBindingSource
            // 
            this.permissaosBindingSource.DataMember = "Permissaos";
            this.permissaosBindingSource.DataSource = this.grupoUsuarioBindingSource;
            // 
            // permissaosDataGridView
            // 
            this.permissaosDataGridView.AllowUserToAddRows = false;
            this.permissaosDataGridView.AllowUserToDeleteRows = false;
            this.permissaosDataGridView.AllowUserToOrderColumns = true;
            this.permissaosDataGridView.AutoGenerateColumns = false;
            this.permissaosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.permissaosDataGridView.DataSource = this.permissaosBindingSource;
            this.permissaosDataGridView.Location = new System.Drawing.Point(427, 152);
            this.permissaosDataGridView.Name = "permissaosDataGridView";
            this.permissaosDataGridView.ReadOnly = true;
            this.permissaosDataGridView.RowHeadersWidth = 51;
            this.permissaosDataGridView.RowTemplate.Height = 24;
            this.permissaosDataGridView.Size = new System.Drawing.Size(434, 225);
            this.permissaosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descrisaao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrissão";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(269, 95);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(269, 124);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 5;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(361, 94);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 6;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Adicionar_per
            // 
            this.Adicionar_per.Location = new System.Drawing.Point(674, 123);
            this.Adicionar_per.Name = "Adicionar_per";
            this.Adicionar_per.Size = new System.Drawing.Size(75, 23);
            this.Adicionar_per.TabIndex = 8;
            this.Adicionar_per.Text = "Adicionar";
            this.Adicionar_per.UseVisualStyleBackColor = true;
            // 
            // Excluir_Permissao
            // 
            this.Excluir_Permissao.Location = new System.Drawing.Point(755, 124);
            this.Excluir_Permissao.Name = "Excluir_Permissao";
            this.Excluir_Permissao.Size = new System.Drawing.Size(75, 23);
            this.Excluir_Permissao.TabIndex = 9;
            this.Excluir_Permissao.Text = "Excluir";
            this.Excluir_Permissao.UseVisualStyleBackColor = true;
            // 
            // BuscarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.Excluir_Permissao);
            this.Controls.Add(this.Adicionar_per);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.permissaosDataGridView);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarGrupoUsuario";
            this.ShowIcon = false;
            this.Text = "Buscar Grupo de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.BindingSource permissaosBindingSource;
        private System.Windows.Forms.DataGridView permissaosDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Adicionar_per;
        private System.Windows.Forms.Button Excluir_Permissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}