using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace meteo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.open-meteo.com/v1/forecast?latitude=41.9028&longitude=12.4964&daily=temperature_2m_max,temperature_2m_min,precipitation_sum&timezone=auto");
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string risp = await response.Content.ReadAsStringAsync();


            risultato oggetto = JsonConvert.DeserializeObject<risultato>(risp);
            MessageBox.Show(oggetto.daily.temperature_2m_max.Length.ToString());

            /*chart1.DataSource = oggetto.daily.temperature_2m_max.ToArray();
            chart1.DataBind();
            chart1.Refresh();*/
            for (int i = 0; i < oggetto.daily.temperature_2m_max.Length; i++)
            {
                chart1.Series[0].Points.AddXY(/*oggetto.daily.time[1]*/i, oggetto.daily.temperature_2m_max[i]);
            }
        }
    }
}
