// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.VectorChangedEventHandler`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(201660242, 40895, 19568, 170, 12, 14, 76, 130, 217, 167, 97)]
  public delegate void VectorChangedEventHandler<T>(
    IObservableVector<T> sender,
    IVectorChangedEventArgs @event);
}
