﻿using MailSender.Models.Base;

namespace MailSender.Models
{
    public class Recipient : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
