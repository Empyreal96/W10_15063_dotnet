// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IMapChangedEventArgs`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(2570712287, 1290, 19471, 170, 96, 119, 7, 95, 156, 71, 119)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IMapChangedEventArgs<K>
  {
    CollectionChange CollectionChange { [MethodImpl] get; }

    K Key { [MethodImpl] get; }
  }
}
