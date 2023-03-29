using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels.ResponseModels;
using OpenAI.GPT3.ObjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI
{
    public class OpenAI
    {
        readonly IOpenAIService _openAIService;

        public OpenAI(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        public async Task Task()
        {
            while (true)
            {
                Console.Write("::");
                CompletionCreateResponse result = await _openAIService.Completions.CreateCompletion(new CompletionCreateRequest()
                {
                    Prompt = Console.ReadLine(),
                    MaxTokens = 2048
                }, Models.TextDavinciV3);

                Console.WriteLine(result.Choices[0].Text);
            }

        }

        

        }
    }

