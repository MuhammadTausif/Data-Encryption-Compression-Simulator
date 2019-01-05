using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data_Encryption_Compression_Simulator.ClassLib;
using System.Collections;

namespace Data_Encryption_Compression_Simulator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenratePublicKey_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptionRSA rsa = new EncryptionRSA();

                string CompositeKey = rsa.KeyGenrator();
                string[] stArray = CompositeKey.Split('.');
                textBoxPublicKey.Text = stArray[0];
                textBoxPrivateKeyE.Text = stArray[1];
                textBoxPrivateKey.Text = stArray[1];
            }
            catch (Exception ex)
            {

                MessageBox.Show("System Can not genrate Public and Private Keys \n\nException:\n"+ex.Message+"\n\nPress OK to Proceede");
            }

        }

        private void buttonEncrypte_Click(object sender, EventArgs e)
        {
            #region --[this should be replaced after testing all key 1111111 output 1]--
            //try
            //{
            //    EncryptionRSA rsa = new EncryptionRSA();

            //    string CompositeKey = rsa.KeyGenrator();
            //    string[] stArray = CompositeKey.Split('.');
            //    textBoxPublicKey.Text = stArray[0];
            //    textBoxPrivateKeyE.Text = stArray[1];
            //}
            //catch
            //{
            //    MessageBox.Show("Exeption Occured");
            //}
            #endregion


            try
            {
                EncryptionRSA rsa = new EncryptionRSA();
                TypeConversion tp = new TypeConversion();
                RSAKeys rks = new RSAKeys();
                int keyPropf=rks.ValidatePublicKeys(textBoxPublicKey.Text);
                if (keyPropf == 0)
                {
                    int b,a = 1;
                    b = a / keyPropf;
                }
                richTextBoxEncrypte.Text = rsa.Encryptor(tp.CharToInt(richTextBoxEncrypte.Text), textBoxPublicKey.Text);
                buttonEncrypte.Enabled = false;
                buttonProceedeForCompression.Enabled = true;
            }
            catch (Exception ex)
            {
                buttonProceedeForCompression.Enabled = false;
                buttonEncrypte.Enabled = true;
                MessageBox.Show("System Can Not Encryte Your Message \n\nExplanation:\nPlease there must be text in the main text and\nGenrate/Enter correct Public Key in the respected text box\n\nExeption  :  "+ex.Message+"\n\nPress OK to proceede");
            }
            #region--[this aslo belong to region 1111 output and work with it]--
            //buttonSaveEncryptedCompressedText.Visible = true;
            //buttonEncrypte.Visible = false;
            #endregion
        }

        private void buttonProceedeForCompression_Click(object sender, EventArgs e)
        {
            try
            {
                string orignalStirng = richTextBoxEncrypte.Text;
                string forByteCode;
                StringBuilder for8Cont = new StringBuilder();
                string ChakingSt = "0000000";//this is used for practice to replace seven zeros "0000000"

                Compression cmpr = new Compression();

                forByteCode = (for8Cont.Append((cmpr.Coding(orignalStirng) + ChakingSt))).ToString();



                byte[] newForByte = cmpr.GetBytes(forByteCode);
              
                string encodedSt = Encoding.Default.GetString(newForByte);
                richTextBoxEncrypte.Text = encodedSt;
                richTextBoxDecryption.Text = encodedSt;
                buttonEncrypte.Enabled = false;
                buttonProceedeForCompression.Enabled = false;
                buttonDecrypte.Enabled = false;
                buttonDecompress.Enabled = true;
               
                MessageBox.Show("System has Compressed the Encrypted text\n\nPress OK to proceede ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Can not Compress your Message \n\nException:\n" + ex.Message+"\n\nPress OK to Proceede");
            }
           
        }

        private void buttonDecompress_Click(object sender, EventArgs e)
        {
            try
            {
                string testing = richTextBoxDecryption.Text;
                byte[] compressedBytes = Encoding.Default.GetBytes(testing);

                BitArray bitArray = new BitArray(compressedBytes);
                Compression cmpr = new Compression();
                string arrnged = cmpr.ArrangeString(bitArray);


                richTextBoxDecryption.Text = cmpr.DeCoding(arrnged);
                MessageBox.Show("System has Decompressed the Encrypted text\n\nPress OK to proceede ");

                buttonDecompress.Enabled = false;
                buttonDecrypte.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("System Can not Decompress your Message \n\nException:\n" + ex.Message+"\n\nPress OK to Proceede");
            }
            
        }

        private void buttonDecrypte_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptionRSA rsa = new EncryptionRSA();
                TypeConversion tp = new TypeConversion();

                richTextBoxDecryption.Text = tp.IntToChar(rsa.Dencryptor(richTextBoxDecryption.Text, textBoxPrivateKey.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Can not Decrypte your Message \n\nExplanation:\nPlease enter Correct Private Key and Correct Encrypted text\n\nException:" + ex.Message+"\n\nPress OK to Proceede");
            }
        }

        private void buttonSaveEncryptedCompressedText_Click(object sender, EventArgs e)
        {
            #region--[this is for test puposes and should be deleted]--
           // EncryptionRSA rsa = new EncryptionRSA();
           // TypeConversion tp = new TypeConversion();

           // richTextBoxEncrypte.Text = tp.IntToChar(rsa.Dencryptor(richTextBoxEncrypte.Text, textBoxPrivateKeyE.Text));
           ////Should be removed
           // buttonSaveEncryptedCompressedText.Visible = false;
           // buttonEncrypte.Visible = true;
            #endregion
        }

        private void buttonStartD_Click(object sender, EventArgs e)
        {
            textBoxPrivateKey.Text = null;
            richTextBoxDecryption.Text = null;
            buttonDecompress.Enabled = true;

        }

        private void buttonStartE_Click(object sender, EventArgs e)
        {
            textBoxPrivateKeyE.Text = null;
            textBoxPrivateKey.Text = null;
            textBoxPublicKey.Text = null;
            richTextBoxEncrypte.Text = null;
            buttonProceedeForCompression.Enabled = false;
            buttonEncrypte.Enabled = true;
        }

        private void textBoxPrivateKeyE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
