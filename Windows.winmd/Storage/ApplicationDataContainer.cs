// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ApplicationDataContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ApplicationDataContainer : IApplicationDataContainer
  {
    public extern string Name { [MethodImpl] get; }

    public extern ApplicationDataLocality Locality { [MethodImpl] get; }

    public extern IPropertySet Values { [MethodImpl] get; }

    public extern IMapView<string, ApplicationDataContainer> Containers { [MethodImpl] get; }

    [MethodImpl]
    public extern ApplicationDataContainer CreateContainer(
      string name,
      ApplicationDataCreateDisposition disposition);

    [MethodImpl]
    public extern void DeleteContainer(string name);
  }
}
