// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailQuerySearchFields
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum EmailQuerySearchFields : uint
  {
    None = 0,
    Subject = 1,
    Sender = 2,
    Preview = 4,
    Recipients = 8,
    All = 4294967295, // 0xFFFFFFFF
  }
}
