using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Winform的UI界面优化方法
/// </summary>
namespace Module_MKTools
{
    /// <summary>
    /// 重写Menu背景颜色属性
    /// </summary>
    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(0, 71, 160); }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(45, 140, 230); }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(0, 71, 160); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.LightSkyBlue; }
        }
    }

    public class NewColorRenderer : ToolStripProfessionalRenderer
    {
        public NewColorRenderer() : base(new MyColors()) { }
    }

}
