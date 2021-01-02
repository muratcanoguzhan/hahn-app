﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.December2020.Domain.Applicants.Dtos
{
    public class ApplicantDto
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public string FamilyName { get; set; }
        public string Address { get; set; }
        public string CountryOfOrigin { get; set; }
        public string EmailAdress { get; set; }
        public int Age { get; set; }
        public bool Hired { get; set; }
    }
}