using Superheroes.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Superheroe heroeActual;
        public Superheroe HeroeActual
        {
            get { return heroeActual; }
            set { 
                heroeActual = value;
                NotifyPropertyChanged("HeroeActual");
            }
        }

        private int contadorActual;
        public int ContadorActual
        {
            get { return contadorActual; }
            set { 
                contadorActual = value;
                NotifyPropertyChanged("ContadorActual");
            }
        }

        private int totalHeroes;
        public int TotalHeroes
        {
            get { return totalHeroes; }
            set {
                totalHeroes = value;
                NotifyPropertyChanged("TotalHeroes");
            }
        }

        List<Superheroe> lista;

        public MainWindowVM()
        {
            contadorActual = 1;
            totalHeroes = 3;
            HeroeActual = lista[contadorActual - 1];
            TotalHeroes = lista.Count;
        }

        public void Avanzar()
        {
            ContadorActual++;
            HeroeActual = lista[contadorActual - 1];
        }

        public void Retroceder()
        {
            ContadorActual--;
            HeroeActual = lista[contadorActual - 1];
        }

    }
}
