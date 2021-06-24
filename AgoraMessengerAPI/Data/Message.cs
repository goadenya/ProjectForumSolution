using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraMessengerAPI.Data
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public string Id { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
    }
}
