using Newtonsoft.Json;

namespace TraversalCoreProject.Services
{
    public class reCaptchaResponse
    {
        [JsonProperty("Success")]
        public bool Success { get; set; }
        public string[] ErrorCodes { get; set; }
    }


    public class ReCaptcha
    {
        private readonly string _secret = "6LfuvJIpAAAAAHFVECUbxV6dXJaarVg_KWzqZ612";
        private readonly string _url = "https://www.google.com/recaptcha/api/siteverify";
        private string responseCode = "";
        
        public ReCaptcha(string responseCode)
        {
            this.responseCode = responseCode;
        }

        public async Task<bool> Verify() {
            var content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"secret", this._secret },
                    {"response", this.responseCode }
                });

            var client = new HttpClient();
            var response = await client.PostAsync(this._url, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<reCaptchaResponse>();
                if (result.Success)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
