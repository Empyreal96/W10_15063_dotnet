// Decompiled with JetBrains decompiler
// Type: System.Data.PropertyAttributes
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace System.Data
{
  [Flags]
  [Obsolete("PropertyAttributes has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
  public enum PropertyAttributes
  {
    NotSupported = 0,
    Required = 1,
    Optional = 2,
    Read = 512, // 0x00000200
    Write = 1024, // 0x00000400
  }
}
