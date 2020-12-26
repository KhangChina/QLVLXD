using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVLXD
{
    public partial class usTonKho : DevExpress.XtraEditors.XtraUserControl
    {

        private static usTonKho _instance;
        public static usTonKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usTonKho();
                return _instance;
            }
        }
        public usTonKho()
        {
            InitializeComponent();
        }
    }
}
