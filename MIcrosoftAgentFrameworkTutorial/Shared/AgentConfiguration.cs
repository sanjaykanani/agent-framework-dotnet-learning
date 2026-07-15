namespace MIcrosoftAgentFrameworkTutorial.Shared;

public static class AgentConfiguration
{
    public static string ProjectEndpoint =>
        Environment.GetEnvironmentVariable("AZURE_AI_PROJECT_ENDPOINT")
        ?? throw new InvalidOperationException("AZURE_AI_PROJECT_ENDPOINT environment variable is not set.");

    public static string Model =>
        Environment.GetEnvironmentVariable("AZURE_OPENAI_MODEL")
        ?? "gpt-4o";
}
