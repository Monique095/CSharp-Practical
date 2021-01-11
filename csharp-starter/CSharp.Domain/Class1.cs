using System;

namespace CSharp.Domain
{
    //All Classes.
    public class InvoiceSystem
    {
        #region Fields

        //Fields
        private DateTime invoiceDate;
        private string invoiceReferenceNumber;
        private DateTime invoiceDueDate;
        private double totalInvoiceAmount;
    

        #endregion

        #region Constructor

        //Constructor 
        public InvoiceSystem()
        {
        }
        public InvoiceSystem(DateTime invoiceDate, string invoiceReferenceNumber, DateTime invoiceDueDate,
            double totalInvoiceAmount) : this() //invoke the default constructor
        {
            this.InvoiceDate = invoiceDate;
            this.InvoiceReferenceNumber = invoiceReferenceNumber;
            this.InvoiceDueDate = invoiceDueDate;
            this.TotalInvoiceAmount = totalInvoiceAmount;
    
        }

        #endregion 

        #region Properties

        //Get and Set Properties
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }

        public string InvoiceReferenceNumber
        {
            get { return invoiceReferenceNumber; }
            set { invoiceReferenceNumber = value; }
        }

        public DateTime InvoiceDueDate
        {
            get { return invoiceDueDate; }
            set { invoiceDueDate = value; }
        }

        public double TotalInvoiceAmount
        {
            get { return totalInvoiceAmount; }
            set { totalInvoiceAmount = value; }
        }

        #endregion

        
    }

    public class InvoiceItems
    {
        #region Fields

        //Fields
        private string description;
        private double testing_rate;
        private double development_rate;
        private double testing_per_hour;
        private double development_per_hour;
        private double consultation_fee;
        private double planning_rate;
        private double planning_per_hour;
        private double database_server;
        private double hosting;
        private double hosting_add_emails;
        private double maintain_website;
        private double debugging;
        private double api_development;
        private double security_patches;


        #endregion

        #region Constructor

        //Constructor
        public InvoiceItems()
        {
        }
        //The Invoked Constructor
        public InvoiceItems(string description, double testing_rate, double development_rate, double testing_per_hour, double development_per_hour, double consultation_fee,
            double rate_per_page,double hosting, double planning_rate, double planning_per_hour, double hosting_add_emails, double maintain_website, double debugging,
            double api_development, double security_patches) : this() //invoke the default constructor
        {
            this.Description = description;
            this.Testing_Rate = testing_rate;
            this.Development_Rate = development_rate;
            this.Testing_per_hour = testing_per_hour;
            this.Development_per_hour = development_per_hour;
            this.Consultation_fee = consultation_fee;
            this.Database_server = database_server;
            this.Hosting = hosting;
            this.Planning_per_hour = planning_per_hour;
            this.Planning_Rate = planning_rate;
            this.Hosting_add_emails = hosting_add_emails;
            this.Maintain_website = maintain_website;
            this.Debugging = debugging;
            this.Api_Development = api_development;
            this.Security_patches = security_patches;
        }

        #endregion

        #region Properties

        //Get and Set Properties of the Fields
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Testing_Rate
        {
            get { return testing_rate; }
            set { testing_rate = value; }
        }
        public double Development_Rate
        {
            get { return development_rate; }
            set { development_rate = value; }
        }
        public double Testing_per_hour
        {
            get { return testing_per_hour; }
            set { testing_per_hour = value; }
        }
        public double Development_per_hour
        {
            get { return development_per_hour; }
            set { development_per_hour = value; }
        }
        public double Consultation_fee
        { 
            get { return consultation_fee; }
            set { consultation_fee = value; }
        }
        public double Database_server
        {
            get { return database_server; }
            set { database_server = value; }
        }
        public double Hosting
        {
            get { return hosting; }
            set { hosting = value; }
        }
        public double Planning_per_hour
        {
            get { return planning_per_hour; }
            set { planning_per_hour = value; }
        }
        public double Planning_Rate
        {
            get { return planning_rate; }
            set { planning_rate = value; }
        }
        public double Hosting_add_emails
        {
            get { return hosting_add_emails; }
            set { hosting_add_emails = value; }
        }
        public double Maintain_website
        {
            get { return maintain_website; }
            set { maintain_website = value; }
        }
        public double Debugging
        {
            get { return debugging; }
            set { debugging = value; }
        }
        public double Api_Development
        {
            get { return api_development; }
            set { api_development = value; }
        }
        public double Security_patches
        {
            get { return security_patches; }
            set { security_patches = value; }
        }

        #endregion
    }


}
