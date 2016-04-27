using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using c_labs.common;

namespace c_labs.common
{
    class Utils
    {
        /*
        public static List<ExcelParser> parserExcel(int sheet, string path)
        {
            var book = new ExcelQueryFactory(path);
            var resultado = (from row in book.Worksheet("Hoja1")
                             let item = new ExcelParser
                             {
                                 Id = row[0].Cast<string>(),
                                 Nombre = row[1].Cast<string>(),
                                 Apellidos = row[2].Cast<string>()
                             }
                             select item).ToList();

            book.Dispose();
            return resultado;
        }
        */



        public static Double rateM(double rate)
        {
            return Math.Pow(1.0 + rate / 100.0, 1.0 / 12.0) - 1.0;
        }

        public static Double payment(double rate, double installment, double amount)
        {
            double tasaM = rateM(rate);
            return (amount * tasaM) / (1.0 - Math.Pow((1 + tasaM), -installment * 12.0));
        }

        public static Double calculateRate(double n_periodos, double pago, double monto)
        {
            int i = 0;
            double y = 0;
            double n = n_periodos * 12.0;
            double z = pago / monto;
            double x = 1.1;

            // No iteraremos mas de 50 veces
            while (Math.Floor((y - 1) * 10000) != Math.Floor((x - 1) * 10000) && i < 50)
            {
                y = x;
                x = y - ((Math.Pow(y, n + 1) - (Math.Pow(y, n) * (z + 1)) + z) / (((n + 1) * Math.Pow(y, n)) - (n * (z + 1) * Math.Pow(y, n - 1))));
                i++;
            }
            if (i == 50)
                throw new Exception("No se logro aproximar mediante Newton-Raphson al valor del tasa interes.");
            return x - 1;
        }

        public static void log(String lines)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\xls\\app.log", true);
            file.WriteLine(lines);

            file.Close();
        }

        public static void addOk(String lines)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\xls\\ok.log", true);
            file.WriteLine(lines);

            file.Close();
        }

        public static void addFail(String lines)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\xls\\fail.log", true);
            file.WriteLine(lines);

            file.Close();
        }

        public static void addValidate(String lines)
        {
            //DirectoryInfo DirectoryInfo = new DirectoryInfo("");

            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\xls\\validate.log", true);
            file.WriteLine(lines);

            file.Close();
        }

        public static IList<ValueObject> convertToList(IList<Hashtable> values)
        {
            IList<ValueObject> result = new List<ValueObject>();
            foreach (Hashtable val in values)
            {
                ValueObject o = new ValueObject();
                o.id = Convert.ToInt64(val["id"]);
                o.desc = Convert.ToString(val["desc"]);
                result.Add(o);
            }

            return result;
        }
    }

}
