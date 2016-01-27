using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Importador
{
    public partial class Form1 : Form
    {

        #region << Eventos >>
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Importar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarAccion();
        }
        #endregion
        #region << Metodos >>
        public class Item
        {
            public string Name { get; set; }
            public int Value { get; set; }

            public Item(string name, int value)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        private void LlenarAccion()
        {

            List<Item> lista = new List<Item>();

            lista.Add(new Item("Productos", 1));
            lista.Add(new Item("Precios", 2));
          

            this.cmbAccion.DisplayMember = "Name";
            this.cmbAccion.ValueMember = "Value";
            this.cmbAccion.DataSource = lista;

            
        }


        private void Importar() { 
               
        }
        #endregion

   
    }
}
