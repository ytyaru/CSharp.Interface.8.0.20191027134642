using System;

namespace CS8_Interface
{
    public class MultifunctionalMouse : IWheelMouse, IWheelButtonMouse, ITiltWheelMouse, IExtendButtonMouse
    {
        public void Move() {}
        public void ClickLeft() {}
        public void ClickRight() {}
        public void ClickCenter() {}
        public void ScrollUp() {}
        public void ScrollDown() {}
        public void TiltLeft() {}
        public void TiltRight() {}
        public void PushButton1() {}
        public void PushButton2() {}
    }
}
