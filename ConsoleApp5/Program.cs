// See https://aka.ms/new-console-template for more information
using OpenAI;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3;

Console.WriteLine("Hello, World!");

var openAiService = new OpenAIService(new OpenAiOptions()
{
    ApiKey = "API-KEY"
});

OpenAI.OpenAI a = new OpenAI.OpenAI(openAiService);
a.Task();
Console.ReadKey();