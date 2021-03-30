using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LandsOfTheVoid
{
    public partial class Inventory : Form
    {
        PersonParametrs Person;
        public Inventory()
        {
            InitializeComponent();
            
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Person = new PersonParametrs(250, 300, 100, 25, 30, 32, 15698, 56, 300, 300, 350, "Ульян");
            WeaponPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_as-val.gif");
            //ArmorPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_armor_stalker.gif");

            Armor ArmorPerson = new Armor("img_armor_stalker.gif", "ФОРТ Росич", 65);
            ArmorPanel.BackgroundImage = Image.FromFile(ArmorPerson.PathIcon);
            groupBox1.Text = Person.NamePerson;

            Level.Text = $@"Уровень: {Person.Level}";
            Experience.Text = $@"Опыт: {Person.Experience}";
            Health.Text = $@"Здоровье {Person.Health} / {Person.MaxHealth}";
            Mind.Text = $@"Рассудок {Person.Mind} / {Person.MaxMind}";
            Stamina.Text = $@"Выносливость {Person.Stamina} / {Person.MaxStamina}";
            Power.Text = $@"Сила {Person.Power}";
            Agality.Text = $@"Ловкость {Person.Agality}";
            Intellect.Text = $@"Интеллект {Person.Intellect}";


        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }


    }

    class PersonParametrs
    {
        public string NamePerson;
        public Int16 Health;
        public Int16 MaxHealth;
        public Int16 Stamina;
        public Int16 MaxStamina;
        public Int16 Power;
        public Int16 Agality;
        public Int16 Mind;
        public Int16 MaxMind;
        public Int16 Intellect;
        public Int32 Experience;
        public Int16 Level;
        /// <summary>
        /// Передача параметров
        /// </summary>
        /// <param name="_health">Очки здоровья</param>
        /// <param name="_mind">Разум</param>
        /// <param name="_stamina">Выносливость</param>
        /// <param name="_power">Сила</param>
        /// <param name="_agality">Ловкость</param>
        /// <param name="_intellect">Интеллект</param>
        /// <param name="_experience">Опыт</param>
        /// <param name="_level">Уровень</param>
        public PersonParametrs(Int16 _health, Int16 _mind, Int16 _stamina, Int16 _power, Int16 _agality, Int16 _intellect, 
            Int32 _experience, Int16 _level, Int16 _maxHealth, Int16 _maxMind, Int16 _maxStamina, string _namePersoon)
        {
            Health = _health;
            Mind = _mind;
            Stamina = _stamina;
            Power = _power;
            Agality = _agality;
            Intellect = _intellect;
            Experience = _experience;
            Level = _level;
            MaxHealth = _maxHealth;
            MaxMind = _maxMind;
            MaxStamina = _maxStamina;
            NamePerson = _namePersoon;
        }

    }

    class Armor
    {
        public string PathIcon = Directory.GetCurrentDirectory() + @"\Resources\";
        public string NameArmor;
        public Int16 ArmorPoint;
        public Armor(string _pathIcon, string _nameArmor, short _armorPoint)
        {
            PathIcon +=_pathIcon;
            NameArmor = _nameArmor;
            ArmorPoint = _armorPoint;
        }
    }
}
