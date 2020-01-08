using ListViewXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewOrnek : ContentPage
    {
        public ListViewOrnek()
        {
            InitializeComponent();
            List<OgrenciModel> ogr = new List<OgrenciModel>();
            ogr.Add(new OgrenciModel {ID=1,Name="hasan",SurName="özgür",Point=24,ImageURL="QAS.jpg" });
            ogr.Add(new OgrenciModel {ID = 2,Name="kemal",SurName="düzmen",Point=32,ImageURL = "QAS.jpg" });

            OgrList.ItemsSource = ogr;
        }


        // OnSelected Adında bir method yazdık listeye tıklandığında bu methoda gelinecek
        public void OnSelected(Object sender,SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            //e.SelectedItem'ı Ogrenci Model ile Cast ederek kendisinin Obje türünü OgrenciModel Yaptık
            OgrenciModel ogr = (OgrenciModel)e.SelectedItem;
            DisplayAlert("Öğrenci Bilgisi", ogr.Name, "Tamam");

        }


     
    }
}