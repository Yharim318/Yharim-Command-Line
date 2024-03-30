﻿Console.WriteLine("Welcome to Yharim's Command Line!");
Console.WriteLine("----------------------------------");
List<string> activities = ["Bozo Calculator", "Raffle", "Sing", "Seconds Alive", /*"",*/ "Quit"];
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
    return Console.ReadLine();
}
int PromptInt(string message){
    Console.WriteLine(message);
    string indexString = Console.ReadLine();
    int index;
    try{
        index = Convert.ToInt32(indexString);
    
    }
    catch{
        Console.WriteLine("That is not a valid number. Please try again!");
        Console.ReadKey();
        Console.Clear();
        index = PromptInt(message);
        
    }
    Console.Clear();
    return index;
}
float PromptFloat(string message){
    Console.WriteLine(message);
    string indexString = Console.ReadLine();
    float index;
    try{
        index = Convert.ToSingle(indexString);
    
    }
    catch{
        Console.WriteLine("That is not a valid number. Please try again!");
        Console.ReadKey();
        Console.Clear();
        index = PromptInt(message);
        
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
    Console.WriteLine("Please choose an activity: ");
    listActivities();
    string indexString = Console.ReadLine();
    int index;
    try{
        index = Convert.ToInt32(indexString);
        if (index > activities.Count || index < 1){
            index = Convert.ToInt16("a");
        }
    }
    catch{
        Console.WriteLine("That is not a valid number. Please try again!");
        Console.ReadKey();
        Console.Clear();
        index = Prompt();
        
    }
    return index;
    
}
void Sing(){
    Console.Beep();
    Console.WriteLine("Jumpscare!");
    Console.ReadKey();
    Console.Clear();
}
void SecondsAlive(){
    float years = PromptFloat("How many years have you been alive?");
    double seconds = years * 31536000;
    Console.WriteLine($"You have been alive for:\n{seconds}\nseconds!");
    Console.ReadKey();
    Console.Clear();
}

