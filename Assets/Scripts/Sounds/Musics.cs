using System.Collections.Generic;
using UnityEngine;
using Aurinaxtailer;
using TMPro;

public class Musics : MonoBehaviour
{
    [SerializeField] private List<AudioClip> playlist = new List<AudioClip>();
    [SerializeField] private TextMeshProUGUI musicName;
    private int listIndex;

    void Start()
    {
        if (playlist.Count == 0) return;
        listIndex = Random.Range(0, playlist.Count);
        AudioManager.Instance.PlayMusic(playlist[listIndex]);
        InitializeMusicName();
    }

    public void nextMusic(int valueIndex)
    {
        listIndex += valueIndex;
        if (listIndex >= playlist.Count)
            listIndex = 0;
        else if (listIndex < 0)
            listIndex = playlist.Count - 1;
        AudioManager.Instance.PlayMusic(playlist[listIndex]);
        InitializeMusicName();
    }

    private void InitializeMusicName()
    {
        musicName.text = playlist[listIndex].name;
    }
}
