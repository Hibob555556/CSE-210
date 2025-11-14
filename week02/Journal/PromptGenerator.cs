namespace Journal
{
    class PromptGenerator
    {
        public List<string> _prompts;

        public string GetRandomPrompt()
        {
            // store random prompts to give the user in an array of type string
            string[] randomPrompts = [
                "What was the best part of my day?",
                "Did I meet anyone new today?",
                "What was the emotion I felt the most today?",
                "Did I feel validated in my feelings today?",
                "Did I go anywhere fun today?"
            ];

            // generate a number between 0 and the length of the random prompts array length.
            // this allows you to add additional prompts without having to modify this code.
            Random rnd = new();
            int promptIndex = rnd.Next(0, randomPrompts.Length);

            // get and return the random prompt. This could be one line but this feels easier to read.
            string prompt = randomPrompts[promptIndex];
            return prompt;
        }
    }
}