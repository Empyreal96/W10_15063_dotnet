// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ActivationKind
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ActivationKind
  {
    Launch = 0,
    Search = 1,
    ShareTarget = 2,
    File = 3,
    Protocol = 4,
    FileOpenPicker = 5,
    FileSavePicker = 6,
    CachedFileUpdater = 7,
    ContactPicker = 8,
    Device = 9,
    PrintTaskSettings = 10, // 0x0000000A
    CameraSettings = 11, // 0x0000000B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] RestrictedLaunch = 12, // 0x0000000C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] AppointmentsProvider = 13, // 0x0000000D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Contact = 14, // 0x0000000E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] LockScreenCall = 15, // 0x0000000F
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] VoiceCommand = 16, // 0x00000010
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] LockScreen = 17, // 0x00000011
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PickerReturned = 1000, // 0x000003E8
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WalletAction = 1001, // 0x000003E9
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PickFileContinuation = 1002, // 0x000003EA
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PickSaveFileContinuation = 1003, // 0x000003EB
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PickFolderContinuation = 1004, // 0x000003EC
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WebAuthenticationBrokerContinuation = 1005, // 0x000003ED
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] WebAccountProvider = 1006, // 0x000003EE
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ComponentUI = 1007, // 0x000003EF
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ProtocolForResults = 1009, // 0x000003F1
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ToastNotification = 1010, // 0x000003F2
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] Print3DWorkflow = 1011, // 0x000003F3
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DialReceiver = 1012, // 0x000003F4
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] DevicePairing = 1013, // 0x000003F5
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] UserDataAccountsProvider = 1014, // 0x000003F6
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] FilePickerExperience = 1015, // 0x000003F7
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] LockScreenComponent = 1016, // 0x000003F8
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] ContactPanel = 1017, // 0x000003F9
  }
}
