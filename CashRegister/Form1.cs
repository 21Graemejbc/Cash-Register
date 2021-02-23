/*Graeme Cook
 * February 11 (Edited February 23)
 A program that mimics a cash register. Takes input (# of items & tender), calculates prices (with tax & change, prints a receipt*/

//Using statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//Error noises

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //Declaration & setting of constants
        double cardPrice = 3000;
        double chargerPrice = 15;
        double phonePrice = 1200;
        double taxRate = 0.13;

        //Declaration & setting of input variables 
        int card = 0;
        int charger = 0;
        int phone = 0;

        //Declaration & setting of order number tracker
        int orderNum = 0;

        //Declaration & setting of math/display variables
        double total = 0;
        double taxAmount = 0;
        double subTotal = 0;
        double tender = 0;
        double change = 0;

        //Globally setup sound players
        SoundPlayer kaChingPlayer = new SoundPlayer(Properties.Resources.Kaching);
        SoundPlayer receiptPlayer = new SoundPlayer(Properties.Resources.Receipt);
        SoundPlayer errorPlayer = new SoundPlayer(Properties.Resources.Error);

        public Form1()
        {
            //Focus on first input box, disable change & receipt buttons
            InitializeComponent();
            cardInput.Focus(); //Not working
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Blocks blank input fields from throwing errors by setting them to 0 instead, if not blank: converts fields to integers and stores them
                if (cardInput.Text == "")
                { card = 0; }
                else
                { card = Convert.ToInt32(cardInput.Text); }

                if (phoneInput.Text == "")
                { phone = 0; }
                else
                { phone = Convert.ToInt32(phoneInput.Text); }

                if (chargerInput.Text == "")
                { charger = 0; }
                else
                { charger = Convert.ToInt32(chargerInput.Text); }

                //If all input fields are left empty
                if (card == 0 && phone == 0 && charger == 0)
                {
                    //Display error message & play error noise
                    errorPlayer.Play();
                    totalsOutput.Text = "Please order at least one item";
                }

                else
                {
                    //Otherwise, do the math to find the total cost, tax, and the grand total
                    total = card * cardPrice + phone * phonePrice + charger * chargerPrice;
                    taxAmount = total * taxRate;
                    subTotal = total + taxAmount;

                    //Play sound effect
                    kaChingPlayer.Play();

                    //Display (in currency format) the variables calculated above
                    totalsOutput.Text = $"Sub Total: {total.ToString("C")}";
                    totalsOutput.Text += $"\n\nTax: {taxAmount.ToString("C")}";
                    totalsOutput.Text += $"\n\nTotal: {subTotal.ToString("C")}";

                    //Enable next button
                    changeButton.Enabled = true;
                }
            }
            catch
            {
                //If the above throws an error, catch it, display error, and send them back (hasn't happened yet, will need work if errors start popping up), play error noise
                errorPlayer.Play();
                leftReceiptOutput.Text = "Error";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //Block the print button from being repressed, to avoid issues
            receiptButton.Enabled = false;

            //Add to the order number counter (for later display)
            ++orderNum;

            //Play sound, print receipt
            receiptPlayer.Play();
            leftReceiptOutput.Text = "Totally Legit Tech Inc.";
            Thread.Sleep(500);
            Refresh();
            leftReceiptOutput.Text += $"\n{DateTime.Now.ToString()}";
            Thread.Sleep(500);
            Refresh();
            leftReceiptOutput.Text += $"\nOrder #{orderNum}";
            leftReceiptOutput.Text += "\n";
            rightReceiptOutput.Text += "\n\n\n";

            //Only display items that have been ordered (and their price)
            if (card > 0)
            {
                leftReceiptOutput.Text += $"\n{card} Graphics Cards";
                rightReceiptOutput.Text += $"\n@ {cardPrice.ToString("C")}";
                Thread.Sleep(500);
                Refresh();
            }
            if (phone > 0)
            {
                leftReceiptOutput.Text += $"\n{phone} Phones";
                rightReceiptOutput.Text += $"\n@ {phonePrice.ToString("C")}";
                Thread.Sleep(500);
                Refresh();
            }
            if (charger > 0)
            {
                leftReceiptOutput.Text += $"\n{charger} Chargers";
                rightReceiptOutput.Text += $"\n@ {chargerPrice.ToString("C")}";
                Thread.Sleep(500);
                Refresh();
            }

            //Continue printing
            leftReceiptOutput.Text += $"\n\nSubtotal:";
            rightReceiptOutput.Text += $"\n\n{total.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            leftReceiptOutput.Text += $"\nTax:";
            rightReceiptOutput.Text += $"\n{taxAmount.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            leftReceiptOutput.Text += $"\nTotal:";
            rightReceiptOutput.Text += $"\n{subTotal.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            leftReceiptOutput.Text += $"\n\nTendered:";
            rightReceiptOutput.Text += $"\n\n{tender.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            leftReceiptOutput.Text += $"\nChange:";
            rightReceiptOutput.Text += $"\n{change.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            goodDayLabel.Text += "\n\nThank you for your business, have a good day!";
            Thread.Sleep(500);
            Refresh();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //Clear output
            leftReceiptOutput.Text = "";

            //If there is no input, send the user back, and ask for an input, play error noise
            if (tenderInput.Text == "")
            {
                errorPlayer.Play();
                leftReceiptOutput.Text = "Please enter a number for the amount          tendered"; //Spaces to avoid clipping of text
                return;
            }
            try
            {
                tender = Convert.ToDouble(tenderInput.Text);
            }
            catch
            {
                //If there is an error with the above conversion: catch it, and ask them to enter only numbers (only know error, will need changes if another one is discovered), play error noise
                errorPlayer.Play();
                leftReceiptOutput.Text = "Please enter only numbers as the amount tendered";
                return;
            }

            //If a tender amount less than the grand total is entered: ask for one greater and play error noise
            if (tender < subTotal)
            {
                errorPlayer.Play();
                leftReceiptOutput.Text = "Please enter an amount of tender greater than the total cost of the order";
            }
            else
            {
                //Otherwise (if everything checks out), do some math to determine the change, play a sound effect, display the math, and enable the next button
                change = tender - subTotal;
                kaChingPlayer.Play();
                changeOutput.Text = $"{change.ToString("C")}";
                receiptButton.Enabled = true;
            }
        }

        private void reorderButton_Click(object sender, EventArgs e)
        {
            //Reset variables
            card = 0;
            phone = 0;
            charger = 0;
            total = 0;
            taxAmount = 0;
            subTotal = 0;
            tender = 0;
            change = 0;

            //Reset input/output fields
            cardInput.Text = "0";
            phoneInput.Text = "0";
            chargerInput.Text = "0";
            tenderInput.Text = "";
            totalsOutput.Text = "";
            changeOutput.Text = "";
            leftReceiptOutput.Text = "";
            rightReceiptOutput.Text = "";
            goodDayLabel.Text = "";

            //Place focus on first input field
            cardInput.Focus();

            //Redisable buttons
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
        }
    }
}
