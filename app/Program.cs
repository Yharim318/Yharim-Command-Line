﻿using Microsoft.VisualBasic;

Console.WriteLine("Welcome to Yharim's Command Line!");
Console.WriteLine("----------------------------------");
List<string> activities = ["Bozo Calculator", "Raffle", "Sing", "Seconds Alive", "Count", "Sort", "Quit"];
bool playing = true;
while(playing){
    Start();
}
void Start(){
    int activityIndex = Prompt();
    switch (activityIndex){
        case 1:
            Console.Clear();
            BozoCalculator();
            break;
        case 2:
            Console.Clear();
            Raffle();
            break;
        case 3:
            Console.Clear();
            Sing();
            break;
        case 4:
            Console.Clear();
            SecondsAlive();
            break;
        case 5:
            Console.Clear();
            Count();
            break;
        case 6:
            Console.Clear();
            Sort();
            break;
        default:
            playing = false;
            break;
    }
}
void Raffle(){
    List<string> people = [];
    Random random = new();
    for (int max = PromptInt("How many people?"); people.Count < max; people.Add(PromptString($"{people.Count + 1}. "))) {}
    Console.WriteLine($"{people[random.Next(people.Count-1)]} wins!");
    Console.ReadKey();
    Console.Clear();
}
string PromptString(string message){
    Console.Write(message);
    string? output = Console.ReadLine();
    return output;
}
int PromptInt(string message){
    Console.WriteLine(message);
    string? indexString = Console.ReadLine();
    int index;
    try{
        index = Convert.ToInt32(indexString);
    
    }
    catch{
        Console.Clear();
        Console.WriteLine("That is not a valid number. Please try again!");
        Console.ReadKey();
        Console.Clear();
        index = PromptInt(message);
        
    }
    Console.Clear();
    return index;
}
float PromptFloatPositive(string message){
    Console.Write(message);
    string? indexString = Console.ReadLine();
    float index;
    try{
        index = Convert.ToSingle(indexString);
        if (index < 0){
            index = Convert.ToByte("Your Mother");
        }
    
    }
    catch{
        Console.Clear();
        Console.WriteLine("That is not a valid number. Please try again!");
        Console.ReadKey();
        Console.Clear();
        index = PromptFloatPositive(message);
        
    }
    Console.Clear();
    return index;
}
float PromptFloat(string message){
    Console.Write(message);
    string? indexString = Console.ReadLine();
    float index;
    try{
        index = Convert.ToSingle(indexString);
    
    }
    catch{
        Console.Clear();
        Console.WriteLine("That is not a valid number. Please try again!");
        Console.ReadKey();
        Console.Clear();
        index = PromptFloat(message);
        
    }
    Console.Clear();
    return index;
}
void listActivities(){
    for (int i = 0; i < activities.Count; i++){
        Console.WriteLine($"{i+1}. {activities[i]}");
    }
}
void BozoCalculator(){
    Console.WriteLine("You are a bozo no doubt!");
    Console.ReadKey();
    Console.Clear();
}
int Prompt(){
    Console.WriteLine("Please choose an activity: \n");
    listActivities();
    string? indexString = Console.ReadLine();
    int index;
    try{
        index = Convert.ToInt32(indexString);
        if (index > activities.Count || index < 1){
            index = Convert.ToInt16("a");
        }
    }
    catch{
        Console.Clear();
        Console.WriteLine("That is not a valid number. Please try again!");
        Console.ReadKey();
        Console.Clear();
        index = Prompt();
        
    }
    return index;
    
}
string EncodeIntToDashes(int i)
{
    return String.Concat(Enumerable.Repeat("-", i));
}
void Sing(){
    Console.Beep();
    Console.WriteLine("Jumpscare!");
    Console.ReadKey();
    Console.Clear();
}
void SecondsAlive(){
    float years = PromptFloat("How many years have you been alive: ");
    double seconds = years * 31536000;
    Console.WriteLine($"You have been alive for:\n{seconds}\nseconds!");
    Console.ReadKey();
    Console.Clear();
}
void Count(){
    double timer = PromptFloatPositive("How many seconds: ");
    double countTo = timer + DateTime.Now.TimeOfDay.TotalSeconds;
    double lastTime = -1;
    // Console.WriteLine(countTo);
    while (DateTime.Now.TimeOfDay.TotalSeconds < countTo){
        double timeLeft = Math.Round(countTo - DateTime.Now.TimeOfDay.TotalSeconds + 0.5);
        if (lastTime != timeLeft){
            Console.Clear();
            Console.WriteLine(timeLeft);
        }
        lastTime = timeLeft;
    }
    Console.Clear();
    Console.WriteLine($"{timer} seconds have elapsed!");
    Console.ReadKey();
    Console.Clear();
}
void Sort(){
    Random random = new Random();
    bool passAgain = true;
    int length = Console.BufferHeight-1;
    int[] ints = new int[length];
    for (int i = 0; i < length; i++) 
    {
        ints[i] = i + 1;
    }
    random.Shuffle(ints);
    while(passAgain)
    {
        passAgain = false;
 
        for (int i = 0; i < ints.Length-1; i++)
        {
            if (ints[i] > ints[i+1])
            {
                Console.Clear();
                int buffer1 = ints[i];
                int buffer2 = ints[i+1];
                ints[i] = buffer2;
                ints[i+1] = buffer1;
                passAgain = true;
                for(int ii = 0; ii < ints.Length; ii++)
                {
                    Console.WriteLine(EncodeIntToDashes(ints[ii]));
                }
                Thread.Sleep(3);                
            }
        }
        
    }
    Console.ReadKey();
    Console.Clear();
}
