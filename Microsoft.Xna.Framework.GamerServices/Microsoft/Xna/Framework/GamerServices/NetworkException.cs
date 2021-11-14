// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.NetworkException
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;

namespace Microsoft.Xna.Framework.GamerServices
{
  public class NetworkException : Exception
  {
    public NetworkException()
    {
    }

    public NetworkException(string message)
      : base(message)
    {
    }

    public NetworkException(string message, Exception innerException)
      : base(message, innerException)
    {
    }
  }
}
