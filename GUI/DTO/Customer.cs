﻿using System;
using System.Data;
using System.Linq;

namespace GUI.DTO
{
    public class Customer
    {
        public Customer(string iD, string name, DateTime birth, string address,
            string phone, int identityCard)
        {
            this.ID = iD;
            this.Name = name;
            this.BirthDate = birth;
            this.Address = address;
            this.Phone = phone;
            this.IdentityCard = identityCard;
        }

        public Customer(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.Name = row["HoTen"].ToString();
            this.BirthDate = DateTime.Parse(row["NgaySinh"].ToString());
            this.Address = row["DiaChi"].ToString();
            this.Phone = row["SDT"].ToString();
            this.IdentityCard = (int)row["CMND"];
        }

        public string ID { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public int IdentityCard { get; set; }

    }
}
