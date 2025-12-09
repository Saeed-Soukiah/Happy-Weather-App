using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather_App
{
    public partial class FRM_Location : Form
    {
        private Country countries;

        public FRM_Location()
        {
            InitializeComponent();
        }

        // Async void is appropriate for WinForms event handlers.
        private async void FRM_Location_Load(object sender, EventArgs e)
        {
            try
            {
                // 1) Fetch JSON asynchronously (I/O)
                var helper = new HTTPHelper();
                string json = await helper.GetJsonAsync("https://countriesnow.space/api/v0.1/countries/");

                // 2) Deserialize (cheap). If very large, consider doing this on a background thread.
                countries = JsonConvert.DeserializeObject<Country>(json);

                // 3) Build the list on a background thread (CPU-bound)
                var list = await Task.Run(() =>
                {
                    var temp = new List<string>();
                    if (countries?.data != null)
                    {
                        foreach (var c in countries.data)
                        {
                            var countryName = c.country ?? string.Empty;
                            if (c.cities != null)
                            {
                                foreach (var city in c.cities)
                                {
                                    temp.Add($"{city}, {countryName}");
                                }
                            }
                        }
                    }
                    return temp;
                });

                // 4) Assign DataSource on UI thread (we are back on UI thread after await)
                Locations_Combo_Box.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load locations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            var selected = Locations_Combo_Box.SelectedItem as string;
            if (string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Please select a location first.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // The items are in the format "City, Country"
            var parts = selected.Split(new[] { ',' }, 2);
            string city = parts.Length > 0 ? parts[0].Trim() : string.Empty;
            string country = parts.Length > 1 ? parts[1].Trim() : string.Empty;

            // Example: store or use the selected values
            MessageBox.Show($"Saved location:\nCity: {city}\nCountry: {country}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: persist selection to settings or pass back to caller as needed
            Properties.Settings.Default.FullName = Locations_Combo_Box.Text;
            Properties.Settings.Default.Save();
        }

        private void Locations_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}