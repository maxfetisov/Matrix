namespace Matrix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MatrixA = new System.Windows.Forms.RichTextBox();
            this.MatrixB = new System.Windows.Forms.RichTextBox();
            this.MatrixRez = new System.Windows.Forms.RichTextBox();
            this.labelMatrixA = new System.Windows.Forms.Label();
            this.labelMatrixB = new System.Windows.Forms.Label();
            this.labelMatrixRez = new System.Windows.Forms.Label();
            this.labelRavno = new System.Windows.Forms.Label();
            this.buttonTransA = new System.Windows.Forms.Button();
            this.buttonTransB = new System.Windows.Forms.Button();
            this.buttonTransRez = new System.Windows.Forms.Button();
            this.buttonRangA = new System.Windows.Forms.Button();
            this.buttonRangB = new System.Windows.Forms.Button();
            this.buttonRangRez = new System.Windows.Forms.Button();
            this.textBoxRangA = new System.Windows.Forms.TextBox();
            this.textBoxRangB = new System.Windows.Forms.TextBox();
            this.textBoxRangRez = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonProA = new System.Windows.Forms.Button();
            this.buttonProB = new System.Windows.Forms.Button();
            this.buttonProRez = new System.Windows.Forms.Button();
            this.numericUpDownProA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownProB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownProRez = new System.Windows.Forms.NumericUpDown();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonClearA = new System.Windows.Forms.Button();
            this.buttonClearB = new System.Windows.Forms.Button();
            this.buttonClearRez = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonPro = new System.Windows.Forms.Button();
            this.buttonRaz = new System.Windows.Forms.Button();
            this.textBoxSizeA2 = new System.Windows.Forms.TextBox();
            this.textBoxSizeB2 = new System.Windows.Forms.TextBox();
            this.textBoxSizeRez2 = new System.Windows.Forms.TextBox();
            this.textBoxSizeRez1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownA1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProRez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB2)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixA
            // 
            this.MatrixA.Location = new System.Drawing.Point(22, 46);
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.Size = new System.Drawing.Size(249, 176);
            this.MatrixA.TabIndex = 0;
            this.MatrixA.Text = "";
            this.MatrixA.TextChanged += new System.EventHandler(this.MatrixA_TextChanged);
            // 
            // MatrixB
            // 
            this.MatrixB.Location = new System.Drawing.Point(440, 46);
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.Size = new System.Drawing.Size(246, 176);
            this.MatrixB.TabIndex = 1;
            this.MatrixB.Text = "";
            this.MatrixB.TextChanged += new System.EventHandler(this.MatrixB_TextChanged);
            // 
            // MatrixRez
            // 
            this.MatrixRez.Location = new System.Drawing.Point(858, 46);
            this.MatrixRez.Name = "MatrixRez";
            this.MatrixRez.ReadOnly = true;
            this.MatrixRez.Size = new System.Drawing.Size(245, 176);
            this.MatrixRez.TabIndex = 2;
            this.MatrixRez.Text = "";
            this.MatrixRez.TextChanged += new System.EventHandler(this.MatrixRez_TextChanged);
            // 
            // labelMatrixA
            // 
            this.labelMatrixA.AutoSize = true;
            this.labelMatrixA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMatrixA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrixA.Location = new System.Drawing.Point(18, 10);
            this.labelMatrixA.Name = "labelMatrixA";
            this.labelMatrixA.Size = new System.Drawing.Size(107, 22);
            this.labelMatrixA.TabIndex = 3;
            this.labelMatrixA.Text = "Матрица А:";
            // 
            // labelMatrixB
            // 
            this.labelMatrixB.AutoSize = true;
            this.labelMatrixB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMatrixB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrixB.Location = new System.Drawing.Point(436, 10);
            this.labelMatrixB.Name = "labelMatrixB";
            this.labelMatrixB.Size = new System.Drawing.Size(106, 22);
            this.labelMatrixB.TabIndex = 4;
            this.labelMatrixB.Text = "Матрица В:";
            // 
            // labelMatrixRez
            // 
            this.labelMatrixRez.AutoSize = true;
            this.labelMatrixRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMatrixRez.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrixRez.Location = new System.Drawing.Point(854, 10);
            this.labelMatrixRez.Name = "labelMatrixRez";
            this.labelMatrixRez.Size = new System.Drawing.Size(97, 22);
            this.labelMatrixRez.TabIndex = 5;
            this.labelMatrixRez.Text = "Результат:";
            // 
            // labelRavno
            // 
            this.labelRavno.AutoSize = true;
            this.labelRavno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRavno.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRavno.Location = new System.Drawing.Point(735, 82);
            this.labelRavno.Name = "labelRavno";
            this.labelRavno.Size = new System.Drawing.Size(86, 86);
            this.labelRavno.TabIndex = 6;
            this.labelRavno.Text = "=";
            // 
            // buttonTransA
            // 
            this.buttonTransA.Enabled = false;
            this.buttonTransA.Location = new System.Drawing.Point(21, 258);
            this.buttonTransA.Name = "buttonTransA";
            this.buttonTransA.Size = new System.Drawing.Size(129, 23);
            this.buttonTransA.TabIndex = 7;
            this.buttonTransA.Text = "Транспонировать";
            this.buttonTransA.UseVisualStyleBackColor = true;
            this.buttonTransA.Click += new System.EventHandler(this.buttonTransA_Click);
            // 
            // buttonTransB
            // 
            this.buttonTransB.Enabled = false;
            this.buttonTransB.Location = new System.Drawing.Point(439, 258);
            this.buttonTransB.Name = "buttonTransB";
            this.buttonTransB.Size = new System.Drawing.Size(129, 23);
            this.buttonTransB.TabIndex = 8;
            this.buttonTransB.Text = "Транспонировать";
            this.buttonTransB.UseVisualStyleBackColor = true;
            this.buttonTransB.Click += new System.EventHandler(this.buttonTransB_Click);
            // 
            // buttonTransRez
            // 
            this.buttonTransRez.Enabled = false;
            this.buttonTransRez.Location = new System.Drawing.Point(857, 258);
            this.buttonTransRez.Name = "buttonTransRez";
            this.buttonTransRez.Size = new System.Drawing.Size(129, 23);
            this.buttonTransRez.TabIndex = 9;
            this.buttonTransRez.Text = "Транспонировать";
            this.buttonTransRez.UseVisualStyleBackColor = true;
            this.buttonTransRez.Click += new System.EventHandler(this.buttonTransRez_Click);
            // 
            // buttonRangA
            // 
            this.buttonRangA.Enabled = false;
            this.buttonRangA.Location = new System.Drawing.Point(21, 287);
            this.buttonRangA.Name = "buttonRangA";
            this.buttonRangA.Size = new System.Drawing.Size(129, 23);
            this.buttonRangA.TabIndex = 10;
            this.buttonRangA.Text = "Ранг";
            this.buttonRangA.UseVisualStyleBackColor = true;
            this.buttonRangA.Click += new System.EventHandler(this.buttonRangA_Click);
            // 
            // buttonRangB
            // 
            this.buttonRangB.Enabled = false;
            this.buttonRangB.Location = new System.Drawing.Point(439, 287);
            this.buttonRangB.Name = "buttonRangB";
            this.buttonRangB.Size = new System.Drawing.Size(129, 23);
            this.buttonRangB.TabIndex = 11;
            this.buttonRangB.Text = "Ранг";
            this.buttonRangB.UseVisualStyleBackColor = true;
            this.buttonRangB.Click += new System.EventHandler(this.buttonRangB_Click);
            // 
            // buttonRangRez
            // 
            this.buttonRangRez.Enabled = false;
            this.buttonRangRez.Location = new System.Drawing.Point(857, 287);
            this.buttonRangRez.Name = "buttonRangRez";
            this.buttonRangRez.Size = new System.Drawing.Size(129, 23);
            this.buttonRangRez.TabIndex = 12;
            this.buttonRangRez.Text = "Ранг";
            this.buttonRangRez.UseVisualStyleBackColor = true;
            this.buttonRangRez.Click += new System.EventHandler(this.buttonRangRez_Click);
            // 
            // textBoxRangA
            // 
            this.textBoxRangA.Location = new System.Drawing.Point(195, 287);
            this.textBoxRangA.Name = "textBoxRangA";
            this.textBoxRangA.ReadOnly = true;
            this.textBoxRangA.Size = new System.Drawing.Size(75, 20);
            this.textBoxRangA.TabIndex = 13;
            // 
            // textBoxRangB
            // 
            this.textBoxRangB.Location = new System.Drawing.Point(610, 287);
            this.textBoxRangB.Name = "textBoxRangB";
            this.textBoxRangB.ReadOnly = true;
            this.textBoxRangB.Size = new System.Drawing.Size(75, 20);
            this.textBoxRangB.TabIndex = 14;
            // 
            // textBoxRangRez
            // 
            this.textBoxRangRez.Location = new System.Drawing.Point(1027, 287);
            this.textBoxRangRez.Name = "textBoxRangRez";
            this.textBoxRangRez.ReadOnly = true;
            this.textBoxRangRez.Size = new System.Drawing.Size(75, 20);
            this.textBoxRangRez.TabIndex = 15;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 385);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1121, 22);
            this.statusStrip.TabIndex = 16;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonProA
            // 
            this.buttonProA.Enabled = false;
            this.buttonProA.Location = new System.Drawing.Point(21, 316);
            this.buttonProA.Name = "buttonProA";
            this.buttonProA.Size = new System.Drawing.Size(129, 23);
            this.buttonProA.TabIndex = 17;
            this.buttonProA.Text = "Умножить";
            this.buttonProA.UseVisualStyleBackColor = true;
            this.buttonProA.Click += new System.EventHandler(this.buttonProA_Click);
            // 
            // buttonProB
            // 
            this.buttonProB.Enabled = false;
            this.buttonProB.Location = new System.Drawing.Point(439, 316);
            this.buttonProB.Name = "buttonProB";
            this.buttonProB.Size = new System.Drawing.Size(129, 23);
            this.buttonProB.TabIndex = 18;
            this.buttonProB.Text = "Умножить";
            this.buttonProB.UseVisualStyleBackColor = true;
            this.buttonProB.Click += new System.EventHandler(this.buttonProB_Click);
            // 
            // buttonProRez
            // 
            this.buttonProRez.Enabled = false;
            this.buttonProRez.Location = new System.Drawing.Point(857, 316);
            this.buttonProRez.Name = "buttonProRez";
            this.buttonProRez.Size = new System.Drawing.Size(129, 23);
            this.buttonProRez.TabIndex = 19;
            this.buttonProRez.Text = "Умножить";
            this.buttonProRez.UseVisualStyleBackColor = true;
            this.buttonProRez.Click += new System.EventHandler(this.buttonProRez_Click);
            // 
            // numericUpDownProA
            // 
            this.numericUpDownProA.DecimalPlaces = 1;
            this.numericUpDownProA.Location = new System.Drawing.Point(195, 319);
            this.numericUpDownProA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownProA.Name = "numericUpDownProA";
            this.numericUpDownProA.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownProA.TabIndex = 20;
            this.numericUpDownProA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownProB
            // 
            this.numericUpDownProB.DecimalPlaces = 1;
            this.numericUpDownProB.Location = new System.Drawing.Point(610, 319);
            this.numericUpDownProB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownProB.Name = "numericUpDownProB";
            this.numericUpDownProB.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownProB.TabIndex = 21;
            this.numericUpDownProB.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownProRez
            // 
            this.numericUpDownProRez.DecimalPlaces = 1;
            this.numericUpDownProRez.Location = new System.Drawing.Point(1027, 319);
            this.numericUpDownProRez.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownProRez.Name = "numericUpDownProRez";
            this.numericUpDownProRez.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownProRez.TabIndex = 22;
            this.numericUpDownProRez.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonSum
            // 
            this.buttonSum.Enabled = false;
            this.buttonSum.Location = new System.Drawing.Point(320, 134);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 23);
            this.buttonSum.TabIndex = 23;
            this.buttonSum.Text = "А + В";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonClearA
            // 
            this.buttonClearA.Enabled = false;
            this.buttonClearA.Location = new System.Drawing.Point(195, 258);
            this.buttonClearA.Name = "buttonClearA";
            this.buttonClearA.Size = new System.Drawing.Size(75, 23);
            this.buttonClearA.TabIndex = 26;
            this.buttonClearA.Text = "Очистить";
            this.buttonClearA.UseVisualStyleBackColor = true;
            this.buttonClearA.Click += new System.EventHandler(this.buttonClearA_Click);
            // 
            // buttonClearB
            // 
            this.buttonClearB.Enabled = false;
            this.buttonClearB.Location = new System.Drawing.Point(610, 258);
            this.buttonClearB.Name = "buttonClearB";
            this.buttonClearB.Size = new System.Drawing.Size(75, 23);
            this.buttonClearB.TabIndex = 27;
            this.buttonClearB.Text = "Очистить";
            this.buttonClearB.UseVisualStyleBackColor = true;
            this.buttonClearB.Click += new System.EventHandler(this.buttonClearB_Click);
            // 
            // buttonClearRez
            // 
            this.buttonClearRez.Enabled = false;
            this.buttonClearRez.Location = new System.Drawing.Point(1027, 258);
            this.buttonClearRez.Name = "buttonClearRez";
            this.buttonClearRez.Size = new System.Drawing.Size(75, 23);
            this.buttonClearRez.TabIndex = 28;
            this.buttonClearRez.Text = "Очистить";
            this.buttonClearRez.UseVisualStyleBackColor = true;
            this.buttonClearRez.Click += new System.EventHandler(this.buttonClearRez_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Enabled = false;
            this.buttonChange.Location = new System.Drawing.Point(320, 76);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 29;
            this.buttonChange.Text = "◁ ▷";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonPro
            // 
            this.buttonPro.Enabled = false;
            this.buttonPro.Location = new System.Drawing.Point(320, 105);
            this.buttonPro.Name = "buttonPro";
            this.buttonPro.Size = new System.Drawing.Size(75, 23);
            this.buttonPro.TabIndex = 30;
            this.buttonPro.Text = "А * В";
            this.buttonPro.UseVisualStyleBackColor = true;
            this.buttonPro.Click += new System.EventHandler(this.buttonPro_Click);
            // 
            // buttonRaz
            // 
            this.buttonRaz.Enabled = false;
            this.buttonRaz.Location = new System.Drawing.Point(320, 163);
            this.buttonRaz.Name = "buttonRaz";
            this.buttonRaz.Size = new System.Drawing.Size(75, 23);
            this.buttonRaz.TabIndex = 31;
            this.buttonRaz.Text = "А - В";
            this.buttonRaz.UseVisualStyleBackColor = true;
            this.buttonRaz.Click += new System.EventHandler(this.buttonRaz_Click);
            // 
            // textBoxSizeA2
            // 
            this.textBoxSizeA2.Location = new System.Drawing.Point(227, 12);
            this.textBoxSizeA2.Name = "textBoxSizeA2";
            this.textBoxSizeA2.ReadOnly = true;
            this.textBoxSizeA2.Size = new System.Drawing.Size(43, 20);
            this.textBoxSizeA2.TabIndex = 33;
            this.textBoxSizeA2.Text = "3";
            // 
            // textBoxSizeB2
            // 
            this.textBoxSizeB2.Location = new System.Drawing.Point(642, 12);
            this.textBoxSizeB2.Name = "textBoxSizeB2";
            this.textBoxSizeB2.ReadOnly = true;
            this.textBoxSizeB2.Size = new System.Drawing.Size(43, 20);
            this.textBoxSizeB2.TabIndex = 35;
            this.textBoxSizeB2.Text = "3";
            // 
            // textBoxSizeRez2
            // 
            this.textBoxSizeRez2.Location = new System.Drawing.Point(1058, 12);
            this.textBoxSizeRez2.Name = "textBoxSizeRez2";
            this.textBoxSizeRez2.ReadOnly = true;
            this.textBoxSizeRez2.Size = new System.Drawing.Size(43, 20);
            this.textBoxSizeRez2.TabIndex = 37;
            // 
            // textBoxSizeRez1
            // 
            this.textBoxSizeRez1.Location = new System.Drawing.Point(984, 12);
            this.textBoxSizeRez1.Name = "textBoxSizeRez1";
            this.textBoxSizeRez1.ReadOnly = true;
            this.textBoxSizeRez1.Size = new System.Drawing.Size(43, 20);
            this.textBoxSizeRez1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(201, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(616, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "х";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1033, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "х";
            // 
            // numericUpDownA1
            // 
            this.numericUpDownA1.Location = new System.Drawing.Point(151, 12);
            this.numericUpDownA1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA1.Name = "numericUpDownA1";
            this.numericUpDownA1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownA1.TabIndex = 41;
            this.numericUpDownA1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownA1.ValueChanged += new System.EventHandler(this.numericUpDownA1_ValueChanged);
            // 
            // numericUpDownB2
            // 
            this.numericUpDownB2.Location = new System.Drawing.Point(567, 12);
            this.numericUpDownB2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB2.Name = "numericUpDownB2";
            this.numericUpDownB2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownB2.TabIndex = 42;
            this.numericUpDownB2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownB2.ValueChanged += new System.EventHandler(this.numericUpDownB2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Продолжить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Продолжить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1121, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownB2);
            this.Controls.Add(this.numericUpDownA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSizeRez2);
            this.Controls.Add(this.textBoxSizeRez1);
            this.Controls.Add(this.textBoxSizeB2);
            this.Controls.Add(this.textBoxSizeA2);
            this.Controls.Add(this.buttonRaz);
            this.Controls.Add(this.buttonPro);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonClearRez);
            this.Controls.Add(this.buttonClearB);
            this.Controls.Add(this.buttonClearA);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.numericUpDownProRez);
            this.Controls.Add(this.numericUpDownProB);
            this.Controls.Add(this.numericUpDownProA);
            this.Controls.Add(this.buttonProRez);
            this.Controls.Add(this.buttonProB);
            this.Controls.Add(this.buttonProA);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBoxRangRez);
            this.Controls.Add(this.textBoxRangB);
            this.Controls.Add(this.textBoxRangA);
            this.Controls.Add(this.buttonRangRez);
            this.Controls.Add(this.buttonRangB);
            this.Controls.Add(this.buttonRangA);
            this.Controls.Add(this.buttonTransRez);
            this.Controls.Add(this.buttonTransB);
            this.Controls.Add(this.buttonTransA);
            this.Controls.Add(this.labelRavno);
            this.Controls.Add(this.labelMatrixRez);
            this.Controls.Add(this.labelMatrixB);
            this.Controls.Add(this.labelMatrixA);
            this.Controls.Add(this.MatrixRez);
            this.Controls.Add(this.MatrixB);
            this.Controls.Add(this.MatrixA);
            this.Name = "Form1";
            this.Text = "Матричный калькулятор";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProRez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MatrixA;
        private System.Windows.Forms.RichTextBox MatrixB;
        private System.Windows.Forms.RichTextBox MatrixRez;
        private System.Windows.Forms.Label labelMatrixA;
        private System.Windows.Forms.Label labelMatrixB;
        private System.Windows.Forms.Label labelMatrixRez;
        private System.Windows.Forms.Label labelRavno;
        private System.Windows.Forms.Button buttonTransA;
        private System.Windows.Forms.Button buttonTransB;
        private System.Windows.Forms.Button buttonTransRez;
        private System.Windows.Forms.Button buttonRangA;
        private System.Windows.Forms.Button buttonRangB;
        private System.Windows.Forms.Button buttonRangRez;
        private System.Windows.Forms.TextBox textBoxRangA;
        private System.Windows.Forms.TextBox textBoxRangB;
        private System.Windows.Forms.TextBox textBoxRangRez;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonProA;
        private System.Windows.Forms.Button buttonProB;
        private System.Windows.Forms.Button buttonProRez;
        private System.Windows.Forms.NumericUpDown numericUpDownProA;
        private System.Windows.Forms.NumericUpDown numericUpDownProB;
        private System.Windows.Forms.NumericUpDown numericUpDownProRez;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonClearA;
        private System.Windows.Forms.Button buttonClearB;
        private System.Windows.Forms.Button buttonClearRez;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonPro;
        private System.Windows.Forms.Button buttonRaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSizeA2;
        private System.Windows.Forms.TextBox textBoxSizeB2;
        private System.Windows.Forms.TextBox textBoxSizeRez2;
        private System.Windows.Forms.TextBox textBoxSizeRez1;
        private System.Windows.Forms.NumericUpDown numericUpDownA1;
        private System.Windows.Forms.NumericUpDown numericUpDownB2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

