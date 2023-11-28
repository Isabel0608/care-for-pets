using System; 
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class OptionButton : MonoBehaviour
{
    private Text text = null;
    private Button button = null;
    private Image image = null;
    private Color ColorOriginal = Color.black;

    public Option Option { get; set; }

    private void Awake()
    {
        button = GetComponent<Button>(); 
        image = GetComponent<Image>();
        text = transform.GetChild(0).GetComponent<Text>();
        ColorOriginal = image.color;
    }

    public void Construct(Option option, Action<OptionButton> callback)
    {
        text.text = option.text; 
        button.enabled = true;
        Option = option;
        image.color = ColorOriginal;
        button.onClick.AddListener(delegate
        {
            callback(this);
        });
    }
    public void SetColor(Color c)
    {
        button.enabled = false;
        image.color = c;
    }
}
