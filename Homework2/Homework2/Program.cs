namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deyisen = Console.ReadLine(); 
            string trimeden = Trimmetodu(deyisen);
            Console.WriteLine(trimeden);

            

        }

        static string Trimmetodu(string name)
        {
            if (name == null)
            {
                return null;
            }

            int start = 0;
            int end = name.Length - 1;

            while (start <= end && char.IsWhiteSpace(name[start]))
            {
                start++;
            }

            while (end >= start && char.IsWhiteSpace(name[end]))
            {
                end--;
            }

            return name.Substring(start, end - start + 1);

        }
    }
}
