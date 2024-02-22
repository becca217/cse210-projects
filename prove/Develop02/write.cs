// Option 1
public class Write
    {
        public List <string> prompts = new List<string>()
        {
            "What was the highlight of my day?",
            "What lesson(s) did I learn today?",
            "What should I celebrate about today?",
            "Who made an impact on me today?",
            "What am I grateful about today?"
        };

        public void DisplayWrite()
        {
            Random random = new Random ();
            int randomPrompt = random.Next(prompts.Count);
            
            Console.WriteLine ($"Your prompt is: {prompts[randomPrompt]} ");
        }
        
    }