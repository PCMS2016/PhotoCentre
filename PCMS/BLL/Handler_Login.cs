using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Login : IHandler_Login 
    {
        private IDBAccess_Login db = null;
        public Handler_Login()
        {
            db = new DBAccess_Login();
        }
        public void Login(Salesperson salesperson)
        {
            db.Login(salesperson);
        }

        public string Encrypt(string word)
        {
            string newWord = word;
            char[] characters = newWord.ToCharArray();

            for (int i = 0; i < characters.Length; i++ )
            {
                switch (characters[i])
                {
                    case 'a':
                        characters[i] = 'm';
                        break;
                    case 'b':
                        characters[i] = 'g';
                        break;
                    case 'c':
                        characters[i] = 'z';
                        break;
                    case 'd':
                        characters[i] = 'e';
                        break;
                    case 'e':
                        characters[i] = 'l';
                        break;
                    case 'f':
                        characters[i] = 'h';
                        break;
                    case 'g':
                        characters[i] = 'v';
                        break;
                    case 'h':
                        characters[i] = 'd';
                        break;
                    case 'i':
                        characters[i] = 'k';
                        break;
                    case 'j':
                        characters[i] = 'f';
                        break;
                    case 'k':
                        characters[i] = 'o';
                        break;
                    case 'l':
                        characters[i] = 'a';
                        break;
                    case 'm':
                        characters[i] = 't';
                        break;
                    case 'n':
                        characters[i] = 'i';
                        break;
                    case 'o':
                        characters[i] = 'b';
                        break;
                    case 'p':
                        characters[i] = 'n';
                        break;
                    case 'q':
                        characters[i] = 'c';
                        break;
                    case 'r':
                        characters[i] = 'j';
                        break;
                    case 's':
                        characters[i] = 'q';
                        break;
                    case 't':
                        characters[i] = 'p';
                        break;
                    case 'u':
                        characters[i] = 'x';
                        break;
                    case 'v':
                        characters[i] = 'y';
                        break;
                    case 'w':
                        characters[i] = 'r';
                        break;
                    case 'x':
                        characters[i] = 'w';
                        break;
                    case 'y':
                        characters[i] = 'u';
                        break;
                    case 'z':
                        characters[i] = 's';
                        break;
                    case ' ':
                        characters[i] = '0';
                        break;
                    case '1':
                        characters[i] = '3';
                        break;
                    case '2':
                        characters[i] = '"';
                        break;
                    case '3':
                        characters[i] = '$';
                        break;
                    case '4':
                        characters[i] = '6';
                        break;
                    case '5':
                        characters[i] = '*';
                        break;
                    case '6':
                        characters[i] = '%';
                        break;
                    case '7':
                        characters[i] = '9';
                        break;
                    case '8':
                        characters[i] = ')';
                        break;
                    case '9':
                        characters[i] = '1';
                        break;
                    case '0':
                        characters[i] = '#';
                        break;
                }
            }

            newWord = new string(characters);
            return newWord;
        }

    }
}
