
//using System.Text;




//namespace ConsoleApp1.CodeWars._20_39
//{
//    internal class GPT
//    {
//        static async Task Main(string[] args)
//        {
//            // Set the API key and base URL
//            var apiKey = "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";
//            var baseUrl = "https://api.openai.com";

//            // Use the Assistant model to generate text
//            var model_engine = "text-davinci-002";
//            var prompt = "how many people are there";
         

//            using (var client = new HttpClient())
//            {
//                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
//                var content = new StringContent($"{{\"model\": \"{model_engine}\", \"prompt\": \"{prompt}\", \"max_tokens\": 1024, \"n\": 1, \"stop\": null, \"temperature\": 0.5           , \"history\":[ prompt: What is the capital of France?, response: The capital of France is Paris.]         }}", Encoding.UTF8, "application/json");
//                var response = await client.PostAsync($"{baseUrl}/v1/completions", content);
//                var responseString = await response.Content.ReadAsStringAsync();
//                // Parse the response string to get the generated text
//                // ...
//                Console.WriteLine(responseString);
//            }

          
//        }


     
//    }
//}
