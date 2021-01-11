using CSharp.Domain;
using System;
using System.Collections.Generic;

namespace CSharp.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beginning of the App.
            Console.WriteLine("App is running....Press the Enter key to calculate the" +
                " " + "Invoice!");
            Console.ReadLine();

            //Call Invoice_System class in CSharp.Domain Project.
            InvoiceSystem invoiceClass = new InvoiceSystem();

            //Call the GetCollection() method.
            GetCollection();        
        }

        //Method. 
        public static void GetCollection()
        {
            //To Calculate the InvoiceDate and InvoiceDueDate
            DateTime date = DateTime.Today;
            var lastDayOfMonth = new DateTime(date.Year, date.Month, 1);

            //Created a List all 12 Invoices
            #region
            InvoiceSystem invoice1 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6), //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC001",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0, 
            };

            InvoiceSystem invoice2 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6), //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC002",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice3 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6), //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC003",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice4 = new InvoiceSystem()
            { 
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6), //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC004",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice5 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6),  //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC005",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice6 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6),  //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC006",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice7 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6),  //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC007",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice8 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6),  //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC008",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice9 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6),  //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC009",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
                
            };

            InvoiceSystem invoice10 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6),  //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC0010",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice11 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6),  //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC0011",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };

            InvoiceSystem invoice12 = new InvoiceSystem()
            {
                InvoiceDate = lastDayOfMonth.AddMonths(1).AddDays(-6),  //(5 days before the end of the month) so it's -6 days
                InvoiceReferenceNumber = "IC0012",
                InvoiceDueDate = lastDayOfMonth.AddMonths(2).AddDays(-1), //Last day of the month
                TotalInvoiceAmount = 0,
            };
            #endregion

            //Add to a Generic List (All 12 Invoices)
            List<InvoiceSystem> collectionOfInvoices = new List<InvoiceSystem>();
            collectionOfInvoices.Add(invoice1);
            collectionOfInvoices.Add(invoice2);
            collectionOfInvoices.Add(invoice3);
            collectionOfInvoices.Add(invoice4);
            collectionOfInvoices.Add(invoice5);
            collectionOfInvoices.Add(invoice6);
            collectionOfInvoices.Add(invoice7);
            collectionOfInvoices.Add(invoice8);
            collectionOfInvoices.Add(invoice9);
            collectionOfInvoices.Add(invoice10);
            collectionOfInvoices.Add(invoice11);
            collectionOfInvoices.Add(invoice12);

            //Created a List of 12 Items of each invoice
            #region Items
            InvoiceItems item1 = new InvoiceItems()
            {
                Consultation_fee = 100.00,
                Testing_Rate = 123.45,
                Testing_per_hour = 2.5,
                Development_Rate = 320.00,
                Development_per_hour = 2.5,
                Planning_Rate = 115.00, 
                Planning_per_hour = 1.5
            };

            InvoiceItems item2 = new InvoiceItems()
            {
                Testing_Rate = 123.45,
                Testing_per_hour = 2.1,
                Development_Rate = 320.00,
                Development_per_hour = 2.9,
                Database_server = 300.00
            };

            InvoiceItems item3 = new InvoiceItems()
            {
                Testing_Rate = 123.45,
                Testing_per_hour = 3.5,
                Development_Rate = 320.00,
                Development_per_hour = 5.1
            };

            InvoiceItems item4 = new InvoiceItems()
            {
                Testing_Rate = 200.50,
                Testing_per_hour = 4.5,
                Development_Rate = 320.00,
                Development_per_hour = 6.1,
                Hosting = 2000.00
            };

            InvoiceItems item5 = new InvoiceItems()
            { 
                Testing_Rate = 200.00,
                Testing_per_hour = 6.2,
                Development_Rate = 320.00,
                Development_per_hour = 4.3
            };

            InvoiceItems item6 = new InvoiceItems()
            {
                Testing_Rate = 320.00,
                Testing_per_hour = 6.5,
                Development_Rate = 320.99,
                Development_per_hour = 4,
                Hosting_add_emails = 265.00,
                Maintain_website = 150.00
            };

            InvoiceItems item7 = new InvoiceItems()
            {
                Testing_Rate = 320.00,
                Testing_per_hour = 6.5,
                Development_Rate = 320.00,
                Development_per_hour = 4.5,
                Maintain_website = 150.00
            };

            InvoiceItems item8 = new InvoiceItems()
            {
                Testing_Rate = 320.00,
                Testing_per_hour = 6.2,
                Development_Rate = 350.00,
                Development_per_hour = 4,
                Debugging = 185.00
            };

            InvoiceItems item9 = new InvoiceItems()
            {
                Testing_Rate = 320.95,
                Testing_per_hour = 6.2,
                Development_Rate = 420.00,
                Development_per_hour = 5,
                Maintain_website = 150.00
            };

            InvoiceItems item10 = new InvoiceItems()
            {
                Testing_Rate = 320.95,
                Testing_per_hour = 6.2,
                Development_Rate = 220.00,
                Development_per_hour = 4.3,
                Maintain_website = 230.99
            };

            InvoiceItems item11 = new InvoiceItems()
            {
                Testing_Rate = 320.00,
                Testing_per_hour = 7,
                Development_Rate = 320.00,
                Development_per_hour = 5.5,
                Api_Development = 350.00,
                Maintain_website = 150.00
            };

            InvoiceItems item12 = new InvoiceItems()
            {
                Testing_Rate = 409.00,
                Testing_per_hour = 6,
                Development_Rate = 300.00,
                Development_per_hour = 5,
                Security_patches = 420.00,
                Consultation_fee = 100.00
            };
            #endregion

            //Items List (12 Items of each Invoice)
            List<InvoiceItems> collectionInvoiceItems = new List<InvoiceItems>();
            collectionInvoiceItems.Add(item1);
            collectionInvoiceItems.Add(item2);
            collectionInvoiceItems.Add(item3);
            collectionInvoiceItems.Add(item4);
            collectionInvoiceItems.Add(item5);
            collectionInvoiceItems.Add(item6);
            collectionInvoiceItems.Add(item7);
            collectionInvoiceItems.Add(item8);
            collectionInvoiceItems.Add(item9);
            collectionInvoiceItems.Add(item10);
            collectionInvoiceItems.Add(item11);
            collectionInvoiceItems.Add(item12);

            //If Statements:
            #region January 
            DateTime dt = DateTime.Now; // Get the Month we are in
            if (dt.Month == 1) 
            {
                // ONLY January Month
                InvoiceSystem invoiceCollection = collectionOfInvoices[0]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[0];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- " ,
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Consultation                      |     n/a               |    R {1}                 |    R {1}   \n" +
                    "Testing                           |     {3}               |    R {2}              |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {5}               |    R {4}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Planning                          |     {7}               |    R {6}                 |    R " + itemsCollection.Planning_per_hour * itemsCollection.Planning_Rate ,
                    itemsCollection.Description,
                    itemsCollection.Consultation_fee,
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Planning_Rate,
                    itemsCollection.Planning_per_hour);

   
                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                    "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour)
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour)
                    + itemsCollection.Consultation_fee 
                    + (itemsCollection.Planning_Rate * itemsCollection.Planning_per_hour)); 
            }

            #endregion

            #region February
            else if (dt.Month == 2)
            {
                //ONLY February Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[1]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[1];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + 
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}              |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}               |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Database Service                  |     n/a               |    R {4}                 |    R {4}",
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Database_server);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                    "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount  
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour) 
                    + itemsCollection.Database_server);  
            }

            #endregion

            #region March
            else if (dt.Month == 3)
            {
                //ONLY March Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[2]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[2];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                     "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}              |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}               |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate,
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                    "                                                               Total Invoice Amount: |    R ");

                //Calculate
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour));

  
            }

            #endregion

            #region April
            else if (dt.Month == 4)
            {
                //ONLY April Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[3]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[3];   //Items List 


                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}               |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}               |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Application Hosting               |     n/a               |    R {4}                |    R {4}",
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Hosting);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");

                //Calculate
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour 
                    + itemsCollection.Hosting));
            }

            #endregion

            #region May
            else if (dt.Month == 5)
            {
                //ONLY May Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[4]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[4];   //Items List 


                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");
                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}                 |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}               |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate,
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour)); 

            }

            #endregion

            #region June
            else if (dt.Month == 6)
            {
                //ONLY June Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[5]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[5];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}                 |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}                 |    R {2}              |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Add Email (3x)                    |     n/a               |    R {4}                 |    R {4} \n" +
                    "Maintain of Website               |     n/a               |    R {5}                 |    R {5}",
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Hosting_add_emails,
                    itemsCollection.Maintain_website);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour
                    + itemsCollection.Hosting_add_emails 
                    + itemsCollection.Maintain_website)); 

            }

            #endregion

            #region July
            else if (dt.Month == 7)
            {
                //ONLY July Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[6]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[6];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}                 |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}               |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Updated Pictures in the           |     n/a               |    R {4}                 |    R {4} \n"+
                    "Application",
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Maintain_website);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour
                    + itemsCollection.Maintain_website)); 

            }

            #endregion

            #region August
            else if (dt.Month == 8)
            {
                //ONLY August Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[7]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[7];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}                 |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}                 |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Debugging                         |     {1}               |    R {4}                 |    R " + itemsCollection.Debugging * itemsCollection.Testing_per_hour,
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Debugging);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour)
                    + (itemsCollection.Debugging * itemsCollection.Testing_per_hour)); 

            }

            #endregion

            #region September
            else if (dt.Month == 9)
            {
                //ONLY September Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[8]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[8];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                          " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}              |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}                 |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Other Services                    |     n/a               |    R {4}                 |    R {4}",
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Maintain_website);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour)
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour)
                    + itemsCollection.Maintain_website); 

            }

            #endregion

            #region October
            else if (dt.Month == 10)
            {
                //ONLY October Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[9]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[9];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                         " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}               |    R {0}              |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}               |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Scaling and Maintaing             |     n/a               |    R {4}              |    R {4}",
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Maintain_website);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour 
                    + itemsCollection.Maintain_website)); 

            }

            #endregion

            #region November
            else if (dt.Month == 11)
            {
                //ONLY November Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[10]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[10];   //Items List 


                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                         " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}                 |    R {0}                 |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}               |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "API Development                   |     n/a               |    R {4}                 |    R {4} \n" +
                    "Updated Report Lists              |     n/a               |    R {5}                 |    R {5}",
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Api_Development,
                    itemsCollection.Maintain_website);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour
                    + itemsCollection.Api_Development 
                    + itemsCollection.Maintain_website)); 

            }

            #endregion

            #region December
            else if (dt.Month == 12)
            {
                //ONLY December Month
                //
                InvoiceSystem invoiceCollection = collectionOfInvoices[11]; //Invoices List
                InvoiceItems itemsCollection = collectionInvoiceItems[11];   //Items List 

                //InvoiceSystem Properties
                Console.WriteLine(dt.ToString("MMMM") + " " + "Month" + "\n\n" + //Convert the Number of the Month into Words.
                    "-------------------------------------------------------------------------------------------------------------------- \n" +
                    "Invoice Reference Number: {0} " + "                                                         " + "Date: {1} \n" +
                    "                                                                                          " + "Due Date: {2} \n" +
                    "-------------------------------------------------------------------------------------------------------------------- ",
                     invoiceCollection.InvoiceReferenceNumber,
                     invoiceCollection.InvoiceDate.ToShortDateString(),
                     invoiceCollection.InvoiceDueDate.ToShortDateString());

                //Heading
                Console.WriteLine("Description                      " + " | " + "   Hours             " + " | " + "   Unit Price           " + " | " + "   Amount \n" +
                "-------------------------------------------------------------------------------------------------------------------- ");

                //Invoice Items Properties
                Console.WriteLine("Testing                           |     {1}                 |    R {0}                 |    R " + itemsCollection.Testing_per_hour * itemsCollection.Testing_Rate + "\n" +
                    "Development                       |     {3}                 |    R {2}                 |    R " + itemsCollection.Development_per_hour * itemsCollection.Development_Rate + "\n" +
                    "Security Patches                  |     n/a               |    R {4}                 |    R {4} \n" +
                    "Consultation                      |     n/a               |    R {5}                 |    R {5}",
                    itemsCollection.Testing_Rate,
                    itemsCollection.Testing_per_hour,
                    itemsCollection.Development_Rate,
                    itemsCollection.Development_per_hour,
                    itemsCollection.Security_patches,
                    itemsCollection.Consultation_fee);

                //Total Invoice Amount Calculate and Displayed!
                Console.Write("-------------------------------------------------------------------------------------------------------------------- \n" +
                                  "                                                               Total Invoice Amount: |    R ");

                //Calculate:
                Console.WriteLine(invoiceCollection.TotalInvoiceAmount 
                    = (itemsCollection.Testing_Rate * itemsCollection.Testing_per_hour) 
                    + (itemsCollection.Development_Rate * itemsCollection.Development_per_hour 
                    + itemsCollection.Security_patches
                    + itemsCollection.Consultation_fee)); 

            }

            #endregion

            //else statement:
            else
            {
                Console.WriteLine("Seems like there is no Month to Calculate!");
            }

        }
    }
}
