// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.TypedEventHandler`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(2648818996, 27361, 4576, 132, 225, 24, 169, 5, 188, 197, 63)]
  public delegate void TypedEventHandler<TSender, TResult>(TSender sender, TResult args);
}
