﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models.Enums;

namespace Web.Models.Entities
{
    [Table("ArızaKayıt")]
    public class TroubleRecord:BaseEntity<int>
    {
        [Column("Beyaz Esya")]
        [DisplayName("Beyaz Eşya Tipi")]
        public Types Types  { get; set; }
        [Column("Marka")]
        [DisplayName("Marka")]
        public BrandTypes BrandTypes { get; set; }
        [Column("Fotoğraf")]
        [DisplayName("Fotoğraf")]
        public string PhotoPath { get; set; }
        [Column("Mesaj")]
        [DisplayName("Arıza Bilgisi")]
        public string Message { get; set; }

    }
}