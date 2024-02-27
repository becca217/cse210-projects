public class Save
{
    public static void SaveToFile (List<string>entries)
    {
        string filename = "journalfile.csv";
        using (StreamWriter outputFile = new StreamWriter (filename))
        {
            foreach (entry e in entries)
            {
                outputFile.WriteLine (e.entries);
            }
        }
    }
}