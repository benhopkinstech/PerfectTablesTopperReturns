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
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddReturn
            // 
            this.txtAddReturn.AutoSize = true;
            this.txtAddReturn.Location = new System.Drawing.Point(12, 179);
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
            this.cmbSize.Location = new System.Drawing.Point(60, 197);
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
            this.cmbDesign.Location = new System.Drawing.Point(60, 226);
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
            this.cmbColour.Location = new System.Drawing.Point(60, 255);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(121, 23);
            this.cmbColour.TabIndex = 3;
            // 
            // txtSize
            // 
            this.txtSize.AutoSize = true;
            this.txtSize.Location = new System.Drawing.Point(27, 200);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(27, 15);
            this.txtSize.TabIndex = 4;
            this.txtSize.Text = "Size";
            // 
            // txtDesign
            // 
            this.txtDesign.AutoSize = true;
            this.txtDesign.Location = new System.Drawing.Point(16, 229);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(43, 15);
            this.txtDesign.TabIndex = 5;
            this.txtDesign.Text = "Design";
            // 
            // txtColour
            // 
            this.txtColour.AutoSize = true;
            this.txtColour.Location = new System.Drawing.Point(12, 258);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(43, 15);
            this.txtColour.TabIndex = 6;
            this.txtColour.Text = "Colour";
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.Location = new System.Drawing.Point(106, 313);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(75, 23);
            this.btnAddReturn.TabIndex = 7;
            this.btnAddReturn.Text = "Add Return";
            this.btnAddReturn.UseVisualStyleBackColor = true;
            this.btnAddReturn.Click += new System.EventHandler(this.btnAddReturn_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.AutoSize = true;
            this.txtNumber.Location = new System.Drawing.Point(4, 286);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(51, 15);
            this.txtNumber.TabIndex = 8;
            this.txtNumber.Text = "Number";
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(61, 284);
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(120, 23);
            this.numNumber.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}