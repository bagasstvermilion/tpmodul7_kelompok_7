using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    public class Program
    {
        public static void ReadJSONDataMhs()
        {
            string path = @"../../../tp7_1_103022300011.json";
            string jsonString = File.ReadAllText(path);

            var data = JsonSerializer.Deserialize<DataMahasiswa103022300011>(jsonString);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");

        }

        public static void Main(string[] args)
        {
            ReadJSONDataMhs();
            Console.WriteLine();
        }
    }
}
