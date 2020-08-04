using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MallFormulär.DTO
{
    public class Bas
    {
        [Required, StringLength(5, MinimumLength = 1)]
        public string BasText { get; set; }
        [Range(10, 20)]
        public int BasTal { get; set; }
    }
    public class DataA:Bas
    {
        [Range(100,200)]
        public int TalA { get; set; }
    }
    public class DataB : Bas
    {
        [Required, StringLength(10, MinimumLength = 2)]
        public string TextB { get; set; }
    }
}
