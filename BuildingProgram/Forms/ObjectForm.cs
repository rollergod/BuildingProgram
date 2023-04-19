using BuildingProgram.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingProgram.Forms
{
    public partial class ObjectForm : BaseForm
    {
        public ObjectForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
        }
        
    }
}
