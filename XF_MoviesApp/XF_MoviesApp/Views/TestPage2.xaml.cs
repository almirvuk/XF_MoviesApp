﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MoviesApp.Views {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage2 : ContentPage {

        public TestPage2(string fullName) {
            InitializeComponent();

            labelFullName2.Text = fullName;
        }
    }
}