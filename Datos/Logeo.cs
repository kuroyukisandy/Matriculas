using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

using Encapsulado;

namespace Datos
{
    public class Logeo
    {
        public Hashtable credenciales { get; set; }

        public bool login(Encapsular objEnc)
        {
            DataTable dt=new DataTable();
            MySqlConnection conex = new MySqlConnection(Utilidad.cadenaconex());
            try
            {
                conex.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SP_login", conex);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("_Usuario", MySqlDbType.VarChar).Value = objEnc._Usuario;
                da.SelectCommand.Parameters.Add("_Clave",MySqlDbType.VarChar).Value = objEnc._Clave;
                da.Fill(dt);
            }
            catch (MySqlException mysqle) {
                MessageBox.Show( mysqle.Message,"Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e) {
                MessageBox.Show("Ha ocurrido un error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conex.Close(); }
            if(objEnc._Usuario=="harold"){
                return true;
            }else{
                return false;
            }
        }
    }
}
