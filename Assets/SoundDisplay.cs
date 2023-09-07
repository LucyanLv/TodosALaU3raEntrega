using UnityEngine;
using UnityEngine.UI;

public class SoundDisplay : MonoBehaviour
{
    public Sprite soundOnSprite;
    public Sprite soundOffSprite;
    public Image soundImage;

    private bool isSoundEnabled = true;

    private void Start()
    {
        UpdateSoundDisplay();
    }

    public void ToggleSound()
    {
        isSoundEnabled = !isSoundEnabled;
        UpdateSoundDisplay();
        AudioListener.pause = !isSoundEnabled;
    }

    private void UpdateSoundDisplay()
    {
        soundImage.sprite = isSoundEnabled ? soundOnSprite : soundOffSprite;
    }
}
