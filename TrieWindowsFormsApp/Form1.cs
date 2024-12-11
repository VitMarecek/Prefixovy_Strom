using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TrieWindowsFormsApp.Form1;
using System.IO;

namespace TrieWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Trie trie = new Trie();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Vyberte soubor"
            };
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    foreach (var line in File.ReadAllLines(openFileDialog.FileName))
                    {
                        var parts = line.Split(new[] { ' ' }, 2); 
                        if (parts.Length == 2)
                        {
                            trie.Insert(parts[0], parts[1]);
                        }
                    }
                    MessageBox.Show("Data byla načtena úspěšně.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo k chybě při načítání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string prefix = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(prefix))
            {
                MessageBox.Show("Zadejte prosím prefix.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> results = trie.Search(prefix);
            if (results.Count > 0)
            {
                textBox2.Text = string.Join(Environment.NewLine, results); 
            }
            else
            {
                textBox2.Text = "Žádné odpovídající prefixy nenalezeny.";
            }
        }
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children { get; set; } = new Dictionary<char, TrieNode>();

            public string Name { get; set; } = null; 
        }

        public class Trie
        {
            private TrieNode root;

            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string prefix, string name)
            {
                var current = root;

                foreach (char ch in prefix)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        current.Children[ch] = new TrieNode();
                    }
                    current = current.Children[ch];
                }
                current.Name = name; 
            }

            public List<string> Search(string prefix)
            {
                var current = root;

                
                foreach (char ch in prefix)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        return new List<string>(); // Prefix není v trie
                    }
                    current = current.Children[ch];
                }

                
                var results = new List<string>();
                CollectAllNames(current, results);
                return results;
            }
            private void CollectAllNames(TrieNode node, List<string> results)
            {
                if (node == null)
                    return;

                
                if (node.Name != null)
                {
                    results.Add(node.Name);
                }

                
                foreach (var child in node.Children.Values)
                {
                    CollectAllNames(child, results);
                }
            }
        }
    }
}
