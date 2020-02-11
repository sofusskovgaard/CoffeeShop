﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CoffeeShop.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Creating a Global culture specific to our application.
            CultureInfo cultureInfo = new CultureInfo("da-DK");

            #region Creating the DateTime Information specific to our application.
            //DateTimeFormatInfo dateTimeInfo = new DateTimeFormatInfo();

            //// Defining various date and time formats.
            //dateTimeInfo.DateSeparator = "/";
            //dateTimeInfo.LongDatePattern = "dd/MM/yyyy";
            //dateTimeInfo.ShortDatePattern = "dd/MM/yyyy";
            //dateTimeInfo.LongTimePattern = "hh:mm:ss tt";
            //dateTimeInfo.ShortTimePattern = "hh:mm tt";

            //// Setting application wide date time format.
            //cultureInfo.DateTimeFormat = dateTimeInfo;
            #endregion

            // Assigning our custom Culture to the application.                        
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),
                new FrameworkPropertyMetadata(System.Windows.Markup.XmlLanguage.GetLanguage(System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
        }
    }
}
