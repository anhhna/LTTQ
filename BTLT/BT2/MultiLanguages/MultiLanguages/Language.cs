using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MultiLanguages
{
    public enum eLanguage
    {
        TiengViet = 0,
        TiengAnh = 1
    }

    public class Language
	{
		private DataSet ds = new DataSet();

		private int flag_language = (int)eLanguage.TiengViet;
        string from = "viet";
        string to = "anh";

        public Language()
		{
		}

        public void SetLanguage(int val)
        {
            this.flag_language = val;
            switch (this.flag_language)
            {
                case (int)eLanguage.TiengViet:
                    from = "viet";
                    to = "anh";
                    break;
                case (int)eLanguage.TiengAnh:
                    from = "anh";
                    to = "viet";
                    break;
            }
        }

		public void ChangeMainMenu(string frmName, MenuStrip mnu, DataSet ds)
		{
			ds.ReadXml(string.Concat("Language//", frmName, ".xml"));
            foreach (ToolStripMenuItem menu in mnu.Items)
            {
                ChangeMenu(menu);
            }
        }

        private void ChangeMenu(ToolStripMenuItem item)
        {
            item.Text = this.get_text(ds.Tables[0], to, item.Text, from);
            for (int i = 0; i < item.DropDown.Items.Count; i++)
            {
                ToolStripItem subItem = item.DropDown.Items[i];
                if (item is ToolStripMenuItem)
                {
                    ChangeMenu(subItem as ToolStripMenuItem);
                }
            }
        }

        public void ChangeLanguage(string frmName, Form frm)
        {
            this.ds.ReadXml("Language//" + frmName + ".xml");
            frm.Text = this.get_text(this.ds.Tables[0], to, frm.Text, from);
            foreach (Control control in frm.Controls)
            {
                control.Text = this.get_text(this.ds.Tables[0], to, control.Text, from);
                //switch (control.GetType().ToString())
                //{
                //    case "System.Windows.Forms.Label":
                //    case "System.Windows.Forms.Button":
                //    case "System.Windows.Forms.CheckBox":
                //        control.Text = this.get_text(this.ds.Tables[0], to, control.Text, from);
                //        break;
                //    case "System.Windows.Forms.Panel":
                //        break;
                //    case "System.Windows.Forms.GroupBox":
                //        break;
                //    case "System.Windows.Forms.TabControl":
                //        break;
                //}
            }
            ChangeMainMenu(frmName, frm.MainMenuStrip, this.ds);
        }

		private string get_text(DataTable dt, string to, string text, string from)
		{
			string str = text;
            string dkt = to + "='" + text + "'";
            DataRow dataRow = this.getrowbyid(dt, dkt);
			if (dataRow != null)
			{
				str = dataRow[from].ToString();
			}
			return str.Trim();
		}

		public DataRow getrowbyid(DataTable dt, string exp)
		{
			DataRow dataRow;
			try
			{
				dataRow = dt.Select(exp)[0];
			}
			catch
			{
				dataRow = null;
			}
			return dataRow;
		}
	}
}