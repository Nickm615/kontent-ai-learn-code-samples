// DocSection: cm_api_v2_get_workflow_steps
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_ENVIRONMENT_ID>"
});

var response = await client.ListWorkflowsAsync();
var workflowSteps = response.FirstOrDefault(x => x.Codename == "default").Steps;
// EndDocSection