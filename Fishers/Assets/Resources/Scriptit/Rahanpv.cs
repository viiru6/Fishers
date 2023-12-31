using TMPro;
using UnityEngine;

public class Rahanpv : MonoBehaviour
{
    private int raha;
    public TextMeshProUGUI rahaTeksti;

    void Start()
    {
        raha = 110; // Alustetaan rahaesimerkki100:lla.
        PäivitäRahaTeksti();
    }

    public void LisääRahaa(int määrä)
    {
        raha += määrä;
        PäivitäRahaTeksti();
    }

    public bool VähennäRahaa(int määrä)
    {
        if (raha - määrä >= 0)
        {
            raha -= määrä;
            PäivitäRahaTeksti();
            return true;
        }
        else
        {
            Debug.Log("Ei ole tarpeeksi rahaa!");
            return false;
        }
    }

    void PäivitäRahaTeksti()
    {
        if (rahaTeksti != null)
        {
            rahaTeksti.text = "" + raha;
        }
    }
}