namespace Zapravka
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
            this.BuyButton = new System.Windows.Forms.Button();
            this.PetrolLabel = new System.Windows.Forms.Label();
            this.PetrolPriceLabel = new System.Windows.Forms.Label();
            this.PetrolChoose = new System.Windows.Forms.ComboBox();
            this.PetrolPriceBox = new System.Windows.Forms.TextBox();
            this.PetrolGrn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.PetrolTotalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SumBox = new System.Windows.Forms.TextBox();
            this.PetrolBox = new System.Windows.Forms.TextBox();
            this.SumAmountChoice = new System.Windows.Forms.RadioButton();
            this.FuelAmountChoice = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColaQuantityBox = new System.Windows.Forms.TextBox();
            this.FriesQuantityBox = new System.Windows.Forms.TextBox();
            this.BurgerQuantityBox = new System.Windows.Forms.TextBox();
            this.HotDogQuantityBox = new System.Windows.Forms.TextBox();
            this.ColaPrice = new System.Windows.Forms.TextBox();
            this.FriesPrice = new System.Windows.Forms.TextBox();
            this.BurgerPrice = new System.Windows.Forms.TextBox();
            this.HotDogPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BurgerBox = new System.Windows.Forms.CheckBox();
            this.FriesBox = new System.Windows.Forms.CheckBox();
            this.ColaBox = new System.Windows.Forms.CheckBox();
            this.HotDogBox = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.CafeTotalLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(120, 20);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(146, 53);
            this.BuyButton.TabIndex = 0;
            this.BuyButton.Text = "Прорахувати";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.CountTotal);
            // 
            // PetrolLabel
            // 
            this.PetrolLabel.AutoSize = true;
            this.PetrolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetrolLabel.Location = new System.Drawing.Point(13, 38);
            this.PetrolLabel.Name = "PetrolLabel";
            this.PetrolLabel.Size = new System.Drawing.Size(70, 20);
            this.PetrolLabel.TabIndex = 1;
            this.PetrolLabel.Text = "Бензин";
            // 
            // PetrolPriceLabel
            // 
            this.PetrolPriceLabel.AutoSize = true;
            this.PetrolPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetrolPriceLabel.Location = new System.Drawing.Point(25, 79);
            this.PetrolPriceLabel.Name = "PetrolPriceLabel";
            this.PetrolPriceLabel.Size = new System.Drawing.Size(46, 20);
            this.PetrolPriceLabel.TabIndex = 2;
            this.PetrolPriceLabel.Text = "Ціна";
            // 
            // PetrolChoose
            // 
            this.PetrolChoose.FormattingEnabled = true;
            this.PetrolChoose.Items.AddRange(new object[] {
            "A-92",
            "A-95",
            "A-98",
            "A-100",
            "Diesel",
            "Gas",
            "Electric"});
            this.PetrolChoose.Location = new System.Drawing.Point(89, 38);
            this.PetrolChoose.Name = "PetrolChoose";
            this.PetrolChoose.Size = new System.Drawing.Size(110, 24);
            this.PetrolChoose.TabIndex = 3;
            this.PetrolChoose.SelectedIndexChanged += new System.EventHandler(this.PetrolChoose_SelectedIndexChanged);
            // 
            // PetrolPriceBox
            // 
            this.PetrolPriceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PetrolPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetrolPriceBox.Location = new System.Drawing.Point(89, 80);
            this.PetrolPriceBox.Multiline = true;
            this.PetrolPriceBox.Name = "PetrolPriceBox";
            this.PetrolPriceBox.ReadOnly = true;
            this.PetrolPriceBox.Size = new System.Drawing.Size(100, 20);
            this.PetrolPriceBox.TabIndex = 4;
            // 
            // PetrolGrn
            // 
            this.PetrolGrn.AutoSize = true;
            this.PetrolGrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetrolGrn.Location = new System.Drawing.Point(195, 80);
            this.PetrolGrn.Name = "PetrolGrn";
            this.PetrolGrn.Size = new System.Drawing.Size(41, 20);
            this.PetrolGrn.TabIndex = 5;
            this.PetrolGrn.Text = "грн.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SumBox);
            this.panel1.Controls.Add(this.PetrolBox);
            this.panel1.Controls.Add(this.SumAmountChoice);
            this.panel1.Controls.Add(this.FuelAmountChoice);
            this.panel1.Controls.Add(this.PetrolPriceBox);
            this.panel1.Controls.Add(this.PetrolChoose);
            this.panel1.Controls.Add(this.PetrolPriceLabel);
            this.panel1.Controls.Add(this.PetrolLabel);
            this.panel1.Controls.Add(this.PetrolGrn);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(43, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 311);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.PetrolTotalLabel);
            this.panel4.Location = new System.Drawing.Point(29, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 86);
            this.panel4.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(154, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "грн.";
            // 
            // PetrolTotalLabel
            // 
            this.PetrolTotalLabel.AutoSize = true;
            this.PetrolTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetrolTotalLabel.Location = new System.Drawing.Point(55, 29);
            this.PetrolTotalLabel.Name = "PetrolTotalLabel";
            this.PetrolTotalLabel.Size = new System.Drawing.Size(27, 29);
            this.PetrolTotalLabel.TabIndex = 14;
            this.PetrolTotalLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(218, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "л.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(218, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "грн.";
            // 
            // SumBox
            // 
            this.SumBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SumBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SumBox.Location = new System.Drawing.Point(136, 163);
            this.SumBox.Multiline = true;
            this.SumBox.Name = "SumBox";
            this.SumBox.ReadOnly = true;
            this.SumBox.Size = new System.Drawing.Size(75, 20);
            this.SumBox.TabIndex = 11;
            this.SumBox.TextChanged += new System.EventHandler(this.CountBySum);
            // 
            // PetrolBox
            // 
            this.PetrolBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PetrolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetrolBox.Location = new System.Drawing.Point(136, 131);
            this.PetrolBox.Multiline = true;
            this.PetrolBox.Name = "PetrolBox";
            this.PetrolBox.ReadOnly = true;
            this.PetrolBox.Size = new System.Drawing.Size(75, 20);
            this.PetrolBox.TabIndex = 10;
            this.PetrolBox.TextChanged += new System.EventHandler(this.CountByPetrol);
            // 
            // SumAmountChoice
            // 
            this.SumAmountChoice.AutoSize = true;
            this.SumAmountChoice.Location = new System.Drawing.Point(29, 163);
            this.SumAmountChoice.Name = "SumAmountChoice";
            this.SumAmountChoice.Size = new System.Drawing.Size(62, 20);
            this.SumAmountChoice.TabIndex = 9;
            this.SumAmountChoice.Text = "Сума";
            this.SumAmountChoice.UseVisualStyleBackColor = true;
            this.SumAmountChoice.CheckedChanged += new System.EventHandler(this.SumAmountChoice_CheckedChanged);
            // 
            // FuelAmountChoice
            // 
            this.FuelAmountChoice.AutoSize = true;
            this.FuelAmountChoice.Location = new System.Drawing.Point(29, 131);
            this.FuelAmountChoice.Name = "FuelAmountChoice";
            this.FuelAmountChoice.Size = new System.Drawing.Size(85, 20);
            this.FuelAmountChoice.TabIndex = 8;
            this.FuelAmountChoice.Text = "Кількість";
            this.FuelAmountChoice.UseVisualStyleBackColor = true;
            this.FuelAmountChoice.CheckedChanged += new System.EventHandler(this.FuelAmountChoice_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Автозаправка";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(17, 124);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(108, 65);
            this.panel6.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.ColaQuantityBox);
            this.panel2.Controls.Add(this.FriesQuantityBox);
            this.panel2.Controls.Add(this.BurgerQuantityBox);
            this.panel2.Controls.Add(this.HotDogQuantityBox);
            this.panel2.Controls.Add(this.ColaPrice);
            this.panel2.Controls.Add(this.FriesPrice);
            this.panel2.Controls.Add(this.BurgerPrice);
            this.panel2.Controls.Add(this.HotDogPrice);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.BurgerBox);
            this.panel2.Controls.Add(this.FriesBox);
            this.panel2.Controls.Add(this.ColaBox);
            this.panel2.Controls.Add(this.HotDogBox);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(392, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 311);
            this.panel2.TabIndex = 7;
            // 
            // ColaQuantityBox
            // 
            this.ColaQuantityBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ColaQuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColaQuantityBox.Location = new System.Drawing.Point(223, 140);
            this.ColaQuantityBox.Multiline = true;
            this.ColaQuantityBox.Name = "ColaQuantityBox";
            this.ColaQuantityBox.ReadOnly = true;
            this.ColaQuantityBox.Size = new System.Drawing.Size(65, 20);
            this.ColaQuantityBox.TabIndex = 27;
            this.ColaQuantityBox.Text = "0";
            this.ColaQuantityBox.TextChanged += new System.EventHandler(this.CountCafe);
            // 
            // FriesQuantityBox
            // 
            this.FriesQuantityBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FriesQuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriesQuantityBox.Location = new System.Drawing.Point(225, 106);
            this.FriesQuantityBox.Multiline = true;
            this.FriesQuantityBox.Name = "FriesQuantityBox";
            this.FriesQuantityBox.ReadOnly = true;
            this.FriesQuantityBox.Size = new System.Drawing.Size(65, 20);
            this.FriesQuantityBox.TabIndex = 26;
            this.FriesQuantityBox.Text = "0";
            this.FriesQuantityBox.TextChanged += new System.EventHandler(this.CountCafe);
            // 
            // BurgerQuantityBox
            // 
            this.BurgerQuantityBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BurgerQuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BurgerQuantityBox.Location = new System.Drawing.Point(225, 73);
            this.BurgerQuantityBox.Multiline = true;
            this.BurgerQuantityBox.Name = "BurgerQuantityBox";
            this.BurgerQuantityBox.ReadOnly = true;
            this.BurgerQuantityBox.Size = new System.Drawing.Size(65, 20);
            this.BurgerQuantityBox.TabIndex = 25;
            this.BurgerQuantityBox.Text = "0";
            this.BurgerQuantityBox.TextChanged += new System.EventHandler(this.CountCafe);
            // 
            // HotDogQuantityBox
            // 
            this.HotDogQuantityBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HotDogQuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HotDogQuantityBox.Location = new System.Drawing.Point(225, 42);
            this.HotDogQuantityBox.Multiline = true;
            this.HotDogQuantityBox.Name = "HotDogQuantityBox";
            this.HotDogQuantityBox.ReadOnly = true;
            this.HotDogQuantityBox.Size = new System.Drawing.Size(65, 20);
            this.HotDogQuantityBox.TabIndex = 24;
            this.HotDogQuantityBox.Text = "0";
            this.HotDogQuantityBox.TextChanged += new System.EventHandler(this.CountCafe);
            // 
            // ColaPrice
            // 
            this.ColaPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ColaPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColaPrice.Location = new System.Drawing.Point(149, 140);
            this.ColaPrice.Multiline = true;
            this.ColaPrice.Name = "ColaPrice";
            this.ColaPrice.ReadOnly = true;
            this.ColaPrice.Size = new System.Drawing.Size(49, 20);
            this.ColaPrice.TabIndex = 23;
            this.ColaPrice.Text = "21";
            // 
            // FriesPrice
            // 
            this.FriesPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FriesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriesPrice.Location = new System.Drawing.Point(149, 105);
            this.FriesPrice.Multiline = true;
            this.FriesPrice.Name = "FriesPrice";
            this.FriesPrice.ReadOnly = true;
            this.FriesPrice.Size = new System.Drawing.Size(49, 20);
            this.FriesPrice.TabIndex = 22;
            this.FriesPrice.Text = "30";
            // 
            // BurgerPrice
            // 
            this.BurgerPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BurgerPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BurgerPrice.Location = new System.Drawing.Point(149, 73);
            this.BurgerPrice.Multiline = true;
            this.BurgerPrice.Name = "BurgerPrice";
            this.BurgerPrice.ReadOnly = true;
            this.BurgerPrice.Size = new System.Drawing.Size(49, 20);
            this.BurgerPrice.TabIndex = 21;
            this.BurgerPrice.Text = "60";
            // 
            // HotDogPrice
            // 
            this.HotDogPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HotDogPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HotDogPrice.Location = new System.Drawing.Point(149, 42);
            this.HotDogPrice.Multiline = true;
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.ReadOnly = true;
            this.HotDogPrice.Size = new System.Drawing.Size(49, 20);
            this.HotDogPrice.TabIndex = 17;
            this.HotDogPrice.Text = "41";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(219, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "кількість";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(152, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "ціна";
            // 
            // BurgerBox
            // 
            this.BurgerBox.AutoSize = true;
            this.BurgerBox.Location = new System.Drawing.Point(25, 73);
            this.BurgerBox.Name = "BurgerBox";
            this.BurgerBox.Size = new System.Drawing.Size(99, 20);
            this.BurgerBox.TabIndex = 19;
            this.BurgerBox.Text = "Гамбургер";
            this.BurgerBox.UseVisualStyleBackColor = true;
            this.BurgerBox.CheckedChanged += new System.EventHandler(this.BurgerBox_CheckedChanged);
            // 
            // FriesBox
            // 
            this.FriesBox.AutoSize = true;
            this.FriesBox.Location = new System.Drawing.Point(25, 106);
            this.FriesBox.Name = "FriesBox";
            this.FriesBox.Size = new System.Drawing.Size(117, 20);
            this.FriesBox.TabIndex = 18;
            this.FriesBox.Text = "Картопля-фрі";
            this.FriesBox.UseVisualStyleBackColor = true;
            this.FriesBox.CheckedChanged += new System.EventHandler(this.FriesBox_CheckedChanged);
            // 
            // ColaBox
            // 
            this.ColaBox.AutoSize = true;
            this.ColaBox.Location = new System.Drawing.Point(25, 140);
            this.ColaBox.Name = "ColaBox";
            this.ColaBox.Size = new System.Drawing.Size(95, 20);
            this.ColaBox.TabIndex = 17;
            this.ColaBox.Text = "Кока-кола";
            this.ColaBox.UseVisualStyleBackColor = true;
            this.ColaBox.CheckedChanged += new System.EventHandler(this.ColaBox_CheckedChanged);
            // 
            // HotDogBox
            // 
            this.HotDogBox.AutoSize = true;
            this.HotDogBox.Location = new System.Drawing.Point(25, 38);
            this.HotDogBox.Name = "HotDogBox";
            this.HotDogBox.Size = new System.Drawing.Size(78, 20);
            this.HotDogBox.TabIndex = 16;
            this.HotDogBox.Text = "Хот-дог";
            this.HotDogBox.UseVisualStyleBackColor = true;
            this.HotDogBox.CheckedChanged += new System.EventHandler(this.HotDogBox_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.CafeTotalLabel);
            this.panel5.Location = new System.Drawing.Point(53, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 86);
            this.panel5.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(154, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "грн.";
            // 
            // CafeTotalLabel
            // 
            this.CafeTotalLabel.AutoSize = true;
            this.CafeTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CafeTotalLabel.Location = new System.Drawing.Point(55, 29);
            this.CafeTotalLabel.Name = "CafeTotalLabel";
            this.CafeTotalLabel.Size = new System.Drawing.Size(27, 29);
            this.CafeTotalLabel.TabIndex = 14;
            this.CafeTotalLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(83, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "До оплати:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(423, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Міні-Кафе";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TotalLabel);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.BuyButton);
            this.panel3.Location = new System.Drawing.Point(60, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 88);
            this.panel3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(551, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "грн.";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(452, 27);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(27, 29);
            this.TotalLabel.TabIndex = 16;
            this.TotalLabel.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(89, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ціна";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(100, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "ВСЬОГО до оплати:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(50, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "До оплати:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label PetrolLabel;
        private System.Windows.Forms.Label PetrolPriceLabel;
        private System.Windows.Forms.ComboBox PetrolChoose;
        private System.Windows.Forms.TextBox PetrolPriceBox;
        private System.Windows.Forms.Label PetrolGrn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SumBox;
        private System.Windows.Forms.TextBox PetrolBox;
        private System.Windows.Forms.RadioButton SumAmountChoice;
        private System.Windows.Forms.RadioButton FuelAmountChoice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PetrolTotalLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CafeTotalLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox ColaPrice;
        private System.Windows.Forms.TextBox FriesPrice;
        private System.Windows.Forms.TextBox BurgerPrice;
        private System.Windows.Forms.TextBox HotDogPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox BurgerBox;
        private System.Windows.Forms.CheckBox FriesBox;
        private System.Windows.Forms.CheckBox ColaBox;
        private System.Windows.Forms.CheckBox HotDogBox;
        private System.Windows.Forms.TextBox ColaQuantityBox;
        private System.Windows.Forms.TextBox FriesQuantityBox;
        private System.Windows.Forms.TextBox BurgerQuantityBox;
        private System.Windows.Forms.TextBox HotDogQuantityBox;
        private System.Windows.Forms.Label label6;
    }
}

