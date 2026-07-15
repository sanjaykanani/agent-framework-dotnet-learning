using MIcrosoftAgentFrameworkTutorial.Shared;

var tutorial = TutorialCatalog.All.First();
Console.WriteLine($"Running: {tutorial.Name}");
await tutorial.RunAsync();
