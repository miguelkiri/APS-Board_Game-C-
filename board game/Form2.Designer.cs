namespace board_game
{
    partial class Form2
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
            System.Windows.Forms.Label idBoardLabel;
            System.Windows.Forms.Label idFuncionarioLabel;
            System.Windows.Forms.Label nomedoJogoLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label dCompraLabel;
            System.Windows.Forms.Label dVendaLabel;
            System.Windows.Forms.Label classEtariaLabel;
            System.Windows.Forms.Label dMediaJogoLabel;
            System.Windows.Forms.Label anoPublicacaoLabel;
            System.Windows.Forms.Label qVezesJogadoLabel;
            System.Windows.Forms.Label tipoSleevesLabel;
            System.Windows.Forms.Label qSleevesLabel;
            System.Windows.Forms.Label qPlayersLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label mecanicasLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.boardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDsystemDataSet = new board_game.BDsystemDataSet();
            this.funcionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mecanicasComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idBoardTextBox = new System.Windows.Forms.TextBox();
            this.nomedoJogoTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.dCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dVendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.classEtariaTextBox = new System.Windows.Forms.TextBox();
            this.dMediaJogoTextBox = new System.Windows.Forms.TextBox();
            this.anoPublicacaoTextBox = new System.Windows.Forms.TextBox();
            this.qVezesJogadoTextBox = new System.Windows.Forms.TextBox();
            this.tipoSleevesTextBox = new System.Windows.Forms.TextBox();
            this.qSleevesTextBox = new System.Windows.Forms.TextBox();
            this.qPlayersTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boardTableAdapter = new board_game.BDsystemDataSetTableAdapters.BoardTableAdapter();
            this.tableAdapterManager = new board_game.BDsystemDataSetTableAdapters.TableAdapterManager();
            this.boardBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.boardBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.funcionariosTableAdapter = new board_game.BDsystemDataSetTableAdapters.FuncionariosTableAdapter();
            this.boardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            idBoardLabel = new System.Windows.Forms.Label();
            idFuncionarioLabel = new System.Windows.Forms.Label();
            nomedoJogoLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            dCompraLabel = new System.Windows.Forms.Label();
            dVendaLabel = new System.Windows.Forms.Label();
            classEtariaLabel = new System.Windows.Forms.Label();
            dMediaJogoLabel = new System.Windows.Forms.Label();
            anoPublicacaoLabel = new System.Windows.Forms.Label();
            qVezesJogadoLabel = new System.Windows.Forms.Label();
            tipoSleevesLabel = new System.Windows.Forms.Label();
            qSleevesLabel = new System.Windows.Forms.Label();
            qPlayersLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            mecanicasLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingNavigator)).BeginInit();
            this.boardBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idBoardLabel
            // 
            idBoardLabel.AutoSize = true;
            idBoardLabel.Location = new System.Drawing.Point(34, 44);
            idBoardLabel.Name = "idBoardLabel";
            idBoardLabel.Size = new System.Drawing.Size(50, 13);
            idBoardLabel.TabIndex = 0;
            idBoardLabel.Text = "Id Board:";
            // 
            // idFuncionarioLabel
            // 
            idFuncionarioLabel.AutoSize = true;
            idFuncionarioLabel.Location = new System.Drawing.Point(34, 70);
            idFuncionarioLabel.Name = "idFuncionarioLabel";
            idFuncionarioLabel.Size = new System.Drawing.Size(77, 13);
            idFuncionarioLabel.TabIndex = 2;
            idFuncionarioLabel.Text = "Id Funcionario:";
            // 
            // nomedoJogoLabel
            // 
            nomedoJogoLabel.AutoSize = true;
            nomedoJogoLabel.Location = new System.Drawing.Point(34, 96);
            nomedoJogoLabel.Name = "nomedoJogoLabel";
            nomedoJogoLabel.Size = new System.Drawing.Size(76, 13);
            nomedoJogoLabel.TabIndex = 4;
            nomedoJogoLabel.Text = "Nomedo Jogo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(34, 148);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(35, 13);
            autorLabel.TabIndex = 8;
            autorLabel.Text = "Autor:";
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Location = new System.Drawing.Point(34, 174);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(43, 13);
            editoraLabel.TabIndex = 10;
            editoraLabel.Text = "Editora:";
            // 
            // dCompraLabel
            // 
            dCompraLabel.AutoSize = true;
            dCompraLabel.Location = new System.Drawing.Point(34, 201);
            dCompraLabel.Name = "dCompraLabel";
            dCompraLabel.Size = new System.Drawing.Size(46, 13);
            dCompraLabel.TabIndex = 12;
            dCompraLabel.Text = "Compra:";
            // 
            // dVendaLabel
            // 
            dVendaLabel.AutoSize = true;
            dVendaLabel.Location = new System.Drawing.Point(34, 227);
            dVendaLabel.Name = "dVendaLabel";
            dVendaLabel.Size = new System.Drawing.Size(41, 13);
            dVendaLabel.TabIndex = 14;
            dVendaLabel.Text = "Venda:";
            // 
            // classEtariaLabel
            // 
            classEtariaLabel.AutoSize = true;
            classEtariaLabel.Location = new System.Drawing.Point(34, 252);
            classEtariaLabel.Name = "classEtariaLabel";
            classEtariaLabel.Size = new System.Drawing.Size(65, 13);
            classEtariaLabel.TabIndex = 16;
            classEtariaLabel.Text = "Faixa Etária:";
            // 
            // dMediaJogoLabel
            // 
            dMediaJogoLabel.AutoSize = true;
            dMediaJogoLabel.Location = new System.Drawing.Point(34, 278);
            dMediaJogoLabel.Name = "dMediaJogoLabel";
            dMediaJogoLabel.Size = new System.Drawing.Size(74, 13);
            dMediaJogoLabel.TabIndex = 18;
            dMediaJogoLabel.Text = "Duração Jogo";
            // 
            // anoPublicacaoLabel
            // 
            anoPublicacaoLabel.AutoSize = true;
            anoPublicacaoLabel.Location = new System.Drawing.Point(34, 304);
            anoPublicacaoLabel.Name = "anoPublicacaoLabel";
            anoPublicacaoLabel.Size = new System.Drawing.Size(85, 13);
            anoPublicacaoLabel.TabIndex = 20;
            anoPublicacaoLabel.Text = "Ano Publicação:";
            // 
            // qVezesJogadoLabel
            // 
            qVezesJogadoLabel.AutoSize = true;
            qVezesJogadoLabel.Location = new System.Drawing.Point(34, 330);
            qVezesJogadoLabel.Name = "qVezesJogadoLabel";
            qVezesJogadoLabel.Size = new System.Drawing.Size(77, 13);
            qVezesJogadoLabel.TabIndex = 22;
            qVezesJogadoLabel.Text = "Vezes Jogado:";
            // 
            // tipoSleevesLabel
            // 
            tipoSleevesLabel.AutoSize = true;
            tipoSleevesLabel.Location = new System.Drawing.Point(34, 356);
            tipoSleevesLabel.Name = "tipoSleevesLabel";
            tipoSleevesLabel.Size = new System.Drawing.Size(72, 13);
            tipoSleevesLabel.TabIndex = 24;
            tipoSleevesLabel.Text = "Tipo Sleeves:";
            // 
            // qSleevesLabel
            // 
            qSleevesLabel.AutoSize = true;
            qSleevesLabel.Location = new System.Drawing.Point(34, 382);
            qSleevesLabel.Name = "qSleevesLabel";
            qSleevesLabel.Size = new System.Drawing.Size(48, 13);
            qSleevesLabel.TabIndex = 26;
            qSleevesLabel.Text = "Sleeves:";
            // 
            // qPlayersLabel
            // 
            qPlayersLabel.AutoSize = true;
            qPlayersLabel.Location = new System.Drawing.Point(34, 408);
            qPlayersLabel.Name = "qPlayersLabel";
            qPlayersLabel.Size = new System.Drawing.Size(44, 13);
            qPlayersLabel.TabIndex = 28;
            qPlayersLabel.Text = "Players:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(34, 434);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 30;
            descricaoLabel.Text = "Descrição:";
            // 
            // mecanicasLabel1
            // 
            mecanicasLabel1.AutoSize = true;
            mecanicasLabel1.Location = new System.Drawing.Point(34, 122);
            mecanicasLabel1.Name = "mecanicasLabel1";
            mecanicasLabel1.Size = new System.Drawing.Size(62, 13);
            mecanicasLabel1.TabIndex = 34;
            mecanicasLabel1.Text = "Mecanicas:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(mecanicasLabel1);
            this.panel1.Controls.Add(this.mecanicasComboBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(idBoardLabel);
            this.panel1.Controls.Add(this.idBoardTextBox);
            this.panel1.Controls.Add(idFuncionarioLabel);
            this.panel1.Controls.Add(nomedoJogoLabel);
            this.panel1.Controls.Add(this.nomedoJogoTextBox);
            this.panel1.Controls.Add(autorLabel);
            this.panel1.Controls.Add(this.autorTextBox);
            this.panel1.Controls.Add(editoraLabel);
            this.panel1.Controls.Add(this.editoraTextBox);
            this.panel1.Controls.Add(dCompraLabel);
            this.panel1.Controls.Add(this.dCompraDateTimePicker);
            this.panel1.Controls.Add(dVendaLabel);
            this.panel1.Controls.Add(this.dVendaDateTimePicker);
            this.panel1.Controls.Add(classEtariaLabel);
            this.panel1.Controls.Add(this.classEtariaTextBox);
            this.panel1.Controls.Add(dMediaJogoLabel);
            this.panel1.Controls.Add(this.dMediaJogoTextBox);
            this.panel1.Controls.Add(anoPublicacaoLabel);
            this.panel1.Controls.Add(this.anoPublicacaoTextBox);
            this.panel1.Controls.Add(qVezesJogadoLabel);
            this.panel1.Controls.Add(this.qVezesJogadoTextBox);
            this.panel1.Controls.Add(tipoSleevesLabel);
            this.panel1.Controls.Add(this.tipoSleevesTextBox);
            this.panel1.Controls.Add(qSleevesLabel);
            this.panel1.Controls.Add(this.qSleevesTextBox);
            this.panel1.Controls.Add(qPlayersLabel);
            this.panel1.Controls.Add(this.qPlayersTextBox);
            this.panel1.Controls.Add(descricaoLabel);
            this.panel1.Controls.Add(this.descricaoTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 595);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.boardBindingSource, "IdFuncionario", true));
            this.comboBox1.DataSource = this.funcionariosBindingSource1;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.ValueMember = "IdFuncionario";
            // 
            // boardBindingSource
            // 
            this.boardBindingSource.DataMember = "Board";
            this.boardBindingSource.DataSource = this.bDsystemDataSet;
            // 
            // bDsystemDataSet
            // 
            this.bDsystemDataSet.DataSetName = "BDsystemDataSet";
            this.bDsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource1
            // 
            this.funcionariosBindingSource1.DataMember = "Funcionarios";
            this.funcionariosBindingSource1.DataSource = this.bDsystemDataSet;
            // 
            // mecanicasComboBox
            // 
            this.mecanicasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "Mecanicas", true));
            this.mecanicasComboBox.FormattingEnabled = true;
            this.mecanicasComboBox.Items.AddRange(new object[] {
            "Action [Atuação",
            "Action/Movement Programming [Programação de Ações e Movimento]",
            "Action Point Allowence System [Sistema de Pontos de Ação]",
            "Area Control/ Area Influence [Controle de Área e Influência de Área]",
            "Area Enclosure [Cerco de Área]",
            "Area Movement [Movimento de Área]",
            "Area Impulse [Sistema por Impulso/ Impulso de Área]",
            "Auction/Bidding [Leilão]",
            "Betting/Wagering [Apostas]",
            "Campaign/ Battle Card Driven [Campanha/ Batalhas Dirigidas por Cartas]",
            "Card Drafting [Seleção de Cartas]",
            "Chit-Pull System [Sistema de Puxar Grupos]",
            "Cooperative Play [Jogo cooperativo - todos contra o tabuleiro]",
            "Commodity Speculation/Stock Holding [Especulação Financeira]",
            "Crayon Rail System [¿]",
            "Deck/Pool Building [Construção de Baralho]",
            "Dice Rolling [Rolagem de dados]",
            "Grid Movement [Movimentação em Grade]",
            "Hand Management [Administração de cartas]",
            "Hex-and-Counter [Marcadores e Hexágonos]",
            "Line Drawing [Desenhar",
            "Memory [Memória]",
            "Modular Board [Tabuleiro Modular]",
            "Paper and Pencil [Papel e Caneta]:",
            "Partnership [Jogo em Equipe – Parcerias]",
            "Pattern Building [Construção A Partir de Modelo]",
            "Pattern Recognition [Identificação a Partir de Modelo]",
            "Pick Up and Deliver [Pegar e Entregar]",
            "Player Elimination [Eliminação de Jogadores]",
            "Point to Point Movement [Movimento Ponto a Ponto]",
            "Press You Luck [Sorte]",
            "Rock-Paper-Scissors [Pedra, Papel e Tesoura]",
            "Role Playing [Desempenhar um papel – Personificação]",
            "Roll/Spin and Move [Rolar e Mover]",
            "Route/Network Building [Rotas/Construção de Rotas]",
            "Secret Unit Deployment [Posicionamento Secreto]",
            "Set Collection [Colecionar Componentes]",
            "Simulation [Simulação]",
            "Simultaneous Action Sellection [Seleção Simultânea das Ações]",
            "Singing [Cantar]",
            "Stock Holding [vide Especulação Financeira]",
            "Story Telling [Contação de Histórias]",
            "Take That [Tomar o Que]",
            "Tile Placement [Colocação de Peças]",
            "Time Track [Linha de Tempo]",
            "Trading (Troca)",
            "Taking (ou Trick Taking) [Vaza/Truque]",
            "Variable Phase Order [Ordem Variável de Fases]",
            "Variable Player Powers [Jogadores com Diferentes Habilidades]",
            "Voting (Votação)",
            "Worker Placement [Alocação de Trabalhadores]"});
            this.mecanicasComboBox.Location = new System.Drawing.Point(125, 119);
            this.mecanicasComboBox.Name = "mecanicasComboBox";
            this.mecanicasComboBox.Size = new System.Drawing.Size(225, 21);
            this.mecanicasComboBox.TabIndex = 35;
            this.mecanicasComboBox.SelectedIndexChanged += new System.EventHandler(this.mecanicasComboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(232, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 49);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(51, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 32;
            this.button1.Text = "Salvar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // idBoardTextBox
            // 
            this.idBoardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "IdBoard", true));
            this.idBoardTextBox.Location = new System.Drawing.Point(125, 41);
            this.idBoardTextBox.Name = "idBoardTextBox";
            this.idBoardTextBox.ReadOnly = true;
            this.idBoardTextBox.Size = new System.Drawing.Size(225, 20);
            this.idBoardTextBox.TabIndex = 1;
            this.idBoardTextBox.TextChanged += new System.EventHandler(this.idBoardTextBox_TextChanged);
            // 
            // nomedoJogoTextBox
            // 
            this.nomedoJogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "NomedoJogo", true));
            this.nomedoJogoTextBox.Location = new System.Drawing.Point(125, 93);
            this.nomedoJogoTextBox.Name = "nomedoJogoTextBox";
            this.nomedoJogoTextBox.Size = new System.Drawing.Size(225, 20);
            this.nomedoJogoTextBox.TabIndex = 5;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(125, 145);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(225, 20);
            this.autorTextBox.TabIndex = 9;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "Editora", true));
            this.editoraTextBox.Location = new System.Drawing.Point(125, 171);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(225, 20);
            this.editoraTextBox.TabIndex = 11;
            // 
            // dCompraDateTimePicker
            // 
            this.dCompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.boardBindingSource, "DCompra", true));
            this.dCompraDateTimePicker.Location = new System.Drawing.Point(125, 197);
            this.dCompraDateTimePicker.Name = "dCompraDateTimePicker";
            this.dCompraDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.dCompraDateTimePicker.TabIndex = 13;
            // 
            // dVendaDateTimePicker
            // 
            this.dVendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.boardBindingSource, "DVenda", true));
            this.dVendaDateTimePicker.Location = new System.Drawing.Point(125, 223);
            this.dVendaDateTimePicker.Name = "dVendaDateTimePicker";
            this.dVendaDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.dVendaDateTimePicker.TabIndex = 15;
            // 
            // classEtariaTextBox
            // 
            this.classEtariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "ClassEtaria", true));
            this.classEtariaTextBox.Location = new System.Drawing.Point(125, 249);
            this.classEtariaTextBox.Name = "classEtariaTextBox";
            this.classEtariaTextBox.Size = new System.Drawing.Size(225, 20);
            this.classEtariaTextBox.TabIndex = 17;
            // 
            // dMediaJogoTextBox
            // 
            this.dMediaJogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "DMediaJogo", true));
            this.dMediaJogoTextBox.Location = new System.Drawing.Point(125, 275);
            this.dMediaJogoTextBox.Name = "dMediaJogoTextBox";
            this.dMediaJogoTextBox.Size = new System.Drawing.Size(225, 20);
            this.dMediaJogoTextBox.TabIndex = 19;
            // 
            // anoPublicacaoTextBox
            // 
            this.anoPublicacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "AnoPublicacao", true));
            this.anoPublicacaoTextBox.Location = new System.Drawing.Point(125, 301);
            this.anoPublicacaoTextBox.Name = "anoPublicacaoTextBox";
            this.anoPublicacaoTextBox.Size = new System.Drawing.Size(225, 20);
            this.anoPublicacaoTextBox.TabIndex = 21;
            // 
            // qVezesJogadoTextBox
            // 
            this.qVezesJogadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "QVezesJogado", true));
            this.qVezesJogadoTextBox.Location = new System.Drawing.Point(125, 327);
            this.qVezesJogadoTextBox.Name = "qVezesJogadoTextBox";
            this.qVezesJogadoTextBox.Size = new System.Drawing.Size(225, 20);
            this.qVezesJogadoTextBox.TabIndex = 23;
            // 
            // tipoSleevesTextBox
            // 
            this.tipoSleevesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "TipoSleeves", true));
            this.tipoSleevesTextBox.Location = new System.Drawing.Point(125, 353);
            this.tipoSleevesTextBox.Name = "tipoSleevesTextBox";
            this.tipoSleevesTextBox.Size = new System.Drawing.Size(225, 20);
            this.tipoSleevesTextBox.TabIndex = 25;
            // 
            // qSleevesTextBox
            // 
            this.qSleevesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "QSleeves", true));
            this.qSleevesTextBox.Location = new System.Drawing.Point(125, 379);
            this.qSleevesTextBox.Name = "qSleevesTextBox";
            this.qSleevesTextBox.Size = new System.Drawing.Size(225, 20);
            this.qSleevesTextBox.TabIndex = 27;
            // 
            // qPlayersTextBox
            // 
            this.qPlayersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "QPlayers", true));
            this.qPlayersTextBox.Location = new System.Drawing.Point(125, 405);
            this.qPlayersTextBox.Name = "qPlayersTextBox";
            this.qPlayersTextBox.Size = new System.Drawing.Size(225, 20);
            this.qPlayersTextBox.TabIndex = 29;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boardBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(125, 431);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(225, 70);
            this.descricaoTextBox.TabIndex = 31;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.bDsystemDataSet;
            // 
            // boardTableAdapter
            // 
            this.boardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoardTableAdapter = this.boardTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.PlayersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = board_game.BDsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // boardBindingNavigator
            // 
            this.boardBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.boardBindingNavigator.BindingSource = this.boardBindingSource;
            this.boardBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.boardBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.boardBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.boardBindingNavigatorSaveItem});
            this.boardBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.boardBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.boardBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.boardBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.boardBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.boardBindingNavigator.Name = "boardBindingNavigator";
            this.boardBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.boardBindingNavigator.Size = new System.Drawing.Size(407, 25);
            this.boardBindingNavigator.TabIndex = 1;
            this.boardBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // boardBindingNavigatorSaveItem
            // 
            this.boardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boardBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("boardBindingNavigatorSaveItem.Image")));
            this.boardBindingNavigatorSaveItem.Name = "boardBindingNavigatorSaveItem";
            this.boardBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.boardBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.boardBindingNavigatorSaveItem.Click += new System.EventHandler(this.boardBindingNavigatorSaveItem_Click);
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // boardBindingSource1
            // 
            this.boardBindingSource1.DataMember = "Board";
            this.boardBindingSource1.DataSource = this.bDsystemDataSet;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 595);
            this.Controls.Add(this.boardBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Novo Board Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingNavigator)).EndInit();
            this.boardBindingNavigator.ResumeLayout(false);
            this.boardBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BDsystemDataSet bDsystemDataSet;
        private System.Windows.Forms.BindingSource boardBindingSource;
        private BDsystemDataSetTableAdapters.BoardTableAdapter boardTableAdapter;
        private BDsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator boardBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton boardBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idBoardTextBox;
        private System.Windows.Forms.TextBox nomedoJogoTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.DateTimePicker dCompraDateTimePicker;
        private System.Windows.Forms.DateTimePicker dVendaDateTimePicker;
        private System.Windows.Forms.TextBox classEtariaTextBox;
        private System.Windows.Forms.TextBox dMediaJogoTextBox;
        private System.Windows.Forms.TextBox anoPublicacaoTextBox;
        private System.Windows.Forms.TextBox qVezesJogadoTextBox;
        private System.Windows.Forms.TextBox tipoSleevesTextBox;
        private System.Windows.Forms.TextBox qSleevesTextBox;
        private System.Windows.Forms.TextBox qPlayersTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox mecanicasComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private BDsystemDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource boardBindingSource1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource1;
    }
}