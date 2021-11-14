// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceMapMapViewIterator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ResourceMapMapViewIterator : IIterator<IKeyValuePair<string, ResourceMap>>
  {
    public extern IKeyValuePair<string, ResourceMap> Current { [MethodImpl] get; }

    public extern bool HasCurrent { [MethodImpl] get; }

    [MethodImpl]
    public extern bool MoveNext();

    [MethodImpl]
    public extern uint GetMany([Out] IKeyValuePair<string, ResourceMap>[] items);
  }
}
