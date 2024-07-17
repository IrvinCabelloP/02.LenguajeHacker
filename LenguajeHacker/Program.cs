using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribe un programa que reciba un texto y transforme lenguaje natural a
 * "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
 *  se caracteriza por sustituir caracteres alfanuméricos.
 * - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
 *   con el alfabeto y los números en "leet".
 *   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
 */

namespace LenguajeHacker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que recibe un texto en lenguaje natural y lo transforma a 'lenguaje hacker'.");
            Console.WriteLine("Ingresa el texto a cifrar a lenguaje hacker:");
            string textoOriginal = Console.ReadLine();
            TraducirALenguajeHacker(textoOriginal);
        }

        static void TraducirALenguajeHacker(string textoOriginal)
        {
            Dictionary<char, List<string>> lenguajeHacker = new Dictionary<char, List<string>>
        {
            { 'a', new List<string> { "4", "/\\", "@", "/-\\", "^", "aye", "(L", "Д" } },
            { 'b', new List<string> { "I3", "8", "13", "|3", "ß", "!3", "(3", "/3", ")3", "|-]", "j3", "6" } },
            { 'c', new List<string> { "[", "¢", "{", "<" } },
            { 'd', new List<string> { ")", "|)", "(|", "[)", "I>", "|>", "?", "T)", "I7", "cl", "|}", ">", "|]", "(", "©" } },
            { 'e', new List<string> { "3", "&", "£", "€", "ë", "[-", "|=-" } },
            { 'f', new List<string> { "|=", "ƒ", "|#", "ph", "/=", "v" } },
            { 'g', new List<string> { "&", "6", "(_+", "9", "C-", "gee", "(?,", "[,", "{,", "<-", "(." } },
            { 'h', new List<string> { "#", "/-/", "[-]", "]-[", ")-(", "(-)", ":-:", "|~|", "|-|", "]~[", "}{", "!-!", "1-1", "\\-/", "I+I", "/-\\" } },
            { 'i', new List<string> { "1", "[]", "|", "!", "eye", "3y3", "][" } },
            { 'j', new List<string> { ",_|", "_|", "._|", "._]", "_]", ",_]", "]", ";", "1" } },
            { 'k', new List<string> { ">|", "|<", "/<", "1<", "|c", "|(", "|{" } },
            { 'l', new List<string> { "1", "£", "7", "|_", "|" } },
            { 'm', new List<string> { "/\\/\\", "/V\\", "JVI", "[V]", "[]V[]", "|\\/|", "^^", "<\\/>", "{V}", "(v)", "(V)", "|V|", "nn", "IVI", "|\\|\\", "]\\/[" } },
            { 'n', new List<string> { "^/", "|\\|", "/\\/", "[\\]", "<\\>", "{\\}", "|V", "/V", "И", "^", "ท" } },
            { 'ñ', new List<string> { "¿?", "==?" } },
            { 'o', new List<string> { "0", "Q", "()", "oh", "[]", "p", "<>", "Ø" } },
            { 'p', new List<string> { "|*", "|o", "|º", "?", "|^", "|>", "|\"", "9", "[]D", "|°", "|7" } },
            { 'q', new List<string> { "(_)", "9", "()_", "2", "0_", "<|", "&" } },
            { 'r', new List<string> { "I2", "|`", "|~", "|?", "/2", "|^", "lz", "|9", "2", "12", "®", "[z", "Я", ".-", "|2", "|-" } },
            { 's', new List<string> { "5", "$", "z", "§", "ehs", "es", "2" } },
            { 't', new List<string> { "7", "+", "-|-", "']['", "†", "\"|\"", "~|~" } },
            { 'u', new List<string> { "(_)", "|_|", "v", "L|", "µ", "บ" } },
            { 'v', new List<string> { "\\/", "|/", "\\|" } },
            { 'w', new List<string> { "\\/\\/", "VV", "\\N", "'//", "\\\\'", "\\^/", "(n)", "\\V/", "\\X/", "\\|/", "\\_|_/", "\\_:_/", "Ш", "Щ", "uu", "2u", "\\\\//\\\\//", "พ", "v²" } },
            { 'x', new List<string> { "><", "Ж", "}{", "ecks", "×", "?", ")(", "][" } },
            { 'y', new List<string> { "j", "`/", "Ч", "7", "\\|/", "¥", "\\//" } },
            { 'z', new List<string> { "2", "7_", "-/_", "%", ">_", "s", "~/_", "-\\_", "-|_" } }
        };

            try
            {
                // Convertimos el texto a minúsculas para una comparación uniforme
                textoOriginal = textoOriginal.ToLower();

                // Usamos un StringBuilder para construir la cadena traducida eficientemente
                var traduccion = new System.Text.StringBuilder();

                // Creamos una instancia de Random para la selección aleatoria
                Random random = new Random();

                // Traducimos el texto usando el mapeo y seleccionando aleatoriamente las sustituciones
                foreach (char c in textoOriginal)
                {
                    if (lenguajeHacker.ContainsKey(c))
                    {
                        List<string> opciones = lenguajeHacker[c];
                        string sustitucion = opciones[random.Next(opciones.Count)];
                        traduccion.Append(sustitucion);
                    }
                    else
                    {
                        traduccion.Append(c);
                    }
                }
                Console.WriteLine("El texto traducido es: "+traduccion);
                Console.ReadLine();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message); 
            }
        }
    }
}
