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
using System.Windows.Threading;

namespace ПрактическаяРабота3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public classes.PersonInfo Player = new classes.PersonInfo("студент", 100, 10 ,1,0,0,9);

        public List<classes.PersonInfo> Enemys = new List<classes.PersonInfo>();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public classes.PersonInfo Enemy = new classes.PersonInfo("enemy",100,10,1,0,0,9);
        public MainWindow()
        {
            InitializeComponent();
            UserInfoPlayer();

            Enemys.Add(new classes.PersonInfo("Болотное чудовище", 100,20,1,15,5,20));
            Enemys.Add(new classes.PersonInfo("маринад", 20, 5, 1, 5, 5, 5));
            Enemys.Add(new classes.PersonInfo("ооао", 50, 3, 1, 1, 10, 15));
            
            dispatcherTimer.Tick += AttackPlayer;
            dispatcherTimer.Interval = new System.TimeSpan(0, 0, 5);
            dispatcherTimer.Start();
            SelectEnemy();
        }
        public void SelectEnemy()
        {
            int Id = new Random().Next(0,Enemys.Count);

            Enemy = new classes.PersonInfo(
                Enemys[Id].Name,
                Enemys[Id].Health,
                Enemys[Id].Armor,
                Enemys[Id].Level,
                Enemys[Id].Glasses,
                Enemys[Id].Money,
                Enemys[Id].Damage);

        }
        private void AttackPlayer(object sender, System.EventArgs e)
        {
            Player.Health -= Convert.ToInt32(Enemy.Damage * 100f / (100f - Player.Armor));
            UserInfoPlayer();
        }
        public void UserInfoPlayer()
        {
            if (Player.Glasses > 100 * Player.Level)
            {
                Player.Level++;
                Player.Glasses = 0;
                Player.Health += 100;
                Player.Damage++;
                Player.Armor++;
            }
            playerHealth.Content = "Жизенные показатели: " + Player.Health;
            playerArmor.Content = "Броня: " + Player.Armor;
            playerLevel.Content = "Уровень: " + Player.Level;
            playerGlasses.Content = "Опыт: " + Player.Glasses;
            playerMoney.Content = "Монеты: " + Player.Money;

        }
        private void AttackEnemy(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Enemy.Health -= Convert.ToInt32(Player.Damage * 100f / (100f - Enemy.Armor));
            if (Enemy.Health <= 0)
            {
                Player.Glasses += Enemy.Glasses;
                Player.Money += Enemy.Money;
                UserInfoPlayer();
                SelectEnemy();
            }
            else
            {
                emptyHealth.Content = "Жизненные показатели: " + Enemy.Health;
                emptyArmor.Content = "Броня: " + Enemy.Armor;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            Оглушение.Hidde
        }
    }
}
