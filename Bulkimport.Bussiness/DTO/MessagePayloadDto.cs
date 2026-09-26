using System;
using System.Collections.Generic;
using System.Text;

namespace Bulkimport.Bussiness.DTO
{
    public class MessagePayloadDto
    {
        public string eventType { get; set; }
        public Guid ID { get; set; }
        public int totalrecord { get; set; }
        public int Validcount { get; set; }
        public int invalidcount { get; set; }
        public DateTime ProcessingDurationMs { get; set; }
        public DateTime CompletedAt { get; set; }






    }
}
