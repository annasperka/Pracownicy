using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KotrakMed
{
    public class EntityProperties
    {
        public enum Status:byte { New = 1, Accepted = 2, Blocked = 3}
    }

    public class Tools
    {
        public void Transform(DataTable dataTable)
        {
            dataTable.Columns["Status"].DefaultValue = (byte)EntityProperties.Status.New;
            dataTable.Columns["StatusValue"].DefaultValue = EntityProperties.Status.New.ToString();

            foreach (DataRow row in dataTable.Rows)
            {
                byte value = (byte)row["Status"];
                row["StatusValue"] = (EntityProperties.Status)value;
            }
        }

        public void SetDisplayMember(DataGridViewComboBoxColumn column)
        {
            column.DisplayMember = "StatusValue";
        }

         public static bool CheckEmailFormat(string email)
        {
            if (email == String.Empty) return true;

            Regex RX = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");

            if (!RX.IsMatch(email))
            {
                return false;

            }

            return true;

        }

        public void SetDisplayMember(ComboBox combo)
        {
            combo.DisplayMember = "StatusValue";
        }
    }


   
}
