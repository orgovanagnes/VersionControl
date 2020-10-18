﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using WindowsFormsApp.Entities;
using WindowsFormsApp.MnbServiceReference;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            RefreshData();

        }

        private void RefreshData()
        {
            Rates.Clear();

            WEbszolgaltatashivasa();

            chartRateData.DataSource = Rates;
            //XMLfeldolgozasa();

            chartRateData.DataSource = Rates;
            diagram();
        }

        private void diagram()
        {
            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        /* private void XMLfeldolgozasa()
         {
             // XML document létrehozása és az aktuális XML szöveg betöltése
             var xml = new XmlDocument();
             xml.LoadXml(result);

             // Végigmegünk a dokumentum fő elemének gyermekein
             foreach (XmlElement element in xml.DocumentElement)
             {
                 // Létrehozzuk az adatsort és rögtön hozzáadjuk a listához
                 // Mivel ez egy referencia típusú változó, megtehetjük, hogy előbb adjuk a listához és csak később töltjük fel a tulajdonságait
                 var rate = new RateData();
                 Rates.Add(rate);

                 // Dátum
                 rate.Date = DateTime.Parse(element.GetAttribute("date"));

                 // Valuta
                 var childElement = (XmlElement)element.ChildNodes[0];
                 rate.Currency = childElement.GetAttribute("curr");

                 // Érték
                 var unit = decimal.Parse(childElement.GetAttribute("unit"));
                 var value = decimal.Parse(childElement.InnerText);
                 if (unit != 0)
                     rate.Value = value / unit;
             }
         }*/

        private static void WEbszolgaltatashivasa()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()

            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            // Ebben az esetben a "var" a GetExchangeRates visszatérési értékéből kapja a típusát.
            // Ezért a response változó valójában GetExchangeRatesResponseBody típusú.
            var response = mnbService.GetExchangeRates(request);

            // Ebben az esetben a "var" a GetExchangeRatesResult property alapján kapja a típusát.
            // Ezért a result változó valójában string típusú.
            var result = response.GetExchangeRatesResult;
        }

        private void chartRateData_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
            comboBox1.DataSource = Currencies;
        }
    }
}
