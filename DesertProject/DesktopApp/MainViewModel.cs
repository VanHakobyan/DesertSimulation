using System;
using System.Collections.Generic;
using DesktopApp.Base_classes;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml;
using DesktopApp.Base_classes.Elements;
using DesktopApp.Players;

namespace DesktopApp
{
    public class MainViewModel : ViewModel<MainWindow>
    {
        private ObservableCollection<Element> _items;

        private Random _rnd = new Random();

        public ObservableCollection<Element> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    Notify();
                }
            }
        }

        private int _rows;
        private int _columns;

        public void Show()
        {
            View.Show();
        }

        public MainViewModel()
        {
            if (!File.Exists("MainSettings.xml"))
            {
                Rows = 10;
                Columns = 10;
            }
            else
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                FileStream fs = new FileStream("MainSettings.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                int.TryParse(xmldoc.ChildNodes[1].ChildNodes[0].InnerText, out var rows);
                int.TryParse(xmldoc.ChildNodes[1].ChildNodes[1].InnerText, out var columns);

                Rows = rows;
                Columns = columns;
            }

            Items = new ObservableCollection<Element>();
            for (var i = 0; i < Rows * Columns; i++)
            {
                Items.Add(new Element());
            }
            FillElements();
            SetPlayers();

            Notify(nameof(Items));
        }

        private void FillElements()
        {
            var waters = new Water().CountOnDesert;
            var grasses = new Grass().CountOnDesert;
            var rocks = new Rock().CountOnDesert;
            var quicksands = new Quicksand().CountOnDesert;

            int index;
            for (int i = 0; i < waters; i++)
            {
                index = _rnd.Next(0, Rows * Columns);
                while (Items[index].Color != "peru")
                {
                    index = _rnd.Next(0, Rows * Columns);
                }
                Items[index] = new Water();
            }
            for (int i = 0; i < grasses; i++)
            {
                index = _rnd.Next(0, Rows * Columns);
                while (Items[index].Color != "peru")
                {
                    index = _rnd.Next(0, Rows * Columns);
                }
                Items[index] = new Grass();
            }
            for (int i = 0; i < rocks; i++)
            {
                index = _rnd.Next(0, Rows * Columns);
                while (Items[index].Color != "peru")
                {
                    index = _rnd.Next(0, Rows * Columns);
                }
                Items[index] = new Rock();
            }
            for (int i = 0; i < quicksands; i++)
            {
                index = _rnd.Next(0, Rows * Columns);
                while (Items[index].Color != "peru")
                {
                    index = _rnd.Next(0, Rows * Columns);
                }
                Items[index] = new Quicksand();
            }
        }

        private void SetPlayers()
        {
            var mice = new PocketMouse().CountOnDesert;
            var coyotes = new Coyote().CountOnDesert;

            int index;
            for (int i = 0; i < mice; i++)
            {
                index = _rnd.Next(0, Rows * Columns);
                while (Items[index].Color != "peru" && Items[index].Name != "")
                {
                    index = _rnd.Next(0, Rows * Columns);
                }
                Items[index] = new PocketMouse();
            }
            for (int i = 0; i < coyotes; i++)
            {
                index = _rnd.Next(0, Rows * Columns);
                while (Items[index].Color != "peru" && Items[index].Name != "")
                {
                    index = _rnd.Next(0, Rows * Columns);
                }
                Items[index] = new Coyote();
            }
        }

        public int Rows
        {
            get { return _rows; }
            set
            {
                if (_rows != value)
                {
                    _rows = value;
                    Notify();
                }
            }
        }

        public int Columns
        {
            get { return _columns; }
            set
            {
                if (_columns != value)
                {
                    _columns = value;
                    Notify();
                }
            }
        }
    }
}