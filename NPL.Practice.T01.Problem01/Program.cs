using System.ComponentModel.DataAnnotations;

namespace NPL.Practice.T01.Problem01
{
    internal class Program
    {
        private static decimal[] DrawCircleChart(int[] charInput)
        {
            // Khoi tao bien chua tong cua input
            int sum = 0;
            // Tao vong lap de tinh tong cua input
            for (int i = 0; i < charInput.Length; i++)
            {
                sum += charInput[i];
            }
            // Khoi tao bien chua ket qua
            decimal[] result = new decimal[charInput.Length];
            // Tao vong lap de tinh phan tram cua tung input
            for (int i = 0; i < charInput.Length; i++)
            {
                // Kiem tra neu khong phai so cuoi hi tinh phan tram cua input binh thuong va lay 2 chu so thap phan
                if (i != charInput.Length - 1)
                {
                    result[i] = Math.Round((decimal)charInput[i] / sum * 100, 2);
                }
                // Neu la so cuoi thi se lay 100% tru di tong phan tram cua cac input truoc do
                else
                {
                    result[i] = 100;
                    for (int j = 0; j < result.Length - 1; j++)
                    {
                        result[i] -= result[j];
                    }
                }
            }
            // Tra ve ket qua
            return result;
        }

        static void Main(string[] args)
        {
            // Nhap list cac input tu ban phim
            int n = Validate.ValidateNumber("Input length of array: ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                // Lay gia tri o phan tu thu n
                arr[i] = Validate.ValidateNumber("Value of index " + i + ": ");
            }
            // Lay ket qua tu ham DrawCircleChart
            decimal[] results = DrawCircleChart(arr);
            // In ra ket qua
            Console.Write("Result: ");
            for (int i = 0; i < results.Length; i++)
            {   // In ket qua
                Console.Write(results[i]);
                // Truong hop la so cuoi thi ko co so phay o cuoi
                if (i < results.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}