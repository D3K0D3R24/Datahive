using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Datahive
{
    public class MenuColorTable:ProfessionalColorTable
    {
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectColor;

        //Constructor
        public MenuColorTable(bool isMainmenu, Color primaryColor)
        {
            if (isMainmenu)
            {
                backColor = Color.FromArgb(37, 39, 40);
                leftColumnColor = Color.FromArgb(32, 33, 51);
                borderColor = Color.FromArgb(32, 33, 51);
                menuItemBorderColor = primaryColor;
                menuItemSelectColor = primaryColor;
            }
            else
            {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuItemSelectColor = primaryColor;
            }
        }

        //Overrides
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backColor;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return borderColor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return menuItemBorderColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return menuItemSelectColor;
            }
        }
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return leftColumnColor;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return leftColumnColor;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return leftColumnColor;
            }
        }
    }
}
