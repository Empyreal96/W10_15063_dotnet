// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileTemplateType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TileTemplateType
  {
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Image = 0,
    [Deprecated("TileSquareImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Image.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareImage = 0,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Block = 1,
    [Deprecated("TileSquareBlock may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Block.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareBlock = 1,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Text01 = 2,
    [Deprecated("TileSquareText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareText01 = 2,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Text02 = 3,
    [Deprecated("TileSquareText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareText02 = 3,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Text03 = 4,
    [Deprecated("TileSquareText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareText03 = 4,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150Text04 = 5,
    [Deprecated("TileSquareText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquareText04 = 5,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150PeekImageAndText01 = 6,
    [Deprecated("TileSquarePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquarePeekImageAndText01 = 6,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150PeekImageAndText02 = 7,
    [Deprecated("TileSquarePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquarePeekImageAndText02 = 7,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150PeekImageAndText03 = 8,
    [Deprecated("TileSquarePeekImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquarePeekImageAndText03 = 8,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150PeekImageAndText04 = 9,
    [Deprecated("TileSquarePeekImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileSquarePeekImageAndText04 = 9,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Image = 10, // 0x0000000A
    [Deprecated("TileWideImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Image.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideImage = 10, // 0x0000000A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150ImageCollection = 11, // 0x0000000B
    [Deprecated("TileWideImageCollection may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageCollection.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideImageCollection = 11, // 0x0000000B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150ImageAndText01 = 12, // 0x0000000C
    [Deprecated("TileWideImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideImageAndText01 = 12, // 0x0000000C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150ImageAndText02 = 13, // 0x0000000D
    [Deprecated("TileWideImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideImageAndText02 = 13, // 0x0000000D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150BlockAndText01 = 14, // 0x0000000E
    [Deprecated("TileWideBlockAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideBlockAndText01 = 14, // 0x0000000E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150BlockAndText02 = 15, // 0x0000000F
    [Deprecated("TileWideBlockAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideBlockAndText02 = 15, // 0x0000000F
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection01 = 16, // 0x00000010
    [Deprecated("TileWidePeekImageCollection01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection01 = 16, // 0x00000010
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection02 = 17, // 0x00000011
    [Deprecated("TileWidePeekImageCollection02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection02 = 17, // 0x00000011
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection03 = 18, // 0x00000012
    [Deprecated("TileWidePeekImageCollection03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection03 = 18, // 0x00000012
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection04 = 19, // 0x00000013
    [Deprecated("TileWidePeekImageCollection04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection04 = 19, // 0x00000013
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection05 = 20, // 0x00000014
    [Deprecated("TileWidePeekImageCollection05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection05.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection05 = 20, // 0x00000014
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageCollection06 = 21, // 0x00000015
    [Deprecated("TileWidePeekImageCollection06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection06.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageCollection06 = 21, // 0x00000015
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageAndText01 = 22, // 0x00000016
    [Deprecated("TileWidePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageAndText01 = 22, // 0x00000016
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImageAndText02 = 23, // 0x00000017
    [Deprecated("TileWidePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImageAndText02 = 23, // 0x00000017
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage01 = 24, // 0x00000018
    [Deprecated("TileWidePeekImage01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage01 = 24, // 0x00000018
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage02 = 25, // 0x00000019
    [Deprecated("TileWidePeekImage02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage02 = 25, // 0x00000019
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage03 = 26, // 0x0000001A
    [Deprecated("TileWidePeekImage03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage03 = 26, // 0x0000001A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage04 = 27, // 0x0000001B
    [Deprecated("TileWidePeekImage04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage04 = 27, // 0x0000001B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage05 = 28, // 0x0000001C
    [Deprecated("TileWidePeekImage05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage05.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage05 = 28, // 0x0000001C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150PeekImage06 = 29, // 0x0000001D
    [Deprecated("TileWidePeekImage06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage06.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWidePeekImage06 = 29, // 0x0000001D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText01 = 30, // 0x0000001E
    [Deprecated("TileWideSmallImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText01 = 30, // 0x0000001E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText02 = 31, // 0x0000001F
    [Deprecated("TileWideSmallImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText02 = 31, // 0x0000001F
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText03 = 32, // 0x00000020
    [Deprecated("TileWideSmallImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText03 = 32, // 0x00000020
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText04 = 33, // 0x00000021
    [Deprecated("TileWideSmallImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText04 = 33, // 0x00000021
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150SmallImageAndText05 = 34, // 0x00000022
    [Deprecated("TileWideSmallImageAndText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText05.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideSmallImageAndText05 = 34, // 0x00000022
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text01 = 35, // 0x00000023
    [Deprecated("TileWideText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text01.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText01 = 35, // 0x00000023
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text02 = 36, // 0x00000024
    [Deprecated("TileWideText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text02.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText02 = 36, // 0x00000024
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text03 = 37, // 0x00000025
    [Deprecated("TileWideText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text03.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText03 = 37, // 0x00000025
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text04 = 38, // 0x00000026
    [Deprecated("TileWideText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text04.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText04 = 38, // 0x00000026
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text05 = 39, // 0x00000027
    [Deprecated("TileWideText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text05.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText05 = 39, // 0x00000027
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text06 = 40, // 0x00000028
    [Deprecated("TileWideText06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text06.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText06 = 40, // 0x00000028
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text07 = 41, // 0x00000029
    [Deprecated("TileWideText07 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text07.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText07 = 41, // 0x00000029
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text08 = 42, // 0x0000002A
    [Deprecated("TileWideText08 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text08.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText08 = 42, // 0x0000002A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text09 = 43, // 0x0000002B
    [Deprecated("TileWideText09 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text09.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText09 = 43, // 0x0000002B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text10 = 44, // 0x0000002C
    [Deprecated("TileWideText10 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText10 = 44, // 0x0000002C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150Text11 = 45, // 0x0000002D
    [Deprecated("TileWideText11 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text11.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] TileWideText11 = 45, // 0x0000002D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310BlockAndText01 = 46, // 0x0000002E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310BlockAndText02 = 47, // 0x0000002F
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Image = 48, // 0x00000030
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndText01 = 49, // 0x00000031
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndText02 = 50, // 0x00000032
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndTextOverlay01 = 51, // 0x00000033
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndTextOverlay02 = 52, // 0x00000034
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageAndTextOverlay03 = 53, // 0x00000035
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageCollectionAndText01 = 54, // 0x00000036
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageCollectionAndText02 = 55, // 0x00000037
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310ImageCollection = 56, // 0x00000038
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList01 = 57, // 0x00000039
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList02 = 58, // 0x0000003A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList03 = 59, // 0x0000003B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList04 = 60, // 0x0000003C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text01 = 61, // 0x0000003D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text02 = 62, // 0x0000003E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text03 = 63, // 0x0000003F
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text04 = 64, // 0x00000040
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text05 = 65, // 0x00000041
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text06 = 66, // 0x00000042
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text07 = 67, // 0x00000043
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text08 = 68, // 0x00000044
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310TextList01 = 69, // 0x00000045
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310TextList02 = 70, // 0x00000046
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310TextList03 = 71, // 0x00000047
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImageAndText01 = 72, // 0x00000048
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310SmallImagesAndTextList05 = 73, // 0x00000049
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare310x310Text09 = 74, // 0x0000004A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare71x71IconWithBadge = 75, // 0x0000004B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare150x150IconWithBadge = 76, // 0x0000004C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileWide310x150IconWithBadgeAndText = 77, // 0x0000004D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileSquare71x71Image = 78, // 0x0000004E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TileTall150x310Image = 79, // 0x0000004F
  }
}
