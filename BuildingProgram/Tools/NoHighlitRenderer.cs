using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingProgram.Tools
{
    internal class NoHighlightRenderer : ToolStripProfessionalRenderer
    {
        Font textFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color menuItemSelectedColor = Color.Black;
        private Color menuItemBorderColor = Color.Red;
        private Color textColor = Color.White;
        public NoHighlightRenderer() : base(new MenuBarColor())
        {
            // item bg color
            this.menuItemSelectedColor = Color.White;
            // item border
            this.menuItemBorderColor = Color.White;
            this.textColor = Color.White;

        }
    }
}
