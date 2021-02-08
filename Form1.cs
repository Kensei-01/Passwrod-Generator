using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int length = 3;
        string currentPassword;
        static List<char> SpecialCharacters = new List<char>() { '!', '§', '$', '%', '&', '/', '(', ')', '=', '?', '*', '#' };
        static List<char> CapitalLetters = new List<char>() { 'B', 'A', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static List<char> numbers = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        static List<char> SmallLetter = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<List<char>> allLists = new List<List<char>>() { SpecialCharacters, CapitalLetters, numbers, SmallLetter };
        List<List<char>> listWithCapital = new List<List<char>>() { CapitalLetters, numbers, SmallLetter };
        List<List<char>> listWithSpecial = new List<List<char>>() { SpecialCharacters, numbers, SmallLetter };
        List<List<char>> ListNumberChars = new List<List<char>>() { numbers, SmallLetter };

        Random random = new Random();

        static bool includeBigLetter = false;
        static bool includeSpecialChars = false;
        static bool includeOnlyNums = false;
        static bool includeOnlySmallChars = false;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            if (!(length < 4))
            {
                length--;
                lblPasswordLengthReal.Text = $"{length}";
            }
        }
        private void checkSpecialChar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkSpecialChar.Checked)
            {
                includeSpecialChars = true;
                btnOnlyNumbers.Checked = false;
                includeOnlyNums = false;
            }
            else includeSpecialChars = false;
        }

        private void checkBigLetters_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBigLetters.Checked)
            {
                includeBigLetter = true;
                includeOnlyNums = false;
                btnOnlyNumbers.Checked = false;
                includeOnlySmallChars = false;
                btnOnlySmallLetters.Checked = false;
            }
            else includeBigLetter = false;
        }
        

        private void btnIncrement_Click_1(object sender, EventArgs e)
        {
            if (length < 50)
            {
                length++;
                lblPasswordLengthReal.Text = $"{length}";
            }
        }

        private void btnGeneratePw_Click_1(object sender, EventArgs e)
        {
            lblCopiedText.Text = "";
            btnCopyPassword.Enabled = true;

            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {

                int list1 = random.Next(0, SpecialCharacters.Count);
                int list2 = random.Next(0, CapitalLetters.Count);
                int list3 = random.Next(0, numbers.Count);
                int list4 = random.Next(0, SmallLetter.Count);
                int[] lists = { list1, list2, list3, list4 };
                int[] listsWithBigLetters = { list2, list3, list4 };
                int[] listWithSpacialLetters = { list1, list3, list4 };
                int[] defaultList = { list3, list4 };

                if (includeOnlyNums)
                {
                    result[i] = numbers[list3];
                }
                else if (includeOnlySmallChars)
                {
                    result[i] = SmallLetter[list4];
                }

                else if (includeBigLetter && includeSpecialChars)
                {
                    int choose = random.Next(0, 4);
                    result[i] = allLists[choose][lists[choose]];
                }
                else if (includeBigLetter)
                {
                    int choose = random.Next(0, 3);
                    result[i] = listWithCapital[choose][listsWithBigLetters[choose]];
                }
                else if (includeSpecialChars)
                {
                    int choose = random.Next(0, 3);
                    result[i] = listWithSpecial[choose][listWithSpacialLetters[choose]];
                }
                else
                {
                    int choose = random.Next(0, 2);
                    result[i] = ListNumberChars[choose][defaultList[choose]];
                }
            }
            string finalResult = new string(result);
            lblPassword.Text = "Your Password: " + finalResult;
            currentPassword = finalResult;
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            lblCopiedText.Text = "Copied to Clipboard!";
            
            Clipboard.SetText(currentPassword);
        }

        private void btnOnlyNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnlyNumbers.Checked) 
            {
                includeOnlyNums = true;
                checkBigLetters.Checked = false;
                checkSpecialChar.Checked = false;
                btnOnlySmallLetters.Checked = false;
            }
            
            else includeOnlyNums = false;
        }

        private void btnOnlySmallLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnlySmallLetters.Checked)
            {
                includeOnlySmallChars = true;
                checkBigLetters.Checked = false;
                checkSpecialChar.Checked = false;
                btnOnlyNumbers.Checked = false;
            }
            else includeOnlySmallChars = false;
        }
    }
    
}
