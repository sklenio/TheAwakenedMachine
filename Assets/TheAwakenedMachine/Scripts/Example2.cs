using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  // OBS!! detta beh�vs f�r att vi ska f� access till Nya Input Systemet i C# koden

public class Example2 : MonoBehaviour
{
    private CustomInputActionControl customAction; // Kommer ni ih�g namnet p� skriptet som genererades �t oss ??

    // Start is called before the first frame update
    void Start()
    {
        // Vi m�ste h�r f�rst skapa en "instans" av det skriptet f�r att skapa ett objekt av den
        customAction = new CustomInputActionControl();

        // Sedan m�ste vi "aktivera" detta
        customAction.Enable();

        // H�r kommer sedan valfritt vad vi faktum VILL eller BEH�VER lyssna p� fr�n det vi bundit via "bindings"

        // F�rst m�ste vi aktivera actions
        customAction.Gameplay.Move.Enable();

        // Sedan binder vi en funktion som "lyssnar" (eng listener) p� "h�ndelsen" (eng events) started
        // NOTE: h�ndelsen started motsvaras h�r av Input.GetKeyDown dvs utf�rs f�rsta/en g�ng
        customAction.Gameplay.Move.started += Move_started;

        // NOTE: h�ndelsen performed motsvarar h�r av Input.GetKey dvs utf�rs s� l�nge vi h�ller knappen nere
        // NOTE: h�ndelsen cancled motsvarar h�r av Input.GetKeyUp dvs utf�rs n�r vi sl�pper tagenten i slutet
    }

    private void OnDestroy()
    {
        // Och n�r vi avslutar programmet eller skriptet blir inaktivt eller f�rst�rs
        // m�ste vi alltid som grundregel sluta "lyssna" p� "h�ndelsen" started f�r att undvika s.k. memory leaks och att det blir error!
        customAction.Gameplay.Move.started -= Move_started;

        // Samt m�ste vi �ven disable detta
        customAction.Gameplay.Move.Disable();

        // och allra sist �ven disable customAction
        customAction.Disable();
    }

    private void Move_started(InputAction.CallbackContext obj)
    {
        Debug.Log("You have start to activate the action: Move");
        Debug.Log(obj.ReadValue<Vector2>());
    }

    void Update()
    {
        // Update beh�vs i princip inte l�ngre MEN 
        // det finns s�klart undantag f�r detta och vi kan �ven v�lja att forts�tta anv�nda denna
        // f�r att l�sa av fr�n tagenttryckningar osv

        // S� h�r skulle man kunna l�sa av direkt is�fall
        // H�r har vi att vi l�ser av direkt fr�n action "Move"
        // men vi g�r detta flera g�nger per sekund, vilket inte alltid
        // �r optimalt, d� �r vi tillbaks p� ruta ett som Example1 skriptet visar
        // customAction.Gameplay.Move.ReadValue<Vector2>();

    }
}
