using System;
using System.Collections.Generic;
using DesktopApp.Base_classes;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using DesktopApp.Base_classes.Elements;
using DesktopApp.Players;
using System.Timers;

namespace DesktopApp
{
    public class MainViewModel : ViewModel<MainWindow>
    {
        private ObservableCollection<Element> _items;

        private Random _rnd = new Random();
        private List<int> _coyoteIndexes = new List<int>();
        public static System.Timers.Timer timer;

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

        public MainViewModel(int rows, int columns)
        {
            timer = new System.Timers.Timer(2000);
            timer.Elapsed += Iterate;

            Rows = rows;
            Columns = columns;

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
                _coyoteIndexes.Add(index);
                Items[index] = new Coyote();
            }
        }

        private void Iterate(object sender, ElapsedEventArgs e)
        {
            timer.Enabled = false;
            for (var i = 0; i < _coyoteIndexes.Count; i++)
            {
                var adjacentSpots = GetAdjacentSpots(_coyoteIndexes[i]);
                if (adjacentSpots.Count == 0) continue;
                var randomStep = _rnd.Next(0, adjacentSpots.Count);
                var currentCoyote = Items[_coyoteIndexes[i]];
                Application.Current.Dispatcher.Invoke((Action) delegate
                {
                    Items[adjacentSpots[randomStep]] = currentCoyote;
                    Items[_coyoteIndexes[i]] = new Element();
                });
                _coyoteIndexes[i] = adjacentSpots[randomStep];
            }
            Notify(nameof(Items));
            timer.Enabled = true;
        }

        private List<int> GetAdjacentSpots(int index)
        {
            var list = new List<int>();
            var rowIndex = index / Columns;
            var columnIndex = index % Columns;
            if (rowIndex - 1 >= 0) list.Add(index - Columns);
            if (rowIndex + 1 <= Rows - 1) list.Add(index + Columns);
            if (columnIndex - 1 >= 0) list.Add(index - 1);
            if (columnIndex + 1 <= Columns - 1) list.Add(index + 1);
            if (rowIndex - 1 >= 0 && columnIndex - 1 >= 0) list.Add(index - Columns - 1);
            if (rowIndex - 1 >= 0 && columnIndex + 1 <= Columns - 1) list.Add(index - Columns + 1);
            if (rowIndex + 1 <= Rows - 1 && columnIndex - 1 >= 0) list.Add(index + Columns - 1);
            if (rowIndex + 1 <= Rows - 1 && columnIndex + 1 <= Columns - 1) list.Add(index + Columns + 1);

            return list;
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