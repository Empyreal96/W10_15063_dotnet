// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.ContainerEncodingProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContainerEncodingProperties : 
    IContainerEncodingProperties,
    IMediaEncodingProperties
  {
    [MethodImpl]
    public extern ContainerEncodingProperties();

    public extern MediaPropertySet Properties { [MethodImpl] get; }

    public extern string Type { [MethodImpl] get; }

    public extern string Subtype { [MethodImpl] set; [MethodImpl] get; }
  }
}
