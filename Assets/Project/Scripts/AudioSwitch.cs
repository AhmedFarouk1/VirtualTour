using UnityEngine;

public class AudioSwitch : MonoBehaviour
{

    ///<summary> this script used to turn sound on/off
    private bool muted = false;


    void Start()
    {

        if (PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }

        else
        {
            Load();
        }

    }

    public void OnButtonPress()  // when press on the sound button
    {

        muted = !muted;
        AudioListener.pause = muted;

        Save();
    }


    private void Load()  // load sound status from PlayerPrefs
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save() // save sound status in PlayerPrefs
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
