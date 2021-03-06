﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class cl_VolumeManager
{

    public static int GetDeviceMinVolume()
    {
        int streammusic = 3;
        return deviceAudio.Call<int>("getStreamMinVolume", streammusic);
    }

    public static int GetDeviceMaxVolume()
    {
        int streammusic = 3;
        return deviceAudio.Call<int>("getStreamMaxVolume", streammusic);
    }

    public static int GetDeviceVolume()
    {
        int streammusic = 3;
        return deviceAudio.Call<int>("getStreamVolume", streammusic);
    }

    private static AndroidJavaObject audioManager;

    private static AndroidJavaObject deviceAudio
    {
        get
        {
            if (audioManager == null)
            {
                AndroidJavaClass up = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject context = up.GetStatic<AndroidJavaObject>("currentActivity");

                audioManager = context.Call<AndroidJavaObject>("getSystemService", "audio");
            }
            return audioManager;
        }
    }
}
