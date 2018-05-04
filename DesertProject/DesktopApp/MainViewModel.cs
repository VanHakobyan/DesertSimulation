using System;
using System.Collections.Generic;
using DesktopApp.Base_classes;
using System.Collections.ObjectModel;
using DesktopApp.Base_classes.Elements;

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
            Rows = 10;
            Columns = 10;

            Items = new ObservableCollection<Element>();
            for (int i = 0; i < Rows * Columns; i++)
            {
                Items.Add(new Element());
            }
            FillElements();

            Notify(nameof(Items));

        }

        private void FillElements()
        {
            var waters = new Water().CountOnDesert;
            Rows = 10;
            Columns = 10;

            int index;
            for (int i = 0; i < waters; i++)
            {
                index = _rnd.Next(0, 100);
                while (Items[index].Color != "peru")
                {
                    index = _rnd.Next(0, 100);
                }
                Items[index] = new Water();
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