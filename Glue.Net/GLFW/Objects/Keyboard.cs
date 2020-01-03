using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.GLFW
{
    public class Keyboard
    {
        public static Keyboard GetKeyboard(GLFW_Window window) => window.Keyboard;

        Dictionary<KeyCode, Key> keys;
        public Key GetKey(KeyCode keycode)
        {
            if (keys.TryGetValue(keycode, out Key k))
                return k;
            else
                return null;
        }

        internal void __Init()
        {
            KeyCode[] arr = Enum.GetValues(typeof(KeyCode)) as KeyCode[];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == KeyCode.UNKNOWN)
                    continue;

                int scancode = Glfw.__GetKeyScancode((int)arr[i]);
                Key k = new Key(scancode, arr[i]);
                keys.Add(arr[i], k);
            }
                
        }

        internal Keyboard() {
            keys = new Dictionary<KeyCode, Key>();
        }


        internal void __UpdateKeyStates(GLFW_Window window)
        {
            foreach (KeyValuePair<KeyCode, Key> kvp in keys)
                kvp.Value.__UpdateState(Glfw.__GetKey(window.Handle, (int)kvp.Value.KeyCode));
        }
    }
}
