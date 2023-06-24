using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Test.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private int id;
        private string traceability;
        private DatosLista itemL1;
        private DatosLista itemL2;
        private ICommand izquierdaTodo;
        private ICommand izquierdaUno;
        private ICommand derechaTodo;
        private ICommand derechaUno;
        private ObservableCollection<DatosLista> lista1;
        private ObservableCollection<DatosLista> lista2;

        public MainViewModel()
        {
            Random rnd = new Random();
            lista1 = new ObservableCollection<DatosLista>();
            lista2 = new ObservableCollection<DatosLista>();

            for (int i = 0; i < 10; i++)
            {
                lista1.Add(new DatosLista((i+1), (rnd.Next(1, 100000 + 1)).ToString()));
            }
            for (int i = 10; i < 20; i++)
            {
                lista2.Add(new DatosLista((i + 1), (rnd.Next(1, 100000 + 1)).ToString()));
            }
        }

        public ObservableCollection<DatosLista> Lista1
        {
            get { return lista1; }
            set
            {
                lista1 = value;
                OnPropertyChanged(nameof(lista1));
            }
        }
        public ObservableCollection<DatosLista> Lista2
        {
            get { return lista2; }
            set
            {
                lista2 = value;
                OnPropertyChanged(nameof(lista2));
            }
        }
        public int Id
        {
            get { return id; }
            set { 
                id = value; 
                OnPropertyChanged("Id"); 
            }
        }
        public string Traceability
        {
            get { return traceability; }
            set { 
                traceability = value; 
                OnPropertyChanged("Traceability");
            }
        }

        public DatosLista ItemL1
        {
            get { return itemL1; }
            set
            {
                itemL1 = value;
                itemL2 = null;
                OnPropertyChanged(nameof(itemL1));
                OnPropertyChanged(nameof(itemL2));
            }
        }
        public DatosLista ItemL2
        {
            get { return itemL2; }
            set
            {
                itemL2 = value;
                itemL1 = null;
                OnPropertyChanged(nameof(itemL1));
                OnPropertyChanged(nameof(itemL2));
            }
        }

        public  ICommand DerechaTodo
        {
            get
            {
                if (derechaTodo == null)
                {
                    derechaTodo = new RelayCommand(p => this.MoverDerechaTodo());
                }
                return derechaTodo;
            }
        }

        public void MoverDerechaTodo()
        {
            bool ban = false;
            int i = 0;
            try
            {

                if (lista1.Count > 0)
                {
                    var result = MessageBox.Show("Seguro que deseas mover Todos los registro de la lista 1!", "Message", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                    {
                        for (i = 0; i < lista1.Count; i++)
                        {
                            DatosLista newlist = new DatosLista(lista1[i].Id, lista1[i].Traceability);
                            lista2.Add(newlist);
                        }
                        lista1.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("La lista 1 esta vacia!", "Message", MessageBoxButton.OK);
                }
            }
            catch (Exception ex) { }
        }

        public ICommand DerechaUno
        {
            get
            {
                if (derechaUno == null)
                {
                    derechaUno = new RelayCommand(p => this.MoverDerechaUno());
                }
                return derechaUno;
            }
        }

        public void MoverDerechaUno()
        {
            bool ban = false;
            int i = 0;
            try
            {
                if (itemL1 != null)
                {
                    var result = MessageBox.Show("Seguro que deseas mover este registro!", "Message", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        var row = itemL1.Id;
                        Console.WriteLine("row: " + row);
                        for (i = 0; i < lista1.Count; i++)
                        {
                            if (row == lista1[i].Id)
                            {
                                DatosLista newlist = new DatosLista(lista1[i].Id, lista1[i].Traceability);
                                lista2.Add(newlist);
                                lista1.RemoveAt(i);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un registro de la lista izquierda!", "Message", MessageBoxButton.OK);
                }
            }
            catch (Exception ex) { }
        }

        public ICommand IzquierdaTodo
        {
            get
            {
                if (izquierdaTodo == null)
                {
                    izquierdaTodo = new RelayCommand(p => this.MoverIzquierdaTodo());
                }
                return izquierdaTodo;
            }
        }

        public void MoverIzquierdaTodo()
        {
            bool ban = false;
            int i = 0;
            try
            {
                
                if (lista2.Count>0)
                {   
                    var result = MessageBox.Show("Seguro que deseas mover Todos los registro de la lista 2!", "Message", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                    {
                        for (i = 0; i < lista2.Count; i++)
                        {
                            DatosLista newlist = new DatosLista(lista2[i].Id, lista2[i].Traceability);
                            lista1.Add(newlist);
                        }
                        lista2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("La lista 2 esta vacia!", "Message", MessageBoxButton.OK);
                }
            }
            catch (Exception ex) { }
        }

        public ICommand IzquierdaUno
        {
            get
            {
                if (izquierdaUno == null)
                {
                    izquierdaUno = new RelayCommand(p => this.MoverIzquierdaUno());
                }
                return izquierdaUno;
            }
        }

        public void MoverIzquierdaUno()
        {
            bool ban = false;
            int i = 0;
            try
            {
                if (itemL2 != null)
                {
                    var result = MessageBox.Show("Seguro que deseas mover este registro!", "Message", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                    {
                        var row = itemL2.Id;
                        Console.WriteLine("row: " + row);
                        for (i = 0; i < lista2.Count; i++)
                        {
                            if (row == lista2[i].Id)
                            {
                                DatosLista newlist = new DatosLista(lista2[i].Id, lista2[i].Traceability);
                                lista1.Add(newlist);
                                lista2.RemoveAt(i);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un registro de la lista derecha!", "Message", MessageBoxButton.OK);
                }
            }
            catch (Exception ex) { }
        }
    }
}
