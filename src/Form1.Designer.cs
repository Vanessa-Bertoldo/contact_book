
namespace ProjetoAgenda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcbDadosP1 = new System.Windows.Forms.TabPage();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.contatosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new ProjetoAgenda.agendaDataSet();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet2 = new ProjetoAgenda.agendaDataSet2();
            this.contatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet1 = new ProjetoAgenda.agendaDataSet1();
            this.tcbDados = new System.Windows.Forms.TabControl();
            this.contatosTableAdapter = new ProjetoAgenda.agendaDataSet1TableAdapters.contatosTableAdapter();
            this.contatosTableAdapter1 = new ProjetoAgenda.agendaDataSet2TableAdapters.contatosTableAdapter();
            this.agendaDataSet4 = new ProjetoAgenda.agendaDataSet4();
            this.contatosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contatosTableAdapter2 = new ProjetoAgenda.agendaDataSet4TableAdapters.contatosTableAdapter();
            this.contatosTableAdapter3 = new ProjetoAgenda.agendaDataSetTableAdapters.contatosTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tcbDadosP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).BeginInit();
            this.tcbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcbDadosP1
            // 
            this.tcbDadosP1.BackColor = System.Drawing.Color.Teal;
            this.tcbDadosP1.Controls.Add(this.dvgDados);
            this.tcbDadosP1.Controls.Add(this.btnPesquisar);
            this.tcbDadosP1.Controls.Add(this.cmbOperador);
            this.tcbDadosP1.Controls.Add(this.txtValor);
            this.tcbDadosP1.Controls.Add(this.txtCodigo);
            this.tcbDadosP1.Controls.Add(this.txtEmail);
            this.tcbDadosP1.Controls.Add(this.txtNome);
            this.tcbDadosP1.Controls.Add(this.cmbCampo);
            this.tcbDadosP1.Controls.Add(this.mskTelefone);
            this.tcbDadosP1.Controls.Add(this.label1);
            this.tcbDadosP1.Controls.Add(this.label2);
            this.tcbDadosP1.Controls.Add(this.label4);
            this.tcbDadosP1.Controls.Add(this.label3);
            this.tcbDadosP1.Location = new System.Drawing.Point(4, 27);
            this.tcbDadosP1.Name = "tcbDadosP1";
            this.tcbDadosP1.Padding = new System.Windows.Forms.Padding(3);
            this.tcbDadosP1.Size = new System.Drawing.Size(871, 613);
            this.tcbDadosP1.TabIndex = 0;
            this.tcbDadosP1.Text = "Dados";
            this.tcbDadosP1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dvgDados
            // 
            this.dvgDados.AutoGenerateColumns = false;
            this.dvgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDados.BackgroundColor = System.Drawing.Color.White;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.email,
            this.telefone,
            this.btnEditar,
            this.btnExcluir});
            this.dvgDados.DataSource = this.contatosBindingSource3;
            this.dvgDados.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvgDados.Location = new System.Drawing.Point(10, 232);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.Size = new System.Drawing.Size(850, 375);
            this.dvgDados.TabIndex = 5;
            this.dvgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDados_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 0.8387708F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 40;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.FillWeight = 173.9673F;
            this.nome.HeaderText = "NOME";
            this.nome.MinimumWidth = 150;
            this.nome.Name = "nome";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 173.9673F;
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 150;
            this.email.Name = "email";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.FillWeight = 3.350965F;
            this.telefone.HeaderText = "TELEFONE";
            this.telefone.MinimumWidth = 150;
            this.telefone.Name = "telefone";
            // 
            // btnEditar
            // 
            this.btnEditar.FillWeight = 2.301028F;
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.MinimumWidth = 40;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FillWeight = 2.269126F;
            this.btnExcluir.HeaderText = "";
            this.btnExcluir.Image = global::ProjetoAgenda.Properties.Resources.Hopstarter_Button_Button_Close_16;
            this.btnExcluir.MinimumWidth = 40;
            this.btnExcluir.Name = "btnExcluir";
            // 
            // contatosBindingSource3
            // 
            this.contatosBindingSource3.DataMember = "contatos";
            this.contatosBindingSource3.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "agendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Turquoise;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(718, 195);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(142, 32);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.AutoCompleteCustomSource.AddRange(new string[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "<>"});
            this.cmbOperador.Enabled = false;
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "<>"});
            this.cmbOperador.Location = new System.Drawing.Point(155, 195);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(68, 32);
            this.cmbOperador.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(242, 198);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(175, 29);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(6, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(71, 29);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(6, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(123, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(411, 29);
            this.txtNome.TabIndex = 2;
            // 
            // cmbCampo
            // 
            this.cmbCampo.AutoCompleteCustomSource.AddRange(new string[] {
            "Id",
            "Nome",
            "Email",
            "Telefone"});
            this.cmbCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Email",
            "Telefone"});
            this.cmbCampo.Location = new System.Drawing.Point(6, 195);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(143, 32);
            this.cmbCampo.TabIndex = 4;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // mskTelefone
            // 
            this.mskTelefone.AllowDrop = true;
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(471, 103);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(154, 29);
            this.mskTelefone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(119, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(467, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // contatosBindingSource1
            // 
            this.contatosBindingSource1.DataMember = "contatos";
            this.contatosBindingSource1.DataSource = this.agendaDataSet2;
            // 
            // agendaDataSet2
            // 
            this.agendaDataSet2.DataSetName = "agendaDataSet2";
            this.agendaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contatosBindingSource
            // 
            this.contatosBindingSource.DataMember = "contatos";
            this.contatosBindingSource.DataSource = this.agendaDataSet1;
            // 
            // agendaDataSet1
            // 
            this.agendaDataSet1.DataSetName = "agendaDataSet1";
            this.agendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcbDados
            // 
            this.tcbDados.Controls.Add(this.tcbDadosP1);
            this.tcbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcbDados.Location = new System.Drawing.Point(12, 33);
            this.tcbDados.Name = "tcbDados";
            this.tcbDados.SelectedIndex = 0;
            this.tcbDados.Size = new System.Drawing.Size(879, 644);
            this.tcbDados.TabIndex = 3;
            // 
            // contatosTableAdapter
            // 
            this.contatosTableAdapter.ClearBeforeFill = true;
            // 
            // contatosTableAdapter1
            // 
            this.contatosTableAdapter1.ClearBeforeFill = true;
            // 
            // agendaDataSet4
            // 
            this.agendaDataSet4.DataSetName = "agendaDataSet4";
            this.agendaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contatosBindingSource2
            // 
            this.contatosBindingSource2.DataMember = "contatos";
            this.contatosBindingSource2.DataSource = this.agendaDataSet4;
            // 
            // contatosTableAdapter2
            // 
            this.contatosTableAdapter2.ClearBeforeFill = true;
            // 
            // contatosTableAdapter3
            // 
            this.contatosTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "id";
            this.dataGridViewImageColumn1.FillWeight = 101.4059F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProjetoAgenda.Properties.Resources.Custom_Icon_Design_Pretty_Office_10_Pencil1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 103;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "id";
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ProjetoAgenda.Properties.Resources.Custom_Icon_Design_Flatastic_1_Delete1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 89;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::ProjetoAgenda.Properties.Resources.Custom_Icon_Design_Flatastic_1_Delete_16__1_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(772, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::ProjetoAgenda.Properties.Resources.Custom_Icon_Design_Mono_General_1_Save_16;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(639, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 35);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(903, 689);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tcbDados);
            this.Name = "Form1";
            this.Text = "Projeto_Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcbDadosP1.ResumeLayout(false);
            this.tcbDadosP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).EndInit();
            this.tcbDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabPage tcbDadosP1;
        private System.Windows.Forms.DataGridView dvgDados;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tcbDados;
        private agendaDataSet1 agendaDataSet1;
        private System.Windows.Forms.BindingSource contatosBindingSource;
        private agendaDataSet1TableAdapters.contatosTableAdapter contatosTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private agendaDataSet2 agendaDataSet2;
        private System.Windows.Forms.BindingSource contatosBindingSource1;
        private agendaDataSet2TableAdapters.contatosTableAdapter contatosTableAdapter1;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.MaskedTextBox mskTelefone;
        private agendaDataSet4 agendaDataSet4;
        private System.Windows.Forms.BindingSource contatosBindingSource2;
        private agendaDataSet4TableAdapters.contatosTableAdapter contatosTableAdapter2;
        private agendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource contatosBindingSource3;
        private agendaDataSetTableAdapters.contatosTableAdapter contatosTableAdapter3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
    }
}

