// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.XlastConfiguration
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class XlastConfiguration
  {
    public Dictionary<string, int> Achievements;
    public Dictionary<string, int> GamerPictures;
    public Dictionary<string, int> AvatarAssets;
    public Dictionary<string, int> GameModes;
    public Dictionary<string, int> PresenceModes;
    public Dictionary<string, XlastProperty> PresenceProperties;
    public Dictionary<string, XlastLeaderboard> Leaderboards;
    private const string gameAssembly = "game.exe";
    private const string resourceName = "Microsoft.Xna.Framework.XlastConfiguration";
    private static XlastConfiguration instance;
    private static string GameAssemblyPath;

    public static XlastConfiguration Instance
    {
      get
      {
        if (XlastConfiguration.instance == null)
        {
          try
          {
            XlastConfiguration.instance = XlastConfiguration.LoadEmbeddedResource();
          }
          catch
          {
          }
        }
        return XlastConfiguration.instance;
      }
    }

    [SecuritySafeCritical]
    internal static void CacheGameAssemblyPath() => XlastConfiguration.GameAssemblyPath = Path.Combine(new HostInfo().AppInstallFolder, Deployment.Current.EntryPointAssembly + ".dll");

    [SecuritySafeCritical]
    private static XlastConfiguration LoadEmbeddedResource()
    {
      Stream manifestResourceStream = Assembly.Load(Deployment.Current.EntryPointAssembly).GetManifestResourceStream("Microsoft.Xna.Framework.XlastConfiguration");
      XlastConfiguration xlastConfiguration = (XlastConfiguration) null;
      if (manifestResourceStream != null)
        xlastConfiguration = new XlastReader().Read(manifestResourceStream);
      return xlastConfiguration;
    }

    public static TKey GetKeyForValue<TKey, TValue>(
      Dictionary<TKey, TValue> dictionary,
      TValue value)
      where TValue : IEquatable<TValue>
    {
      foreach (KeyValuePair<TKey, TValue> keyValuePair in dictionary)
      {
        if (keyValuePair.Value.Equals(value))
          return keyValuePair.Key;
      }
      return default (TKey);
    }
  }
}
