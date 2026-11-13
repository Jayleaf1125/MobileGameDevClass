using AYellowpaper.SerializedCollections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public SerializedDictionary<Sound, AudioClip> SoundDict = new SerializedDictionary<Sound, AudioClip>();
    public static SoundManager Instance;

    AudioSource[] _allAudioSources = new AudioSource[10];

    private void Awake()
    {
        Instance = this;
        _allAudioSources = GetComponents<AudioSource>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        switch (currentSceneIndex)
        {
            case 0:
                PlayBackgroundSound(Sound.Menu);
                break;
            case 1:
                PlayBackgroundSound(Sound.BackgroundOne);
                break;
            case 2:
                PlayBackgroundSound(Sound.Win);
                break;
            case 3:
                PlayBackgroundSound(Sound.BackgroundTwo);
                break;
            case 4:
                PlayBackgroundSound(Sound.Win);
                break;
            case 5:
                PlayBackgroundSound(Sound.BackgroundThree);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayBackgroundSound(Sound sound)
    {
        //AudioSource audioSource = GetComponent<AudioSource>();
        _allAudioSources[0].clip = SoundDict[sound];
        _allAudioSources[0].Play();
    }

    public void PlayUnquieSound(Sound sound)
    {
        _allAudioSources[1].clip = SoundDict[sound];
        _allAudioSources[1].PlayOneShot(SoundDict[sound]);
    }
}
