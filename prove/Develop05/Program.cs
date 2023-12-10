using System;
using System.Collections.Generic;

namespace Develop05
{
    class Program
    {
        static void Main()
        {
            GoalList goalList = new GoalList();
            Menu menu = new Menu();
            while (true)
            {
                menu.PrintTotalPoints();
                menu.StartMenu();
                if (menu.GetSelection() == "1")
                {
                    
                    menu.SelectType();
                    if (menu.getType() == "1")
                    {
                        
                        Simple simple = new Simple();
                        List<string> simpleGoal = simple.CreateGoal();
                        goalList.AddGoal(simpleGoal);
                    } else if (menu.getType() == "2")
                    {
                        Eternal eternal = new Eternal();
                        List<string> eternalGoal = eternal.CreateGoal();
                        goalList.AddGoal(eternalGoal);
                    } else if (menu.getType() == "3")
                    {
                        
                        Checklist checklist = new Checklist();
                        List<string> checklistGoal = checklist.CreateGoal();
                        goalList.AddGoal(checklistGoal);
                    } else
                    {
                        
                        Console.WriteLine("Invalid Selection | Please Try Again");
                    }

                } else if (menu.GetSelection() == "2")
                {
                   
                    int goalNumber = 1;
                    string isComplete = " ";
                    Console.WriteLine("The goals are:");
                    foreach (List<string> goal in goalList.GetGoals())
                    {
                        switch(goal[0])
                        {
                            case "Simplegoal":
                                if (goal[4] == "True")
                                {
                                    isComplete = "X";
                                } else
                                {
                                    isComplete = " ";
                                }
                                Console.WriteLine($"{goalNumber}. [{isComplete}] {goal[1]} ({goal[2]})");
                                break;

                            case "Eternalgoal":
                                isComplete = " ";
                                Console.WriteLine($"{goalNumber}. [{isComplete}] {goal[1]} ({goal[2]})");
                                break;

                            case "Checklistgoal":
                                if (goal[5] == goal[6])
                                {
                                    isComplete = "X";
                                }
                                Console.WriteLine($"{goalNumber}. [{isComplete}] {goal[1]} ({goal[2]}) -- Currently completed: {goal[6]}/{goal[5]}");
                                break;
                        }
                        goalNumber += 1;
                    }

                } else if (menu.GetSelection() == "3")
                {
                    
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine() ?? String.Empty;
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach(List<string> goal in goalList.GetGoals())
                        {
                            switch(goal[0])
                            {
                                case "Simplegoal":
                                    outputFile.WriteLine($"{goal[0]},{goal[1]},{goal[2]},{goal[3]},{goal[4]}");
                                    break;

                                case "Eternalgoal":
                                    outputFile.WriteLine($"{goal[0]},{goal[1]},{goal[2]},{goal[3]}");
                                    break;
                                
                                case "Checklistgoal":
                                    outputFile.WriteLine($"{goal[0]},{goal[1]},{goal[2]},{goal[3]},{goal[4]},{goal[5]},{goal[6]}");
                                    break;
                            }
                        }
                    }

                } else if (menu.GetSelection() == "4")
                {
                    //Load goals
                    Console.Write("What is the filename for the goal file? ");
                    string fileName = Console.ReadLine() ?? String.Empty;
                    string [] lines = System.IO.File.ReadAllLines(fileName);
                    var pieces = new List<string>();
                    foreach (string line in lines)
                    {
                        List<string> goal = new List<string>();
                        string[] parts = line.Split(",");
                        goal.AddRange(parts);
                        goalList.AddGoal(goal);
                    }
                    File.Delete(fileName);

                } else if (menu.GetSelection() == "5")
                {
                    //Record event
                    Console.WriteLine("The goals are:");
                    int goalNumber = 1;
                    foreach (List<string> goal in goalList.GetGoals())
                    {
                        Console.WriteLine($"{goalNumber}. {goal[1]}");
                        goalNumber += 1;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    string selection = Console.ReadLine();
                    switch(goalList.GetGoals()[Convert.ToInt32(selection) - 1][0])
                    {
                        case "Simplegoal":
                            if (goalList.GetGoals()[Convert.ToInt32(selection) - 1][4] == "False")
                            {
                                goalList.GetGoals()[Convert.ToInt32(selection) - 1][4] = "True";
                                menu.SetTotalPoints(Convert.ToInt32(menu.GetTotalPoints()) + Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][3]));
                            }
                            break;

                        case "Eternalgoal":
                            menu.SetTotalPoints(Convert.ToInt32(menu.GetTotalPoints()) + Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][3]));
                            break;

                        case "Checklistgoal":
                            if (Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][5]) > Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][6]))
                            {
                                goalList.GetGoals()[Convert.ToInt32(selection) - 1][6] = Convert.ToString(Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][6]) + 1);
                                if (Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][5]) > Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][6]))
                                {
                                    menu.SetTotalPoints(Convert.ToInt32(menu.GetTotalPoints()) + Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][3]));
                                } else if (Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][5]) == Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][6]))
                                {
                                    menu.SetTotalPoints(Convert.ToInt32(menu.GetTotalPoints()) + Convert.ToInt32(goalList.GetGoals()[Convert.ToInt32(selection) - 1][4]));
                                }
                            }
                            break;
                        default:
                            break;
                    }

                } else if (menu.GetSelection() == "6")
                {
                    //Quit
                    break;
                } else
                {
                    //Error handling
                    Console.WriteLine("Invalid Selection | Please Try Again");
                }
            }
        }
    }
}