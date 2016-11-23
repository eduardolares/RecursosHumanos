using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using System.IO;

namespace RecursosHumanos.Vistas.UserControls
{
    public partial class Nomina : UserControl
    {
        
        public Nomina()
        {
            InitializeComponent();
            _PanelControlNomina.BackColor = Color.FromArgb(0, 0, 0, 0);
            
        }

        Dictionary<string, string> GetReplaceDictionary()
        {
            Dictionary<string, string> replaceDict = new Dictionary<string, string>();
            replaceDict.Add("#nombre#", _TextBoxNombre.Text.Trim());

            return replaceDict;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samplePath = "C:\\users\\eduar\\Desktop\\nombre.docx";
            string docPath = "C:\\users\\eduar\\Desktop\\eduardo.docx";
            Document documento = new Document();
            documento.LoadFromFile(samplePath);
            Dictionary<string, string> dictReplace = GetReplaceDictionary();
            foreach (KeyValuePair<string, string> kvp in dictReplace)
            {
                documento.Replace(kvp.Key, kvp.Value, true, true);
            }

            documento.SaveToFile(docPath, FileFormat.Docx);
        }
    }
}
