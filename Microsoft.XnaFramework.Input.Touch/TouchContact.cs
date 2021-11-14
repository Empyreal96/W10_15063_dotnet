// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.TouchContact
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

namespace Microsoft.Xna.Framework.Input.Touch
{
  internal struct TouchContact
  {
    internal ushort wContactID;
    internal TouchEventFlags wFlags;
    internal short xScreen;
    internal short yScreen;
    internal short xWindow;
    internal short yWindow;
    internal short reserved0;
    internal short reserved1;
    internal short reserved2;
    internal short reserved3;
    internal short reserved4;
    internal short reserved5;
    internal ulong reserved6;
    internal Matrix3X2 reserved7;
  }
}
