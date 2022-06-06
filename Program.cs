using System;

namespace PW5
{
    internal class Program
    {
        /// <summary>
        /// Main - Split Words [Метод разделения строки на слова]
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)        {   

            Console.WriteLine("Введите предложение, которое необходимо разделить:");
            string line = Console.ReadLine();
            var arrayWords = SplitSentence(line);
            ShowArray(arrayWords);
            MixWords();
            Console.ReadKey();
        }
        /// <summary>
        /// Метод разделяющий предложение на слова по пробелу 
        /// </summary>
        /// <param name="line">Разделяемая строка</param>
        /// <returns>Возвращает массив из слов</returns>
        static string[] SplitSentence(string line)
        {
            return line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        /// <summary>
        /// Метод выводящий на экран массив из строк
        /// </summary>
        /// <param name="stringArray">Массив строк</param>
        static void ShowArray(string[] stringArray)
        {
            foreach (var word in stringArray)
            {
                Console.WriteLine(word);
            }
        }
        

        /// <summary>
        /// Mix Words [Перестановка слов в предложении]
        /// </summary>
        static void MixWords()
        {
            Console.WriteLine("Введите предложение, в котором будет перемешан порядок слов:");
            string line = Console.ReadLine();
            Console.WriteLine($"Ваше предложение в обратном порядке -> {ReverseWords(line)}");
        }
        static string ReverseWords(string inputPhrase)
        {
            var arrayPhrases = SplitSentence(inputPhrase);
            string result = "";
            for(int i = arrayPhrases.Length - 1; i >= 0; i--)
            {
                result += $"{arrayPhrases[i]} ";                
            }
            return result;
        }
        
        
    }
}
