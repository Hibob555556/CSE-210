namespace Journal
{
    class Journal
    {
        public List<Entry> _entries = [];

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            _entries.ForEach((entry) =>
            {
                // create entry header text
                string displayHeader = $"{entry._date} | {entry._promptText.Trim()}";

                // write the header
                Console.WriteLine(Environment.NewLine + displayHeader);

                // display a divider in between the entry header and text
                int textLen = displayHeader.Length;
                for (int i = 0; i < textLen + 2; i++)
                    Console.Write("-");

                // display the entry text
                Console.WriteLine(Environment.NewLine + entry._entryText + Environment.NewLine);
            });
        }

        public void SaveToFile()
        {

        }

        public void LoadFromFile(string file)
        {

        }

        public void CreateEntry(bool newLine = false)
        {
            // create a new prompt generator and journal
            PromptGenerator pg = new();

            // get a random prompt for the user
            string prompt = $"{pg.GetRandomPrompt()} ";
            if (!newLine)
                Console.Write(prompt);
            else
                Console.WriteLine(prompt);
            string response = Console.ReadLine();

            // get the current time (the time the response was submitted)
            string time;
            time = DateTime.Now.ToString();

            Entry e = new()
            {
                _promptText = prompt,
                _entryText = response,
                _date = time
            };

            AddEntry(e);
        }
    }
}