using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAReceiver
{
    public partial class Form1 : Form
    {
        public byte[] HexStringToBytes(string s)
        {
            const string HEX_CHARS = "0123456789ABCDEF";

            if (s.Length == 0)
                return new byte[0];

            if ((s.Length + 1) % 3 != 0)
                throw new FormatException();

            byte[] bytes = new byte[(s.Length + 1) / 3];

            int state = 0; // 0 = expect first digit, 1 = expect second digit, 2 = expect hyphen
            int currentByte = 0;
            int x;
            int value = 0;

            foreach (char c in s)
            {
                switch (state)
                {
                    case 0:
                        x = HEX_CHARS.IndexOf(Char.ToUpperInvariant(c));
                        if (x == -1)
                            throw new FormatException();
                        value = x << 4;
                        state = 1;
                        break;
                    case 1:
                        x = HEX_CHARS.IndexOf(Char.ToUpperInvariant(c));
                        if (x == -1)
                            throw new FormatException();
                        bytes[currentByte++] = (byte)(value + x);
                        state = 2;
                        break;
                    case 2:
                        if (c != '-')
                            throw new FormatException();
                        state = 0;
                        break;
                }
            }

            return bytes;
        }

        public void Decryption(string strText, string rsaString)
        {
            var privateKey = rsaString;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(privateKey);

                    var resultBytes = HexStringToBytes(textBoxCipherBytes.Text);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    textBoxDecrypted.Text = decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Generate a public/private key using RSA  
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048);
            // Read public key in a XML string
            string RSAXML = RSA.ToXmlString(true);

            // Get key into parameters  
            RSAParameters RSAKeyInfo = RSA.ExportParameters(true);

            //Set textbox content
            textBoxPublicKey.Text = RSAXML;
            textBoxExponent.Text = BitConverter.ToString(RSAKeyInfo.Exponent);
            textBoxModulus.Text = BitConverter.ToString(RSAKeyInfo.Modulus);
            textBoxD.Text = BitConverter.ToString(RSAKeyInfo.D);
            textBoxDP.Text = BitConverter.ToString(RSAKeyInfo.DP);
            textBoxDQ.Text = BitConverter.ToString(RSAKeyInfo.DQ);
            textBoxInverseQ.Text = BitConverter.ToString(RSAKeyInfo.InverseQ);
            textBoxP.Text = BitConverter.ToString(RSAKeyInfo.P);
            textBoxQ.Text = BitConverter.ToString(RSAKeyInfo.Q);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decryption(textBoxCipherBytes.Text, textBoxPublicKey.Text);
        }
    }
}
