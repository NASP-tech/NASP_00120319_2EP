using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClaseGUI05
{
    public partial class AddOrder : UserControl
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            var product = Connection.addQuery("SELECT productname FROM product");
            var productCombo = new List<string>();
            foreach (DataRow dr in product.Rows)
            {
                productCombo.Add(dr[0].ToString());
            }

            cmbOrder.DataSource = productCombo;

            var address = Connection.addQuery("SELECT address FROM address ");
            var addressCombo = new List<string>();
            foreach (DataRow dl in address.Rows)
            {
                addressCombo.Add(dl[0].ToString());
            }

            cmbAddress.DataSource = addressCombo;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cmbAddress.Text.Equals(""))
            {
                MessageBox.Show("Can't leave empty space");
            }
            else
            {
                try
                {
                    string nonQuery = $"INSERT INTO APPORDER(idproducto, idaddress) VALUES(" +
                                      $"'{cmbOrder.Text.ToString()}'," +
                                      $"{cmbAddress.Text.ToString()}";
                    Connection.addNonQuery(nonQuery);

                    MessageBox.Show("Your orden has begun! Thank you for your choice :)");

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void btnCheckOrderHistory_Click(object sender, EventArgs e)
        {
            if (cmbOrder.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }

            else
            {
                try
                {
                    var dt = Connection.addQuery($"SELECT prod.idproduct, order.idaddress" +
                                                 "FROM product prod, apporder order, address ad" +
                                                 $"WHERE order.idproduct = prod.idproduct AND order.idaddress = ad.idaddress" +
                                                 $"AND order.idproduct = {cmbOrder.SelectedItem.ToString()}");

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}