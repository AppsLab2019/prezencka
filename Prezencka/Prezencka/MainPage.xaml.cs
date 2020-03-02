﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prezencka
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                    clock_big.Text = DateTime.Now.ToString("hh:mm:ss"));

                return true;
            });


        }

        private void OwnTimeChangedArrive(object sender, PropertyChangedEventArgs e)
        {

        }

        private void OwnTimeChangedRest(object sender, PropertyChangedEventArgs e)
        {

        }

        private void OwnTimeChangedLeave(object sender, PropertyChangedEventArgs e)
        {

        }
    }
}
