using System;

namespace CS8_Interface
{
    public interface IWheelMouse : IMouse
    {
        public void ScrollUp();
        public void ScrollDown();
    }
}
