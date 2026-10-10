namespace Assignment_C__Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Answer 01
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            //Console.WriteLine($"All Grades: {string.Join(", ", grades)}");
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades.First()}");
            //Console.WriteLine($"Last Grade: {grades.Last()}");

            //grades.Sort();
            //Console.WriteLine(string.Join(", ", grades));

            //int firstAbove90 = grades.First(g => g > 90);
            //Console.WriteLine(firstAbove90);

            //var failingGrades = grades.Where(g => g < 75).ToList();
            //Console.WriteLine(string.Join(", ", failingGrades));

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine(string.Join(", ", grades));

            //bool has100 = grades.Contains(100);
            //Console.WriteLine(has100);

            //List<string> formattedGrades = grades.Select(g => $"Grade: {g}").ToList();
            //foreach (var item in formattedGrades)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Answer 02
            //SortedList<int, string> leaderboard = new SortedList<int, string>()
            //{
            //    { 500, "Ahmed" },
            //    { 200, "Sara" },
            //    { 800, "Ali" },
            //    { 350, "Mona" }
            //};

            //foreach (var kvp in leaderboard)
            //{
            //    Console.WriteLine($"Score: {kvp.Key}  Player: {kvp.Value}");
            //}

            //int firstKey = leaderboard.Keys[0];
            //string firstValue = leaderboard.Values[0];
            //Console.WriteLine($"Key: {firstKey}, Value: {firstValue}");

            //bool has500 = leaderboard.ContainsKey(500);
            //Console.WriteLine(has500);

            //if (leaderboard.TryGetValue(999, out string? player999))
            //{
            //    Console.WriteLine($"Player found: {player999}");
            //}
            //else
            //{
            //    Console.WriteLine("Player with score 999 not found! (Handled safely without exception)");
            //}

            //leaderboard.Remove(200);
            //foreach (var kvp in leaderboard)
            //{
            //    Console.WriteLine($"Score: {kvp.Key} -> Player: {kvp.Value}");
            //}
            #endregion


            #region Answe 03
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //    { "Ahmed", "01012345678" },
            //    { "Sara", "01198765432" },
            //    { "Ali", "01233344455" },
            //    { "Mona", "01599887766" }
            //};

            //phoneBook["Khaled"] = "01000000000";

            //try
            //{
            //    phoneBook.Add("Ahmed", "01111111111"); 
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error caught: {ex.Message}");
            //}

            //bool added = phoneBook.TryAdd("Sara", "02222222222");
            //Console.WriteLine($"TryAdd duplicate 'Sara' succeeded? {added}");

            //bool found = phoneBook.ContainsKey("Ibrahim");
            //Console.WriteLine($"Does 'Ibrahim' exist? {found}");

            //string searchResult = phoneBook.GetValueOrDefault("Ibrahim", "Not Found");
            //Console.WriteLine($"Search for Ibrahim: {searchResult}");

            //Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
            //Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
            //#endregion


            //#region Answer 04
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com"); 

            //Console.WriteLine($"Stored emails count: {emails.Count}");

            //HashSet<int> setA = [1, 2, 3, 4, 5];
            //HashSet<int> setB = [4, 5, 6, 7, 8];

            //HashSet<int> unionSet = new HashSet<int>(setA);
            //unionSet.UnionWith(setB);
            //Console.WriteLine("UnionWith: " + string.Join(", ", unionSet));

            //HashSet<int> intersectSet = new HashSet<int>(setA);
            //intersectSet.IntersectWith(setB);
            //Console.WriteLine("IntersectWith: " + string.Join(", ", intersectSet));

            //HashSet<int> exceptSet = new HashSet<int>(setA);
            //exceptSet.ExceptWith(setB);
            //Console.WriteLine("ExceptWith: " + string.Join(", ", exceptSet));

            //bool isSubset = new HashSet<int> { 1, 2 }.IsSubsetOf(setA);
            //Console.WriteLine($"Is {{1, 2}} a subset of Set A? {isSubset}");
            #endregion

            #region Answer 05
            //Queue<string> printQueue = new Queue<string>();
            //printQueue.Enqueue("Report.pdf");
            //printQueue.Enqueue("Invoice.pdf");
            //printQueue.Enqueue("Letter.docx");
            //printQueue.Enqueue("Resume.pdf");
            //printQueue.Enqueue("Photo.jpg");

            //Console.WriteLine($"Queue Count: {printQueue.Count}");
            //Console.WriteLine($"Queue items: {string.Join(", ", printQueue)}");

            //Console.WriteLine($"Next up (Peek): {printQueue.Peek()}");

            //Console.WriteLine("\nProcessing Print Queue:");
            //while (printQueue.Count > 0)
            //{
            //    string doc = printQueue.Dequeue();
            //    Console.WriteLine($"Printing: [{doc}]");
            //}

            //bool success = printQueue.TryDequeue(out string? result);
            //Console.WriteLine($"\nTryDequeue on empty queue succeeded? {success}, Result: {result ?? "null"}");
            #endregion




            #region Answer 06
            Stack<string> history = new Stack<string>();

            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");

            Console.WriteLine($"Current Page (Peek): {history.Peek()}");



            for (int i = 0; i < 3; i++)
            {
                string leftPage = history.Pop();
                Console.WriteLine($"Left page: {leftPage}");
            }

            Console.WriteLine($"\nCurrent Page after going back: {history.Peek()}");

            while (history.Count > 0)
            {
                history.Pop();
            }

            bool popped = history.TryPop(out string? emptyResult);
            Console.WriteLine($"TryPop on empty stack succeeded? {popped}");
            #endregion
        }
    }
}
