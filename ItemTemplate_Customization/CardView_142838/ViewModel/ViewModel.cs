using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CardView_142838
{

    public class ViewModel
    {       
        private ObservableCollection<Model> collection;
        public ObservableCollection<Model> CardViewcollections
        {
            get { return collection; }
            set { collection = value; }
        }
   
        public ViewModel()
        {
            CardViewcollections = new ObservableCollection<Model>();
            GenerateItems();       
        }        
        private void GenerateItems()
        {
            for (int i = 0; i <= 5; i++)
            {
                collection.Add(new Model() { Name = "Item" + i, Header = "Header" + i });
            }
        }
    }
}
