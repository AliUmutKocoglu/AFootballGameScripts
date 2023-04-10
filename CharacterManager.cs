using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public CharacterDataBase characterDB;
    public Text nameText;
    public SpriteRenderer teampicSprite;
    public GameObject nextButton;
    public GameObject backButton;
    public GameObject selectYourTameTxt;
    public GameObject playButton;
    public GameObject teamName;
    public GameObject skipButton;
    private int selectedOption = 0;
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption= 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
    }
    public void NextOption()
    {
        selectedOption++;
        if(selectedOption>=characterDB.CharacterCount)
        {
            selectedOption= 0;
        }
        UpdateCharacter(selectedOption);
        Save();
    }
    public void BackOption() 
    { 
        selectedOption--; 
        if(selectedOption<0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
        Save();
    }
    private void UpdateCharacter(int selectedOption)
    {
        Characters character = characterDB.GetCharacters(selectedOption);
        teampicSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }
    public void ChangeScene(int sceneId)
    {
        nextButton.SetActive(false);
        backButton.SetActive(false);
        playButton.SetActive(false);
        selectYourTameTxt.SetActive(false);
        teamName.SetActive(false);
        skipButton.SetActive(true);
        if (selectedOption == 0)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Adanaspor\\AdanademirCinematic.mp4";          
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0,0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(96f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 1)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Konyaspor\\KonyasporCinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(28f);
                SceneManager.LoadScene(1);
            }
        }
    
        else if (selectedOption == 2)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Hatayspor\\Hatayspor Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(61f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 3)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Beþiktaþ\\Beþiktaþ Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(44f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 4)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Giresunspor\\Giresunspor Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(72f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 5)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Alanyaspor\\Alanyaspor Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(40.6f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 6)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Sivasspor\\Sivasspor Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(40f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 7)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Fenerbahçe\\Fenerbahce Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(58f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 8)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Antalyaspor\\Antalyaspor Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(45.6f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 9)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Galatasaray\\Galatasaray Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(53.6f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 10)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Gaziantep\\Gaziantep Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(52f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 11)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Istanbulspor\\Istanbulspor Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(38f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 12)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Kasimpasa\\Kasimpasa Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(33f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 13)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Basaksehir\\Basaksehir Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(49f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 14)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Ankaragucu\\Ankaragucu Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(46f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 15)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Trabzonspor\\Trabzonspor Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(57f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 16)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Karagumruk\\Karagumruk Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(39f);
                SceneManager.LoadScene(1);
            }
        }
        else if (selectedOption == 17)
        {
            GameObject camera = GameObject.Find("Main Camera");

            var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.playOnAwake = false;
            videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
            videoPlayer.targetCameraAlpha = 1F;
            videoPlayer.frame = 100;
            videoPlayer.url = "C:\\UnityMyGames\\Footbal Game\\Football Game\\Assets\\Textures\\Kayserispor\\Kayserispor Cinematic.mp4";
            videoPlayer.Play();
            videoPlayer.SetDirectAudioVolume(0, 0.3F);

            StartCoroutine(Baslangic());
            IEnumerator Baslangic()
            {
                yield return new WaitForSeconds(31f);
                SceneManager.LoadScene(1);
            }
        }
    }
    public void QuickChangeScene(int sceneId)
    {
        SceneManager.LoadScene(1);
    }
}
