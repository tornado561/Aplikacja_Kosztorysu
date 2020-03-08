namespace VP_10_Base_Project
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.text_nazwa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_pokazkategorie = new System.Windows.Forms.Button();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_pokazprzedmioty = new System.Windows.Forms.Button();
            this.wyniki = new System.Windows.Forms.DataGridView();
            this.wynikiPrawe = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listaKategorii = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.numberic_ilosc = new System.Windows.Forms.NumericUpDown();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_kategoria = new System.Windows.Forms.TextBox();
            this.text_opis = new System.Windows.Forms.TextBox();
            this.text_cena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.text_kwota = new System.Windows.Forms.TextBox();
            this.button_generujpdf = new System.Windows.Forms.Button();
            this.button_usun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiPrawe)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberic_ilosc)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_nazwa
            // 
            this.text_nazwa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_nazwa.Location = new System.Drawing.Point(129, 30);
            this.text_nazwa.Multiline = true;
            this.text_nazwa.Name = "text_nazwa";
            this.text_nazwa.Size = new System.Drawing.Size(172, 21);
            this.text_nazwa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nazwa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_pokazkategorie
            // 
            this.button_pokazkategorie.BackColor = System.Drawing.Color.Transparent;
            this.button_pokazkategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_pokazkategorie.Location = new System.Drawing.Point(307, 3);
            this.button_pokazkategorie.Name = "button_pokazkategorie";
            this.button_pokazkategorie.Size = new System.Drawing.Size(147, 21);
            this.button_pokazkategorie.TabIndex = 28;
            this.button_pokazkategorie.Text = "Pokaż Kategorie";
            this.button_pokazkategorie.UseVisualStyleBackColor = false;
            this.button_pokazkategorie.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataSource = typeof(System.Data.DataTable);
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataSource = typeof(System.Data.DataTable);
            // 
            // button_pokazprzedmioty
            // 
            this.button_pokazprzedmioty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_pokazprzedmioty.Enabled = false;
            this.button_pokazprzedmioty.Location = new System.Drawing.Point(307, 30);
            this.button_pokazprzedmioty.Name = "button_pokazprzedmioty";
            this.button_pokazprzedmioty.Size = new System.Drawing.Size(147, 21);
            this.button_pokazprzedmioty.TabIndex = 36;
            this.button_pokazprzedmioty.Text = "Pokaż Przedmioty";
            this.button_pokazprzedmioty.UseVisualStyleBackColor = true;
            this.button_pokazprzedmioty.Click += new System.EventHandler(this.Button3_Click);
            // 
            // wyniki
            // 
            this.wyniki.AllowUserToAddRows = false;
            this.wyniki.AllowUserToDeleteRows = false;
            this.wyniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.wyniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wyniki.Cursor = System.Windows.Forms.Cursors.Default;
            this.wyniki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wyniki.Location = new System.Drawing.Point(3, 63);
            this.wyniki.MultiSelect = false;
            this.wyniki.Name = "wyniki";
            this.wyniki.ReadOnly = true;
            this.wyniki.RowHeadersVisible = false;
            this.wyniki.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wyniki.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.wyniki.RowTemplate.Height = 200;
            this.wyniki.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wyniki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wyniki.Size = new System.Drawing.Size(457, 372);
            this.wyniki.TabIndex = 18;
            this.wyniki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Wyniki_CellContentClick);
            this.wyniki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wyniki_CellContentClick_1);
            // 
            // wynikiPrawe
            // 
            this.wynikiPrawe.AllowUserToAddRows = false;
            this.wynikiPrawe.AllowUserToDeleteRows = false;
            this.wynikiPrawe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.wynikiPrawe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wynikiPrawe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wynikiPrawe.Location = new System.Drawing.Point(472, 3);
            this.wynikiPrawe.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.wynikiPrawe.MultiSelect = false;
            this.wynikiPrawe.Name = "wynikiPrawe";
            this.wynikiPrawe.ReadOnly = true;
            this.wynikiPrawe.RowHeadersVisible = false;
            this.wynikiPrawe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wynikiPrawe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.wynikiPrawe.RowTemplate.Height = 200;
            this.wynikiPrawe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wynikiPrawe.Size = new System.Drawing.Size(464, 435);
            this.wynikiPrawe.TabIndex = 29;
            this.wynikiPrawe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WynikiPrawe_CellContentClick_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.wynikiPrawe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 504);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.wyniki, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(463, 438);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.57112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94967F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button_pokazkategorie, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_pokazprzedmioty, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.text_nazwa, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.listaKategorii, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(457, 54);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // listaKategorii
            // 
            this.listaKategorii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaKategorii.FormattingEnabled = true;
            this.listaKategorii.Location = new System.Drawing.Point(128, 2);
            this.listaKategorii.Margin = new System.Windows.Forms.Padding(2);
            this.listaKategorii.Name = "listaKategorii";
            this.listaKategorii.Size = new System.Drawing.Size(174, 21);
            this.listaKategorii.TabIndex = 37;
            this.listaKategorii.SelectedIndexChanged += new System.EventHandler(this.ListaKategorii_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.12923F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.29748F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.41717F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.07806F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.07806F));
            this.tableLayoutPanel4.Controls.Add(this.numberic_ilosc, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.button_dodaj, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.typTextBox, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.text_id, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.text_kategoria, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.text_opis, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.text_cena, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 447);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(463, 54);
            this.tableLayoutPanel4.TabIndex = 31;
            // 
            // numberic_ilosc
            // 
            this.numberic_ilosc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberic_ilosc.AutoSize = true;
            this.numberic_ilosc.Location = new System.Drawing.Point(279, 30);
            this.numberic_ilosc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberic_ilosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberic_ilosc.Name = "numberic_ilosc";
            this.numberic_ilosc.Size = new System.Drawing.Size(86, 20);
            this.numberic_ilosc.TabIndex = 37;
            this.numberic_ilosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_dodaj
            // 
            this.button_dodaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_dodaj.Location = new System.Drawing.Point(371, 30);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(89, 21);
            this.button_dodaj.TabIndex = 40;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // typTextBox
            // 
            this.typTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typTextBox.Location = new System.Drawing.Point(371, 3);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.ReadOnly = true;
            this.typTextBox.Size = new System.Drawing.Size(89, 20);
            this.typTextBox.TabIndex = 38;
            // 
            // text_id
            // 
            this.text_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_id.Location = new System.Drawing.Point(3, 3);
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(73, 20);
            this.text_id.TabIndex = 22;
            this.text_id.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // text_kategoria
            // 
            this.text_kategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_kategoria.Location = new System.Drawing.Point(82, 3);
            this.text_kategoria.Name = "text_kategoria";
            this.text_kategoria.ReadOnly = true;
            this.text_kategoria.Size = new System.Drawing.Size(83, 20);
            this.text_kategoria.TabIndex = 19;
            // 
            // text_opis
            // 
            this.text_opis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_opis.Location = new System.Drawing.Point(171, 3);
            this.text_opis.Name = "text_opis";
            this.text_opis.ReadOnly = true;
            this.text_opis.Size = new System.Drawing.Size(102, 20);
            this.text_opis.TabIndex = 20;
            this.text_opis.TextChanged += new System.EventHandler(this.Text_opis_TextChanged);
            // 
            // text_cena
            // 
            this.text_cena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_cena.Location = new System.Drawing.Point(279, 3);
            this.text_cena.Name = "text_cena";
            this.text_cena.ReadOnly = true;
            this.text_cena.Size = new System.Drawing.Size(86, 20);
            this.text_cena.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(171, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ilość";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel5.Controls.Add(this.text_kwota, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_generujpdf, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_usun, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(472, 447);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(464, 54);
            this.tableLayoutPanel5.TabIndex = 32;
            // 
            // text_kwota
            // 
            this.text_kwota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_kwota.Location = new System.Drawing.Point(335, 3);
            this.text_kwota.Name = "text_kwota";
            this.text_kwota.ReadOnly = true;
            this.text_kwota.Size = new System.Drawing.Size(126, 20);
            this.text_kwota.TabIndex = 31;
            // 
            // button_generujpdf
            // 
            this.button_generujpdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_generujpdf.Location = new System.Drawing.Point(168, 2);
            this.button_generujpdf.Margin = new System.Windows.Forms.Padding(2);
            this.button_generujpdf.Name = "button_generujpdf";
            this.tableLayoutPanel5.SetRowSpan(this.button_generujpdf, 2);
            this.button_generujpdf.Size = new System.Drawing.Size(162, 50);
            this.button_generujpdf.TabIndex = 30;
            this.button_generujpdf.Text = "Generuj plik Excel";
            this.button_generujpdf.UseVisualStyleBackColor = true;
            this.button_generujpdf.Click += new System.EventHandler(this.button_generujpdf_Click);
            // 
            // button_usun
            // 
            this.button_usun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_usun.Enabled = false;
            this.button_usun.Location = new System.Drawing.Point(3, 3);
            this.button_usun.Name = "button_usun";
            this.tableLayoutPanel5.SetRowSpan(this.button_usun, 2);
            this.button_usun.Size = new System.Drawing.Size(160, 48);
            this.button_usun.TabIndex = 26;
            this.button_usun.Text = "Usuń";
            this.button_usun.UseVisualStyleBackColor = true;
            this.button_usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(338, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Kwota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(939, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(440, 232);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator Kosztorysu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiPrawe)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberic_ilosc)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox text_nazwa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_pokazkategorie;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private System.Windows.Forms.Button button_pokazprzedmioty;
        private System.Windows.Forms.DataGridView wyniki;
        private System.Windows.Forms.DataGridView wynikiPrawe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_kategoria;
        private System.Windows.Forms.TextBox text_opis;
        private System.Windows.Forms.TextBox text_cena;
        private System.Windows.Forms.NumericUpDown numberic_ilosc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_kwota;
        private System.Windows.Forms.Button button_generujpdf;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.ComboBox listaKategorii;
    }
}

