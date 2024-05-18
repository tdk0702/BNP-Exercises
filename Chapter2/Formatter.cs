using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Chapter2
{
    public partial class Formatter : Form
    {
        public Formatter()
        {
            InitializeComponent();
        }

        public enum purchaseOrderStates
        {
            ISSUED, DELIVERED, INVOICED, PAID
        }
        [Serializable()]
        public class company
        {
            public string name;
            public string address;
            public string phone;
        }
        [Serializable()]
        public class lineItem
        {
            public string description;
            public int quantity;
            public double cost;
        }
        [Serializable()]
        public class purchaseOrder
        {
            private purchaseOrderStates _purchaseOrderStatus;
            private DateTime _issuanceDate;
            private DateTime _deliveryDate;
            private DateTime _invoiceDate;
            private DateTime _paymentDate;
            public company buyer;
            public company vendor;
            public string reference;
            public lineItem[] items;
            public purchaseOrder()
            {
                _purchaseOrderStatus = purchaseOrderStates.ISSUED;
                _issuanceDate = DateTime.Now;
            }
            public void recordDelivery()
            {
                if (_purchaseOrderStatus == purchaseOrderStates.ISSUED)
                {
                    _purchaseOrderStatus = purchaseOrderStates.DELIVERED;
                    _deliveryDate = DateTime.Now;
                }
            }


        }

        company Vendor = new company();
        company Buyer = new company();
        lineItem Goods = new lineItem();
        purchaseOrder po = new purchaseOrder();

        private void SoapFormatter_Load(object sender, EventArgs e)
        {
            Vendor.name = "Acme Inc.";
            Buyer.name = "Wiley E. Coyote";
            Goods.description = "anti-RoadRunner cannon";
            Goods.quantity = 1;
            Goods.cost = 599.99;
            po.items = new lineItem[1];
            po.items[0] = Goods;
            po.buyer = Buyer;
            po.vendor = Vendor;

        }
        private void btnSOAPSerial_Click(object sender, EventArgs e)
        {
            SoapFormatter sf = new SoapFormatter();
            FileStream fs = File.Create("..\\po.xml");
            sf.Serialize(fs, po);
            fs.Close();
        }
        private void btnSOAPDeserial_Click(object sender, EventArgs e)
        {
            SoapFormatter sf = new SoapFormatter();
            FileStream fs = File.OpenRead("..\\po.xml");
            purchaseOrder pi = (purchaseOrder) sf.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Customer is " + pi.buyer.name +
                "\nVendor is " + pi.vendor.name + ", phone is " + pi.vendor.phone +
                            "\nItem is " + pi.items[0].description + " has quantity " +
                            pi.items[0].quantity.ToString() + ", has cost " + pi.items[0].cost.ToString());

        }
        [Obsolete]
        private void btnBinarySerial_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Create("..\\po_bin.txt");
            bf.Serialize(fs, po);
            fs.Close();
            MessageBox.Show("Serialize succesful!", "Info");

        }

        [Obsolete]
        private void btnBinaryDeserial_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.OpenRead("..\\po_bin.txt");
            purchaseOrder po = (purchaseOrder)bf.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Customer is " + po.buyer.name);

        }
        private void btnXMLSerial_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(po.GetType());
            FileStream fs = File.Create("..\\po1.xml");
            xs.Serialize(fs, po);
            fs.Close();

        }
        private void btnXMLDeserial_Click(object sender, EventArgs e)
        {
            purchaseOrder po = new purchaseOrder();
            XmlSerializer xs = new XmlSerializer(po.GetType());
            FileStream fs = File.OpenRead("..\\po1.xml");
            po = (purchaseOrder) xs.Deserialize(fs);
            fs.Close();
            MessageBox.Show("Customer is " + po.buyer.name +
                "\nVendor is " + po.vendor.name + ", phone is " + po.vendor.phone + "\nItem is " + po.items[0].description + " has quantity " +
                po.items[0].quantity.ToString() + ", has cost " + po.items[0].cost.ToString());

        }
    }
}
