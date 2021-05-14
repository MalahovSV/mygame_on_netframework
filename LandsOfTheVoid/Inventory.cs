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
using System.Xml;
using System.Xml.Serialization;

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
            WeaponPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_ak_103.png");
            rucksackPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_military_rucksack.png");
            BootsPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_military_boots.png");
            HelmPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_military_helm.png");
            GasMaskPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_gas_mask.png");
            Armor ArmorPerson = new Armor("img_armor_gray.png", "ФОРТ Росич", 65, 10.90);
            //ArmorPanel.BackgroundImage = Image.FromFile(ArmorPerson.PathIcon);
            SerializationXML serialization = new SerializationXML();
            List<Armor> armors1 = new List<Armor>();

            serialization.NewSetArmor(armors1);
            LoadParamsActor();
            loadFromXML_Inventory();
        }

        private void LoadParamsActor()
        {
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

        private void Stamina_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) 
            {
                if (tableInventory.Rows[e.RowIndex].Cells[4].Value is checked(false))
                {
                    if (tableInventory.Rows[e.RowIndex].Cells[0].Value.ToString() == "Armor")
                        UpdataArmor(tableInventory.Rows[e.RowIndex].Cells);
                }
                else 
                {
                    //ArmorPanel.BackgroundImage.Dispose();
                    ArmorPanel.BackgroundImage = null;
                    UncheckedAllCellsClassArmor();
                }
            }
        }


        /// <summary>
        /// Подгрузка содержимого инвентаря с XML
        ///
        /// </summary>
        public void loadFromXML_Inventory()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Directory.GetCurrentDirectory() + @"\Saves\SaveDataPlayer.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            int i = 0;
            foreach (XmlNode xnode in xRoot)
            {

                tableInventory.Rows.Add();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        tableInventory.Rows[i].Cells[1].Value = $@"{attr.Value} ";
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "class")
                    {
                        tableInventory.Rows[i].Cells[0].Value = $@"{childnode.InnerText}";
                    }
                    if (childnode.Name == "weight")
                    {
                        tableInventory.Rows[i].Cells[2].Value = $@"{childnode.InnerText} ";
                    }
                    if (childnode.Name == "count")
                    {
                        tableInventory.Rows[i].Cells[3].Value = $@"{childnode.InnerText} ";
                    }
                    if (childnode.Name == "put_on")
                    {
                        if (childnode.InnerText == "true")
                        {
                            tableInventory.Rows[i].Cells[4].Value = true;
                        }
                        else
                            tableInventory.Rows[i].Cells[4].Value = false;
                    }
                }
                i++;
            }

        }
        /// <summary>
        /// Меняет на PanelArmor изображение
        /// </summary>
        /// <param name="data"></param>
        private void UpdataArmor(DataGridViewCellCollection data) 
        {
            if (ArmorPanel.BackgroundImage == null)
            {
                ArmorPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_armor_gray.png");
                UncheckedAllCellsClassArmor();
                data[4].Value = true;
            } else
            {
                ArmorPanel.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + @"\Resources\img_armor_gray.png");
                UncheckedAllCellsClassArmor();
                data[4].Value = true;
            }
        }
        /// <summary>
        /// Убирает все галочки, все checkbox инвентаря таблицы с классом Armor буду false
        /// </summary>
        private void UncheckedAllCellsClassArmor()
        {
            for (int RowsDGV = 0; RowsDGV<tableInventory.Rows.Count; RowsDGV++)
            {
                if(tableInventory.Rows[RowsDGV].Cells[0].Value.ToString() == "Armor")
                {
                    tableInventory.Rows[RowsDGV].Cells[4].Value = false;
                }
            }
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

    public class Item
    {
        public double Weight { get; set; }

    }
    [Serializable]
    public class Armor : Item
    {
        public string PathIcon = Directory.GetCurrentDirectory() + @"\Resources\";
        public string NameArmor { get; set; }
        public Int16 ArmorPoint { get; set; }

        public Armor() { }

        public Armor(string _pathIcon, string _nameArmor, short _armorPoint, double _Weight)
        {
            PathIcon += _pathIcon;
            NameArmor = _nameArmor;
            ArmorPoint = _armorPoint;
            Weight = _Weight;
        }
    }
    [Serializable]
    class SerializationXML
    {
        public void AddSetArmor(List<Armor> armors) // Внести новый список
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Armor>));

            //сериализация
            using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\armor.xml", FileMode.Append))
            {
                serializer.Serialize(fs, armors);
            }
        }

        public void NewSetArmor(List<Armor> armors) // Внести новый список
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Armor>));

            //сериализация
            using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\armor.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, armors);
            }
        }
        public void GetArmor() //Вывести список Armor
        {
            List<Armor> armors = new List<Armor>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Armor>));
            //десериализация
            using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\armor.xml", FileMode.OpenOrCreate))
            {

                armors = (List<Armor>)serializer.Deserialize(fs);
                foreach (Armor arm in armors)
                    MessageBox.Show($@" {arm.NameArmor} {arm.ArmorPoint} {arm.Weight}", "asdas");
            }
        }

        internal void NewSetArmor(Type type, object p, string v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
}