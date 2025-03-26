namespace Prefixovy_Strom_Trie
{
    partial class PrefixovyStrom
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.textBoxPrefixSearch = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBoxPrefixAdd = new System.Windows.Forms.TextBox();
            this.textBoxDataAdd = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrefixDelete = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linearSearchButton = new System.Windows.Forms.Button();
            this.textBoxLinearSearch = new System.Windows.Forms.TextBox();
            this.buttonListBox = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxTrie = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadButton.Location = new System.Drawing.Point(13, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(193, 57);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Načíst data ze souboru";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // textBoxPrefixSearch
            // 
            this.textBoxPrefixSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrefixSearch.Location = new System.Drawing.Point(13, 153);
            this.textBoxPrefixSearch.Name = "textBoxPrefixSearch";
            this.textBoxPrefixSearch.Size = new System.Drawing.Size(191, 24);
            this.textBoxPrefixSearch.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxResult.Location = new System.Drawing.Point(210, 153);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(386, 24);
            this.textBoxResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zadej vyhledáváný prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(210, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Výpis";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.Location = new System.Drawing.Point(12, 183);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(126, 35);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Vyhledat";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textBoxPrefixAdd
            // 
            this.textBoxPrefixAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrefixAdd.Location = new System.Drawing.Point(13, 349);
            this.textBoxPrefixAdd.Name = "textBoxPrefixAdd";
            this.textBoxPrefixAdd.Size = new System.Drawing.Size(125, 24);
            this.textBoxPrefixAdd.TabIndex = 6;
            // 
            // textBoxDataAdd
            // 
            this.textBoxDataAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDataAdd.Location = new System.Drawing.Point(144, 349);
            this.textBoxDataAdd.Name = "textBoxDataAdd";
            this.textBoxDataAdd.Size = new System.Drawing.Size(164, 24);
            this.textBoxDataAdd.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(13, 379);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 63);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Přidat/Upravit";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prefix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(141, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // textBoxPrefixDelete
            // 
            this.textBoxPrefixDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrefixDelete.Location = new System.Drawing.Point(331, 349);
            this.textBoxPrefixDelete.Name = "textBoxPrefixDelete";
            this.textBoxPrefixDelete.Size = new System.Drawing.Size(158, 24);
            this.textBoxPrefixDelete.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(331, 379);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(158, 35);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Odstranit";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(328, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prefix pro odstranění";
            // 
            // linearSearchButton
            // 
            this.linearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linearSearchButton.Location = new System.Drawing.Point(720, 42);
            this.linearSearchButton.Name = "linearSearchButton";
            this.linearSearchButton.Size = new System.Drawing.Size(218, 57);
            this.linearSearchButton.TabIndex = 14;
            this.linearSearchButton.Text = "Vyhledat - Linear Search";
            this.linearSearchButton.UseVisualStyleBackColor = true;
            this.linearSearchButton.Click += new System.EventHandler(this.linearSearchButton_Click);
            // 
            // textBoxLinearSearch
            // 
            this.textBoxLinearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLinearSearch.Location = new System.Drawing.Point(720, 12);
            this.textBoxLinearSearch.Name = "textBoxLinearSearch";
            this.textBoxLinearSearch.Size = new System.Drawing.Size(218, 24);
            this.textBoxLinearSearch.TabIndex = 15;
            // 
            // buttonListBox
            // 
            this.buttonListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonListBox.Location = new System.Drawing.Point(602, 379);
            this.buttonListBox.Name = "buttonListBox";
            this.buttonListBox.Size = new System.Drawing.Size(336, 35);
            this.buttonListBox.TabIndex = 17;
            this.buttonListBox.Text = "Vypis stromu";
            this.buttonListBox.UseVisualStyleBackColor = true;
            this.buttonListBox.Click += new System.EventHandler(this.buttonListBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxTrie
            // 
            this.textBoxTrie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTrie.Location = new System.Drawing.Point(602, 106);
            this.textBoxTrie.MaxLength = 0;
            this.textBoxTrie.Multiline = true;
            this.textBoxTrie.Name = "textBoxTrie";
            this.textBoxTrie.Size = new System.Drawing.Size(336, 267);
            this.textBoxTrie.TabIndex = 18;
            // 
            // PrefixovyStrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.textBoxTrie);
            this.Controls.Add(this.buttonListBox);
            this.Controls.Add(this.textBoxLinearSearch);
            this.Controls.Add(this.linearSearchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.textBoxPrefixDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBoxDataAdd);
            this.Controls.Add(this.textBoxPrefixAdd);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxPrefixSearch);
            this.Controls.Add(this.loadButton);
            this.Name = "PrefixovyStrom";
            this.Text = "Prefixový strom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox textBoxPrefixSearch;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBoxPrefixAdd;
        private System.Windows.Forms.TextBox textBoxDataAdd;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrefixDelete;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button linearSearchButton;
        private System.Windows.Forms.TextBox textBoxLinearSearch;
        private System.Windows.Forms.Button buttonListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxTrie;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

