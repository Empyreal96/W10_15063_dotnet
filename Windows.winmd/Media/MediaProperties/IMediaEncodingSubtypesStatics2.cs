// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingSubtypesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (MediaEncodingSubtypes))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1266471485, 17151, 19763, 133, 49, 6, 38, 190, 228, 181, 45)]
  internal interface IMediaEncodingSubtypesStatics2
  {
    string Vp9 { get; }

    string L8 { get; }

    string L16 { get; }

    string D16 { get; }
  }
}
