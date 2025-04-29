using System;
using System.Windows;
using System.Windows.Controls;

namespace TresEnCalle
{
    public partial class MainWindow : Window
    {
        private string currentPlayer = "X";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (string.IsNullOrEmpty(clickedButton.Content.ToString()))
            {
                clickedButton.Content = currentPlayer;
                CheckForWinner();
                currentPlayer = (currentPlayer == "X") ? "O" : "X";
            }
        }

        private void CheckForWinner()
        {
            // Check horizontal, vertical, and diagonal lines for a winner
            if (IsWinner(Button1, Button2, Button3) ||
                IsWinner(Button4, Button5, Button6) ||
                IsWinner(Button7, Button8, Button9) ||
                IsWinner(Button1, Button4, Button7) ||
                IsWinner(Button2, Button5, Button8) ||
                IsWinner(Button3, Button6, Button9) ||
                IsWinner(Button1, Button5, Button9) ||
                IsWinner(Button3, Button5, Button7))
            {
                MessageBox.Show($"{currentPlayer} wins!");
                ResetGame();
            }
        }

        private bool IsWinner(Button btn1, Button btn2, Button btn3)
        {
            return btn1.Content.ToString() == btn2.Content.ToString() &&
                   btn2.Content.ToString() == btn3.Content.ToString() &&
                   !string.IsNullOrEmpty(btn1.Content.ToString());
        }

        private void ResetGame()
        {
            // Reset all buttons to be empty
            foreach (UIElement element in GameGrid.Children)
            {
                if (element is Button button)
                {
                    button.Content = "";
                }
            }
        }

        private void Button_Click_1()
        {

        }
    }
}
