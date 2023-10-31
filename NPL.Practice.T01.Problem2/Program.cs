using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace NPL.Practice.T01.Problem2
{
    internal class Program
    {
        static private List<string> GenerateEmailAddress(List<string> listEmployees)
        {
            // Khoi tao bien Dectionary chua key la ten va value la list email
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();
            // Khai bao domain
            string domain = "@fsoft.com.vn";
            // Tao vong lap listEmployee
            foreach (var item in listEmployees)
            {
                // Cat ten ra thanh list cac tu
                string[] names = Regex.Split(item, @"\s+");
                // Cho ten bat dau tu cuoi cung
                string name = names[names.Length - 1].ToLower();
                // Tao vong lap cho names de lay ra cac chu cai dau va noi vao nhau
                for(int i = 0; i < names.Length - 1; i++)
                {
                    // Cat chu cai dau cua tu va noi vao nhau
                    name += names[i].Substring(0, 1).ToLower();
                }
                // Kiem tra xem name da co trong dictionary chua
                // Neu chua thi them vao
                if (!emails.ContainsKey(name))
                {
                    emails[name] = new List<string>() { name + domain};
                }
                // Neu co thi cong ten voi so luong phan tu co trong list cua dictinary co key la name
                else
                {
                    List<string> list = emails[name];
                    list.Add(name + list.Count() + domain);
                    emails[name] = list;
                }

            }
            // Lay ra ra cac value cua dictionary
            IEnumerable<List<string>> allValues = emails.Values;
            // Tao biet chua ke qua
            List<string> rs = new List<string>();
            // Tao vong lap de lay ra cac email trong cac list
            foreach (List<string> emailList in allValues)
            {
                foreach (string email in emailList)
                {
                    rs.Add(email);
                }
            }

            return rs;
        }
        static void Main(string[] args)
        {
            // Nhap list cac input tu ban phim
            int n = Validate.ValidateNumber("Input length of list name: ");

            List<string> listEmployees = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                // Lay gia tri cua phan tu thu n
                Console.Write($"Value of index {i}: ");
                listEmployees.Add(Console.ReadLine());
            }
            // Lay ket qua tu ham GenerateEmailAddress
            List<string> results = GenerateEmailAddress(listEmployees);
            // In ra ket qua
            Console.WriteLine("Result: ");
            foreach (string emailAddress in results)
            {
                Console.WriteLine(emailAddress);
            }
        }
    }
}