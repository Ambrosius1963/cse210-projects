public class PromptGen {

    public List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is the most important thing that you want to share with your kids?",
            "What type of person do you want to be remembered as at your funeral?",
            "What are three things you're grateful for today, and why?",
            "Describe a challenge you faced today and how you overcame it.",
            "Write about a moment that brought you joy or made you smile.",
            "Reflect on a mistake you made and what you learned from it.",
            "How do you want to improve yourself, and what steps can you take to achieve that?",
            "Write a letter to your future self, describing your aspirations and goals.",
            "What are your favorite qualities in a friend, and do you possess those qualities yourself?",
            "If you could travel anywhere in the world, where would you go and why?",
            "Explore a childhood memory that still resonates with you.",
            "Describe a book, movie, or song that had a profound impact on you and explain why.",
            "Reflect on a time when you stepped out of your comfort zone and what you gained from the experience.",
            "Write about a role model or someone you admire and the qualities you admire in them.",
            "Explore your dreams and aspirations for the future.",
            "What are your favorite ways to practice self-care and relaxation?",
            "Describe a recent accomplishment that you're proud of.",
            "Write about a moment when you felt truly at peace.",
            "Reflect on a lesson you learned from a difficult experience.",
            "If you could have a conversation with someone, living or dead, who would it be and why?",
            "Explore your relationship with time. Do you feel rushed, or do you have a sense of balance?",
            "Write about a goal you have for the upcoming month and the steps you'll take to achieve it."
        };
    public string GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

}