using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For
            //VD1
            //Console.OutputEncoding= Encoding.UTF8;
            //Console.Write("Nhập vào một số: ");
            //int i = Convert.ToInt32(Console.ReadLine());
            //for (int x = 0; x <= i; x++)
            //{
            //    if(x%2 == 0)
            //    {
            //        Console.Write("Các số chẵn là:");
            //        Console.Write("{0} \t", x);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Các số lẻ là: {0}", x);
            //    }
            //}


            //VD2
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.Write("Nhập vào một số: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for(int a = 1; a <= b; a++)
            //{
            //    sum += a;
            //    Console.WriteLine("{0}", a);

            //}
            //Console.WriteLine("Tổng của các số trong dãy là: {0}", sum);

            #endregion

            #region While

            //VD1:
            //int a = 0;
            //while(a < 10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}

            //VD2:
            //Console.OutputEncoding = Encoding.UTF8;
            //int i = 0;
            //Console.Write("Nhập vào 1 số:");
            //int j = Convert.ToInt32(Console.ReadLine());
            //while (i <= j)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            #endregion

            #region Do/While

            //VD
            Console.OutputEncoding = Encoding.UTF8;
            int z = 1;
            int sum = 0;
            do
            {
                Console.WriteLine(z);
                sum += z;
                z++;
            }while(z < 10);
            Console.WriteLine("Tổng các số là: {0}", sum);
            #endregion

            Console.ReadKey();
        }
    }
}

//Cấu trúc lặp
/*
 * Một vòng lặp là một chuỗi các hành động lặp đi lặp lại đến khi thỏa mãn một điều kiện dừng nào đó
 * Kết thúc khi không còn thỏa mãn một điều kiện nào nữa
 * Gồm các loại vòng lặp:
 * - For: Đầu tiên đi vào phần khởi tạo, sau đó so sánh với điều kiện lặp nếu thỏa mãn sẽ thực hiện code, thực hiện xong code sẽ thực hiện bước lặp
 * Cú pháp: for ("Khởi tạo"; "Điều kiện lặp"; "Bước lặp")
 * {
 *      Code
 *      Khối lệnh được lặp lại
 * }
 * 
 * - While: Điều kiện lặp là một biểu thức logic bắt buộc phải có với kết quả trả về bắt buộc là true hoặc false.
 * Từ khóa while biểu thị đây là một vòng lặp while. 
 * Các câu lệnh trong khối lệnh sẽ được lặp lại đến khi không còn thỏa mãn điều kiện lặp sẽ kết thúc vòng lặp while
 * Cú pháp:
 *  while (<Điều kiện lặp>)
 *  {
 *      // [câu lệnh];
 *  }
 * 
 * - Do/While
 * Tương tự như vòng lặp while
 * Vòng lặp này sẽ thực thi khối mã một lần, thực hiện câu lệnh trong khối code trước rồi mới kiểm tra điều kiện lặp,
 * sau đó sẽ lặp lại vòng lặp miễn là điều kiện đó còn đúng.
 * Cú pháp:
 * do {
 *      [câu lệnh];
 *    }
 * while (<điều kiện lặp>);
 */