/*
PromptGenerator

*Provide the user with a randomly selected 
prompt from a list*

*/

public class PromptGenerator
{

    List<string> _prompts = new List<string>
{
    "What made you smile today, and why?",
    "Describe a moment this week when you felt truly at peace.",
    "What’s one thing you were proud of that most people didn't notice?",
    "If today were a chapter title in your life story, what would it be?",
    "What’s something you’ve learned recently that changed your perspective?",
    "What’s a habit you’d like to build, and what’s stopping you?",
    "Who inspires you, and what qualities do they have that you admire?",
    "What does success look like for you this month?",
    "Describe a place that makes you feel safe and why.",
    "What’s a memory you revisit often, and how does it shape you?",
    "What’s one thing you need to let go of?",
    "What does your ideal day look like from morning to night?",
    "What’s a compliment you received that stuck with you?",
    "What’s something you’ve never tried but secretly want to?",
    "What emotion have you felt most strongly this week?",
    "What’s a small win you can celebrate today?",
    "Describe a dream you had recently and what you think it means.",
    "What’s one thing you wish people understood about you?",
    "What does growth mean to you right now?",
    "Who was the most interesting person you interacted with today?",
    "What is one thing you would like to do different today?",
    "What is one thing you would like to do again today?",
    "What is something you'd like to remember?"
};
    public string GeneratePrompt()
    {
        // randomly select an index 
        Random rand = new Random();
        int i = rand.Next(_prompts.Count);

        // return random prompt
        string randomPrompt = _prompts[i];
        return randomPrompt;
    }
}