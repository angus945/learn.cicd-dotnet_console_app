using CicdDemo;

var name = args.Length > 0 ? args[0] : "CI/CD Learner";

Console.WriteLine(Greeting.Create(name));