namespace MIcrosoftAgentFrameworkTutorial.Tutorials;

public interface ITutorial
{
    string Name { get; }

    Task RunAsync();
}