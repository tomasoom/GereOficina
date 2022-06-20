namespace GereOficina
{
    partial class frmGereOficina
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
            this.lbLC_Clientes = new System.Windows.Forms.ListBox();
            this.txtLC_NomeCliente = new System.Windows.Forms.TextBox();
            this.txtLC_NIFCliente = new System.Windows.Forms.TextBox();
            this.btnLC_AddCliente = new System.Windows.Forms.Button();
            this.gpbLC_AddCliente = new System.Windows.Forms.GroupBox();
            this.lblNIFCLiente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.gpbListaCliente = new System.Windows.Forms.GroupBox();
            this.btnLC_RemoveCliente = new System.Windows.Forms.Button();
            this.gpbFCS = new System.Windows.Forms.GroupBox();
            this.lblFCS_TotalGasto = new System.Windows.Forms.Label();
            this.lblFCS_HeaderTotalGasto = new System.Windows.Forms.Label();
            this.gpbFCS_Parcelas = new System.Windows.Forms.GroupBox();
            this.gpbFCS_AddParcela = new System.Windows.Forms.GroupBox();
            this.btnFCS_AddParcela = new System.Windows.Forms.Button();
            this.txtFCS_Valor = new System.Windows.Forms.TextBox();
            this.txtFCS_Descricao = new System.Windows.Forms.TextBox();
            this.btnFCS_RemoveParcela = new System.Windows.Forms.Button();
            this.lbFCS_Parcelas = new System.Windows.Forms.ListBox();
            this.gpbFCS_Servicos = new System.Windows.Forms.GroupBox();
            this.btnFCS_RemoveServico = new System.Windows.Forms.Button();
            this.gpbFCS_AddServico = new System.Windows.Forms.GroupBox();
            this.btnFCS_AddServico = new System.Windows.Forms.Button();
            this.cboFCS_Tipo = new System.Windows.Forms.ComboBox();
            this.lbFCS_Servicos = new System.Windows.Forms.ListBox();
            this.gpbFCS_Carros = new System.Windows.Forms.GroupBox();
            this.btnFCS_RemoveCarro = new System.Windows.Forms.Button();
            this.gpbFCS_AddCarro = new System.Windows.Forms.GroupBox();
            this.btnFCS_AddCarro = new System.Windows.Forms.Button();
            this.txtFCS_MatriculaCarro = new System.Windows.Forms.TextBox();
            this.lbFCS_Carros = new System.Windows.Forms.ListBox();
            this.btnFCS_Guardar = new System.Windows.Forms.Button();
            this.lblFCS_NIFCliente = new System.Windows.Forms.Label();
            this.txtFCS_NIFCliente = new System.Windows.Forms.TextBox();
            this.txtFCS_NomeCLiente = new System.Windows.Forms.TextBox();
            this.lblFCS_NomeCliente = new System.Windows.Forms.Label();
            this.gpbLC_AddCliente.SuspendLayout();
            this.gpbListaCliente.SuspendLayout();
            this.gpbFCS.SuspendLayout();
            this.gpbFCS_Parcelas.SuspendLayout();
            this.gpbFCS_AddParcela.SuspendLayout();
            this.gpbFCS_Servicos.SuspendLayout();
            this.gpbFCS_AddServico.SuspendLayout();
            this.gpbFCS_Carros.SuspendLayout();
            this.gpbFCS_AddCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLC_Clientes
            // 
            this.lbLC_Clientes.FormattingEnabled = true;
            this.lbLC_Clientes.Location = new System.Drawing.Point(16, 54);
            this.lbLC_Clientes.Name = "lbLC_Clientes";
            this.lbLC_Clientes.Size = new System.Drawing.Size(200, 355);
            this.lbLC_Clientes.TabIndex = 0;
            this.lbLC_Clientes.SelectedIndexChanged += new System.EventHandler(this.lbLC_Clientes_SelectedIndexChanged);
            // 
            // txtLC_NomeCliente
            // 
            this.txtLC_NomeCliente.Location = new System.Drawing.Point(50, 29);
            this.txtLC_NomeCliente.Name = "txtLC_NomeCliente";
            this.txtLC_NomeCliente.Size = new System.Drawing.Size(120, 20);
            this.txtLC_NomeCliente.TabIndex = 1;
            // 
            // txtLC_NIFCliente
            // 
            this.txtLC_NIFCliente.Location = new System.Drawing.Point(50, 61);
            this.txtLC_NIFCliente.Name = "txtLC_NIFCliente";
            this.txtLC_NIFCliente.Size = new System.Drawing.Size(120, 20);
            this.txtLC_NIFCliente.TabIndex = 2;
            // 
            // btnLC_AddCliente
            // 
            this.btnLC_AddCliente.Location = new System.Drawing.Point(65, 87);
            this.btnLC_AddCliente.Name = "btnLC_AddCliente";
            this.btnLC_AddCliente.Size = new System.Drawing.Size(84, 39);
            this.btnLC_AddCliente.TabIndex = 3;
            this.btnLC_AddCliente.Text = "Guardar";
            this.btnLC_AddCliente.UseVisualStyleBackColor = true;
            this.btnLC_AddCliente.Click += new System.EventHandler(this.btnLC_AddCliente_Click);
            // 
            // gpbLC_AddCliente
            // 
            this.gpbLC_AddCliente.Controls.Add(this.lblNIFCLiente);
            this.gpbLC_AddCliente.Controls.Add(this.lblNomeCliente);
            this.gpbLC_AddCliente.Controls.Add(this.txtLC_NomeCliente);
            this.gpbLC_AddCliente.Controls.Add(this.btnLC_AddCliente);
            this.gpbLC_AddCliente.Controls.Add(this.txtLC_NIFCliente);
            this.gpbLC_AddCliente.Location = new System.Drawing.Point(16, 431);
            this.gpbLC_AddCliente.Name = "gpbLC_AddCliente";
            this.gpbLC_AddCliente.Size = new System.Drawing.Size(200, 132);
            this.gpbLC_AddCliente.TabIndex = 4;
            this.gpbLC_AddCliente.TabStop = false;
            this.gpbLC_AddCliente.Text = "Criar Novo Cliente";
            // 
            // lblNIFCLiente
            // 
            this.lblNIFCLiente.AutoSize = true;
            this.lblNIFCLiente.Location = new System.Drawing.Point(17, 64);
            this.lblNIFCLiente.Name = "lblNIFCLiente";
            this.lblNIFCLiente.Size = new System.Drawing.Size(27, 13);
            this.lblNIFCLiente.TabIndex = 5;
            this.lblNIFCLiente.Text = "NIF:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(6, 32);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCliente.TabIndex = 4;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // gpbListaCliente
            // 
            this.gpbListaCliente.Controls.Add(this.btnLC_RemoveCliente);
            this.gpbListaCliente.Controls.Add(this.lbLC_Clientes);
            this.gpbListaCliente.Controls.Add(this.gpbLC_AddCliente);
            this.gpbListaCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbListaCliente.Name = "gpbListaCliente";
            this.gpbListaCliente.Size = new System.Drawing.Size(247, 569);
            this.gpbListaCliente.TabIndex = 5;
            this.gpbListaCliente.TabStop = false;
            this.gpbListaCliente.Text = "Lista de Clientes";
            // 
            // btnLC_RemoveCliente
            // 
            this.btnLC_RemoveCliente.Location = new System.Drawing.Point(16, 25);
            this.btnLC_RemoveCliente.Name = "btnLC_RemoveCliente";
            this.btnLC_RemoveCliente.Size = new System.Drawing.Size(200, 23);
            this.btnLC_RemoveCliente.TabIndex = 5;
            this.btnLC_RemoveCliente.Text = "Remover";
            this.btnLC_RemoveCliente.UseVisualStyleBackColor = true;
            this.btnLC_RemoveCliente.Click += new System.EventHandler(this.btnLC_RemoveCliente_Click);
            // 
            // gpbFCS
            // 
            this.gpbFCS.Controls.Add(this.lblFCS_TotalGasto);
            this.gpbFCS.Controls.Add(this.lblFCS_HeaderTotalGasto);
            this.gpbFCS.Controls.Add(this.gpbFCS_Parcelas);
            this.gpbFCS.Controls.Add(this.gpbFCS_Servicos);
            this.gpbFCS.Controls.Add(this.gpbFCS_Carros);
            this.gpbFCS.Controls.Add(this.btnFCS_Guardar);
            this.gpbFCS.Controls.Add(this.lblFCS_NIFCliente);
            this.gpbFCS.Controls.Add(this.txtFCS_NIFCliente);
            this.gpbFCS.Controls.Add(this.txtFCS_NomeCLiente);
            this.gpbFCS.Controls.Add(this.lblFCS_NomeCliente);
            this.gpbFCS.Location = new System.Drawing.Point(287, 12);
            this.gpbFCS.Name = "gpbFCS";
            this.gpbFCS.Size = new System.Drawing.Size(792, 569);
            this.gpbFCS.TabIndex = 6;
            this.gpbFCS.TabStop = false;
            this.gpbFCS.Text = "Ficha Cliente Selecionado";
            // 
            // lblFCS_TotalGasto
            // 
            this.lblFCS_TotalGasto.AutoSize = true;
            this.lblFCS_TotalGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCS_TotalGasto.Location = new System.Drawing.Point(687, 56);
            this.lblFCS_TotalGasto.Name = "lblFCS_TotalGasto";
            this.lblFCS_TotalGasto.Size = new System.Drawing.Size(31, 20);
            this.lblFCS_TotalGasto.TabIndex = 9;
            this.lblFCS_TotalGasto.Text = "0,0";
            // 
            // lblFCS_HeaderTotalGasto
            // 
            this.lblFCS_HeaderTotalGasto.AutoSize = true;
            this.lblFCS_HeaderTotalGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCS_HeaderTotalGasto.Location = new System.Drawing.Point(658, 36);
            this.lblFCS_HeaderTotalGasto.Name = "lblFCS_HeaderTotalGasto";
            this.lblFCS_HeaderTotalGasto.Size = new System.Drawing.Size(96, 20);
            this.lblFCS_HeaderTotalGasto.TabIndex = 8;
            this.lblFCS_HeaderTotalGasto.Text = "Total Gasto:";
            // 
            // gpbFCS_Parcelas
            // 
            this.gpbFCS_Parcelas.Controls.Add(this.gpbFCS_AddParcela);
            this.gpbFCS_Parcelas.Controls.Add(this.btnFCS_RemoveParcela);
            this.gpbFCS_Parcelas.Controls.Add(this.lbFCS_Parcelas);
            this.gpbFCS_Parcelas.Location = new System.Drawing.Point(543, 100);
            this.gpbFCS_Parcelas.Name = "gpbFCS_Parcelas";
            this.gpbFCS_Parcelas.Size = new System.Drawing.Size(231, 451);
            this.gpbFCS_Parcelas.TabIndex = 7;
            this.gpbFCS_Parcelas.TabStop = false;
            this.gpbFCS_Parcelas.Text = "Parcelas";
            // 
            // gpbFCS_AddParcela
            // 
            this.gpbFCS_AddParcela.Controls.Add(this.btnFCS_AddParcela);
            this.gpbFCS_AddParcela.Controls.Add(this.txtFCS_Valor);
            this.gpbFCS_AddParcela.Controls.Add(this.txtFCS_Descricao);
            this.gpbFCS_AddParcela.Location = new System.Drawing.Point(6, 363);
            this.gpbFCS_AddParcela.Name = "gpbFCS_AddParcela";
            this.gpbFCS_AddParcela.Size = new System.Drawing.Size(219, 82);
            this.gpbFCS_AddParcela.TabIndex = 2;
            this.gpbFCS_AddParcela.TabStop = false;
            this.gpbFCS_AddParcela.Text = "Criar Nova (Descrição - Valor)";
            // 
            // btnFCS_AddParcela
            // 
            this.btnFCS_AddParcela.Location = new System.Drawing.Point(7, 43);
            this.btnFCS_AddParcela.Name = "btnFCS_AddParcela";
            this.btnFCS_AddParcela.Size = new System.Drawing.Size(206, 33);
            this.btnFCS_AddParcela.TabIndex = 2;
            this.btnFCS_AddParcela.Text = "Adicionar Parcela";
            this.btnFCS_AddParcela.UseVisualStyleBackColor = true;
            this.btnFCS_AddParcela.Click += new System.EventHandler(this.btnFCS_AddParcela_Click);
            // 
            // txtFCS_Valor
            // 
            this.txtFCS_Valor.Location = new System.Drawing.Point(113, 17);
            this.txtFCS_Valor.Name = "txtFCS_Valor";
            this.txtFCS_Valor.Size = new System.Drawing.Size(100, 20);
            this.txtFCS_Valor.TabIndex = 1;
            // 
            // txtFCS_Descricao
            // 
            this.txtFCS_Descricao.Location = new System.Drawing.Point(7, 17);
            this.txtFCS_Descricao.Name = "txtFCS_Descricao";
            this.txtFCS_Descricao.Size = new System.Drawing.Size(100, 20);
            this.txtFCS_Descricao.TabIndex = 0;
            // 
            // btnFCS_RemoveParcela
            // 
            this.btnFCS_RemoveParcela.Location = new System.Drawing.Point(7, 20);
            this.btnFCS_RemoveParcela.Name = "btnFCS_RemoveParcela";
            this.btnFCS_RemoveParcela.Size = new System.Drawing.Size(218, 23);
            this.btnFCS_RemoveParcela.TabIndex = 1;
            this.btnFCS_RemoveParcela.Text = "Remover";
            this.btnFCS_RemoveParcela.UseVisualStyleBackColor = true;
            this.btnFCS_RemoveParcela.Click += new System.EventHandler(this.btnFCS_RemoveParcela_Click);
            // 
            // lbFCS_Parcelas
            // 
            this.lbFCS_Parcelas.FormattingEnabled = true;
            this.lbFCS_Parcelas.Location = new System.Drawing.Point(6, 51);
            this.lbFCS_Parcelas.Name = "lbFCS_Parcelas";
            this.lbFCS_Parcelas.Size = new System.Drawing.Size(219, 303);
            this.lbFCS_Parcelas.TabIndex = 0;
            // 
            // gpbFCS_Servicos
            // 
            this.gpbFCS_Servicos.Controls.Add(this.btnFCS_RemoveServico);
            this.gpbFCS_Servicos.Controls.Add(this.gpbFCS_AddServico);
            this.gpbFCS_Servicos.Controls.Add(this.lbFCS_Servicos);
            this.gpbFCS_Servicos.Location = new System.Drawing.Point(234, 100);
            this.gpbFCS_Servicos.Name = "gpbFCS_Servicos";
            this.gpbFCS_Servicos.Size = new System.Drawing.Size(303, 451);
            this.gpbFCS_Servicos.TabIndex = 6;
            this.gpbFCS_Servicos.TabStop = false;
            this.gpbFCS_Servicos.Text = "Serviços";
            // 
            // btnFCS_RemoveServico
            // 
            this.btnFCS_RemoveServico.Location = new System.Drawing.Point(14, 21);
            this.btnFCS_RemoveServico.Name = "btnFCS_RemoveServico";
            this.btnFCS_RemoveServico.Size = new System.Drawing.Size(269, 23);
            this.btnFCS_RemoveServico.TabIndex = 2;
            this.btnFCS_RemoveServico.Text = "Remover";
            this.btnFCS_RemoveServico.UseVisualStyleBackColor = true;
            this.btnFCS_RemoveServico.Click += new System.EventHandler(this.btnFCS_RemoveServico_Click);
            // 
            // gpbFCS_AddServico
            // 
            this.gpbFCS_AddServico.Controls.Add(this.btnFCS_AddServico);
            this.gpbFCS_AddServico.Controls.Add(this.cboFCS_Tipo);
            this.gpbFCS_AddServico.Location = new System.Drawing.Point(7, 363);
            this.gpbFCS_AddServico.Name = "gpbFCS_AddServico";
            this.gpbFCS_AddServico.Size = new System.Drawing.Size(282, 82);
            this.gpbFCS_AddServico.TabIndex = 1;
            this.gpbFCS_AddServico.TabStop = false;
            this.gpbFCS_AddServico.Text = "Criar Novo (Tipo)";
            // 
            // btnFCS_AddServico
            // 
            this.btnFCS_AddServico.Location = new System.Drawing.Point(7, 48);
            this.btnFCS_AddServico.Name = "btnFCS_AddServico";
            this.btnFCS_AddServico.Size = new System.Drawing.Size(269, 30);
            this.btnFCS_AddServico.TabIndex = 1;
            this.btnFCS_AddServico.Text = "Criar Serviço";
            this.btnFCS_AddServico.UseVisualStyleBackColor = true;
            this.btnFCS_AddServico.Click += new System.EventHandler(this.btnFCS_AddServico_Click);
            // 
            // cboFCS_Tipo
            // 
            this.cboFCS_Tipo.FormattingEnabled = true;
            this.cboFCS_Tipo.Items.AddRange(new object[] {
            "Manutenção",
            "Reparação"});
            this.cboFCS_Tipo.Location = new System.Drawing.Point(7, 18);
            this.cboFCS_Tipo.Name = "cboFCS_Tipo";
            this.cboFCS_Tipo.Size = new System.Drawing.Size(269, 21);
            this.cboFCS_Tipo.TabIndex = 0;
            // 
            // lbFCS_Servicos
            // 
            this.lbFCS_Servicos.FormattingEnabled = true;
            this.lbFCS_Servicos.Location = new System.Drawing.Point(7, 51);
            this.lbFCS_Servicos.Name = "lbFCS_Servicos";
            this.lbFCS_Servicos.Size = new System.Drawing.Size(282, 303);
            this.lbFCS_Servicos.TabIndex = 0;
            this.lbFCS_Servicos.SelectedIndexChanged += new System.EventHandler(this.lbFCS_Servicos_SelectedIndexChanged);
            // 
            // gpbFCS_Carros
            // 
            this.gpbFCS_Carros.Controls.Add(this.btnFCS_RemoveCarro);
            this.gpbFCS_Carros.Controls.Add(this.gpbFCS_AddCarro);
            this.gpbFCS_Carros.Controls.Add(this.lbFCS_Carros);
            this.gpbFCS_Carros.Location = new System.Drawing.Point(19, 100);
            this.gpbFCS_Carros.Name = "gpbFCS_Carros";
            this.gpbFCS_Carros.Size = new System.Drawing.Size(209, 457);
            this.gpbFCS_Carros.TabIndex = 5;
            this.gpbFCS_Carros.TabStop = false;
            this.gpbFCS_Carros.Text = "Carros";
            // 
            // btnFCS_RemoveCarro
            // 
            this.btnFCS_RemoveCarro.Location = new System.Drawing.Point(6, 22);
            this.btnFCS_RemoveCarro.Name = "btnFCS_RemoveCarro";
            this.btnFCS_RemoveCarro.Size = new System.Drawing.Size(188, 23);
            this.btnFCS_RemoveCarro.TabIndex = 2;
            this.btnFCS_RemoveCarro.Text = "Remover";
            this.btnFCS_RemoveCarro.UseVisualStyleBackColor = true;
            this.btnFCS_RemoveCarro.Click += new System.EventHandler(this.btnFCS_RemoveCarro_Click);
            // 
            // gpbFCS_AddCarro
            // 
            this.gpbFCS_AddCarro.Controls.Add(this.btnFCS_AddCarro);
            this.gpbFCS_AddCarro.Controls.Add(this.txtFCS_MatriculaCarro);
            this.gpbFCS_AddCarro.Location = new System.Drawing.Point(7, 361);
            this.gpbFCS_AddCarro.Name = "gpbFCS_AddCarro";
            this.gpbFCS_AddCarro.Size = new System.Drawing.Size(187, 90);
            this.gpbFCS_AddCarro.TabIndex = 1;
            this.gpbFCS_AddCarro.TabStop = false;
            this.gpbFCS_AddCarro.Text = "Criar Novo (Matricula)";
            // 
            // btnFCS_AddCarro
            // 
            this.btnFCS_AddCarro.Location = new System.Drawing.Point(9, 50);
            this.btnFCS_AddCarro.Name = "btnFCS_AddCarro";
            this.btnFCS_AddCarro.Size = new System.Drawing.Size(172, 34);
            this.btnFCS_AddCarro.TabIndex = 1;
            this.btnFCS_AddCarro.Text = "Adicionar Carro";
            this.btnFCS_AddCarro.UseVisualStyleBackColor = true;
            this.btnFCS_AddCarro.Click += new System.EventHandler(this.btnFCS_AddCarro_Click);
            // 
            // txtFCS_MatriculaCarro
            // 
            this.txtFCS_MatriculaCarro.Location = new System.Drawing.Point(9, 20);
            this.txtFCS_MatriculaCarro.Name = "txtFCS_MatriculaCarro";
            this.txtFCS_MatriculaCarro.Size = new System.Drawing.Size(172, 20);
            this.txtFCS_MatriculaCarro.TabIndex = 0;
            // 
            // lbFCS_Carros
            // 
            this.lbFCS_Carros.FormattingEnabled = true;
            this.lbFCS_Carros.Location = new System.Drawing.Point(6, 51);
            this.lbFCS_Carros.Name = "lbFCS_Carros";
            this.lbFCS_Carros.Size = new System.Drawing.Size(188, 303);
            this.lbFCS_Carros.TabIndex = 0;
            this.lbFCS_Carros.SelectedIndexChanged += new System.EventHandler(this.lbFCS_Carros_SelectedIndexChanged);
            // 
            // btnFCS_Guardar
            // 
            this.btnFCS_Guardar.Location = new System.Drawing.Point(355, 36);
            this.btnFCS_Guardar.Name = "btnFCS_Guardar";
            this.btnFCS_Guardar.Size = new System.Drawing.Size(283, 58);
            this.btnFCS_Guardar.TabIndex = 4;
            this.btnFCS_Guardar.Text = "Guardar Alterações";
            this.btnFCS_Guardar.UseVisualStyleBackColor = true;
            this.btnFCS_Guardar.Click += new System.EventHandler(this.btnFCS_Guardar_Click);
            // 
            // lblFCS_NIFCliente
            // 
            this.lblFCS_NIFCliente.AutoSize = true;
            this.lblFCS_NIFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCS_NIFCliente.Location = new System.Drawing.Point(31, 72);
            this.lblFCS_NIFCliente.Name = "lblFCS_NIFCliente";
            this.lblFCS_NIFCliente.Size = new System.Drawing.Size(39, 20);
            this.lblFCS_NIFCliente.TabIndex = 3;
            this.lblFCS_NIFCliente.Text = "NIF:";
            // 
            // txtFCS_NIFCliente
            // 
            this.txtFCS_NIFCliente.Location = new System.Drawing.Point(85, 74);
            this.txtFCS_NIFCliente.Name = "txtFCS_NIFCliente";
            this.txtFCS_NIFCliente.Size = new System.Drawing.Size(250, 20);
            this.txtFCS_NIFCliente.TabIndex = 2;
            // 
            // txtFCS_NomeCLiente
            // 
            this.txtFCS_NomeCLiente.Location = new System.Drawing.Point(85, 36);
            this.txtFCS_NomeCLiente.Name = "txtFCS_NomeCLiente";
            this.txtFCS_NomeCLiente.Size = new System.Drawing.Size(250, 20);
            this.txtFCS_NomeCLiente.TabIndex = 1;
            // 
            // lblFCS_NomeCliente
            // 
            this.lblFCS_NomeCliente.AutoSize = true;
            this.lblFCS_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCS_NomeCliente.Location = new System.Drawing.Point(15, 34);
            this.lblFCS_NomeCliente.Name = "lblFCS_NomeCliente";
            this.lblFCS_NomeCliente.Size = new System.Drawing.Size(55, 20);
            this.lblFCS_NomeCliente.TabIndex = 0;
            this.lblFCS_NomeCliente.Text = "Nome:";
            // 
            // frmGereOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 593);
            this.Controls.Add(this.gpbFCS);
            this.Controls.Add(this.gpbListaCliente);
            this.Name = "frmGereOficina";
            this.Text = "Gere Oficina";
            this.Load += new System.EventHandler(this.frmGereClientes_Load);
            this.gpbLC_AddCliente.ResumeLayout(false);
            this.gpbLC_AddCliente.PerformLayout();
            this.gpbListaCliente.ResumeLayout(false);
            this.gpbFCS.ResumeLayout(false);
            this.gpbFCS.PerformLayout();
            this.gpbFCS_Parcelas.ResumeLayout(false);
            this.gpbFCS_AddParcela.ResumeLayout(false);
            this.gpbFCS_AddParcela.PerformLayout();
            this.gpbFCS_Servicos.ResumeLayout(false);
            this.gpbFCS_AddServico.ResumeLayout(false);
            this.gpbFCS_Carros.ResumeLayout(false);
            this.gpbFCS_AddCarro.ResumeLayout(false);
            this.gpbFCS_AddCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLC_Clientes;
        private System.Windows.Forms.TextBox txtLC_NomeCliente;
        private System.Windows.Forms.TextBox txtLC_NIFCliente;
        private System.Windows.Forms.Button btnLC_AddCliente;
        private System.Windows.Forms.GroupBox gpbLC_AddCliente;
        private System.Windows.Forms.Label lblNIFCLiente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.GroupBox gpbListaCliente;
        private System.Windows.Forms.Button btnLC_RemoveCliente;
        private System.Windows.Forms.GroupBox gpbFCS;
        private System.Windows.Forms.TextBox txtFCS_NomeCLiente;
        private System.Windows.Forms.Label lblFCS_NomeCliente;
        private System.Windows.Forms.Button btnFCS_Guardar;
        private System.Windows.Forms.Label lblFCS_NIFCliente;
        private System.Windows.Forms.TextBox txtFCS_NIFCliente;
        private System.Windows.Forms.GroupBox gpbFCS_Parcelas;
        private System.Windows.Forms.Button btnFCS_RemoveParcela;
        private System.Windows.Forms.ListBox lbFCS_Parcelas;
        private System.Windows.Forms.GroupBox gpbFCS_Servicos;
        private System.Windows.Forms.Button btnFCS_RemoveServico;
        private System.Windows.Forms.GroupBox gpbFCS_AddServico;
        private System.Windows.Forms.Button btnFCS_AddServico;
        private System.Windows.Forms.ComboBox cboFCS_Tipo;
        private System.Windows.Forms.ListBox lbFCS_Servicos;
        private System.Windows.Forms.GroupBox gpbFCS_Carros;
        private System.Windows.Forms.Button btnFCS_RemoveCarro;
        private System.Windows.Forms.GroupBox gpbFCS_AddCarro;
        private System.Windows.Forms.Button btnFCS_AddCarro;
        private System.Windows.Forms.TextBox txtFCS_MatriculaCarro;
        private System.Windows.Forms.ListBox lbFCS_Carros;
        private System.Windows.Forms.GroupBox gpbFCS_AddParcela;
        private System.Windows.Forms.TextBox txtFCS_Descricao;
        private System.Windows.Forms.Button btnFCS_AddParcela;
        private System.Windows.Forms.TextBox txtFCS_Valor;
        private System.Windows.Forms.Label lblFCS_TotalGasto;
        private System.Windows.Forms.Label lblFCS_HeaderTotalGasto;
    }
}

