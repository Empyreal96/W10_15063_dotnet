// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IVectorChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(1465463775, 13566, 17536, 175, 21, 7, 105, 31, 61, 93, 155)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IVectorChangedEventArgs
  {
    CollectionChange CollectionChange { get; }

    uint Index { get; }
  }
}
