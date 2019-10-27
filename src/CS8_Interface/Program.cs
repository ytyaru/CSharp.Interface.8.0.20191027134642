using System;
using System.Collections.Generic;

namespace CS8_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // マウス生成
            List<IMouse> mouses = new List<IMouse> {
                new SimpleMouse(), 
                new PopularMouse(),
                new MultifunctionalMouse(),
            };
            // メソッド呼出
            foreach(IMouse mouse in mouses) {
                mouse.Move();
                mouse.ClickLeft();
                mouse.ClickRight();
                if (mouse is IWheelButtonMouse wheelButtonMouse) {
                    wheelButtonMouse.ClickCenter();
                }
                if (mouse is IWheelMouse wheelMouse) {
                    wheelMouse.ScrollUp();
                    wheelMouse.ScrollDown();
                }
                if (mouse is ITiltWheelMouse tiltWheelMouse) {
                    tiltWheelMouse.TiltLeft();
                    tiltWheelMouse.TiltRight();
                }
                if (mouse is IExtendButtonMouse extendButtonMouse) {
                    extendButtonMouse.PushButton1();
                    extendButtonMouse.PushButton2();
                }
            }
        }
    }
}
