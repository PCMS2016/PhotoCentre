using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using DAL;

namespace PCMS
{
    public class PrintReceipt
    {
        private Company company = null;
        private IHandler_Company handlerCompany = null;

        private List<OrderLine> orderItems = null;
        private string orderNumber;
        private string date;
        private string time;
        private double total;
        private double cash;
        private double change;
        private double discount;
        private double totalVat;
        private double discountTotal;
        private double VAT = double.Parse(ConfigurationManager.AppSettings["VAT"]);
        private string customer;

        public PrintReceipt(List<OrderLine> orderItems, string date, string time, string orderNumber, 
            double total, double cash, double change, double discount, string customer)
        {
            handlerCompany = new Handler_Company();
            company = handlerCompany.GetCompanyDetails();

            this.orderItems = orderItems;
            this.date = date.Substring(0,10);
            this.time = time.Substring(11);
            this.orderNumber = orderNumber;
            this.total = total;
            this.cash = cash;
            this.change = change;
            this.discount = discount;
            this.customer = customer;

            VAT = VAT / 100; 

            discountTotal = total - (total / 100 * discount);

            //===http://vatcalconline.com/ ===//
            totalVat = discountTotal - (((discountTotal / (1 + VAT)) - discountTotal) / -1);
        }

        //===https://www.youtube.com/watch?v=ToRXCw91r-c ===//

        public void Print()
        {
            //Dialog popup object created
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            //Show dialog
            DialogResult result = printDialog.ShowDialog();

            //Start process if the user clicks OK
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font12 = new Font("Courier New", 12);
            Font font18 = new Font("Courier New", 18);
  
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            float fontHeight = font12.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            //Heading//
            graphic.DrawString(company.Name, font18, solidBrush, startX, startY);
            offset += (int)fontHeight + 10;
            graphic.DrawString(company.Address1, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            if (company.Address2 != "")
            {
                graphic.DrawString(company.Address2, font12, solidBrush, startX, startY + offset);
                offset += (int)fontHeight + 5;
            }
            graphic.DrawString(company.City, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString(company.Suburb, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString(company.PostalCode, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 20;
            graphic.DrawString("Phone: " + company.Phone, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Fax:   " + company.Fax, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Email: " + company.Email, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 20;

            graphic.DrawString("Order#: " + orderNumber, font18, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Customer: " + customer, font18, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 20;
            graphic.DrawString("Date: " + date, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Time: " + time, font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 20;

            graphic.DrawString("Item".PadRight(30) + "Qty".PadRight(6) + "Price".PadRight(10) + "Total".PadRight(10) , font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("=======================================================", font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;

            //Content//
            foreach (var item in orderItems)
            {
                string product = item.Product.PadRight(30);
                string qty = (item.Quantity.ToString()).PadRight(6);
                string price = (string.Format("{0:C}", item.ItemPrice)).PadRight(10);
                string total = string.Format("{0:C}", item.LineTotal);
                string printLine = product + qty + price + total;

                graphic.DrawString(printLine, font12, solidBrush, startX, startY + offset);

                offset += (int)fontHeight + 5;
            }
            graphic.DrawString("=======================================================", font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;

            offset += 20;

            //Footer//
            graphic.DrawString("Discount: ".PadLeft(46) + string.Format("{0:f2}%", discount), font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("VAT: ".PadLeft(46) + string.Format("{0:f2}%", ConfigurationManager.AppSettings["VAT"]), font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Total (excl VAT): ".PadLeft(46) + string.Format("{0:c}", totalVat), font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Total (incl VAT): ".PadLeft(46) + string.Format("{0:c}", discountTotal), font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Total (Discount): ".PadLeft(46) + string.Format("{0:c}", discountTotal), font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Cash: ".PadLeft(46) + string.Format("{0:c}", cash), font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 5;
            graphic.DrawString("Change: ".PadLeft(46) + string.Format("{0:c}", change), font12, solidBrush, startX, startY + offset);
            offset += (int)fontHeight + 20;
            graphic.DrawString("Thank You!".PadLeft(23), font18, solidBrush, startX, startY + offset);
        }
    }
}
