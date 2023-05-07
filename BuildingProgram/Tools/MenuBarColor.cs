
namespace BuildingProgram.Tools
{
    internal class MenuBarColor : ProfessionalColorTable
    {
        // mainmenutirp bg color
        Color ManuBarCommonColor = Color.Transparent;
        // all items border
        Color MenuBorderColor = Color.White;
        // mianmenutrip border
        Color MenuItemBorderColor = Color.White;
        public MenuBarColor()
        {
        }
        #region
       
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return MenuBorderColor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return Color.White;
            }
        }
        public override Color MenuItemPressedGradientBegin => Color.Black;
        public override Color MenuItemPressedGradientEnd => Color.Black;
        #endregion
    }
}
