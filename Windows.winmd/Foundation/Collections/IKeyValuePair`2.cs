// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IKeyValuePair`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(45422889, 49604, 19070, 137, 64, 3, 18, 181, 193, 133, 0)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IKeyValuePair<K, V>
  {
    K Key { [MethodImpl] get; }

    V Value { [MethodImpl] get; }
  }
}
