// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingPropertiesWithFormatUserData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2565934457, 5098, 18943, 190, 112, 38, 115, 219, 105, 112, 44)]
  internal interface IAudioEncodingPropertiesWithFormatUserData
  {
    void SetFormatUserData(byte[] value);

    void GetFormatUserData(out byte[] value);
  }
}
