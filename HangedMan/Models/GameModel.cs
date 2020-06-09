using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangedMan.Models
{
    public class GameModel
    {
        string Word;

        public string PropertyMaskedWord { get; private set; }

        public bool HasWon { get; private set; }

        public bool HasLost { get; private set; }

        public int NoOfTries { get; private set; }

        public GameModel(string Word)
        {
            this.Word = Word;
            MaskWord();
            NoOfTries = 8;
        }

        private void MaskWord()
        {
            string firstLetter = Word.Substring(0, 1);
            string rebuildedWord = firstLetter;

            for (int i = 1; i < Word.Length; i++)
            {
                if (firstLetter == Word[i].ToString())
                {
                    rebuildedWord = rebuildedWord + firstLetter;
                }
                else
                {
                    rebuildedWord = rebuildedWord + "*";
                }
            }
            PropertyMaskedWord = rebuildedWord;
        }

        public void RevealCharacter(char letter)
        {
            letter = char.ToLower(letter);

            List<int> IndexList = new List<int>();

            for (int i = 0; i < Word.Length; i++)
            {
                if (letter == Word[i])
                {
                    IndexList.Add(i);
                }
            }

            if (IndexList.Count == 0)
            {
                NoOfTries = NoOfTries - 1;
                CheckVictoryCondition();
                return;
            }

            char[] temporary = PropertyMaskedWord.ToCharArray();

            for (int i = 0; i < IndexList.Count; i++)
            {
                temporary[IndexList[i]] = letter;
            }

            PropertyMaskedWord = new string(temporary);
            CheckVictoryCondition();
        }

        public char GetFirstCharacter()
        {
            return Word[0];
        }
        private void CheckVictoryCondition()
        {
            if (PropertyMaskedWord.Contains("*") && NoOfTries != 0)
            {
                HasWon = false;
            }
            else if (NoOfTries == 0)
            {
                HasLost = true;
            }
            else
            {
                HasWon = true;
            }
        }

    }
}
