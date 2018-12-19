using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MonoalphabeticVigenereCiphersExercise
{
    public class MonoCipher
    {
        static char[] alphabet = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        static char[] cipheralphabet = new char[] { 'L', 'E', 'O', 'P', 'A', 'R', 'D', 'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'Q', 'N', 'M', 'K', 'J', 'I', 'H', 'G', 'F', 'C', 'B' };



        public void Encrypt()
        {
            string messagefile = "messageP";
            string pathread = @"C:\\Users\Saeed Dickie\source\repos\MonoalphabeticVigenereCiphersExercise\MonoalphabeticVigenereCiphersExercise\CipherFiles\" + messagefile + ".txt";
            string pathwrite = @"C:\\Users\Saeed Dickie\source\repos\MonoalphabeticVigenereCiphersExercise\MonoalphabeticVigenereCiphersExercise\CipherFiles\messageC.txt";


            byte[] TextCharArray = File.ReadAllBytes(pathread);

            ArrayList CipherCharOutput = new ArrayList();
            string output = "";


            foreach (var character in TextCharArray)
            {
               if (character == 32) CipherCharOutput.Add(Convert.ToChar(" "));
                if (character == 13) CipherCharOutput.Add(Convert.ToChar("\r"));
                if (character == 10) CipherCharOutput.Add(Convert.ToChar("\n"));


                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (character == Convert.ToByte(alphabet[i]))
                    {
                        var cipherletter = Convert.ToChar(cipheralphabet[i]);

                        CipherCharOutput.Add(cipherletter);
                    }
                }
                
            }

                       
            StreamWriter sw = new StreamWriter(pathwrite);

            foreach (var item in CipherCharOutput)
            {
                output += item;
            
            }

            sw.WriteLine(output);

            sw.Close();
        }



  

        public void Decrypt()
        {
        string messagefile = "messageC";
        string pathread = @"C:\\Users\[]\source\repos\MonoalphabeticVigenereCiphersExercise\MonoalphabeticVigenereCiphersExercise\CipherFiles\" + messagefile + ".txt";
        string pathwrite = @"C:\\Users\[]\source\repos\MonoalphabeticVigenereCiphersExercise\MonoalphabeticVigenereCiphersExercise\CipherFiles\messageD.txt";


         byte[] TextCharArray = File.ReadAllBytes(pathread);

         ArrayList CipherCharOutput = new ArrayList();
        string output = "";


        foreach (var character in TextCharArray)
        {
            if (character == 32) CipherCharOutput.Add(Convert.ToChar(" "));
            if (character == 13) CipherCharOutput.Add(Convert.ToChar("\r"));
            if (character == 10) CipherCharOutput.Add(Convert.ToChar("\n"));


            for (int i = 0; i < alphabet.Length; i++)
            {
                if (character == Convert.ToByte(cipheralphabet[i]))
                {
                    var decryptletter = Convert.ToChar(alphabet[i]);

                    CipherCharOutput.Add(decryptletter);
                }
            }

        }


        StreamWriter sw = new StreamWriter(pathwrite);

        foreach (var item in CipherCharOutput)
        {
            output += item;

        }

        sw.WriteLine(output);

        sw.Close();
    }

    }

}

