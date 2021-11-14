// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.TouchInfoBuffer
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

namespace Microsoft.Xna.Framework.Input.Touch
{
  internal struct TouchInfoBuffer
  {
    internal ushort cbSize;
    internal GestureInfoFlags dwFlags;
    internal uint dwTimeStamp;
    internal ulong hwndTarget;
    internal uint dwSessionID;
    internal byte reserved;
    internal byte cInRangeContacts;
    internal byte cInContactContacts;
    internal byte cContacts;
    internal TouchContacts rgContacts;
  }
}
