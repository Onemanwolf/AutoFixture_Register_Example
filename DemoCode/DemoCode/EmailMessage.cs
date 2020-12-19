using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class EmailMessage
    {
        public Guid Id { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsImportant { get; set; }


        public EmailMessage(Guid id,
                   string toAddress,
                   string fromAddress,
                   string subject,
                   string body,
                   bool isImportant)
        {
            Id = id;
            ToAddress = toAddress;
            FromAddress = fromAddress;
            Subject = subject;
            Body = body;
            IsImportant = isImportant;
        }
    }
}
