namespace CWORK_Var2_VendingMachine
{
    partial class GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.labelRefund = new System.Windows.Forms.Label();
            this.buttonRefund = new System.Windows.Forms.Button();
            this.textBoxRefund = new System.Windows.Forms.TextBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.textBoxCoins = new System.Windows.Forms.TextBox();
            this.richTextBoxMachineCash = new System.Windows.Forms.RichTextBox();
            this.labelInfoMoney = new System.Windows.Forms.Label();
            this.radioButtonPr1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPr2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPr3 = new System.Windows.Forms.RadioButton();
            this.radioButtonPr4 = new System.Windows.Forms.RadioButton();
            this.radioButtonPr5 = new System.Windows.Forms.RadioButton();
            this.buttonGetProduct = new System.Windows.Forms.Button();
            this.pictureBoxPr5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPr4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPr3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPr2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPr1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSnickers = new System.Windows.Forms.PictureBox();
            this.pictureBoxMars = new System.Windows.Forms.PictureBox();
            this.pictureBoxLays = new System.Windows.Forms.PictureBox();
            this.pictureBoxPepsi = new System.Windows.Forms.PictureBox();
            this.pictureBoxSprite = new System.Windows.Forms.PictureBox();
            this.labelSnickers = new System.Windows.Forms.Label();
            this.labelMars = new System.Windows.Forms.Label();
            this.labelLays = new System.Windows.Forms.Label();
            this.labelPepsi = new System.Windows.Forms.Label();
            this.labelSprite = new System.Windows.Forms.Label();
            this.buttonSecret = new System.Windows.Forms.Button();
            this.textBoxSnickersCount = new System.Windows.Forms.TextBox();
            this.textBoxMarsCount = new System.Windows.Forms.TextBox();
            this.textBoxLaysCount = new System.Windows.Forms.TextBox();
            this.textBoxSpriteCount = new System.Windows.Forms.TextBox();
            this.textBoxPepsiCount = new System.Windows.Forms.TextBox();
            this.buttonLoadCash = new System.Windows.Forms.Button();
            this.buttonLoadCoins = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnickers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPepsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRefund
            // 
            this.labelRefund.AutoSize = true;
            this.labelRefund.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRefund.Location = new System.Drawing.Point(767, 234);
            this.labelRefund.Name = "labelRefund";
            this.labelRefund.Size = new System.Drawing.Size(109, 19);
            this.labelRefund.TabIndex = 0;
            this.labelRefund.Text = "Возврат денег";
            // 
            // buttonRefund
            // 
            this.buttonRefund.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefund.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRefund.Location = new System.Drawing.Point(685, 259);
            this.buttonRefund.Name = "buttonRefund";
            this.buttonRefund.Size = new System.Drawing.Size(80, 30);
            this.buttonRefund.TabIndex = 1;
            this.buttonRefund.Text = "Вернуть";
            this.buttonRefund.UseVisualStyleBackColor = true;
            this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
            // 
            // textBoxRefund
            // 
            this.textBoxRefund.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxRefund.Location = new System.Drawing.Point(771, 264);
            this.textBoxRefund.Name = "textBoxRefund";
            this.textBoxRefund.ReadOnly = true;
            this.textBoxRefund.Size = new System.Drawing.Size(131, 20);
            this.textBoxRefund.TabIndex = 2;
            this.textBoxRefund.TextChanged += new System.EventHandler(this.textBoxRefund_TextChanged);
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.Location = new System.Drawing.Point(600, 103);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(66, 19);
            this.labelCoins.TabIndex = 3;
            this.labelCoins.Text = "Монеты";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCash.Location = new System.Drawing.Point(600, 9);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(67, 19);
            this.labelCash.TabIndex = 4;
            this.labelCash.Text = "Купюры";
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(604, 46);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(100, 20);
            this.textBoxCash.TabIndex = 5;
            // 
            // textBoxCoins
            // 
            this.textBoxCoins.Location = new System.Drawing.Point(604, 137);
            this.textBoxCoins.Name = "textBoxCoins";
            this.textBoxCoins.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoins.TabIndex = 6;
            // 
            // richTextBoxMachineCash
            // 
            this.richTextBoxMachineCash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxMachineCash.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMachineCash.Location = new System.Drawing.Point(771, 46);
            this.richTextBoxMachineCash.Name = "richTextBoxMachineCash";
            this.richTextBoxMachineCash.ReadOnly = true;
            this.richTextBoxMachineCash.Size = new System.Drawing.Size(165, 102);
            this.richTextBoxMachineCash.TabIndex = 7;
            this.richTextBoxMachineCash.Text = "";
            // 
            // labelInfoMoney
            // 
            this.labelInfoMoney.AutoSize = true;
            this.labelInfoMoney.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoMoney.Location = new System.Drawing.Point(767, 23);
            this.labelInfoMoney.Name = "labelInfoMoney";
            this.labelInfoMoney.Size = new System.Drawing.Size(140, 19);
            this.labelInfoMoney.TabIndex = 8;
            this.labelInfoMoney.Text = "Деньги в автомате";
            // 
            // radioButtonPr1
            // 
            this.radioButtonPr1.AutoSize = true;
            this.radioButtonPr1.Location = new System.Drawing.Point(63, 93);
            this.radioButtonPr1.Name = "radioButtonPr1";
            this.radioButtonPr1.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPr1.TabIndex = 9;
            this.radioButtonPr1.TabStop = true;
            this.radioButtonPr1.UseVisualStyleBackColor = true;
            // 
            // radioButtonPr2
            // 
            this.radioButtonPr2.AutoSize = true;
            this.radioButtonPr2.Location = new System.Drawing.Point(166, 93);
            this.radioButtonPr2.Name = "radioButtonPr2";
            this.radioButtonPr2.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPr2.TabIndex = 10;
            this.radioButtonPr2.TabStop = true;
            this.radioButtonPr2.UseVisualStyleBackColor = true;
            // 
            // radioButtonPr3
            // 
            this.radioButtonPr3.AutoSize = true;
            this.radioButtonPr3.Location = new System.Drawing.Point(270, 93);
            this.radioButtonPr3.Name = "radioButtonPr3";
            this.radioButtonPr3.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPr3.TabIndex = 11;
            this.radioButtonPr3.TabStop = true;
            this.radioButtonPr3.UseVisualStyleBackColor = true;
            // 
            // radioButtonPr4
            // 
            this.radioButtonPr4.AutoSize = true;
            this.radioButtonPr4.Location = new System.Drawing.Point(374, 93);
            this.radioButtonPr4.Name = "radioButtonPr4";
            this.radioButtonPr4.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPr4.TabIndex = 12;
            this.radioButtonPr4.TabStop = true;
            this.radioButtonPr4.UseVisualStyleBackColor = true;
            // 
            // radioButtonPr5
            // 
            this.radioButtonPr5.AutoSize = true;
            this.radioButtonPr5.Location = new System.Drawing.Point(477, 93);
            this.radioButtonPr5.Name = "radioButtonPr5";
            this.radioButtonPr5.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPr5.TabIndex = 13;
            this.radioButtonPr5.TabStop = true;
            this.radioButtonPr5.UseVisualStyleBackColor = true;
            // 
            // buttonGetProduct
            // 
            this.buttonGetProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonGetProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGetProduct.Location = new System.Drawing.Point(549, 191);
            this.buttonGetProduct.Name = "buttonGetProduct";
            this.buttonGetProduct.Size = new System.Drawing.Size(155, 34);
            this.buttonGetProduct.TabIndex = 14;
            this.buttonGetProduct.Text = "Выдать товар";
            this.buttonGetProduct.UseVisualStyleBackColor = true;
            this.buttonGetProduct.Click += new System.EventHandler(this.buttonGetProduct_Click);
            // 
            // pictureBoxPr5
            // 
            this.pictureBoxPr5.Location = new System.Drawing.Point(464, 128);
            this.pictureBoxPr5.Name = "pictureBoxPr5";
            this.pictureBoxPr5.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxPr5.TabIndex = 15;
            this.pictureBoxPr5.TabStop = false;
            // 
            // pictureBoxPr4
            // 
            this.pictureBoxPr4.Location = new System.Drawing.Point(362, 128);
            this.pictureBoxPr4.Name = "pictureBoxPr4";
            this.pictureBoxPr4.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxPr4.TabIndex = 16;
            this.pictureBoxPr4.TabStop = false;
            // 
            // pictureBoxPr3
            // 
            this.pictureBoxPr3.Location = new System.Drawing.Point(257, 128);
            this.pictureBoxPr3.Name = "pictureBoxPr3";
            this.pictureBoxPr3.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxPr3.TabIndex = 17;
            this.pictureBoxPr3.TabStop = false;
            // 
            // pictureBoxPr2
            // 
            this.pictureBoxPr2.Location = new System.Drawing.Point(153, 128);
            this.pictureBoxPr2.Name = "pictureBoxPr2";
            this.pictureBoxPr2.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxPr2.TabIndex = 18;
            this.pictureBoxPr2.TabStop = false;
            // 
            // pictureBoxPr1
            // 
            this.pictureBoxPr1.Location = new System.Drawing.Point(51, 128);
            this.pictureBoxPr1.Name = "pictureBoxPr1";
            this.pictureBoxPr1.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxPr1.TabIndex = 19;
            this.pictureBoxPr1.TabStop = false;
            // 
            // pictureBoxSnickers
            // 
            this.pictureBoxSnickers.Location = new System.Drawing.Point(42, 234);
            this.pictureBoxSnickers.Name = "pictureBoxSnickers";
            this.pictureBoxSnickers.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxSnickers.TabIndex = 20;
            this.pictureBoxSnickers.TabStop = false;
            // 
            // pictureBoxMars
            // 
            this.pictureBoxMars.Location = new System.Drawing.Point(143, 234);
            this.pictureBoxMars.Name = "pictureBoxMars";
            this.pictureBoxMars.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxMars.TabIndex = 21;
            this.pictureBoxMars.TabStop = false;
            // 
            // pictureBoxLays
            // 
            this.pictureBoxLays.Location = new System.Drawing.Point(244, 234);
            this.pictureBoxLays.Name = "pictureBoxLays";
            this.pictureBoxLays.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLays.TabIndex = 22;
            this.pictureBoxLays.TabStop = false;
            // 
            // pictureBoxPepsi
            // 
            this.pictureBoxPepsi.Location = new System.Drawing.Point(349, 234);
            this.pictureBoxPepsi.Name = "pictureBoxPepsi";
            this.pictureBoxPepsi.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxPepsi.TabIndex = 23;
            this.pictureBoxPepsi.TabStop = false;
            // 
            // pictureBoxSprite
            // 
            this.pictureBoxSprite.Location = new System.Drawing.Point(451, 234);
            this.pictureBoxSprite.Name = "pictureBoxSprite";
            this.pictureBoxSprite.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxSprite.TabIndex = 24;
            this.pictureBoxSprite.TabStop = false;
            // 
            // labelSnickers
            // 
            this.labelSnickers.AutoSize = true;
            this.labelSnickers.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSnickers.Location = new System.Drawing.Point(12, 312);
            this.labelSnickers.Name = "labelSnickers";
            this.labelSnickers.Size = new System.Drawing.Size(51, 14);
            this.labelSnickers.TabIndex = 25;
            this.labelSnickers.Text = "Snickers:";
            // 
            // labelMars
            // 
            this.labelMars.AutoSize = true;
            this.labelMars.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMars.Location = new System.Drawing.Point(130, 312);
            this.labelMars.Name = "labelMars";
            this.labelMars.Size = new System.Drawing.Size(35, 14);
            this.labelMars.TabIndex = 26;
            this.labelMars.Text = "Mars:";
            // 
            // labelLays
            // 
            this.labelLays.AutoSize = true;
            this.labelLays.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLays.Location = new System.Drawing.Point(232, 312);
            this.labelLays.Name = "labelLays";
            this.labelLays.Size = new System.Drawing.Size(32, 14);
            this.labelLays.TabIndex = 27;
            this.labelLays.Text = "Lays:";
            // 
            // labelPepsi
            // 
            this.labelPepsi.AutoSize = true;
            this.labelPepsi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPepsi.Location = new System.Drawing.Point(327, 312);
            this.labelPepsi.Name = "labelPepsi";
            this.labelPepsi.Size = new System.Drawing.Size(36, 14);
            this.labelPepsi.TabIndex = 28;
            this.labelPepsi.Text = "Pepsi:";
            // 
            // labelSprite
            // 
            this.labelSprite.AutoSize = true;
            this.labelSprite.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSprite.Location = new System.Drawing.Point(427, 312);
            this.labelSprite.Name = "labelSprite";
            this.labelSprite.Size = new System.Drawing.Size(39, 14);
            this.labelSprite.TabIndex = 29;
            this.labelSprite.Text = "Sprite:";
            // 
            // buttonSecret
            // 
            this.buttonSecret.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSecret.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSecret.Location = new System.Drawing.Point(790, 336);
            this.buttonSecret.Name = "buttonSecret";
            this.buttonSecret.Size = new System.Drawing.Size(168, 31);
            this.buttonSecret.TabIndex = 30;
            this.buttonSecret.Text = "Секретная кнопка";
            this.buttonSecret.UseVisualStyleBackColor = true;
            this.buttonSecret.Click += new System.EventHandler(this.buttonSecret_Click);
            // 
            // textBoxSnickersCount
            // 
            this.textBoxSnickersCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSnickersCount.Location = new System.Drawing.Point(69, 309);
            this.textBoxSnickersCount.Name = "textBoxSnickersCount";
            this.textBoxSnickersCount.ReadOnly = true;
            this.textBoxSnickersCount.Size = new System.Drawing.Size(35, 20);
            this.textBoxSnickersCount.TabIndex = 31;
            // 
            // textBoxMarsCount
            // 
            this.textBoxMarsCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMarsCount.Location = new System.Drawing.Point(169, 309);
            this.textBoxMarsCount.Name = "textBoxMarsCount";
            this.textBoxMarsCount.ReadOnly = true;
            this.textBoxMarsCount.Size = new System.Drawing.Size(35, 20);
            this.textBoxMarsCount.TabIndex = 32;
            // 
            // textBoxLaysCount
            // 
            this.textBoxLaysCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLaysCount.Location = new System.Drawing.Point(270, 309);
            this.textBoxLaysCount.Name = "textBoxLaysCount";
            this.textBoxLaysCount.ReadOnly = true;
            this.textBoxLaysCount.Size = new System.Drawing.Size(35, 20);
            this.textBoxLaysCount.TabIndex = 33;
            // 
            // textBoxSpriteCount
            // 
            this.textBoxSpriteCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSpriteCount.Location = new System.Drawing.Point(477, 309);
            this.textBoxSpriteCount.Name = "textBoxSpriteCount";
            this.textBoxSpriteCount.ReadOnly = true;
            this.textBoxSpriteCount.Size = new System.Drawing.Size(35, 20);
            this.textBoxSpriteCount.TabIndex = 34;
            // 
            // textBoxPepsiCount
            // 
            this.textBoxPepsiCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPepsiCount.Location = new System.Drawing.Point(375, 309);
            this.textBoxPepsiCount.Name = "textBoxPepsiCount";
            this.textBoxPepsiCount.ReadOnly = true;
            this.textBoxPepsiCount.Size = new System.Drawing.Size(35, 20);
            this.textBoxPepsiCount.TabIndex = 35;
            // 
            // buttonLoadCash
            // 
            this.buttonLoadCash.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadCash.Location = new System.Drawing.Point(519, 38);
            this.buttonLoadCash.Name = "buttonLoadCash";
            this.buttonLoadCash.Size = new System.Drawing.Size(79, 36);
            this.buttonLoadCash.TabIndex = 36;
            this.buttonLoadCash.Text = "Загрузить";
            this.buttonLoadCash.UseVisualStyleBackColor = true;
            this.buttonLoadCash.Click += new System.EventHandler(this.buttonLoadCash_Click);
            // 
            // buttonLoadCoins
            // 
            this.buttonLoadCoins.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadCoins.Location = new System.Drawing.Point(519, 128);
            this.buttonLoadCoins.Name = "buttonLoadCoins";
            this.buttonLoadCoins.Size = new System.Drawing.Size(79, 36);
            this.buttonLoadCoins.TabIndex = 37;
            this.buttonLoadCoins.Text = "Загрузить";
            this.buttonLoadCoins.UseVisualStyleBackColor = true;
            this.buttonLoadCoins.Click += new System.EventHandler(this.buttonLoadCoins_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOFF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOFF.Location = new System.Drawing.Point(15, 20);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(128, 34);
            this.buttonOFF.TabIndex = 38;
            this.buttonOFF.Text = "Выключить";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 5000;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 379);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonLoadCoins);
            this.Controls.Add(this.buttonLoadCash);
            this.Controls.Add(this.textBoxPepsiCount);
            this.Controls.Add(this.textBoxSpriteCount);
            this.Controls.Add(this.textBoxLaysCount);
            this.Controls.Add(this.textBoxMarsCount);
            this.Controls.Add(this.textBoxSnickersCount);
            this.Controls.Add(this.buttonSecret);
            this.Controls.Add(this.labelSprite);
            this.Controls.Add(this.labelPepsi);
            this.Controls.Add(this.labelLays);
            this.Controls.Add(this.labelMars);
            this.Controls.Add(this.labelSnickers);
            this.Controls.Add(this.pictureBoxSprite);
            this.Controls.Add(this.pictureBoxPepsi);
            this.Controls.Add(this.pictureBoxLays);
            this.Controls.Add(this.pictureBoxMars);
            this.Controls.Add(this.pictureBoxSnickers);
            this.Controls.Add(this.pictureBoxPr1);
            this.Controls.Add(this.pictureBoxPr2);
            this.Controls.Add(this.pictureBoxPr3);
            this.Controls.Add(this.pictureBoxPr4);
            this.Controls.Add(this.pictureBoxPr5);
            this.Controls.Add(this.buttonGetProduct);
            this.Controls.Add(this.radioButtonPr5);
            this.Controls.Add(this.radioButtonPr4);
            this.Controls.Add(this.radioButtonPr3);
            this.Controls.Add(this.radioButtonPr2);
            this.Controls.Add(this.radioButtonPr1);
            this.Controls.Add(this.labelInfoMoney);
            this.Controls.Add(this.richTextBoxMachineCash);
            this.Controls.Add(this.textBoxCoins);
            this.Controls.Add(this.textBoxCash);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.textBoxRefund);
            this.Controls.Add(this.buttonRefund);
            this.Controls.Add(this.labelRefund);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnickers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPepsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRefund;
        private System.Windows.Forms.Button buttonRefund;
        private System.Windows.Forms.TextBox textBoxRefund;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.TextBox textBoxCoins;
        private System.Windows.Forms.Label labelInfoMoney;
        private System.Windows.Forms.RadioButton radioButtonPr1;
        private System.Windows.Forms.RadioButton radioButtonPr2;
        private System.Windows.Forms.RadioButton radioButtonPr3;
        private System.Windows.Forms.RadioButton radioButtonPr4;
        private System.Windows.Forms.RadioButton radioButtonPr5;
        private System.Windows.Forms.Button buttonGetProduct;
        private System.Windows.Forms.PictureBox pictureBoxPr5;
        private System.Windows.Forms.PictureBox pictureBoxPr4;
        private System.Windows.Forms.PictureBox pictureBoxPr3;
        private System.Windows.Forms.PictureBox pictureBoxPr2;
        private System.Windows.Forms.PictureBox pictureBoxPr1;
        private System.Windows.Forms.PictureBox pictureBoxSnickers;
        private System.Windows.Forms.PictureBox pictureBoxMars;
        private System.Windows.Forms.PictureBox pictureBoxLays;
        private System.Windows.Forms.PictureBox pictureBoxPepsi;
        private System.Windows.Forms.PictureBox pictureBoxSprite;
        private System.Windows.Forms.Label labelSnickers;
        private System.Windows.Forms.Label labelMars;
        private System.Windows.Forms.Label labelLays;
        private System.Windows.Forms.Label labelPepsi;
        private System.Windows.Forms.Label labelSprite;
        private System.Windows.Forms.Button buttonSecret;
        private System.Windows.Forms.TextBox textBoxSnickersCount;
        private System.Windows.Forms.TextBox textBoxMarsCount;
        private System.Windows.Forms.TextBox textBoxLaysCount;
        private System.Windows.Forms.TextBox textBoxSpriteCount;
        private System.Windows.Forms.TextBox textBoxPepsiCount;
        private System.Windows.Forms.Button buttonLoadCash;
        private System.Windows.Forms.Button buttonLoadCoins;
        private System.Windows.Forms.Button buttonOFF;
        public System.Windows.Forms.RichTextBox richTextBoxMachineCash;
        private System.Windows.Forms.Timer timerDelay;
    }
}

