using System;

namespace CS8_Interface
{
    public interface ITiltWheelMouse : IMouse
    {
        public void TiltLeft();
        public void TiltRight();
    }
}
