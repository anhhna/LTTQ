using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hsCustomControl
{
    public partial class hsTreeView : UserControl
    {
        private bool bCo;
        private string stooltip = "";
        private string strMa = "";
        private string strTen = "";

        public hsTreeView()
        {
            this.InitializeComponent();
        }

        private void chkTitle_CheckedChanged(object sender, EventArgs e)
        {
            this.f_Set_CheckID(this.treeView1, this.chkTitle.Checked);
        }

        private void chkTitle_MouseMove(object sender, MouseEventArgs e)
        {
            this.toolTip1.SetToolTip(this.chkTitle, this.stooltip);
        }

        private void f_Get_CheckID()
        {
            try
            {
                this.strMa = "";
                this.strTen = "";
                for (int i = 0; i < this.treeView1.Nodes.Count; i++)
                {
                    if (this.treeView1.Nodes[i].Checked)
                    {
                        if (this.bCo)
                        {
                            this.strMa = this.strMa + "'" + this.treeView1.Nodes[i].Tag.ToString() + "',";
                        }
                        else
                        {
                            this.strMa = this.strMa + this.treeView1.Nodes[i].Tag.ToString() + ",";
                        }
                        this.strTen = this.strTen + this.treeView1.Nodes[i].Text + "^";
                    }
                }
            }
            catch
            {
            }
        }

        public int Count
        {
            get
            {
                return this.treeView1.Nodes.Count;
            }
        }

        public bool IsCheck(int i)
        {
            return this.treeView1.Nodes[i].Checked;
        }

        public string GetDisplay(int i)
        {
            return this.treeView1.Nodes[i].Text;
        }

        public string GetValue(int i)
        {
            return this.treeView1.Nodes[i].Tag.ToString();
        }

        private void f_Set_Check(TreeNode v_node, bool v_bool)
        {
            try
            {
                foreach (TreeNode anode in v_node.Nodes)
                {
                    anode.Checked = v_bool;
                    anode.ForeColor = anode.Checked ? Color.Blue : Color.Black;
                    if (anode.Nodes.Count > 0)
                    {
                        this.f_Set_Check(anode, v_bool);
                    }
                }
            }
            catch
            {
            }
        }

        private void f_Set_CheckID(TreeView v_tree, bool v_b)
        {
            try
            {
                for (int i = 0; i < v_tree.Nodes.Count; i++)
                {
                    v_tree.Nodes[i].Checked = v_b;
                    v_tree.Nodes[i].ForeColor = v_tree.Nodes[i].Checked ? Color.Blue : Color.Black;
                }
            }
            catch
            {
            }
        }

        public void f_Set_CheckID(string tag, bool v_b)
        {
            try
            {
                for (int i = 0; i < this.treeView1.Nodes.Count; i++)
                {
                    if (this.treeView1.Nodes[i].Tag.ToString() == tag)
                    {
                        this.treeView1.Nodes[i].Checked = v_b;
                        this.treeView1.Nodes[i].ForeColor = this.treeView1.Nodes[i].Checked ? Color.Blue : Color.Black;
                    }
                }
            }
            catch
            {
            }
        }

        public void f_set_CheckTreeView(DataSet ads, string s_sosanh)
        {
            foreach (DataRow r in ads.Tables[0].Select("done=1"))
            {
                for (int i = 0; i < this.treeView1.Nodes.Count; i++)
                {
                    if (r[s_sosanh].ToString() == this.treeView1.Nodes[i].Tag.ToString())
                    {
                        this.treeView1.Nodes[i].Checked = true;
                        this.treeView1.Nodes[i].ForeColor = this.treeView1.Nodes[i].Checked ? Color.Blue : Color.Black;
                    }
                }
            }
        }

        public void setDataSource(DataTable dt, string strDisplayMember, string strValuaMember, string strTieude, bool b_dk, string s_tooltip)
        {
            this.chkTitle.Text = strTieude.ToUpper();
            this.treeView1.Nodes.Clear();
            this.bCo = b_dk;
            this.stooltip = s_tooltip;
            this.treeView1.BeginUpdate();
            foreach (DataRow r in dt.Rows)
            {
                TreeNode anode = new TreeNode(r[strDisplayMember].ToString()) {
                    Tag = r[strValuaMember].ToString()
                };
                this.treeView1.Nodes.Add(anode);
                anode.ExpandAll();
            }
            this.treeView1.EndUpdate();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if ((e.Action == TreeViewAction.ByMouse) || (e.Action == TreeViewAction.ByKeyboard))
            {
                e.Node.ForeColor = e.Node.Checked ? Color.Blue : Color.Black;
                this.treeView1.ExpandAll();
            }
            this.treeView1.ExpandAll();
        }

        public string get_Ma
        {
            get
            {
                this.f_Get_CheckID();
                return this.strMa;
            }
        }

        public TreeView get_TreeView
        {
            get
            {
                return this.treeView1;
            }
        }

        public string get_Ten
        {
            get
            {
                this.f_Get_CheckID();
                return this.strTen;
            }
        }

        public bool set_CheckBox
        {
            set
            {
                this.chkTitle.Checked = value;
            }
        }
    }
}
