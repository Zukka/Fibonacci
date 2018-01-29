using Xamarin.Forms;
using System.Collections.Generic;
using System;
namespace Fibonacci
{
    public partial class FibonacciPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (requestedNumberSize.Text.Length == 0 || requestedNumberSize.Text == "0")
            {
                labelResult.Text = "Error: Invalid data input.";
                return;
            }
            FibonacciCalculator calcolateFibonacciNumbersList = new FibonacciCalculator();
            int numberOfItems = 0;
            if (Int32.TryParse(requestedNumberSize.Text, out numberOfItems)) {
                calcolateFibonacciNumbersList.RequestedListSize(numberOfItems);
                List<int> returnedList = calcolateFibonacciNumbersList.getListOfFibonacciNumbers();
                if (returnedList.Count > 0) {
                    labelResult.Text = "";
                    for (int index = 0; index < returnedList.Count; index++) {
                        labelResult.Text += returnedList[index].ToString() + " ";
                    }

                }
            } else {
                labelResult.Text = "Error: Invalid data input.";
            }
        }

        public FibonacciPage()
        {
            InitializeComponent();
        }
    }
}
