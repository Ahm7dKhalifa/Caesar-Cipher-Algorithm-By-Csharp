using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher_Algorithm_By_Csharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ovalPictureBox2_Click(object sender, EventArgs e)
        {
            MessageError.Text = " ";
            List<string> messageEncrpto = new List<string>();
            List<char> alphbet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToList<char>();
            //store the message
            string message = textBox1.Text;
            //check if the message is empty or not
            if (String.IsNullOrEmpty(message))
            {
                MessageError.Text = "Please enter string";
                return;
            }
            int increment = 0;
            //store the increment
            if (textBox2.Text != null)
            {
                increment = Convert.ToInt32(textBox2.Text);
            }
            //check the number is vaild or not
            
            if(increment > 25 || increment <= 0)
            {
                MessageError.Text = "Please enter number between 1 and 25";
                return;
            }
            
            //convert the message to lower case
            message = message.ToLower();
            //split the meesage by whitespace
            string[] words = message.Split(null);
            string[] words_encrypto = new string[words.Length];
            for(int j = 0; j < words.Length; j++)
            {
                //convert string to arrays of chars
                char[] arr = words[j].ToCharArray();
                char[] arr_encrypto = new char[arr.Length];
                for(int i = 0; i < arr.Length; i++)
                {
                    if (!alphbet.Contains(arr[i]))
                    {
                        MessageError.Text = "Please enter only alphbet from a to z ";
                        return;
                    }
                    int newIndex = alphbet.IndexOf(arr[i]) + increment;
                    if (newIndex >= 26)
                    {
                        newIndex = newIndex - 26;
                        arr_encrypto[i] = alphbet[newIndex];
                        
                    }
                    else
                    {
                        arr_encrypto[i] = alphbet[newIndex];

                    }
                }
                //add every word after encrypto
                words_encrypto[j] = new string(arr_encrypto);
            }
            //display the result
            label2.Text = string.Join(" ", words_encrypto); 
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
