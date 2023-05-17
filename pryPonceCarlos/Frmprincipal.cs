using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace pryPonceCarlos
{
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;Persist Security Info=False;");
            conn.Open();
            MessageBox.Show("conexion exitosa");
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader lector;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.TableDirect;
            cmd.CommandText = "Clientes";

        } 
    }
}
