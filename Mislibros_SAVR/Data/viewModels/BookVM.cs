﻿using System;
using System.Collections.Generic;

namespace Mislibros_SAVR.Data.viewModels
{
    public class BookVM
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public string CoverUrl { get; set; }
        public int PublisherId { get; set; }
        public List<int> AutorIDs { get; set; }
    }
}
