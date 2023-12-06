﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessage.Models.Response
{
    public class MessageResponse
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public string SenderId { get; set; }

        public string SenderName { get; set; }

        public string SenderAvatar { get; set; }

        public string Time { get; set; }
    }
}
