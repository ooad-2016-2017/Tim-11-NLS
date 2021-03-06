﻿using ProjekatZatvor.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static ProjekatZatvor.MainPage;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatZatvor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class strazarIzvjestaj : Page, INotifyPropertyChanged
    {
        private UltraMegaGigaViewModel UltraMegaGiga;
        Validacija val;
        public strazarIzvjestaj()
        {
            this.InitializeComponent();
            val = new Validacija();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            UltraMegaGiga = (UltraMegaGigaViewModel)e.Parameter;
            this.DataContext = UltraMegaGiga;
            base.OnNavigatedTo(e);
        }
        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            UltraMegaGiga.PrijaviPrekrsaj();
            //prekrsaj.Text = UltraMegaGiga.UkupanBrojPrekrsaja;
            pohvala.Text = UltraMegaGiga.UkupanBrojPohvala;
            val.strazarIzvjestajPrekrsajValidacija(imeprek.Text, preimeprek.Text, celija.Text, prekprijava.Text);
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            UltraMegaGiga.PrijaviPrekrsaj();
            prekrsaj.Text = UltraMegaGiga.UkupanBrojPrekrsaja;
            pohvala.Text = UltraMegaGiga.UkupanBrojPohvala;
            val.strazarIzvjestajPohvalaValidacija(pohvalaime.Text, pohvalaprezime.Text, pohvalabrcelije.Text);
        }

        

        
    }
}
