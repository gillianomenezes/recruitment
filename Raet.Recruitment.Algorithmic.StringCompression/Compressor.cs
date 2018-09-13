using System;

namespace Raet.Recruitment.Algorithmic.StringCompression
{
    public class Compressor
    {
        public string Compress(string input)
        {
            if (String.IsNullOrEmpty(input))
                return string.Empty;

            bool isCompressible = false;
            string compressedStr = "";
            char currentCharacter = input[0];
            int characterCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (currentCharacter == input[i] && characterCounter < 10 )
                {
                    characterCounter++;

                    if (i < (input.Length-1))
                        continue;
                }

                if (characterCounter > 2)
                    isCompressible = true;

                compressedStr += String.Format("{0}{1}", currentCharacter, (characterCounter % 10));
                currentCharacter = input[i];
                characterCounter = 1;
            }

            if (isCompressible)
                return compressedStr;
            else
                return input;
        }
    }
}
