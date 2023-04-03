using System.Text.Json.Nodes;

namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static async Task<string> getfile()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://localhost:5092/getfil";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return json;
                }
                else
                {
                    int error = (int)response.StatusCode;
                    string errorcode = $"{error} not found";
                    return errorcode;
                }
            }
        }
    }
}