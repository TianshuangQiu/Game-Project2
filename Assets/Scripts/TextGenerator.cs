using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGenerator : MonoBehaviour
{

    // Reset file
    private List<SingleWriter> singleWriter;
    private void Awake()
    {
        singleWriter = new List<SingleWriter>();
    }
    public void AddWriter(Text uiText, string textToWrite, float timePerCharacter)
    {
        singleWriter.Add(new SingleWriter(uiText, textToWrite, timePerCharacter));

    }

    private void Update()
    {
        for (int i = 0; i < singleWriter.Count; i++)
        {
            bool destroyInstance = singleWriter[i].Update();
            if (destroyInstance)
            {
                singleWriter.RemoveAt(i);
                i--;
            }
        }
    }

    public class SingleWriter
    {
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

        // Returns true when there are no more characters in the String
        public bool Update()
        {
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                // Display next character
                timer += timePerCharacter;
                if (characterIndex <= textToWrite.Length - 1)
                {
                    characterIndex++;
                    while (characterIndex < textToWrite.Length && textToWrite[characterIndex] == ' ')
                    {
                        characterIndex++;
                        if (characterIndex >= textToWrite.Length - 1)
                        {
                            break;
                        }
                    }
                    string text = textToWrite.Substring(0, characterIndex);

                    text += "<color=#00000000>" + textToWrite.Substring(characterIndex) + "</color>";
                    uiText.text = text;
                } else
                {
                    uiText = null;
                    return true;
                }
            }
            return false;

        }
    }


}
