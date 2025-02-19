public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){
        _score = 0;
        _goals = new();

    
    }

    public void Start()
    {
        while (true)
        {

            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from menu: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice, try again."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames(){
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void ListGoalDetails(){
        Console.WriteLine("The goals are:");
        int goalNumber = 0;
        foreach (Goal goal in _goals){
            Console.WriteLine($"{goalNumber + 1}. {goal.GetDetailsString()}");
            goalNumber ++;
        }
    }

    public void CreateGoal(){
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t 1. Simple Goal");
        Console.WriteLine("\t 2. Eternal Goal");
        Console.WriteLine("\t 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userChoice = Console.ReadLine();

        if (userChoice == "1"){
            Console.Write("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.Write("What is a description of this?");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points that you want associated with this goal? ");
            string input = Console.ReadLine();
            int points = int.Parse(input);
            SimpleGoal simpleGoal = new(name, description, points);
            _goals.Add(simpleGoal);
        }   
        else if (userChoice == "2"){
            Console.Write("What is the name of your goal.");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with the goal? ");
            string input = Console.ReadLine();
            int points = int.Parse(input);
            EternalGoal eternalGoal = new(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (userChoice == "3"){
             Console.Write("What is the name of your goal.");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with the goal? ");
            string input = Console.ReadLine();
            int points = int.Parse(input);
            Console.Write("How many times does this goal need to be accomplished to earn a bonus? ");
            string targetInput = Console.ReadLine();
            int target = int.Parse(targetInput);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusInput = Console.ReadLine();
            int bonus = int.Parse(bonusInput);
            ChecklistGoal checklistGoal = new(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent(){
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals avaiilable to record.");
            return;
        }

        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames();

        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid entry. Please select a valid goal number.");
        }
    }

    public void SaveGoals(){
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Goal goal in _goals){
                string goalString = goal.GetStringRepresentation();
                outputFile.WriteLine(goalString);
            }
        }
        Console.WriteLine($"Goals saved successfully to {fileName}!");
    }

    public void LoadGoals(){
        Console.Write("What is the filename for the goal file? ");
        string goalFile = Console.ReadLine();

        string [] lines = File.ReadAllLines(goalFile);

        foreach(string line in lines){
        string [] parts = line.Split('|');
        string goalType = parts[0];

            if (goalType == "SimpleGoal"){
                string pointsString = parts[3];
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(pointsString)));
            }
            else if (goalType == "EternalGoal"){
                string pointsString = parts[3];
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(pointsString)));
            }
            else if (goalType == "ChecklistGoal"){
                string pointsString = parts[3];
                string targetString = parts[4];
                string bonusString = parts[5];
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(pointsString), int.Parse(targetString), int.Parse(bonusString)));
            }
        }
    }

}