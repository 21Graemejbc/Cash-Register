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

/*Add title & icon
 * Add margins in all labels
 * Make the receipt NOT print unless something (maybe change label has text in it)*/


namespace CashRegister
{
    public partial class Form1 : Form
    {
        //Maybe focus on first input on start??

        double cardPrice= 3000;
        double chargerPrice = 15;
        double phonePrice = 1200;
        double taxRate = 0.13;
        //Declaration & setting of constants

        int card = 0;
        int charger = 0;
        int phone = 0;
        //Declaration & setting of input variables 

        double total = 0;
        double taxAmount = 0;
        double subTotal = 0;
        double tender = 0;
        double change = 0;
        //Declaration & setting of math/display variables

        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                card = Convert.ToInt32(cardInput.Text);
                phone = Convert.ToInt32(phoneInput.Text);
                charger = Convert.ToInt32(chargerInput.Text);

                total = card * cardPrice + phone * phonePrice + charger * chargerPrice;
                taxAmount = total * taxRate;
                subTotal = total + taxAmount;

                totalsOutput.Text = $"Sub Total: {total.ToString("C")}";
                totalsOutput.Text += $"\n\nTax: {taxAmount.ToString("C")}";
                totalsOutput.Text += $"\n\nTotal: {subTotal.ToString("C")}";
            }
            catch
            {
                leftReceiptOutput.Text = "Please enter numbers only into the quantity selections";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            leftReceiptOutput.Text = "Totally Legit Tech Inc.";
            Thread.Sleep(500);
            Refresh();
            leftReceiptOutput.Text += $"\n{DateTime.Now.ToString()}";
            Thread.Sleep(500);
            Refresh();
            leftReceiptOutput.Text += "\n";
            if (card > 0)
            {
                leftReceiptOutput.Text += $"\n{card} Graphics Cards";
                rightReceiptOutput.Text += $"\n\n\n@ {cardPrice.ToString("C")}";
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
            leftReceiptOutput.Text += $"\n\nTender:";
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
            try
            {
                tender = Convert.ToDouble(tenderInput.Text);
                change = tender - subTotal;
                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                totalsOutput.Text = "Please enter numbers only into the tender box";
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

            cardInput.Text = "";
            phoneInput.Text = "";
            chargerInput.Text = "";
            tenderInput.Text = "";
            totalsOutput.Text = "";
            changeOutput.Text = "";
            leftReceiptOutput.Text = "";
            rightReceiptOutput.Text = "";
            goodDayLabel.Text = "";
        }
    }
}
