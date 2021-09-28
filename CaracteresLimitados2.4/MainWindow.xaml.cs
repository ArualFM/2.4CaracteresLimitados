using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaracteresLimitados2._4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int ContadorPalabras = int.Parse(ContadorCaracteresTextBlock.Text);
            int MaximoPalabras = int.Parse(MaximoCaracteresTextBlock.Text);
            int ContadorPalabrasUsuario = TextoUsuarioTextBox.Text.Length;
            ContadorCaracteresTextBlock.Text = ContadorPalabrasUsuario.ToString();

            if (ContadorPalabras >= MaximoPalabras -1)
            {
                TextoUsuarioTextBox.IsReadOnly = true;
            }


            

        }
    }
}
