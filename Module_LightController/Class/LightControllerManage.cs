using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Module_LightController
{
    /// <summary>
    /// 光源控制器
    /// </summary>
    public class LightControllerManage
    {
        public LightControllerManage(LightBrandEnum lightBrands)
        {
            SwitchCommType(lightBrands);
        }

        public LightControllerManage(LightBrandEnum lightBrands, Dictionary<string, string> props)
        {
            SwitchCommType(lightBrands, props);
        }

        public LightControllerBase _LightControllerBase;

        /// <summary>
        /// 光源控制器控制界面
        /// </summary>
        public Form FormControllerSetting;

        public LightControllerBase SwitchCommType(LightBrandEnum lightBrands)
        {

            switch (lightBrands)
            {
                case LightBrandEnum.RS232MX:
                    _LightControllerBase = new LightController_RS232_MX();
                    FormControllerSetting = new FormControllerRS232(_LightControllerBase);
                    break;
            }
            return _LightControllerBase;
        }

        public LightControllerBase SwitchCommType(LightBrandEnum lightBrands, Dictionary<string, string> props)
        {

            switch (lightBrands)
            {
                case LightBrandEnum.RS232MX:
                    _LightControllerBase = new LightController_RS232_MX();
             
                    foreach (KeyValuePair<string, string> item in props)
                    {
                        ((LightController_RS232_MX)_LightControllerBase).SetParamValue(item.Key, item.Value);
                    }

                    FormControllerSetting = new FormControllerRS232(_LightControllerBase);
                    break;
            }
            return _LightControllerBase;
        }
    }
}
