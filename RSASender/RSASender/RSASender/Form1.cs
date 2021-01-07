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

namespace RSASender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            var publicKey = textBoxReceiverPublicKey.Text;
            var stringToBeEncrypted = Encoding.UTF8.GetBytes(textBoxPlaintext.Text);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(publicKey.ToString());
                    var encryptedData = rsa.Encrypt(stringToBeEncrypted, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);

                    textBoxCipherbytes.Text = (BitConverter.ToString(encryptedData));
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
    }
}
