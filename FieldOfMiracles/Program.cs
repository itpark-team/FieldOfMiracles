using System;

namespace FieldOfMiracles
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;
            string hiddenWord;

            char[] guessWord;
            bool isGuessed=false;

            bool isGuessNow;

            bool isSymbolExist;

            char currentSybmol;

            Console.Write("Пожалуйста загадайте слово: ");
            hiddenWord = Console.ReadLine();

            Console.Write("Пожалуйста введите вопрос-подсказку: ");
            question = Console.ReadLine();


            guessWord = new char[hiddenWord.Length];
            for (int i = 0; i < guessWord.Length; i++)
            {
                guessWord[i] = '*';
            }

            do
            {
                Console.Clear();
                Console.WriteLine(question);
                Console.WriteLine(guessWord);

                do
                {
                    isSymbolExist = false;

                    Console.Write("Введите предполагаемую букву: ");
                    currentSybmol = (char)Console.Read();
                    Console.ReadLine();

                    for (int i = 0; i < guessWord.Length; i++)
                    {
                        if(currentSybmol==guessWord[i])
                        {
                            isSymbolExist = true;
                            break;
                        }
                    }

                    if(isSymbolExist)
                    {
                        Console.WriteLine("Данная буква уже отгадана, пожалуйста, введите другую");
                    }
                }
                while (isSymbolExist);

                isGuessNow = false;
                for (int i = 0; i < hiddenWord.Length; i++)
                {
                    if(hiddenWord[i]==currentSybmol)
                    {
                        guessWord[i] = currentSybmol;
                        isGuessNow = true;
                    }
                }
                if(isGuessNow)
                {
                    Console.WriteLine("Поздравляем, такакя буква есть в слове");
                }
                else
                {
                    Console.WriteLine("К сожалению, такой буквы в слове нет");
                }

                Console.WriteLine("Для продолжения нажмите Enter");
                Console.ReadKey();

                isGuessed = true;
                for (int i = 0; i < hiddenWord.Length; i++)
                {
                    if(hiddenWord[i]!=guessWord[i])
                    {
                        isGuessed = false;
                        break;
                    }
                }
            }
            while (!isGuessed);

            Console.Clear();
            Console.WriteLine(question);
            Console.WriteLine(guessWord);
            Console.WriteLine("Поздравляем вы отгадали слово!");
        }
    }
}
