namespace ConsultaCotacaoClient
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodNeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValAtualCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValAtualVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerVariacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdNegocios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodNeg,
            this.ValFechamento,
            this.ValAbertura,
            this.ValMinimo,
            this.ValMaximo,
            this.ValAtualCompra,
            this.ValAtualVenda,
            this.PerVariacao,
            this.QtdNegocios,
            this.Hora});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(575, 113);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CodNeg
            // 
            this.CodNeg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodNeg.DefaultCellStyle = dataGridViewCellStyle26;
            this.CodNeg.HeaderText = "C�digo";
            this.CodNeg.MaxInputLength = 12;
            this.CodNeg.Name = "CodNeg";
            this.CodNeg.ToolTipText = "C�digo da A��o";
            // 
            // ValFechamento
            // 
            this.ValFechamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValFechamento.HeaderText = "Fech.";
            this.ValFechamento.Name = "ValFechamento";
            this.ValFechamento.ReadOnly = true;
            this.ValFechamento.ToolTipText = "Pre�o da a��o no fechamento do preg�o anterior (em R$)";
            // 
            // ValAbertura
            // 
            this.ValAbertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValAbertura.HeaderText = "Abertura";
            this.ValAbertura.Name = "ValAbertura";
            this.ValAbertura.ReadOnly = true;
            this.ValAbertura.ToolTipText = "Pre�o da a��o na abertura do preg�o (em R$)";
            // 
            // ValMinimo
            // 
            this.ValMinimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValMinimo.HeaderText = "M�nimo";
            this.ValMinimo.Name = "ValMinimo";
            this.ValMinimo.ReadOnly = true;
            this.ValMinimo.ToolTipText = "Pre�o m�nimo da a��o no preg�o (em R$)";
            // 
            // ValMaximo
            // 
            this.ValMaximo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValMaximo.HeaderText = "M�ximo";
            this.ValMaximo.Name = "ValMaximo";
            this.ValMaximo.ReadOnly = true;
            this.ValMaximo.ToolTipText = "Pre�o m�ximo da a��o durante o preg�o (em R$)";
            // 
            // ValAtualCompra
            // 
            this.ValAtualCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValAtualCompra.DefaultCellStyle = dataGridViewCellStyle27;
            this.ValAtualCompra.HeaderText = "Compra";
            this.ValAtualCompra.Name = "ValAtualCompra";
            this.ValAtualCompra.ReadOnly = true;
            this.ValAtualCompra.ToolTipText = "Melhor oferta de compra no momento (em R$)";
            // 
            // ValAtualVenda
            // 
            this.ValAtualVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValAtualVenda.DefaultCellStyle = dataGridViewCellStyle28;
            this.ValAtualVenda.HeaderText = "Venda";
            this.ValAtualVenda.Name = "ValAtualVenda";
            this.ValAtualVenda.ReadOnly = true;
            this.ValAtualVenda.ToolTipText = "Melhor oferta de venda no momento (em R$)";
            // 
            // PerVariacao
            // 
            this.PerVariacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerVariacao.DefaultCellStyle = dataGridViewCellStyle29;
            this.PerVariacao.HeaderText = "Varia��o";
            this.PerVariacao.Name = "PerVariacao";
            this.PerVariacao.ReadOnly = true;
            this.PerVariacao.ToolTipText = "Varia��o entre o pre�o atual e o pre�o de fechamento da a��o no preg�o anterior (" +
                "em %)";
            // 
            // QtdNegocios
            // 
            this.QtdNegocios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QtdNegocios.HeaderText = "Neg�cios";
            this.QtdNegocios.Name = "QtdNegocios";
            this.QtdNegocios.ReadOnly = true;
            this.QtdNegocios.ToolTipText = "N�mero de neg�cios fechados durante o preg�o";
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Hora.DefaultCellStyle = dataGridViewCellStyle30;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.ToolTipText = "Data e hora do preg�o aos quais a cota��o � referente";
            this.Hora.Width = 54;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Location = new System.Drawing.Point(523, 118);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(56, 21);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Atraso de 15 minutos em todas as colunas exceto \"Compra\", \"Venda\" e \"Varia��o\".";
            // 
            // lblSegundos
            // 
            this.lblSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(350, 118);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSegundos.Size = new System.Drawing.Size(15, 12);
            this.lblSegundos.TabIndex = 6;
            this.lblSegundos.Text = "0s";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Consulta Cota��o";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 143);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Consulta Cota��o v2.4.1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodNeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValAtualCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValAtualVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerVariacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdNegocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}
