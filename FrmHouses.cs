using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;

namespace Sun_House
{
    public partial class FrmHouses : AntdUI.BaseForm
    {
        //initialise the map
        private void InitiatMap()
        {
            //initialise the gmap control
            GmapHousePosition.MapProvider = GMapProviders.GoogleHybridMap;
            GmapHousePosition.ShowCenter = false;
            GmapHousePosition.MinZoom = 1;
            GmapHousePosition.MaxZoom = 40;
            GmapHousePosition.Zoom = 5;
            GmapHousePosition.DragButton = MouseButtons.Left;
        }

        public FrmHouses()
        {
            InitializeComponent();
        }

        private void FrmHouses_Load(object sender, EventArgs e)
        {
            InitiatMap();
        }

        private void FrmHouses_FormClosing(object sender, FormClosingEventArgs e)
        {
            GmapHousePosition.Manager.CancelTileCaching();
            GmapHousePosition.Dispose();
        }

        private void GmapHousePosition_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            //get tje lang and the lat
            txtNewPosX.Text = pointClick.Lng.ToString();
            txtNewPosY.Text = pointClick.Lat.ToString();

            //set the marker
            var markOverlay = new GMapOverlay("MY House");
            GMarkerGoogle mark = new GMarkerGoogle(pointClick, GMarkerGoogleType.yellow_pushpin);
            markOverlay.Markers.Clear();
            markOverlay.Markers.Add(mark);
            GmapHousePosition.Overlays.Clear();
            GmapHousePosition.Overlays.Add(markOverlay);
            //refresh the map (zoom in and zoom out)
            double z = GmapHousePosition.Zoom;
            GmapHousePosition.Zoom = z + 0.5;
            GmapHousePosition.Zoom = z;
            //get the address if possible
            GeoCoderStatusCode status;
            Placemark? address = GMapProviders.GoogleMap.GetPlacemark(pointClick, out status);
            if (status == GeoCoderStatusCode.OK && address.HasValue)
            {
                txtNewAddress.Text = address.Value.Address;
            }
            
        }
    }
}
