﻿namespace TrieWindowsFormsApp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtNewPrefix = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRemovePrefix = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.txtAllData = new System.Windows.Forms.TextBox();
            this.buttonLinear = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "nacteni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "vyhledani";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 20);
            this.textBox2.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtNewPrefix
            // 
            this.txtNewPrefix.Location = new System.Drawing.Point(12, 287);
            this.txtNewPrefix.Name = "txtNewPrefix";
            this.txtNewPrefix.Size = new System.Drawing.Size(100, 20);
            this.txtNewPrefix.TabIndex = 4;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(119, 287);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 20);
            this.txtNewName.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Přidat prefix";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRemovePrefix
            // 
            this.txtRemovePrefix.Location = new System.Drawing.Point(372, 287);
            this.txtRemovePrefix.Name = "txtRemovePrefix";
            this.txtRemovePrefix.Size = new System.Drawing.Size(100, 20);
            this.txtRemovePrefix.TabIndex = 7;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(372, 314);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Odstranit prefix";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(543, 11);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(112, 23);
            this.btnShowData.TabIndex = 9;
            this.btnShowData.Text = "Vypsat prefixy";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // txtAllData
            // 
            this.txtAllData.Location = new System.Drawing.Point(543, 40);
            this.txtAllData.Multiline = true;
            this.txtAllData.Name = "txtAllData";
            this.txtAllData.Size = new System.Drawing.Size(245, 208);
            this.txtAllData.TabIndex = 10;
            // 
            // buttonLinear
            // 
            this.buttonLinear.Location = new System.Drawing.Point(664, 386);
            this.buttonLinear.Name = "buttonLinear";
            this.buttonLinear.Size = new System.Drawing.Size(124, 23);
            this.buttonLinear.TabIndex = 11;
            this.buttonLinear.Text = "Vyhledat - Linearni";
            this.buttonLinear.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(664, 418);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonLinear);
            this.Controls.Add(this.txtAllData);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtRemovePrefix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtNewPrefix);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtNewPrefix;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRemovePrefix;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.TextBox txtAllData;
        private System.Windows.Forms.Button buttonLinear;
        private System.Windows.Forms.TextBox textBox3;
    }
}

