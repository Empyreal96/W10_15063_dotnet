// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IReference`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(1640068870, 11621, 4576, 154, 232, 212, 133, 100, 1, 84, 114)]
  public interface IReference<T> : IPropertyValue
  {
    T Value { [MethodImpl] get; }
  }
}
