namespace PerfectTablesTopperReturns
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAddReturn = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbDesign = new System.Windows.Forms.ComboBox();
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.Label();
            this.txtDesign = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.Label();
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.Label();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.txtSearchReturns = new System.Windows.Forms.Label();
            this.numNumberS = new System.Windows.Forms.NumericUpDown();
            this.txtNumberS = new System.Windows.Forms.Label();
            this.txtColourS = new System.Windows.Forms.Label();
            this.txtDesignS = new System.Windows.Forms.Label();
            this.txtSizeS = new System.Windows.Forms.Label();
            this.cmbColourS = new System.Windows.Forms.ComboBox();
            this.cmbDesignS = new System.Windows.Forms.ComboBox();
            this.cmbSizeS = new System.Windows.Forms.ComboBox();
            this.dataFound = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSearchSize = new System.Windows.Forms.Button();
            this.btnSearchDesign = new System.Windows.Forms.Button();
            this.btnSearchColour = new System.Windows.Forms.Button();
            this.btnSearchNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFound)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddReturn
            // 
            this.txtAddReturn.AutoSize = true;
            this.txtAddReturn.Location = new System.Drawing.Point(5, 175);
            this.txtAddReturn.Name = "txtAddReturn";
            this.txtAddReturn.Size = new System.Drawing.Size(73, 15);
            this.txtAddReturn.TabIndex = 0;
            this.txtAddReturn.Text = "Add a return";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "6 x 3.5cm Tall",
            "5cm Tall",
            "7cm Tall",
            "10cm Tall",
            "6 x 5-6cm Wide",
            "12cm Wide",
            "15cm Wide"});
            this.cmbSize.Location = new System.Drawing.Point(61, 193);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 23);
            this.cmbSize.TabIndex = 1;
            // 
            // cmbDesign
            // 
            this.cmbDesign.FormattingEnabled = true;
            this.cmbDesign.Items.AddRange(new object[] {
            "Block",
            "Bold",
            "Bubble",
            "Curly",
            "Groovy",
            "Ornate",
            "Crown Curly"});
            this.cmbDesign.Location = new System.Drawing.Point(61, 222);
            this.cmbDesign.Name = "cmbDesign";
            this.cmbDesign.Size = new System.Drawing.Size(121, 23);
            this.cmbDesign.TabIndex = 2;
            // 
            // cmbColour
            // 
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Items.AddRange(new object[] {
            "Pure White ST046",
            "White/Iridescent ST028",
            "Ivory ST048",
            "Champagne ST040",
            "Gold ST035",
            "Silver ST034",
            "Pewter ST042",
            "Brown ST049",
            "Black ST036",
            "Rose Gold ST043",
            "Pale Pink ST029",
            "Rose Pink ST039",
            "Cerise ST037",
            "Neon Pink ST058",
            "Lilac ST031",
            "Purple ST038",
            "Bright Yellow ST054",
            "Peach ST059",
            "Orange ST050",
            "Red ST032",
            "Burgundy ST053",
            "Icy Blue ST047",
            "Blue ST030",
            "Celeste ST056",
            "Sapphire ST051",
            "Royal Blue ST060",
            "Navy ST041",
            "Mint ST057",
            "Light Green ST045",
            "Green ST033",
            "Turquoise ST044",
            "Bright Rainbow ST055",
            "Pastel Mix ST052",
            "Silver Mirror ST071",
            "Gold Mirror ST070",
            "Red Mirror ST073",
            "Green Mirror ST072",
            "Rose Gold Mirror ST074",
            "Pink Mirror ST075"});
            this.cmbColour.Location = new System.Drawing.Point(61, 251);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(121, 23);
            this.cmbColour.TabIndex = 3;
            // 
            // txtSize
            // 
            this.txtSize.AutoSize = true;
            this.txtSize.Location = new System.Drawing.Point(28, 196);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(27, 15);
            this.txtSize.TabIndex = 4;
            this.txtSize.Text = "Size";
            // 
            // txtDesign
            // 
            this.txtDesign.AutoSize = true;
            this.txtDesign.Location = new System.Drawing.Point(17, 225);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(43, 15);
            this.txtDesign.TabIndex = 5;
            this.txtDesign.Text = "Design";
            // 
            // txtColour
            // 
            this.txtColour.AutoSize = true;
            this.txtColour.Location = new System.Drawing.Point(13, 254);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(43, 15);
            this.txtColour.TabIndex = 6;
            this.txtColour.Text = "Colour";
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.Location = new System.Drawing.Point(62, 310);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(120, 23);
            this.btnAddReturn.TabIndex = 7;
            this.btnAddReturn.Text = "Add Return";
            this.btnAddReturn.UseVisualStyleBackColor = true;
            this.btnAddReturn.Click += new System.EventHandler(this.btnAddReturn_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.AutoSize = true;
            this.txtNumber.Location = new System.Drawing.Point(5, 282);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(51, 15);
            this.txtNumber.TabIndex = 8;
            this.txtNumber.Text = "Number";
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(62, 280);
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(120, 23);
            this.numNumber.TabIndex = 10;
            // 
            // txtSearchReturns
            // 
            this.txtSearchReturns.AutoSize = true;
            this.txtSearchReturns.Location = new System.Drawing.Point(5, 32);
            this.txtSearchReturns.Name = "txtSearchReturns";
            this.txtSearchReturns.Size = new System.Drawing.Size(102, 15);
            this.txtSearchReturns.TabIndex = 11;
            this.txtSearchReturns.Text = "Search the returns";
            // 
            // numNumberS
            // 
            this.numNumberS.Location = new System.Drawing.Point(62, 137);
            this.numNumberS.Name = "numNumberS";
            this.numNumberS.Size = new System.Drawing.Size(120, 23);
            this.numNumberS.TabIndex = 20;
            // 
            // txtNumberS
            // 
            this.txtNumberS.AutoSize = true;
            this.txtNumberS.Location = new System.Drawing.Point(5, 139);
            this.txtNumberS.Name = "txtNumberS";
            this.txtNumberS.Size = new System.Drawing.Size(51, 15);
            this.txtNumberS.TabIndex = 19;
            this.txtNumberS.Text = "Number";
            // 
            // txtColourS
            // 
            this.txtColourS.AutoSize = true;
            this.txtColourS.Location = new System.Drawing.Point(13, 111);
            this.txtColourS.Name = "txtColourS";
            this.txtColourS.Size = new System.Drawing.Size(43, 15);
            this.txtColourS.TabIndex = 17;
            this.txtColourS.Text = "Colour";
            // 
            // txtDesignS
            // 
            this.txtDesignS.AutoSize = true;
            this.txtDesignS.Location = new System.Drawing.Point(17, 82);
            this.txtDesignS.Name = "txtDesignS";
            this.txtDesignS.Size = new System.Drawing.Size(43, 15);
            this.txtDesignS.TabIndex = 16;
            this.txtDesignS.Text = "Design";
            // 
            // txtSizeS
            // 
            this.txtSizeS.AutoSize = true;
            this.txtSizeS.Location = new System.Drawing.Point(28, 53);
            this.txtSizeS.Name = "txtSizeS";
            this.txtSizeS.Size = new System.Drawing.Size(27, 15);
            this.txtSizeS.TabIndex = 15;
            this.txtSizeS.Text = "Size";
            // 
            // cmbColourS
            // 
            this.cmbColourS.FormattingEnabled = true;
            this.cmbColourS.Items.AddRange(new object[] {
            "Pure White ST046",
            "White/Iridescent ST028",
            "Ivory ST048",
            "Champagne ST040",
            "Gold ST035",
            "Silver ST034",
            "Pewter ST042",
            "Brown ST049",
            "Black ST036",
            "Rose Gold ST043",
            "Pale Pink ST029",
            "Rose Pink ST039",
            "Cerise ST037",
            "Neon Pink ST058",
            "Lilac ST031",
            "Purple ST038",
            "Bright Yellow ST054",
            "Peach ST059",
            "Orange ST050",
            "Red ST032",
            "Burgundy ST053",
            "Icy Blue ST047",
            "Blue ST030",
            "Celeste ST056",
            "Sapphire ST051",
            "Royal Blue ST060",
            "Navy ST041",
            "Mint ST057",
            "Light Green ST045",
            "Green ST033",
            "Turquoise ST044",
            "Bright Rainbow ST055",
            "Pastel Mix ST052",
            "Silver Mirror ST071",
            "Gold Mirror ST070",
            "Red Mirror ST073",
            "Green Mirror ST072",
            "Rose Gold Mirror ST074",
            "Pink Mirror ST075"});
            this.cmbColourS.Location = new System.Drawing.Point(61, 108);
            this.cmbColourS.Name = "cmbColourS";
            this.cmbColourS.Size = new System.Drawing.Size(121, 23);
            this.cmbColourS.TabIndex = 14;
            // 
            // cmbDesignS
            // 
            this.cmbDesignS.FormattingEnabled = true;
            this.cmbDesignS.Items.AddRange(new object[] {
            "Block",
            "Bold",
            "Bubble",
            "Curly",
            "Groovy",
            "Ornate",
            "Crown Curly"});
            this.cmbDesignS.Location = new System.Drawing.Point(61, 79);
            this.cmbDesignS.Name = "cmbDesignS";
            this.cmbDesignS.Size = new System.Drawing.Size(121, 23);
            this.cmbDesignS.TabIndex = 13;
            // 
            // cmbSizeS
            // 
            this.cmbSizeS.FormattingEnabled = true;
            this.cmbSizeS.Items.AddRange(new object[] {
            "6 x 3.5cm Tall",
            "5cm Tall",
            "7cm Tall",
            "10cm Tall",
            "6 x 5-6cm Wide",
            "12cm Wide",
            "15cm Wide"});
            this.cmbSizeS.Location = new System.Drawing.Point(61, 50);
            this.cmbSizeS.Name = "cmbSizeS";
            this.cmbSizeS.Size = new System.Drawing.Size(121, 23);
            this.cmbSizeS.TabIndex = 12;
            // 
            // dataFound
            // 
            this.dataFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFound.Location = new System.Drawing.Point(305, 29);
            this.dataFound.Name = "dataFound";
            this.dataFound.RowTemplate.Height = 25;
            this.dataFound.Size = new System.Drawing.Size(470, 307);
            this.dataFound.TabIndex = 21;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(658, 342);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(117, 23);
            this.btnViewAll.TabIndex = 22;
            this.btnViewAll.Text = "View All Returns";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnSearchSize
            // 
            this.btnSearchSize.Location = new System.Drawing.Point(188, 50);
            this.btnSearchSize.Name = "btnSearchSize";
            this.btnSearchSize.Size = new System.Drawing.Size(100, 23);
            this.btnSearchSize.TabIndex = 23;
            this.btnSearchSize.Text = "Search Size";
            this.btnSearchSize.UseVisualStyleBackColor = true;
            this.btnSearchSize.Click += new System.EventHandler(this.btnSearchSize_Click);
            // 
            // btnSearchDesign
            // 
            this.btnSearchDesign.Location = new System.Drawing.Point(188, 79);
            this.btnSearchDesign.Name = "btnSearchDesign";
            this.btnSearchDesign.Size = new System.Drawing.Size(100, 23);
            this.btnSearchDesign.TabIndex = 24;
            this.btnSearchDesign.Text = "Search Design";
            this.btnSearchDesign.UseVisualStyleBackColor = true;
            this.btnSearchDesign.Click += new System.EventHandler(this.btnSearchDesign_Click);
            // 
            // btnSearchColour
            // 
            this.btnSearchColour.Location = new System.Drawing.Point(188, 108);
            this.btnSearchColour.Name = "btnSearchColour";
            this.btnSearchColour.Size = new System.Drawing.Size(100, 23);
            this.btnSearchColour.TabIndex = 25;
            this.btnSearchColour.Text = "Search Colour";
            this.btnSearchColour.UseVisualStyleBackColor = true;
            // 
            // btnSearchNumber
            // 
            this.btnSearchNumber.Location = new System.Drawing.Point(188, 137);
            this.btnSearchNumber.Name = "btnSearchNumber";
            this.btnSearchNumber.Size = new System.Drawing.Size(100, 23);
            this.btnSearchNumber.TabIndex = 26;
            this.btnSearchNumber.Text = "Search Number";
            this.btnSearchNumber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 373);
            this.Controls.Add(this.btnSearchNumber);
            this.Controls.Add(this.btnSearchColour);
            this.Controls.Add(this.btnSearchDesign);
            this.Controls.Add(this.btnSearchSize);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dataFound);
            this.Controls.Add(this.numNumberS);
            this.Controls.Add(this.txtNumberS);
            this.Controls.Add(this.txtColourS);
            this.Controls.Add(this.txtDesignS);
            this.Controls.Add(this.txtSizeS);
            this.Controls.Add(this.cmbColourS);
            this.Controls.Add(this.cmbDesignS);
            this.Controls.Add(this.cmbSizeS);
            this.Controls.Add(this.txtSearchReturns);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnAddReturn);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbColour);
            this.Controls.Add(this.cmbDesign);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.txtAddReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Perfect Tables Topper Returns";
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtAddReturn;
        private ComboBox cmbSize;
        private ComboBox cmbDesign;
        private ComboBox cmbColour;
        private Label txtSize;
        private Label txtDesign;
        private Label txtColour;
        private Button btnAddReturn;
        private Label txtNumber;
        private NumericUpDown numNumber;
        private Label txtSearchReturns;
        private NumericUpDown numNumberS;
        private Label txtNumberS;
        private Label txtColourS;
        private Label txtDesignS;
        private Label txtSizeS;
        private ComboBox cmbColourS;
        private ComboBox cmbDesignS;
        private ComboBox cmbSizeS;
        private DataGridView dataFound;
        private Button btnViewAll;
        private Button btnSearchSize;
        private Button btnSearchDesign;
        private Button btnSearchColour;
        private Button btnSearchNumber;
    }
}