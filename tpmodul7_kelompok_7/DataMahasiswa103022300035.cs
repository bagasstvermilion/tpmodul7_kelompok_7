﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    class DataMahasiswa103022300035
    {
        public NamaMHS nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    class NamaMHS
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
}
