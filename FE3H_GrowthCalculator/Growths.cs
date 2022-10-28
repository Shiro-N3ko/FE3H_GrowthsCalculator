using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE3H_GrowthCalculator
{
    public class Growths
    {
        public Growths()
        {
            List<Class> classList = new List<Class>();
            List<Character> characterList = new List<Character>();
            isValid = false;
        }

        private List<Class> classList;
        private List<Character> characterList;
        public bool isValid { get; set; }
        public Class userClass { get; set; }
        public Character userChar { get; set; }

        private Character? getCharByName(string? name)
        {
            for (int i = 0; i < characterList.Count; i++)
            {
                if (characterList[i].Name == name)
                {
                    userChar = characterList[i];
                    return characterList[i];
                }
            }
            return null;
        }

        private Class? getClassByName(string? name)
        {
            for (int i = 0; i < classList.Count; i++)
            {
                if (classList[i].Name == name)
                {
                    userClass = classList[i];
                    return classList[i];
                }
            }
            return null;
        }

        public void setClassList(List<Class> classList_)
        {
            classList = classList_;
        }

        public void setCharacterList(List<Character> characterList_)
        {
            characterList = characterList_;
        }

        public bool isCharValid(string? name)
        {
            if (getCharByName(name) != null)
            {
                return true;
            }
            else
            {
                invalidChoice();
                return false;
            }
        }

        public bool isClassValid(string? name)
        {
            if (getClassByName != null)
            {
                return true;
            }
            else
            {
                invalidChoice();
                return false;
            }
        }

        private void invalidChoice()
        {
            Console.WriteLine("Error: Class/Char Not Found In Data!\nPlease Enter Again!");
        }
    }
}