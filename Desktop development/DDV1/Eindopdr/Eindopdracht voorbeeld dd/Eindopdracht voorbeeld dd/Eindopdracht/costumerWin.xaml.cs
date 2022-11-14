using Eindopdracht.models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Eindopdracht
{
    /// <summary>
    /// Interaction logic for CostumerWin.xaml
    /// </summary>
    public partial class CostumerWin : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Costumer costumerNew = new Costumer();

        public Costumer CostumerNew
        {
            get { return costumerNew; }
            set { costumerNew = value; OnPropertyChanged(); }
        }

        DBconnection db = new DBconnection();


        public CostumerWin()
        {
            InitializeComponent();
            DataContext = this;
        }

        public CostumerWin(Costumer costumerNew)
        {
            this.costumerNew = costumerNew;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (costumerNew == null)
            {
                MessageBox.Show("Leeg textboxen. je moet een waarde geven om een costumer toetevoegen.");
                return;
            }
            db.SaveCosutmer(CostumerNew);
            this.Close();
            MainWindow win2 = new MainWindow();
            win2.Show();

        }
    }
}
