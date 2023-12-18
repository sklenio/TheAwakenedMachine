using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  // OBS!! detta behövs för att vi ska få access till Nya Input Systemet i C# koden

public class Example2 : MonoBehaviour
{
    private CustomInputActionControl customAction; // Kommer ni ihåg namnet på skriptet som genererades åt oss ??

    // Start is called before the first frame update
    void Start()
    {
        // Vi måste här först skapa en "instans" av det skriptet för att skapa ett objekt av den
        customAction = new CustomInputActionControl();

        // Sedan måste vi "aktivera" detta
        customAction.Enable();

        // Här kommer sedan valfritt vad vi faktum VILL eller BEHÖVER lyssna på från det vi bundit via "bindings"

        // FÖrst måste vi aktivera actions
        customAction.Gameplay.Move.Enable();

        // Sedan binder vi en funktion som "lyssnar" (eng listener) på "händelsen" (eng events) started
        // NOTE: händelsen started motsvaras här av Input.GetKeyDown dvs utförs första/en gång
        customAction.Gameplay.Move.started += Move_started;

        // NOTE: händelsen performed motsvarar här av Input.GetKey dvs utförs så länge vi håller knappen nere
        // NOTE: händelsen cancled motsvarar här av Input.GetKeyUp dvs utförs när vi släpper tagenten i slutet
    }

    private void OnDestroy()
    {
        // Och när vi avslutar programmet eller skriptet blir inaktivt eller förstörs
        // måste vi alltid som grundregel sluta "lyssna" på "händelsen" started för att undvika s.k. memory leaks och att det blir error!
        customAction.Gameplay.Move.started -= Move_started;

        // Samt måste vi även disable detta
        customAction.Gameplay.Move.Disable();

        // och allra sist även disable customAction
        customAction.Disable();
    }

    private void Move_started(InputAction.CallbackContext obj)
    {
        Debug.Log("You have start to activate the action: Move");
        Debug.Log(obj.ReadValue<Vector2>());
    }

    void Update()
    {
        // Update behövs i princip inte längre MEN 
        // det finns såklart undantag för detta och vi kan även välja att fortsätta använda denna
        // för att läsa av från tagenttryckningar osv

        // Så här skulle man kunna läsa av direkt isåfall
        // Här har vi att vi läser av direkt från action "Move"
        // men vi gör detta flera gånger per sekund, vilket inte alltid
        // är optimalt, då är vi tillbaks på ruta ett som Example1 skriptet visar
        // customAction.Gameplay.Move.ReadValue<Vector2>();

    }
}
