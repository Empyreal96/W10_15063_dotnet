// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Graphics.DeviceLostException
// Assembly: Microsoft.Xna.Framework.Graphics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 222C1F45-3A13-4016-A5CC-9C488C5318DA
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI1FF1~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
  [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Justification = "The serialization types do not exist on XBOX360")]
  public sealed class DeviceLostException : Exception
  {
    public DeviceLostException()
    {
    }

    public DeviceLostException(string message)
      : base(message)
    {
    }

    public DeviceLostException(string message, Exception inner)
      : base(message, inner)
    {
    }
  }
}
