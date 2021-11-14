// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.TouchContacts
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input.Touch
{
  internal struct TouchContacts
  {
    private TouchContact _contact0;
    private TouchContact _contact1;
    private TouchContact _contact2;
    private TouchContact _contact3;
    private TouchContact _contact4;
    private TouchContact _contact5;
    private TouchContact _contact6;
    private TouchContact _contact7;
    private TouchContact _contact8;
    private TouchContact _contact9;
    private TouchContact _contact10;
    private TouchContact _contact11;
    private TouchContact _contact12;
    private TouchContact _contact13;
    private TouchContact _contact14;
    private TouchContact _contact15;

    internal TouchContact this[int i]
    {
      get
      {
        switch (i)
        {
          case 0:
            return this._contact0;
          case 1:
            return this._contact1;
          case 2:
            return this._contact2;
          case 3:
            return this._contact3;
          case 4:
            return this._contact4;
          case 5:
            return this._contact5;
          case 6:
            return this._contact6;
          case 7:
            return this._contact7;
          case 8:
            return this._contact8;
          case 9:
            return this._contact9;
          case 10:
            return this._contact10;
          case 11:
            return this._contact11;
          case 12:
            return this._contact12;
          case 13:
            return this._contact13;
          case 14:
            return this._contact14;
          case 15:
            return this._contact15;
          default:
            throw new ArgumentOutOfRangeException(nameof (i));
        }
      }
      set
      {
        switch (i)
        {
          case 0:
            this._contact0 = value;
            break;
          case 1:
            this._contact1 = value;
            break;
          case 2:
            this._contact2 = value;
            break;
          case 3:
            this._contact3 = value;
            break;
          case 4:
            this._contact4 = value;
            break;
          case 5:
            this._contact5 = value;
            break;
          case 6:
            this._contact6 = value;
            break;
          case 7:
            this._contact7 = value;
            break;
          case 8:
            this._contact8 = value;
            break;
          case 9:
            this._contact9 = value;
            break;
          case 10:
            this._contact10 = value;
            break;
          case 11:
            this._contact11 = value;
            break;
          case 12:
            this._contact12 = value;
            break;
          case 13:
            this._contact13 = value;
            break;
          case 14:
            this._contact14 = value;
            break;
          case 15:
            this._contact15 = value;
            break;
          default:
            throw new ArgumentOutOfRangeException(nameof (i));
        }
      }
    }
  }
}
