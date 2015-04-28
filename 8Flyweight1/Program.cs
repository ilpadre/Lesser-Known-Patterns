using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Flyweight2
{
    class MainApp
    {
        static int numberOfAllocations = 0;

        static void Main()
        {
            var characters = new ArrayList();

            var fileName = "input.txt";
            var document = string.Empty;
            using (StreamReader sr = new StreamReader(fileName))
            {
                document = sr.ReadToEnd();
            }
            char[] chars = document.ToCharArray();


            // extrinsic state
            int pointSize = 10;
            foreach (var c in chars)
            {
                var character = GetCharacter(c);
                characters.Add(character);
            }

            foreach (var c in characters)
            {
                pointSize++;
                var ch = (Character) c;
                if (ch == null) continue;
                ch.Display(pointSize);
            }
            Console.WriteLine();
            Console.WriteLine("Number of object allocations: {0}", numberOfAllocations);
            Console.ReadKey();
        }

        public static Character GetCharacter(char key)
        {
            Character character = null;
            switch (key)
            {
                case 'A': character = new CharacterA(); break;
                case 'B': character = new CharacterB(); break;
                case 'C': character = new CharacterC(); break;
                case 'D': character = new CharacterD(); break;
                case 'E': character = new CharacterE(); break;
                case 'F': character = new CharacterF(); break;
                case 'G': character = new CharacterG(); break;
                case 'H': character = new CharacterH(); break;
                case 'I': character = new CharacterI(); break;
                case 'J': character = new CharacterJ(); break;
                case 'K': character = new CharacterK(); break;
                case 'L': character = new CharacterL(); break;
                case 'M': character = new CharacterM(); break;
                case 'N': character = new CharacterN(); break;
                case 'O': character = new CharacterO(); break;
                case 'P': character = new CharacterP(); break;
                case 'Q': character = new CharacterQ(); break;
                case 'R': character = new CharacterR(); break;
                case 'S': character = new CharacterS(); break;
                case 'T': character = new CharacterT(); break;
                case 'U': character = new CharacterU(); break;
                case 'V': character = new CharacterV(); break;
                case 'W': character = new CharacterW(); break;
                case 'X': character = new CharacterX(); break;
                case 'Y': character = new CharacterY(); break;
                case 'Z': character = new CharacterZ(); break;
                case 'a': character = new Charactera(); break;
                case 'b': character = new Characterb(); break;
                case 'c': character = new Characterc(); break;
                case 'd': character = new Characterd(); break;
                case 'e': character = new Charactere(); break;
                case 'f': character = new Characterf(); break;
                case 'g': character = new Characterg(); break;
                case 'h': character = new Characterh(); break;
                case 'i': character = new Characteri(); break;
                case 'j': character = new Characterj(); break;
                case 'k': character = new Characterk(); break;
                case 'l': character = new Characterl(); break;
                case 'm': character = new Characterm(); break;
                case 'n': character = new Charactern(); break;
                case 'o': character = new Charactero(); break;
                case 'p': character = new Characterp(); break;
                case 'q': character = new Characterq(); break;
                case 'r': character = new Characterr(); break;
                case 's': character = new Characters(); break;
                case 't': character = new Charactert(); break;
                case 'u': character = new Characteru(); break;
                case 'v': character = new Characterv(); break;
                case 'w': character = new Characterw(); break;
                case 'x': character = new Characterx(); break;
                case 'y': character = new Charactery(); break;
                case 'z': character = new Characterz(); break;
                case '0': character = new Character0(); break;
                case '1': character = new Character1(); break;
                case '2': character = new Character2(); break;
                case '3': character = new Character3(); break;
                case '4': character = new Character4(); break;
                case '5': character = new Character5(); break;
                case '6': character = new Character6(); break;
                case '7': character = new Character7(); break;
                case '8': character = new Character8(); break;
                case '9': character = new Character9(); break;
                case '.': character = new CharacterPeriod(); break;
                case ',': character = new CharacterComma(); break;
                case '?': character = new CharacterQuestionMark(); break;
                case '\'': character = new CharacterApostrophe(); break;
                case '"': character = new CharacterQuote(); break;
                case ' ': character = new CharacterSpace(); break;
                case ':': character = new CharacterColon(); break;
                case ';': character = new CharacterSemiColon(); break;
                case '[': character = new CharacterLeftBracket(); break;
                case ']': character = new CharacterRightBracket(); break;
                case '-': character = new CharacterDash(); break;
            }
            numberOfAllocations++;

            return character;
        }

    }

    abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize;

        public virtual void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
              " (pointsize " + this.pointSize + ")");
        }
    }

    #region Upper Case Letters
    class CharacterA : Character
    {
        // Constructor
        public CharacterA()
        {
            this.symbol = 'A';
            this.height = 100;
            this.width = 120;
            this.ascent = 70;
            this.descent = 0;
        }
    }

    class CharacterB : Character
    {
        public CharacterB()
        {
            this.symbol = 'B';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }



    class CharacterC : Character
    {
        public CharacterC()
        {
            this.symbol = 'C';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterD : Character
    {
        public CharacterD()
        {
            this.symbol = 'D';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterE : Character
    {
        public CharacterE()
        {
            this.symbol = 'E';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterF : Character
    {
        public CharacterF()
        {
            this.symbol = 'F';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterG : Character
    {
        public CharacterG()
        {
            this.symbol = 'G';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterH : Character
    {
        public CharacterH()
        {
            this.symbol = 'H';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterI : Character
    {
        public CharacterI()
        {
            this.symbol = 'I';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterJ : Character
    {
        public CharacterJ()
        {
            this.symbol = 'J';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterK : Character
    {
        public CharacterK()
        {
            this.symbol = 'K';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterL : Character
    {
        public CharacterL()
        {
            this.symbol = 'L';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterM : Character
    {
        public CharacterM()
        {
            this.symbol = 'M';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterN : Character
    {
        public CharacterN()
        {
            this.symbol = 'N';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterO : Character
    {
        public CharacterO()
        {
            this.symbol = 'O';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterP : Character
    {
        public CharacterP()
        {
            this.symbol = 'P';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterQ : Character
    {
        public CharacterQ()
        {
            this.symbol = 'Q';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterR : Character
    {
        public CharacterR()
        {
            this.symbol = 'R';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterS : Character
    {
        public CharacterS()
        {
            this.symbol = 'S';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterT : Character
    {
        public CharacterT()
        {
            this.symbol = 'T';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterU : Character
    {
        public CharacterU()
        {
            this.symbol = 'U';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterV : Character
    {
        public CharacterV()
        {
            this.symbol = 'V';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterW : Character
    {
        public CharacterW()
        {
            this.symbol = 'W';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterX : Character
    {
        public CharacterX()
        {
            this.symbol = 'X';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterY : Character
    {
        public CharacterY()
        {
            this.symbol = 'Y';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }

    internal class CharacterZ : Character
    {
        // Constructor
        public CharacterZ()
        {
            this.symbol = 'Z';
            this.height = 100;
            this.width = 100;
            this.ascent = 68;
            this.descent = 0;
        }
    }

    #endregion

    #region Lower Case Letters

    class Charactera : Character
    {
        public Charactera()
        {
            this.symbol = 'a';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterb : Character
    {
        public Characterb()
        {
            this.symbol = 'b';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterc : Character
    {
        public Characterc()
        {
            this.symbol = 'c';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterd : Character
    {
        public Characterd()
        {
            this.symbol = 'd';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Charactere : Character
    {
        public Charactere()
        {
            this.symbol = 'e';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterf : Character
    {
        public Characterf()
        {
            this.symbol = 'f';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterg : Character
    {
        public Characterg()
        {
            this.symbol = 'g';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterh : Character
    {
        public Characterh()
        {
            this.symbol = 'h';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characteri : Character
    {
        public Characteri()
        {
            this.symbol = 'i';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterj : Character
    {
        public Characterj()
        {
            this.symbol = 'j';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterk : Character
    {
        public Characterk()
        {
            this.symbol = 'k';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterl : Character
    {
        public Characterl()
        {
            this.symbol = 'l';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterm : Character
    {
        public Characterm()
        {
            this.symbol = 'm';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Charactern : Character
    {
        public Charactern()
        {
            this.symbol = 'n';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Charactero : Character
    {
        public Charactero()
        {
            this.symbol = 'o';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterp : Character
    {
        public Characterp()
        {
            this.symbol = 'p';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterq : Character
    {
        public Characterq()
        {
            this.symbol = 'q';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterr : Character
    {
        public Characterr()
        {
            this.symbol = 'r';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characters : Character
    {
        public Characters()
        {
            this.symbol = 's';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Charactert : Character
    {
        public Charactert()
        {
            this.symbol = 't';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characteru : Character
    {
        public Characteru()
        {
            this.symbol = 'u';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterv : Character
    {
        public Characterv()
        {
            this.symbol = 'v';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterw : Character
    {
        public Characterw()
        {
            this.symbol = 'w';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterx : Character
    {
        public Characterx()
        {
            this.symbol = 'x';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Charactery : Character
    {
        public Charactery()
        {
            this.symbol = 'y';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Characterz : Character
    {
        public Characterz()
        {
            this.symbol = 'z';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }

    #endregion

    #region Digits


    class Character0 : Character
    {
        public Character0()
        {
            this.symbol = '0';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character1 : Character
    {
        public Character1()
        {
            this.symbol = '1';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character2 : Character
    {
        public Character2()
        {
            this.symbol = '2';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character3 : Character
    {
        public Character3()
        {
            this.symbol = '3';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character4 : Character
    {
        public Character4()
        {
            this.symbol = '4';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character5 : Character
    {
        public Character5()
        {
            this.symbol = '5';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character6 : Character
    {
        public Character6()
        {
            this.symbol = '6';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character7 : Character
    {
        public Character7()
        {
            this.symbol = '7';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character8 : Character
    {
        public Character8()
        {
            this.symbol = '8';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class Character9 : Character
    {
        public Character9()
        {
            this.symbol = '9';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }




    #endregion

    #region Punctuation

    class CharacterPeriod : Character
    {
        public CharacterPeriod()
        {
            this.symbol = '.';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterComma : Character
    {
        public CharacterComma()
        {
            this.symbol = ',';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterQuestionMark : Character
    {
        public CharacterQuestionMark()
        {
            this.symbol = '?';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterApostrophe : Character
    {
        public CharacterApostrophe()
        {
            this.symbol = '\'';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterQuote : Character
    {
        public CharacterQuote()
        {
            this.symbol = '"';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }


    class CharacterSpace : Character
    {
        public CharacterSpace()
        {
            this.symbol = ' ';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }

    class CharacterColon : Character
    {
        public CharacterColon()
        {
            this.symbol = ':';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }

    class CharacterSemiColon : Character
    {
        public CharacterSemiColon()
        {
            this.symbol = ';';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }

    class CharacterLeftBracket : Character
    {
        public CharacterLeftBracket()
        {
            this.symbol = '[';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }

    class CharacterRightBracket : Character
    {
        public CharacterRightBracket()
        {
            this.symbol = ']';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }

    class CharacterDash : Character
    {
        public CharacterDash()
        {
            this.symbol = '-';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
    }




    #endregion



}
