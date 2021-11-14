// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattProtocolErrorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3393635781, 3788, 18441, 190, 163, 207, 121, 188, 153, 30, 55)]
  [ExclusiveTo(typeof (GattProtocolError))]
  internal interface IGattProtocolErrorStatics
  {
    byte InvalidHandle { get; }

    byte ReadNotPermitted { get; }

    byte WriteNotPermitted { get; }

    byte InvalidPdu { get; }

    byte InsufficientAuthentication { get; }

    byte RequestNotSupported { get; }

    byte InvalidOffset { get; }

    byte InsufficientAuthorization { get; }

    byte PrepareQueueFull { get; }

    byte AttributeNotFound { get; }

    byte AttributeNotLong { get; }

    byte InsufficientEncryptionKeySize { get; }

    byte InvalidAttributeValueLength { get; }

    byte UnlikelyError { get; }

    byte InsufficientEncryption { get; }

    byte UnsupportedGroupType { get; }

    byte InsufficientResources { get; }
  }
}
