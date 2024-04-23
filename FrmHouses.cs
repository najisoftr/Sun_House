using GMap.NET;
using GMap.NET.MapProviders;
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
        public FrmHouses()
        {
            InitializeComponent();
        }

        private void FrmHouses_Load(object sender, EventArgs e)
        {
            //initialise the gmap control
            GmapHousePosition.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleHybridMap;
            GmapHousePosition.ShowCenter = false;
            GmapHousePosition.MinZoom  =1;
            GmapHousePosition.MaxZoom = 40;
            GmapHousePosition.Zoom = 5;
            GmapHousePosition.DragButton = MouseButtons.Left;
        }

        private void FrmHouses_FormClosing(object sender, FormClosingEventArgs e)
        {
            GmapHousePosition.Manager.CancelTileCaching();
            GmapHousePosition.Dispose();
        }

        private void GmapHousePosition_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
        {
            txtNewPosX.Text = pointClick.Lng.ToString();
            txtNewPosY.Text = pointClick.Lat.ToString();
            GeoCoderStatusCode status;
            Placemark? address = GMapProviders.GoogleMap.GetPlacemark(pointClick, out status);
            if (status == GeoCoderStatusCode.OK && address.HasValue)
            {
                txtNewAddress.Text = address.Value.Address;
            }
        }
    }
}
