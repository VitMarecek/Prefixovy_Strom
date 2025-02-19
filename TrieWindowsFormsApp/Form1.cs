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
        private string sourceFilePath;
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
                    sourceFilePath = openFileDialog.FileName;
                    foreach (var line in File.ReadAllLines(sourceFilePath))
                    {
                        var trimmedLine = line.Trim(); // Oříznutí neviditelných znaků
                        var parts = trimmedLine.Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length == 2)
                        {
                            string prefix = parts[0].Trim(); // Oříznutí prefixu
                            string name = parts[1].Trim();   // Oříznutí jména
                            trie.Insert(prefix, name);
                            Console.WriteLine($"Načten prefix: '{prefix}', Jméno: '{name}'");
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
                        current.Children[ch] = new TrieNode(); // Vytvoření nového uzlu
                    }
                    current = current.Children[ch];
                }

                // Na posledním uzlu uložíme jméno
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

            public List<string> GetAllData()
            {
                List<string> result = new List<string>();
                CollectAllData(root, "", result);
                return result;
            }
            private void CollectAllData(TrieNode node, string currentPrefix, List<string> result)
            {
                if (node.Name != null)
                {
                    result.Add($"{currentPrefix} {node.Name}");
                }

                foreach (var child in node.Children)
                {
                    CollectAllData(child.Value, currentPrefix + child.Key, result);
                }
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

            public bool Remove(string prefix)
            {
                if (string.IsNullOrEmpty(prefix)) return false;

                prefix = prefix.Trim(); // Oříznutí neviditelných znaků
                return Remove(root, prefix, 0);
            }

            private bool Remove(TrieNode node, string prefix, int depth)
            {
                if (node == null)
                    return false;

                // Pokud jsme dosáhli konce prefixu
                if (depth == prefix.Length)
                {
                    if (node.Name == null)
                        return false; // Prefix neexistuje jako celé jméno

                    node.Name = null; // Odebrání jména

                    // Pokud nemá žádné děti, můžeme ho odstranit
                    return node.Children.Count == 0;
                }

                char ch = prefix[depth];
                if (!node.Children.ContainsKey(ch))
                    return false;

                bool shouldDeleteChild = Remove(node.Children[ch], prefix, depth + 1);

                // Pokud dítě nemá další záznamy, můžeme ho odstranit
                if (shouldDeleteChild)
                {
                    node.Children.Remove(ch);
                    return node.Children.Count == 0 && node.Name == null;
                }

                return false;
            }
        }


        private void RemoveFromFile(string prefix)
        {
            if (string.IsNullOrEmpty(sourceFilePath))
            {
                MessageBox.Show("Cesta ke zdrojovému souboru nebyla nalezena.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            prefix = prefix.Trim(); // Oříznutí prefixu

            var lines = File.ReadAllLines(sourceFilePath, Encoding.UTF8)
                .Select(line => line.Trim()) // Oříznutí každého řádku
                .Where(line => !line.StartsWith(prefix + " ")) // Ověření správného formátu
                .ToList();

            File.WriteAllLines(sourceFilePath, lines, Encoding.UTF8);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newPrefix = txtNewPrefix.Text.Trim();
            string newName = txtNewName.Text.Trim();

            if (string.IsNullOrEmpty(newPrefix) || string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Zadejte platný prefix i jméno.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Přidání dat do trie
            trie.Insert(newPrefix, newName);
            MessageBox.Show($"Prefix '{newPrefix}' a jméno '{newName}' bylo úspěšně přidáno.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Uložení dat do souboru
            if (!string.IsNullOrEmpty(sourceFilePath))
            {
                File.AppendAllText(sourceFilePath, $"{newPrefix} {newName}{Environment.NewLine}");
                MessageBox.Show($"Prefix '{newPrefix}' a jméno '{newName}' bylo přidáno a uloženo do souboru.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cesta ke zdrojovému souboru nebyla nalezena. Data byla přidána do aplikace, ale neuložena do souboru.", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Vyčištění vstupních polí
            txtNewPrefix.Text = string.Empty;
            txtNewName.Text = string.Empty;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string prefix = txtRemovePrefix.Text.Trim();
            if (string.IsNullOrEmpty(prefix))
            {
                MessageBox.Show("Zadejte prefix k odstranění.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Odebrání z trie
            bool removed = trie.Remove(prefix);
            if (removed)
            {
                RemoveFromFile(prefix);
                MessageBox.Show($"Prefix '{prefix}' byl úspěšně odstraněn.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Prefix nebyl nalezen.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtRemovePrefix.Text = string.Empty;
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            List<string> allData = trie.GetAllData();

            if (allData.Count > 0)
            {
                txtAllData.Text = string.Join(Environment.NewLine, allData);
            }
            else
            {
                txtAllData.Text = "Žádná data nejsou uložena.";
            }
        }
    }
}
