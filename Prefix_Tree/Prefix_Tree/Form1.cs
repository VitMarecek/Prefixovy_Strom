using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prefix_Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Pridat(string slovo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<String> Hledat(string hledatString)
        {
            return new string[] { };
        }

        protected class PrefixovyStromUzel
        {
            private readonly Dictionary<char, PrefixovyStromUzel> podUzly;
            private bool jeSlovo;

            public PrefixovyStromUzel()
            {
                podUzly = new Dictionary<char, PrefixovyStromUzel>();
                jeSlovo = false;
            }

            public Dictionary<char, PrefixovyStromUzel> PodUzly { get { return podUzly; } }
            public bool JeSlovo { get { return JeSlovo; } set { jeSlovo = value; } }
        }
    }
}
