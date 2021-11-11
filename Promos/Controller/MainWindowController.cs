using System;
using System.Collections.Generic;
using System.Text;
using Promo_0177.Model;

namespace Promo_0177.Controller
{
    class MainWindowController 
    {
        KeranjangBelanja keranjangBelanja;

        public MainWindowController(KeranjangBelanja keranjangBelanja)
        {
            this.keranjangBelanja = keranjangBelanja;
        }

        public void addItem(Item item)
        {
            this.keranjangBelanja.addItem(item);
        }
        public List<Item> getSelectedItems()
        {
            return this.keranjangBelanja.getItems();
        }

        public void deleteSelectedItem(Item item)
        {
            this.keranjangBelanja.removeItem(item);
        }


    }

}
