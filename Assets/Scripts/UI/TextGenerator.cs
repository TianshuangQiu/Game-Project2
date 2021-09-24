using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGenerator : MonoBehaviour
{

    public void AddWriter(Text uiText, string textToWrite, float timePerCharacter)
    {

    }
    
    public class SingleWriter {
        private Text uiText;
        private string textToWrite;
        private int characterIndex;
        private float timePerCharacter;
        private float timer;

        public SingleWriter(Text uiText, string textToWrite, float timePerCharacter)
        {
            this.uiText = uiText;
            this.textToWrite = textToWrite;
            this.timePerCharacter = timePerCharacter;
            characterIndex = 0;

        }

        // Update is called once per frame
        void Update()
        {
            if (uiText != null)
            {
                timer -= Time.deltaTime;
                while (timer <= 0f)
                {
                    // Display next character
                    timer += timePerCharacter;
                    characterIndex++;
                    string text = textToWrite.Substring(0, characterIndex);

                    text += "<color=#00000000>" + textToWrite.Substring(characterIndex) + "</color>";
                    uiText.text = text;
                    if (characterIndex >= textToWrite.Length)
                    {
                        // Entire string displayed
                        uiText = null;
                        return;
                    }
                    while (characterIndex <= textToWrite.Length && textToWrite[characterIndex] == ' ')
                    {
                        characterIndex++;
                    }
                }
            }
        }
    }

  
}
