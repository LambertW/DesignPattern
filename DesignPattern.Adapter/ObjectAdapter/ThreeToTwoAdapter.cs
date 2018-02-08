using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter.ObjectAdapter
{
    /// <summary>
    /// 适配器类
    /// </summary>
    public class ThreeToTwoAdapter : TwoHoleTarget
    {
        // 引用两个孔插头的实例,从而将客户端与TwoHole联系起来
        private ThreeHoleAdaptee threeHoleAdaptee = new ThreeHoleAdaptee();

        public override void Request()
        {
            threeHoleAdaptee.SpecificRequest();
        }
    }
}
