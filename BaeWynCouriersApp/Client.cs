﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    class Client
    {
        public int ClientId { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public bool Contracted { get; set; }

        public Client()
        {
        }

        //public void AddClient()
        //{
        //}
    }
}
