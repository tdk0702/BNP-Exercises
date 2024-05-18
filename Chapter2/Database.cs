using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Xml.Serialization;


namespace Chapter2
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private static string strCon;
        public static SqlConnection scn;
        public static OleDbConnection ocn;
        private void SQLDatabase_Load(object sender, EventArgs e)
        {

        }

        private void btnSqlConnect_Click(object sender, EventArgs e)
        {
            strCon = "Data Source=" + txtTenSerVer.Text + ";Initial Catalog=qlhokhau;Persist Security Info=True;User ID=sa;Password=123456";
            try
            {
                scn = new SqlConnection(strCon);
                scn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chi tiết kỹ thuật: " + ex.ToString(),
                    "Thông báo lỗi kết nối dữ liệu!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
        }
        private void btnOleConnect_Click(object sender, EventArgs e)
        {
            string dataPath = tbxOleCon.Text;
            string myConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
            dataPath + ";Persist Security Info=True;Jet OLEDB:Database Password=123456";
            try
            {
                ocn = new OleDbConnection(strCon);
                ocn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chi tiết kỹ thuật: " + ex.ToString(), "Thông báo lỗi kết nối dữ liệu!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
        }
        public void nonQuery(string szSQL, string szDSN)
        {
            OleDbConnection DSN = new OleDbConnection(szDSN);
            DSN.Open();
            OleDbCommand SQL = new OleDbCommand(szSQL, DSN);
            SQL.ExecuteNonQuery();
            DSN.Close();
        }
        public DataSet Query(string szSQL, string szDSN)
        {
            DataSet ds = new DataSet();
            OleDbConnection DSN = new OleDbConnection(szDSN);
            DSN.Open();
            OleDbCommand SQL = new OleDbCommand(szSQL, DSN);
            OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL);
            Adapter.Fill(ds, "sql");
            DSN.Close();
            return (ds);
        }

        public DataSet DataSerial(string command)
        {
            string szDSN = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\purchaseOrder.mdb";
            OleDbConnection DSN = new OleDbConnection(szDSN);
            XmlSerializer xs = new XmlSerializer(typeof(DataSet));
            DataSet ds = new DataSet();
            DSN.Open();
            OleDbCommand odbc = new OleDbCommand(command, DSN);
            OleDbDataAdapter odda = new OleDbDataAdapter(odbc);
            odda.Fill(ds, "sql");
            TextWriter tw = new StreamWriter("..\\sql.xml");
            xs.Serialize(tw, ds);
            tw.Close();
            DSN.Close();
            return ds;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataSet ds = DataSerial(tbxQuery.Text);
            tbxResult.Text = ds.ToString();
        }
    }
}
