using Azure.AI.Projects;
using Azure.Identity;
using MIcrosoftAgentFrameworkTutorial.Shared;
using Microsoft.Agents.AI;

namespace MIcrosoftAgentFrameworkTutorial.Tutorials;

public sealed class HelloAgentTutorial : ITutorial
{
    public string Name => "01 - Hello Agent";

    public async Task RunAsync()
    {
        AIAgent agent = new AIProjectClient(new Uri(AgentConfiguration.ProjectEndpoint), new DefaultAzureCredential())
            .AsAIAgent(model: AgentConfiguration.Model, instructions: "You are good at telling jokes", name: "Joker");

        Console.WriteLine(await agent.RunAsync("Tell me a joke"));

        await foreach (var update in agent.RunStreamingAsync("Tell me a joke on vehicles"))
        {
            Console.Write(update);
        }
    }
}
