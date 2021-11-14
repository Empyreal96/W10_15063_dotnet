// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.AvatarDescription
// Assembly: Microsoft.Xna.Framework.Avatar, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8518E295-C4D7-45FF-B025-9F2E181C471E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFB9E~1.DLL

using GamerServices.Platforms.Web;
using System;

namespace Microsoft.Xna.Framework.GamerServices
{
  public class AvatarDescription
  {
    internal const int DescriptionSize = 1021;
    private static AvatarDescription[] signedInGamerDescriptions = new AvatarDescription[4];
    internal object handleLock = new object();
    internal uint kernelHandle = uint.MaxValue;
    internal byte[] description;
    private float? height;
    private AvatarBodyType? bodyType;

    public bool IsValid => this.description != null && this.description.Length == 1021 && this.description[0] > (byte) 0;

    public byte[] Description
    {
      get
      {
        byte[] numArray = new byte[this.description.Length];
        Array.Copy((Array) this.description, (Array) numArray, this.description.Length);
        return numArray;
      }
    }

    public float Height
    {
      get
      {
        if (!this.height.HasValue)
        {
          float height = 0.0f;
          if (this.IsValid && SafeAvatarNativeMethods.AvatarDescription_GetHeight(this.kernelHandle, out height) != 0U)
            height = 0.0f;
          this.height = new float?(height);
        }
        return this.height.Value;
      }
    }

    public AvatarBodyType BodyType
    {
      get
      {
        if (!this.bodyType.HasValue)
        {
          AvatarBodyType avatarBodyType = AvatarBodyType.Female;
          if (this.IsValid)
          {
            int bodyTypeNum = 0;
            if (SafeAvatarNativeMethods.AvatarDescription_GetBodyType(this.kernelHandle, out bodyTypeNum) != 0U)
              bodyTypeNum = 0;
            if (bodyTypeNum == 1)
              avatarBodyType = AvatarBodyType.Male;
          }
          this.bodyType = new AvatarBodyType?(avatarBodyType);
        }
        return this.bodyType.Value;
      }
    }

    static AvatarDescription() => FrameworkCallbackLinker.AvatarChanged += new EventHandler(AvatarDescription.OnAvatarChanged);

    public static IAsyncResult BeginGetFromGamer(
      Gamer gamer,
      AsyncCallback callback,
      object state)
    {
      if (gamer == null)
        throw new ArgumentNullException(nameof (gamer));
      if (gamer.IsDisposed)
        throw new ObjectDisposedException(gamer.GetType().Name, FrameworkResources.ObjectDisposedException);
      return GamerServicesDispatcher.Gsp.QueueAsyncTask((LIVEnTask) new AvatarDescription.AsyncDescriptionReader(gamer.Gamertag, gamer is SignedInGamer ? 0 : -1), callback, state);
    }

    public static AvatarDescription EndGetFromGamer(IAsyncResult result)
    {
      byte[] data = new byte[1021];
      if (result == null)
        throw new ArgumentNullException(nameof (result));
      if (!(result is AvatarDescription.AsyncDescriptionReader descriptionReader))
        throw new ArgumentException(FrameworkResources.IAsyncNotFromBegin);
      descriptionReader.EndProcessWithCheck();
      byte[] descriptionData = descriptionReader.descriptionData;
      int playerIndex = descriptionReader.playerIndex;
      uint resultCode = descriptionReader.resultCode;
      uint descriptionHandle = descriptionReader.descriptionHandle;
      if (resultCode == 0U)
      {
        Array.Copy((Array) descriptionData, 0, (Array) data, 1, 1020);
        data[0] = (byte) 1;
      }
      else if (resultCode == 2147746306U)
        throw new ArgumentException(FrameworkResources.IAsyncNotFromBegin);
      if (playerIndex < 0 || playerIndex >= 4)
        return new AvatarDescription(descriptionHandle, data, false);
      if (AvatarDescription.signedInGamerDescriptions[playerIndex] == null)
        AvatarDescription.signedInGamerDescriptions[playerIndex] = new AvatarDescription(descriptionHandle, data, false);
      return AvatarDescription.signedInGamerDescriptions[playerIndex];
    }

    public AvatarDescription(byte[] data)
      : this(uint.MaxValue, data, true)
    {
      if (!this.IsValid)
        return;
      this.kernelHandle = uint.MaxValue;
      byte[] description = new byte[1020];
      Array.Copy((Array) this.description, 1, (Array) description, 0, 1020);
      int fromDescription = (int) SafeAvatarNativeMethods.AvatarDescription_CreateFromDescription(description, out this.kernelHandle);
    }

    internal AvatarDescription(uint kernelHandle, byte[] data, bool makeCopy)
    {
      if (data == null)
        throw new ArgumentNullException(nameof (data));
      if (data.Length != 1021)
        throw new ArgumentException(FrameworkResources.ResourceDataMustBeCorrectSize, nameof (data));
      if (makeCopy)
      {
        this.description = new byte[1021];
        Array.Copy((Array) data, (Array) this.description, 1021);
      }
      else
        this.description = data;
      this.kernelHandle = kernelHandle;
    }

    internal void AddRef()
    {
      lock (this.handleLock)
        ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarDescription_AddRef(this.kernelHandle));
    }

    internal void ReleaseHandle()
    {
      lock (this.handleLock)
      {
        if (this.kernelHandle == uint.MaxValue)
          return;
        int released;
        ErrorHandler.ThrowExceptionFromResult(SafeAvatarNativeMethods.AvatarDescription_ReleaseHandle(this.kernelHandle, out released));
        if (released == 0)
          return;
        this.kernelHandle = uint.MaxValue;
      }
    }

    ~AvatarDescription() => this.ReleaseHandle();

    public static AvatarDescription CreateRandom() => AvatarDescription.CreateRandom(-1);

    public static AvatarDescription CreateRandom(AvatarBodyType bodyType) => bodyType >= AvatarBodyType.Female && bodyType <= AvatarBodyType.Male ? AvatarDescription.CreateRandom((int) bodyType) : throw new ArgumentOutOfRangeException(nameof (bodyType));

    private static AvatarDescription CreateRandom(int bodyType)
    {
      byte[] data = new byte[1021];
      uint descriptionHandle = uint.MaxValue;
      byte[] description = new byte[1020];
      if (SafeAvatarNativeMethods.AvatarDescription_CreateRandom(bodyType, out descriptionHandle, description) == 0U)
      {
        Array.Copy((Array) description, 0, (Array) data, 1, 1020);
        data[0] = (byte) 1;
      }
      return new AvatarDescription(descriptionHandle, data, false);
    }

    public event EventHandler<EventArgs> Changed;

    private static void OnAvatarChanged(object sender, EventArgs args)
    {
      if (!(sender is SignedInGamer signedInGamer) || signedInGamer.PlayerIndex < PlayerIndex.One || signedInGamer.PlayerIndex > PlayerIndex.Four)
        return;
      EventHandler<EventArgs> changed = AvatarDescription.signedInGamerDescriptions[(int) signedInGamer.PlayerIndex].Changed;
      AvatarDescription.signedInGamerDescriptions[(int) signedInGamer.PlayerIndex] = (AvatarDescription) null;
      if (changed == null)
        return;
      changed(sender, args);
    }

    private class AsyncDescriptionReader : LIVEnTask
    {
      public int playerIndex;
      public uint resultCode;
      public uint descriptionHandle;
      public byte[] descriptionData;
      private string gamertag;

      public AsyncDescriptionReader(string gamertag, int playerIndex)
      {
        this.descriptionData = new byte[1020];
        this.gamertag = gamertag;
        this.playerIndex = playerIndex;
      }

      public override void Do() => this.GetDescription();

      private void GetDescription() => this.resultCode = SafeAvatarNativeMethods.AvatarDescription_CreateFromGamertag(this.gamertag, out this.descriptionHandle, this.descriptionData);
    }
  }
}
