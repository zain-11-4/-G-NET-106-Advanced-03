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
        }
    }
}
