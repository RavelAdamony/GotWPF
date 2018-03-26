using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebApiGoT.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace GameOfThronesTournamentWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void displayHouses(object sender, RoutedEventArgs e)
        {
            List<HouseDTO> houses = await GetHouses();
            listView.ItemsSource = houses.Select(h => h.Name).ToList();
        }

        private void editHouses(object sender, RoutedEventArgs e)
        {
            //EditHouses edit_window = new EditHouses();
            //edit_window.Show();
        }

        public async Task<List<HouseDTO>> GetHouses()
        {
            List<HouseDTO> models = new List<HouseDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56063/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/house/GetAllHouses");
                if (response.IsSuccessStatusCode)
                {
                    string temp = await response.Content.ReadAsStringAsync();
                    models = JsonConvert.DeserializeObject<List<HouseDTO>>(temp);
                }

            }
            return models;
        }
    }
}
