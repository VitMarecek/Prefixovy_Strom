using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prefixovy_Strom_Trie.PrefixovyStrom;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prefixovy_Strom_Trie
{
    public partial class PrefixovyStrom : Form
    {
        private Trie trie = new Trie();
        private string sourceFilePath;
        public PrefixovyStrom()
        {
            InitializeComponent();
            searchButton.Enabled = false;
            addButton.Enabled = false;
            deleteButton.Enabled = false;
            linearSearchButton.Enabled = false;
            buttonListBox.Enabled = false;
            textBoxDataAdd.Enabled = false;
            textBoxLinearSearch.Enabled = false;
            textBoxPrefixAdd.Enabled = false;
            textBoxPrefixDelete.Enabled = false;
            textBoxPrefixSearch.Enabled = false;
            textBoxResult.Enabled = false;
            textBoxTrie.Enabled = false;
        }

        private void loadButton_Click(object sender, EventArgs e)
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
                        var trimmedLine = line.Trim();
                        var parts = trimmedLine.Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length == 2)
                        {
                            string prefix = parts[0].Trim();
                            string name = parts[1].Trim();
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
                searchButton.Enabled = true;
                addButton.Enabled = true;
                deleteButton.Enabled = true;
                linearSearchButton.Enabled = true;
                buttonListBox.Enabled = true;
                textBoxDataAdd.Enabled = true;
                textBoxLinearSearch.Enabled = true;
                textBoxPrefixAdd.Enabled = true;
                textBoxPrefixDelete.Enabled = true;
                textBoxPrefixSearch.Enabled = true;
                textBoxResult.Enabled = true;
                textBoxTrie.Enabled = true;
            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string prefix = textBoxPrefixSearch.Text.Trim();
            if (string.IsNullOrEmpty(prefix))
            {
                MessageBox.Show("Zadejte prosím prefix.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> results = trie.Search(prefix);
            if (results.Count > 0)
            {
                textBoxResult.Text = string.Join(Environment.NewLine, results);

            }
            else
            {
                textBoxResult.Text = "Žádné odpovídající prefixy nenalezeny.";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newPrefix = textBoxPrefixAdd.Text.Trim();
            string newName = textBoxDataAdd.Text.Trim();

            if (string.IsNullOrEmpty(newPrefix) || string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Zadejte platný prefix i jméno.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Přidání dat do trie
            trie.Insert(newPrefix, newName);
            MessageBox.Show($"Prefix '{newPrefix}' a jméno '{newName}' bylo úspěšně přidáno.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Vyčištění vstupních polí
            textBoxPrefixAdd.Text = string.Empty;
            textBoxDataAdd.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string prefix = textBoxPrefixDelete.Text.Trim();
            if (string.IsNullOrEmpty(prefix))
            {
                MessageBox.Show("Zadejte prefix k odstranění.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Odebrání z trie
            bool removed = trie.Remove(prefix);
            if (removed)
            {               
                MessageBox.Show($"Prefix '{prefix}' byl úspěšně odstraněn.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Prefix již neexistuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBoxPrefixDelete.Text = string.Empty;
        }

        private void linearSearchButton_Click(object sender, EventArgs e)
        {
            string prefix = textBoxLinearSearch.Text.Trim();
            string result = "";
            string finalString = ""; //Oprav
            StreamReader sw = new StreamReader(sourceFilePath);
            string radek;
            bool log = false;
            while (!sw.EndOfStream && !log)
            {
                radek = sw.ReadLine();
                string[] radecek = radek.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (radecek[0].StartsWith(prefix))
                {
                    result = radecek[1];
                    finalString = finalString + " " + result;
                }
            }
            if (finalString != "")
            {
                textBoxResult.Text = finalString;
            }
            else
            {
                textBoxResult.Text = "Žádné odpovídající prefixy nenalezeny.";
            }
        }

        private void buttonListBox_Click(object sender, EventArgs e)
        {                           
                List<string> allData = trie.GetAllData();
                
                if (allData.Count > 0)
                {
                    textBoxTrie.Text = string.Join(Environment.NewLine, allData);
                    
                }
                else
                {
                    textBoxTrie.Text = "Žádná data nejsou uložena.";
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

                // Uložení jména na posledním uzlu
                current.Name = name;
            }

            public List<string> Search(string prefix)
            {
                var current = root;


                foreach (char ch in prefix)
                {
                    if (!current.Children.ContainsKey(ch))
                    {
                        return new List<string>(); // Prefix není ve stromě
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
    }
}
