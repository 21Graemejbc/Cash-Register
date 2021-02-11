/*Graeme Cook
 * February 11
 A program that mimics a cash register. Takes input (# of items & tender), calculates prices (with tax0 & change, prints a receipt*/

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

// Sequential button activation 

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double cardPrice = 3000;
        double chargerPrice = 15;
        double phonePrice = 1200;
        double taxRate = 0.13;
        //Declaration & setting of constants

        int card = 0;
        int charger = 0;
        int phone = 0;
        //Declaration & setting of input variables 

        int orderNum = 0;
        //Declaration & setting of order number tracker

        double total = 0;
        double taxAmount = 0;
        double subTotal = 0;
        double tender = 0;
        double change = 0;
        //Declaration & setting of math/display variables

        //Disable buttons at the beginning, activate in sequence 

        public Form1()
        {
            InitializeComponent();
            cardInput.Focus();
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            SoundPlayer kaChingPlayer = new SoundPlayer(Properties.Resources.Kaching);
            try
            {
                card = Convert.ToInt32(cardInput.Text);
                phone = Convert.ToInt32(phoneInput.Text);
                charger = Convert.ToInt32(chargerInput.Text);

                if (card == 0 && phone == 0 && charger == 0)
                {
                    totalsOutput.Text = "Please order at least one item";
                }
                else
                {
                    total = card * cardPrice + phone * phonePrice + charger * chargerPrice;
                    taxAmount = total * taxRate;
                    subTotal = total + taxAmount;

                    kaChingPlayer.Play();

                    totalsOutput.Text = $"Sub Total: {total.ToString("C")}";
                    totalsOutput.Text += $"\n\nTax: {taxAmount.ToString("C")}";
                    totalsOutput.Text += $"\n\nTotal: {subTotal.ToString("C")}";
                    changeButton.Enabled = true;
                }
            }
            catch
            {
                leftReceiptOutput.Text = "Error";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer receiptPlayer = new SoundPlayer(Properties.Resources.Receipt);
            ++orderNum;

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
            SoundPlayer kaChingPlayer = new SoundPlayer(Properties.Resources.Kaching);
            leftReceiptOutput.Text = "";

            if (tenderInput.Text == "")
            {
                leftReceiptOutput.Text = "Please enter a number for the amount          tendered";
                return;
            }
            try
            {
                tender = Convert.ToDouble(tenderInput.Text);
            }
            catch
            {
                leftReceiptOutput.Text = "Please enter only numbers as the amount tendered";
                return;
            }
            if (tender < subTotal)
            {
                leftReceiptOutput.Text = "Please enter an amount of tender greater than the total cost of the order";
            }
            else
            {
                change = tender - subTotal;
                kaChingPlayer.Play();
                changeOutput.Text = $"{change.ToString("C")}";
                receiptButton.Enabled = true;
            }
        }

        private void reorderButton_Click(object sender, EventArgs e)
        {
            card = 0;
            phone = 0;
            charger = 0;
            total = 0;
            taxAmount = 0;
            subTotal = 0;
            tender = 0;
            change = 0;

            cardInput.Text = "0";
            phoneInput.Text = "0";
            chargerInput.Text = "0";
            tenderInput.Text = "";
            totalsOutput.Text = "";
            changeOutput.Text = "";
            leftReceiptOutput.Text = "";
            rightReceiptOutput.Text = "";
            goodDayLabel.Text = "";

            cardInput.Focus();

            changeButton.Enabled = false;
            receiptButton.Enabled = false;
        }
    }
}
