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
        /*public static void ReadJSONDataMhs()
        {
            string path = @"../../../tp7_1_103022300035.json";
            string jsonString = File.ReadAllText(path);

            var data = JsonSerializer.Deserialize<DataMahasiswa103022300035>(jsonString);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");

        }*/

        public static void ReadJSONDataMhs()
        {
            string path = @"../../../tp7_1_103022300021.json";
            string jsonString = File.ReadAllText(path);

            var data = JsonSerializer.Deserialize<DataMahasiswa103022300021>(jsonString);
            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }


        /*public static void ReadJSONKuliahMhs()
        {
            string path = @"../../../tp7_2_103022300035.json";
            string jsonString = File.ReadAllText(path);

            var dataList = JsonSerializer.Deserialize<KuliahMahasiswa103022300035>(jsonString);

            int i = 1;
            foreach (var course in dataList.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }*/

        public static void Main(string[] args)
        {
            ReadJSONDataMhs();
            Console.WriteLine();
            //ReadJSONKuliahMhs();
        }
    }
}
