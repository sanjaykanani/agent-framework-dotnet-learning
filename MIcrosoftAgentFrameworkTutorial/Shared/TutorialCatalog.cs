using MIcrosoftAgentFrameworkTutorial.Tutorials;

namespace MIcrosoftAgentFrameworkTutorial.Shared;

public static class TutorialCatalog
{
    public static IReadOnlyList<ITutorial> All { get; } =
    [
        new HelloAgentTutorial(),
        //new PromptingTutorial(),
        //new ToolsTutorial(),
        //new MemoryTutorial(),
        //new RetrievalTutorial(),
        //new MultiAgentTutorial(),
        //new EvaluationTutorial()
    ];
}
