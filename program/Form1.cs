using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cityNameGenerator
{
    public partial class Form1 : Form
    {
        int numberOfNames = 5;
        int namesPrinted = 0;
        // Fantasy Elven Style City Name Generator 5
        static String[] prefixes5 = { "Riv", "Loth", "Tir", "Aqu", "Gond", "Fir", "For", "Mirk", "Mith", "Galad", "Gal", "Cel", "Sir", "Luc", "Val", "Glor" };
        static String[] suffixes5 = { "endell", "ariel", "en Haven", "olin", "alonde", "ion", "ian", "en Woods", "an Riverlands" };

        // Fantasy Evil Style City Name Generator 4

        static String[] prefixes4 = { "Mor", "Izen", "Khan", "Dagor", "Lich", "Kro", "Wor", "Gorgo", "Iron", "Dagen", "Dre", "Darken" };
        static String[] suffixes4 = { "dor", "gard", "karak", "land", "moth", "gen", "roth", "forge", "fort", "den" };

        // British Fantasy Style City Name Generator 3
        static String[] prefixes3 = { "Norther", "Wessen", "Talken", "Tolken", "Larken", "Litten", "Litter", "Britter", "Souther", "Wester", "Easter", "Farken", "Falken", "Tarr", "Marr", "Ports", "Brad", "Lei", "Herr" };
        static String[] suffixes3 = { "land", "glade", "den", "feld", "brough", "bridge", "chester", "mouth", "water", "ford", "ham" };

        // German Style City Name Generator 2
        static String[] prefixes2 = { "Ber", "Ham", "Mu", "Frank", "Dres", "Nurem", "Dussel", "Stutt", "Bre", "Lu", "Dort", "Augs", "Saar", "Ro", "Wurtz", "Wurtem", "Olden", "Klagen" };
        static String[] suffixes2 = { "lin", "burg", "berg", "furt", "dorf", "gart", "beck", "brucken", "dam" };


        // Italian Style City Name Generator 1
        static String[] prefixes1 = { "Tor", "Ver", "Pad", "Mess", "Gen", "Pr", "Sal", "Ferr", "Lat", "Camp", "Berg", "Sirac", "Tr", "Nov", "Anc", "Lec", "Piac", "Liv", "Nav","R","L","Tar" };
        static String[] suffixes1 = { "ini", "ati", "oli", "osa", "ata", "anto", "ona", "onte", "ano", "ecchio", "ere", "ino", "ello", "ana", "agna", "asco", "ate", "ero", "azzo", "ezzo", "aro", "ano", "ano","oma" };

        public Form1()
        {
            InitializeComponent();
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            resetDisplayBox();
            if (italianButton.Checked == true)
            {
                populateDisplayBoxPrelim(numberOfNames, prefixes1, suffixes1);
            }
            else if(germanButton.Checked == true)
            {
                populateDisplayBoxPrelim(numberOfNames, prefixes2, suffixes2);
            }
            else if(menButton.Checked == true)
            {
                populateDisplayBoxPrelim(numberOfNames, prefixes3, suffixes3);
            } else if(evilButton.Checked == true)
            {
                populateDisplayBoxPrelim(numberOfNames, prefixes4, suffixes4);
            } else if(elvenButton.Checked == true)
            {
                populateDisplayBoxPrelim(numberOfNames, prefixes5, suffixes5);
            }
        }

        public void resetDisplayBox()
        {
            namesPrinted = 0;
            displayBox.Text = "";
        }
        public void populateDisplayBoxPrelim(int amount, String[] prefixArray, String[] suffixArray)
        {
            Random r = new Random();
            for (int i = 0; i < amount; i++)
            {
                populateDisplayBox(prefixArray, suffixArray, r);
            }
        }
        public void populateDisplayBox(String[] prefixArray, String[] suffixArray, Random r)
        {
            String name = getRandom(prefixArray,r);
            name = name + "" + getRandom(suffixArray,r);
            displayBox.Text += name;
            namesPrinted += 1;
            if (namesPrinted == numberOfNames)
            {
                displayBox.Text += ".";
            }
            else
            {
                displayBox.Text += ", ";
            }
        }

        public static String getRandom(String[] array, Random r)
        {
            var randomIndex = r.Next(0, array.Length);
            return array[randomIndex];
        }
    }
}
