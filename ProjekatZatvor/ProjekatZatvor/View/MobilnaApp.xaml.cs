using Microsoft.WindowsAzure.MobileServices;
using ProjekatZatvor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MobilnaApp : Page
    {
        IMobileServiceTable<ZatvorenikTabela> userTableObj = App.MobileService.GetTable<ZatvorenikTabela>();
        private void btnSpasi_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                ZatvorenikTabela obj = new ZatvorenikTabela();
                obj.ime = txtIme.Text;
                obj.prezime = txtPrezime.Text;
                obj.brojCelije = txtBrojCelije.Text;
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog zatvorenika.");

                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " +
               ex.ToString());
                msgDialogError.ShowAsync();
            }
        }

        public MobilnaApp()
        {
            this.InitializeComponent();
        }
    }
}
