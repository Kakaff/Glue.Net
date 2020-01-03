using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.GLFW
{
    public delegate void keychangedfunc(Key k);

    public sealed class Key
    {
        public KeyState State { get; private set; }
        public KeyCode KeyCode { get; private set; }
        public int Scancode { get; private set; }

        public event keychangedfunc OnKeyDown
        {
            add => onKeyDown += value;
            remove => onKeyDown -= value;
        }

        public event keychangedfunc OnKeyUp
        {
            add => onKeyUp += value;
            remove => onKeyUp -= value;
        }

        public event keychangedfunc OnKeyPressed
        {
            add => onKeyPressed += value;
            remove => onKeyPressed -= value;
        }

        public event keychangedfunc OnKeyReleased
        {
            add => onKeyReleased += value;
            remove => onKeyReleased -= value;
        }

        event keychangedfunc onKeyDown,onKeyUp,onKeyPressed,onKeyReleased;

        internal Key(int scancode,KeyCode keycode)
        {
            this.Scancode = scancode;
            KeyCode = keycode;
            State = KeyState.Up;
        }

        internal void __UpdateState(int newstate)
        {
            if (newstate == Glfw.GLFW_PRESS || newstate == Glfw.GLFW_REPEAT)
            {
                if (CheckState(KeyState.Up))
                {
                    State = KeyState.Pressed | KeyState.Down;
                    onKeyPressed?.Invoke(this);
                }
                else if (CheckState(KeyState.Pressed))
                    State = KeyState.Down;

                onKeyDown?.Invoke(this);
            } else if (newstate == Glfw.GLFW_RELEASE)
            {
                if (CheckState(KeyState.Down))
                {
                    State = KeyState.Released | KeyState.Up;
                    onKeyReleased?.Invoke(this);
                }
                else if (CheckState(KeyState.Released))
                    State = KeyState.Up;

                onKeyUp?.Invoke(this);
            }
        }

        public bool CheckState(KeyState ks) => (State & ks) != 0;
    }
}
