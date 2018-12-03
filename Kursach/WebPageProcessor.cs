using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    static class WebPageProcessor
    {
        static string pageStart = "<!DOCTYPE html><html><head><meta name=\"viewport\" content=\"initial-scale=1.0, user-scalable=no\"><meta charset=\"utf-8\"><title>Marker Clustering</title><style>#map {height: 100%;}html, body {height: 100%;margin: 0;padding: 0;}</style></head><body><div id=\"map\"></div><script>function initMap() {var map = new google.maps.Map(document.getElementById('map'), {zoom: 3,center: {lat: -28.024, lng: 140.887}});var labels = '';var markers = locations.map(function(location, i) {return new google.maps.Marker({position: location,label: labels[i % labels.length]});});var markerCluster = new MarkerClusterer(map, markers,{imagePath: 'https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m'});}";
        static string pageEnd = "</script><script src=\"https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/markerclusterer.js\"></script><script async defer src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyBovhBbBcRel6VrZZmTONhGpipFA6mBS28&callback=initMap\"></script></body></html>";

        private static List<Location> GetLocations(DataGridView dataGrid)
        {
            List<Location> locations = new List<Location>();
            for(var i = 0; i < dataGrid.RowCount - 1; i++)
            {
                locations.Add(new Location(double.Parse(dataGrid.Rows[i].Cells[7].Value.ToString()), double.Parse(dataGrid.Rows[i].Cells[8].Value.ToString())));
            }

            return locations;
        }

        public static void CreateMap(DataGridView dataGrid)
        {
            List<Location> locations = GetLocations(dataGrid);
            if (locations.Count > 0)
            {
                using (FileStream fstream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath) + "/map.html", FileMode.Create))
                {
                    string map = pageStart;

                    string locationString = "var locations = [";

                    foreach (Location location in locations)
                    {
                        locationString += "{lat: " + location.lat.ToString().Replace(',','.') + ", lng: " + location.lng.ToString().Replace(',', '.') + "},";
                    }

                    map += locationString.Substring(0, locationString.Length - 1) + "]" + pageEnd;
                    byte[] array = Encoding.Default.GetBytes(map);

                    fstream.Write(array, 0, array.Length);
                }
            }
        }
    }
}
