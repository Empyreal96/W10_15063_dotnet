// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundTransfer.BtsPerfMarkerUtil
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Logging;

namespace Microsoft.Phone.BackgroundTransfer
{
  internal class BtsPerfMarkerUtil
  {
    public const string DownloadScenario = "DownloadScenario";
    public const string UploadScenario = "UploadScenario";
    public const string BackgroundTransferServiceRequestsApi = "BackgroundTransferService.Requests";
    public const string BackgroundTransferServiceFindApi = "BackgroundTransferService.Find";
    public const string BackgroundTransferServiceAddApi = "BackgroundTransferService.Add";
    public const string BackgroundTransferServiceRemoveApi = "BackgroundTransferService.Remove";

    internal static void LogApiStart(string apiName) => Logger.YLogEvent(2147483651U, 83U, LogFlags.Health | LogFlags.BeginMarker, apiName);

    internal static void LogApiEnd(string apiName) => Logger.YLogEvent(2147483651U, 83U, LogFlags.Health | LogFlags.EndMarker, apiName);

    internal static void LogScenarioStart(string scenarioName) => Logger.YLogEvent(2147483651U, 84U, LogFlags.Health | LogFlags.BeginMarker, scenarioName);

    internal static void LogScenarioEnd(string scenarioName) => Logger.YLogEvent(2147483651U, 84U, LogFlags.Health | LogFlags.EndMarker, scenarioName);
  }
}
