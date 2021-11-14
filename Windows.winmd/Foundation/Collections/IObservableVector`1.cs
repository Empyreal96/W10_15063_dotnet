// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IObservableVector`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(1494739795, 20660, 18957, 179, 9, 101, 134, 43, 63, 29, 188)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IObservableVector<T> : IVector<T>
  {
    event VectorChangedEventHandler<T> VectorChanged;
  }
}
