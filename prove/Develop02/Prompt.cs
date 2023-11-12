using System;

public class Prompt
{
    List<int> usedPrompts = new List<int>();

    public string GetPrompts()
    {
      string prompt ="";
      List<string> prompts = new List<string>()
      {
        "What was the most peaceful moment during the day?",
        "Describe something you learned today that you didn’t know before.",
        "Would you change any of the decisions you made today?",
        "How were your meals today? Do you feel nourished?",
        "What frightened you today?",
        "Who do you wish you had talked to today? How do they improve your life?",
        "Describe the moments of frustration you felt today. How would your day have changed if those moments were different?",
        "If you’d had another hour during the day, how would you have spent it?",
        "Did something (or someone) empower you today?",
        "Did you stop yourself from doing something you enjoy today? Why or why not?",
        "Reflect on how your body feels. Where are you storing your stress? What put it there?",
        "Who helped you the most today? Who did you help the most?",
        "Describe your day from another person’s perspective. Is it different from yours?",
        "What was the most peaceful moment during the day?",
        "Describe something you learned today that you didn’t know before.",
        "Would you change any of the decisions you made today?",
        "How were your meals today? Do you feel nourished?",
        "What frightened you today?",
        "Who do you wish you had talked to today? How do they improve your life?",
        "Describe the moments of frustration you felt today. How would your day have changed if those moments were different?",
        "If you’d had another hour during the day, how would you have spent it?",
        "Did something (or someone) empower you today?",
        "Did you stop yourself from doing something you enjoy today? Why or why not?",
        "Reflect on how your body feels. Where are you storing your stress? What put it there?",
        "Who helped you the most today? Who did you help the most?",
        "Describe your day from another person’s perspective. Is it different from yours?",
        "What would you do if you found a puppy in the street?",
        "What would you do with a million dollars if you had to spend it in one hour?",
        "What would you do if you needed to change your career or major?",
        "What would you do if you could suddenly read minds?",
        "What would you do if you were locked out of your house?",
        "What would you do if your loved one were accused of a crime?",
        "What would you do if you were stranded on a desert island with someone you dislike?",
        "What would do if you lost all your possessions? What would you replace? What wouldn’t you replace?",
        "What would you do if you lost one of your senses? Which would be the most difficult one to lose?",
      };
      

      Random rand = new Random();
      int num = rand.Next(0, prompts.Count);

      if (usedPrompts.Count() < 35)  
      {
        if (!usedPrompts.Contains(num))
        {
          
          usedPrompts.Add(num);
          prompt = prompts[num];
        }
        else{
          GetPrompts();
        }
      }
      else
      {
        Console.WriteLine("There are no more prompts for today!");
      }
      return prompt;
    }
}