using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class LocalFiles : UserControl
    {
        public LocalFiles()
        {
            InitializeComponent();
        }
        public string Title
        {
            set
            {
                title.Text = value;
            }
            get
            {
                return title.Text;
            }
        }
        public string TolderPath
        {
            set
            {
                folderPath.Text = value;
            }
            get
            {
                return folderPath.Text;
            }
        }
    }
}
