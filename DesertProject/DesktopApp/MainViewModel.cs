using System;
using System.Collections.Generic;
using DesktopApp.Base_classes;
using System.Collections.ObjectModel;

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

            Notify(nameof(Items));

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