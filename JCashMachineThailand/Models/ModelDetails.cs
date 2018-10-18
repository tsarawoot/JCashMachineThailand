﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JCashMachineThailand.Models
{

    public class ModelDetails
    {
        private List<Product> products { get; set; }
        private List<Service> services { get; set; }

        public ModelDetails()
        {

        }

        public List<Product> GetProducts()
        {
            products = createProdocts();
            return products;
        }

        public List<Service> GetServices()
        {
            services = createServices();
            return services;
        }

        private List<Product> createProdocts()
        {
            //iPRO-RC
            Product iproRc = new Product
            {
                Code = 4089,
                Name = "iPRO-RC",
                Image = "ipro-rc.png",
                Info = "Built on the UBA platform, UBA Recycler recycles two denominations, $5 to $100 notes, selectable via protocol command. " +
                "UBA-RC uses the innovative Roller Friction Recycling Technology to hold up to 100 banknotes in each recycling chamber"
            };
            //iPRO-SS
            Product iproSs = new Product
            {
                Code = 4089,
                Name = "iPRO-SS",
                Image = "ipro-ss.png",
                Info = "iPro is the successor of UBA-1x/2x series with faster note-to-note speed and state-of-the-art sensor technology" +
                " while still keeping the same interface, dimension and mounting options."
            };
            //TBV
            Product tbv = new Product
            {
                Code = 4060,
                Name = "TBV",
                Image = "tbv.png",
                Info = "TBV is a new series of bill acceptor from JCM that is exclusively designed for commercial applications " +
                "(retail safes, kiosks, ticketing, small banking, etc)"
            };
            //iVIZION
            Product ivizion = new Product
            {
                Code = 4074,
                Name = "iVIZION",
                Image = "ivizion.png",
                Info = "Some product information"
            };
            //DBV-500
            Product dbv500 = new Product
            {
                Code = 4104,
                Name = "DBV-500",
                Image = "dbv500.png",
                Info = "Some product information"
            };
            //DBV-400
            Product dbv400 = new Product
            {
                Code = 4107,
                Name = "DBV-400",
                Image = "dbv400.png",
                Info = "Some product information"
            };
            //VEGA
            Product vega = new Product
            {
                Code = 4064,
                Name = "VEGA",
                Image = "vega.png",
                Info = "Vega is the compact bill acceptor with a lockable removable cash box and flexible options."
            };
            //PUB
            Product pub = new Product
            {
                Code = 4045,
                Name = "PUB-7/11",
                Image = "pub.png",
                Info = "Some product information"
            };
            //-------------------
            //return product list
            return new List<Product>() { iproRc, iproSs, tbv, ivizion, dbv500, dbv400, vega, pub };
        }

        private List<Service> createServices()
        {
            //1. Software Development Center
            Service sdc = new Service
            {
                Name = "Software Support Center.",
                Info = "We are ready for all cases of requested to upgrade our machine for the best performance" +
                    " Such as the new banknotes printed, removing the outmoded banknotes or event the special modification for customer."
            };
            //2. Technical Information Services
            Service tis = new Service
            {
                Name = "Technical Information Services.",
                Info = "Contact us when you have any questions of our Banknotes Acceptor, we promptly serve your acquiring an any technical question by profesional engineer."
            };
            //return services list.
            return new List<Service> { sdc, tis };
        }
    }

    public class Product
    {
        public uint Code { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Info { get; set; }
    }

    public class Service
    {
        public string Name { get; set; }
        public string Info { get; set; }
    }
}