using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsController : MonoBehaviour
{
    public Stats Stats;
    public GameObject statsPanel;
    bool statsPanelActive;
    void Update()
    {
        if (statsPanel.active) { DisplayStats(); }//jos stats paneeli on auki sen tiedot päivitetään

        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            if (statsPanelActive)
            {
                statsPanel.SetActive(false);
                statsPanelActive = false;
            }
            else
            {
                statsPanel.SetActive(true);
                statsPanelActive = true;
            }
        }
    }
    public void DisplayStats()//päivittää statsPaneelin tiedot
    {
        GameObject KalojaKerättyHarmaa = GameObject.Find("KalojaKerättyHarmaa");
        KalojaKerättyHarmaa.GetComponent<TextMeshProUGUI>().text = "<color=#D9D9D9>Harmaita</color> kaloja kalastettu: " + Stats.KalojaKerättyHarmaa.ToString();
        GameObject KalojaKerättyVihreä = GameObject.Find("KalojaKerättyVihreä");
        KalojaKerättyVihreä.GetComponent<TextMeshProUGUI>().text = "<color=#00FF00>Vihreitä</color> kaloja kalastettu: " + Stats.KalojaKerättyVihreä.ToString();
        GameObject KalojaKerättySininen = GameObject.Find("KalojaKerättySininen");
        KalojaKerättySininen.GetComponent<TextMeshProUGUI>().text = "<color=#0000FF>Sinisiä</color>  kaloja kalastettu: " + Stats.KalojaKerättySininen.ToString();
        GameObject KalojaKerättyLiila = GameObject.Find("KalojaKerättyLiila");
        KalojaKerättyLiila.GetComponent<TextMeshProUGUI>().text = "<color=#FF00FF>Liiloja</color>  kaloja kalastettu: " + Stats.KalojaKerättyLiila.ToString();
        GameObject KalojaKerättyPunainen = GameObject.Find("KalojaKerättyPunainen");
        KalojaKerättyPunainen.GetComponent<TextMeshProUGUI>().text = "<color=#FF0000>Punaisia</color>  kaloja kalastettu: " + Stats.KalojaKerättyPunainen.ToString();

        GameObject KalojaKerättyYhteensä = GameObject.Find("KalojaKerättyYhteensä");
        KalojaKerättyYhteensä.GetComponent<TextMeshProUGUI>().text = "<color=#9C9CF5>Kaloja</color> Kerätty Yhteensä: " + Stats.KalojaKerättyYhteensä.ToString();

        GameObject KerratKalastettu = GameObject.Find("KerratKalastettu");
        KerratKalastettu.GetComponent<TextMeshProUGUI>().text = "Kerrat Kalastettu: " + Stats.KerratKalastettu.ToString();

        GameObject RahaaTienattuYhteensä = GameObject.Find("RahaaTienattuYhteensä");
        RahaaTienattuYhteensä.GetComponent<TextMeshProUGUI>().text = "Rahaa Tienattu Yhteensä: " + "<color=#FFEB04>" + Stats.RahaaTienattuYhteensä.ToString() + " kultaa</color>";

        GameObject KerratMyyty = GameObject.Find("KerratMyyty");
        KerratMyyty.GetComponent<TextMeshProUGUI>().text = "Kerrat Myyty: " + Stats.KerratMyyty.ToString();

        GameObject AikaPelattuTunnit = GameObject.Find("AikaPelattuTunnit");
        AikaPelattuTunnit.GetComponent<TextMeshProUGUI>().text = "Pelattu: " + Stats.AikaPelattuTunnit.ToString().Substring(0, 4) + " tuntia";

        GameObject peliLadattuKerrat = GameObject.Find("peliLadattuKerrat");
        peliLadattuKerrat.GetComponent<TextMeshProUGUI>().text = "Peli Avattu: " + Stats.kerratPeliAvattu.ToString() + " kertaa";

        GameObject KerratKauppaAvattu = GameObject.Find("KerratKauppaAvattu");
        KerratKauppaAvattu.GetComponent<TextMeshProUGUI>().text = "Kaupassa Vierailtu: " + Stats.KerratKauppaAvattu.ToString() + " kertaa";

        // harmaa = D9D9D9
        // vihreä = 00FF00
        // sininen = 0000FF
        // liila = FF00FF
        // punainen = FF0000
        // kaikki = 63F7FF

        // kulta = FFEB04  
    }
}
