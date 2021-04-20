using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo.Entities
{
    public class TodoSample
    {
        // BURADA DB OLUŞACAK STÜNLARI BELİRLİYORUZ.
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key + Identity=Yes
        public int ID { get; set; }
        [StringLength(50)] // nvarChar(50) Yapıyor. Aksi halde MAX girer.
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedData { get; set; }
        public int Status { get; set; }
    }
}
